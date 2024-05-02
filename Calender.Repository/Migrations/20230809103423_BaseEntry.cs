using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Repository.Migrations
{
    /// <inheritdoc />
    public partial class BaseEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "UserDevices");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "EventAttachments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime",
                nullable: true,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "UserRoles",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "UserRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UserRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "UserRoles",
                type: "datetime",
                nullable: true,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "UserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "UserDevices",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "UserDevices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "UserDevices",
                type: "datetime",
                nullable: true,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "UserDevices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Roles",
                type: "datetime",
                nullable: true,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Reminders",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Reminders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Reminders",
                type: "datetime",
                nullable: true,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Reminders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "RecurringEvents",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "RecurringEvents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "RecurringEvents",
                type: "datetime",
                nullable: true,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "RecurringEvents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Locations",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Locations",
                type: "datetime",
                nullable: true,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Events",
                type: "datetime",
                nullable: true,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Eventperiods",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Eventperiods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Eventperiods",
                type: "datetime",
                nullable: true,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Eventperiods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "EventAttendees",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "EventAttendees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "EventAttendees",
                type: "datetime",
                nullable: true,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "EventAttendees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "EventAttachments",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "EventAttachments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "EventAttachments",
                type: "datetime",
                nullable: true,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "EventAttachments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Devices",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Devices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Devices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Devices",
                type: "datetime",
                nullable: true,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Devices",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Applications",
                type: "datetime",
                nullable: false,
                //defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
                defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));


            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Applications",
                type: "datetime",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Applications",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "UserDevices");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "UserDevices");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "UserDevices");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "UserDevices");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "RecurringEvents");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "RecurringEvents");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "RecurringEvents");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "RecurringEvents");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Eventperiods");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Eventperiods");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Eventperiods");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Eventperiods");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "EventAttendees");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EventAttendees");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "EventAttendees");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EventAttendees");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "EventAttachments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EventAttachments");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "EventAttachments");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EventAttachments");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "ID");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "UserDevices",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Locations",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Locations",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Events",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Events",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Events",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Events",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "EventAttachments",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Applications",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Applications",
                type: "datetime",
                nullable: true);
        }
    }
}
