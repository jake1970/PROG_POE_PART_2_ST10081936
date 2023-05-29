using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prog_POE_Part_2
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Log in




            try
            {
                PasswordManager ManageSignIn = new PasswordManager();
                PROG_POE_DatabaseEntities DataHold = new PROG_POE_DatabaseEntities();

                //var test = DataHold.LoginDatas.Find(iptUsername.Text);

                LoginData userAttempt = new PROG_POE_DatabaseEntities().LoginDatas.SingleOrDefault(LoginData => LoginData.Username == iptUsername.Text);

                if (userAttempt != null)
                {

                    string actualSalt = userAttempt.Salt.ToString();
                    string actualHash = userAttempt.Hash.ToString();
                    string attemptPassword = iptPassword.Text;

                    bool userExists = ManageSignIn.VerifyPassword(attemptPassword, actualHash, actualSalt);

                    if (userExists == true)
                    {
                        Response.Redirect("Overview.aspx?Parameter=" + userAttempt.LoginID.ToString());
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "showError", "alert(User does not exist);", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "showError", "alert(User does not exist);", true);
                }


            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "showError", "alert(User does not exist);", true);
            }
            //show message kinda
            // ScriptManager.RegisterStartupScript(Page, Page.GetType(), "showError", "alert('" + test + "');", true);//userAttempt.LoginID.ToString()
        }

    }
}