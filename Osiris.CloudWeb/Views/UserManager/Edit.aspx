<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/ConternMaster.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="public-nav">您当前的位置：<a href="">管理首页</a>><a href="">用户管理</a></div>

    <form class="layui-form" action="/UserManager/Edit" style="margin-top: 25px;" method="post">
        <input type="hidden" id="id" value="<%=Model.Id==null?"":Model.Id %>" />
        <div class="layui-form-item">
            <label class="layui-form-label" style="height:100px; line-height:100px;">用户头像</label>
            <div class="layui-input-block">
                <img src="<%=Model.HeadImage==null?"/FileStore/HeadImages/1.png":Model.HeadImage %>" style="width:100px; height:100px; cursor:pointer;"  id="himage" />
                <input type="hidden" name="headimage" id="headimage" value="<%=Model.HeadImage==null?"/FileStore/HeadImages/1.png":Model.HeadImage %>" />
            </div>
        </div>

        <div class="layui-form-item">
            <label class="layui-form-label">用户名</label>
            <div class="layui-input-block">
                <input type="text" name="userName"   id="userName" value="<%=Model.UserName==null?"":Model.UserName %>" lay-verify="title" autocomplete="off" placeholder="请输入用户名" class="layui-input">
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">密码</label>
            <div class="layui-input-inline">
                <input type="password" name="password" value="<%=Model.Password==null?"":"$%^&**&^%$" %>" lay-verify="pass" placeholder="请输入密码"  autocomplete="off" class="layui-input">
            </div>
            <div class="layui-form-mid layui-word-aux">请填写5到30位密码</div>
        </div> 
        
        <div class="layui-form-item">
            <label class="layui-form-label">是否锁定</label>
            <div class="layui-input-block">
                <input type="checkbox" name="islock" lay-skin="switch" <%=Model.IsLock==0?"":"checked" %> title="是否锁定">
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">是否管理员</label>
            <div class="layui-input-block">
                <input type="checkbox" name="isadmin" lay-skin="switch" <%=Model.IsAdmin==false?"":"checked" %> title="是否管理员">
            </div>
        </div>
        <div class="layui-form-item">
            <div class="layui-input-block">
                <button class="layui-btn" lay-submit="" lay-filter="tb">立即提交</button>
                <button type="reset" class="layui-btn layui-btn-primary">重置</button>
            </div>
        </div>

        <div id="headlist" class="headlist hide">
            <ul>
            <li><img src="/FileStore/HeadImages/1.png" /><i class="layui-icon hide">&#x1005;</i></li>
            <li><img src="/FileStore/HeadImages/2.png" /><i class="layui-icon hide">&#x1005;</i></li>
            <li><img src="/FileStore/HeadImages/3.png" /><i class="layui-icon hide">&#x1005;</i></li>
            <li><img src="/FileStore/HeadImages/4.png" /><i class="layui-icon hide">&#x1005;</i></li>
            <li><img src="/FileStore/HeadImages/5.png" /><i class="layui-icon hide">&#x1005;</i></li>
            <li><img src="/FileStore/HeadImages/6.png" /><i class="layui-icon hide">&#x1005;</i></li>
            <li><img src="/FileStore/HeadImages/7.png" /><i class="layui-icon hide">&#x1005;</i></li>
            <li><img src="/FileStore/HeadImages/8.png" /><i class="layui-icon hide">&#x1005;</i></li>
        </ul> 
        </div>
    </form>

    <script>
        $().ready(function () {
            layui.use(['form', 'layedit', 'laydate'], function () {
                var form = layui.form()
                , layer = layui.layer
                , layedit = layui.layedit
                , laydate = layui.laydate;

                //自定义验证规则
                form.verify({
                    title: function (value) {
                        if (value.length < 5) {
                            return '用户名至少得5个字符啊';
                        }
                    }
                  , pass: [/(.+){5,30}$/, '密码必须5到30位']
                });

                layer.tips('点击选择头像', '#himage');
                 
            });

            $("#userName").blur(function () {
                var userName = $("#userName").val();
                $.post("/UserManager/ExistsUser", {userName:userName},function(result){
                    if (result.result == 1)
                    {
                        layer.msg("用户名被占用!");
                        $("#userName").select();
                        $("#userName").focus();
                        return;
                    }

                })
            })

            $("#himage").click(function () {
                layer.open({
                    type: 1,
                    title: "选择头像",
                    closeBtn: 1,
                    area: ['495px','320px'],
                    skin: 'layui-layer-lan', //没有背景色
                    shade :0,
                    shadeClose: false,
                    content: $('#headlist'),
                    btn: ['提交', '取消'],
                    yes: function(index, layero){
                        $("#headlist ul li").each(function (index) {

                            if (!$(this).children("i").hasClass("hide")) {
                                var u = $(this).children("img").attr("src");
                                $("#headimage").val(u);
                                $("#himage").attr("src", u);
                            }

                        })
                        layer.close(index);
                    }

                });
               
                $("#headlist ul li").each(function (index) {
                    if ($("#headimage").val() == $(this).children("img").attr("src"))
                    {
                        $(this).children("i").removeClass("hide");
                        $(this).children("i").addClass("dis");
                    }
                })
            })
            $("#headlist ul li").click(function () {
                $("#headlist ul li").each(function (index) {
                    $(this).children("i").removeClass("dis");
                    $(this).children("i").addClass("hide");
                })
                $(this).children("i").removeClass("hide");
            })
            if ($("#id").val() != "0") { 
                $("#userName").attr("disabled", "disabled");    
            }

        });
    </script>
</asp:Content>

