<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProducts.aspx.cs" Inherits="Prog_POE_Part_2.ViewProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Overview</title>

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

            <div class="center-content">
            <asp:Label ID="lblWelcome" runat="server" Text="Your products," Font-Size="XX-Large" ForeColor="Black"></asp:Label>
             </div>

            

            <hr/>

            <asp:GridView ID="GridView1" runat="server" DataSourceID="ProductsSource"></asp:GridView>

            <div class="center-content" style="margin-top: 10pt">

            

             
               
            
            <asp:Label ID="lblFarmerSelector" runat="server" Text="Farmer Filter: " Font-Size="Large" ForeColor="Black"></asp:Label>
                <asp:DropDownList ID="ddlFarmerFilter" runat="server"></asp:DropDownList>
                <asp:Button ID="btnConfirmFarmerFilter" runat="server" Text="✔" Height="20px" Width="20px" CssClass="button_rounded" BorderStyle="None" OnClick="btnConfirmFarmerFilter_Click" />
                





                <div class="center-content">
            <asp:Label ID="lblProductTypeSelector" runat="server" Text="Product Type Filter: " Font-Size="Large" ForeColor="Black"></asp:Label>
            <asp:DropDownList ID="ddlProductTypeFilter" runat="server"></asp:DropDownList>
</div>
               <hr/>

             <div class="center-content">
            <asp:Label ID="lblDateRangeHeader" runat="server" Text="Date Range Filter: " Font-Size="Large" ForeColor="Black"></asp:Label>
            

</div>
           

            <div class="center-content">
            <asp:Label ID="lblDateRangeStart" runat="server" Text="Date From: " Font-Size="Large" ForeColor="Black"></asp:Label>
                <asp:TextBox ID="dpStart" runat="server" textmode="Date"></asp:TextBox>
               
            

</div>

              <div class="center-content">
            <asp:Label ID="lblDateRangeEnd" runat="server" Text="Date Till: " Font-Size="Large" ForeColor="Black"></asp:Label>
                  <asp:TextBox ID="dpEnd" runat="server" textmode="Date"></asp:TextBox>
                  
            

</div>
        

             <div class="center-content" style="margin-top: 16pt">
                 <asp:Button ID="btnClearFilters" runat="server" Text="Clear All Filters" Height="30px" Width="150px" CssClass="button_rounded" BorderStyle="None" OnClick="btnManageFarmers_Click" />

             </div>
          
               
            
            <asp:SqlDataSource ID="ProductsSource" runat="server" ConnectionString="<%$ ConnectionStrings:POE_DB %>" SelectCommand="SELECT * FROM Product"></asp:SqlDataSource>
         
        </div>
         

    </form>
</body>
</html>