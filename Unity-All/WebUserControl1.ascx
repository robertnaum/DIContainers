<%@ Control Language="C#" AutoEventWireup="true" %>
<%@ Import Namespace="BusinessLibrary" %>
<%@ Import Namespace="Microsoft.Practices.Unity" %>
<script runat="server">
   [Dependency] public IDrivable Drivable { get; set; }


</script>
I'm in the webusercontrol
<p><%=Drivable.Drive() %></p>