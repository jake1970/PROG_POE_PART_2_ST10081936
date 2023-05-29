<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Prog_POE_Part_2.AddProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Product</title>

             <style>
    body {
      background-color: #33475b;
      display: flex;
      align-items: center;
      justify-content: center;
      height: 100vh;
      margin: 0;
      padding: 0;
    }

    .container {
      background-color: white;
      padding: 20px;
      border-radius: 5px;
      box-shadow: 0 0 10px rgba(0, 0, 0, 0.3);
    }

    .center-content {
      text-align: center;
    }


    .button_rounded {
            background-color: #008CBA;
            color: #ffffff;
            border-radius: 8px;
        }
  </style>

</head>
<body>
    <form id="form1" runat="server">
       

             <div class="container">

               <div class="center-content" style="margin-bottom: 10pt">

                 

            <asp:Label ID="lblWelcome" runat="server" Text="Add New Product" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
             </div>

           <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="lblUsername" runat="server" Text="Product Name" Font-Size="Large" ForeColor="Black"></asp:Label>

            <asp:TextBox ID="iptProductName" runat="server"></asp:TextBox>                   
             </div>

            <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="Label1" runat="server" Text="Description" Font-Size="Large" ForeColor="Black"></asp:Label>

                <asp:TextBox ID="iptProductDescription" runat="server" Height="50pt"></asp:TextBox>                   
             </div>

            <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="Label2" runat="server" Text="Quantity" Font-Size="Large" ForeColor="Black"></asp:Label>

            <asp:TextBox ID="iptProductQuantity" runat="server" TextMode="Number"></asp:TextBox>                   
             </div>

             <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="Label3" runat="server" Text="Product Type" Font-Size="Large" ForeColor="Black"></asp:Label>

          
                 <asp:DropDownList ID="ddlProductType" runat="server" ></asp:DropDownList>
                 <asp:Button ID="Button2" runat="server" Text="+" Height="20px" Width="20px" CssClass="button_rounded" BorderStyle="None" />
             </div>

             

            <div class="center-content" style="margin-top: 10pt">
                <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" Height="30px" Width="150px" CssClass="button_rounded" BorderStyle="None" OnClick="btnAddProduct_Click" />

            </div>
                 
               
             </div>
        
        
    </form>
</body>
</html>
