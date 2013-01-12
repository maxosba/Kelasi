<%@ Control Language="C#" CodeBehind="ManyToMany.ascx.cs" Inherits="Kelasi.UI.Web.Data.ManyToManyField" %>

<asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
      <asp:DynamicHyperLink runat="server"></asp:DynamicHyperLink>
    </ItemTemplate>
</asp:Repeater>

