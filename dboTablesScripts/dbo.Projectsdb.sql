CREATE TABLE [dbo].[Projectsdb] (
    [id_project]      INT          IDENTITY (1, 1) NOT NULL,
    [project_name]    VARCHAR (50) NOT NULL,
    [enterprise_name] VARCHAR (50) NOT NULL,
    [project_hours]   INT          NOT NULL,
    [project_status]  VARCHAR (50) NOT NULL,
    [contact_info]    VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Projectsdb] PRIMARY KEY CLUSTERED ([id_project] ASC)
);

