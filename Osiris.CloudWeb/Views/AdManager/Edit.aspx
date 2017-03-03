<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/ConternMaster.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">

    <style>
        .site-demo-upload
        {
            position: relative;
            background: #e2e2e2;
        }

            .site-demo-upload, .site-demo-upload img
            {
                width: 200px;
                height: 200px;
                border-radius: 100%;
            }

                .site-demo-upload .site-demo-upbar
                {
                    position: absolute;
                    top: 50%;
                    left: 50%;
                    margin: -18px 0 0 -56px;
                }

                .site-demo-upload .layui-upload-button
                {
                    background-color: rgba(0,0,0,.2);
                    color: rgba(255,255,255,1);
                }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="public-nav">您当前的位置：<a href="">管理首页</a>><a href="">广告管理</a></div>

    <form class="layui-form" action="/AdManager/Edit" style="margin-top: 25px;" method="post">
        <input type="hidden" name="Id" id="Id" value="<%=Model.Id==null?"":Model.Id %>" />
        <input type="hidden" id="AdPath" name="AdPath" value="<%=Model.AdPath==null?"/content/images/icon_txt.png":Model.AdPath %>" />
        <input type="hidden" id="ThumbPath" name="ThumbPath" value="<%=Model.ThumbPath==null?"/content/images/icon_txt.png":Model.ThumbPath %>" />

        <div class="layui-form-item">
            <label class="layui-form-label">选择区域</label>
            <div class="layui-input-inline">
                <select name="eare" id="eare" lay-filter="eare"> 
                    <option value="上海市" selected="">上海市</option>
                    <option value="黄浦区">黄浦区</option>
                    <option value="卢湾区">卢湾区</option>
                    <option value="徐汇区">徐汇区</option>
                    <option value="长宁区">长宁区</option>
                    <option value="静安区">静安区</option>
                    <option value="普陀区">普陀区</option>
                    <option value="闸北区">闸北区</option>
                    <option value="虹口区">虹口区</option>
                    <option value="杨浦区">杨浦区</option>
                    <option value="闵行区">闵行区</option>
                    <option value="宝山区">宝山区</option>
                    <option value="嘉定区">嘉定区</option>
                    <option value="浦东新区">浦东新区</option>
                    <option value="金山区">金山区</option>
                    <option value="松江区">松江区</option>
                    <option value="青浦区">青浦区</option>
                    <option value="南汇区">南汇区</option>
                    <option value="奉贤区">奉贤区</option>
                    <option value="崇明县">崇明县</option>
                </select>
            </div>
            <div class="layui-form-mid layui-word-aux" style="color: red;">* 默认选择上海市时.为用户广告设置(非地区广告)</div>
        </div>

        <div class="layui-form-item">
            <label class="layui-form-label">广告标题</label>
            <div class="layui-input-block">
                <input type="text" name="Remark" id="Remark" value="<%=Model.Remark==null?"":Model.Remark %>" autocomplete="off" class="layui-input" maxlength="20">
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">重复次数</label>
            <div class="layui-input-inline">
                <input type="number" name="RepeatNum" lay-verify="number" autocomplete="off" class="layui-input" value="<%=Model.RepeatNum==null?1:Model.RepeatNum %>" max="1000" min="1">
            </div>
        </div>


        <div class="layui-form-item">
            <label class="layui-form-label">范围选择</label>
            <div class="layui-input-inline">
                <input class="layui-input" placeholder="开始时间" name="BeginTime" lay-verify="time" value="<%=Model.BeginTime==null?"":Model.BeginTime %>" onclick="layui.laydate({ elem: this, min: laydate.now(0), istime: true, format: 'YYYY-MM-DD hh:00:00' })">
            </div>
            <div class="layui-input-inline">
                <input class="layui-input" placeholder="结束时间" name="EndTime" lay-verify="time" value="<%=Model.EndTime==null?"":Model.EndTime %>" onclick="layui.laydate({ elem: this, min: laydate.now(0), istime: true, format: 'YYYY-MM-DD hh:00:00' })">
            </div>
        </div>

        <div class="layui-form-item">
            <label class="layui-form-label">广告类型</label>
            <div class="layui-input-block" id="adType">
                <input type="radio" name="AdType" value="0" lay-filter="typeItem" title="文本" <%=Model.AdType==0?"checked":"" %>>
                <input type="radio" name="AdType" value="1" lay-filter="typeItem" title="图片" <%=Model.AdType==1?"checked":"" %>>
                <input type="radio" name="AdType" value="2" lay-filter="typeItem" title="视频" <%=Model.AdType==2?"checked":"" %>>
            </div>
        </div>
        <div class="layui-form-item layui-form-text">
            <label class="layui-form-label">广告内容</label>
            <div class="layui-input-block">
                <textarea placeholder="请输入内容" name="AdText" class="layui-textarea"><%=Model.AdText==null?"":Model.AdText %></textarea>
            </div>
        </div>

        <div class="layui-form-item hide" id="uploadPanle">
            <label class="layui-form-label" style="height: 200px; line-height: 200px;">上传文件</label>
            <div class="layui-input-block">
                <div class="site-demo-upload">
                    <img id="viewPath" src="<%=Model.ThumbPath==null?"/Content/images/default.png":Model.ThumbPath %>">
                    <div class="site-demo-upbar">
                        <input type="file" name="file1" class="layui-upload-file" id="fileImage">
                    </div>
                </div>
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
            layui.use(['form', 'layedit', 'laydate', 'upload'], function () {
                var form = layui.form()
                , layer = layui.layer
                , layedit = layui.layedit,
                laydate = layui.laydate,
                upload = layui.upload

                //自定义验证规则
                form.verify({
                    time: function (value) {
                        if (value.length < 10) {
                            return '播放时间不能为空';
                        }
                    }
                });


                $("#eare").next().find("li[lay-value='<%=ViewData["eare"] %>']").click();
                

                form.on('radio(typeItem)', function (data) {
                    var adtype = data.value;
                    var ext = 'zip|rar|txt', type = 'file', title = '上传文件';
                    switch (adtype) {
                        case '0': ext = 'zip|rar|txt'; type = 'file'; title = '上传文件'; $("#uploadPanle").addClass("hide"); break;
                        case '1': ext = 'jpg|png|bmp|gif'; type = 'images'; title = '上传图片'; $("#uploadPanle").removeClass("hide"); break;
                        case '2': ext = 'mp4|flv|avi'; type = 'video'; title = '上传视频'; $("#uploadPanle").removeClass("hide"); break;
                    }

                    layui.upload({
                        url: '/AdManager/Upload',
                        elem: '#fileImage',  //指定原始元素，默认直接查找class="layui-upload-file" 
                        method: 'Post', //上传接口的http类型 
                        ext: ext,
                        type: type,
                        title: title,
                        before: function (input) {
                            //返回的参数item，即为当前的input DOM对象
                            layer.msg('文件上传中');
                        },
                        success: function (res) {

                            viewPath.src = res.thumbPath;
                            $("#AdPath").val(res.url);
                            $("#ThumbPath").val(res.thumbPath);
                        }
                    });
                });

                $('#adType').find(".layui-form-radioed").children("i").click();

            });

        });
    </script>
</asp:Content>
