<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="/Content/layui/css/layui.css" rel="stylesheet" />
    <link href="/Content/styles/map.css" rel="stylesheet" />
    <title>电子地图</title>
    <style type="text/css">
        html
        {
            height: 100%;
        }

        body
        {
            height: 100%;
            margin: 0px;
            padding: 0px;
        }
        .red
        {color:red;
        }
        #container
        {
            height: 100%;
        }
    </style>
    <script src="/Content/Scripts/jquery-1.10.2.min.js"></script>
    <script src="/Content/layui/layui.js"></script>
    <script type="text/javascript" src="http://api.map.baidu.com/api?v=2.0&ak=<%=ViewData["BaiduAK"] %>"></script>
</head>

<body>
    <div class="container">
        <form class="layui-form">
            <div class="cont-l">
                <div class="car-main">
                    <h2>当前区域车辆</h2>
                    <div>37辆</div>
                    <ul class="carList">
                        <li><i class="layui-icon">&#xe60c;</i>  车辆1</li>
                    </ul>
                </div>
            </div>
        </form>
        <div class="cont-r">
            <div id="container"></div>
        </div>
    </div>
    <script type="text/javascript">
 //默认为上海市地图
            var map = new BMap.Map("container");          // 创建地图实例   
            map.centerAndZoom("上海市", 12);                 // 初始化地图，设置中心点坐标和地图级别  
            map.addControl(new BMap.NavigationControl());

            //检查选定区域进行地图移动
            var eare = '<%=ViewData["Eare"]%>';
            var coo = '<%=ViewData["Coordinate"] %>';
        var ggPoint = getPoint(coo);


         
            layui.use(['layer', 'form'], function () {
                var layer = layui.layer
                , form = layui.form();


            });
            

            $().ready(function () {
                GetCurrentCar(eare);
                //坐标转换完之后的回调函数
                translateCallback = function (data) {
                    if (data.status === 0) {
                        map.setCenter(data.points[0]);
                        map.panTo(data.points[0]);
                        map.setZoom(13);
                    }
                }

                //坐标转换完之后的回调函数
                translateCallbackEare = function (data) {
                    if (data.status === 0) {
                        var markernew = new BMap.Marker(data.points[0]);
                        map.addOverlay(markernew);
                        map.setCenter(data.points[0]);
                        map.panTo(data.points[0]);
                        map.setZoom(13);
                    }
                }


                setTimeout(function () {
                    var convertor = new BMap.Convertor();
                    var pointArr = [];
                    pointArr.push(ggPoint);
                    convertor.translate(pointArr, 1, 5, translateCallback)
                }, 1000);

                //每3秒检查一次当前选定区域是否改变.改变时,变动地图中心点.
                setInterval("isChange()", "5000");

            });

        var isChange = function () {
            $.post("/MapManager/GetCurrentEare", function (data) {
                
                if (eare != data) {
                    
                    eare = data;
                    GetCurrentCar(eare);
                    $.post("/MapManager/GetCurrentCoordinate", function (data) {
                        var point = getPoint(data);
                        var convertor = new BMap.Convertor();
                        var pointArr = [];
                        pointArr.push(point);
                        convertor.translate(pointArr, 1, 5, translateCallback);

                    })
                }
            })
        }
        var GetCurrentCar = function (eare) {
            //加载当前区域车辆
            $.ajax({
                type: "post", 
                data:{eare:eare},
                url: "/MapManager/GetCurrentEareDevice",
                beforeSend: function () {
                    // &#xe63e;
                    $(".carList").html("<br/><br/><br/><br/><br/><span class='red'>GPS地区计算中,<br/>请稍侯... ...</span>");
                },
                success: function (data) {
                    var json = eval("(" + data + ")");
                    var html = "";
                    $.each(json.result, function (index, item) {
                        html += "<li did='" + item.deviceid + "'><i class=\"layui-icon\">&#xe60c;</i>  车辆" + item.id + "</li>";

                        var point = getPoint(item.lon+","+item.lat);
                        var convertor = new BMap.Convertor();
                        var pointArr = [];
                        pointArr.push(point);
                        convertor.translate(pointArr, 1, 5, translateCallbackEare);

                    });

                    $(".carList").html(html);
                },
                complete: function () {
                    //$("loading").hide();
                },
                error: function (data) {
                    //console.info("error: " + data.responseText);
                }
            });
        }
        //创建坐标点
        function getPoint(p) {
            var a = p.split(',');
            var lon = a[0] * 1;
            var lat = a[1] * 1;
            var ggPoint = new BMap.Point(lon, lat);

            return ggPoint;
        }
    </script>
</body>
</html>
