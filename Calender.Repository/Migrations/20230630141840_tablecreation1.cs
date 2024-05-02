using Calendar.Models.Models.Auth;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Repository.Migrations
{
    /// <inheritdoc />
    public partial class tablecreation1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           


            migrationBuilder.CreateTable(
name: "Applications",
columns: table => new
{
    ID = table.Column<int>(type: "int", nullable: false)
  .Annotation("SqlServer:Identity", "1, 1"),
    DomainName = table.Column<string>(type: "varchar(100)", nullable: false),
    Description = table.Column<string>(type: "text", nullable: true),
    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
    ExpirationDate = table.Column<DateTime>(type: "datetime", nullable: true),
    IsActive = table.Column<bool>(type: "bit", nullable: true)
},
constraints: table =>
{
    table.PrimaryKey("PK_Applications", x => x.ID);
});


            migrationBuilder.CreateTable(
         name: "Devices",
         columns: table => new
         {
             ID = table.Column<int>(type: "int", nullable: false)
                 .Annotation("SqlServer:Identity", "1, 1"),
             IsAppPlatformBlocked = table.Column<bool>(type: "bit", nullable: true),
             Platform = table.Column<string>(type: "varchar(100)", nullable: true)
         },
         constraints: table =>
         {
             table.PrimaryKey("PK_Devices", x => x.ID);
         });






            migrationBuilder.CreateTable(
          name: "EventAttachments",
          columns: table => new
          {
              ID = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
              EventID = table.Column<int>(type: "int", nullable: false),
              FileName = table.Column<string>(type: "varchar(100)", nullable: true),
              FilePathOrURL = table.Column<string>(type: "varchar(100)", nullable: true),
              CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
          },
          constraints: table =>
          {
              table.PrimaryKey("PK_EventAttachments", x => x.ID);

          });



            migrationBuilder.CreateTable(
          name: "EventAttendees",
          columns: table => new
          {
              ID = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
              EventID = table.Column<int>(type: "int", nullable: false),
              UserID = table.Column<int>(type: "int", nullable: false),
              ResponseStatus = table.Column<string>(type: "varchar(20)", nullable: true)
          },
          constraints: table =>
          {
              table.PrimaryKey("PK_EventAttendees", x => x.ID);
          });



            migrationBuilder.CreateTable(
              name: "Eventperiods",
              columns: table => new
              {
                  ID = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  Period = table.Column<string>(type: "varchar(50)", nullable: true),
                  PeriodValues = table.Column<int>(type: "int", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Eventperiods", x => x.ID);
              });

            migrationBuilder.CreateTable(
    name: "Locations",
    columns: table => new
    {
        ID = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        LocationName = table.Column<string>(type: "varchar(255)", nullable: true),
        Address = table.Column<string>(type: "varchar(255)", nullable: true),
        Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        Description = table.Column<string>(type: "varchar(max)", nullable: true),
        CreationDate = table.Column<DateTime>(type: "datetime", nullable: true),
        LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_Locations", x => x.ID);
    });

            migrationBuilder.CreateTable(
 name: "Events",
 columns: table => new
 {
     ID = table.Column<int>(type: "int", nullable: false)
         .Annotation("SqlServer:Identity", "1, 1"),
     Title = table.Column<string>(type: "varchar(100)", nullable: false),
     Description = table.Column<string>(type: "text", nullable: true),
     StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
     EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
     UserID = table.Column<int>(type: "int", nullable: false),
     PrivacySettings = table.Column<string>(type: "varchar(50)", nullable: true),
     EventPeriodID = table.Column<int>(type: "int", nullable: false),
     Color = table.Column<string>(type: "varchar(20)", nullable: true),
     CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
     LastModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
     LocationID = table.Column<int>(type: "int", nullable: false),
     IsActive = table.Column<bool>(type: "bit", nullable: true),
     IsDeleted = table.Column<bool>(type: "bit", nullable: true)
 },
 constraints: table =>
 {
     table.PrimaryKey("PK_Events", x => x.ID);
 });





            migrationBuilder.CreateTable(
                     name: "RecurringEvents",
                     columns: table => new
                     {
                         ID = table.Column<int>(type: "int", nullable: false)
                             .Annotation("SqlServer:Identity", "1, 1"),
                         EventID = table.Column<int>(type: "int", nullable: false),
                         RecurrencePattern = table.Column<string>(type: "varchar(50)", nullable: true),
                         RecurrenceStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                         RecurrenceEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                         Exceptions = table.Column<string>(type: "varchar(max)", nullable: true)
                     },
                     constraints: table =>
                     {
                         table.PrimaryKey("PK_RecurringEvents", x => x.ID);
                     });



            migrationBuilder.CreateTable(
            name: "Reminders",
            columns: table => new
            {
                ID = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                EventID = table.Column<int>(type: "int", nullable: false),
                ReminderDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                IsSent = table.Column<bool>(type: "bit", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Reminders", x => x.ID);
            });




            migrationBuilder.CreateTable(
              name: "Roles",
              columns: table => new
              {
                  ID = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  RolesName = table.Column<string>(type: "varchar(50)", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Roles", x => x.ID);
              });

            migrationBuilder.CreateTable(
            name: "UserDevices",
            columns: table => new
            {
                ID = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                UserID = table.Column<int>(type: "int", nullable: false),
                PlatformDetails = table.Column<string>(type: "nvarchar(500)", nullable: true),
                ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                DeviceId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_UserDevices", x => x.ID);
            });




            migrationBuilder.CreateTable(
                  name: "UserRoles",
                  columns: table => new
                  {
                      ID = table.Column<int>(type: "int", nullable: false)
                          .Annotation("SqlServer:Identity", "1, 1"),
                      DomainID = table.Column<int>(type: "int", nullable: false),
                      UserID = table.Column<int>(type: "int", nullable: false),
                      RoleID = table.Column<int>(type: "int", nullable: false)
                  },
                  constraints: table =>
                  {
                      table.PrimaryKey("PK_UserRoles", x => x.ID);
                  });



            migrationBuilder.CreateTable(
             name: "Users",
             columns: table => new
             {
                 ID = table.Column<int>(type: "int", nullable: false)
                     .Annotation("SqlServer:Identity", "1, 1"),
                 Username = table.Column<string>(type: "varchar(50)", nullable: false),
                 Email = table.Column<string>(type: "varchar(100)", nullable: false),
                 Password = table.Column<string>(type: "varchar(100)", nullable: false),
                 CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                 LastLoginDate = table.Column<DateTime>(type: "datetime", nullable: true),
                 DomainID = table.Column<int>(type: "int", nullable: false),
                 SecretKey = table.Column<string>(type: "varchar(100)", nullable: false),
                 IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                 IsActive = table.Column<bool>(type: "bit", nullable: true)
             },
             constraints: table =>
             {
                 table.PrimaryKey("PK_Users", x => x.ID);
             });



            migrationBuilder.AddForeignKey(
name: "FK_Event_Attachments_EventId",
table: "EventAttachments",
column: "EventId",
principalTable: "Events",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
       name: "FK_Event_Attendees_EventId",
       table: "EventAttendees",
       column: "EventId",
       principalTable: "Events",
       principalColumn: "Id",
       onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
        name: "FK_Event_Attendees_UserId",
        table: "EventAttendees",
        column: "UserId",
        principalTable: "Users",
        principalColumn: "Id",
        onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
name: "FK_Event_User_Id",
table: "Events",
column: "UserID",
principalTable: "Users",
principalColumn: "Id"
//onDelete: ReferentialAction.Cascade
);

            migrationBuilder.AddForeignKey(
          name: "FK_EventPeriod_Id",
          table: "Events",
          column: "EventPeriodID",
          principalTable: "Eventperiods",
          principalColumn: "Id",
          onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
        name: "FK_Event_LocationId",
        table: "Events",
        column: "LocationID",
        principalTable: "Locations",
        principalColumn: "Id",
        onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
name: "FK_RecurringEvents_EventId",
table: "RecurringEvents",
column: "EventID",
principalTable: "Events",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);


            migrationBuilder.AddForeignKey(
name: "FK_Reminders_EventId",
table: "Reminders",
column: "EventID",
principalTable: "Events",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);


            migrationBuilder.AddForeignKey(
name: "FK_UserDevices_UserId",
table: "UserDevices",
column: "UserID",
principalTable: "Users",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
name: "FK_UserDevices_DeviceId",
table: "UserDevices",
column: "DeviceID",
principalTable: "Devices",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);


            migrationBuilder.AddForeignKey(
name: "FK_UserRoles_UserId",
table: "UserRoles",
column: "UserID",
principalTable: "Users",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
name: "FK_UserRoles_ApplicationId",
table: "UserRoles",
column: "DomainID",
principalTable: "Applications",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
name: "FK_Roles_ApplicationId",
table: "UserRoles",
column: "RoleID",
principalTable: "Roles",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
name: "FK_Users_ApplicationId",
table: "Users",
column: "DomainID",
principalTable: "Applications",
principalColumn: "Id"
//onDelete: ReferentialAction.Cascade
);



        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
        name: "Applications");

            migrationBuilder.DropTable(
           name: "Devices");

            migrationBuilder.DropTable(
           name: "Events");

            migrationBuilder.DropTable(
            name: "EventAttachments");

            migrationBuilder.DropTable(
          name: "EventAttendees");

            migrationBuilder.DropTable(
            name: "Eventperiods");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "RecurringEvents");

            migrationBuilder.DropTable(
                name: "Reminders");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserDevices");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");



        }
    }
}
