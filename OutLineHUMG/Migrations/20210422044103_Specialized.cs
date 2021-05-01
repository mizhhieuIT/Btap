using Microsoft.EntityFrameworkCore.Migrations;

namespace OutLineHUMG.Migrations
{
    public partial class Specialized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "specialized",
                columns: table => new
                {
                    Idspecialized = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titlespecialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeSpecialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contentspecialized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseofYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Statusspecialized = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialized", x => x.Idspecialized);
                });

            migrationBuilder.CreateTable(
                name: "subject",
                columns: table => new
                {
                    Idsubject = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusSubject = table.Column<byte>(type: "tinyint", nullable: false),
                    Idspecialized = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subject", x => x.Idsubject);
                    table.ForeignKey(
                        name: "FK_subject_specialized_Idspecialized",
                        column: x => x.Idspecialized,
                        principalTable: "specialized",
                        principalColumn: "Idspecialized",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_subject_Idspecialized",
                table: "subject",
                column: "Idspecialized");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "subject");

            migrationBuilder.DropTable(
                name: "specialized");
        }
    }
}
