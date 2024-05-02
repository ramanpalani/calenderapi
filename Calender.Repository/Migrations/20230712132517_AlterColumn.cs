using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AlterColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "DomainName",
            //    table: "Applications");
         
            migrationBuilder.RenameColumn(
                name: "DomainID",
                table: "Users",
                newName: "ApplicationId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "UserRoles",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "UserRoles",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "UserRoles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DomainID",
                table: "UserRoles",
                newName: "ApplicationId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "UserDevices",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "UserDevices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Roles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EventID",
                table: "Reminders",
                newName: "EventId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Reminders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EventID",
                table: "RecurringEvents",
                newName: "EventId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "RecurringEvents",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Locations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Events",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "Events",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "EventPeriodID",
                table: "Events",
                newName: "EventPeriodId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Events",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Eventperiods",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "EventAttendees",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "EventID",
                table: "EventAttendees",
                newName: "EventId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "EventAttendees",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EventID",
                table: "EventAttachments",
                newName: "EventId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "EventAttachments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Devices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Applications",
                newName: "Id");


            migrationBuilder.RenameColumn(
                name: "DomainName",
                table: "Applications",
                newName:"ApplicationName");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

   

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ApplicationName",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "ApplicationId",
                table: "Users",
                newName: "DomainID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserRoles",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "UserRoles",
                newName: "RoleID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserRoles",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ApplicationId",
                table: "UserRoles",
                newName: "DomainID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserDevices",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserDevices",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Roles",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Reminders",
                newName: "EventID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reminders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "RecurringEvents",
                newName: "EventID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RecurringEvents",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Locations",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Events",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Events",
                newName: "LocationID");

            migrationBuilder.RenameColumn(
                name: "EventPeriodId",
                table: "Events",
                newName: "EventPeriodID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Events",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Eventperiods",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "EventAttendees",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "EventAttendees",
                newName: "EventID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EventAttendees",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "EventAttachments",
                newName: "EventID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EventAttachments",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Devices",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Applications",
                newName: "ID");

            migrationBuilder.RenameColumn(
            name: "DomainName",
            table: "Applications",
            newName: "ApplicationName");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "Applications"
                );

        }
    }
}
