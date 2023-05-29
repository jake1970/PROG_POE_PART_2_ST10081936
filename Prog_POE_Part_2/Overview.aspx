<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Overview.aspx.cs" Inherits="Prog_POE_Part_2.Overview" %>

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
            <asp:Label ID="lblWelcome" runat="server" Text="Welcome back," Font-Size="XX-Large" ForeColor="Black"></asp:Label>
             </div>

            <div class="center-content">
            <asp:Label ID="lblName" runat="server" Text="{Name}" Font-Size="X-Large" ForeColor="Black"></asp:Label>
             </div>

            <hr/>

             <div class="center-content" style="margin-top:10px>
            <asp:Label ID="lblFullName" runat="server" Text="Fullname" Font-Size="Large" ForeColor="Black"></asp:Label>
             </div> 

            
            <div class="center-content" style="margin-top:10px">
            <asp:Label ID="lblEmail" runat="server" Text="email" Font-Size="Large" ForeColor="Black"></asp:Label>
             </div>

            <div class="center-content" style="margin-top:10px">
            <asp:Label ID="lblPhoneNumber" runat="server" Text="PhoneNumber" Font-Size="Large" ForeColor="Black"></asp:Label>
             </div>

            <div class="center-content" style="margin-top:10px">
            <asp:Label ID="lblFullAddress" runat="server" Text="StreetAddress, city (farmer)" Font-Size="Large" ForeColor="Black"></asp:Label>
             </div>


                  

            <hr/>

                        <div class="center-content">
                            <asp:Button ID="btnViewProducts" runat="server" Text="View (your) products" Height="30px" Width="150px" CssClass="button_rounded" BorderStyle="None" OnClick="btnViewProducts_Click" />
                            <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" Height="30px" Width="150px" CssClass="button_rounded" BorderStyle="None" OnClick="btnAddProduct_Click" />
                            <asp:Button ID="btnManageFarmers" runat="server" Text="Manage Farmers" Height="30px" Width="150px" CssClass="button_rounded" BorderStyle="None" OnClick="btnManageFarmers_Click" />

                        </div>

            <hr/>
         
        </div>

    </form>
</body>
</html>

