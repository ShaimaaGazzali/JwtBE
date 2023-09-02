using Microsoft.EntityFrameworkCore.Migrations;

namespace Base2022.Data.Migrations
{
    public partial class editUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Birthday",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            // migrationBuilder.Sql("INSERT INTO AspNetUsers(Id, FullName, Birthday,Mobile,EmailConfirmed,PhoneNumberConfirmed) Values('1', 'Admin','1-5-1991', '01032336002',1,1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "AspNetUsers");
        }
    }
}
