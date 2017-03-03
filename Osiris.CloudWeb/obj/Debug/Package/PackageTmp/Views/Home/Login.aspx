<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
 
<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta http-equiv="Pragma" content="no-cache">
    <meta http-equiv="Cache-Control" content="no-cache">
    <meta http-equiv="Expires" content="0">
    <title>系统登录</title>
    <link href="/Content/themes/login/login.css" rel="stylesheet" />
</head>
<body>
   <form id="from1" action="/home/login" method="post">
    <div class="login">
        <div class="message">OSIRIS-管理登录</div>
        <div id="darkbannerwrap"></div>

        <input name="action" value="login" type="hidden" id="txtUserName">
        <input name="username" placeholder="用户名" required="" type="text">
        <hr class="hr15">
        <input name="password" placeholder="密码" required="" type="password" id="txtPassword">
        <hr class="hr15">
        <input value="登录" style="width: 100%;" type="submit">
        <hr class="hr20">
        <!-- 帮助 <a onClick="alert('请联系管理员')">忘记密码</a> -->

    </div> 
       </form>
</body>
</html>
<script>

</script>
