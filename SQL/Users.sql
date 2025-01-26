USE [IG_Crypto]
GO

/****** Object:  Table [dbo].[Agents]    Script Date: 06/01/2025 17:16:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

 

Create TABLE [dbo].[Users](
	[Usert_ID] [varchar](220) NULL,
	[Fist_Name] [varchar](220) NULL,
	[Last_Name] [varchar](220) NULL,
	[Full_Name] [varchar](220) NULL,
	[Phone] [varchar](220) NULL,
	[Secondary_Phone] [varchar](220) NULL,
	[Email] [varchar](220) NULL,
	[Roll] [varchar](220) NULL,
	[UserName] [varchar](220) NULL,
	[Password] varbinary (Max),
	 StartDate DateTime default Getdate(),
     EndDate DateTime,
	[Active] [bit] NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Users] ADD  DEFAULT (CONVERT([varchar](250),newid())) FOR [Usert_ID]
GO

ALTER TABLE [dbo].[Users] ADD  DEFAULT ((1)) FOR [Active]
GO

 


  OPEN SYMMETRIC KEY Key_Password DECRYPTION BY CERTIFICATE Certificate_Pss


  Update u
  Set u.[Password] =  EncryptByKey(Key_GUID ('Key_Password'), CONVERT(varchar,'@Crypto2025')  )
  From [IG_Crypto].[dbo].[Users] as u
  where u.[Usert_ID] = 'D0BE20A7-E0B2-4A36-8698-6263B9D9756F'