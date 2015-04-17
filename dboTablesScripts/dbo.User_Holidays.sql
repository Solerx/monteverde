CREATE TABLE [dbo].[User_Holidays] (
    [id_user]            INT          NOT NULL,
    [holidays_requested] SMALLINT     NOT NULL,
    [date_requested]     DATETIME     NOT NULL,
    [status]             VARCHAR (50) NOT NULL,
    [notes]              VARCHAR (50) NOT NULL
);

