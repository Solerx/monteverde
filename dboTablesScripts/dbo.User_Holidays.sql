CREATE TABLE [dbo].[User_Holidays] (
    [id_user]            INT          NOT NULL,
    [holidays_requested] SMALLINT     NOT NULL,
    [date_from]          DATETIME     NOT NULL,
    [date_to]            DATETIME     NOT NULL,
    [notes]              VARCHAR (50) NOT NULL,
    [status]             VARCHAR (50) NULL
);

