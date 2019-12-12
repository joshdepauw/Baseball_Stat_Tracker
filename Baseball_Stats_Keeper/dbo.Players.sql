CREATE TABLE [dbo].[Players] (
    [PlayerID]  INT IDENTITY(1,1)  NOT NULL,
    [FirstName] NCHAR (15) NOT NULL,
    [LastName]  NCHAR (25) NOT NULL,
    [Grade]     INT        NOT NULL,
    [Team]      NCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([PlayerID] ASC)
);

