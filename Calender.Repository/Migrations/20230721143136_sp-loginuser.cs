using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendar.Repository.Migrations
{
    /// <inheritdoc />
    public partial class sploginuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[sp_loginuser]
                    @email varchar(50),
@pwd varchar(50),
@appid int
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from Users where Email=@email and Password=@pwd and ApplicationId=@appid
                END";

            migrationBuilder.Sql(sp);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
        }
    }
}
