<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DayCalculator.aspx.cs" Inherits="DayCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Valittu päivä: <span id="selectedDate" runat="server"></span><br />
        Valitun päivän ja tämän päivän erotus: <span id="dateDifference" runat="server"></span><br />
        <asp:Button ID="btnBack" runat="server" Text="< vuosi" OnClick="btnBack_Click"/>
        <asp:Button ID="btnForward" runat="server" Text="vuosi >" OnClick="btnForward_Click"/><br />
        <asp:Calendar ID="calMyCalendar" runat="server" OnSelectionChanged="calMyCalendar_SelectionChanged"></asp:Calendar>
    </div>
    </form>
</body>
</html>
