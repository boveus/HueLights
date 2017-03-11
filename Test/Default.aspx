<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 147px;
            height: 166px;
        }
        #Brightness {
            margin-left: 0px;
        }
    </style>
</head>
<body style="position: relative; top: 20px; left: 18px; height: 284px; width: 799px">
    <form id="form1" runat="server">
    <div>
    
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="59px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="111px" style="top: 61px; left: 59px; float: none; margin-left: 0px; text-align: left;">
                <asp:ListItem Selected="True" Value="LivingRoom">LivingRoom</asp:ListItem>
                <asp:ListItem>Hallway</asp:ListItem>
            </asp:RadioButtonList>
    
    </div>
        <div style="margin-left: 120px">
        </div>
        <p style="margin-left: 160px">
            &nbsp;</p>
        <asp:Button ID="OffButton" runat="server" Text="Off" OnClick="OffButton_Click1" Height="19px" Width="71px" style="margin-left: 24px" />
        <asp:Button ID="OnButton" runat="server" Text="On" OnClick="OnButton_Click1" Width="72px" Height="22px" style="top: 194px; left: 146px; margin-left: 23px; margin-top: 9px;" />
    <p style="margin-left: 40px">
        <asp:Button ID="Brightness" runat="server" Text="Set Brightness" Width="137px" OnClick="SetBrightness"/>
        <asp:TextBox ID="BrightnessValue" runat="server" MaxLength="3" Width="126px"></asp:TextBox>
        </p>
    <p>
        &nbsp;</p>
    </form>
    </body>
</html>
