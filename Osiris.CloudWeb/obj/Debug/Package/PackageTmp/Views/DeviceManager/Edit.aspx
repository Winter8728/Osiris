<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/ConternMaster.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="public-nav">您当前的位置：<a href="">管理首页</a>><a href="">终端管理</a></div>

    <form class="layui-form" action="/DeviceManager/Edit" style="margin-top: 25px;" method="post">
        <input type="hidden" name="Id" id="Id" value="<%=Model.Id==null?"":Model.Id %>" /> 

        <div class="layui-form-item">
            <label class="layui-form-label">终端ID</label>
            <div class="layui-input-block">
                <input type="text" name="DeviceId"   id="deviceId" value="<%=Model.DeviceId==null?"":Model.DeviceId %>" lay-verify="title" autocomplete="off" placeholder="请输入终端ID" class="layui-input" maxlength="20">
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">开关</label>
            <div class="layui-input-block">
                <input type="checkbox" name="switch" lay-skin="switch" <%=Model.Switch=="1"?"":"checked" %> title="开关">
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">是否锁定</label>
            <div class="layui-input-block">
                <input type="checkbox" name="islock" lay-skin="switch" <%=Model.IsLock==false?"":"checked" %> title="是否锁定">
            </div>
        </div>
        <div class="layui-form-item">
            <div class="layui-input-block">
                <button class="layui-btn" lay-submit="" lay-filter="tb">立即提交</button>
                <button type="reset" class="layui-btn layui-btn-primary">重置</button>
            </div>
        </div>
         
    </form>

    <script>
        $().ready(function () {
            layui.use(['form', 'layedit' ], function () {
                var form = layui.form()
                , layer = layui.layer
                , layedit = layui.layedit 

                //自定义验证规则
                form.verify({
                    title: function (value) {
                        if (value.length < 5) {
                            return '终端ID至少得5个字符';
                        }
                    } 
                });
                 
                 
            });

            $("#deviceId").blur(function () {
                var deviceId = $("#deviceId").val();
                $.post("/DeviceManager/ExistsDevice", { deviceId: deviceId }, function (result) {
                    if (result.result == 1)
                    {
                        layer.msg("DeviceId被占用!");
                        $("#deviceId").select();
                        $("#deviceId").focus();
                        return;
                    }

                })
            })
             
            if ($("#Id").val() != "0") { 
                $("#deviceId").attr("disabled", "disabled");
            }

        });
    </script>
</asp:Content>

