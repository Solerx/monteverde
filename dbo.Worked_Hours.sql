CREATE TABLE [dbo].[Worked_Hours] (
    [id_user]    INT          NOT NULL,
    [id_project] INT          NOT NULL,
    [hours]      INT          NOT NULL,
    [user_notes] VARCHAR (50) NOT NULL,
    [date]       ROWVERSION   NOT NULL
);

