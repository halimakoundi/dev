<%@ Page Title="Palindrome finder" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Palindrome._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
            </hgroup>
            <p>
                This algorithm is to find the 3 longest unique palindromes in a string. For the 3 longest palindromes,
                 it will report the palindrome text, start index and the length in descending order of length.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>For example, the output for string, “sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop” should be:</h3>
    <ol class="round">
        <li class="one">
            <h5>Text: hijkllkjih, Index: 23, Length: 10</h5>
        </li>
        <li class="two">
            <h5>Text: defggfed, Index: 13, Length: 8</h5>
        </li>
        <li class="three">
            <h5>Text: abccba, Index: 5 Length: 6</h5>
        </li>
    </ol>
    <asp:Label ID="PalindromeLbl" runat="server" Text="Please enter some text"></asp:Label>
    <asp:TextBox ID="palindromTxt" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator  
             ID="RequiredFieldValidator1"  
             runat="server"  
             ControlToValidate="palindromTxt"
             EnableClientScript="true"  
             SetFocusOnError="true"
             CssClass="errMsg"  
             Text="Please enter a text"  
             > </asp:RequiredFieldValidator>
    <asp:Button ID="getPalindromesBtn" runat="server" Text="Get Palindromes" ></asp:Button>
    <asp:Repeater ID="palindromesListRpt" runat="server">
        <HeaderTemplate>
            <h3> The results for the string you've entered are</h3>
        </HeaderTemplate>
        <ItemTemplate>            
            <ol class="round">
                <li >
                    <h5><%# String.Format("Text: {0}, Index: {1}, Length: {2}", Eval("TextValue"), Eval("StartIndex"), Eval("LengthValue"))%></h5>
                </li>
            </ol>
        </ItemTemplate>
    </asp:Repeater>
    <p><asp:Label ID="lblErrorMsg" runat="server" CssClass="errMsg" Text="Sorry, no palindrome has been found." Visible="false">
        </asp:Label>
    </p>   
</asp:Content>
