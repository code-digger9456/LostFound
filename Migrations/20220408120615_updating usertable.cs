using Microsoft.EntityFrameworkCore.Migrations;

namespace LostFound.Migrations
{
    public partial class updatingusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "UserDetails",
                newName: "Password");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "UserDetails",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailId",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityQuestion",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "UserDetails");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "UserDetails");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "UserDetails");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "UserDetails");

            migrationBuilder.DropColumn(
                name: "SecurityQuestion",
                table: "UserDetails");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "UserDetails",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
