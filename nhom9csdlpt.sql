USE [QLDSV_TC]
GO
/****** Object:  User [HTKN]    Script Date: 12/06/2023 9:25:22 SA ******/
CREATE USER [HTKN] FOR LOGIN [HTKN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [MSmerge_5D6851FBEFBD4AEBA5E70CDC628E0266]    Script Date: 12/06/2023 9:25:22 SA ******/
CREATE ROLE [MSmerge_5D6851FBEFBD4AEBA5E70CDC628E0266]
GO
/****** Object:  DatabaseRole [MSmerge_7DDD83A822214403930414A71A53D5AA]    Script Date: 12/06/2023 9:25:22 SA ******/
CREATE ROLE [MSmerge_7DDD83A822214403930414A71A53D5AA]
GO
/****** Object:  DatabaseRole [MSmerge_9ADBAA8E80BB45838FBBF175BE5005C6]    Script Date: 12/06/2023 9:25:22 SA ******/
CREATE ROLE [MSmerge_9ADBAA8E80BB45838FBBF175BE5005C6]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 12/06/2023 9:25:22 SA ******/
CREATE ROLE [MSmerge_PAL_role]
GO
ALTER ROLE [db_owner] ADD MEMBER [HTKN]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_5D6851FBEFBD4AEBA5E70CDC628E0266]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_7DDD83A822214403930414A71A53D5AA]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_9ADBAA8E80BB45838FBBF175BE5005C6]
GO
/****** Object:  Schema [MSmerge_PAL_role]    Script Date: 12/06/2023 9:25:22 SA ******/
CREATE SCHEMA [MSmerge_PAL_role]
GO
/****** Object:  UserDefinedTableType [dbo].[TYPE_DANGKY]    Script Date: 12/06/2023 9:25:22 SA ******/
CREATE TYPE [dbo].[TYPE_DANGKY] AS TABLE(
	[MALTC] [int] NULL,
	[MASV] [nchar](10) NULL,
	[DIEM_CC] [int] NULL,
	[DIEM_GK] [float] NULL,
	[DIEM_CK] [float] NULL
)
GO
/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 12/06/2023 9:25:22 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DS_PHANMANH]
AS
	SELECT  TENKHOA=PUBS.description, TENSERVER= subscriber_server
	   FROM dbo.sysmergepublications PUBS,  dbo.sysmergesubscriptions SUBS
	   WHERE PUBS.pubid= SUBS.PUBID  AND PUBS.publisher <> SUBS.subscriber_server
GO
/****** Object:  Table [dbo].[CT_DONGHOCPHI]    Script Date: 12/06/2023 9:25:22 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_DONGHOCPHI](
	[MASV] [nchar](10) NOT NULL,
	[NIENKHOA] [nchar](9) NOT NULL,
	[HOCKY] [int] NOT NULL,
	[NGAYDONG] [date] NOT NULL,
	[SOTIENDONG] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CT_DONGHOCPHI] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[NIENKHOA] ASC,
	[HOCKY] ASC,
	[NGAYDONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANGKY]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGKY](
	[MALTC] [int] NOT NULL,
	[MASV] [nchar](10) NOT NULL,
	[DIEM_CC] [int] NULL,
	[DIEM_GK] [float] NULL,
	[DIEM_CK] [float] NULL,
	[HUYDANGKY] [bit] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_DANGKY] PRIMARY KEY CLUSTERED 
(
	[MALTC] ASC,
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_DANGKY] UNIQUE NONCLUSTERED 
(
	[MALTC] ASC,
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[MAGV] [nchar](10) NOT NULL,
	[MAKHOA] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[HOCVI] [nvarchar](20) NULL,
	[HOCHAM] [nvarchar](20) NULL,
	[CHUYENMON] [nvarchar](50) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_GIANGVIEN] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOCPHI]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOCPHI](
	[MASV] [nchar](10) NOT NULL,
	[NIENKHOA] [nchar](9) NOT NULL,
	[HOCKY] [int] NOT NULL,
	[HOCPHI] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_HOCPHI] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[NIENKHOA] ASC,
	[HOCKY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKHOA] [nchar](10) NOT NULL,
	[TENKHOA] [nvarchar](50) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MAKHOA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [nchar](10) NOT NULL,
	[TENLOP] [nvarchar](50) NOT NULL,
	[KHOAHOC] [nchar](9) NOT NULL,
	[MAKHOA] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOPTINCHI]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOPTINCHI](
	[MALTC] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[NIENKHOA] [nchar](9) NOT NULL,
	[HOCKY] [int] NOT NULL,
	[MAMH] [nchar](10) NOT NULL,
	[NHOM] [int] NOT NULL,
	[MAGV] [nchar](10) NOT NULL,
	[MAKHOA] [nchar](10) NOT NULL,
	[SOSVTOITHIEU] [int] NOT NULL,
	[HUYLOP] [bit] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_LOPTINCHI] PRIMARY KEY CLUSTERED 
(
	[MALTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_LOPTINCHI] UNIQUE NONCLUSTERED 
(
	[NIENKHOA] ASC,
	[HOCKY] ASC,
	[MAMH] ASC,
	[NHOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [nchar](10) NOT NULL,
	[TENMH] [nvarchar](50) NOT NULL,
	[SOTIET_LT] [int] NOT NULL,
	[SOTIET_TH] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[PHAI] [bit] NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[NGAYSINH] [date] NULL,
	[MALOP] [nchar](10) NOT NULL,
	[DANGHIHOC] [bit] NOT NULL,
	[PASSWORD] [nvarchar](40) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_DONGHOCPHI] ADD  CONSTRAINT [DF_CT_DONGHOCPHI_NGAYDONG]  DEFAULT (getdate()) FOR [NGAYDONG]
GO
ALTER TABLE [dbo].[CT_DONGHOCPHI] ADD  CONSTRAINT [MSmerge_df_rowguid_345EAB9A17154A56AD2BF30581D2C84A]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[DANGKY] ADD  CONSTRAINT [MSmerge_df_rowguid_57BB49A4AE174610BA72059555D18466]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GIANGVIEN] ADD  CONSTRAINT [MSmerge_df_rowguid_8E6326C3788346F3A70FD7CC5652B3BE]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[HOCPHI] ADD  CONSTRAINT [DF_HOCPHI_HOCKY]  DEFAULT ((1)) FOR [HOCKY]
GO
ALTER TABLE [dbo].[HOCPHI] ADD  CONSTRAINT [DF_HOCPHI_HOCPHI]  DEFAULT ((6000000)) FOR [HOCPHI]
GO
ALTER TABLE [dbo].[HOCPHI] ADD  CONSTRAINT [MSmerge_df_rowguid_01144806ECDB4740A7365F79D2CA90F8]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[KHOA] ADD  CONSTRAINT [MSmerge_df_rowguid_8D5FA77D348740619E0A692B7363E455]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[LOP] ADD  CONSTRAINT [MSmerge_df_rowguid_1011C54E762848159E8407B564DC8B75]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[LOPTINCHI] ADD  CONSTRAINT [DF_LOPTINCHI_HUYLOP]  DEFAULT ('false') FOR [HUYLOP]
GO
ALTER TABLE [dbo].[LOPTINCHI] ADD  CONSTRAINT [MSmerge_df_rowguid_54D2AB0D6ECB4C6AA4C79BDF1D9B6343]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[MONHOC] ADD  CONSTRAINT [MSmerge_df_rowguid_32BBC6EE319E4F878468211FCF3CB9EC]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[SINHVIEN] ADD  CONSTRAINT [DF_SINHVIEN_PHAI]  DEFAULT ('false') FOR [PHAI]
GO
ALTER TABLE [dbo].[SINHVIEN] ADD  CONSTRAINT [DF_SINHVIEN_DANGHIHOC]  DEFAULT ('false') FOR [DANGHIHOC]
GO
ALTER TABLE [dbo].[SINHVIEN] ADD  CONSTRAINT [DF_SINHVIEN_PASSWORD]  DEFAULT ('') FOR [PASSWORD]
GO
ALTER TABLE [dbo].[SINHVIEN] ADD  CONSTRAINT [MSmerge_df_rowguid_C3EA20FF0B5C4469A4E38FB7E4100E9A]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[CT_DONGHOCPHI]  WITH CHECK ADD  CONSTRAINT [FK_CT_DONGHOCPHI_HOCPHI] FOREIGN KEY([MASV], [NIENKHOA], [HOCKY])
REFERENCES [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY])
GO
ALTER TABLE [dbo].[CT_DONGHOCPHI] CHECK CONSTRAINT [FK_CT_DONGHOCPHI_HOCPHI]
GO
ALTER TABLE [dbo].[DANGKY]  WITH CHECK ADD  CONSTRAINT [FK_CTLTC_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DANGKY] CHECK CONSTRAINT [FK_CTLTC_SINHVIEN]
GO
ALTER TABLE [dbo].[DANGKY]  WITH CHECK ADD  CONSTRAINT [FK_DANGKY_LOPTINCHI] FOREIGN KEY([MALTC])
REFERENCES [dbo].[LOPTINCHI] ([MALTC])
GO
ALTER TABLE [dbo].[DANGKY] CHECK CONSTRAINT [FK_DANGKY_LOPTINCHI]
GO
ALTER TABLE [dbo].[GIANGVIEN]  WITH CHECK ADD  CONSTRAINT [FK_GIANGVIEN_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
GO
ALTER TABLE [dbo].[GIANGVIEN] CHECK CONSTRAINT [FK_GIANGVIEN_KHOA]
GO
ALTER TABLE [dbo].[HOCPHI]  WITH CHECK ADD  CONSTRAINT [FK_HOCPHI_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[HOCPHI] CHECK CONSTRAINT [FK_HOCPHI_SINHVIEN]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_KHOA]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH CHECK ADD  CONSTRAINT [FK_LOPTINCHI_GIANGVIEN] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIANGVIEN] ([MAGV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [FK_LOPTINCHI_GIANGVIEN]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH CHECK ADD  CONSTRAINT [FK_LOPTINCHI_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [FK_LOPTINCHI_KHOA]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH CHECK ADD  CONSTRAINT [FK_LOPTINCHI_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [FK_LOPTINCHI_MONHOC]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[CT_DONGHOCPHI]  WITH CHECK ADD  CONSTRAINT [CK_SOTIENDONG] CHECK  (([SOTIENDONG]>(0)))
GO
ALTER TABLE [dbo].[CT_DONGHOCPHI] CHECK CONSTRAINT [CK_SOTIENDONG]
GO
ALTER TABLE [dbo].[HOCPHI]  WITH CHECK ADD  CONSTRAINT [CK_HOCKY] CHECK  (([HOCKY]>=(1) AND [HOCKY]<=(4)))
GO
ALTER TABLE [dbo].[HOCPHI] CHECK CONSTRAINT [CK_HOCKY]
GO
ALTER TABLE [dbo].[HOCPHI]  WITH CHECK ADD  CONSTRAINT [CK_HOCPHI] CHECK  (([HOCPHI]>(0)))
GO
ALTER TABLE [dbo].[HOCPHI] CHECK CONSTRAINT [CK_HOCPHI]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH CHECK ADD  CONSTRAINT [CK_SOSVTOITHIEU] CHECK  (([SOSVTOITHIEU]>(0)))
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [CK_SOSVTOITHIEU]
GO
ALTER TABLE [dbo].[LOPTINCHI]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_8537E885_0883_4173_A750_697BF7627DCA] CHECK NOT FOR REPLICATION (([MALTC]>(8) AND [MALTC]<=(1008) OR [MALTC]>(1008) AND [MALTC]<=(2008)))
GO
ALTER TABLE [dbo].[LOPTINCHI] CHECK CONSTRAINT [repl_identity_range_8537E885_0883_4173_A750_697BF7627DCA]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKLOPTINCHI]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_CHECKLOPTINCHI]
@maltc int, @mamh nchar(10), @nienkhoa nchar(9),@hocky int, @nhom int
as
	IF exists(select HOCKY from LOPTINCHI where MAMH = @mamh AND NIENKHOA = @nienkhoa AND HOCKY = @hocky AND NHOM = @nhom)
	Begin
		return 1
	end
	else
	if exists(select HOCKY from LINK1.QLDSV_TC.DBO.LOPTINCHI where   MAMH = @mamh AND NIENKHOA = @nienkhoa AND HOCKY = @hocky AND NHOM = @nhom)
	Begin
		return 2
	End
	else
		return 0
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKMALOP]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_CHECKMALOP]
@X nchar(10)
AS
	
	IF exists(select MALOP from LOP where MALOP = @X)
	Begin
		return 1
	end
	else
	if exists(select MALOP from LINK1.QLDSV_TC.DBO.LOP where MALOP = @X)
	Begin
		return 2
	End
	else
		return 0
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKMAMH]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_CHECKMAMH]
@X nchar(10)
AS
	
	IF exists(select MAMH from MONHOC where MAMH = @X)
	Begin
		return 1
	end
	else
	if exists(select MAMH from LINK1.QLDSV_TC.DBO.MONHOC where MAMH = @X)
	Begin
		return 2
	End
	else
		return 0
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKMASV]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_CHECKMASV]
@X nchar(10)
AS
	
	IF exists(select MASV from SINHVIEN where MASV = @X)
	Begin
		return 1
	end
	else
	if exists(select MASV from LINK1.QLDSV_TC.DBO.SINHVIEN where MASV = @X)
	Begin
		return 2
	End
	else
		return 0
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKMASV_SONGSONG]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHECKMASV_SONGSONG]
	@MASV nchar(10)
AS
BEGIN
	SET XACT_ABORT ON 
	BEGIN DISTRIBUTED TRANSACTION;
    DECLARE @STR1 NVARCHAR(400)
	DECLARE @RESULT INT
    SET @STR1='EXEC SP_CHECKMASV '+ '''' + @MASV + '''' + ', ' + STR(@RESULT) + ' OUTPUT'
    IF  EXISTS (SELECT job_id FROM msdb.dbo.sysjobs_view WHERE name = N'Job_1')
        EXEC msdb.dbo.sp_delete_job @job_name=N'Job_1' 
    
    EXECUTE msdb.dbo.sp_add_job @job_name = N'Job_1', @start_step_id = 1
    EXECUTE msdb.dbo.sp_add_jobserver  @job_name = N'Job_1', @server_name =  @@SERVERNAME
    EXECUTE msdb.dbo.sp_add_jobstep  @job_name =  N'Job_1' , @step_id = 1, @step_name = 'Check student number', @command =  @STR1 ,   @server = @@SERVERNAME, @database_name = 'QLDSV_TC'
    EXECUTE msdb.dbo.sp_start_job    @job_name =  N'Job_1'

	EXEC LINK1.QLDSV_TC.DBO.SP_CHECKMASV @MASV, @RESULT OUTPUT
	RETURN @RESULT
	COMMIT TRANSACTION;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKTENLOP]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_CHECKTENLOP]
 @Y nchar(10),@X nvarchar(50)
AS
	
	IF exists(select TENLOP from LOP where TENLOP = @X AND MALOP = @Y)
	Begin
		return 1
	end
	else
	if exists(select TENLOP from LINK1.QLDSV_TC.DBO.LOP where TENLOP = @X AND MALOP = @Y)
	Begin
		return 2
	End
	else
		return 0
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKTENMH]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_CHECKTENMH]
@X nchar(10),@Y nvarchar(50)
AS
	
	IF exists(select TENLOP from LOP where MALOP = @X AND TENLOP = @Y)
	Begin
		return 1
	end
	else
	if exists(select MALOP from LINK1.QLDSV_TC.DBO.LOP where MALOP = @X  AND TENLOP = @Y)
	Begin
		return 2
	End
	else
		return 0
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
BEGIN
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM GIANGVIEN WHERE MAGV = @TENUSER ),
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DELETE_DKY_SV]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DELETE_DKY_SV]
	@MALTC INT,
	@NIENKHOA NCHAR(9),
	@HOCKY INT,
	@MASV NCHAR(10), 
	@CHIPHI INT
AS
BEGIN
	--KIỂM TRA SINH VIÊN ĐÃ ĐÓNG HỌC PHÍ CHƯA
	IF EXISTS(SELECT 1 FROM LINK2.QLDSV_TC.DBO.CT_DONGHOCPHI CT WHERE CT.MASV = @MASV AND CT.NIENKHOA = @NIENKHOA AND CT.HOCKY = @HOCKY)
	BEGIN
		RAISERROR ('Sinh viên đã hết thời hạn hủy đăng ký', 16, 1)
		RETURN
	END
	
	SET XACT_ABORT ON 
	BEGIN DISTRIBUTED TRANSACTION;

	--CẬP NHẬP TRẠNG THÁI ĐĂNG KÝ 
	UPDATE DANGKY SET HUYDANGKY = 1 WHERE DANGKY.MASV = @MASV AND DANGKY.MALTC = @MALTC

	--TÍNH LẠI TỔNG HỌC PHÍ TRONG HỌC KỲ VÀ NIÊN KHÓA ĐÓ
	DECLARE @TONGTIET INT, @HOCPHI INT
	SELECT @TONGTIET = MONHOC.SOTIET_LT + MONHOC.SOTIET_TH 
	FROM (SELECT MAMH FROM LOPTINCHI WHERE MALTC = @MALTC) LTC, MONHOC WHERE LTC.MAMH=MONHOC.MAMH 

	---------lấy kết quả tính được của tổng học phí sau khi hủy đk--------------
	SET @HOCPHI = (SELECT HP.HOCPHI FROM LINK2.QLDSV_TC.DBO.HOCPHI HP 
	WHERE HP.MASV=@MASV AND HP.NIENKHOA=@NIENKHOA AND HP.HOCKY=@HOCKY)-(@TONGTIET/15)*@CHIPHI

	--------- Xét xem học phí sau khi trừ có bằng 0 hay không, nếu bằng 0 thì xóa còn không thì cập nhật lại --------------
	IF @HOCPHI>0
	BEGIN
		UPDATE LINK2.QLDSV_TC.DBO.HOCPHI SET HOCPHI-=(@TONGTIET/15)*@CHIPHI WHERE MASV=@MASV AND NIENKHOA=@NIENKHOA AND HOCKY=@HOCKY
	END
	ELSE
	BEGIN
		DELETE FROM LINK2.QLDSV_TC.DBO.HOCPHI WHERE MASV=@MASV AND NIENKHOA=@NIENKHOA AND HOCKY=@HOCKY
	END
	COMMIT TRANSACTION;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DKY_LOPTINCHI]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DKY_LOPTINCHI]
	@MALTC INT,
	@NIENKHOA NCHAR(9),
	@HOCKY INT,
	@MAMH NCHAR(10),
	@MASV NCHAR(10), 
	@CHIPHI INT
AS
BEGIN
	IF EXISTS(SELECT 1 FROM (SELECT MALTC FROM DANGKY WHERE MASV=@MASV AND HUYDANGKY=0) DK, 
							(SELECT MALTC FROM LOPTINCHI WHERE MAMH=@MAMH AND NIENKHOA=@NIENKHOA AND HOCKY=@HOCKY) LTC
							 WHERE  DK.MALTC = LTC.MALTC)
	BEGIN
		RAISERROR('Bạn đã đăng ký lớp này',16,1)
		RETURN
	END

	ELSE IF EXISTS(SELECT 1 FROM LINK2.QLDSV_TC.DBO.CT_DONGHOCPHI WHERE MASV = @MASV AND NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY)
	BEGIN
		RAISERROR('Bạn đã hết thời hạn đăng ký',16,1)
		RETURN
	END
	
	SET XACT_ABORT ON 
	BEGIN DISTRIBUTED TRANSACTION;
	-------------------------------- UPDATE DANGKY ------------------------------------------------.
	IF EXISTS(SELECT 1 FROM DANGKY DK WHERE DK.MASV=@MASV AND DK.MALTC=@MALTC AND DK.HUYDANGKY=1)
	BEGIN
		UPDATE DANGKY SET HUYDANGKY=0 WHERE MASV=@MASV AND MALTC=@MALTC 
	END
	ELSE
	BEGIN
		INSERT INTO DANGKY(MALTC, MASV, HUYDANGKY) VALUES (@MALTC, @MASV, 0)
	END

	-------------------- Cập nhật học phí khi đã đăng ký thành công --------------------------------
	DECLARE @TONGTIET INT

	SELECT @TONGTIET = MH.SOTIET_LT + MH.SOTIET_TH
	FROM (SELECT MAMH FROM LOPTINCHI WHERE MALTC=@MALTC) LTC, 
		MONHOC MH 
		WHERE LTC.MAMH = MH.MAMH 

	-------------------- Cộng vào học phí nếu trước đó đã đăng ký môn nào đó.--------------------------------
	IF EXISTS(SELECT 1 FROM LINK2.QLDSV_TC.DBO.HOCPHI HP WHERE HP.MASV = @MASV AND HP.NIENKHOA = @NIENKHOA AND HP.HOCKY = @HOCKY)
	BEGIN
		UPDATE LINK2.QLDSV_TC.DBO.HOCPHI 
		SET HOCPHI += (@TONGTIET/15) * @CHIPHI 
		WHERE MASV = @MASV AND NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY
	END

	-------------------- Ngược lại sẽ thêm mới học phí nếu trước đó chưa từng đăng ký --------------------------------
	ELSE
	BEGIN
		INSERT INTO LINK2.QLDSV_TC.DBO.HOCPHI(MASV,NIENKHOA,HOCKY,HOCPHI) 
		VALUES (@MASV, @NIENKHOA, @HOCKY, (@TONGTIET/15) * @CHIPHI)
	END
	COMMIT TRANSACTION;
END



GO
/****** Object:  StoredProcedure [dbo].[SP_DSDK_SV]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DSDK_SV]
	@MASV NCHAR(10), 
	@NIENKHOA NCHAR(9),
	@HOCKY INT, 
	@CHIPHI INT
AS
BEGIN
	SELECT LTC.MALTC, LTC.MAMH, MH.TENMH, LTC.NHOM, MH.SOTIET_LT, MH.SOTIET_TH, STC=(MH.SOTIET_LT + MH.SOTIET_TH)/15, HOCPHI=((MH.SOTIET_LT + MH.SOTIET_TH)/15)* @CHIPHI
	FROM 
	(SELECT MALTC FROM DANGKY WHERE MASV = @MASV  AND HUYDANGKY=0) DK, 
	(SELECT MALTC, MAMH, NHOM FROM LOPTINCHI WHERE NIENKHOA= @NIENKHOA AND HOCKY= @HOCKY) LTC,
	MONHOC MH
	WHERE DK.MALTC=LTC.MALTC AND LTC.MAMH= MH.MAMH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GETCTHOCPHI]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GETCTHOCPHI] 
	@MASV NCHAR(10),
	@NIENKHOA NCHAR(9),
	@HOCKY INT
AS
BEGIN
	SELECT CT.NGAYDONG,CT.SOTIENDONG  FROM CT_DONGHOCPHI CT
	WHERE CT.MASV = @MASV AND CT.NIENKHOA = @NIENKHOA AND CT.HOCKY = @HOCKY
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GETDSLTC_NK_HK]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GETDSLTC_NK_HK] 
	@NIENKHOA NCHAR(9), 
	@HOCKY INT
AS
BEGIN
	SELECT LTC.MALTC, MH.MAMH, MH.TENMH, LTC.NHOM,  GV.HO + ' ' + GV.TEN AS HOTEN
		, SOSV = ISNULL((SELECT COUNT(DK.MALTC) FROM DANGKY DK WHERE DK.MALTC = LTC.MALTC AND DK.HUYDANGKY=0 GROUP BY DK.MALTC), 0)
	FROM 
		(SELECT MALTC, MAMH, NHOM, MAGV  FROM LOPTINCHI WHERE NIENKHOA = @NIENKHOA AND HOCKY=@HOCKY AND HUYLOP = 0) LTC,
		(SELECT MAMH, TENMH FROM MONHOC) MH, 
		(SELECT MAGV, HO, TEN FROM GIANGVIEN) GV
	WHERE MH.MAMH = LTC.MAMH AND GV.MAGV = LTC.MAGV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GETHOCPHI_SV]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GETHOCPHI_SV]
	@MASV NCHAR(10)
AS
BEGIN
	SELECT HP.MASV, HP.NIENKHOA, HP.HOCKY, HP.HOCPHI ,
	PAID = ISNULL(SUM(CTHP.SOTIENDONG), 0)
	FROM 
	(SELECT * FROM HOCPHI WHERE HOCPHI.MASV = @MASV) HP 
	LEFT JOIN
	(SELECT * FROM CT_DONGHOCPHI WHERE CT_DONGHOCPHI.MASV = @MASV) CTHP
	ON (HP.NIENKHOA = CTHP.NIENKHOA AND HP.HOCKY = CTHP.HOCKY)
	GROUP BY HP.MASV, HP.NIENKHOA, HP.HOCKY, HP.HOCPHI
	ORDER BY HP.NIENKHOA, HP.HOCKY ASC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GETKHOAHOC_SV]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GETKHOAHOC_SV]
	@MASV NCHAR(10)
AS
BEGIN
	DECLARE @MALOP NCHAR(10)
	SET @MALOP = (SELECT MALOP FROM SINHVIEN WHERE MASV = @MASV)

	SELECT KHOAHOC FROM LOP
	WHERE MALOP = @MALOP
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GETMONHOC_NK_HK]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_GETMONHOC_NK_HK]
@nienkhoa nchar(9), @hocky int
as
select distinct(ltc.MAMH), mh.TENMH from LOPTINCHI as ltc,MONHOC as mh where NIENKHOA = @nienkhoa AND HOCKY = @hocky and ltc.MAMH = mh.MAMH
GO
/****** Object:  StoredProcedure [dbo].[SP_GETNHOM_NK_HK_MH]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_GETNHOM_NK_HK_MH]
@nienkhoa nchar(9), @hocky int, @mamh nchar(10)
as
select MALTC,NHOM,ltc.MAGV,HOTEN = HO + ' ' + TEN from LOPTINCHI as ltc,GIANGVIEN as gv where NIENKHOA = @nienkhoa AND HOCKY = @hocky AND MAMH = @mamh AND ltc.MAGV = gv.MAGV
GO
/****** Object:  StoredProcedure [dbo].[SP_GETTHONGTINSV]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GETTHONGTINSV]
	@MASV NCHAR(10)
AS
BEGIN
	SELECT HOTEN = HO + ' ' + TEN, MALOP FROM SINHVIEN
	WHERE MASV = @MASV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_DS_LTC]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAY_DS_LTC]
	@NK NVARCHAR(10), 
	@HK INT
AS
BEGIN
	SELECT MALTC, TENMH, HOTEN = HO + ' ' + TEN
	FROM (SELECT MALTC, MAMH, NHOM, MAGV FROM LOPTINCHI 
	WHERE NIENKHOA = @NK AND HOCKY = @HK AND HUYLOP = 'FALSE') LTC,
	MONHOC MH, GIANGVIEN GV
	WHERE LTC.MAMH = MH.MAMH AND LTC.MAGV = GV.MAGV
	ORDER BY TENMH, NHOM
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_DSSV_DANGKY]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAY_DSSV_DANGKY]
	@MALTC INT
AS
BEGIN
	SELECT SV.MASV, HOTENSV = HO + ' ' + TEN, DIEM_CC, DIEM_GK, DIEM_CK
		FROM (SELECT MASV, DIEM_CC, DIEM_GK, DIEM_CK FROM DANGKY WHERE MALTC = @MALTC AND HUYDANGKY = 'FALSE') DSDK,
		SINHVIEN SV
		WHERE DSDK.MASV = SV.MASV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PAY_TUITION]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_PAY_TUITION]
	@MASV NCHAR(10),
	@NIENKHOA NCHAR(9),
	@HOCKY INT,
	@NGAYDONG DATETIME,
	@SOTIENDONG INT
AS
BEGIN
	IF EXISTS(SELECT 1 FROM CT_DONGHOCPHI WHERE NGAYDONG = @NGAYDONG AND MASV = @MASV AND NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY)
		UPDATE CT_DONGHOCPHI SET SOTIENDONG += @SOTIENDONG WHERE NGAYDONG = @NGAYDONG AND MASV = @MASV AND NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY
	ELSE
		INSERT INTO CT_DONGHOCPHI(MASV,NIENKHOA,HOCKY,NGAYDONG,SOTIENDONG) values(@MASV, @NIENKHOA, @HOCKY, @NGAYDONG, @SOTIENDONG)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_GETFINALSCORESOFCLASS]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REPORT_GETFINALSCORESOFCLASS]
	@MALOP NCHAR(10)
AS
BEGIN
	DECLARE 
	@cols NVARCHAR(MAX) = '',
	@query NVARCHAR(MAX);


	SELECT @cols += QUOTENAME(TENMH) + ','
	FROM MONHOC
	SET @cols = LEFT(@cols, LEN(@cols) - 1);

	SET @query = '
		SELECT *
		FROM (SELECT SV.MASV, SV.HO, SV.TEN, DK.DIEM, TENMH
		FROM ((SELECT MASV, HO, TEN FROM SINHVIEN WHERE MALOP = '''+ @MALOP + ''' AND DANGHIHOC = 0) SV 
		LEFT JOIN (SELECT MALTC, MASV, DIEM = MAX(DIEM_CC * 0.1 + DIEM_GK * 0.3 + DIEM_CK * 0.6) FROM DANGKY WHERE HUYDANGKY = 0 GROUP BY MALTC, MASV) DK ON SV.MASV = DK.MASV
		LEFT JOIN (SELECT MALTC, MAMH FROM LOPTINCHI WHERE HUYLOP = 0) LTC ON LTC.MALTC = DK.MALTC
		LEFT JOIN (SELECT MAMH, TENMH FROM MONHOC) MH ON MH.MAMH = LTC.MAMH)) SourceTable
		PIVOT
		( 
			MAX(DIEM)
			FOR TENMH IN (' + @cols + ')
		) AS PivotTable'
	EXEC (@query)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_GETFINALSCORESOFCLASS2]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REPORT_GETFINALSCORESOFCLASS2]
	@MALOP NCHAR(10)
AS
BEGIN
	DECLARE 
	@cols NVARCHAR(MAX) = '',
	@query NVARCHAR(MAX);


	SELECT @cols += QUOTENAME(TENMH) + ','
	FROM MONHOC
	SET @cols = LEFT(@cols, LEN(@cols) - 1);

	SET @query = '
		SELECT *
		FROM (SELECT SV.MASV, SV.HO, SV.TEN, DK.DIEM, TENMH
		FROM ((SELECT MASV, HO, TEN FROM SINHVIEN WHERE MALOP = '''+ @MALOP + ''' AND DANGHIHOC = 0) SV 
		LEFT JOIN (SELECT MALTC, MASV, DIEM = MAX(DIEM_CC * 0.1 + DIEM_GK * 0.3 + DIEM_CK * 0.6) FROM DANGKY WHERE HUYDANGKY = 0 GROUP BY MALTC, MASV) DK ON SV.MASV = DK.MASV
		LEFT JOIN (SELECT MALTC, MAMH FROM LOPTINCHI WHERE HUYLOP = 0) LTC ON LTC.MALTC = DK.MALTC
		LEFT JOIN (SELECT MAMH, TENMH FROM MONHOC) MH ON MH.MAMH = LTC.MAMH)) SourceTable
		PIVOT
		( 
			MAX(DIEM)
			FOR TENMH IN (' + @cols + ')
		) AS PivotTable'
	EXEC (@query)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_GETLISTCREDITCLASS]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REPORT_GETLISTCREDITCLASS]
	@NIENKHOA NCHAR(9),
	@HOCKY INT
AS
BEGIN
	SELECT MH.TENMH, LTC.NHOM, HOTENGV = GV.HO + ' ' + GV.TEN, LTC.SOSVTOITHIEU, SOSVDADANGKY = COUNT(DK.MALTC)
	FROM (SELECT MALTC, MAMH, NHOM, MAGV, SOSVTOITHIEU FROM LOPTINCHI WHERE NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY AND HUYLOP = 0) LTC
	INNER JOIN (SELECT MALTC FROM DANGKY) DK ON DK.MALTC = LTC.MALTC
	INNER JOIN (SELECT MAMH, TENMH FROM MONHOC) MH ON MH.MAMH = LTC.MAMH
	INNER JOIN (SELECT MAGV, HO, TEN FROM GIANGVIEN) GV ON GV.MAGV = LTC.MAGV
	GROUP BY MH.TENMH, LTC.NHOM, GV.HO + ' ' + GV.TEN, LTC.SOSVTOITHIEU
	ORDER BY MH.TENMH, LTC.NHOM
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_GETLISTPAYTUITIONOFCLASS]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REPORT_GETLISTPAYTUITIONOFCLASS]
	@MALOP NCHAR(10),
	@NIENKHOA NCHAR(9),
	@HOCKY INT
AS
BEGIN
	SELECT SV.MASV, HOTEN = SV.HO + ' ' + SV.TEN, HP.HOCPHI, PAID
	FROM (SELECT MASV, HO, TEN FROM SINHVIEN WHERE MALOP = @MALOP AND DANGHIHOC = 0) SV
	LEFT JOIN (SELECT MASV, HOCPHI FROM HOCPHI WHERE NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY) HP ON HP.MASV = SV.MASV
	LEFT JOIN (SELECT MASV, PAID = SUM(SOTIENDONG) FROM CT_DONGHOCPHI WHERE NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY GROUP BY MASV) CTDHP ON CTDHP.MASV = SV.MASV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_GETSCORESCREDITCLASS]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REPORT_GETSCORESCREDITCLASS]
	@NIENKHOA NCHAR(9),
	@HOCKY INT,
	@MONHOC NCHAR(10),
	@NHOM INT
AS
BEGIN
	DECLARE @MALTC INT
	SET @MALTC = (SELECT MALTC FROM LOPTINCHI 
	WHERE NIENKHOA = @NIENKHOA AND MAMH = @MONHOC AND NHOM = @NHOM AND HOCKY = @HOCKY AND HUYLOP = 0)

	IF @MALTC IS NULL
		RETURN
	ELSE
		SELECT DK.MASV, SV.HO, SV.TEN, DK.DIEM_CC, DK.DIEM_GK, DK.DIEM_CK
		FROM (SELECT MASV, DIEM_CC, DIEM_GK, DIEM_CK FROM DANGKY WHERE MALTC = @MALTC AND HUYDANGKY = 0) DK
		INNER JOIN (SELECT MASV, HO, TEN FROM SINHVIEN) SV ON SV.MASV = DK.MASV
		ORDER BY SV.TEN, SV.HO, DK.MASV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_GETSTUDENTSCORES]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REPORT_GETSTUDENTSCORES]
	@MASV NCHAR(10)
AS
BEGIN
	SELECT MH.TENMH, DIEM = MAX(0.1 * DK.DIEM_CC + 0.3 * DIEM_GK + 0.6 * DIEM_CK)
	FROM (SELECT MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK FROM DANGKY WHERE MASV = @MASV AND HUYDANGKY = 0) DK
	INNER JOIN (SELECT MALTC, MAMH FROM LOPTINCHI) LTC ON LTC.MALTC = DK.MALTC
	INNER JOIN (SELECT MAMH, TENMH FROM MONHOC) MH ON MH.MAMH = LTC.MAMH
	GROUP BY MH.TENMH
	ORDER BY MH.TENMH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORT_GETSTUDENTSLISTCREDITCLASS]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REPORT_GETSTUDENTSLISTCREDITCLASS]
	@NIENKHOA NCHAR(9),
	@HOCKY INT,
	@MONHOC NCHAR(10),
	@NHOM INT
AS
BEGIN
	DECLARE @MALTC INT
	SET @MALTC = (SELECT MALTC FROM LOPTINCHI 
	WHERE NIENKHOA = @NIENKHOA AND MAMH = @MONHOC AND NHOM = @NHOM AND HOCKY = @HOCKY AND HUYLOP = 0)
	
	IF @MALTC IS NULL
		RETURN
	ELSE
		SELECT DK.MASV, SV.HO, SV.TEN, SV.PHAI, SV.MALOP
		FROM 
		(SELECT MASV FROM DANGKY WHERE MALTC = @MALTC AND HUYDANGKY = 0) DK 
		INNER JOIN (SELECT MASV, HO, TEN, PHAI, MALOP FROM SINHVIEN) SV ON SV.MASV = DK.MASV
		ORDER BY SV.TEN, SV.HO, DK.MASV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SV_DANGNHAP]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SV_DANGNHAP]
	@MASV NCHAR(10), 
	@PASSWORD nvarchar(40)
AS
BEGIN
	IF EXISTS (SELECT * FROM SINHVIEN WHERE MASV = @MASV AND PASSWORD = @PASSWORD)
	BEGIN
		SELECT USERNAME = @MASV, 
			   HOTEN = (SELECT HO+ ' '+ TEN FROM SINHVIEN WHERE MASV = @MASV AND PASSWORD = @PASSWORD),
			   TENNHOM = 'SV'
	END
	ELSE
		RAISERROR (N'Mã SV hoặc mật khẩu không chính xác!', 16,1)	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOLOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS
BEGIN
	IF EXISTS(SELECT name FROM sys.server_principals 
		WHERE TYPE IN('U','S','G')
		AND name NOT LIKE '%##%'
		AND name = @LGNAME)
		RETURN 1
	ELSE IF EXISTS(SELECT name FROM sys.database_principals
		WHERE type_desc = 'SQL_USER'
		AND name = @USERNAME)
		RETURN 2
	EXEC SP_ADDLOGIN @LGNAME, @PASS,'QLDSV_TC'
	EXEC SP_GRANTDBACCESS @LGNAME, @USERNAME

	EXEC sp_addrolemember @ROLE, @USERNAME
	IF @ROLE= 'PGV' OR @ROLE= 'PKT' OR @ROLE= 'KHOA'
	BEGIN 
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
	RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimLop]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimLop] @X nchar(10)
AS

IF exists (select MALOP from dbo.LOP where MALOP = @X)
BEGIN
SELECT TENLOP = (SELECT TENLOP From dbo.LOP Where MALOP = @X)
END
ELSE
IF exists (SELECT MALOP FROm  LINK0.QLDSV_TC.dbo.LOP where MALOP = @X)
BEGIN
	select TENLOP FROM LINK0.QLDSV_TC.DBO.LOP WHERE MALOP = @X
	
	END
	ELSE
		raiserror('Ma lop ban tim khong co',16,1)
GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_DIEM]    Script Date: 12/06/2023 9:25:23 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATE_DIEM]
	@DIEMTHI TYPE_DANGKY READONLY
AS
BEGIN
	MERGE INTO DANGKY AS TARGET
	USING (SELECT MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK FROM @DIEMTHI) AS SOURCE
	ON TARGET.MALTC = SOURCE.MALTC AND TARGET.MASV = SOURCE.MASV
	WHEN MATCHED THEN 
		UPDATE SET TARGET.DIEM_CC = SOURCE.DIEM_CC, TARGET.DIEM_GK = SOURCE.DIEM_GK,
		TARGET.DIEM_CK = SOURCE.DIEM_CK
	WHEN NOT MATCHED THEN
	INSERT (MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK)
	VALUES (SOURCE.MALTC, SOURCE.MASV, SOURCE.DIEM_CC, SOURCE.DIEM_GK, SOURCE.DIEM_CK);
END
GO
