CREATE TABLE [dbo].[Time_Registration] (
    [id_user]       INT          NOT NULL,
    [id_project]    INT          NOT NULL,
    [hours]         INT          NOT NULL,
    [user_notes]    VARCHAR (50) NOT NULL,
    [date]          DATETIME     NOT NULL,
    [work_category] VARCHAR (50) NOT NULL,
    CONSTRAINT [FK_projectsdb_worktime] FOREIGN KEY ([id_project]) REFERENCES [dbo].[Projectsdb] ([id_project]),
    CONSTRAINT [FK_usersdb_worktime] FOREIGN KEY ([id_user]) REFERENCES [dbo].[Usersdb] ([id_user])
);

