<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CardsMapGenerator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cards Map Generator for "Nome in Codice"</title>
</head>
<body>
     <form id="form1" runat="server">
        <div style="width: 260px; height: 260px;">
            <asp:Repeater runat="server" ID="rptColori">
                <ItemTemplate>
                    <div style='<%# "float:left;width: 50px; height: 50px; margin-left: 2px; margin-bottom: 2px;background-color:" + Container.DataItem %>'></div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
