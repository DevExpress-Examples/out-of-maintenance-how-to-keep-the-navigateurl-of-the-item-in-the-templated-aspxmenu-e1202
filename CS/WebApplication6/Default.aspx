<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication6._Default" %>

<%@ register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxEditors"
    TagPrefix="dxe" %>

<%@ register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dxm" %>
<%@ register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxSiteMapControl"
    TagPrefix="dxsm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxm:aspxmenu ID="ASPxMenu1" runat="server" DataSourceID="ASPxSiteMapDataSource1"
            Orientation="Vertical" OnDataBound="ASPxMenu1_DataBound">
            <itemtemplate>
                <dxe:aspxlabel ID="ASPxLabel1" runat="server" Text='<%#Container.Item.Text %>' Width="100px" Height="20px" Cursor="pointer">
                </dxe:aspxlabel>
            </itemtemplate>
        </dxm:aspxmenu>
        <dxsm:aspxsitemapdatasource ID="ASPxSiteMapDataSource1" runat="server" SiteMapFileName="~/web.sitemap" />
       
    </div>
    </form>
</body>
</html>
