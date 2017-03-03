<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <title>区域列表</title>
    <link href="/Content/layui/css/layui.css" rel="stylesheet" />
    <style>
        .layui-form-radio
        {
                margin: 6px 70px 0px 0px;
        }
        .btnsub
        {
            margin:0 auto;
        }
    </style>
</head>
<body>
     
    <form class="layui-form" action="/home/EareList"  method="post" data-ajax="true">
        <div class="layui-input-block" style="margin-top:20px;">
            <input type="radio" name="eare" value="上海市" title="上海市" checked />
            <input type="radio" name="eare" value="黄浦区" title="黄浦区" /><br />
            <input type="radio" name="eare" value="卢湾区" title="卢湾区" />
            <input type="radio" name="eare" value="徐汇区" title="徐汇区" /><br />
            <input type="radio" name="eare" value="长宁区" title="长宁区" />
            <input type="radio" name="eare" value="静安区" title="静安区" /><br />
            <input type="radio" name="eare" value="普陀区" title="普陀区" />
            <input type="radio" name="eare" value="闸北区" title="闸北区" /><br />
            <input type="radio" name="eare" value="虹口区" title="虹口区" />
            <input type="radio" name="eare" value="杨浦区" title="杨浦区" /><br />
            <input type="radio" name="eare" value="闵行区" title="闵行区" />
            <input type="radio" name="eare" value="宝山区" title="宝山区" /><br />
            <input type="radio" name="eare" value="嘉定区" title="嘉定区" />
            <input type="radio" name="eare" value="浦东新区" title="浦东新区" /><br />
            <input type="radio" name="eare" value="金山区" title="金山区" />
            <input type="radio" name="eare" value="松江区" title="松江区" /><br />
            <input type="radio" name="eare" value="青浦区" title="青浦区" />
            <input type="radio" name="eare" value="南汇区" title="南汇区" /><br />
            <input type="radio" name="eare" value="奉贤区" title="奉贤区" />
            <input type="radio" name="eare" value="崇明县" title="崇明县" /><br /> 
            
        </div>
        <div class="layui-input-block" style="margin-top:20px;width:300px;  text-align:center;">
            <input class="layui-btn btnsub" id="btnSub" type="button"  value="立即提交"/> 
            </div>
    </form>

    <script src="/Content/Scripts/jquery-1.10.2.min.js"></script>
    <script src="/Content/Scripts/jquery.unobtrusive-ajax.min.js"></script>
    <script src="/Content/layui/layui.js"></script>
    <script>

        //一般直接写在一个js文件中
        layui.use(['layer', 'form'], function () {
            var layer = layui.layer
            , form = layui.form();


        });
        var eare = '<%=ViewData["Eare"]%>';
        $(function () {
            
            $("input[name='eare'][value="+eare+"]").attr("checked", true);

            var index = parent.layer.getFrameIndex(window.name);
            $('#btnSub').on('click', function () {
                
                var v = $('.layui-input-block input[name="eare"]:checked ').val();
                 
                if (eare == v)
                    layer.alert("当前区域为:" + eare);
                else {
                    eare = v;
                    $(this).submit();
                }
             }); 
        })
        var setEare = function () {
            window.parent.document.getElementById('btnEare').innerText = eare;
            parent.layer.close(parent.layer.getFrameIndex(window.name));
        }
    </script>

</body>
</html>
