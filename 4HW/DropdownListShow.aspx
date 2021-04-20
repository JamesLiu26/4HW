<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropdownListShow.aspx.cs" Inherits="_4HW.DropdownListShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="dbl_Area" runat="server" AutoPostBack="true"></asp:DropDownList><br />
            <asp:DropDownList ID="dbl_Place" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
