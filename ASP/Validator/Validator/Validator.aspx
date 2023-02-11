<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Validator.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Insert Your Details:<br />
            <br />
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtName" ErrorMessage="RequiredFieldValidator" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Family Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextFname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ForeColor="Red" ControlToValidate="TxtName" Display="Dynamic">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TxtName" ErrorMessage="proper family name" ForeColor="Red">Differs from name</asp:CompareValidator>
            <br />
            <br />
            Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextAdd" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter proper address" ForeColor="Red" ControlToValidate="TextAdd" Display="Dynamic">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TextAdd" ErrorMessage="proper address" ForeColor="Red">at least 2 chars</asp:CompareValidator>
            <br />
            <br />
            City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextCity" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter proper city" ForeColor="Red" ControlToValidate="TextCity" Display="Dynamic">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="TextCity" ErrorMessage="Proper City" ForeColor="Red">At least 2 chars</asp:CompareValidator>
            <br />
            <br />
            Zip Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextZCode" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter proper zipcode" ForeColor="Red" ControlToValidate="TextZCode" Display="Dynamic">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="TextZCode" ErrorMessage="Proper Code" ForeColor="Red">(xxxxxx)</asp:CompareValidator>
            <br />
            <br />
            Phone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextPhone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="enter proper number" ForeColor="Red" ControlToValidate="TextPhone" Display="Dynamic">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator5" runat="server" ControlToValidate="TextPhone" ErrorMessage="Enter proper number"  ClientValidationFunction="validateLength" ForeColor="Red">(xxx-xxxxxxxxx / xxx-xxxxxxxxx)</asp:CompareValidator>
            <br />
            <br />
            E-Mail:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Enter proper mail" ForeColor="Red" ControlToValidate="TextEmail" Display="Dynamic">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator6" runat="server" ControlToValidate="TextEmail" ErrorMessage="Enter proper mail" ClientValidationFunction="validateLength" ForeColor="Red">example@example.com</asp:CompareValidator>
            <br />
            <br />
            <asp:Button ID="CheckBtn" runat="server" Text="Check" OnClick="Page_Load" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ShowMessageBox="True" HeaderText="ValidationSum" />
        </div>
    </form>
</body>
</html>
