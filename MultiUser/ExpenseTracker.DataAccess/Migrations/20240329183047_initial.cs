using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habits", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Habits",
                columns: new[] { "Id", "Description", "Name", "TenantName" },
                values: new object[,]
                {
                    { 1, "Become a francophone", "Learn French", "Bluewave" },
                    { 2, "Get really fit", "Run a marathon", "AscendTech" },
                    { 3, "Finish your book project", "Write every day", "CloudSphere" },
                    { 4, "Finish your book project", "Write every day", "DataStream" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Habits");
        }
    }
}
