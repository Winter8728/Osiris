use OsirisDB
go

--drop table userinfo
--drop table DeviceInfo
--drop table Coordinate
--drop table DeviceAd

--create 用户表
create table UserInfo
(
	Id int primary key not null identity (1,1),
	UserName varchar(20) not null,
	[Password] varchar(32) not null,
	HeadImage varchar(100) ,                       --头像     +
	IsLock int not null default 0,                  --状态
    IsAdmin bit not null default 0,                 --是否管理员
	CreateTime datetime default getdate(),                            --创建时间
	UpdateTime datetime default getdate(),                            --修改时间  
	Creator varchar(20),                            --创建者
	Remark nvarchar(50)
)
go
--设备表
create table DeviceInfo
(
	Id int primary key not null identity (1,1),
	DeviceId varchar(20) not null, --设备id
	Brightness varchar(10) ,       --亮度
	Temperature varchar(10),       --温度
	Powerwaste varchar(10),        --功耗
	ViewModel varchar(10),         --显示模式
	Switch varchar(10),            --开关 
	IsLock   bit default 0,        --是否锁定 
	Longitude varchar(20),          --经纬度
	CreateTime datetime default getdate(),           --创建时间
	UpdateTime datetime default getdate(),           --修改时间  
	Creator varchar(20),           --创建者
	Remark nvarchar(50)            --备注
)
go
--固定坐标表
create table Coordinate
(
	Id int primary key not null identity (1,1),
	Eare nvarchar(5),               --区域
	Longitude varchar(20),          --经纬度
	LogoName nvarchar(30),          --标志物名称
	CreateTime datetime default getdate(),            --创建时间
	UpdateTime datetime default getdate(),            --修改时间  
	Creator varchar(20),            --创建者
	Remark nvarchar(50)
)
go
--广告表
create table DeviceAd
(
	Id int primary key not null identity (1,1),
	AdType int default 0,                         --广告类型: 0 文字 1 图片 2 视频
	AdText varchar(500),						  --广告文本   +
	AdPath varchar(100),                          --广告路径
	ThumbUrl varchar(100),						  --缩略图     +
	RepeatNum int ,                               --重复次数
	Eare nvarchar(10),                            --播放区域
	BeginTime datetime,                           --开始时间
	EndTime   datetime,                           --结束时间
	CreateTime datetime default getdate(),                          --创建时间
	UpdateTime datetime default getdate(),                          --修改时间  
	Creator varchar(20),                          --创建者
	Remark nvarchar(50)
)



























