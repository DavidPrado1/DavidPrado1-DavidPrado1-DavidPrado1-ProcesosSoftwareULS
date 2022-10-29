<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Web Service SOAP en .NET</title>
</head>

<body>
    <h1>Calculadora con Web Services</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label id="label" AssociatedControlId="TextBox1" Text="Numero 1:" runat="server" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label id="label2" AssociatedControlId="TextBox1" Text="Numero 2:" runat="server" />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Suma" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Resta" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Multiplicacion" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Division" OnClick="Button4_Click" />
        </div>
        <div>
            <asp:Label id="label1" AssociatedControlId="TextBox3" Text="Resultado:" runat="server" disabled="true"/>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        </div>
    </form>
</body>
    <p>Felix David Prado Apaza</p>
</html>
