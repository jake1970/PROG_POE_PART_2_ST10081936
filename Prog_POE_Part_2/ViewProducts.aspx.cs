using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;
using static System.Net.Mime.MediaTypeNames;

namespace Prog_POE_Part_2
{
    public partial class ViewProducts : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Parameter"] == "Employee")
            {
                //if employee viewing
                lblWelcome.Text = "Product Overview";

                if (ddlFarmerFilter.Items.Count == 0)
                {
                    //populate drop down boxes
                    List<string> farmerList = new PROG_POE_DatabaseEntities().Farmers.Select(p => p.FirstName + " " + p.LastName).ToList();

                    ddlFarmerFilter.Items.Clear();

                    ddlFarmerFilter.Items.Add("All");
                    foreach (string i in farmerList)
                    {
                        // code block to be executed
                        ddlFarmerFilter.Items.Add(i);
                    }
                }


                if (ddlProductTypeFilter.Items.Count == 0)
                {
                    List<string> productTypeList = new PROG_POE_DatabaseEntities().Products.Select(p => p.ProductType).Distinct().ToList();

                    ddlProductTypeFilter.Items.Clear();

                    ddlProductTypeFilter.Items.Add("All");
                    foreach (string i in productTypeList)
                    {
                        // code block to be executed
                        ddlProductTypeFilter.Items.Add(i);
                    }
                }

            }
            else
            {
                //if farmer viewing
                ProductsSource.SelectCommand = " SELECT Product.ProductName, Product.ProductDescription, Product.DateAdded, Product.Quantity, Product.ProductType FROM Product INNER JOIN FarmerProductList ON Product.ProductID = FarmerProductList.ProductID WHERE FarmerProductList.FarmerID = " + Request.QueryString["Parameter"];
                //Hide employee filters
                lblWelcome.Text = "Your Products";

                lblFarmerSelector.Visible = false;
                ddlFarmerFilter.Visible = false;
                lblProductTypeSelector.Visible = false;
                ddlProductTypeFilter.Visible = false;
                lblDateRangeHeader.Visible = false;
                lblDateRangeStart.Visible = false;
                dpStart.Visible = false;
                lblDateRangeEnd.Visible = false;
                dpEnd.Visible = false;
                btnClearFilters.Visible = false;
                btnConfirmFarmerFilter.Visible = false;



            }

        }

        protected void btnManageFarmers_Click(object sender, EventArgs e)
        {

            ddlFarmerFilter.Text = "All";
            ddlProductTypeFilter.Text = "All";

            ProductsSource.SelectCommand = "SELECT Product.ProductID, Product.ProductName, Product.ProductDescription, Product.DateAdded, Product.Quantity, Product.ProductType FROM Product";

        }

      
        
            protected void btnConfirmFarmerFilter_Click(object sender, EventArgs e)
            {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "showError", "alert('" + ddlFarmerFilter.Text + "');", true);
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "showError", "alert('" + ddlFarmerFilter.SelectedItem.Text + "');", true);

            if (ddlFarmerFilter.Text == "All")
            {
                ProductsSource.SelectCommand = "SELECT Product.ProductID, Product.ProductName, Product.ProductDescription, Product.DateAdded, Product.Quantity, Product.ProductType FROM Product";
            }
            else
            {
        
                string farmerFullName = ddlFarmerFilter.SelectedItem.Text;

         

            string[] farmerNameSplit = farmerFullName.Split(' ');

           
            string selectedFarmerFirstName = farmerNameSplit[0];
                string selectedFarmerLastName = farmerNameSplit[1];

            Farmer farmerToFilter = new PROG_POE_DatabaseEntities().Farmers.SingleOrDefault(Farmer => Farmer.FirstName == selectedFarmerFirstName || Farmer.LastName == selectedFarmerLastName);
                string selectedFarmerID = farmerToFilter.FarmerID.ToString();

             

                ProductsSource.SelectCommand = "SELECT Product.ProductName, Product.ProductDescription, Product.DateAdded, Product.Quantity, Product.ProductType FROM Product INNER JOIN FarmerProductList ON Product.ProductID = FarmerProductList.ProductID WHERE FarmerProductList.FarmerID = " + selectedFarmerID;


           }


        }
    }
}