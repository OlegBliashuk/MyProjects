<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientDes.aspx.cs" Inherits="Client.ClientDes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>        function cac() {
            window.close()
        }</script>
    <style type="text/css">
        .block1
        {
            width: 800px;
            padding-right: 20%;
            float: inherit;
            height: 400px;
            padding-left:20%;
            padding-top: 20px;
            
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="block1" align="center" >
        <div style="font-family: 'Arial Black'; color: #FF0000; font-style: italic" align="left">
            Для додавання нового співробітника заповніть дану форму відповідно таким правилам:<br />
            &nbsp;&nbsp;&nbsp; - введення даних тільки кириличними знаками;<br />
            &nbsp;&nbsp;&nbsp; - дата заповнюється таким чином - ДД.ММ.РР, де РР - останнї дві
            цифри року народження;<br />
            &nbsp;&nbsp;&nbsp; - розмір зарплати вказується тільки цифрами та в у.о.;<br />
            &nbsp;&nbsp;&nbsp; - після того як будуть заповнені усі текстові поля натисніть
            &quot;Готово&quot;
        </div>
        <p style="font-family: 'Arial Black'; font-size: small; color: #808080">
            Прізвище:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Ім&#39;я:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; По-батькові:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Датанародження:</p>
            <p>
            <asp:TextBox ID="Surnume" runat="server" Width="200px"></asp:TextBox>            
            <asp:TextBox ID="Name" runat="server" Width="200px"></asp:TextBox>            
            <asp:TextBox ID="SecName" runat="server" Width="200px"></asp:TextBox>            
            <asp:TextBox ID="DBirth" runat="server" Width="150px"></asp:TextBox>
        </p>
        <p style="font-family: 'Arial Black'; font-size: small; color: #808080">
            Посада:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Розмір зарплати:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Досвід роботи:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Дата початку роботи:</p>
        <asp:TextBox ID="Position" runat="server" Width="200px"></asp:TextBox>
        
        <asp:TextBox ID="Salary" runat="server" Width="200px"></asp:TextBox>
       
        <asp:TextBox ID="Expirience" runat="server" Width="200px"></asp:TextBox>
       
        <asp:TextBox ID="DStart" runat="server" Width="150px"></asp:TextBox>
           <p>
            <asp:Button ID="Cancel" OnClientClick="cac()" runat="server" BackColor="#FF9966"
                Font-Size="Large" Text="Відміна" Width="127px" />
           
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
            <asp:Button ID="SaveChang" runat="server" BackColor="#66FF66" Font-Size="Large" Text="Готово"
                Width="127px" />
        </p>
    </div>
    </form>
</body>
</html>
