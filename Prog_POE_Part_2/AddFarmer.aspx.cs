using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prog_POE_Part_2
{
    public partial class AddFarmer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            PROG_POE_DatabaseEntities DataHold = new PROG_POE_DatabaseEntities();


        }


        protected void btnAddFarmer_Click(object sender, EventArgs e)
        {


            PasswordManager newFarmerUser = new PasswordManager();
            PROG_POE_DatabaseEntities DataHold = new PROG_POE_DatabaseEntities();


            bool checkPassword = newFarmerUser.passwordMatch(iptPassword.Text, iptConfirmPassword.Text);
            if (checkPassword == true)
            {
                //if passwords match

                byte[] genSalt = newFarmerUser.CreateSalt();

                string genHash = newFarmerUser.CreateHash(iptPassword.Text, genSalt);

                //add login
                try
                {
                   
                    LoginData newLogin = new LoginData();
                   

                    newLogin.Username = iptUsername.Text;
                    newLogin.Hash = genHash.ToString();
                    newLogin.Salt = Convert.ToBase64String(genSalt);

                    DataHold.LoginDatas.Add(newLogin);
                    DataHold.SaveChanges();

                    int passID = newLogin.LoginID;


                    Farmer newFarmer = new Farmer();

                    newFarmer.FirstName = iptFirstName.Text;
                    newFarmer.LastName = iptLastName.Text;
                    newFarmer.EmailAddress = iptEmail.Text;
                    newFarmer.PhoneNumber = iptPhone.Text;
                    newFarmer.StreetAddress = iptStreet.Text;
                    newFarmer.City = iptCity.Text;
                    newFarmer.LoginID = passID;

                    DataHold.Farmers.Add(newFarmer);
                    DataHold.SaveChanges();

                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "showError", "alert(Input Error);", true);
                }



            }
            else
            {
                //if passwords dont match
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "showError", "alert(Passwords Dont Match);", true);
            }


        }





    }
}