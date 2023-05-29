<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFarmer.aspx.cs" Inherits="Prog_POE_Part_2.AddFarmer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Farmer</title>

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

                 

            <asp:Label ID="lblWelcome" runat="server" Text="Add New Farmer" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
             </div>

           <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="lblUsername" runat="server" Text="Username" Font-Size="Large" ForeColor="Black"></asp:Label>

            <asp:TextBox ID="iptUsername" runat="server"></asp:TextBox>                   
             </div>

            <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="Label1" runat="server" Text="Password" Font-Size="Large" ForeColor="Black"></asp:Label>

            <asp:TextBox ID="iptPassword" runat="server"></asp:TextBox>                   
             </div>


             <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="Label3" runat="server" Text="Confirm Password" Font-Size="Large" ForeColor="Black"></asp:Label>

            <asp:TextBox ID="iptConfirmPassword" runat="server"></asp:TextBox>                   
             </div>

             <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="Label4" runat="server" Text="First Name" Font-Size="Large" ForeColor="Black"></asp:Label>

            <asp:TextBox ID="iptFirstName" runat="server"></asp:TextBox>                   
             </div>

             <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="Label5" runat="server" Text="Last Name" Font-Size="Large" ForeColor="Black"></asp:Label>

            <asp:TextBox ID="iptLastName" runat="server"></asp:TextBox>                   
             </div>

             <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="Label6" runat="server" Text="Email Address" Font-Size="Large" ForeColor="Black"></asp:Label>

            <asp:TextBox ID="iptEmail" runat="server"></asp:TextBox>                   
             </div>

             <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="Label7" runat="server" Text="Phone Number" Font-Size="Large" ForeColor="Black"></asp:Label>

            <asp:TextBox ID="iptPhone" runat="server"></asp:TextBox>                   
             </div>
               

             <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="Label8" runat="server" Text="Street Address" Font-Size="Large" ForeColor="Black"></asp:Label>

            <asp:TextBox ID="iptStreet" runat="server"></asp:TextBox>                   
             </div>

             <div class="center-content" style="margin-top: 5pt">
            <asp:Label ID="Label9" runat="server" Text="City" Font-Size="Large" ForeColor="Black"></asp:Label>

            <asp:TextBox ID="iptCity" runat="server"></asp:TextBox>                   
             </div>

            <div class="center-content" style="margin-top: 10pt">
                <asp:Button ID="btnLogin" runat="server" Text="Submit" Height="30px" Width="150px" CssClass="button_rounded" BorderStyle="None" OnClick="btnAddFarmer_Click" />

            </div>

        </div>
    </form>
</body>
</html>
