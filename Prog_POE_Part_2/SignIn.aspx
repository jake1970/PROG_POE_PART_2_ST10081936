<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="Prog_POE_Part_2.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>

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
            <asp:Label ID="lblWelcome" runat="server" Text="Welcome to Farm Central" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
             </div>

            <div class="center-content">
            <asp:Image ID="imgLogo" runat="server" ImageUrl="images/Farm_Central_Logo.png" Height="200px" Width="200px" />
                </div>

             <div class="center-content">
            <asp:Label ID="lblUsername" runat="server" Text="Username" Font-Size="Large" ForeColor="Black"></asp:Label>
             </div>

                <div class="center-content"  style="margin-top:5px">
            <asp:TextBox ID="iptUsername" runat="server"></asp:TextBox>
                    </div>

             <div class="center-content" style="margin-top:10px">
            <asp:Label ID="lblPassword" runat="server" Text="Password" Font-Size="Large" ForeColor="Black"></asp:Label>
             </div>

                    <div class="center-content"  style="margin-top:5px">
            <asp:TextBox ID="iptPassword" runat="server" TextMode="Password"></asp:TextBox>
                        </div>

                        <div class="center-content" style="margin-top:20px">
                            <asp:Button ID="btnLogin" runat="server" Text="Login" Height="30px" Width="150px" CssClass="button_rounded" BorderStyle="None" OnClick="btnLogin_Click" />
                            </div>
         
        </div>

    </form>
</body>
</html>

