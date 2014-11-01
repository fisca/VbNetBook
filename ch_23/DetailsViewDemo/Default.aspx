<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>รายชื่อพนักงาน</h2>
    
    </div>
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" CellPadding="4" DataKeyNames="EmployeeID" DataSourceID="CompanyDataSource" ForeColor="#333333" GridLines="None" Height="50px" Width="300px">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#FFFFC0" Font-Bold="True" />
            <FieldHeaderStyle BackColor="#FFFF99" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="EmployeeID" HeaderText="รหัสพนักงาน" ReadOnly="True" SortExpression="EmployeeID" />
                <asp:BoundField DataField="FirstName" HeaderText="ชื่อ" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="นามสกุล" SortExpression="LastName" />
                <asp:BoundField DataField="HireDate" DataFormatString="{0:d}" HeaderText="วันที่เริ่มงาน" SortExpression="HireDate" />
                <asp:BoundField DataField="Salary" HeaderText="เงินเดือน" SortExpression="Salary" />
                <asp:CheckBoxField DataField="FullTime" HeaderText="พนักงานประจำ" SortExpression="FullTime" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="CompanyDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Employees] WHERE [EmployeeID] = @EmployeeID" InsertCommand="INSERT INTO [Employees] ([EmployeeID], [FirstName], [LastName], [HireDate], [Salary], [FullTime]) VALUES (@EmployeeID, @FirstName, @LastName, @HireDate, @Salary, @FullTime)" SelectCommand="SELECT * FROM [Employees]" UpdateCommand="UPDATE [Employees] SET [FirstName] = @FirstName, [LastName] = @LastName, [HireDate] = @HireDate, [Salary] = @Salary, [FullTime] = @FullTime WHERE [EmployeeID] = @EmployeeID">
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
