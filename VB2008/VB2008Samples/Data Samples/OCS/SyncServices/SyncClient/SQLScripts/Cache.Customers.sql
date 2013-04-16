﻿/****
This SQL script was generated by the Configure Data Synchronization
dialog box. This script contains statements that create the
change-tracking columns, deleted-items table, and triggers on the
server database. These database objects are required by Synchronization
Services to successfully synchronize data between client and server
databases. For more information, see the
‘How to: Configure a Database Server for Synchronization’ topic in Help.
****/


IF @@TRANCOUNT > 0
set ANSI_NULLS ON 
set QUOTED_IDENTIFIER ON 

GO
BEGIN TRANSACTION;


IF @@TRANCOUNT > 0
ALTER TABLE [Customers] 
ADD [LastEditDate] DateTime NULL CONSTRAINT [DF_Customers_LastEditDate] DEFAULT (GETUTCDATE()) WITH VALUES
GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;


IF @@TRANCOUNT > 0
ALTER TABLE [Customers] 
ADD [CreationDate] DateTime NULL CONSTRAINT [DF_Customers_CreationDate] DEFAULT (GETUTCDATE()) WITH VALUES
GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;


IF @@TRANCOUNT > 0
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[Customers_Tombstone]')) 
BEGIN 
CREATE TABLE [Customers_Tombstone]( 
    [CustomerID] NChar(5) NOT NULL,
    [DeletionDate] DateTime NULL
) ON [PRIMARY] 
END 

GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;


IF @@TRANCOUNT > 0
ALTER TABLE [Customers_Tombstone] ADD CONSTRAINT [PKDEL_Customers_Tombstone_CustomerID]
   PRIMARY KEY CLUSTERED
    ([CustomerID])
    ON [PRIMARY]
GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;


IF @@TRANCOUNT > 0
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'Customers_DeletionTrigger') AND type = 'TR') 
   DROP TRIGGER [Customers_DeletionTrigger] 

GO
CREATE TRIGGER [Customers_DeletionTrigger] 
    ON [Customers] 
    AFTER DELETE 
AS 
SET NOCOUNT ON 
UPDATE [Customers_Tombstone] 
    SET [DeletionDate] = GETUTCDATE() 
    FROM deleted 
    WHERE deleted.[CustomerID] = [Customers_Tombstone].[CustomerID] 
IF @@ROWCOUNT = 0 
BEGIN 
    INSERT INTO [Customers_Tombstone] 
    ([CustomerID], DeletionDate)
    SELECT [CustomerID], GETUTCDATE()
    FROM deleted 
END 

GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;


IF @@TRANCOUNT > 0
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'Customers_UpdateTrigger') AND type = 'TR') 
   DROP TRIGGER [Customers_UpdateTrigger] 

GO
CREATE TRIGGER [Customers_UpdateTrigger] 
    ON [Customers] 
    AFTER UPDATE 
AS 
BEGIN 
    SET NOCOUNT ON 
    UPDATE [Customers] 
    SET [LastEditDate] = GETUTCDATE() 
    FROM inserted 
    WHERE inserted.[CustomerID] = [Customers].[CustomerID] 
END;
GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;


IF @@TRANCOUNT > 0
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'Customers_InsertTrigger') AND type = 'TR') 
   DROP TRIGGER [Customers_InsertTrigger] 

GO
CREATE TRIGGER [Customers_InsertTrigger] 
    ON [Customers] 
    AFTER INSERT 
AS 
BEGIN 
    SET NOCOUNT ON 
    UPDATE [Customers] 
    SET [CreationDate] = GETUTCDATE() 
    FROM inserted 
    WHERE inserted.[CustomerID] = [Customers].[CustomerID] 
END;
GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;
COMMIT TRANSACTION;