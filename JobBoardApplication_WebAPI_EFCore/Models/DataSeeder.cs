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
            // Mark's procedure for seed data API
            // 1. Open command prompt and change the directory path locates into "program.cs" use, --> cd local_directory_path (e.g. C:\Source\JobBoarApp_WebAPI_EFCore\JobBoardApplication_WebAPI_EFCore\JobBoardApplication_WebAPI_EFCore )
            // 2. Then type, "dotnet run seeddata"

            // Mock data
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
                            FirstName = "Ben",
                            LastName = "Tong",
                            EmailAddress = "bentong@gmail.com",
                            JobPosition = "Developer"
                        },
                        new Applicant()
                        {
                            ApplicantId = 3,
                            FirstName = "Kevin",
                            LastName = "Cosme",
                            EmailAddress = "kevincosme@gmail.com",
                            JobPosition = "Teacher"
                        },
                        new Applicant()
                        {
                            ApplicantId = 4,
                            FirstName = "Tom",
                            LastName = "Guts",
                            EmailAddress = "tomguts@gmail.com",
                            JobPosition = "Accountant"
                        },
                        new Applicant()
                        {
                            ApplicantId = 5,
                            FirstName = "King",
                            LastName = "Kong",
                            EmailAddress = "kingkong@gmail.com",
                            JobPosition = "Analyst"
                        },

                };

                applicantDbContext.Applicants.AddRange(applicants);
                applicantDbContext.SaveChanges();
            }

            // Seed Data for Job Positions
            if (!applicantDbContext.JobPositions.Any())
            {
                var positions = new List<JobPosition>()
                {
                        new JobPosition()
                        {
                            Id= 1,
                            ApplicantId = 1,
                            WorkPosition = "Engineer"
                        },
                        new JobPosition()
                        {
                            Id= 2,
                            ApplicantId = 2,
                            WorkPosition = "Developer"
                        },
                        new JobPosition()
                        {
                            Id = 3,
                            ApplicantId = 3,
                            WorkPosition = "Teacher"
                        },
                        new JobPosition()
                        {
                            Id= 4,
                            ApplicantId = 4,
                            WorkPosition = "Accountant"
                        }, 
                        new JobPosition()
                        {
                            Id= 5,
                            ApplicantId = 5,
                            WorkPosition = "Analyst"
                        }
                };

                applicantDbContext.JobPositions.AddRange(positions);
                applicantDbContext.SaveChanges();
            }
        }
    }
}
