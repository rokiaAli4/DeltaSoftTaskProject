using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskEF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Member_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Member_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Task_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Member_Id = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    deliver_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Task_Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Members_FK_Member_Id",
                        column: x => x.FK_Member_Id,
                        principalTable: "Members",
                        principalColumn: "Member_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Member_Id", "Address", "Email", "IsDeleted", "MemberName", "Phone" },
                values: new object[,]
                {
                    { 1, "mansoura", "Mohamed@gmail.com", false, "Mohamed", "88888888" },
                    { 2, "Alex", "Rokia@gmail.com", false, "Rokia", "999999999" },
                    { 3, "cairo", "Salem@gmail.com", false, "Salem", "1111111111" },
                    { 4, "mansoura", "Noor@gmail.com", false, "Noor", "99999999" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_FK_Member_Id",
                table: "Tasks",
                column: "FK_Member_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
