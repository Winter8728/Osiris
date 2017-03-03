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
-- Description:	<用户登录>
-- =============================================
alter PROCEDURE [dbo].[CheckUserInfo]
	@UserName varchar(20),
	@password varchar(32)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if exists(select * from UserInfo where  userName=@UserName)
	begin
		if exists(select * from UserInfo where  userName=@UserName and password=@password)
		begin
			if exists(select * from UserInfo where  userName=@UserName and password=@password and IsLock=0)
			begin
				return 0 
			end
			else
			return 3  --用户被锁定
		end
		else
		return 2  --密码错误
	end
	else
	return 1  --用户名不存在
END
