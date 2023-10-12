CREATE TABLE [dbo].[Applicant] (
    [ApplicantId]  INT        NULL,
    [FirstName]    NCHAR (20) NULL,
    [LastName]     NCHAR (20) NULL,
    [EmailAddress] NCHAR (30) NULL,
    [JobPosition]  NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([ApplicantId] ASC)
);

