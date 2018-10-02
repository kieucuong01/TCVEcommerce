using Microsoft.EntityFrameworkCore.Migrations;

namespace TCVWeb.Migrations
{
    public partial class Media : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaAlbum_AspNetUsers_UserId",
                table: "MediaAlbum");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaFile_MediaAlbum_AlbumId",
                table: "MediaFile");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItem_MediaAlbum_AlbumId",
                table: "ShopItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MediaFile",
                table: "MediaFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MediaAlbum",
                table: "MediaAlbum");

            migrationBuilder.RenameTable(
                name: "MediaFile",
                newName: "MediaFiles");

            migrationBuilder.RenameTable(
                name: "MediaAlbum",
                newName: "MediaAlbums");

            migrationBuilder.RenameIndex(
                name: "IX_MediaFile_AlbumId",
                table: "MediaFiles",
                newName: "IX_MediaFiles_AlbumId");

            migrationBuilder.RenameIndex(
                name: "IX_MediaAlbum_UserId",
                table: "MediaAlbums",
                newName: "IX_MediaAlbums_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MediaFiles",
                table: "MediaFiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MediaAlbums",
                table: "MediaAlbums",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MediaAlbums_AspNetUsers_UserId",
                table: "MediaAlbums",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaFiles_MediaAlbums_AlbumId",
                table: "MediaFiles",
                column: "AlbumId",
                principalTable: "MediaAlbums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItem_MediaAlbums_AlbumId",
                table: "ShopItem",
                column: "AlbumId",
                principalTable: "MediaAlbums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaAlbums_AspNetUsers_UserId",
                table: "MediaAlbums");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaFiles_MediaAlbums_AlbumId",
                table: "MediaFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItem_MediaAlbums_AlbumId",
                table: "ShopItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MediaFiles",
                table: "MediaFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MediaAlbums",
                table: "MediaAlbums");

            migrationBuilder.RenameTable(
                name: "MediaFiles",
                newName: "MediaFile");

            migrationBuilder.RenameTable(
                name: "MediaAlbums",
                newName: "MediaAlbum");

            migrationBuilder.RenameIndex(
                name: "IX_MediaFiles_AlbumId",
                table: "MediaFile",
                newName: "IX_MediaFile_AlbumId");

            migrationBuilder.RenameIndex(
                name: "IX_MediaAlbums_UserId",
                table: "MediaAlbum",
                newName: "IX_MediaAlbum_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MediaFile",
                table: "MediaFile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MediaAlbum",
                table: "MediaAlbum",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MediaAlbum_AspNetUsers_UserId",
                table: "MediaAlbum",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaFile_MediaAlbum_AlbumId",
                table: "MediaFile",
                column: "AlbumId",
                principalTable: "MediaAlbum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItem_MediaAlbum_AlbumId",
                table: "ShopItem",
                column: "AlbumId",
                principalTable: "MediaAlbum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
