using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class migrationaddd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblservice");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "tblOrders",
                newName: "prodID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "prodID",
                table: "tblOrders",
                newName: "ServiceId");

            migrationBuilder.CreateTable(
                name: "tblservice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicePrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblservice", x => x.Id);
                });
        }
    }
}
