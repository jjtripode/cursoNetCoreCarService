using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarServiceFronted.Migrations
{
    public partial class InitialStructureAndAllEntiies : Migration
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
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
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
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
                values: new object[] { new Guid("d93349db-f465-4aeb-ad0f-69743243b3ba"), "Seat", "Alhambra,Altea,Altea XL,Arosa,Cordoba,Cordoba Vario,Exeo,Ibiza,Ibiza ST,Exeo ST,Leon,Leon ST,Inca,Mii,Toledo" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("96799319-4367-4565-8f05-05edc8eb50de"), "Kia", "Avella,Besta,Carens,Carnival,Cee`d,Cee`d SW,Cerato,K 2500,Magentis,Opirus,Optima,Picanto,Pregio,Pride,Pro Cee`d,Rio,Rio Combi,Rio sedan,Sephia,Shuma,Sorento,Soul,Sportage,Venga" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("9687256d-bae6-40ed-9d55-507410fd5c26"), "Land Rover", "109,Defender,Discovery,Discovery Sport,Freelander,Range Rover,Range Rover Evoque,Range Rover Sport" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("d2f09392-c933-4454-b795-a7024845e003"), "Dodge", "Avenger,Caliber,Challenger,Charger,Grand Caravan,Journey,Magnum,Nitro,RAM,Stealth,Viper" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("15f74d16-c575-4c33-9c03-73e113628d8f"), "Chrysler", "300 C,300 C Touring,300 M,Crossfire,Grand Voyager,LHS,Neon,Pacifica,Plymouth,PT Cruiser,Sebring,Sebring Convertible,Stratus,Stratus Cabrio,Town & Country,Voyager" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("e5b8f6ec-d129-4b86-a762-ed95bcffcc2d"), "Ford", "Aerostar,B-Max,C-Max,Cortina,Cougar,Edge,Escort,Escort Cabrio,Escort kombi,Explorer,F-150,F-250,Fiesta,Focus,Focus C-Max,Focus CC,Focus kombi,Fusion,Galaxy,Grand C-Max,Ka,Kuga,Maverick,Mondeo,Mondeo Combi,Mustang,Orion,Puma,Ranger,S-Max,Sierra,Street Ka,Tourneo Connect,Tourneo Custom,Transit,Transit,Transit Bus,Transit Connect LWB,Transit Courier,Transit Custom,Transit kombi,Transit Tourneo,Transit Valnik,Transit Van,Transit Van 350,Windstar" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("8c574129-18cb-4ced-95a1-7708cfd12b14"), "Hummer", "H2,H3" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("f1e0929a-6d9f-4477-bbda-19cf5aab8392"), "Infiniti", "EX,FX,G,G Coupé,M,Q,QX" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("843a69ac-132b-4f18-a433-a887991b3131"), "Audi", "100,100 Avant,80,80 Avant,80 Cabrio,90,A1,A2,A3,A3 Cabriolet,A3 Limuzina,A3 Sportback,A4,A4 Allroad,A4 Avant,A4 Cabriolet,A5,A5 Cabriolet,A5 Sportback,A6,A6 Allroad,A6 Avant,A7,A8,A8 Long,Q3,Q5,Q7,R8,RS4 Cabriolet,RS4/RS4 Avant,RS5,RS6 Avant,RS7,S3/S3 Sportback,S4 Cabriolet,S4/S4 Avant,S5/S5 Cabriolet,S6/RS6,S7,S8,SQ5,TT Coupé,TT Roadster,TTS" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("0142e434-b41c-48dd-80c2-a0464f6c7596"), "Jaguar", "Daimler,F-Pace,F-Type,S-Type,Sovereign,X-Type,X-type Estate,XE,XF,XJ,XJ12,XJ6,XJ8,XJ8,XJR,XK,XK8 Convertible,XKR,XKR Convertible" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("e2428c2d-708e-4ce2-be11-023f20df3214"), "Nissan", "100 NX,200 SX,350 Z,350 Z Roadster,370 Z,Almera,Almera Tino,Cabstar E - T,Cabstar TL2 Valnik,e-NV200,GT-R,Insterstar,Juke,King Cab,Leaf,Maxima,Maxima QX,Micra,Murano,Navara,Note,NP300 Pickup,NV200,NV400,Pathfinder,Patrol,Patrol GR,Pickup,Pixo,Primastar,Primastar Combi,Primera,Primera Combi,Pulsar,Qashqai,Serena,Sunny,Terrano,Tiida,Trade,Vanette Cargo,X-Trail" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("7439c3fd-6fb6-420d-887d-eed77ec26ba7"), "Volvo", "240,340,360,460,850,850 kombi,C30,C70,C70 Cabrio,C70 Coupé,S40,S60,S70,S80,S90,V40,V50,V60,V70,V90,XC60,XC70,XC90" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("3b9bb5b6-8f87-44f9-b475-0541e5309db0"), "Daewoo", "Espero,Kalos,Lacetti,Lanos,Leganza,Lublin,Matiz,Nexia,Nubira,Nubira kombi,Racer,Tacuma,Tico" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("f19f5567-99e1-4d35-aa11-160be0b88170"), "Fiat", "1100,126,500,500L,500X,850,Barchetta,Brava,Cinquecento,Coupé,Croma,Doblo,Doblo Cargo,Doblo Cargo Combi,Ducato,Ducato Van,Ducato Kombi,Ducato Podvozok,Florino,Florino Combi,Freemont,Grande Punto,Idea,Linea,Marea,Marea Weekend,Multipla,Palio Weekend,Panda,Panda Van,Punto,Punto Cabriolet,Punto Evo,Punto Van,Qubo,Scudo,Scudo Van,Scudo Kombi,Sedici,Seicento,Stilo,Stilo Multiwagon,Strada,Talento,Tipo,Ulysse,Uno,X1/9" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("342aeb87-591a-4e45-8fb2-1b79c5b92275"), "MINI", "Cooper,Cooper Cabrio,Cooper Clubman,Cooper D,Cooper D Clubman,Cooper S,Cooper S Cabrio,Cooper S Clubman,Countryman,Mini One,One D" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("0dba7b26-25a7-423d-8fef-e43c435ff495"), "Rover", "200,214,218,25,400,414,416,620,75" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("49096e97-1898-4a6a-abe0-d13127ecaad7"), "Smart", "Cabrio,City-Coupé,Compact Pulse,Forfour,Fortwo cabrio,Fortwo coupé,Roadster" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("0e08bf69-874a-4c4d-b677-46ed3ef67fac"), "Jeep", "Cherokee,Commander,Compass,Grand Cherokee,Patriot,Renegade,Wrangler" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("f48c5fc9-7a50-4df1-bb51-ffdeaf3ecd9e"), "Saab", "9-3,9-3 Cabriolet,9-3 Coupé,9-3 SportCombi,9-5,9-5 SportCombi,900,900 C,900 C Turbo,9000" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("6e30e476-ec69-4c65-81e1-a51200149738"), "Hyundai", "Accent,Atos,Atos Prime,Coupé,Elantra,Galloper,Genesis,Getz,Grandeur,H 350,H1,H1 Bus,H1 Van,H200,i10,i20,i30,i30 CW,i40,i40 CW,ix20,ix35,ix55,Lantra,Matrix,Santa Fe,Sonata,Terracan,Trajet,Tucson,Veloster" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("8eae2789-7aa5-4eca-a76a-75b6c7041b4c"), "Suzuki", "Alto,Baleno,Baleno kombi,Grand Vitara,Grand Vitara XL-7,Ignis,Jimny,Kizashi,Liana,Samurai,Splash,Swift,SX4,SX4 Sedan,Vitara,Wagon R+" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("da4e8ad7-d47b-4a85-b607-7422db042cb4"), "Mercedes-Benz", "100 D,115,124,126,190,190 D,190 E,200 - 300,200 D,200 E,210 Van,210 kombi,310 Van,310 kombi,230 - 300 CE Coupé,260 - 560 SE,260 - 560 SEL,500 - 600 SEC Coupé,Trieda A,A,A L,AMG GT,Trieda B,Trieda C,C,C Sportcoupé,C T,Citan,CL,CL,CLA,CLC,CLK Cabrio,CLK Coupé,CLS,Trieda E,E,E Cabrio,E Coupé,E T,Trieda G,G Cabrio,GL,GLA,GLC,GLE,GLK,Trieda M,MB 100,Trieda R,Trieda S,S,S Coupé,SL,SLC,SLK,SLR,Sprinter" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("03e8209b-cbcf-4cbd-87f0-5b336f043b83"), "Peugeot", "1007,107,106,108,2008,205,205 Cabrio,206,206 CC,206 SW,207,207 CC,207 SW,306,307,307 CC,307 SW,308,308 CC,308 SW,309,4007,4008,405,406,407,407 SW,5008,508,508 SW,605,806,607,807,Bipper,RCZ" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("d7bf4f89-509c-4dd8-b620-21cccaaed676"), "Dacia", "Dokker,Duster,Lodgy,Logan,Logan MCV,Logan Van,Sandero,Solenza" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("fa679365-3ba0-4ae3-b824-f09fdb824dab"), "Citroën", "Berlingo,C-Crosser,C-Elissée,C-Zero,C1,C2,C3,C3 Picasso,C4,C4 Aircross,C4 Cactus,C4 Coupé,C4 Grand Picasso,C4 Sedan,C5,C5 Break,C5 Tourer,C6,C8,DS3,DS4,DS5,Evasion,Jumper,Jumpy,Saxo,Nemo,Xantia,Xsara" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("6bf3a769-8a6d-415c-92c7-1c1c9e62903b"), "Opel", "Agila,Ampera,Antara,Astra,Astra cabrio,Astra caravan,Astra coupé,Calibra,Campo,Cascada,Corsa,Frontera,Insignia,Insignia kombi,Kadett,Meriva,Mokka,Movano,Omega,Signum,Vectra,Vectra Caravan,Vivaro,Vivaro Kombi,Zafira" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("04548a7c-a79e-4ddf-aadf-0381e57e0973"), "Alfa Romeo", "145,146,147,155,156,156 Sportwagon,159,159 Sportwagon,164,166,4C,Brera,GTV,MiTo,Crosswagon,Spider,GT,Giulietta,Giulia" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("73ee0c1b-47f4-4dda-a8f0-0951395da972"), "Škoda", "Favorit,Felicia,Citigo,Fabia,Fabia Combi,Fabia Sedan,Felicia Combi,Octavia,Octavia Combi,Roomster,Yeti,Rapid,Rapid Spaceback,Superb,Superb Combi" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("b08da0a8-beb7-4f89-aae1-8c4039953f8d"), "Chevrolet", "Alero,Aveo,Camaro,Captiva,Corvette,Cruze,Cruze SW,Epica,Equinox,Evanda,HHR,Kalos,Lacetti,Lacetti SW,Lumina,Malibu,Matiz,Monte Carlo,Nubira,Orlando,Spark,Suburban,Tacuma,Tahoe,Trax" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("375fab64-9dff-4883-be38-75040868c8ff"), "Porsche", "911 Carrera,911 Carrera Cabrio,911 Targa,911 Turbo,924,944,997,Boxster,Cayenne,Cayman,Macan,Panamera" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("2f22ab5a-2bce-4e7f-8379-bd70ad11f23e"), "Renault", "Captur,Clio,Clio Grandtour,Espace,Express,Fluence,Grand Espace,Grand Modus,Grand Scenic,Kadjar,Kangoo,Kangoo Express,Koleos,Laguna,Laguna Grandtour,Latitude,Mascott,Mégane,Mégane CC,Mégane Combi,Mégane Grandtour,Mégane Coupé,Mégane Scénic,Scénic,Talisman,Talisman Grandtour,Thalia,Twingo,Wind,Zoé" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("dfe9668b-da19-4184-9ee2-1f574ae12591"), "Subaru", "BRZ,Forester,Impreza,Impreza Wagon,Justy,Legacy,Legacy Wagon,Legacy Outback,Levorg,Outback,SVX,Tribeca,Tribeca B9,XV" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("61fe02d2-66e9-406e-a447-b2b9609d8622"), "Mazda", "121,2,3,323,323 Combi,323 Coupé,323 F,5,6,6 Combi,626,626 Combi,B-Fighter,B2500,BT,CX-3,CX-5,CX-7,CX-9,Demio,MPV,MX-3,MX-5,MX-6,Premacy,RX-7,RX-8,Xedox 6" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("9f619342-3e4d-460a-8a34-58e98d4c3650"), "Mitsubishi", "3000 GT,ASX,Carisma,Colt,Colt CC,Eclipse,Fuso canter,Galant,Galant Combi,Grandis,L200,L200 Pick up,L200 Pick up Allrad,L300,Lancer,Lancer Combi,Lancer Evo,Lancer Sportback,Outlander,Pajero,Pajeto Pinin,Pajero Pinin Wagon,Pajero Sport,Pajero Wagon,Space Star" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("8f26e338-7ad5-4115-acb3-cee7aa7a6104"), "Lexus", "CT,GS,GS 300,GX,IS,IS 200,IS 250 C,IS-F,LS,LX,NX,RC F,RX,RX 300,RX 400h,RX 450h,SC 430" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("f3eed038-eed4-4b7e-8d60-3f8ed789a52a"), "Toyota", "4-Runner,Auris,Avensis,Avensis Combi,Avensis Van Verso,Aygo,Camry,Carina,Celica,Corolla,Corolla Combi,Corolla sedan,Corolla Verso,FJ Cruiser,GT86,Hiace,Hiace Van,Highlander,Hilux,Land Cruiser,MR2,Paseo,Picnic,Prius,RAV4,Sequoia,Starlet,Supra,Tundra,Urban Cruiser,Verso,Yaris,Yaris Verso" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("b224dbc9-f509-4bfb-9de9-35c6dfabf4ae"), "BMW", "i3,i8,M3,M4,M5,M6,Rad 1,Rad 1 Cabrio,Rad 1 Coupé,Rad 2,Rad 2 Active Tourer,Rad 2 Coupé,Rad 2 Gran Tourer,Rad 3,Rad 3 Cabrio,Rad 3 Compact,Rad 3 Coupé,Rad 3 GT,Rad 3 Touring,Rad 4,Rad 4 Cabrio,Rad 4 Gran Coupé,Rad 5,Rad 5 GT,Rad 5 Touring,Rad 6,Rad 6 Cabrio,Rad 6 Coupé,Rad 6 Gran Coupé,Rad 7,Rad 8 Coupé,X1,X3,X4,X5,X6,Z3,Z3 Coupé,Z3 Roadster,Z4,Z4 Roadster" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("3cd8604f-8ce7-4035-bedc-138a9c3d332b"), "Volkswagen", "Amarok,Beetle,Bora,Bora Variant,Caddy,Caddy Van,Life,California,Caravelle,CC,Crafter,Crafter Van,Crafter Kombi,CrossTouran,Eos,Fox,Golf,Golf Cabrio,Golf Plus,Golf Sportvan,Golf Variant,Jetta,LT,Lupo,Multivan,New Beetle,New Beetle Cabrio,Passat,Passat Alltrack,Passat CC,Passat Variant,Passat Variant Van,Phaeton,Polo,Polo Van,Polo Variant,Scirocco,Sharan,T4,T4 Caravelle,T4 Multivan,T5,T5 Caravelle,T5 Multivan,T5 Transporter Shuttle,Tiguan,Touareg,Touran" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("b3f5440e-6a31-4d9a-991e-7650c3b65ea4"), "Honda", "Accord,Accord Coupé,Accord Tourer,City,Civic,Civic Aerodeck,Civic Coupé,Civic Tourer,Civic Type R,CR-V,CR-X,CR-Z,FR-V,HR-V,Insight,Integra,Jazz,Legend,Prelude" });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("40810af7-2df5-4871-a8f4-e00ca5bdde6d"), 20000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("a1b51d2b-f0fc-41b9-af10-e04872f0cb47"), 50000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("8f1425d2-d268-454a-9532-c6a0912f84fc"), 15000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("91202046-fae1-4d05-9ef2-151d00a20a17"), 10000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("6ef1aaaa-c262-4682-892f-dc47d894b81c"), 5000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("08a63140-0b5b-45a9-bd36-32015e268cd4"), 1000m });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("2d829914-b9a3-40cd-a84d-2ad05ddecae5"), "Pendiente", 10 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("98755457-814b-4de8-a17c-cdd64996b09e"), "En Progreso", 20 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("4c7ca06d-6154-4e6e-b225-22f6c24d0c7d"), "Postergado", 30 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("53323cd5-8bd0-48f1-804b-fce7c84bba1a"), "Finalizado", 40 });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("e9edb2af-ba2c-4902-9186-2ec2d437a969"), "Cambio de Cubiertas " });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("d3f3e946-77bb-4191-9913-1a9433956c09"), "Cambio de Aceite " });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("3b67a232-0b4b-4c0b-9e00-e4ba2462919f"), "Mantenimiento 10000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("4ae04f08-ff50-4aa9-8d5e-0e30828edaaa"), "Cambio de Cambio Filtros " });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("bf1f8ce3-b090-44b7-904f-2f42a56dd8af"), "Mantenimiento 2000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("1534d5fc-6253-4b59-943e-67d88bdbfc4c"), "Mantenimiento 1000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("6c3ab4f5-4b5a-45ec-aafd-56ca0c59eb2f"), "Mantenimiento 5000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("cbd25572-2979-4f20-a8c3-c40d3ab4021d"), "Cambio de Cambio Correa Distribucion " });

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
