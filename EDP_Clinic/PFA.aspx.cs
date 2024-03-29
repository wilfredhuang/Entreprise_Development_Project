﻿using EDP_Clinic.EDP_DBReference;
using System;
using System.Diagnostics;
using System.Web.UI;

namespace EDP_Clinic
{
    public partial class PFA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] != null)
            {
                LoadProfile();
            }
            else
            {
                Response.Redirect("404.aspx", false);
            }
        }

        protected void LoadProfile()
        {
            Service1Client client = new Service1Client();

            Debug.WriteLine("SESSION EMAIL IS " + Session["LoggedIn"].ToString());

            User userobj = client.GetOneUserByEmail(Session["LoggedIn"].ToString());

            Debug.WriteLine("USER ID IS " + userobj.Id);

            Photo photo_obj = client.GetOnePhoto(userobj.Id);

            if (userobj != null)
            {
                //lbl_profileName.Text = "NAME: " + userobj.Name;
                lbl_profileName.Text = userobj.Name;
                // Need to trim the string variable, or the image url will not display properly due to encoded whitespaces %20%20
                //userPfp.ImageUrl = $"~/assets/images/{photo_obj.Photo_Resource.Trim()}.jpg";

                var exist = client.CheckPhotoExist(userobj.Id);
                if (exist == 1)
                {
                    var photo = client.GetOnePhoto(userobj.Id);
                    var fileName = photo.Photo_Resource.ToString();
                    var path = "~/UserImg/" + fileName;
                    userPfp.ImageUrl = path;
                }
                else
                {
                    userPfp.ImageUrl = "https://icon-library.com/images/default-profile-icon/default-profile-icon-16.jpg";
                }

                //System.Diagnostics.Debug.WriteLine("CARE GIVER ID IS " + userobj.Id);
                Caregiver caregiver_obj = client.GetOneCG(userobj.Id);

                if (caregiver_obj != null)
                {
                    //Debug.WriteLine("CARE RECEIVER ID IS " + caregiver_obj.Carereceiver_id);
                    User care_receiverobj = client.GetOneUser(caregiver_obj.Carereceiver_id);
                    //Debug.WriteLine("CARE RECEIVER NAME IS " + care_receiverobj.Name);
                    //Debug.WriteLine("CARE RECEIVER ID IS " + care_receiverobj.Id);

                    Photo photo_obj_cr = client.GetOnePhoto(caregiver_obj.Carereceiver_id);

                    if (care_receiverobj != null)
                    {
                        lbl_crName.Text = care_receiverobj.Name;
                        //crPfp.ImageUrl = $"~/assets/images/{photo_obj_cr.Photo_Resource.Trim()}.jpg";
                        var exist2 = client.CheckPhotoExist(care_receiverobj.Id);
                        if (exist2 == 1)
                        {
                            var photo = client.GetOnePhoto(care_receiverobj.Id);
                            var fileName = photo.Photo_Resource.ToString();
                            var path = "~/UserImg/" + fileName;
                            crPfp.ImageUrl = path;
                        }
                    }
                    else
                    {
                        crPfp.Visible = false;
                        crArrow.Visible = false;
                        lbl_crName.Text = "You do not have any care receivers";
                    }
                }
                else
                {
                    crPfp.Visible = false;
                    crArrow.Visible = false;
                    lbl_crName.Text = "You do not have any care receivers";
                }
            }
        }

        protected void View_Appt_Patient(object sender, ImageClickEventArgs e)
        {
            Service1Client client = new Service1Client();
            User userobj = client.GetOneUserByEmail(Session["LoggedIn"].ToString());
            Session["current_appt_profile"] = userobj.Id;
            Response.Redirect("~/PRFA2.aspx");
        }

        protected void View_Appt_CR(object sender, ImageClickEventArgs e)
        {
            Service1Client client = new Service1Client();
            User userobj = client.GetOneUserByEmail(Session["LoggedIn"].ToString());
            Caregiver caregiver_obj = client.GetOneCG(userobj.Id);
            User care_receiverobj = client.GetOneUser(caregiver_obj.Carereceiver_id);

            Session["current_appt_profile"] = care_receiverobj.Id;
            Response.Redirect("~/PRFA2.aspx");
        }
    }
}