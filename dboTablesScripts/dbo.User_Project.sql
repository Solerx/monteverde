CREATE TABLE [dbo].[User_Project] (
    [id_user]    INT NOT NULL,
    [id_project] INT NOT NULL,
    [work_time]  INT NOT NULL,
    CONSTRAINT [FK_usersdb] FOREIGN KEY ([id_user]) REFERENCES [dbo].[Usersdb] ([id_user]),
    CONSTRAINT [FK_projectsdb] FOREIGN KEY ([id_project]) REFERENCES [dbo].[Projectsdb] ([id_project])
);

