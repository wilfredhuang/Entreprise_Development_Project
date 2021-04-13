﻿using EDP_Clinic.EDP_DBReference;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EDP_Clinic
{
    public partial class AdminPage : System.Web.UI.Page
    {
        readonly Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] == null)
            {
                Response.Redirect("~/Login.aspx", false);
            }
            else
            {
                if (Session["UserRole"].ToString() != "Admin")
                {
                    Response.Redirect("~/Home.aspx", false);
                }
            }
            refreshgrid();
        }
        protected void EmployeeGridView_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "changeinfo")
            {
                // Convert the row index stored in the CommandArgument
                // property to an Integer.
                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow selectedRow = EmployeeGridView.Rows[index];
                string id = selectedRow.Cells[0].Text;
                Debug.WriteLine(id);
                editLbl.Text = id;
                User employee = client.GetOneUser(id);
                tbEditName.Text = employee.Name;
                tbEditEmail.Text = employee.Email;
                tbEditMobile.Text = employee.PhoneNo;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Yes", "openEditModal();", true);
            }
            if (e.CommandName == "deleteinfo")
            {
                Debug.WriteLine("delete clicked");

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = EmployeeGridView.Rows[index];
                var deleteid = selectedRow.Cells[3].Text;
                delLbl.Text = deleteid;
                Debug.WriteLine(deleteid);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ok", "openDeleteModal();", true);
            }
        }
        protected void delBtn_Click(object sender, EventArgs e)
        {
            var id = delLbl.Text;
            try
            {
                var result = client.DeleteOneUser(id);
                if (result == 1)
                {
                    Debug.WriteLine("success");
                }
                else
                {
                    Debug.WriteLine("rip u screwed up");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            refreshgrid();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Yes", "closeDeleteModal();", true);
        }
        protected void editBtn_Click(object sender, EventArgs e)
        {
            string name = HttpUtility.HtmlEncode(tbEditName.Text.Trim());
            string email = HttpUtility.HtmlEncode(tbEditEmail.Text.Trim());
            string mobile = HttpUtility.HtmlEncode(tbEditMobile.Text.Trim());
            string id = HttpUtility.HtmlEncode(editLbl.Text.Trim());
            // var user = client.GetOneUserByEmail(email);
            if (name == "")
            {
                editError.Text = "Enter name";
                editError.ForeColor = Color.Red;
                editError.Visible = true;
                return;
            }
            if (!IsValidEmail(email))
            {
                editError.Text = "Enter proper email";
                editError.ForeColor = Color.Red;
                editError.Visible = true;
                return;
            }
            else
            {
                var exist = client.CheckOneUser(email);
                if (exist == 1)
                {
                    editError.Text = "Email already in use";
                    editError.ForeColor = Color.Red;
                    editError.Visible = true;
                }
            }
            if (!Regex.IsMatch(mobile, @"\d{8}"))
            {
                editError.Text = "Enter proper phone number";
                editError.ForeColor = Color.Red;
                editError.Visible = true;
            }
            else
            {
                var exist = client.CheckPhoneNo(mobile);
                if (exist == 1)
                {
                    editError.Text = "Phone number already in use";
                    editError.ForeColor = Color.Red;
                    editError.Visible = true;
                }
            }
            try
            {
                var result = client.EditOneUser(id, name, email, mobile);
                if (result == 1)
                {
                    Debug.WriteLine("success");
                }
                else
                {
                    Debug.WriteLine("edit error");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            refreshgrid();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Yes", "closeEditModal();", true);

        }
        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            string search = HttpUtility.HtmlEncode(searchtb.Text.Trim());
            // List<User> userlist = new List<User>();
            // patientList = client.ShowAllPatients().ToList<displayUser>();
            List<displayUser> patientList = client.ShowSearchedEmployees(search).ToList<displayUser>();
            EmployeeGridView.Visible = true;
            EmployeeGridView.DataSource = patientList;
            EmployeeGridView.DataBind();

        }
        protected void RefreshBtn_Click(object sender, EventArgs e)
        {
            refreshgrid();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = tbAddEmail.Text;
            string name = tbAddName.Text;
            string mobile = tbAddMobile.Text;
            string role = AddRole.SelectedValue.ToString();
            if (email == "" || name == "" || mobile == "")
            {
                //add error msg for modal
                return;
            }
            else
            {
                var valid = IsValidEmail(email);
                if (!valid)
                {
                    return;
                }
                else
                {
                    var exist = client.CheckOneUser(email);
                    if (exist == 1)
                    {
                        addError.Text = "Email already exists";
                        addError.ForeColor = Color.Red;
                        return;
                    }
                    var exist2 = client.CheckPhoneNo(mobile);
                    if (exist2 == 1)
                    {
                        addError.Text = "Phone Number in use";
                        addError.ForeColor = Color.Red;
                        return;
                    }
                    RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                    byte[] saltByte = new byte[8];
                    rng.GetBytes(saltByte);
                    var salt = Convert.ToBase64String(saltByte);
                    var result = client.AddOneUser(name, "placeholder", salt, email, mobile, role, "No");
                    if (result == 0)
                    {
                        return;
                    }
                    else
                    {
                        tbAddEmail.Text = "";
                        tbAddName.Text = "";
                        tbAddMobile.Text = "";
                        string code = makeCode();
                        client.AddCode(email, code);
                        string link = "https://localhost:44310/EmployeePasswordSet.aspx?value=" + code;
                        SmtpClient emailClient = new SmtpClient("smtp-relay.sendinblue.com", 587)
                        {
                            Credentials = new System.Net.NetworkCredential("bryanchinzw@gmail.com", "vPDBKArZRY7HcIJC"),
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            EnableSsl = true
                        };
                        MailMessage mail = new MailMessage
                        {
                            Subject = "Set Password (MedPill)",
                            SubjectEncoding = System.Text.Encoding.UTF8,
                            Body = "Please Click link to change password <br> <a>" + link + "</a>",
                            IsBodyHtml = true,
                            Priority = MailPriority.High,
                            From = new MailAddress("bryanchinzw@gmail.com")
                        };
                        mail.To.Add(new MailAddress(email));
                        try
                        {
                            emailClient.Send(mail);
                        }
                        catch (SmtpFailedRecipientException ex)
                        {
                            Debug.WriteLine(ex);
                        }
                    }
                }
            }
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public void refreshgrid()
        {
            // List<User> userlist = new List<User>();
            //patientList = client.ShowAllPatients().ToList<displayUser>();
            List<displayUser> patientList = client.ShowAllEmployees().ToList<displayUser>();
            EmployeeGridView.Visible = true;
            EmployeeGridView.DataSource = patientList;
            EmployeeGridView.DataBind();
        }
        public string makeCode()
        {
            var exist = 1;
            string r = "yes";
            while (exist == 1)
            {
                Random generator = new Random();
                r = generator.Next(0, 1000000).ToString("D6");
                exist = client.CheckCodeExist(r);
            }
            return r;
        }
    }
}