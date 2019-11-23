using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseLibrary.API.Migrations
{
    public partial class ComplaintRepository : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComplaintDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    ContactNumber = table.Column<string>(maxLength: 10, nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    IssueDescription = table.Column<string>(maxLength: 500, nullable: false),
                    Area = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplaintDetails", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ComplaintDetails",
                columns: new[] { "Id", "Area", "City", "ContactNumber", "CreatedDate", "EmailAddress", "IssueDescription", "LastModifiedDate", "Title" },
                values: new object[] { new Guid("5807ed94-0f48-4aa8-b801-edbc3c59504c"), "Swargate", "Pune", "", new DateTime(2019, 11, 23, 14, 11, 57, 911, DateTimeKind.Utc).AddTicks(3611), "akshayslodha@gmail.com", "Since Last Four Days we are since Network Range Issues in Area. Please can you resolve asap", new DateTime(2019, 11, 23, 19, 41, 57, 911, DateTimeKind.Local).AddTicks(4964), "Internet Range Issue" });

            migrationBuilder.InsertData(
                table: "ComplaintDetails",
                columns: new[] { "Id", "Area", "City", "ContactNumber", "CreatedDate", "EmailAddress", "IssueDescription", "LastModifiedDate", "Title" },
                values: new object[] { new Guid("bff7b16f-f51d-49bd-aeca-3a74a2e031ca"), "Magarpatta", "Pune", "", new DateTime(2019, 11, 23, 14, 11, 57, 913, DateTimeKind.Utc).AddTicks(2696), "akshayslodha@gmail.com", "Increase in Call Drop Since Last Few Days", new DateTime(2019, 11, 23, 19, 41, 57, 913, DateTimeKind.Local).AddTicks(2714), "Call Drop Issue" });

            migrationBuilder.InsertData(
                table: "ComplaintDetails",
                columns: new[] { "Id", "Area", "City", "ContactNumber", "CreatedDate", "EmailAddress", "IssueDescription", "LastModifiedDate", "Title" },
                values: new object[] { new Guid("f502ccd9-8bbd-4c9c-a77b-cdb5b488c9a4"), "Magarpatta", "Pune", "", new DateTime(2019, 11, 23, 14, 11, 57, 913, DateTimeKind.Utc).AddTicks(2840), "lodha.rohit1@gmail.com", "Increase in Call Drop Since Last Few Days", new DateTime(2019, 11, 23, 19, 41, 57, 913, DateTimeKind.Local).AddTicks(2840), "Call Drop Issue" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComplaintDetails");
        }
    }
}
