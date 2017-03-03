<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>  
<html>  
<head>  
<meta name="viewport" content="initial-scale=1.0, user-scalable=no" />  
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />  
<title>Hello, World</title>  
<style type="text/css">  
html{height:100%}  
body{height:100%;margin:0px;padding:0px}  
#container{height:100%}  
</style>  
    <script src="../../Content/Scripts/jquery-1.8.2.min.js"></script>
<script type="text/javascript" src="http://api.map.baidu.com/api?v=2.0&ak=KyFdnA9dXeQhNaijNfY5r6oeesHeI9uS
">
//v2.0版本的引用方式：src="http://api.map.baidu.com/api?v=2.0&ak=您的密钥"
//v1.4版本及以前版本的引用方式：src="http://api.map.baidu.com/api?v=1.4&key=您的密钥&callback=initialize"
</script>
</head>  
 
<body>  
<div id="container"></div> 
<script type="text/javascript">
    var map = new BMap.Map("container");          // 创建地图实例  
    var point = new BMap.Point(121.48, 31.23);  // 创建点坐标  
    map.centerAndZoom(point, 12);                 // 初始化地图，设置中心点坐标和地图级别  
    map.addControl(new BMap.NavigationControl());

    var marker = new BMap.Marker(point);        // 创建标注    
    map.addOverlay(marker);                     // 将标注添加到地图中
     
    
    function addMarker(point, index) {  // 创建图标对象   
         
        // 创建标注对象并添加到地图   
        var marker2 = new BMap.Marker(point );
        map.addOverlay(marker2);
    }

    window.setTimeout(function () {
       
        
    }, 5000);

    //移动标注
    //marker.enableDragging();
    //marker.addEventListener("dragend", function (e) {
    //    alert("当前位置：" + e.point.lng + ", " + e.point.lat);
    //})

    marker.addEventListener("click", function (e) {
        var bounds = map.getBounds();
        var lngSpan = bounds.maxX - bounds.minX;
        var latSpan = bounds.maxY - bounds.minY;

        alert(lngSpan);
        alert(bounds.minY + latSpan * (Math.random() * 0.7 + 0.15));

        for (var i = 0; i < 10; i++) {
            var point = new BMap.Point(bounds.minX + lngSpan * (Math.random() * 0.7 + 0.15),
                                       bounds.minY + latSpan * (Math.random() * 0.7 + 0.15));
             
            addMarker(point, i);
        }

        //var opts = {
        //    width: 250,     // 信息窗口宽度    
        //    height: 100,     // 信息窗口高度    
        //    title: "Hello"  // 信息窗口标题   
        //}
        //var infoWindow = new BMap.InfoWindow(e.point.lng + ", " + e.point.lat, opts);  // 创建信息窗口对象    
        //map.openInfoWindow(infoWindow, map.getCenter());      // 打开信息窗口
    });
     
    
</script>  
</body>  
</html>
