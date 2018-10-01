using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TCVWeb.Migrations
{
    public partial class Produce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopItem_MediaAlbums_AlbumId",
                table: "ShopItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItem_UserThreads_ThreadId",
                table: "ShopItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItemAttrib_ShopAttrib_AttrId",
                table: "ShopItemAttrib");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItemAttrib_ShopItem_ItemId",
                table: "ShopItemAttrib");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItemTaxo_ShopItem_ItemId",
                table: "ShopItemTaxo");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItemTaxo_Taxonomies_TaxoId",
                table: "ShopItemTaxo");

            migrationBuilder.DropTable(
                name: "Campaign");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopItemTaxo",
                table: "ShopItemTaxo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopItemAttrib",
                table: "ShopItemAttrib");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopItem",
                table: "ShopItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopAttrib",
                table: "ShopAttrib");

            migrationBuilder.RenameTable(
                name: "ShopItemTaxo",
                newName: "ShopItemTaxoes");

            migrationBuilder.RenameTable(
                name: "ShopItemAttrib",
                newName: "ShopItemAttribs");

            migrationBuilder.RenameTable(
                name: "ShopItem",
                newName: "ShopItems");

            migrationBuilder.RenameTable(
                name: "ShopAttrib",
                newName: "ShopAttribs");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItemTaxo_TaxoId",
                table: "ShopItemTaxoes",
                newName: "IX_ShopItemTaxoes_TaxoId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItemTaxo_ItemId",
                table: "ShopItemTaxoes",
                newName: "IX_ShopItemTaxoes_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItemAttrib_ItemId",
                table: "ShopItemAttribs",
                newName: "IX_ShopItemAttribs_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItemAttrib_AttrId",
                table: "ShopItemAttribs",
                newName: "IX_ShopItemAttribs_AttrId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItem_ThreadId",
                table: "ShopItems",
                newName: "IX_ShopItems_ThreadId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItem_SKU",
                table: "ShopItems",
                newName: "IX_ShopItems_SKU");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItem_Name",
                table: "ShopItems",
                newName: "IX_ShopItems_Name");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItem_AlbumId",
                table: "ShopItems",
                newName: "IX_ShopItems_AlbumId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopItemTaxoes",
                table: "ShopItemTaxoes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopItemAttribs",
                table: "ShopItemAttribs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopItems",
                table: "ShopItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopAttribs",
                table: "ShopAttribs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Deliver",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    ThreadId = table.Column<int>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 256, nullable: true),
                    City = table.Column<string>(maxLength: 64, nullable: true),
                    State = table.Column<string>(maxLength: 64, nullable: true),
                    Country = table.Column<string>(maxLength: 64, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliver_UserThreads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "UserThreads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deliver_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shippings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 256, nullable: true),
                    City = table.Column<string>(maxLength: 64, nullable: true),
                    State = table.Column<string>(maxLength: 64, nullable: true),
                    Country = table.Column<string>(maxLength: 64, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shippings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShopCarts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopCarts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShopWishes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopWishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopWishes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    ThreadId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 256, nullable: true),
                    City = table.Column<string>(maxLength: 64, nullable: true),
                    State = table.Column<string>(maxLength: 64, nullable: true),
                    Country = table.Column<string>(maxLength: 64, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_UserThreads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "UserThreads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Suppliers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShopOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    DeliverId = table.Column<int>(nullable: true),
                    ShippingId = table.Column<int>(nullable: true),
                    AdjustPrice = table.Column<double>(nullable: false),
                    ShippingFee = table.Column<double>(nullable: false),
                    GrandTotalPrice = table.Column<double>(nullable: false),
                    PaymentInfo = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    DeliveryTime = table.Column<DateTime>(nullable: true),
                    Note = table.Column<string>(maxLength: 256, nullable: true),
                    OrderStatus = table.Column<int>(nullable: false),
                    PaymentStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopOrders_Deliver_DeliverId",
                        column: x => x.DeliverId,
                        principalTable: "Deliver",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShopOrders_Shippings_ShippingId",
                        column: x => x.ShippingId,
                        principalTable: "Shippings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShopOrders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShopCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CartId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ItemAttrib = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopCartItems_ShopCarts_CartId",
                        column: x => x.CartId,
                        principalTable: "ShopCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopCartItems_ShopItems_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ShopItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopWishItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WishId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopWishItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopWishItems_ShopItems_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ShopItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopWishItems_ShopWishes_WishId",
                        column: x => x.WishId,
                        principalTable: "ShopWishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopOrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ItemAttrib = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopOrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopOrderItems_ShopItems_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ShopItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopOrderItems_ShopOrders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "ShopOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliver_ThreadId",
                table: "Deliver",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliver_UserId",
                table: "Deliver",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Shippings_UserId",
                table: "Shippings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItems_CartId",
                table: "ShopCartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItems_ItemId",
                table: "ShopCartItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopCarts_UserId",
                table: "ShopCarts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrderItems_ItemId",
                table: "ShopOrderItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrderItems_OrderId",
                table: "ShopOrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrders_DeliverId",
                table: "ShopOrders",
                column: "DeliverId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrders_ShippingId",
                table: "ShopOrders",
                column: "ShippingId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopOrders_UserId",
                table: "ShopOrders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopWishes_UserId",
                table: "ShopWishes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopWishItems_ItemId",
                table: "ShopWishItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopWishItems_WishId",
                table: "ShopWishItems",
                column: "WishId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_ThreadId",
                table: "Suppliers",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_UserId",
                table: "Suppliers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItemAttribs_ShopAttribs_AttrId",
                table: "ShopItemAttribs",
                column: "AttrId",
                principalTable: "ShopAttribs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItemAttribs_ShopItems_ItemId",
                table: "ShopItemAttribs",
                column: "ItemId",
                principalTable: "ShopItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItems_MediaAlbums_AlbumId",
                table: "ShopItems",
                column: "AlbumId",
                principalTable: "MediaAlbums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItems_UserThreads_ThreadId",
                table: "ShopItems",
                column: "ThreadId",
                principalTable: "UserThreads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItemTaxoes_ShopItems_ItemId",
                table: "ShopItemTaxoes",
                column: "ItemId",
                principalTable: "ShopItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItemTaxoes_Taxonomies_TaxoId",
                table: "ShopItemTaxoes",
                column: "TaxoId",
                principalTable: "Taxonomies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopItemAttribs_ShopAttribs_AttrId",
                table: "ShopItemAttribs");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItemAttribs_ShopItems_ItemId",
                table: "ShopItemAttribs");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItems_MediaAlbums_AlbumId",
                table: "ShopItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItems_UserThreads_ThreadId",
                table: "ShopItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItemTaxoes_ShopItems_ItemId",
                table: "ShopItemTaxoes");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopItemTaxoes_Taxonomies_TaxoId",
                table: "ShopItemTaxoes");

            migrationBuilder.DropTable(
                name: "ShopCartItems");

            migrationBuilder.DropTable(
                name: "ShopOrderItems");

            migrationBuilder.DropTable(
                name: "ShopWishItems");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "ShopCarts");

            migrationBuilder.DropTable(
                name: "ShopOrders");

            migrationBuilder.DropTable(
                name: "ShopWishes");

            migrationBuilder.DropTable(
                name: "Deliver");

            migrationBuilder.DropTable(
                name: "Shippings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopItemTaxoes",
                table: "ShopItemTaxoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopItems",
                table: "ShopItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopItemAttribs",
                table: "ShopItemAttribs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopAttribs",
                table: "ShopAttribs");

            migrationBuilder.RenameTable(
                name: "ShopItemTaxoes",
                newName: "ShopItemTaxo");

            migrationBuilder.RenameTable(
                name: "ShopItems",
                newName: "ShopItem");

            migrationBuilder.RenameTable(
                name: "ShopItemAttribs",
                newName: "ShopItemAttrib");

            migrationBuilder.RenameTable(
                name: "ShopAttribs",
                newName: "ShopAttrib");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItemTaxoes_TaxoId",
                table: "ShopItemTaxo",
                newName: "IX_ShopItemTaxo_TaxoId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItemTaxoes_ItemId",
                table: "ShopItemTaxo",
                newName: "IX_ShopItemTaxo_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItems_ThreadId",
                table: "ShopItem",
                newName: "IX_ShopItem_ThreadId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItems_SKU",
                table: "ShopItem",
                newName: "IX_ShopItem_SKU");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItems_Name",
                table: "ShopItem",
                newName: "IX_ShopItem_Name");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItems_AlbumId",
                table: "ShopItem",
                newName: "IX_ShopItem_AlbumId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItemAttribs_ItemId",
                table: "ShopItemAttrib",
                newName: "IX_ShopItemAttrib_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopItemAttribs_AttrId",
                table: "ShopItemAttrib",
                newName: "IX_ShopItemAttrib_AttrId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopItemTaxo",
                table: "ShopItemTaxo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopItem",
                table: "ShopItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopItemAttrib",
                table: "ShopItemAttrib",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopAttrib",
                table: "ShopAttrib",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Campaign",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 64, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    FullName = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_Code",
                table: "Campaign",
                column: "Code",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItem_MediaAlbums_AlbumId",
                table: "ShopItem",
                column: "AlbumId",
                principalTable: "MediaAlbums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItem_UserThreads_ThreadId",
                table: "ShopItem",
                column: "ThreadId",
                principalTable: "UserThreads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItemAttrib_ShopAttrib_AttrId",
                table: "ShopItemAttrib",
                column: "AttrId",
                principalTable: "ShopAttrib",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItemAttrib_ShopItem_ItemId",
                table: "ShopItemAttrib",
                column: "ItemId",
                principalTable: "ShopItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItemTaxo_ShopItem_ItemId",
                table: "ShopItemTaxo",
                column: "ItemId",
                principalTable: "ShopItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItemTaxo_Taxonomies_TaxoId",
                table: "ShopItemTaxo",
                column: "TaxoId",
                principalTable: "Taxonomies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
