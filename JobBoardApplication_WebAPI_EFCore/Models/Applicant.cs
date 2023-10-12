// Model for Applicant

using System;
using System.Collections.Generic;

namespace JobBoardApplication_WebAPI_EFCore.Models;

public partial class Applicant
{
    public int ApplicantId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? EmailAddress { get; set; }

    public string? JobPosition { get; set; }
}
