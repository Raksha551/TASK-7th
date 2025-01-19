<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task-7.aspx.cs" Inherits="ASP_TASK_7.Task_7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.min.js" integrity="sha512-v2CJ7UaYy4JwqLDIrZUI/4hqeoQieOmAZNXBeQyjo21dadnwR+8ZaIJVT8EE2iyI61OV8e6M8PP2/4hpQINQ/g==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
<head runat="server">
    <title></title>
    <script>
        $("td").height(50);

    </script>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            text-align: center;
            background-color: #0a0c3f;
            border-spacing: 0px 0px;
        }


        .container {
            margin-top: 80px;
            margin-bottom: 40px;
        }


        .head-container {
            display: flex;
            justify-content: space-between;
            align-items: center;
            background-color: #08392b;
            border-bottom: 1px solid #ddd;
            color: white;
            height: 64px;
            padding: 0;
            top: 0;
            left: 0;
            right: 0;
            z-index: 1000;
            margin-bottom: 0px;
        }

        .header-left {
            width: 100px;
            height: 65px;
            flex-shrink: 0;
            margin: 0;
            border-radius: 10px;
        }

        .head-title1 {
            font-size: 24px;
            font-weight: bold;
            text-align: center;
            color: white;
            line-height: 60px;
            margin: 0;
        }

        .header-right-section {
            display: flex;
            align-items: center;
            gap: 10px;
            padding-right: 20px;
            padding-left: 50px;
        }



        .header-info {
            text-align: right;
        }


        .header-icon1 {
            width: 40px;
            height: 40px;
            cursor: pointer;
        }

        .header-icon {
            width: 40px;
            height: 40px;
            cursor: pointer;
            display: inline-flex;
        }

        .right {
            margin-right: 0px;
            right: 0px;
            justify-content: center;
            align-content: center;
            align-items: center;
            padding-right: 0px;
        }

        .sidebar-icons {
            width: 30px;
            height: 30px;
            padding: 4px;
        }

        .sidebar {
            background-color: darkslategray;
            margin-top: 0%;
            left: 0px;
            justify-content: left;
            font-size: 16px;
            height: 92vh;
            width: 220px;
            position: fixed;
            text-align: left;
            display: flex;
            flex-direction: column;
        }

        .sidebar-items {
            color: #DADBDD;
            text-align: center;
            justify-content: center;
            padding-left: 15px;
            align-content: center;
            text-decoration: none;
        }

        .sidebar-list {
            display: flex;
            flex-direction: row;
            padding: 14px;
            color: white;
            border: 1px solid white;
        }

        #settings {
            padding: 12px;
        }

        #rightlogo {
            width: 100px;
            height: 65px;
            flex-shrink: 0;
            margin: 0px;
            border-radius: 10px;
            padding-left: 4px;
            padding-right: 0px;
        }

        .row {
            border: 2px solid black;
            padding: 10px;
        }

        .celllength {
            width: 200px;
            height: 40px;
            color: black;
        }

        #viewbtn, #exportbtn {
            width: 80px;
            height: 40px;
            background-color: #0094ff;
            border-radius: 5px;
            font-size: 20px;
            font-weight: bold;
            padding-top: 2px;
        }

        .cellname {
            font-size: 18px;
            width: 110px; /* Adjust this value to set your desired width */
            text-align: left; /* Align text to the left if needed */
            padding: 5px;
            color: white;
        }

        #lbxdowncode, .list {
            color: black;
            backface-visibility: visible;
            border-radius: 5px;
            height: 50px;
        }

        .form-control {
            color: black;
        }

        .filtertable {
            /* width: 100%; */ /* Adjust as needed */
            border-collapse: collapse;
            /* margin-top: 200px;*/


            margin-left: 6%;
            width: 120%;
            padding-bottom: 6px;
            padding-top: 60px;
            padding-left: 15px;
            border: 1px solid #DADBDD;
            border-radius: 10px;
            color: black;
            display: inline !important;
            margin-top: 20%;
        }

            .filtertable > th {
                color: #DADBDD;
            }

            .filtertable > tbody > tr > td {
                padding-right: 20px;
            }

            .filtertable > th, .filtertable > td {
                padding: 10px;
                text-align: left;
                display: inline !important;
            }


        /*            .filtertable > td {
                height: 50px;
                width: 180px;
                padding: 6px;
            }*/

        .filters {
            margin-top: 35px;
        }

        .listview-Table {
            margin-left: 14%;
            color: white;
            margin-top: 2%;
            border-spacing: 0px 0px;
        }

            .listview-Table > div > div > table > tbody > tr > td {
                border-spacing: 0px 0px;
                color: black;
            }

            .listview-Table > div > div > table > tbody > tr:nth-child(n+3) > td:last-child {
                border: none;
                display: inline-table;
            }

            .listview-Table > div > div > table > tbody > tr:nth-child(n+3):nth-child(even) > td:nth-child(-n+6) {
                background-color: #ddd;
            }

            .listview-Table > div > div > table > tbody > tr:nth-child(n+3):nth-child(even) > td:last-child > table > tbody > tr > td:nth-child(-n+4) {
                background-color: #ddd;
            }

            .listview-Table > div > div > table > tbody > tr:nth-child(n+3):nth-child(even) > td:last-child > table > tbody > tr > td:not(:nth-child(5)):not(:nth-child(12)):not(:nth-child(14)):not(:nth-child(19)):not(:nth-child(26)) {
                background-color: #ddd;
            }

            .listview-Table > div > div > table > tbody > tr:nth-child(odd):nth-child(n+3) {
                background-color: white;
            }

            .listview-Table > div > div > table > tbody > tr:nth-child(2) > td:nth-child(1) {
                background-color: blue;
                color: #ddd;
                border: none;
            }

            .listview-Table > div > div > table > tbody > tr:nth-last-child(2) > td:last-child {
                color: black;
            }

        td {
            height: 63px;
        }



        .listview-Table > div > div > table > tbody > tr:nth-child(1) > td {
            padding: 5px;
            border: 1px solid #ddd;
        }
            /**/
            .listview-Table > div > div > table > tbody > tr:nth-child(1) > td > table > tbody > tr > td {
                border: 1px solid blue;
            }

        .listview-Table > div > div > table > tbody > tr:nth-child(1) > td {
            background-color: blue;
            color: white;
            border: 1px solid #ddd;
        }


        /*.listview-Table > div > table > tbody > tr:last-child > td:nth-last-child(-n+5) {
    visibility: hidden;
}*/ .listview-Table > div > div > table > tbody > tr:nth-last-child(2) > td:nth-child(n+2):nth-child(-n+6) {
            visibility: hidden;
            display: none;
        }

        .listview-Table > div > div > table > tbody > tr:last-child > td:nth-child(n+2):nth-child(-n+6) {
            visibility: hidden;
            display: none;
        }

        .ineerlistview > tbody > tr > td {
            width: 100px;
        }



        .listview-Table > div > div > table > tbody > tr:nth-child(2) > td > table > tbody {
            background-color: blue;
            color: white;
        }

        .listview-Table > div > div > table > tbody > tr:nth-child(1) {
            position: sticky;
            top: 0;
            background-color: #f2f2f2;
            z-index: 10;
            border: 1px solid #ddd;
        }



        .listview-Table > div > div > table > tbody > tr:nth-child(2) {
            position: sticky;
            /* background-color: #f2f2f2; */
            z-index: 100;
            top: 78px;
        }


        table {
            border-collapse: collapse;
        }

        .ineerlistview {
            list-style: none;
            width: 100%;
            table-layout: fixed;
        }


        .scrollable-table-wrapper {
            height: 580px;
            overflow: scroll;
        }

        .listview-Table td {
            border-right: 1px solid #ddd;
        }
    </style>
    <script>

        function handleButtonClick(button) {
            // Get the parent element of the button (the cell containing the button)
            const parentCell = button.parentElement;

            parentCell.innerHTML = "<span style='font-size:14px; color:green; word-wrap: break-word; white-space: normal; padding-right: 10px; overflow: hidden;'>SP01_data</span>";
            localStorage.setItem(button.id, 'clicked');
        }


        window.onload = function () {
            // Loop through all buttons and check if they have been clicked previously
            const buttons = document.querySelectorAll('button');
            buttons.forEach(button => {
                if (localStorage.getItem(button.id) === 'clicked') {
                    button.parentElement.innerHTML = "<span style='font-size:14px; color:green; word-wrap: break-word; white-space: normal; padding-right: 10px; overflow: hidden;'>SP01_data</span>";
                }
            });
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">

        <div class="head-container">
            <div>
                <img src="./Images/AmiTLogo.jpg" class="header-left" alt="Left Icon" />
            </div>
            <div class="head-title1">TPM-Trak Analysis</div>
            <div class="header-right-section">
                <div class="header-info">
                    <span id="currentDate"></span>
                </div>
                <div class="right">
                    <img src="./Images/maximize.png" class="header-icon" id="r" alt="Maximize Icon" style="padding-bottom: 10px;" />
                    <img src="./Images/profile-user.png" class="header-icon" id="h" alt="Home Icon" style="padding-bottom: 10px;" />
                    <img src="./Images/AmiTLogo.jpg" class="header-icon" id="rightlogo" alt="AmiT Loga" />
                </div>
            </div>
        </div>
        <div style="height: 100%;">
            <div class="sidebar">
                <div class="sidebar-list">
                    <img src="./Images/list.png" class="sidebar-icons" runat="server" alt="Menu Icon" />
                </div>
                <div class="sidebar-list">
                    <img src="./Images/play-button.png" class="sidebar-icons" runat="server" alt="Play Icon" />
                    <a href="#" class="sidebar-items">Historical Analytics</a>
                </div>
                <div class="sidebar-list">
                    <img src="./Images/push-pin.png" class="sidebar-icons" runat="server" alt="Push Pin Icon" />
                    <a href="#" class="sidebar-items">Live Analytics</a>
                </div>
                <div class="sidebar-list">
                    <img src="./Images/atom.png" class="sidebar-icons" runat="server" alt="Atom Icon" />
                    <a href="#" class="sidebar-items">Smart Shop</a>
                </div>
                <div class="sidebar-list">
                    <img src="./Images/back-in-time.png" class="sidebar-icons" runat="server" alt="Back in Time Icon" />
                    <a href="#" class="sidebar-items">Bajaj Analytics</a>
                </div>
                <div class="sidebar-list">
                    <img src="./Images/contact.png" class="sidebar-icons" runat="server" alt="Contact Icon" />
                    <a href="#" class="sidebar-items">User Access</a>
                </div>
                <div class="sidebar-list">
                    <a href="#" class="sidebar-items" id="settings">Settings</a>
                </div>
            </div>
        </div>
        <div class="filters">
            <table class="filtertable">
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Plant ID" CssClass="cellname"></asp:Label>
                        <asp:DropDownList runat="server" ID="plantid" CssClass="celllength" Style="font-size: 18px;">
                            <asp:ListItem Text="Vulkan"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Machine ID" CssClass="cellname"></asp:Label>
                        <asp:DropDownList runat="server" CssClass="celllength" Style="font-size: 18px;">
                            <asp:ListItem Text="M-01"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Year" CssClass="cellname"></asp:Label>
                        <asp:TextBox runat="server" ID="year" CssClass="celllength"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label runat="server" Text="Month" CssClass="cellname"></asp:Label>
                        <asp:TextBox runat="server" ID="month" CssClass="celllength"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button runat="server" ID="viewbtn" Text="View" OnClick="ViewButton_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:HiddenField runat="server" ID="HiddenField1" Value='<%# Eval("ButtonState") %>' />
        <div class="listview-Table" style="background-color: white;">
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:ListView runat="server" ID="listview1" ItemPlaceholderID="itemplaceholder">
                        <LayoutTemplate>
                            <div class="scrollable-table-wrapper">
                                <table>
                                    <tr runat="server" id="itemplaceholder"></tr>
                                </table>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr>
                                <td runat="server" rowspan='<%# Eval("RowSpan") %>' visible='<%# Eval("tdVisible") %>' colspan='<%# Eval("tdColSpan") %>'>
                                    <asp:Label runat="server" ID="lblpointid" Text='<%# Bind("CheckpointID") %>'></asp:Label>
                                </td>
                                <td runat="server" rowspan='<%# Eval("RowSpan") %>' visible='<%# Eval("tdVisible") %>'>
                                    <asp:Label runat="server" Text='<%# Eval("CheckpointItem") %>'></asp:Label>
                                </td>
                                <td runat="server" rowspan='<%# Eval("RowSpan") %>' visible='<%# Eval("tdVisible") %>'>
                                    <asp:Label runat="server" Text='<%# Eval("Requirement") %>'></asp:Label>
                                </td>
                                <td runat="server" rowspan='<%# Eval("RowSpan") %>' visible='<%# Eval("tdVisible") %>'>
                                    <%# Convert.ToBoolean(Eval("IsHeaderRow")) ? Eval("Method") : $"<img src='{Eval("Method")}' />" %>
                                </td>
                                <td runat="server" rowspan='<%# Eval("RowSpan") %>' visible='<%# Eval("tdVisible") %>'>
                                    <%# Convert.ToBoolean(Eval("IsHeaderRow")) ? Eval("Instrument") : $"<img src='{Eval("Instrument")}' />" %>
                                </td>

                                <td runat="server" rowspan='<%# Eval("RowSpan") %>' visible='<%# Eval("tdVisible") %>'>
                                    <asp:Label runat="server" Text='<%# Eval("ActionPlan") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:ListView runat="server" ItemPlaceholderID="inneritemplaceholder" ID="listivew2" DataSource='<%# Eval("innerlistviewdata") %>'>
                                        <LayoutTemplate>
                                            <table class="ineerlistview">
                                                <tr runat="server" style="border-collapse: collapse;">
                                                    <td id="inneritemplaceholder"></td>
                                                </tr>
                                            </table>
                                        </LayoutTemplate>
                                        <ItemTemplate>
                                            <td runat="server"
                                                rowspan='<%# Eval("rowspan") %>'
                                                visible='<%# Eval("tdVisible") %>'>
                                                <asp:Label runat="server" Text='<%# Eval("dynamic_dates") %>'></asp:Label>
                                            </td>

                                        </ItemTemplate>
                                    </asp:ListView>
                                </td>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

    </form>
</body>
</html>
