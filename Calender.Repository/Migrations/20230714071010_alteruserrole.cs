using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Repository.Migrations
{
    /// <inheritdoc />
    public partial class alteruserrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
     

            migrationBuilder.AddColumn<string>(
                name: "AccessKey",
                table: "UserRoles",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessKey",
                table: "UserRoles");

           
        }
    }
}
