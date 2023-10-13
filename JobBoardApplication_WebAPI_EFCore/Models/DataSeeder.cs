namespace JobBoardApplication_WebAPI_EFCore.Models
{
    public class DataSeeder
    {
        private readonly JobBoardAppWebApiContext applicantDbContext;

        public DataSeeder(JobBoardAppWebApiContext applicantDbContext)
        {
            this.applicantDbContext = applicantDbContext;
        }

        public void Seed()
        {
            // Seed data for Applicants
            if (!applicantDbContext.Applicants.Any())
            {
                var applicants = new List<Applicant>()
                {
                        new Applicant()
                        {
                            ApplicantId = 1,
                            FirstName = "Juan",
                            LastName = "Cruz",
                            EmailAddress = "juancruz@gmail.com",
                            JobPosition = "Engineer"
                        },
                        new Applicant()
                        {
                            ApplicantId = 2,
                            FirstName = "Juan",
                            LastName = "Cruz",
                            EmailAddress = "juancruz@gmail.com",
                            JobPosition = "Engineer"
                        },
                        new Applicant()
                        {
                            ApplicantId = 3,
                            FirstName = "Kevin",
                            LastName = "Cosme",
                            EmailAddress = "kevincosme@gmail.com",
                            JobPosition = "Teacher"
                        }
                };

                applicantDbContext.Applicants.AddRange(applicants);
                applicantDbContext.SaveChanges();
            }

            // Seed Data for Job Positions
            //if (!applicantDbContext.JobPositions.Any())
            //{
            //    var positions = new List<JobPosition>()
            //    {
            //            new JobPosition()
            //            {
            //                ApplicantId = 1,
            //                WorkPosition = "Engineer"
            //            },
            //            new JobPosition()
            //            {
            //                ApplicantId = 2,
            //                WorkPosition = "Developer"
            //            },
            //            new JobPosition()
            //            {
            //                ApplicantId = 3,
            //                WorkPosition = "Teacher"
            //            }
            //    };

            //    applicantDbContext.JobPositions.AddRange(positions);
            //    applicantDbContext.SaveChanges();
            //}
        }
    }
}
