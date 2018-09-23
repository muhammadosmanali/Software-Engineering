CREATE TABLE [dbo].[EmployeeData] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [EmployeeId]      NVARCHAR (50) NOT NULL,
    [Name]            NVARCHAR (50) NOT NULL,
    [Cnic]            NVARCHAR (50) NOT NULL,
    [AppointmentDate] DATETIME      NOT NULL,
    [Salary]          NVARCHAR (50) NOT NULL,
    [Email]           NVARCHAR (50) NOT NULL,
    [MailingAddress]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_EmployeeData] PRIMARY KEY CLUSTERED ([Id] ASC)
);

