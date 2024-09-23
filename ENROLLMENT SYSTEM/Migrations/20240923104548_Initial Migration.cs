using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ENROLLMENT_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentEntry",
                columns: table => new
                {
                    StudID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudMidName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudCourse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudYear = table.Column<int>(type: "int", nullable: false),
                    Studremarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEntry", x => x.StudID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentEntry");
        }
    }
}
