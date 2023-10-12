// Model for Job Positions

using System;
using System.Collections.Generic;

namespace JobBoardApplication_WebAPI_EFCore.Models;

public partial class JobPosition
{
    public int Id { get; set; }

    public int? ApplicantId { get; set; }

    public string? WorkPosition { get; set; }
}
