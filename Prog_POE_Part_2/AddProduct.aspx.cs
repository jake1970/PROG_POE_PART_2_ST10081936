using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prog_POE_Part_2
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ddlProductType.Items.Count == 0)
            {

                List<string> productTypeList = new PROG_POE_DatabaseEntities().Products.Select(p => p.ProductType).Distinct().ToList();

                ddlProductType.Items.Clear();

                foreach (string i in productTypeList)
                {
                    // code block to be executed
                    ddlProductType.Items.Add(i);
                }
            }



        }


        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            PROG_POE_DatabaseEntities DataHold = new PROG_POE_DatabaseEntities();
            Product newProduct = new Product();

            newProduct.ProductName = iptProductName.Text;
            newProduct.ProductDescription = iptProductDescription.Text;
            newProduct.DateAdded = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd"));
            newProduct.Quantity = int.Parse(iptProductQuantity.Text);
            newProduct.ProductType = ddlProductType.SelectedItem.ToString();

            DataHold.Products.Add(newProduct);
            DataHold.SaveChanges();

            int passID = newProduct.ProductID;

            FarmerProductList newProductFarmerLink = new FarmerProductList();
            newProductFarmerLink.FarmerID = int.Parse(Request.QueryString["Parameter"]);
            newProductFarmerLink.ProductID = passID;

            DataHold.FarmerProductLists.Add(newProductFarmerLink);
            DataHold.SaveChanges();



        }


    }
}