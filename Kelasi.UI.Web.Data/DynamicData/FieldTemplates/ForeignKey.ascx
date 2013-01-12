<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="Kelasi.UI.Web.Data.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />

