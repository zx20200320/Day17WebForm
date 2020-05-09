<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Day17WebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style>
        #tab td{
            padding:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:500px;margin:auto;margin-top:100px">
            <table id="tab">
                <tr>
                    <td>
                        <asp:TextBox ID="tbInput" TextMode="MultiLine" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="分组" class="btn btn-default" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="tbOutput" TextMode="MultiLine" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
