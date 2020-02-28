using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produkter",
                columns: table => new
                {
                    ProduktId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductOfTheWeek = table.Column<bool>(nullable: false),
                    IsProductOfTheWeek = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkter", x => x.ProduktId);
                    table.ForeignKey(
                        name: "FK_Produkter_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProduktId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ProdukterProduktId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Produkter_ProdukterProduktId",
                        column: x => x.ProdukterProduktId,
                        principalTable: "Produkter",
                        principalColumn: "ProduktId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdukterProduktId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Produkter_ProdukterProduktId",
                        column: x => x.ProdukterProduktId,
                        principalTable: "Produkter",
                        principalColumn: "ProduktId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Sovrum", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Badrum", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Vardagsrum", null });

            migrationBuilder.InsertData(
                table: "Produkter",
                columns: new[] { "ProduktId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOfTheWeek", "LongDescription", "Name", "Price", "ProductOfTheWeek", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://www.systerlycklig.se/images/2.112861/missoni-home-handduk-giacomo-70x115-cm.jpeg", "https://www.systerlycklig.se/images/2.112861/missoni-home-handduk-giacomo-70x115-cm.jpeg", false, false, "Golv som passar till vardagsrum, och är inspirerat av ett tyg från Missoni och har ett distinkt grafiskt mönster med en flödande gradient, presenterad i tidlöst svart. ", "Golv(Missoni Home)", 56.95m, false, "Missoni Home" },
                    { 4, 1, "https://www.systerlycklig.se/images/2.115969/designers-guild-matta-ashbee-berry-250x350-cm.jpeg", "https://www.systerlycklig.se/images/2.115969/designers-guild-matta-ashbee-berry-250x350-cm.jpeg", false, false, "Glow är en mörk, svartblå matta med kopparinslag. Mattan är producerad i vårt egna originalmaterial av vinyl som förstärkts genom att addera ull och glittrigt garn. ", "Matta(Duet - Duet Glow)", 83.95m, false, "Duet - Duet Glow" },
                    { 7, 1, "https://www.systerlycklig.se/images/2.199538/sandberg-tapet-hannes-morkbla.jpeg", "https://www.systerlycklig.se/images/2.199538/sandberg-tapet-hannes-morkbla.jpeg", false, false, "En slitstark och vacker klinker i grå nyanser och naturliga marmoreringar. ", "Marmor(Aura Marengo Blank )", 610.95m, false, "Aura Marengo Blank " },
                    { 2, 2, " https://www.systerlycklig.se/images/2.111554/designers-guild-matta-eberson-cobalt-160x260-cm.jpeg", "https://www.systerlycklig.se/images/2.111554/designers-guild-matta-eberson-cobalt-160x260-cm.jpeg", false, false, "Ett varmt, taktilt golv med en handgjord känsla – dåtid möter nutid i en svart/grå nyans. ", "Golv(Artisan - Coal)", 76.95m, false, "Artisan - Coal" },
                    { 6, 2, "https://www.systerlycklig.se/images/2.110160/missoni-home-badrumsmatta-giacomo.jpeg", "https://www.systerlycklig.se/images/2.110160/missoni-home-badrumsmatta-giacomo.jpeg", false, false, "Badrumsmatta Giacomo från italienska Missoni med klassiskt zickzackmönster. ", "Matta(Giacomo)", 116.95m, false, "Giacomo" },
                    { 8, 2, "https://www.systerlycklig.se/images/2.199595/sandberg-tapet-hannes-svart.jpeg", "https://www.systerlycklig.se/images/2.199595/sandberg-tapet-hannes-svart.jpeg", false, false, "marmorerad granitkeramik i grå nyanser. Dramatiskt mönster med känsla av mörka moln som hopar sig. ", "Marmor(Alvesta Assos Grey Matt)", 568.95m, false, "Alvesta Assos Grey Matt" },
                    { 3, 3, "https://www.systerlycklig.se/images/2.115904/designers-guild-matta-caretti-linen-160x260-cm.jpeg", "https://www.systerlycklig.se/images/2.115904/designers-guild-matta-caretti-linen-160x260-cm.jpeg", false, false, "Ett golv inspirerat av Sisalmattor, med en mjuk, strukturerad och ändå slitstark känsla. ", "Golv(BKB - Metallic Alpha)", 83.95m, false, "BKB - Metallic Alpha" },
                    { 5, 3, "https://www.systerlycklig.se/images/2.153034/designers-guild-matta-castillion-fuchsia-160x260-cm.jpeg", "https://www.systerlycklig.se/images/2.153034/designers-guild-matta-castillion-fuchsia-160x260-cm.jpeg", false, false, "Matta Castillion Fuchsia från Designers Guild är en handvävd matta med modernt diagonalt rutmönster. ", "Matta(Castillion Fuchsia)", 105.95m, false, "Castillion Fuchsia" },
                    { 9, 3, "https://cdn.cdon.com/media-dynamic/images/product/kidsbaby/kidsbabydefault/image838/kakel_d-sign_metro_marquina_10x20-49323698-69612507-xtra1.jpg", "https://cdn.cdon.com/media-dynamic/images/product/kidsbaby/kidsbabydefault/image838/kakel_d-sign_metro_marquina_10x20-49323698-69612507-xtra1.jpg", false, false, " slät yta och marmor-känsla. Ger en exklusiv och vacker vägg. ", "Marmor(Marquina )", 428.95m, false, "Marquina " }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProdukterProduktId",
                table: "OrderDetails",
                column: "ProdukterProduktId");

            migrationBuilder.CreateIndex(
                name: "IX_Produkter_CategoryId",
                table: "Produkter",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProdukterProduktId",
                table: "ShoppingCartItems",
                column: "ProdukterProduktId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Produkter");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
