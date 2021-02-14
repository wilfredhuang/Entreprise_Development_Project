﻿using EDP_Clinic.EDP_DBReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EDP_Clinic
{
    public partial class Patient_view_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = "1";
            Details eList = new Details();
            EDP_DBReference.Service1Client client = new EDP_DBReference.Service1Client();
            eList = client.GetDetailsById(id);
            Name.Text = eList.Name;
            Nric.Text = eList.Nric;
            dob.Text = eList.Date_of_birth;
            Gender.Text = eList.Gender;
            Phone.Text = eList.Phone;
            Email.Text = eList.Email;
            Address.Text = eList.Address;
            Postal.Text = eList.Postal;

        }

        protected void btn_back_click(object sender, EventArgs e)
        {
            
        }

        protected void btn_update_click(object sender, EventArgs e)
        {
            string id = "1";
            string url = "Patient_update_details.aspx?id="+id;
            Response.Redirect(url);
        }
    }
}