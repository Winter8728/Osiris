<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/ConternMaster.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    CoorEdit
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="public-nav">您当前的位置：<a href="">管理首页</a>><a href="">坐标管理</a></div>

    <form class="layui-form" action="/MapManager/CoorEdit" style="margin-top: 25px;" method="post">
        <input type="hidden" name="Id" id="Id" value="<%=Model.Id==null?"":Model.Id %>" /> 

        <div class="layui-form-item">
            <label class="layui-form-label">区域</label>
            <div class="layui-input-block">
                <input type="text" name="Eare"   id="Eare" value="<%=Model.Eare==null?"":Model.Eare %>" lay-verify="eare" autocomplete="off" placeholder="请输入终端ID" class="layui-input" maxlength="4">
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">标志物</label>
            <div class="layui-input-block">
                <input type="text" name="LogoName"   id="LogoName" value="<%=Model.LogoName==null?"":Model.LogoName %>"  autocomplete="off"   class="layui-input" maxlength="10">
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">经度</label>
            <div class="layui-input-block">
                <input type="text" name="Lon"   id="Lon" value="<%=Model.Lon==null?"":Model.Lon %>" lay-verify="lon" autocomplete="off" placeholder="请输入经度" class="layui-input" maxlength="20">
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">纬度</label>
            <div class="layui-input-block">
                <input type="text" name="Lat"   id="Lat" value="<%=Model.Lat==null?"":Model.Lat %>" lay-verify="lat" autocomplete="off" placeholder="请输入纬度" class="layui-input" maxlength="20">
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
            layui.use(['form', 'layedit'], function () {
                var form = layui.form()
                , layer = layui.layer
                , layedit = layui.layedit

                //自定义验证规则
                form.verify({
                    eare: function (value) {
                        if (value.length < 3) {
                            return '区域至少得3个字符';
                        }
                    }, lon: function (value) {
                        if (value.length < 6) {
                            return '经度至少得6个字符';
                        }
                    }, lat: function (value) {
                        if (value.length < 6) {
                            return '纬度至少得6个字符';
                        }
                    }
                });


            });

            $("#Eare").blur(function () {
                var deviceId = $("#Eare").val();
                $.post("/MapManager/Exists", { deviceId: deviceId }, function (result) {
                    if (result.result == 1) {
                        layer.msg("区域被占用!");
                        $("#Eare").select();
                        $("#Eare").focus();
                        return;
                    }

                })
            })

            if ($("#Id").val() != "0") {
                $("#Eare").attr("disabled", "disabled");
            }

        });
    </script>
</asp:Content>

