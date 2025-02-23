USE [master]
GO
/****** Object:  Database [IG_Crypto]    Script Date: 15/01/2025 14:54:28 ******/
CREATE DATABASE [IG_Crypto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IG_Crypto', FILENAME = N'C:\Users\bari_\IG_Crypto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'IG_Crypto_log', FILENAME = N'C:\Users\bari_\IG_Crypto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [IG_Crypto] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IG_Crypto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IG_Crypto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IG_Crypto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IG_Crypto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IG_Crypto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IG_Crypto] SET ARITHABORT OFF 
GO
ALTER DATABASE [IG_Crypto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IG_Crypto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IG_Crypto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IG_Crypto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IG_Crypto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IG_Crypto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IG_Crypto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IG_Crypto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IG_Crypto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IG_Crypto] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IG_Crypto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IG_Crypto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IG_Crypto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IG_Crypto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IG_Crypto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IG_Crypto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IG_Crypto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IG_Crypto] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [IG_Crypto] SET  MULTI_USER 
GO
ALTER DATABASE [IG_Crypto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IG_Crypto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IG_Crypto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IG_Crypto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [IG_Crypto] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [IG_Crypto] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [IG_Crypto] SET QUERY_STORE = OFF
GO
USE [IG_Crypto]
GO
/****** Object:  UserDefinedTableType [dbo].[Local_Type_CommissionTable]    Script Date: 15/01/2025 14:54:28 ******/
CREATE TYPE [dbo].[Local_Type_CommissionTable] AS TABLE(
	[Transaction_ID] [varchar](250) NULL,
	[Agent] [varchar](250) NULL,
	[Currency] [varchar](250) NULL,
	[TransactionDate] [varchar](250) NULL,
	[Gross_Disbursement_Amount] [varchar](250) NULL,
	[Nets_Disbursements_Amount] [varchar](250) NULL,
	[Gass_Fee] [varchar](250) NULL,
	[Tranches_Executed] [varchar](250) NULL,
	[Commission_Status] [varchar](250) NULL,
	[Income] [varchar](250) NULL,
	[DailyDisbursment] [varchar](250) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Local_Type_PendingCommissionTable]    Script Date: 15/01/2025 14:54:28 ******/
CREATE TYPE [dbo].[Local_Type_PendingCommissionTable] AS TABLE(
	[CommissionID] [varchar](250) NULL,
	[CommissionLineID] [varchar](250) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Local_Type_PendingTransactionTable]    Script Date: 15/01/2025 14:54:28 ******/
CREATE TYPE [dbo].[Local_Type_PendingTransactionTable] AS TABLE(
	[TransactionID] [varchar](250) NULL,
	[TransactionLineID] [varchar](250) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[Local_Type_TransactionTable]    Script Date: 15/01/2025 14:54:28 ******/
CREATE TYPE [dbo].[Local_Type_TransactionTable] AS TABLE(
	[Transaction_ID] [varchar](250) NULL,
	[ProviderID] [varchar](250) NULL,
	[CurrencyID] [varchar](250) NULL,
	[TransactionDate] [varchar](250) NULL,
	[Gross_Disbursement_Amount] [varchar](250) NULL,
	[Nets_Disbursements_Amount] [varchar](250) NULL,
	[Gass_Fee] [varchar](250) NULL,
	[Tranches_Executed] [varchar](250) NULL,
	[Transaction_Status] [varchar](250) NULL,
	[Income] [varchar](250) NULL,
	[DailyDisbursment] [varchar](250) NULL
)
GO
/****** Object:  Table [dbo].[Agents]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agents](
	[Agent_ID] [varchar](220) NULL,
	[Fist_Name] [varchar](220) NULL,
	[Last_Name] [varchar](220) NULL,
	[Full_Name] [varchar](220) NULL,
	[Phone] [varchar](220) NULL,
	[Secondary_Phone] [varchar](220) NULL,
	[Email] [varchar](220) NULL,
	[Active] [bit] NULL,
	[Date_GL] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Commissions]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commissions](
	[Commission_ID] [varchar](220) NULL,
	[Currency_ID] [varchar](220) NULL,
	[Agent_ID] [varchar](220) NULL,
	[Transaction_Date] [date] NULL,
	[Gross_Disbursements_Amount] [decimal](18, 3) NULL,
	[Gass_Fee] [decimal](18, 3) NULL,
	[Nets_Disbursements_Amount] [decimal](18, 3) NULL,
	[Status] [varchar](25) NULL,
	[Active] [bit] NULL,
	[Date_GL] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Commissions_Line]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commissions_Line](
	[CommissionLine_ID] [varchar](220) NULL,
	[Commission_ID] [varchar](220) NULL,
	[Transaction_ID] [varchar](220) NULL,
	[Transaction_Date] [date] NULL,
	[Agent_ID] [varchar](220) NULL,
	[Currency_ID] [varchar](220) NULL,
	[Gross_Disbursements_Amount] [decimal](18, 3) NULL,
	[Gass_Fee] [decimal](18, 3) NULL,
	[Nets_Disbursements_Amount] [decimal](18, 3) NULL,
	[Status] [varchar](25) NULL,
	[Active] [bit] NULL,
	[Date_GL] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Currency](
	[Currency_ID] [varchar](220) NULL,
	[Currency_Name] [varchar](220) NULL,
	[Active] [bit] NULL,
	[Date_GL] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Providers]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Providers](
	[Provider_ID] [varchar](220) NULL,
	[Fist_Name] [varchar](220) NULL,
	[Last_Name] [varchar](220) NULL,
	[Full_Name] [varchar](220) NULL,
	[Phone] [varchar](220) NULL,
	[Secondary_Phone] [varchar](220) NULL,
	[Email] [varchar](220) NULL,
	[Rate] [decimal](18, 3) NULL,
	[Active] [bit] NULL,
	[Date_GL] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction_Log]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction_Log](
	[Transaction_ID] [varchar](220) NULL,
	[User] [varchar](20) NULL,
	[Date] [datetime] NULL,
	[Actiom] [varchar](220) NULL,
	[Active] [bit] NULL,
	[Date_GL] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[Transaction_ID] [varchar](220) NULL,
	[Provider_ID] [varchar](220) NULL,
	[Currency_ID] [varchar](220) NULL,
	[Transaction_Date] [date] NULL,
	[Transaction_Type] [varchar](20) NULL,
	[Final_Swap_Tranche_Price] [decimal](18, 3) NULL,
	[Number_of_BTC] [decimal](18, 3) NULL,
	[Gass_Fee] [decimal](18, 3) NULL,
	[Tranches_Executed] [varchar](20) NULL,
	[Active] [bit] NULL,
	[Date_GL] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions_Line]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions_Line](
	[TransactionLine_ID] [varchar](220) NULL,
	[Transaction_ID] [varchar](220) NULL,
	[Provider_ID] [varchar](220) NULL,
	[Currency_ID] [varchar](220) NULL,
	[Transaction_Date] [date] NULL,
	[Gross_Disbursement_Amount] [decimal](18, 3) NULL,
	[Nets_Disbursements_Amount] [decimal](18, 3) NULL,
	[Gass_Fee] [decimal](18, 3) NULL,
	[Income] [decimal](18, 4) NULL,
	[Daily_Disbursment] [decimal](18, 3) NULL,
	[Tranches_Executed] [int] NULL,
	[Transaction_Status] [varchar](20) NULL,
	[Active] [bit] NULL,
	[Date_GL] [date] NULL,
	[Final_Transaction_ID] [varchar](220) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Usert_ID] [varchar](220) NULL,
	[Fist_Name] [varchar](220) NULL,
	[Last_Name] [varchar](220) NULL,
	[Full_Name] [varchar](220) NULL,
	[Phone] [varchar](220) NULL,
	[Secondary_Phone] [varchar](220) NULL,
	[Email] [varchar](220) NULL,
	[Roll] [varchar](220) NULL,
	[UserName] [varchar](220) NULL,
	[Password] [varbinary](max) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Active] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Agents] ADD  DEFAULT (CONVERT([varchar](250),newid())) FOR [Agent_ID]
GO
ALTER TABLE [dbo].[Agents] ADD  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Agents] ADD  DEFAULT (format(CONVERT([date],getdate()),'MM-01-yyyy')) FOR [Date_GL]
GO
ALTER TABLE [dbo].[Commissions] ADD  DEFAULT (CONVERT([varchar](250),newid())) FOR [Commission_ID]
GO
ALTER TABLE [dbo].[Commissions] ADD  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Commissions] ADD  DEFAULT (format(CONVERT([date],getdate()),'MM-01-yyyy')) FOR [Date_GL]
GO
ALTER TABLE [dbo].[Commissions_Line] ADD  DEFAULT (CONVERT([varchar](250),newid())) FOR [CommissionLine_ID]
GO
ALTER TABLE [dbo].[Commissions_Line] ADD  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Commissions_Line] ADD  DEFAULT (format(CONVERT([date],getdate()),'MM-01-yyyy')) FOR [Date_GL]
GO
ALTER TABLE [dbo].[Currency] ADD  DEFAULT (CONVERT([varchar](250),newid())) FOR [Currency_ID]
GO
ALTER TABLE [dbo].[Currency] ADD  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Currency] ADD  DEFAULT (format(CONVERT([date],getdate()),'MM-01-yyyy')) FOR [Date_GL]
GO
ALTER TABLE [dbo].[Providers] ADD  DEFAULT (CONVERT([varchar](250),newid())) FOR [Provider_ID]
GO
ALTER TABLE [dbo].[Providers] ADD  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Providers] ADD  DEFAULT (format(CONVERT([date],getdate()),'MM-01-yyyy')) FOR [Date_GL]
GO
ALTER TABLE [dbo].[Transaction_Log] ADD  DEFAULT (format(CONVERT([date],getdate()),'MM-dd-yyyy')) FOR [Date]
GO
ALTER TABLE [dbo].[Transaction_Log] ADD  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Transaction_Log] ADD  DEFAULT (getdate()) FOR [Date_GL]
GO
ALTER TABLE [dbo].[Transactions] ADD  DEFAULT (CONVERT([varchar](250),newid())) FOR [Transaction_ID]
GO
ALTER TABLE [dbo].[Transactions] ADD  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Transactions] ADD  DEFAULT (format(CONVERT([date],getdate()),'MM-01-yyyy')) FOR [Date_GL]
GO
ALTER TABLE [dbo].[Transactions_Line] ADD  DEFAULT (CONVERT([varchar](250),newid())) FOR [TransactionLine_ID]
GO
ALTER TABLE [dbo].[Transactions_Line] ADD  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Transactions_Line] ADD  DEFAULT (format(CONVERT([date],getdate()),'MM-01-yyyy')) FOR [Date_GL]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (CONVERT([varchar](250),newid())) FOR [Usert_ID]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((1)) FOR [Active]
GO
/****** Object:  StoredProcedure [dbo].[InsertNewCommissionLine]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 CREATE Procedure [dbo].[InsertNewCommissionLine] (
         @Transactions as Varchar (250)
        ,@Agent_ID     as Varchar (250)
		,@Currency_ID as Varchar (250) 
		,@Gross_Disbursements_Amou as Integer
		,@Nets_Disbursements_Amount as Integer )
As 
Begin

Insert Into [IG_Crypto].[dbo].[Commissions_Line] (
       [CommissionLine_ID] 
      ,[Transaction_ID]
      ,[Agent_ID]
	  ,[Currency_ID]
      ,[Gross_Disbursements_Amount] 
      ,[Nets_Disbursements_Amount]
)
Select Cast(newid() as varchar (250))
      ,@Transactions 
	  ,@Agent_ID
	  ,@Currency_ID
	  ,@Gross_Disbursements_Amou 
	  ,@Nets_Disbursements_Amount 

End 
GO
/****** Object:  StoredProcedure [dbo].[sp_Insert_NewUser]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 
 

CREATE Procedure [dbo].[sp_Insert_NewUser] (  @FirstName  nvarchar (250) 
										 ,@LastName  nvarchar (250) 
										 ,@Phone  nvarchar (250) 
										 ,@Email nvarchar (250)   
										 ,@UserID  nvarchar (250) 
										 ,@Password nvarchar (250)
										 )
As 

Begin

/****************************************************************
** Project: DABS   
** Object Name: sp_Insert_NewUser
** Desc: Insert new User
** Auth: BCA
** Date: 01/08/2025
******************************************************************
** Change History
******************************************************************
** PR   Date        Author  Description 
** --   --------   -------   ------------------------------------
**  
******************************************************************/

OPEN SYMMETRIC KEY Key_Password DECRYPTION BY CERTIFICATE Certificate_Pss


--Declare @FirstName  nvarchar (250) = 'Admin1'
--	,@LastName  nvarchar (250) = 'Admin1'
--	,@Phone  nvarchar (250) = '123456' 
--	,@Email nvarchar (250)   = 'Admin@Gemail.com'
--	,@UserID  nvarchar (25) = 'Admin1'
--	,@Password nvarchar (250) = '@Crypto20251'

 Declare @error varchar (250) = 'Error -998: The UserID ' + ltrim(rtrim( @UserID )) + ' Or User with same Name ' + ' Already exists '

 
If exists (Select Usert_ID 
           From [IG_Crypto].[dbo].[Users]
		   Where [UserName] = ltrim(rtrim(@UserID)) 
		        and [Active] = 1
		        Or ( [Fist_Name] = ltrim(rtrim(@FirstName)) and [Last_Name] = ltrim(rtrim(@LastName)) and [Phone] = ltrim(rtrim(@Phone)) and [Email] = ltrim(rtrim(@Email)))
			
			)

 Begin 
 raiserror(@error, 1, 10)  
 End



 Else
 Begin

 Insert Into [IG_Crypto].[dbo].[Users] ( 
	            [Usert_ID]
			  ,[Fist_Name]
			  ,[Last_Name]
			  ,[Full_Name]
			  ,[Phone] 
			  ,[Email]
			  ,[Roll]
			  ,[UserName]
			  ,[Password]
			  ,[StartDate]
			  ,[EndDate]
			  ,[Active]
							 )

	Select Cast(newid() as varchar (250))
	      ,Ltrim(Rtrim(@FirstName)) 
	      ,Ltrim(Rtrim(@LastName)) 
	      ,Ltrim(Rtrim(@LastName)) + ',' + Ltrim(Rtrim(@FirstName))   
		  ,@Phone
		  ,@Email
		  ,'Pending'
		  ,@UserID
		  ,EncryptByKey(Key_GUID ('Key_Password'), CONVERT(varchar,@Password) )
		  ,Cast(Getdate() as Date)
		  ,Null
		  ,1


End 
 
End


GO
/****** Object:  StoredProcedure [dbo].[sp_Restart_Password]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE Procedure [dbo].[sp_Restart_Password] (  @Email nvarchar (250)   
										      ,@UserID  nvarchar (250) 
										      ,@Password nvarchar (250)
										 )
As 

Begin

/****************************************************************
** Project: DABS   
** Object Name: sp_Restart_Password
** Desc: Insert Restart Password
** Auth: BCA
** Date: 01/08/2025
******************************************************************
** Change History
******************************************************************
** PR   Date        Author  Description 
** --   --------   -------   ------------------------------------
**  
******************************************************************/

OPEN SYMMETRIC KEY Key_Password DECRYPTION BY CERTIFICATE Certificate_Pss


----Declare  @Email nvarchar (250)   = 'cccccccc'
----	,@UserID  nvarchar (25) = 'bcortes'
----	,@Password nvarchar (250) = '@Crypto20251'

Declare @error varchar (250) = 'Error -998: The UserID ' + ltrim(rtrim( @UserID )) + 'Or User ' + 'Not exists '

 
If Not exists (Select Usert_ID 
           From [IG_Crypto].[dbo].[Users]
		   Where [UserName] = ltrim(rtrim(@UserID))  and [Email] = ltrim(rtrim(@Email))
		       and [Active] = 1
			)

 Begin 
 raiserror(@error, 1, 10)  
 End



 Else
 Begin


 Update a
 Set a.[EndDate] = Cast(Getdate() as Date)
    ,[Active] = 0
 From [IG_Crypto].[dbo].[Users]  as a
 Where [Active] = 1
       and [UserName] = ltrim(rtrim(@UserID)) 
	   and [Email] = ltrim(rtrim(@Email))

 

IF OBJECT_ID('tempdb..#User') IS NOT NULL
    DROP TABLE #User

Select [Usert_ID]
     ,ROW_NUMBER() OVER(PARTITION BY [Usert_ID] ORDER BY [EndDate]  DESC) as Rw
Into #User
From [IG_Crypto].[dbo].[Users]
 Where   [UserName] = ltrim(rtrim(@UserID)) 
	   and [Email] = ltrim(rtrim(@Email));
 

 Insert Into [IG_Crypto].[dbo].[Users] ( 
	            [Usert_ID]
			  ,[Fist_Name]
			  ,[Last_Name]
			  ,[Full_Name]
			  ,[Phone] 
			  ,[Email]
			  ,[Roll]
			  ,[UserName]
			  ,[Password]
			  ,[StartDate]
			  ,[EndDate]
			  ,[Active]
							 )

Select Cast(newid() as varchar (250))
	      ,Ltrim(Rtrim([Fist_Name])) 
	      ,Ltrim(Rtrim([Last_Name])) 
	      ,Ltrim(Rtrim([Full_Name]))  
		  ,[Phone] 
		  ,[Email]
		  ,[Roll] 
		  ,@UserID
		  ,EncryptByKey(Key_GUID ('Key_Password'), CONVERT(varchar,@Password) )
		  ,Cast(Getdate() as Date)
		  ,Null
		  ,1
From [IG_Crypto].[dbo].[Users]
Where [UserName] = ltrim(rtrim(@UserID))  
      and [Email] = ltrim(rtrim(@Email))
      and  [Usert_ID] = (Select Usert_ID From #User Where Rw = 1)

End 
 
End
GO
/****** Object:  StoredProcedure [dbo].[spCalculateCommissions]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[spCalculateCommissions] (
@FinalSwapTranchePrice as VARCHAR(250) 
,@NumberofBTC as  VARCHAR(250) 
,@TransactionDate as Date  
,@BLUE_TRIANGLES_LTD As  VARCHAR(250)  
,@JOHN_LUMLEY As  VARCHAR(250)  
,@RYAN_FENDLY As  VARCHAR(250)  
,@ANTHONY_CRISCI As  VARCHAR(250)   -- decimal(18, 3)
)
As 

Begin 

--Declare @FinalSwapTranchePrice as  decimal(18, 3) = 98000
--       ,@NumberofBTC as  decimal(18, 3) = 500
--	   ,@TransactionDate as Date = Cast(Getdate() as Date)
--	   ,@BLUE_TRIANGLES_LTD As  decimal(18, 3) = 11250000
--	   ,@JOHN_LUMLEY As  decimal(18, 3) = 5625000
--	   ,@RYAN_FENDLY As  decimal(18, 3) = 5625000
--	   ,@ANTHONY_CRISCI As  decimal(18, 3) = 2500000;


With cte_Commission
As (
Select distinct 
       a.Full_Name as Agent
      ,c.[Currency_Name]
	  ,@TransactionDate as 'TransactionDate'
	  ,c.Currency_ID
	  ,a.Agent_ID
      ,Case when a.Full_Name  = 'C2C' and c.[Currency_Name] = 'USDT'  Then Cast(((Cast(@FinalSwapTranchePrice as decimal(18, 3))  * 0.005) * Cast(@NumberofBTC as decimal(18, 3)) ) as decimal(18, 3))
	        when a.Full_Name  = 'C2C' and c.[Currency_Name] = 'BTC'  Then Cast((Cast(@NumberofBTC as decimal(18, 3))  * 0.00875) as decimal(18, 3))
			when a.Full_Name  = 'PAG' and c.[Currency_Name] = 'USDT'  Then Cast(((Cast(@FinalSwapTranchePrice as decimal(18, 3))  * 0.005) * Cast(@NumberofBTC as decimal(18, 3)) ) as decimal(18, 3))
	        when a.Full_Name  = 'PAG' and c.[Currency_Name] = 'BTC'  Then Cast((Cast(@NumberofBTC as decimal(18, 3))  * 0.00875) as decimal(18, 3))
			when a.Full_Name  = 'IGL' and c.[Currency_Name] = 'USDT'  Then Cast(((Cast(@FinalSwapTranchePrice as decimal(18, 3))  * 0.005) * Cast(@NumberofBTC as decimal(18, 3)) ) as decimal(18, 3))
	        when a.Full_Name  = 'IGL' and c.[Currency_Name] = 'BTC'  Then Cast((Cast(@NumberofBTC as decimal(18, 3))  * 0.0025) as decimal(18, 3))
			When a.Full_Name  = 'Charity'  Then Cast(((Cast(@FinalSwapTranchePrice as decimal(18, 3))  * 0.01) * Cast(@NumberofBTC as decimal(18, 3)) ) as decimal(18, 3))
			When a.Full_Name  = 'Blue Triangles LTD' Then Cast((@BLUE_TRIANGLES_LTD / 8) as decimal(18, 3))
			When a.Full_Name  = 'John Lumley' Then Cast((@JOHN_LUMLEY / 8) as decimal(18, 3))
			When a.Full_Name  = 'Ryan Fendly' Then Cast((@RYAN_FENDLY / 8) as decimal(18, 3))
			When a.Full_Name  = 'Anthony Crisci' Then Cast((@ANTHONY_CRISCI / 8) as decimal(18, 3))
	    End as 'Gross_Disbursement_Amount' 
		,Len(a.Full_Name ) as Orderby
 
From [dbo].[Agents]  as a  
 
     Cross Join (Select [Currency_Name],Currency_ID
	             From [IG_Crypto].[dbo].[Currency]
				 Where [Currency_Name] In ('USDT','BTC')) as c
Where  a.Full_Name  In ( 'C2C' ,'PAG','IGL','Charity','Blue Triangles LTD','John Lumley','Ryan Fendly','Anthony Crisci')
       and 1 = Case When  a.Full_Name  In ( 'C2C' ,'PAG','IGL') and c.[Currency_Name] In ('USDT','BTC') Then 1
	                When  a.Full_Name = 'Charity' and  c.[Currency_Name] = 'USDT' Then 1
					When  a.Full_Name In ('Blue Triangles LTD','John Lumley','Ryan Fendly','Anthony Crisci')  and  c.[Currency_Name] = 'USDT' Then 1
	                Else 0
                 End

 )

Select Distinct 
       c.Agent
      ,c.[Currency_Name]
	  ,c.TransactionDate
	  ,c.Currency_ID
	  ,c.Agent_ID
	  ,c.Gross_Disbursement_Amount
      ,Isnull(Sum(cl.[Gross_Disbursements_Amount]) ,0.000) 'Total_Gross_Disbursement_Amount'
	  ,c.Orderby
From cte_Commission as c
     Left Join [dbo].[Commissions_Line]  as cl On cl.Agent_ID = c.Agent_ID
	                                               and cl.Currency_ID = c.Currency_ID
												  -- and DATEPART(week,cl.Transaction_Date)  = DATEPART(week, Getdate()) 
												   and cl.Transaction_Date Between  Cast(DATEADD(week, DATEDIFF(week, 0, Getdate() - 1), 0) as Date)
												                                     and  Cast(DATEADD(DAY, 8 - DATEPART(WEEKDAY, Getdate()),  Getdate()) as date)
												   and cl.[Status] = 'Pending'
Group by c.Agent 
      ,c.[Currency_Name]
	  ,c.TransactionDate
	  ,c.Currency_ID
	  ,c.Agent_ID
	  ,c.Gross_Disbursement_Amount
	  ,c.Orderby
Order by c.Orderby
        ,c.Agent

 
 End 
GO
/****** Object:  StoredProcedure [dbo].[spClosePendingCommissions]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------drop type Local_Type_PendingCommissionTable

------CREATE TYPE Local_Type_PendingCommissionTable  AS TABLE
------( 
------CommissionID VARCHAR(250)
------,CommissionLineID VARCHAR(250)
------)

 
CREATE Procedure [dbo].[spClosePendingCommissions]
(
 @Commissions as Local_Type_PendingCommissionTable READONLY ,
 @CommissionID as Varchar(250)
,@AgentID as Varchar(250)
,@CurrencyID as Varchar(250)
,@TransactionDate as Varchar(250)
,@Gross_Disbursement_Amout as Varchar(250)
,@GasFee as Varchar(250)
,@Net_Disbursement_Amount as Varchar(250)
,@User as  Varchar (25)
)
As 

Begin

--Declare @CommissionID as Varchar(250)
--       ,@AgentID as Varchar(250)
--	   ,@CurrencyID as Varchar(250)
--	   ,@TransactionDate as Varchar(250)
--	   ,@Gross_Disbursement_Amout as Varchar(250)
--	   ,@GasFee as Varchar(250)
--	   ,@Net_Disbursement_Amount as Varchar(250)
	   
	 --  Declare @Commissions  Table (CommissionID VARCHAR(250),CommissionLineID VARCHAR(250))


DECLARE @errorNumber int;
DECLARE @error1 int;
DECLARE @error2 int;

BEGIN TRANSACTION 

Insert Into [IG_Crypto].[dbo].[Commissions] 
(
 [Commission_ID]
,[Currency_ID]
,[Agent_ID]
,[Transaction_Date]
,[Gross_Disbursements_Amount]
,[Gass_Fee]
,[Nets_Disbursements_Amount]
,[Status]
)

Select @CommissionID
      ,@CurrencyID 
      ,@AgentID
	  ,@TransactionDate
	  ,@Gross_Disbursement_Amout
	  ,@GasFee
	  ,@Net_Disbursement_Amount
	  ,'Closed'
 

SET @error1 = @@ERROR;
SET @errorNumber = @error1;



Update cl
Set cl.[Status] = 'Close'
    ,cl.Commission_ID = @CommissionID
From [IG_Crypto].[dbo].[Commissions_Line] as cl
     Inner Join @Commissions as pcl On pcl.CommissionLineID = cl.CommissionLine_ID
Where cl.[Status] = 'Pending'
     and cl.Active = 1 


Insert Into [dbo].[Transaction_Log] (
 [Transaction_ID]
,[User]
,[Date]
,[Actiom]
)

Select @CommissionID
      ,@User
      ,Getdate()
	  ,Concat('Commission transaction ',@CommissionID ,' was created to close pending commissions')


SET @error2 = @@ERROR;
SET @errorNumber += @error2;

IF @errorNumber = 0
    COMMIT TRANSACTION;
ELSE
BEGIN
ROLLBACK TRANSACTION;
IF @error1 > 0
    PRINT CONCAT('Transaction used to insert commission rolled back with error number: ',@error1);
IF @error2 > 0
    PRINT CONCAT('Transaction used to close pending commission  rolled back with error number: ',@error2);
END

  

End 
GO
/****** Object:  StoredProcedure [dbo].[spClosePendingTransactions]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 ------drop type Local_Type_PendingTransactionTable

----CREATE TYPE Local_Type_PendingTransactionTable  AS TABLE
----( 
----TransactionID VARCHAR(250)
----,TransactionLineID VARCHAR(250)
----)



 CREATE Procedure [dbo].[spClosePendingTransactions]
 (
 @Transactions as Local_Type_PendingTransactionTable READONLY
,@TransactionID as Varchar(250)
,@ProviderID as Varchar(250)
,@CurrencyID as Varchar(250)
,@TransactionDate as Varchar(250)
,@Gross_Disbursement_Amout as Varchar(250)
,@GasFee as Varchar(250)
,@Net_Disbursement_Amount as Varchar(250)
,@User as Varchar(250)
 )
 As 


 Begin


--Declare @Transactions as table 
--(
--TransactionID VARCHAR(250)
--,TransactionLineID VARCHAR(250)
--)
-- Declare @TransactionID as Varchar(250)
--		,@ProviderID as Varchar(250)
--		,@CurrencyID as Varchar(250)
--		,@TransactionDate as Varchar(250)
--		,@Gross_Disbursement_Amout as Varchar(250)
--		,@GasFee as Varchar(250)
--		,@Net_Disbursement_Amount as Varchar(250)



DECLARE @errorNumber int;
DECLARE @error1 int;
DECLARE @error2 int;

BEGIN TRANSACTION 


Insert Into [IG_Crypto].[dbo].[Transactions_Line] 
( 
[TransactionLine_ID] 
,[Provider_ID]
,[Currency_ID]
,[Transaction_Date]
,[Gross_Disbursement_Amount]
,[Nets_Disbursements_Amount]
,[Gass_Fee] 
,[Tranches_Executed]
,[Transaction_Status]
)

Select Distinct 
       @TransactionID  
      ,@ProviderID
	  ,@CurrencyID
	  ,@TransactionDate 
	  ,@Gross_Disbursement_Amout
	  ,@Net_Disbursement_Amount
	  ,@GasFee
	  ,0
	  ,'Close' 
From @Transactions as t


SET @error1 = @@ERROR;
SET @errorNumber = @error1;

 
 Update tl
Set tl.[Transaction_Status] = 'Close'
    ,tl.[Final_Transaction_ID] = @TransactionID
From  [IG_Crypto].[dbo].[Transactions_Line]  as tl
     Inner Join @Transactions as ptl On ptl.TransactionLineID = tl.TransactionLine_ID
Where tl.[Transaction_Status]  = 'Pending'
      and tl.Active = 1 


Insert Into [IG_Crypto].[dbo].[Transaction_Log]
(
 [Transaction_ID]
,[User]
,[Date]
,[Actiom]
)
Select Distinct
       @TransactionID
	  ,@User
      ,Cast(Getdate() as Date)
	  ,Concat('Transaction ',@TransactionID ,' was created')


SET @error2 = @@ERROR;
SET @errorNumber += @error2;

IF @errorNumber = 0
    COMMIT TRANSACTION;

ELSE
BEGIN
ROLLBACK TRANSACTION;
IF @error1 > 0
    PRINT CONCAT('Transaction used to insert Transaction rolled back with error number: ',@error1);
IF @error2 > 0
    PRINT CONCAT('Transaction used to close pending Transaction  rolled back with error number: ',@error2);
END

  

End 
GO
/****** Object:  StoredProcedure [dbo].[spFilterTransaction]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 
 CREATE Procedure [dbo].[spFilterTransaction] ( 
         @Provider_ID as Varchar (250)
		,@Currency_ID as Varchar (250)
		,@Transaction_Date as Varchar (25)
)
As
Begin
SELECT Distinct  
       t.[Transaction_ID] as 'Main_Transaction_ID'
	  ,[Transaction_Date]
      ,t.Transaction_Type
      ,p.Full_Name
      ,c.Currency_Name as Currency
      ,t.[Final_Swap_Tranche_Price]
	  ,isnull(t.Gass_Fee ,0) as 'Gass_Fee'
      ,t.[Number_of_BTC] 
	  ,[Tranches_Executed]
From [IG_Crypto].[dbo].[Transactions] as t
      Inner Join [IG_Crypto].[dbo].[Currency] as c On c.Currency_ID = t.Currency_ID
	  Inner Join [IG_Crypto].[dbo].[Providers] as p On p.Provider_ID = t.Provider_ID
Where t.Active = 1 
      and t.Provider_ID =  @Provider_ID 
      and t.Currency_ID =  IIF(Len(@Currency_ID) > 0 , @Currency_ID,  t.Currency_ID)
	  and t.Transaction_Date =  IIF(Len(@Transaction_Date) > 0 , @Transaction_Date,t.Transaction_Date)

End
GO
/****** Object:  StoredProcedure [dbo].[spFilterUserRoll]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE Procedure [dbo].[spFilterUserRoll] (
 @UserID as Varchar(250) 
,@Password as Varchar(250)  
) As 
Begin

----Declare @UserID as Varchar(250) = 'Admin'
----       ,@Password as Varchar(250) = '@Crypto2025'

OPEN SYMMETRIC KEY Key_Password DECRYPTION BY CERTIFICATE Certificate_Pss

IF EXISTS(SELECT TOP(1) 1 
          FROM [IG_Crypto].[dbo].[Users] 
		  WHERE [UserName] =  @UserID
                and CONVERT(varchar, DecryptByKey([Password]))  = @Password
	            and [Active] = 1	 
          )
BEGIN
Select distinct  
      [Roll]  
FROM [IG_Crypto].[dbo].[Users] 
WHERE [UserName] =  @UserID
      and CONVERT(varchar, DecryptByKey([Password]))  = @Password
	  and [Active] = 1
	  and [Roll]  <> 'Pending'
END ELSE BEGIN
    SELECT 'NOUSER'
END

 
 
End 
GO
/****** Object:  StoredProcedure [dbo].[spInsertNewCommissionLine]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 -- drop TYPE Local_Type_CommissionTable
--Create TYPE Local_Type_CommissionTable  AS TABLE
--      (  Transaction_ID VARCHAR(250)
--        ,Agent  VARCHAR(250)
--        ,Currency VARCHAR(250)
--        ,TransactionDate   VARCHAR(250)
--        ,Gross_Disbursement_Amount  VARCHAR(250)
--        ,Nets_Disbursements_Amount  VARCHAR(250)
--        ,Gass_Fee   VARCHAR(250) 
--		,Tranches_Executed  VARCHAR(250) 
--        ,Commission_Status   VARCHAR(250)  
--		,Income  VARCHAR(250)
--		,DailyDisbursment  VARCHAR(250)
--	  );


--Drop Procedure [dbo].[spInsertNewCommissionLine]
 Create Procedure [dbo].[spInsertNewCommissionLine] (
         @Commissions as Local_Type_CommissionTable READONLY
		)
As 
Begin


Insert Into [IG_Crypto].[dbo].[Commissions_Line]
(    [CommissionLine_ID] 
	,[Transaction_ID]
	,[Transaction_Date]
	,[Agent_ID]
	,[Currency_ID]
	,[Gross_Disbursements_Amount]
	,[Gass_Fee]      
	,[Nets_Disbursements_Amount]
	,[Status] )

Select Cast(newid() as varchar (250))
      ,cm.Transaction_ID
	  ,cm.TransactionDate
	  ,a.Agent_ID 
	  ,c.Currency_ID
	  ,Cast(cm.Gross_Disbursement_Amount as decimal(18, 3))
	  ,Cast(cm.Gass_Fee as decimal(18, 3))
	  ,Cast(cm.Nets_Disbursements_Amount as decimal(18, 3))
	  ,cm.Commission_Status
From @Commissions as cm
     Inner Join [dbo].[Agents] as a On a.Full_Name = cm.Agent
	                                   and a.Active = 1
	 Inner Join [dbo].[Currency] as c On c.Currency_Name = cm.Currency
	                                   and   c.Active = 1

End 
GO
/****** Object:  StoredProcedure [dbo].[spInsertNewCurrency]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[spInsertNewCurrency] 
(@Currency as  VARCHAR(250))

As 
Begin
 
IF NOT EXISTS 
    (   SELECT 1
        FROM [IG_Crypto].[dbo].[Currency]  
        WHERE [Currency_Name] = @Currency    
    )
BEGIN

Insert Into [IG_Crypto].[dbo].[Currency] ([Currency_Name])
Values (@Currency)

End  

End
GO
/****** Object:  StoredProcedure [dbo].[spInsertNewTransaction]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 
 CREATE Procedure [dbo].[spInsertNewTransaction] (
         @Transaction_ID as Varchar (250)
        ,@Provider_ID as Varchar (250)
		,@Currency_ID as Varchar (250)
		,@Transaction_Date as Varchar (25)
		,@TransactioType as Varchar (25)
		,@Final_Swap_Tranche_Price as Integer
		,@Number_of_BTC as Integer
		,@Tranches_Executed as Integer  
		,@User as  Varchar (25)
		)
As 
Begin

  Insert Into [IG_Crypto].[dbo].[Transactions] 
  ([Transaction_ID]
  ,[Provider_ID]
  ,[Currency_ID]
  ,[Transaction_Date]
  ,[Transaction_Type] 
  ,[Final_Swap_Tranche_Price]
  ,[Number_of_BTC] 
  ,[Tranches_Executed]
  )

  Select @Transaction_ID
        ,@Provider_ID  
		,@Currency_ID  
		,@Transaction_Date 
		,@TransactioType
		,@Final_Swap_Tranche_Price  
		,@Number_of_BTC  
		,@Tranches_Executed ;

Insert Into [dbo].[Transaction_Log] (
 [Transaction_ID]
,[User]
,[Date]
,[Actiom]
)

Select @Transaction_ID
      ,@User
      ,Getdate()
	  ,Concat('New ' ,@TransactioType ,' ', 'Transaction created with ID ',@Transaction_ID )
 
End 
GO
/****** Object:  StoredProcedure [dbo].[spInsertNewTransactionLine]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 -- drop TYPE Local_Type_TransactionTable
--Create TYPE Local_Type_TransactionTable  AS TABLE
--      (  Transaction_ID VARCHAR(250)
--        ,ProviderID VARCHAR(250)
--        ,CurrencyID VARCHAR(250)
--        ,TransactionDate   VARCHAR(250)
--        ,Gross_Disbursement_Amount  VARCHAR(250)
--        ,Nets_Disbursements_Amount  VARCHAR(250)
--        ,Gass_Fee   VARCHAR(250)
--        ,Tranches_Executed   VARCHAR(250) 
--        ,Transaction_Status   VARCHAR(250)
--        ,Income   VARCHAR(250)
--        ,DailyDisbursment  VARCHAR(250)
--	  );


 --Drop Procedure [dbo].[spInsertNewTransactionLine]

 Create Procedure [dbo].[spInsertNewTransactionLine] (
         @Transactions as Local_Type_TransactionTable READONLY
		)
As 
Begin

  Insert Into [IG_Crypto].[dbo].[Transactions_Line]
  ([TransactionLine_ID]
  ,[Transaction_ID]
  ,[Provider_ID]
  ,[Currency_ID]
  ,[Transaction_Date]   
  ,[Gross_Disbursement_Amount]
  ,[Nets_Disbursements_Amount] 
  ,[Gass_Fee]
  ,[Income]
  ,[Daily_Disbursment] 
  ,[Tranches_Executed]
  ,[Transaction_Status] 
  )

  Select Cast(newid() as varchar (250))
        ,t.Transaction_ID
		,p.Provider_ID
		,c.Currency_ID
		,t.TransactionDate  
		,Cast(t.Gross_Disbursement_Amount as decimal(18, 3))
		,Cast(t.Nets_Disbursements_Amount as decimal(18, 3))
		,Cast(t.Gass_Fee as decimal(18, 2))
		,Cast(t.Income as decimal(18, 4) ) 
		,Cast(t.DailyDisbursment as decimal(18, 3))
		,Cast(t.Tranches_Executed as Int)
		,Transaction_Status  
  From @Transactions as t
       Inner Join [dbo].[Providers] as p On p.Full_Name = t.ProviderID
	   Inner Join [dbo].[Currency] as c On c.Currency_Name = t.CurrencyID

End 
 

 
GO
/****** Object:  StoredProcedure [dbo].[spTransactionDefaultValues]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 CREATE Procedure [dbo].[spTransactionDefaultValues] (
 @Provider_ID as Varchar(250) 
,@Currency_ID as Varchar(100)
) 
As 
Begin


----Declare @Provider as Varchar(250) = 'DAVIDE'
----       ,@Currency as Varchar(100) = 'BTC' ;

 
Select Case When @Provider_ID = 'DAVIDE' and @Currency_ID = 'BTC' Then 40
            Else 0
        End as 'Total_Currency'

      ,Case When @Provider_ID = 'DAVIDE' and @Currency_ID = 'BTC' Then 98000
            Else 0
        End as    'FinalSwapTranchePrice'

      ,Case When @Provider_ID = 'DAVIDE' and @Currency_ID = 'BTC' Then 0.08
            Else 0
        End as 'Rate'
 

End
GO
/****** Object:  StoredProcedure [dbo].[spTransactionLineDefaultValues]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 CREATE Procedure [dbo].[spTransactionLineDefaultValues] (
 @Provider_ID as Varchar(250) 
,@Currency_ID as Varchar(100)
,@Price as varchar (50)  
,@TotalCurrency as varchar (50) 
,@GasFee as varchar (50) 
) 
As 
Begin


--Declare @Provider_ID as Varchar(250) = 'C2C'
--       ,@Currency_ID as Varchar(100) = 'USDT' 
--	   ,@Price as varchar (50) = 98000
--	   ,@TotalCurrency as varchar(50) = 40


Declare @Rate as decimal (18,2) = 0.08 

 
Select Case When @Provider_ID = 'DAVIDE' and @Currency_ID = 'USDT'               Then  Cast((@TotalCurrency * (1 - @Rate)) * @Price  as Decimal (18,2))
            When @Provider_ID = 'DAVIDE MANDATES' and @Currency_ID = 'BTC'       Then  Cast(((@TotalCurrency * @Rate) * 0.5)    as Decimal (18,2))
			When @Provider_ID In ('C2C' ,'PAG','IGL') and @Currency_ID = 'USDT'  Then  Cast(((((@TotalCurrency * @Rate) * 0.5) - (((@TotalCurrency * @Rate) * 0.5) * 0.015)) * @Price) / 3 as Decimal (18,5))
			Else 0
        End as 'GrossDisbursement'

	,Case When @Provider_ID = 'DAVIDE' and @Currency_ID = 'USDT'                 Then  Cast(((@TotalCurrency * (1 - @Rate)) * @Price) - @GasFee as Decimal (18,2)) 
            When @Provider_ID = 'DAVIDE MANDATES' and @Currency_ID = 'BTC'       Then  Cast((((@TotalCurrency * @Rate) * 0.5))  - @GasFee  as Decimal (18,2))
			When @Provider_ID In ('C2C' ,'PAG','IGL') and @Currency_ID = 'USDT'  Then  Cast((((((@TotalCurrency * @Rate) * 0.5) - (((@TotalCurrency * @Rate) * 0.5) * 0.015)) * @Price) /3) - @GasFee   as Decimal (18,5))
			Else 0
        End as  'NetDisbursement'
    ,Cast((((@TotalCurrency * @Rate) * 0.5) * 0.015) as Decimal (18,3))  *  @Price   as 'FiatRate'


End
GO
/****** Object:  StoredProcedure [dbo].[TransactionLog]    Script Date: 15/01/2025 14:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 



Create Procedure [dbo].[TransactionLog] (
         @Transactions as Varchar (250)
        ,@User    as Varchar (25)
		,@Action as Varchar (250)    )
As 
Begin

Insert Into [IG_Crypto].dbo.TransactionLog  (
       [Transaction_ID]
      ,[User] 
      ,[Actiom]
)
Select @Transactions  
      ,@User    
      ,@Action  

End
GO
USE [master]
GO
ALTER DATABASE [IG_Crypto] SET  READ_WRITE 
GO
