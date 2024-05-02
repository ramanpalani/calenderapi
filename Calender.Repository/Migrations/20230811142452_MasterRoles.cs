using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Repository.Migrations
{
    /// <inheritdoc />
    public partial class MasterRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table: "Roles", column: "RolesName", value: "Admin");
            migrationBuilder.InsertData(table: "Roles", column: "RolesName", value: "Broker");
            migrationBuilder.InsertData(table: "Roles", column: "RolesName", value: "HR");
            migrationBuilder.InsertData(table: "Roles", column: "RolesName", value: "Correspondence");
            migrationBuilder.InsertData(table: "Roles", column: "RolesName", value: "Director");
            migrationBuilder.InsertData(table: "Roles", column: "RolesName", value: "FinalClient");
            migrationBuilder.InsertData(table: "Roles", column: "RolesName", value: "CommercialDirector");
            migrationBuilder.InsertData(table: "Roles", column: "RolesName", value: "Manager");
            migrationBuilder.InsertData(table: "Roles", column: "RolesName", value: "InterLocator");
     
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
