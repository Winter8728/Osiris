﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/ConternMaster.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    用户管理
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="/Content/Scripts/jquery.pagination.js"></script>
    <script src="/Content/Scripts/tablecloth.js"></script>
    <link href="/Content/styles/pagination.css" rel="stylesheet" />
    <script type="text/javascript">    
        var pageIndex = 0;     //页面索引初始值
        var pageSize = 10;     //每页显示条数初始化，修改显示条数，修改这里即可
    
        $(function() {       
            InitTable(0);    //Load事件，初始化表格数据，页面索引为0（第一页）
                                                            
            //分页，PageCount是总条目数，这是必选参数，其它参数都是可选
            $("#Pagination").pagination(<%=ViewData["pageCount"] %>, {
                callback: PageCallback,
                prev_text: '上一页',       //上一页按钮里text
                next_text: '下一页',       //下一页按钮里text
                items_per_page: pageSize,  //显示条数
                num_display_entries: 6,    //连续分页主体部分分页条目数
                current_page: pageIndex,   //当前页索引
                num_edge_entries: 2        //两侧首尾分页条目数
            });
            
            //翻页调用
            function PageCallback(index, jq) {           
                InitTable(index);
            }

            //请求数据
            function InitTable(pageIndex) {                                
                $.ajax({ 
                    type: "POST",
                    dataType: "text",
                    url: '/UserManager/AllUserList',      //提交到一般处理程序请求数据
                    data: "index=" + (pageIndex + 1) + "&pageSize=" + pageSize,          //提交两个参数：pageIndex(页面索引)，pageSize(显示条数)                
                    success: function(data) {                                 
                        $("#Result tr:gt(0)").remove();        //移除Id为Result的表格里的行，从第二行开始（这里根据页面布局不同页变）
                        $("#Result").append(data);             //将返回的数据追加到表格
                    }
                });            
            } 
        });
     

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="public-nav">您当前的位置：<a href="">管理首页</a>><a href="">用户管理</a></div>
    <div class="public-content">
        <div class="public-content-cont">


            <div id="container">
                 <form class="layui-form" action=""  method="post">
                <table id="Result" cellspacing="0" cellpadding="0" class="public-cont-table">
                    <tr>
                        <th style="width: 5%">编号</th>
                        <th style="width: 10%">用户名</th>
                        <th style="width: 10%">是否锁定</th>
                        <th style="width: 15%">是否管理员</th>
                        <th style="width: 20%">创建时间</th>
                        <th style="width: 10%">创建人</th>
                        <th style="width: 30%">操作</th>
                    </tr>
                </table>
                     </form>
                <br />
                <div id="Pagination"></div>
            </div>

        </div>
    </div>
    <script>

        
        layui.use(['form', 'layedit'], function () {
            var form = layui.form()
            , layer = layui.layer;
                
                
            $("#Result").on("click","#btnDel",function(){
                layer.alert("11");
                layer.confirm('删除用户可能会导致用户数据异常,您确定要删除吗?', {
                    btn: ['删除','取消'] //按钮
                }, function(index, layero){
                    
                },function(index, layero){
                    
                })
                 
            }) 
        });

    </script>
</asp:Content>
