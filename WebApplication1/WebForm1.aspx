<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
               
                <tr>
                    <td>FirstName</td>
                      <td>
                          <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>

                      </td>
                </tr>

                <tr>
                    <td>LastName</td>
                      <td>
                          <asp:TextBox ID="LastName" runat="server"></asp:TextBox>

                      </td>
                </tr>
                 <tr>
                    <td>Mobile Number</td>
                      <td>
                          <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>

                      </td>
                </tr>
                 <tr>
                    <td>Email Address</td>
                      <td>
                          <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

                      </td>
                </tr>
                <tr>
                    <td>City</td>
                      <td>
                          <asp:TextBox ID="City" runat="server"></asp:TextBox>
                      </td>
                </tr>
                <tr>
                    <td colspan="2" align ="center">
                        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
                        <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
                        <asp:Button ID="Button4" runat="server" Text="View" OnClick="Button4_Click" />

                    </td>
                </tr>
                 <tr>
                    <td>Updated id </td>
                    <td>
                        <asp:TextBox ID="id" runat="server"></asp:TextBox>
                    </td>
                </tr>




            </table>
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
