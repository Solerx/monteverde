CREATE TABLE [dbo].[Role] (
    [id_role]          INT          IDENTITY (1, 1) NOT NULL,
    [role_name]        VARCHAR (50) NOT NULL,
    [role_description] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_role] ASC)
);

