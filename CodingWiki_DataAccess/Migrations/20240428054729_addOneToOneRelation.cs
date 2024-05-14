using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWikiDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addOneToOneRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Book_Id",
                table: "BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book_Id",
                table: "BookDetails");
        }
    }
}
