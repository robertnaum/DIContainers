<%@ Page Language="C#" AutoEventWireup="true" %>
<%@ Import Namespace="BusinessLibrary" %>
<%@ Import Namespace="Microsoft.Practices.Unity" %>
<%@ Import Namespace="Unity.WebForms" %>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>
<!DOCTYPE html>
<script runat="server">
   [Dependency] public IDrivable Drivable { get; set; }

</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           unity<br/>
    <%
        var container = Context.GetChildContainer();
        var a = container.Resolve<IDrivable>();
        Response.Write("from GetChildContainer" + a.Drive());
    %>
    </div>
    <p>
        From Dependency attribute :<%=Drivable.Drive()%>
    </p>

        
    <uc1:WebUserControl1 runat="server" ID="WebUserControl1" />
   
    </form>
</body>
</html>
