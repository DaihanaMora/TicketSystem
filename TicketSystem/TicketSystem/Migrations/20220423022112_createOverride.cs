using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketSystem.Migrations
{
    public partial class createOverride : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Name_EntranceId",
                table: "Tickets",
                columns: new[] { "Name", "EntranceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrances_Description",
                table: "Entrances",
                column: "Description",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tickets_Name_EntranceId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Entrances_Description",
                table: "Entrances");
        }
    }
}
