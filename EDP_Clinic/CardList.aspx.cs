﻿using EDP_Clinic.EDP_DBReference;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EDP_Clinic
{
    public partial class CardList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["Login"] = "someone@example.com";

            //string guidToken = Guid.NewGuid().ToString();
            //Session["AuthToken"] = guidToken;
            //HttpCookie AuthToken = new HttpCookie("AuthToken");
            //AuthToken.Value = guidToken;
            //Response.Cookies.Add(AuthToken);


            //Checks user session
            if (Session["LoggedIn"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            {
                if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    Response.Redirect("Login.aspx", false);
                }
                else
                {
                    Debug.WriteLine("Retrieving card info");
                    retrieveCardInfo();
                }
            }
            //No credentials at all
            else
            {
                Response.Redirect("Login.aspx", false);
            }
        }

        /*byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }*/

        protected void retrieveCardInfo()
        {
            string userID = Session["LoggedIn"].ToString().Trim();

            List<CardInfo> cifList = new List<CardInfo>();
            Service1Client client = new Service1Client();
            cifList = client.GetAllCards(userID).ToList<CardInfo>();

            cardListView.Visible = true;
            cardListView.DataSource = cifList;
            cardListView.DataBind();


            //If user has less than 3 cards
            //Allow user to add more cards
            if (cifList.Count < 3)
            {
                addCardInfo.Enabled = true;
            }
            //Else disable button
            else
            {
                addCardInfo.Enabled = false;
            }
        }

        protected void moreBtn_Click(object sender, EventArgs e)
        {
            //string cardNumber = CommandArgument
            //Response.Redirect("Authentication.aspx?="); //+ ((LinkButton)sender).Text);
        }

        protected void addCardInfo_Click(object sender, EventArgs e)
        {
            //Create intention for user to add card info
            string guid = Guid.NewGuid().ToString();
            Session["addCardInfo"] = guid;

            Response.Cookies.Add(new HttpCookie("addCardInfo", guid));
            Response.Redirect("Authentication.aspx", false);
        }

        protected void cardListView_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            //Checks if button clicked is view more button
            if (String.Equals(e.CommandName, "viewMore"))
            {
                //Card number will be encrypted later on
                //For now, just pass a plain-text number
                //var cardNumber = ObjectToByteArray(e.CommandArgument);

                Session["UniqueIdentifier"] = e.CommandArgument.ToString();

                //Create intention for user to view card info
                string guid = Guid.NewGuid().ToString();
                Session["viewCardInfo"] = guid;

                Response.Cookies.Add(new HttpCookie("viewCardInfo", guid));
                Response.Redirect("Authentication.aspx", false);
                //Response.Redirect("PaymentInformation.aspx?cardNumber=" + e.CommandArgument);
            }
            //else if()

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserPage.aspx",false);
        }

    }
}