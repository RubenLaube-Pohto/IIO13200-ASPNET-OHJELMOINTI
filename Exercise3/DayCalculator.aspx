<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DayCalculator.aspx.cs" Inherits="DayCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Valittu päivä: <div id="selectedDate" runat="server"></div>
        Valitun päivän ja tämän päivän erotus: <div id="dateDifference" runat="server"></div>
        <asp:Button ID="Button1" runat="server" Text="< vuosi" />
        <asp:Button ID="Button2" runat="server" Text="vuosi >" /><br />
        <asp:Calendar ID="calMyCalendar" runat="server"></asp:Calendar>
    </div>
    </form>
</body>
</html>
