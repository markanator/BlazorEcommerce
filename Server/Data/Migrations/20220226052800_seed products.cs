using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class seedproducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", "https://th.bing.com/th/id/OIP.sZidizqnhAyTX0Tnx1i4ywHaKj?w=208&h=297&c=7&r=0&o=5&dpr=1.25&pid=1.7", 12.99m, "The Hitchhiker's Guide to the Galaxy, v1.1" },
                    { 2, "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline.", "https://th.bing.com/th/id/R.7a2446a678be4698c510c698d3386ea4?rik=rPXgM6tmXc6p8Q&pid=ImgRaw&r=0", 29.99m, "Ready Player One, v1.1" },
                    { 3, "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.", "https://th.bing.com/th/id/OIP.QZQQcihFq4QJ28fXUzQskgDJE1?w=201&h=309&c=7&r=0&o=5&dpr=1.25&pid=1.7", 9.99m, "1984, v1.1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
