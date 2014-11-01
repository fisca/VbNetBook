<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>รายชื่อพนักงานทั้งหมด</h2>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="EmployeeID" DataSourceID="CompanyDataSource" Width="100%" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" style="margin-left: 0px">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:CommandField ButtonType="Image" CancelImageUrl="~/Icons/block-icon.png" DeleteImageUrl="~/Icons/delete-2-icon.png" EditImageUrl="~/Icons/pencil-edit-icon.png" ShowDeleteButton="True" ShowEditButton="True" UpdateImageUrl="~/Icons/save-diskette-floppy-disk-icon.png" />
                <asp:BoundField DataField="EmployeeID" HeaderText="รหัสพนักงาน" ReadOnly="True" SortExpression="EmployeeID" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="FirstName" HeaderText="ชื่อ" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="นามสกุล" SortExpression="LastName" />
                <asp:BoundField DataField="HireDate" HeaderText="วันที่เริ่มงาน" SortExpression="HireDate" DataFormatString="{0:d}" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Salary" HeaderText="เงินเดือน" SortExpression="Salary" >
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:CheckBoxField DataField="FullTime" HeaderText="พนักงานประจำ" SortExpression="FullTime" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:CheckBoxField>
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <asp:SqlDataSource ID="CompanyDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Employees]" DeleteCommand="DELETE FROM [Employees] WHERE [EmployeeID] = @EmployeeID" InsertCommand="INSERT INTO [Employees] ([EmployeeID], [FirstName], [LastName], [HireDate], [Salary], [FullTime]) VALUES (@EmployeeID, @FirstName, @LastName, @HireDate, @Salary, @FullTime)" UpdateCommand="UPDATE [Employees] SET [FirstName] = @FirstName, [LastName] = @LastName, [HireDate] = @HireDate, [Salary] = @Salary, [FullTime] = @FullTime WHERE [EmployeeID] = @EmployeeID">
            <DeleteParameters>
                <asp:Parameter Name="EmployeeID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="EmployeeID" Type="Int32" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="HireDate" Type="DateTime" />
                <asp:Parameter Name="Salary" Type="Decimal" />
                <asp:Parameter Name="FullTime" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="HireDate" Type="DateTime" />
                <asp:Parameter Name="Salary" Type="Decimal" />
                <asp:Parameter Name="FullTime" Type="Boolean" />
                <asp:Parameter Name="EmployeeID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
