﻿CREATE TABLE [dbo].[Usersdb] (
    [id_user]         INT          IDENTITY (1, 1) NOT NULL,
    [name]            VARCHAR (50) NOT NULL,
    [email]           VARCHAR (50) NOT NULL,
    [Password]        VARCHAR (50) NOT NULL,
    [worked_hours]    INT          NOT NULL,
    [holidays]        INT          NOT NULL,
    [registered_date] DATETIME     NOT NULL,
    [user_role]       INT          NOT NULL,
    [is_active]       BIT          NOT NULL,
    CONSTRAINT [PK_Usersdb] PRIMARY KEY CLUSTERED ([id_user] ASC)
);

