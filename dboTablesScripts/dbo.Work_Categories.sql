CREATE TABLE [dbo].[Work_Categories] (
    [Id]                       INT          IDENTITY (1, 1) NOT NULL,
    [workcategory_name]        VARCHAR (50) NOT NULL,
    [workcategory_description] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

