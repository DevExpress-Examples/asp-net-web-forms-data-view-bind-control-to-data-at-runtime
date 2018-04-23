<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <!--region #Markup-->
        <dx:ASPxDataView runat="server" ID="DataView" OnLoad="DataView_Load">
            <SettingsTableLayout ColumnCount="2" RowsPerPage="2" />
        </dx:ASPxDataView>
        <!--endregion #Markup-->
    </form>
</body>
</html>
