using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobBoardApplication_WebAPI_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    ApplicantId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    EmailAddress = table.Column<string>(type: "nchar(30)", fixedLength: true, maxLength: 30, nullable: true),
                    JobPosition = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Applican__39AE91A88E0F09FE", x => x.ApplicantId);
                });

            migrationBuilder?.CreateTable(name: "JobPositions", columns: table => new { Id = table.Column<int>(type: "int", nullable: false), ApplicantId = table.Column<int>(type: "int", nullable: true), WorkPosition = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true) }, constraints: table => { table?.PrimaryKey("PK__JobPosit__3214EC0788B78676", x => x.Id); });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicant");

            migrationBuilder.DropTable(
                name: "JobPositions");
        }
    }
}
