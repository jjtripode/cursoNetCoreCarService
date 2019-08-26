using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarServiceFronted.Migrations
{
    public partial class AllEntities : Migration
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
                name: "Brands",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    models = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceStatus",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdStatus = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServicesType",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CarLicensePlate = table.Column<string>(nullable: true),
                    ManufacturingDate = table.Column<DateTime>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTimeOffset>(nullable: false),
                    PriceID = table.Column<Guid>(nullable: true),
                    StatusID = table.Column<Guid>(nullable: true),
                    ServiceTypeID = table.Column<Guid>(nullable: true),
                    VehicleID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Services_Prices_PriceID",
                        column: x => x.PriceID,
                        principalTable: "Prices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Services_ServicesType_ServiceTypeID",
                        column: x => x.ServiceTypeID,
                        principalTable: "ServicesType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Services_ServiceStatus_StatusID",
                        column: x => x.StatusID,
                        principalTable: "ServiceStatus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Services_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("319ee258-7a3e-4dd2-a05e-9024fd9d403a"), "Seat", "Alhambra,Altea,Altea XL,Arosa,Cordoba,Cordoba Vario,Exeo,Ibiza,Ibiza ST,Exeo ST,Leon,Leon ST,Inca,Mii,Toledo" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("19ee7809-588e-4dcf-aa00-f410b3b60ae0"), "Kia", "Avella,Besta,Carens,Carnival,Cee`d,Cee`d SW,Cerato,K 2500,Magentis,Opirus,Optima,Picanto,Pregio,Pride,Pro Cee`d,Rio,Rio Combi,Rio sedan,Sephia,Shuma,Sorento,Soul,Sportage,Venga" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("f5ea4de7-b927-418f-9a64-65817b5e6964"), "Land Rover", "109,Defender,Discovery,Discovery Sport,Freelander,Range Rover,Range Rover Evoque,Range Rover Sport" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("8138f3cf-34ae-4d9d-a0e2-573f099f4d26"), "Dodge", "Avenger,Caliber,Challenger,Charger,Grand Caravan,Journey,Magnum,Nitro,RAM,Stealth,Viper" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("26f3776d-7717-49b8-ac65-688b148c0cca"), "Chrysler", "300 C,300 C Touring,300 M,Crossfire,Grand Voyager,LHS,Neon,Pacifica,Plymouth,PT Cruiser,Sebring,Sebring Convertible,Stratus,Stratus Cabrio,Town & Country,Voyager" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("bae721ca-c4ae-4d73-b603-0322b9b5329a"), "Ford", "Aerostar,B-Max,C-Max,Cortina,Cougar,Edge,Escort,Escort Cabrio,Escort kombi,Explorer,F-150,F-250,Fiesta,Focus,Focus C-Max,Focus CC,Focus kombi,Fusion,Galaxy,Grand C-Max,Ka,Kuga,Maverick,Mondeo,Mondeo Combi,Mustang,Orion,Puma,Ranger,S-Max,Sierra,Street Ka,Tourneo Connect,Tourneo Custom,Transit,Transit,Transit Bus,Transit Connect LWB,Transit Courier,Transit Custom,Transit kombi,Transit Tourneo,Transit Valnik,Transit Van,Transit Van 350,Windstar" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("c04edb94-c469-4f01-aa57-13f0d1b71d4d"), "Hummer", "H2,H3" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("09345f77-811c-4dbd-ba1e-95bb34fd2308"), "Infiniti", "EX,FX,G,G Coupé,M,Q,QX" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("8dde29e8-b4ca-4a7a-8b16-c78c88448d8a"), "Audi", "100,100 Avant,80,80 Avant,80 Cabrio,90,A1,A2,A3,A3 Cabriolet,A3 Limuzina,A3 Sportback,A4,A4 Allroad,A4 Avant,A4 Cabriolet,A5,A5 Cabriolet,A5 Sportback,A6,A6 Allroad,A6 Avant,A7,A8,A8 Long,Q3,Q5,Q7,R8,RS4 Cabriolet,RS4/RS4 Avant,RS5,RS6 Avant,RS7,S3/S3 Sportback,S4 Cabriolet,S4/S4 Avant,S5/S5 Cabriolet,S6/RS6,S7,S8,SQ5,TT Coupé,TT Roadster,TTS" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("2d81dc2b-98a4-4e20-adbb-e627655398eb"), "Jaguar", "Daimler,F-Pace,F-Type,S-Type,Sovereign,X-Type,X-type Estate,XE,XF,XJ,XJ12,XJ6,XJ8,XJ8,XJR,XK,XK8 Convertible,XKR,XKR Convertible" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("5eff4314-c26b-4448-8aef-d4077da341a1"), "Nissan", "100 NX,200 SX,350 Z,350 Z Roadster,370 Z,Almera,Almera Tino,Cabstar E - T,Cabstar TL2 Valnik,e-NV200,GT-R,Insterstar,Juke,King Cab,Leaf,Maxima,Maxima QX,Micra,Murano,Navara,Note,NP300 Pickup,NV200,NV400,Pathfinder,Patrol,Patrol GR,Pickup,Pixo,Primastar,Primastar Combi,Primera,Primera Combi,Pulsar,Qashqai,Serena,Sunny,Terrano,Tiida,Trade,Vanette Cargo,X-Trail" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("2f384200-cb6f-4ed8-813f-6e44ae928ac6"), "Volvo", "240,340,360,460,850,850 kombi,C30,C70,C70 Cabrio,C70 Coupé,S40,S60,S70,S80,S90,V40,V50,V60,V70,V90,XC60,XC70,XC90" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("471b9bd1-ce73-4f1f-aa44-c3add2ecabd9"), "Daewoo", "Espero,Kalos,Lacetti,Lanos,Leganza,Lublin,Matiz,Nexia,Nubira,Nubira kombi,Racer,Tacuma,Tico" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("be2b5238-a988-4f49-ad2d-d7f296afdccb"), "Fiat", "1100,126,500,500L,500X,850,Barchetta,Brava,Cinquecento,Coupé,Croma,Doblo,Doblo Cargo,Doblo Cargo Combi,Ducato,Ducato Van,Ducato Kombi,Ducato Podvozok,Florino,Florino Combi,Freemont,Grande Punto,Idea,Linea,Marea,Marea Weekend,Multipla,Palio Weekend,Panda,Panda Van,Punto,Punto Cabriolet,Punto Evo,Punto Van,Qubo,Scudo,Scudo Van,Scudo Kombi,Sedici,Seicento,Stilo,Stilo Multiwagon,Strada,Talento,Tipo,Ulysse,Uno,X1/9" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("794331a6-f2f7-47fe-8a7a-bafa1c142398"), "MINI", "Cooper,Cooper Cabrio,Cooper Clubman,Cooper D,Cooper D Clubman,Cooper S,Cooper S Cabrio,Cooper S Clubman,Countryman,Mini One,One D" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("48a0fad2-928d-4b98-8a2b-75f609664a64"), "Rover", "200,214,218,25,400,414,416,620,75" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("c932e5ea-0512-4c77-a2d7-9e0a3a20cfb5"), "Smart", "Cabrio,City-Coupé,Compact Pulse,Forfour,Fortwo cabrio,Fortwo coupé,Roadster" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("73b6e78e-7a25-4561-9aa4-728c4e37cbc5"), "Jeep", "Cherokee,Commander,Compass,Grand Cherokee,Patriot,Renegade,Wrangler" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("078076cf-e908-4d87-871c-e351064f117f"), "Saab", "9-3,9-3 Cabriolet,9-3 Coupé,9-3 SportCombi,9-5,9-5 SportCombi,900,900 C,900 C Turbo,9000" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("73440643-4c02-4cd2-b70f-7893dcab418f"), "Hyundai", "Accent,Atos,Atos Prime,Coupé,Elantra,Galloper,Genesis,Getz,Grandeur,H 350,H1,H1 Bus,H1 Van,H200,i10,i20,i30,i30 CW,i40,i40 CW,ix20,ix35,ix55,Lantra,Matrix,Santa Fe,Sonata,Terracan,Trajet,Tucson,Veloster" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("32061f7e-c025-4238-ac70-da88ea806741"), "Suzuki", "Alto,Baleno,Baleno kombi,Grand Vitara,Grand Vitara XL-7,Ignis,Jimny,Kizashi,Liana,Samurai,Splash,Swift,SX4,SX4 Sedan,Vitara,Wagon R+" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("e3465a8c-c2d8-4491-ace3-be84569c9a5c"), "Mercedes-Benz", "100 D,115,124,126,190,190 D,190 E,200 - 300,200 D,200 E,210 Van,210 kombi,310 Van,310 kombi,230 - 300 CE Coupé,260 - 560 SE,260 - 560 SEL,500 - 600 SEC Coupé,Trieda A,A,A L,AMG GT,Trieda B,Trieda C,C,C Sportcoupé,C T,Citan,CL,CL,CLA,CLC,CLK Cabrio,CLK Coupé,CLS,Trieda E,E,E Cabrio,E Coupé,E T,Trieda G,G Cabrio,GL,GLA,GLC,GLE,GLK,Trieda M,MB 100,Trieda R,Trieda S,S,S Coupé,SL,SLC,SLK,SLR,Sprinter" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("1ac9008f-169d-4196-989c-024bdb9ac970"), "Peugeot", "1007,107,106,108,2008,205,205 Cabrio,206,206 CC,206 SW,207,207 CC,207 SW,306,307,307 CC,307 SW,308,308 CC,308 SW,309,4007,4008,405,406,407,407 SW,5008,508,508 SW,605,806,607,807,Bipper,RCZ" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("642f122f-5ca1-4262-a48b-3d3e339e33a0"), "Dacia", "Dokker,Duster,Lodgy,Logan,Logan MCV,Logan Van,Sandero,Solenza" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("a0d35535-0a6a-4a0f-89cd-92cb67b63f97"), "Citroën", "Berlingo,C-Crosser,C-Elissée,C-Zero,C1,C2,C3,C3 Picasso,C4,C4 Aircross,C4 Cactus,C4 Coupé,C4 Grand Picasso,C4 Sedan,C5,C5 Break,C5 Tourer,C6,C8,DS3,DS4,DS5,Evasion,Jumper,Jumpy,Saxo,Nemo,Xantia,Xsara" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("6a43d5cc-83ec-4af1-b0c5-7b804fadd62b"), "Opel", "Agila,Ampera,Antara,Astra,Astra cabrio,Astra caravan,Astra coupé,Calibra,Campo,Cascada,Corsa,Frontera,Insignia,Insignia kombi,Kadett,Meriva,Mokka,Movano,Omega,Signum,Vectra,Vectra Caravan,Vivaro,Vivaro Kombi,Zafira" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("620c401a-0a23-4f07-af3b-d81923ddd02b"), "Alfa Romeo", "145,146,147,155,156,156 Sportwagon,159,159 Sportwagon,164,166,4C,Brera,GTV,MiTo,Crosswagon,Spider,GT,Giulietta,Giulia" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("9eea8153-f8ef-4c90-b611-51bfc88235a3"), "Škoda", "Favorit,Felicia,Citigo,Fabia,Fabia Combi,Fabia Sedan,Felicia Combi,Octavia,Octavia Combi,Roomster,Yeti,Rapid,Rapid Spaceback,Superb,Superb Combi" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("dc2a14e7-ef12-4e79-9de9-8369661e8a01"), "Chevrolet", "Alero,Aveo,Camaro,Captiva,Corvette,Cruze,Cruze SW,Epica,Equinox,Evanda,HHR,Kalos,Lacetti,Lacetti SW,Lumina,Malibu,Matiz,Monte Carlo,Nubira,Orlando,Spark,Suburban,Tacuma,Tahoe,Trax" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("c808c625-5aac-4be0-93d9-3dfc1f308367"), "Porsche", "911 Carrera,911 Carrera Cabrio,911 Targa,911 Turbo,924,944,997,Boxster,Cayenne,Cayman,Macan,Panamera" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("7950920a-ece5-4782-95de-88abfac060fb"), "Renault", "Captur,Clio,Clio Grandtour,Espace,Express,Fluence,Grand Espace,Grand Modus,Grand Scenic,Kadjar,Kangoo,Kangoo Express,Koleos,Laguna,Laguna Grandtour,Latitude,Mascott,Mégane,Mégane CC,Mégane Combi,Mégane Grandtour,Mégane Coupé,Mégane Scénic,Scénic,Talisman,Talisman Grandtour,Thalia,Twingo,Wind,Zoé" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("603bdb11-a3c0-4c68-8ae9-e0f050233868"), "Subaru", "BRZ,Forester,Impreza,Impreza Wagon,Justy,Legacy,Legacy Wagon,Legacy Outback,Levorg,Outback,SVX,Tribeca,Tribeca B9,XV" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("10b2907f-c276-4cf5-bb6b-a88766b6f5e3"), "Mazda", "121,2,3,323,323 Combi,323 Coupé,323 F,5,6,6 Combi,626,626 Combi,B-Fighter,B2500,BT,CX-3,CX-5,CX-7,CX-9,Demio,MPV,MX-3,MX-5,MX-6,Premacy,RX-7,RX-8,Xedox 6" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("130f9d0e-7e84-4d95-9f82-bf61d5e15ad5"), "Mitsubishi", "3000 GT,ASX,Carisma,Colt,Colt CC,Eclipse,Fuso canter,Galant,Galant Combi,Grandis,L200,L200 Pick up,L200 Pick up Allrad,L300,Lancer,Lancer Combi,Lancer Evo,Lancer Sportback,Outlander,Pajero,Pajeto Pinin,Pajero Pinin Wagon,Pajero Sport,Pajero Wagon,Space Star" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("2941f44b-aba4-42e5-b006-18ade6aef999"), "Lexus", "CT,GS,GS 300,GX,IS,IS 200,IS 250 C,IS-F,LS,LX,NX,RC F,RX,RX 300,RX 400h,RX 450h,SC 430" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("0e700f3f-20fd-4a7e-aaf3-afa3b26122e7"), "Toyota", "4-Runner,Auris,Avensis,Avensis Combi,Avensis Van Verso,Aygo,Camry,Carina,Celica,Corolla,Corolla Combi,Corolla sedan,Corolla Verso,FJ Cruiser,GT86,Hiace,Hiace Van,Highlander,Hilux,Land Cruiser,MR2,Paseo,Picnic,Prius,RAV4,Sequoia,Starlet,Supra,Tundra,Urban Cruiser,Verso,Yaris,Yaris Verso" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("b013bf8f-142d-463e-8dbf-80ef99031f66"), "BMW", "i3,i8,M3,M4,M5,M6,Rad 1,Rad 1 Cabrio,Rad 1 Coupé,Rad 2,Rad 2 Active Tourer,Rad 2 Coupé,Rad 2 Gran Tourer,Rad 3,Rad 3 Cabrio,Rad 3 Compact,Rad 3 Coupé,Rad 3 GT,Rad 3 Touring,Rad 4,Rad 4 Cabrio,Rad 4 Gran Coupé,Rad 5,Rad 5 GT,Rad 5 Touring,Rad 6,Rad 6 Cabrio,Rad 6 Coupé,Rad 6 Gran Coupé,Rad 7,Rad 8 Coupé,X1,X3,X4,X5,X6,Z3,Z3 Coupé,Z3 Roadster,Z4,Z4 Roadster" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("fb35cbbb-4f0a-4e09-9a79-2249b0ff6805"), "Volkswagen", "Amarok,Beetle,Bora,Bora Variant,Caddy,Caddy Van,Life,California,Caravelle,CC,Crafter,Crafter Van,Crafter Kombi,CrossTouran,Eos,Fox,Golf,Golf Cabrio,Golf Plus,Golf Sportvan,Golf Variant,Jetta,LT,Lupo,Multivan,New Beetle,New Beetle Cabrio,Passat,Passat Alltrack,Passat CC,Passat Variant,Passat Variant Van,Phaeton,Polo,Polo Van,Polo Variant,Scirocco,Sharan,T4,T4 Caravelle,T4 Multivan,T5,T5 Caravelle,T5 Multivan,T5 Transporter Shuttle,Tiguan,Touareg,Touran" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("d4902ca8-d503-44e6-80eb-53c2e7c92ecd"), "Honda", "Accord,Accord Coupé,Accord Tourer,City,Civic,Civic Aerodeck,Civic Coupé,Civic Tourer,Civic Type R,CR-V,CR-X,CR-Z,FR-V,HR-V,Insight,Integra,Jazz,Legend,Prelude" });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("03a0d2c2-5bb1-4c23-820d-c58dff69fc9d"), 20000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("837d958b-b96d-409e-aa41-8bc9161977df"), 50000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("e796235e-3083-4f6e-91d2-782f8ddd8a3b"), 15000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("cdfce9cc-6f53-4ec9-861b-8440e338181d"), 10000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("dbc6142f-a72f-484f-b8ee-8c0922b121b9"), 5000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("5775af9d-e17d-48b4-932a-f03f9f7d3e0d"), 1000m });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("d18e493c-5ceb-4274-9d4d-69352d7cb9c3"), "Pendiente", 10 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("bb745a56-bdc6-4ad9-9a4f-c4c432730992"), "En Progreso", 20 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("ae9baf59-1532-416f-84e8-1ca23c1fe4dd"), "Postergado", 30 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("1821ffac-1591-42c8-bf7a-8f20c28d23bd"), "Finalizado", 40 });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("5b0f29c1-44bf-463d-8376-8c6b87ad2fe4"), "Cambio de Cubiertas " });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("6bd08c08-6a5e-4b01-81a7-d9c74eda08bd"), "Cambio de Aceite " });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("22fad374-434b-4e0c-95f3-95f3abfb1cf6"), "Mantenimiento 10000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("65d8bb2c-d0b0-4524-8545-75eb7210a84c"), "Cambio de Cambio Filtros " });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("302d9498-de4d-4566-9b11-390fd93a9375"), "Mantenimiento 2000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("d154caf2-bddf-4e14-9c77-de5589ccd52d"), "Mantenimiento 1000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("b2718b65-eefb-40f3-9237-485ecd50dada"), "Mantenimiento 5000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("8c829998-541c-40fa-aa71-ace614d1f547"), "Cambio de Cambio Correa Distribucion " });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_PriceID",
                table: "Services",
                column: "PriceID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceTypeID",
                table: "Services",
                column: "ServiceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_StatusID",
                table: "Services",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_VehicleID",
                table: "Services",
                column: "VehicleID");
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
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "ServicesType");

            migrationBuilder.DropTable(
                name: "ServiceStatus");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
