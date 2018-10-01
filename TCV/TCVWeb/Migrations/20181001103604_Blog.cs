using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TCVWeb.Migrations
{
    public partial class Blog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopItem_UserThread_ThreadId",
                table: "ShopItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItemTaxo_Taxonomy_TaxoId",
                table: "ShopItemTaxo");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxonomy_Taxonomy_ParentId",
                table: "Taxonomy");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMessage_UserMessage_ParentId",
                table: "UserMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMessage_UserThread_ThreadId",
                table: "UserMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMessage_AspNetUsers_UserId",
                table: "UserMessage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserThread",
                table: "UserThread");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMessage",
                table: "UserMessage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Taxonomy",
                table: "Taxonomy");

            migrationBuilder.RenameTable(
                name: "UserThread",
                newName: "UserThreads");

            migrationBuilder.RenameTable(
                name: "UserMessage",
                newName: "UserMessages");

            migrationBuilder.RenameTable(
                name: "Taxonomy",
                newName: "Taxonomies");

            migrationBuilder.RenameIndex(
                name: "IX_UserMessage_UserId",
                table: "UserMessages",
                newName: "IX_UserMessages_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserMessage_ThreadId",
                table: "UserMessages",
                newName: "IX_UserMessages_ThreadId");

            migrationBuilder.RenameIndex(
                name: "IX_UserMessage_ParentId",
                table: "UserMessages",
                newName: "IX_UserMessages_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Taxonomy_Name_Type",
                table: "Taxonomies",
                newName: "IX_Taxonomies_Name_Type");

            migrationBuilder.RenameIndex(
                name: "IX_Taxonomy_ParentId",
                table: "Taxonomies",
                newName: "IX_Taxonomies_ParentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserThreads",
                table: "UserThreads",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMessages",
                table: "UserMessages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Taxonomies",
                table: "Taxonomies",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AlbumId = table.Column<int>(nullable: true),
                    ThreadId = table.Column<int>(nullable: true),
                    CreateUser = table.Column<string>(maxLength: 128, nullable: true),
                    UpdateUser = table.Column<string>(maxLength: 128, nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: true),
                    PublishTime = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(maxLength: 128, nullable: false),
                    Image = table.Column<string>(maxLength: 512, nullable: true),
                    ExtLink = table.Column<string>(maxLength: 1024, nullable: true),
                    Preview = table.Column<string>(maxLength: 1024, nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Format = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPosts_MediaAlbums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "MediaAlbums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogPosts_UserThreads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "UserThreads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostTaxoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TaxoId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostTaxoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPostTaxoes_BlogPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogPostTaxoes_Taxonomies_TaxoId",
                        column: x => x.TaxoId,
                        principalTable: "Taxonomies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_AlbumId",
                table: "BlogPosts",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_ThreadId",
                table: "BlogPosts",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostTaxoes_PostId",
                table: "BlogPostTaxoes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostTaxoes_TaxoId",
                table: "BlogPostTaxoes",
                column: "TaxoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItem_UserThreads_ThreadId",
                table: "ShopItem",
                column: "ThreadId",
                principalTable: "UserThreads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItemTaxo_Taxonomies_TaxoId",
                table: "ShopItemTaxo",
                column: "TaxoId",
                principalTable: "Taxonomies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxonomies_Taxonomies_ParentId",
                table: "Taxonomies",
                column: "ParentId",
                principalTable: "Taxonomies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_UserMessages_ParentId",
                table: "UserMessages",
                column: "ParentId",
                principalTable: "UserMessages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_UserThreads_ThreadId",
                table: "UserMessages",
                column: "ThreadId",
                principalTable: "UserThreads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_AspNetUsers_UserId",
                table: "UserMessages",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopItem_UserThreads_ThreadId",
                table: "ShopItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItemTaxo_Taxonomies_TaxoId",
                table: "ShopItemTaxo");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxonomies_Taxonomies_ParentId",
                table: "Taxonomies");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_UserMessages_ParentId",
                table: "UserMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_UserThreads_ThreadId",
                table: "UserMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_AspNetUsers_UserId",
                table: "UserMessages");

            migrationBuilder.DropTable(
                name: "BlogPostTaxoes");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserThreads",
                table: "UserThreads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMessages",
                table: "UserMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Taxonomies",
                table: "Taxonomies");

            migrationBuilder.RenameTable(
                name: "UserThreads",
                newName: "UserThread");

            migrationBuilder.RenameTable(
                name: "UserMessages",
                newName: "UserMessage");

            migrationBuilder.RenameTable(
                name: "Taxonomies",
                newName: "Taxonomy");

            migrationBuilder.RenameIndex(
                name: "IX_UserMessages_UserId",
                table: "UserMessage",
                newName: "IX_UserMessage_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserMessages_ThreadId",
                table: "UserMessage",
                newName: "IX_UserMessage_ThreadId");

            migrationBuilder.RenameIndex(
                name: "IX_UserMessages_ParentId",
                table: "UserMessage",
                newName: "IX_UserMessage_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Taxonomies_Name_Type",
                table: "Taxonomy",
                newName: "IX_Taxonomy_Name_Type");

            migrationBuilder.RenameIndex(
                name: "IX_Taxonomies_ParentId",
                table: "Taxonomy",
                newName: "IX_Taxonomy_ParentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserThread",
                table: "UserThread",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMessage",
                table: "UserMessage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Taxonomy",
                table: "Taxonomy",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItem_UserThread_ThreadId",
                table: "ShopItem",
                column: "ThreadId",
                principalTable: "UserThread",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItemTaxo_Taxonomy_TaxoId",
                table: "ShopItemTaxo",
                column: "TaxoId",
                principalTable: "Taxonomy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxonomy_Taxonomy_ParentId",
                table: "Taxonomy",
                column: "ParentId",
                principalTable: "Taxonomy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessage_UserMessage_ParentId",
                table: "UserMessage",
                column: "ParentId",
                principalTable: "UserMessage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessage_UserThread_ThreadId",
                table: "UserMessage",
                column: "ThreadId",
                principalTable: "UserThread",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessage_AspNetUsers_UserId",
                table: "UserMessage",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
