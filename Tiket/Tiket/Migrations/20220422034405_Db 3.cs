using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tiket.Migrations
{
    public partial class Db3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrances_Tickets_TicketId",
                table: "Entrances");

            migrationBuilder.DropIndex(
                name: "IX_Entrances_TicketId",
                table: "Entrances");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Entrances");

            migrationBuilder.AddColumn<int>(
                name: "EntranceId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EntranceId",
                table: "Tickets",
                column: "EntranceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Entrances_EntranceId",
                table: "Tickets",
                column: "EntranceId",
                principalTable: "Entrances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Entrances_EntranceId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_EntranceId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EntranceId",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Entrances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Entrances_TicketId",
                table: "Entrances",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrances_Tickets_TicketId",
                table: "Entrances",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
