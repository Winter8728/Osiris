USE [OsirisDB]
GO
/****** Object:  StoredProcedure [dbo].[CheckUserInfo]    Script Date: 2016-10-9 14:37:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<witer chen>
-- Create date: <20161001>
-- Description:	<��ȡ���й��>
-- =============================================
alter PROCEDURE [dbo].[UserAdAll]
	@UserName varchar(20),
	@DeviceId varchar(30)
AS
BEGIN 
	SET NOCOUNT ON;
	if exists(select * from DeviceInfo where DeviceId=@DeviceId)
	begin
		if exists(select * from UserInfo where UserName=@UserName)
		begin
			if exists(select * from DeviceAd where Creator=@UserName and Eare='��')
			begin
				select * from DeviceAd where Creator=@UserName and Eare='��'
				return 0
			end
			else
				return 3  --��ǰ�û�δ�ϴ����
			
		end
		else
			return 2  --�û�������
	end
	else
		return 1  --deviceid δ��
END
