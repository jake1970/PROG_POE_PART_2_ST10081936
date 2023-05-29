using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prog_POE_Part_2
{
    public partial class Overview : System.Web.UI.Page
    {

        private int currentUserID;
        private bool isFarmer = false;

        public int CurrentUserID { get => currentUserID; set => currentUserID = value; }
        public bool IsFarmer { get => isFarmer; set => isFarmer = value; }

        protected void Page_Load(object sender, EventArgs e)
        {


            PROG_POE_DatabaseEntities DataHold = new PROG_POE_DatabaseEntities();

            CurrentUserID = int.Parse(Request.QueryString["Parameter"]);

            DataHold.LoginDatas.Find(CurrentUserID);


            Employee registeredEmployee = new PROG_POE_DatabaseEntities().Employees.SingleOrDefault(Employee => Employee.LoginID == CurrentUserID);
            Farmer registeredFarmer = new PROG_POE_DatabaseEntities().Farmers.SingleOrDefault(Farmer => Farmer.LoginID == CurrentUserID);
            LoginData registeredUser = new PROG_POE_DatabaseEntities().LoginDatas.SingleOrDefault(LoginData => LoginData.LoginID == CurrentUserID);

            //  ScriptManager.RegisterStartupScript(Page, Page.GetType(), "showError", "alert('" + registeredEmployee.FirstName.ToString() + " " + registeredFarmer.FirstName.ToString() + "');", true);//userAttempt.LoginID.ToString()

            lblName.Text = registeredUser.Username.ToString();

            if (registeredEmployee != null)
            {
                //if employee

                lblWelcome.Text = "Welcome back employee,";

                //hide farmer elements
                lblFullAddress.Visible = false;
                btnAddProduct.Visible = false;

                lblFullName.Text = "Name: " + registeredEmployee.FirstName.ToString() + " " + registeredEmployee.LastName.ToString();
                lblEmail.Text = "Email: " + registeredEmployee.EmailAddress.ToString();
                lblPhoneNumber.Text = "Phone Number: " + registeredEmployee.PhoneNumber.ToString();
                isFarmer = false;
                btnViewProducts.Text = "View Products";

            }
            else
            {

                if (registeredFarmer != null)
                {
                    //if farmer

                    lblWelcome.Text = "Welcome back farmer,";

                    //hide employee elements
                    lblFullName.Text = "Name: " + registeredFarmer.FirstName.ToString() + " " + registeredFarmer.LastName.ToString();
                    lblEmail.Text = "Email: " + registeredFarmer.EmailAddress.ToString();
                    lblPhoneNumber.Text = "Phone Number: " + registeredFarmer.PhoneNumber.ToString();
                    lblFullAddress.Text = "Address: " + registeredFarmer.StreetAddress.ToString() + " " + registeredFarmer.City.ToString();
                    isFarmer = true;
                    btnViewProducts.Text = "View Your Products";
                    btnManageFarmers.Visible = false;
                }

            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {

            //get the farmer ID of user
            Farmer currentFarmer = new PROG_POE_DatabaseEntities().Farmers.SingleOrDefault(Farmer => Farmer.LoginID == currentUserID);

            Response.Redirect("AddProduct.aspx?Parameter=" + currentFarmer.FarmerID.ToString());

        }

        protected void btnViewProducts_Click(object sender, EventArgs e)
        {
            if (isFarmer == true)
            {
                Farmer currentFarmer = new PROG_POE_DatabaseEntities().Farmers.SingleOrDefault(Farmer => Farmer.LoginID == currentUserID);

                Response.Redirect("ViewProducts.aspx?Parameter=" + currentFarmer.FarmerID.ToString());
            }
            else
            {
                Response.Redirect("ViewProducts.aspx?Parameter=Employee");
            }

           

        }

        protected void btnManageFarmers_Click(object sender, EventArgs e)
        {

            Response.Redirect("ManageFarmers.aspx");
        }


        }
}