<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="F_CodeFavorites.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:HyperLinkField DataTextField="Url" HeaderText="Url" />
                <asp:BoundField DataField="Date" HeaderText="Date" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
