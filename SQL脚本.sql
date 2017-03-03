use OsirisDB
go

--drop table userinfo
--drop table DeviceInfo
--drop table Coordinate
--drop table DeviceAd

--create �û���
create table UserInfo
(
	Id int primary key not null identity (1,1),
	UserName varchar(20) not null,
	[Password] varchar(32) not null,
	HeadImage varchar(100) ,                       --ͷ��     +
	IsLock int not null default 0,                  --״̬
    IsAdmin bit not null default 0,                 --�Ƿ����Ա
	CreateTime datetime default getdate(),                            --����ʱ��
	UpdateTime datetime default getdate(),                            --�޸�ʱ��  
	Creator varchar(20),                            --������
	Remark nvarchar(50)
)
go
--�豸��
create table DeviceInfo
(
	Id int primary key not null identity (1,1),
	DeviceId varchar(20) not null, --�豸id
	Brightness varchar(10) ,       --����
	Temperature varchar(10),       --�¶�
	Powerwaste varchar(10),        --����
	ViewModel varchar(10),         --��ʾģʽ
	Switch varchar(10),            --���� 
	IsLock   bit default 0,        --�Ƿ����� 
	Longitude varchar(20),          --��γ��
	CreateTime datetime default getdate(),           --����ʱ��
	UpdateTime datetime default getdate(),           --�޸�ʱ��  
	Creator varchar(20),           --������
	Remark nvarchar(50)            --��ע
)
go
--�̶������
create table Coordinate
(
	Id int primary key not null identity (1,1),
	Eare nvarchar(5),               --����
	Longitude varchar(20),          --��γ��
	LogoName nvarchar(30),          --��־������
	CreateTime datetime default getdate(),            --����ʱ��
	UpdateTime datetime default getdate(),            --�޸�ʱ��  
	Creator varchar(20),            --������
	Remark nvarchar(50)
)
go
--����
create table DeviceAd
(
	Id int primary key not null identity (1,1),
	AdType int default 0,                         --�������: 0 ���� 1 ͼƬ 2 ��Ƶ
	AdText varchar(500),						  --����ı�   +
	AdPath varchar(100),                          --���·��
	ThumbUrl varchar(100),						  --����ͼ     +
	RepeatNum int ,                               --�ظ�����
	Eare nvarchar(10),                            --��������
	BeginTime datetime,                           --��ʼʱ��
	EndTime   datetime,                           --����ʱ��
	CreateTime datetime default getdate(),                          --����ʱ��
	UpdateTime datetime default getdate(),                          --�޸�ʱ��  
	Creator varchar(20),                          --������
	Remark nvarchar(50)
)



























