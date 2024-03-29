﻿using EDP_Clinic.App_Code;
using EDP_Clinic.EDP_DBReference;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace EDP_Clinic
{
    public partial class addCardInfo : System.Web.UI.Page
    {
        byte[] Key;
        byte[] IV;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Checks user session
            if (Session["LoggedIn"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            {
                if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    Response.Redirect("~/Login.aspx", false);
                }
                //User session exists
                else
                {
                    //  Checks if user pass is to add card info
                    if (Session["authOTPAToken"] != null && Request.Cookies["authOTPAToken"] != null)
                    {
                        if (!Session["authOTPAToken"].ToString().Equals(Request.Cookies["authOTPAToken"].Value))
                        {
                            Response.Redirect("~/CardList.aspx", false);
                        }
                        else
                        {
                            //Nothing to put here since all credentials are there
                            Debug.WriteLine("Valid Credentials to add card info");
                        }
                    }
                    else
                    {
                        Response.Redirect("~/CardList.aspx", false);
                    }
                }
            }
            //No credentials at all
            else
            {
                Response.Redirect("~/Login.aspx", false);
            }
        }
        private bool ValidateInput()
        {
            DateTime currentDate = DateTime.Now;
            var greenColor = Color.Green;

            //Checks if card name is empty
            if (String.IsNullOrEmpty(nameOnCardTB.Text))
            {
                nameOnCardError.Text = "Please enter name on card";
                nameOnCardError.ForeColor = Color.Red;
                nameOnCardError.Visible = true;
            }
            else if (!Regex.IsMatch(nameOnCardTB.Text, "^[a-zA-Z0-9 ]*$"))
            {
                nameOnCardError.Text = "Please enter valid card name";
                nameOnCardError.ForeColor = Color.Red;
                nameOnCardError.Visible = true;
            }
            else
            {
                nameOnCardError.Text = "Excellent";
                nameOnCardError.ForeColor = Color.Green;
                nameOnCardError.Visible = true;
            }

            //checks if card number is actually numbers     
            //checks if there is other character other than numbers
            if (!Regex.IsMatch(cardNumberTB.Text, "^[0-9]*$"))
            {
                //cardNumberError.Text = "Testing";
                cardNumberError.Text = "Please enter a valid card number";
                cardNumberError.ForeColor = Color.Red;
                cardNumberError.Visible = true;
            }
            //checks if its empty or null
            else if (String.IsNullOrEmpty(cardNumberTB.Text))
            {
                cardNumberError.Text = "Please enter card number";
                cardNumberError.ForeColor = Color.Red;
                cardNumberError.Visible = true;
            }
            else if (cardNumberTB.Text.Length > 16)
            {
                cardNumberError.Text = "Please enter a valid card number";
                cardNumberError.ForeColor = Color.Red;
                cardNumberError.Visible = true;
            }
            else
            {
                cardNumberError.Text = "Excellent";
                cardNumberError.ForeColor = Color.Green;
                cardNumberError.Visible = true;
            }

            //Checks Card CVV Number
            if (!Regex.IsMatch(CVVTB.Text, "^[0-9]*$"))
            {
                CVVError.Text = "Please enter a valid CVV number";
                CVVError.ForeColor = Color.Red;
                CVVError.Visible = true;
            }
            //checks if its empty or null
            else if (String.IsNullOrEmpty(CVVTB.Text))
            {
                CVVError.Text = "Please enter CVV number";
                CVVError.ForeColor = Color.Red;
                CVVError.Visible = true;
            }
            else if (CVVTB.Text.Length != 3)
            {
                CVVError.Text = "Please enter a 3 digit CVV number";
                CVVError.ForeColor = Color.Red;
                CVVError.Visible = true;
            }
            else
            {
                CVVError.Text = "Excellent";
                CVVError.ForeColor = Color.Green;
                CVVError.Visible = true;
            }

            //Checks if card expiry date is chosen or not
            if (String.IsNullOrEmpty(cardExpiryTB.Text))
            {
                cardExpiryError.Text = "Please select card expiry date";
                cardExpiryError.ForeColor = Color.Red;
                cardExpiryError.Visible = true;
            }
            else
            {
                DateTime inputDate = Convert.ToDateTime(cardExpiryTB.Text);
                double monthDifference = inputDate.Subtract(currentDate).Days / (365.25 / 12);
                if (monthDifference < 3)
                {
                    cardExpiryError.Text = "Please ensure that your expiry date is at least 3 months from current date";
                    cardExpiryError.ForeColor = Color.Red;
                    cardExpiryError.Visible = true;
                }
                else
                {
                    cardExpiryError.Text = "Excellent";
                    cardExpiryError.ForeColor = Color.Green;
                    cardExpiryError.Visible = true;
                }
            }

            //checks if any error labels is green or not
            if (cardNumberError.ForeColor == greenColor
                && nameOnCardError.ForeColor == greenColor
                && cardExpiryError.ForeColor == greenColor
                && CVVError.ForeColor == greenColor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Update button is actually add card btn
        protected void addBtn_Click(object sender, EventArgs e)
        {
            string captchaResponse = Request.Form["g-recaptcha-response"];
            RecaptchaValidation validCaptcha = new RecaptchaValidation();

            bool validInput = ValidateInput();

            bool captchaResult = validCaptcha.ValidateCaptcha(captchaResponse);

            //checks if all input has been validated
            if (validInput == true && captchaResult == true)
            {
                //Will add another if else statement to check if card number already exists or not
                RijndaelManaged cipher = new RijndaelManaged();
                cipher.GenerateKey();
                Key = cipher.Key;
                IV = cipher.IV;

                Service1Client client = new Service1Client();
                bool resultCheck = client.CheckCardByCardNumber(cardNumberTB.Text.Trim());
                //Checks if there is an existing card here
                //It will return true if there is 2 cards here
                if (resultCheck == true)
                {
                    cardNumberError.Text = "Please enter a valid card information";
                    cardNumberError.Visible = true;
                    cardNumberError.ForeColor = Color.Red;
                    Debug.WriteLine("Card existed in database");
                }
                else
                {
                    string guid = Guid.NewGuid().ToString();
                    Debug.WriteLine(guid);
                    string cardNumberInput = cardNumberTB.Text.Trim().Substring(12, 4);
                    string uniqueIdentifier = cardNumberInput + "-" + guid;
                    Debug.WriteLine(uniqueIdentifier);
                    string userID = Session["LoggedIn"].ToString().Trim();

                    //Service1Client client = new Service1Client();
                    int result = client.CreateCardInfo(userID, nameOnCardTB.Text.Trim(), cardNumberTB.Text.Trim(),
                        Convert.ToDateTime(cardExpiryTB.Text), CVVTB.Text.Trim(), IV, Key, true, uniqueIdentifier);

                    if (result == 1)
                    {
                        //Remove pass to add card info
                        Session.Remove("authOTPAToken");
                        Response.Cookies["authOTPAToken"].Value = string.Empty;
                        Response.Cookies["authOTPAToken"].Expires = DateTime.Now.AddMonths(-20);

                        Response.Redirect("CardList.aspx");
                    }
                    else
                    {
                        errorMsg.Text = "Please enter valid information";
                    }
                }
            }
            else
            {
                nameOnCardError.Visible = true;
                cardNumberError.Visible = true;
                cardExpiryError.Visible = true;
                CVVError.Visible = true;
            }
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            //Remove pass to add card info
            Session.Remove("authOTPAToken");
            Response.Cookies["authOTPAToken"].Value = string.Empty;
            Response.Cookies["authOTPAToken"].Expires = DateTime.Now.AddMonths(-20);

            //TwilioSMS();
            Response.Redirect("~/CardList.aspx", false);
        }

        protected void TwilioSMS()
        {
            Debug.WriteLine("Calling Twilio SMS Function");
            //Retrieve keys from web.config
            NameValueCollection myKeys = ConfigurationManager.AppSettings;

            //Reading keys
            var twilioAccSid = myKeys["TWILIO_ACCOUNT_SID"];
            var twilioAuth = myKeys["TWILIO_AUTH_TOKEN"];
            //const string serviceSid = "IS118b50a34ccf7d845af153585b800f7b";

            TwilioClient.Init(twilioAccSid, twilioAuth);
            //(205) 946 - 1964
            //  + 1 213 279 6783
            var message = MessageResource.Create(
            body: "Dear user, you have successfully added a card information.",
            from: new Twilio.Types.PhoneNumber("+12132796783"),
            to: new Twilio.Types.PhoneNumber("+6590251744")
        );
            Debug.WriteLine(message.Sid);
        }
    }
}