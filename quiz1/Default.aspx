<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 381px;
        }
        .auto-style3 {
            width: 72%;
        }
        .auto-style4 {
            width: 94%;
            margin-right: 258px;
            height: 166px;
        }
        .auto-style5 {
            width: 100%;
        }
        .auto-style6 {
            margin-left: 0px;
            margin-top: 0px;
        }
        .auto-style7 {
            width: 451px;
        }
        .auto-style8 {
            width: 149px;
        }
        .auto-style10 {
            width: 1368px;
        }
        .auto-style11 {
            width: 305px;
        }
        .auto-style12 {
            width: 76%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" class="auto-style3">
                <tr>
                    <td class="auto-style10">
                        <table class="auto-style5">
                            <tr>
                                <td class="auto-style7">
                                    <asp:Label ID="LblError" runat="server" Font-Italic="True" ForeColor="#FF3300" Text="Label Error"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style7">CRUD OPERATION</td>
                                <td>ALL AVAILABLE BOOKS</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <table class="auto-style3">
                <tr>
                    <td class="auto-style2">
                        <table class="auto-style4">
                            <tr>
                                <td class="auto-style8">Book ID:</td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" Width="140px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">Book Name:</td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server" Width="140px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">Book Category:</td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server" Width="140px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">Edition:</td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" Width="140px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">Publisher:</td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server" Width="140px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">Print Date:</td>
                                <td>
                                    <asp:TextBox ID="TextBox6" runat="server" Width="140px" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" BorderStyle="Dotted" CssClass="auto-style6" Width="496px" BorderColor="#999966" BackColor="White">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
            <table class="auto-style12">
                <tr>
                    <td>
                        <asp:Button ID="btnSave" runat="server" BorderColor="#9966FF" BorderStyle="Double" Font-Bold="True" Font-Size="Medium" OnClick="Button1_Click" Text="Save" Width="139px" />
                    </td>
                    <td>
                        <asp:Button ID="btnUdt" runat="server" BorderColor="#9966FF" BorderStyle="Double" Font-Bold="True" Font-Size="Medium" OnClick="Update_Click" Text="Update" Width="139px" />
                    </td>
                    <td>
                        <asp:Button ID="btnDel" runat="server" BorderColor="#9966FF" BorderStyle="Double" Font-Bold="True" Font-Size="Medium" OnClick="Delete_Click" Text="Delete" Width="139px" />
                    </td>
                    <td>
                        <asp:Button ID="btnSrh" runat="server" BorderColor="#9966FF" BorderStyle="Double" Font-Bold="True" Font-Size="Medium" OnClick="Search_Click" Text="Search" Width="139px" />
                    </td>
                    <td class="auto-style11">
                        <asp:Button ID="btnShow" runat="server" BorderColor="#9966FF" BorderStyle="Double" Font-Bold="True" Font-Size="Medium" OnClick="ALL_Click" Text="Show All" Width="139px" />
                    &nbsp;<asp:Button ID="btnReset" runat="server" BorderColor="#9966FF" BorderStyle="Double" Font-Bold="True" Font-Size="Medium" OnClick="Reset_Click" Text="Reset" Width="139px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
