using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactFormPage.Migrations
{
    public partial class BetterCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Body",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Messages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Body",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Messages");
        }
    }
}
