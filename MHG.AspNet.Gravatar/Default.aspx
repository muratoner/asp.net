<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MHG.AspNet.Gravatar.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <img src="//www.gravatar.com/avatar/<%= MHG.AspNet.Gravatar.MD5.Hash("muhackgames@gmail.com") %>?s=512" />
    </div>
    </form>
</body>
</html>
