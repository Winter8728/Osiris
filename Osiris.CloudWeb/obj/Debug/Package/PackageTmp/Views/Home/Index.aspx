<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
    <link href="/Content/styles/reset.css" rel="stylesheet" />
    <link href="/Content/styles/public.css" rel="stylesheet" /> 
    <link href="/Content/layui/css/layui.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" class="layui-form">
    <div class="public-header-warrp">
        <div class="public-header">
            <div class="content">
                <div class="public-header-logo"><a href="">
                    <img src="/Content/images/logo.png" /></a></div>
                <div class="public-header-admin fr">
                    <p class="admin-name"><b><%=ViewData["name"] %></b> 您好！</p>
                    <div class="public-header-fun fr">
                      <a href="#" id="btnEare" class="public-header-man"><%=ViewData["Eare"] %></a>
                        <a href="/home/loginout" class="public-header-loginout">安全退出</a>
                    </div>
                </div>
                 
            </div>
        </div>
    </div>

    </form>
    <div class="clearfix"></div>
    <!-- 内容展示 -->
    <div class="public-ifame">
        <div class="content">
            <!-- 内容模块头 -->
            <div class="clearfix"></div>
            <!-- 左侧导航栏 -->
            <div class="public-ifame-leftnav">
                <div class="public-title-warrp">
                    <div class="public-ifame-title ">
                        <a href="">首页</a>
                    </div>
                </div>
                <ul class="left-nav-list">
                    <li class="public-ifame-item">
                        <a href="javascript:;">用户管理</a>
                        <div class="ifame-item-sub">
                            <ul>
                                <li class="active"><a href="/UserManager/Index" target="content">用户列表</a> | <a href="/UserManager/Edit" target="content">添加</a></li>
                            </ul>
                        </div>
                    </li>
                    <li class="public-ifame-item">
                        <a href="javascript:;">终端管理</a>
                        <div class="ifame-item-sub">
                            <ul>
                                <li><a href="/DeviceManager/Index" target="content">列表管理</a> | <a href="/DeviceManager/Edit" target="content">添加</a></li>

                            </ul>
                        </div>
                    </li>
                    <li class="public-ifame-item">
                        <a href="javascript:;">地图管理</a>
                        <div class="ifame-item-sub">
                            <ul>
                                <li><a href="/MapManager/Index" target="content">地图管理</a></li>
                                <li><a href="/MapManager/Coordinate" target="content">坐标管理</a> | <a href="/MapManager/CoorEdit" target="content">添加</a></li>
                            </ul>
                        </div>
                    </li>
                    <li class="public-ifame-item">
                        <a href="javascript:;">广告管理</a>
                        <div class="ifame-item-sub">
                            <ul>
                                <li><a href="/AdManager/Index" target="content">广告列表</a>|<a href="/AdManager/Edit" target="content">添加</a></li>
                            </ul>
                        </div>
                    </li>
                </ul>
            </div>
            <!-- 右侧内容展示部分 -->
            <div class="public-ifame-content">
                <iframe name="content" src="/home/main" frameborder="0" id="mainframe" scrolling="yes" marginheight="0" marginwidth="0" width="100%" style="height: 700px;"></iframe>
            </div>
        </div>
    </div>
    <script src="/Content/Scripts/jquery-1.10.2.min.js"></script> 
    <script src="/Content/layui/layui.js"></script>  
    <script>
        $().ready(function () {
            //

            layui.use(['layer', 'form'], function () {
                var layer = layui.layer
                , form = layui.form();

                layer.tips('点击可设置区域', '#btnEare', {
                    tips: [4, '#FF5722']
                });

            });

                $("#btnEare").click(function () {
                    var html = "<br />";
                    layer.open({
                        type: 2,
                        title: "设置区域",
                        skin: 'layui-layer-demo', //样式类名
                        closeBtn: 1, //不显示关闭按钮
                        shift: 1,
                        shadeClose: false, //开启遮罩关闭
                        area: ["500px", "500px"],
                        content: '/Home/EareList' 
                    });
                })
            

            var item = $(".public-ifame-item");

            for (var i = 0; i < item.length; i++) {
                $(item[i]).on('click', function () {
                    $(".ifame-item-sub").hide();
                    if ($(this.lastElementChild).css('display') == 'block') {
                        $(this.lastElementChild).hide()
                        $(".ifame-item-sub li").removeClass("active");
                    } else {
                        $(this.lastElementChild).show();
                        $(".ifame-item-sub li").on('click', function () {
                            $(".ifame-item-sub li").removeClass("active");
                            $(this).addClass("active");
                        });
                    }
                });
            }
        });
    </script>
</body>
</html>
