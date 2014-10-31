<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>WebControlDemo</title>

    <!-- Bootstrap core CSS -->
    <link href="Bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="CSS/Style.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>      
        <script src="Scripts/html5shiv.min.js"></script>
        <script src="Scripts/respond.min.js"></script>
    <![endif]-->

    <style type="text/css">
        .auto-style1 {
            width: 150px;
        }

        .auto-style2 {
            width: 10px;
        }

        .auto-style3 {
            width: 152px;
        }
    </style>

</head>


<body>
    <form id="form1" runat="server">
        <div class="container">
            <table>
                <tr>
                    <td class="auto-style1" style="text-align: center">
                        <asp:Image ID="imgPhoto" runat="server" BorderStyle="None" BorderWidth="2px" Height="100px" Width="100px" />
                    </td>
                    <td class="auto-style2">&nbsp;
                    </td>
                    <td style="vertical-align: top" class="auto-style3">
                        <asp:CheckBox ID="chkFilename" runat="server" Text="แสดงชื่อไฟล์" AutoPostBack="True" />
                        <br />
                        <asp:Label ID="lblFilename" runat="server" BackColor="#CCFFCC" BorderStyle="Inset" BorderWidth="1px" Visible="False" Width="150px"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">รูปภาพ<br />
                        <asp:RadioButtonList ID="rblNickname" runat="server" BackColor="#FFFF99" BorderColor="Silver" BorderStyle="Inset" BorderWidth="1px" CellPadding="0" CellSpacing="5" Width="150px" AutoPostBack="True">
                            <asp:ListItem>Nooknet</asp:ListItem>
                            <asp:ListItem>Numnum</asp:ListItem>
                            <asp:ListItem>Tonyod</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">รูปแบบเส้นขอบ<br />
                        <asp:RadioButtonList ID="rblBorderStyle" runat="server" BackColor="#FFFF99" BorderColor="Silver" BorderStyle="Inset" BorderWidth="1px" CellPadding="0" CellSpacing="5" Width="150px" AutoPostBack="True">
                            <asp:ListItem>No Border</asp:ListItem>
                            <asp:ListItem>Line Border</asp:ListItem>
                            <asp:ListItem>3D Border</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>

    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="Bootstrap/js/bootstrap.min.js"></script>
    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <script src="Scripts/ie10-viewport-bug-workaround.js"></script>
</body>
</html>
