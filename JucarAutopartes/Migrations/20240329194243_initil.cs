using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace INVENTARIOS.Migrations
{
    /// <inheritdoc />
    public partial class initil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdProveedor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Contacto = table.Column<long>(type: "bigint", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdProveedor);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    IdProveedor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NitProveedor = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Contacto = table.Column<long>(type: "bigint", maxLength: 60, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.IdProveedor);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CantidadReal = table.Column<int>(type: "int", maxLength: 60, nullable: false),
                    CantidadIdeal = table.Column<int>(type: "int", maxLength: 60, nullable: false),
                    CantidadMinima = table.Column<int>(type: "int", nullable: false),
                    CantidadAlarma = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "FacturasVentas",
                columns: table => new
                {
                    FacturaVentaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NFactura = table.Column<int>(type: "int", nullable: false),
                    FechaGeneracion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaExpedicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalBruto = table.Column<float>(type: "real", nullable: false),
                    TotalIVA = table.Column<float>(type: "real", nullable: false),
                    TotalRetFuente = table.Column<float>(type: "real", nullable: false),
                    TotalPago = table.Column<float>(type: "real", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturasVentas", x => x.FacturaVentaId);
                    table.ForeignKey(
                        name: "FK_FacturasVentas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacturasCompras",
                columns: table => new
                {
                    FacturaCompraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NFactura = table.Column<int>(type: "int", nullable: false),
                    FechaGeneracion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaExpedicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalBruto = table.Column<float>(type: "real", nullable: false),
                    TotalIVA = table.Column<float>(type: "real", nullable: false),
                    TotalRetFuente = table.Column<float>(type: "real", nullable: false),
                    TotalPago = table.Column<float>(type: "real", nullable: false),
                    IdProveedor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProveedoresIdProveedor = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturasCompras", x => x.FacturaCompraId);
                    table.ForeignKey(
                        name: "FK_FacturasCompras_Proveedores_ProveedoresIdProveedor",
                        column: x => x.ProveedoresIdProveedor,
                        principalTable: "Proveedores",
                        principalColumn: "IdProveedor");
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Cantidad = table.Column<int>(type: "int", maxLength: 60, nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lugar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCategoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MetodoPagos",
                columns: table => new
                {
                    IdMetodoPago = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    NombrePlataforma = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    FacturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodoPagos", x => x.IdMetodoPago);
                    table.ForeignKey(
                        name: "FK_MetodoPagos_FacturasVentas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "FacturasVentas",
                        principalColumn: "FacturaVentaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesFacturaCompras",
                columns: table => new
                {
                    DetalleFacturaCompraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ValorUnitario = table.Column<float>(type: "real", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    IVA = table.Column<float>(type: "real", nullable: false),
                    ValorDescuento = table.Column<float>(type: "real", nullable: false),
                    FacturaCompraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesFacturaCompras", x => x.DetalleFacturaCompraId);
                    table.ForeignKey(
                        name: "FK_DetallesFacturaCompras_FacturasCompras_FacturaCompraId",
                        column: x => x.FacturaCompraId,
                        principalTable: "FacturasCompras",
                        principalColumn: "FacturaCompraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesFacturaCompras_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesFacturaVentas",
                columns: table => new
                {
                    DetalleFacturaVentaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ValorUnitario = table.Column<float>(type: "real", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    IVA = table.Column<float>(type: "real", nullable: false),
                    ValorDescuento = table.Column<float>(type: "real", nullable: false),
                    ProductoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacturaVentaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesFacturaVentas", x => x.DetalleFacturaVentaId);
                    table.ForeignKey(
                        name: "FK_DetallesFacturaVentas_FacturasVentas_FacturaVentaId",
                        column: x => x.FacturaVentaId,
                        principalTable: "FacturasVentas",
                        principalColumn: "FacturaVentaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesFacturaVentas_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoricosPrecios",
                columns: table => new
                {
                    IdHistoricoPrecios = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrecioCompra = table.Column<float>(type: "real", maxLength: 60, nullable: false),
                    PrecioVenta = table.Column<float>(type: "real", maxLength: 60, nullable: false),
                    PrecioDescuento = table.Column<float>(type: "real", nullable: false),
                    FechaDescuento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricosPrecios", x => x.IdHistoricoPrecios);
                    table.ForeignKey(
                        name: "FK_HistoricosPrecios_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "278e2588-caf3-4a23-8843-7df5e2faea84", null, "Bodega", "BODEGA" },
                    { "3084120c-5b5c-4686-956a-917f46dcf620", null, "Administrador", "ADMINISTRADOR" },
                    { "776e19a0-9718-4de7-9f70-729d3e7d1908", null, "Cajero", "CAJERO" },
                    { "d0372260-2c7d-46ba-8cee-4df0c4d9d657", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "IdCategoria", "Nombre" },
                values: new object[,]
                {
                    { new Guid("4f9a7cdb-c6dd-4c1c-8ca2-88f34c913c54"), "Portatiles" },
                    { new Guid("5af38236-256e-4ded-a81e-8010f08c51b6"), "Implementos" },
                    { new Guid("b130f449-a5f3-4e3e-a165-d73c3b73a241"), "Auriculares" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "IdProveedor", "Apellido", "Contacto", "Correo", "Direccion", "Documento", "Nombre" },
                values: new object[,]
                {
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "Ortega", 313132352131L, "Ortega@gmail.com", "Gaitana", "3958934", "Maicol Ortega" },
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479815"), "Cardenas", 3134623131L, "Cardenas@gmail.com", "Bilbao", "3948934", "Bryan Linares" },
                    { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "Rodriguez", 3131314131L, "Rodriguez@gmail.com", "lisboa", "39487334", "Angel Correa" }
                });

            migrationBuilder.InsertData(
                table: "FacturasCompras",
                columns: new[] { "FacturaCompraId", "FechaExpedicion", "FechaGeneracion", "FechaVencimiento", "IdProveedor", "NFactura", "ProveedoresIdProveedor", "TotalBruto", "TotalIVA", "TotalPago", "TotalRetFuente" },
                values: new object[,]
                {
                    { new Guid("5c5b2abf-5de1-49cb-98b8-6c13fddc7a6e"), new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9d4c051-49b6-410c-bc78-2d54a9991880"), 1, null, 100000f, 19000f, 139000f, 20000f },
                    { new Guid("6e922ba7-f823-4a3b-81ef-65a55a981c60"), new DateTime(2000, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 2, null, 150000f, 2850f, 182850f, 30000f }
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "IdProveedor", "Apellido", "Contacto", "Correo", "Direccion", "NitProveedor", "Nombre" },
                values: new object[,]
                {
                    { new Guid("c9d4c051-49b6-410c-bc78-2d54a9991880"), "Lopez", 31313131L, "lopez@gmail.com", "gaitana", "39487358944", "Maicol Cardona" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Rodriguez", 31313131L, "Rodriguez@gmail.com", "lisboa", "39487358934", "Angel Correa" }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "StockId", "CantidadAlarma", "CantidadIdeal", "CantidadMinima", "CantidadReal", "FechaIngreso" },
                values: new object[,]
                {
                    { new Guid("9fffc55a-186f-4d62-88b4-78b43b2948c1"), 5, 40, 10, 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(21) },
                    { new Guid("e9208668-35d6-4862-b4f6-2b3fe8f6a525"), 5, 50, 2, 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24) },
                    { new Guid("f46678ca-5e2e-4b36-8d56-5eb110770bbe"), 5, 100, 30, 250, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(22) }
                });

            migrationBuilder.InsertData(
                table: "FacturasVentas",
                columns: new[] { "FacturaVentaId", "ClienteId", "FechaExpedicion", "FechaGeneracion", "FechaVencimiento", "NFactura", "TotalBruto", "TotalIVA", "TotalPago", "TotalRetFuente" },
                values: new object[,]
                {
                    { new Guid("a6cf357e-205e-45f4-be76-25c8e08aac16"), new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 120000f, 22800f, 157800f, 15000f },
                    { new Guid("ceda0177-4b48-4379-8907-b75c4f0aa10f"), new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 85000f, 16150f, 113150f, 12000f }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Cantidad", "Estado", "IdCategoria", "Lugar", "Nombre", "Precio", "StockId" },
                values: new object[,]
                {
                    { new Guid("03a78db6-0e2e-4d18-9001-fbccb5cc2dca"), 1, "Activo", new Guid("b130f449-a5f3-4e3e-a165-d73c3b73a241"), "Estante 1", "Audifonos inalambricos", 250000f, new Guid("f46678ca-5e2e-4b36-8d56-5eb110770bbe") },
                    { new Guid("3bbe0bbe-0379-4d32-9fd9-d74a51d319a6"), 1, "Activo", new Guid("5af38236-256e-4ded-a81e-8010f08c51b6"), "Estante 3", "Mouse inalambrico", 50000f, new Guid("9fffc55a-186f-4d62-88b4-78b43b2948c1") },
                    { new Guid("6bd9dded-9a5f-412c-9575-2110dbd9b7c6"), 1, "Activo", new Guid("4f9a7cdb-c6dd-4c1c-8ca2-88f34c913c54"), "Estante 2", "Computador Samsung 2018", 2600000f, new Guid("e9208668-35d6-4862-b4f6-2b3fe8f6a525") }
                });

            migrationBuilder.InsertData(
                table: "DetallesFacturaCompras",
                columns: new[] { "DetalleFacturaCompraId", "Cantidad", "FacturaCompraId", "IVA", "ProductoId", "ValorDescuento", "ValorUnitario" },
                values: new object[,]
                {
                    { new Guid("69cc48c7-b5a1-487f-cb3b-08dbfb6a7af6"), 4, new Guid("6e922ba7-f823-4a3b-81ef-65a55a981c60"), 0.3f, new Guid("03a78db6-0e2e-4d18-9001-fbccb5cc2dca"), 0.05f, 500000f },
                    { new Guid("ccd4cc9b-87f5-4cf2-65b4-08dbfb6a7af1"), 2, new Guid("5c5b2abf-5de1-49cb-98b8-6c13fddc7a6e"), 0.3f, new Guid("03a78db6-0e2e-4d18-9001-fbccb5cc2dca"), 0.05f, 250000f }
                });

            migrationBuilder.InsertData(
                table: "DetallesFacturaVentas",
                columns: new[] { "DetalleFacturaVentaId", "Cantidad", "FacturaVentaId", "IVA", "ProductoId", "ValorDescuento", "ValorUnitario" },
                values: new object[,]
                {
                    { new Guid("3239a8db-ba0d-471e-cb3c-08dbfb6a7af6"), 2, new Guid("ceda0177-4b48-4379-8907-b75c4f0aa10f"), 8075f, new Guid("03a78db6-0e2e-4d18-9001-fbccb5cc2dca"), 0f, 42500f },
                    { new Guid("dd412a46-bf61-4853-6439-08dbfb6aabed"), 2, new Guid("a6cf357e-205e-45f4-be76-25c8e08aac16"), 1534f, new Guid("3bbe0bbe-0379-4d32-9fd9-d74a51d319a6"), 0f, 60000f }
                });

            migrationBuilder.InsertData(
                table: "HistoricosPrecios",
                columns: new[] { "IdHistoricoPrecios", "Estado", "FechaDescuento", "PrecioCompra", "PrecioDescuento", "PrecioVenta", "ProductoId" },
                values: new object[,]
                {
                    { new Guid("369ccaf1-e340-4ee9-b612-acc195dc856a"), "Inactivo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), 342f, 234f, 342f, new Guid("6bd9dded-9a5f-412c-9575-2110dbd9b7c6") },
                    { new Guid("8285b178-56af-4939-aada-e35f6e067db5"), "Inactivo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), 678f, 456f, 456f, new Guid("3bbe0bbe-0379-4d32-9fd9-d74a51d319a6") },
                    { new Guid("c20a3432-81eb-48c2-a25e-6574cd445cbb"), "Inactivo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), 34f, 45f, 45f, new Guid("03a78db6-0e2e-4d18-9001-fbccb5cc2dca") }
                });

            migrationBuilder.InsertData(
                table: "MetodoPagos",
                columns: new[] { "IdMetodoPago", "FacturaId", "FechaTransaccion", "Monto", "NombrePlataforma" },
                values: new object[,]
                {
                    { new Guid("5ef90d94-ca4a-49fe-ba78-e42e1c527606"), new Guid("ceda0177-4b48-4379-8907-b75c4f0aa10f"), new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25000, "Nequi" },
                    { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), new Guid("a6cf357e-205e-45f4-be76-25c8e08aac16"), new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25000, "Daviplata" }
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
                name: "IX_DetallesFacturaCompras_FacturaCompraId",
                table: "DetallesFacturaCompras",
                column: "FacturaCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesFacturaCompras_ProductoId",
                table: "DetallesFacturaCompras",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesFacturaVentas_FacturaVentaId",
                table: "DetallesFacturaVentas",
                column: "FacturaVentaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesFacturaVentas_ProductoId",
                table: "DetallesFacturaVentas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasCompras_ProveedoresIdProveedor",
                table: "FacturasCompras",
                column: "ProveedoresIdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasVentas_ClienteId",
                table: "FacturasVentas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosPrecios_ProductoId",
                table: "HistoricosPrecios",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_MetodoPagos_FacturaId",
                table: "MetodoPagos",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdCategoria",
                table: "Productos",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_StockId",
                table: "Productos",
                column: "StockId");
        }

        /// <inheritdoc />
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
                name: "DetallesFacturaCompras");

            migrationBuilder.DropTable(
                name: "DetallesFacturaVentas");

            migrationBuilder.DropTable(
                name: "HistoricosPrecios");

            migrationBuilder.DropTable(
                name: "MetodoPagos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "FacturasCompras");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "FacturasVentas");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
