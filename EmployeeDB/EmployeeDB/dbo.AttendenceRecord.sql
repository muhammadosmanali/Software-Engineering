CREATE TABLE [dbo].[AttendenceRecord] (
    [Id]             INT      IDENTITY (1, 1) NOT NULL,
    [AttendenceId]   INT      NOT NULL,
    [LogInTIme]      DATETIME NOT NULL,
    [LogOutTime]     DATETIME NOT NULL,
    [AttendenceDate] DATETIME NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

