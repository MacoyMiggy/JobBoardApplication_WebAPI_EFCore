CREATE TABLE [dbo].[Applicant] (
    [ApplicantId]           INT        NOT NULL,
    [FirstName]    NCHAR (30) NULL,
    [LastName]     NCHAR (30) NULL,
    [EmailAddress] NCHAR (50) NULL,
    [JobPosition]  NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([ApplicantId] ASC)
);

