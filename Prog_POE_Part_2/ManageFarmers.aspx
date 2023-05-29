<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageFarmers.aspx.cs" Inherits="Prog_POE_Part_2.ManageFarmers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Farmers</title>

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

                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:POE_DB %>" SelectCommand="SELECT * FROM [Farmer]"></asp:SqlDataSource>

            <asp:Label ID="lblWelcome" runat="server" Text="Farmers" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
             </div>

            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1"></asp:GridView>
           

            <div class="center-content" style="margin-top: 10pt">
                <asp:Button ID="btnAddFarmer" runat="server" Text="Add Farmer" Height="30px" Width="150px" CssClass="button_rounded" BorderStyle="None" OnClick="btnAddFarmer_Click" />

            </div>

        </div>
    </form>
</body>
</html>
