using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarServiceFronted.Migrations
{
    public partial class InitialStructureAndAllEntiies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new Guid("686a19a7-ccc5-4f4d-aa40-f257eb8bf970"), "Seat", "Alhambra,Altea,Altea XL,Arosa,Cordoba,Cordoba Vario,Exeo,Ibiza,Ibiza ST,Exeo ST,Leon,Leon ST,Inca,Mii,Toledo" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("6b5ed128-c620-4ad4-a503-7403466da379"), "Kia", "Avella,Besta,Carens,Carnival,Cee`d,Cee`d SW,Cerato,K 2500,Magentis,Opirus,Optima,Picanto,Pregio,Pride,Pro Cee`d,Rio,Rio Combi,Rio sedan,Sephia,Shuma,Sorento,Soul,Sportage,Venga" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("3d6c63f6-4bea-45c0-9a88-79d564805b95"), "Land Rover", "109,Defender,Discovery,Discovery Sport,Freelander,Range Rover,Range Rover Evoque,Range Rover Sport" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("059dcae8-bd05-4a40-8435-9fcc385e3dba"), "Dodge", "Avenger,Caliber,Challenger,Charger,Grand Caravan,Journey,Magnum,Nitro,RAM,Stealth,Viper" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("8870c6da-b188-4aa8-8ff2-5b1698754f1c"), "Chrysler", "300 C,300 C Touring,300 M,Crossfire,Grand Voyager,LHS,Neon,Pacifica,Plymouth,PT Cruiser,Sebring,Sebring Convertible,Stratus,Stratus Cabrio,Town & Country,Voyager" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("618bd0ed-a6fd-45de-8e6e-c6b000f6a0ea"), "Ford", "Aerostar,B-Max,C-Max,Cortina,Cougar,Edge,Escort,Escort Cabrio,Escort kombi,Explorer,F-150,F-250,Fiesta,Focus,Focus C-Max,Focus CC,Focus kombi,Fusion,Galaxy,Grand C-Max,Ka,Kuga,Maverick,Mondeo,Mondeo Combi,Mustang,Orion,Puma,Ranger,S-Max,Sierra,Street Ka,Tourneo Connect,Tourneo Custom,Transit,Transit,Transit Bus,Transit Connect LWB,Transit Courier,Transit Custom,Transit kombi,Transit Tourneo,Transit Valnik,Transit Van,Transit Van 350,Windstar" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("1b658981-76b0-4b8d-89be-6e4a51dd8537"), "Hummer", "H2,H3" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("b30200ee-79ab-42ec-9cb5-d7c6408cc8be"), "Infiniti", "EX,FX,G,G Coupé,M,Q,QX" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("36708c5d-17f5-480d-b77d-b53975db5262"), "Audi", "100,100 Avant,80,80 Avant,80 Cabrio,90,A1,A2,A3,A3 Cabriolet,A3 Limuzina,A3 Sportback,A4,A4 Allroad,A4 Avant,A4 Cabriolet,A5,A5 Cabriolet,A5 Sportback,A6,A6 Allroad,A6 Avant,A7,A8,A8 Long,Q3,Q5,Q7,R8,RS4 Cabriolet,RS4/RS4 Avant,RS5,RS6 Avant,RS7,S3/S3 Sportback,S4 Cabriolet,S4/S4 Avant,S5/S5 Cabriolet,S6/RS6,S7,S8,SQ5,TT Coupé,TT Roadster,TTS" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("57c50296-0f69-49e4-8981-add3356ef990"), "Jaguar", "Daimler,F-Pace,F-Type,S-Type,Sovereign,X-Type,X-type Estate,XE,XF,XJ,XJ12,XJ6,XJ8,XJ8,XJR,XK,XK8 Convertible,XKR,XKR Convertible" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("80257e5c-a75e-4e63-80fe-59983e2bdef7"), "Nissan", "100 NX,200 SX,350 Z,350 Z Roadster,370 Z,Almera,Almera Tino,Cabstar E - T,Cabstar TL2 Valnik,e-NV200,GT-R,Insterstar,Juke,King Cab,Leaf,Maxima,Maxima QX,Micra,Murano,Navara,Note,NP300 Pickup,NV200,NV400,Pathfinder,Patrol,Patrol GR,Pickup,Pixo,Primastar,Primastar Combi,Primera,Primera Combi,Pulsar,Qashqai,Serena,Sunny,Terrano,Tiida,Trade,Vanette Cargo,X-Trail" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("49b4730a-6296-4f64-9cdb-cdb257006ab9"), "Volvo", "240,340,360,460,850,850 kombi,C30,C70,C70 Cabrio,C70 Coupé,S40,S60,S70,S80,S90,V40,V50,V60,V70,V90,XC60,XC70,XC90" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("943eba02-e814-4270-b23c-d73d2d3d0c5e"), "Daewoo", "Espero,Kalos,Lacetti,Lanos,Leganza,Lublin,Matiz,Nexia,Nubira,Nubira kombi,Racer,Tacuma,Tico" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("162fbab6-3b6d-4016-9535-a697472c76de"), "Fiat", "1100,126,500,500L,500X,850,Barchetta,Brava,Cinquecento,Coupé,Croma,Doblo,Doblo Cargo,Doblo Cargo Combi,Ducato,Ducato Van,Ducato Kombi,Ducato Podvozok,Florino,Florino Combi,Freemont,Grande Punto,Idea,Linea,Marea,Marea Weekend,Multipla,Palio Weekend,Panda,Panda Van,Punto,Punto Cabriolet,Punto Evo,Punto Van,Qubo,Scudo,Scudo Van,Scudo Kombi,Sedici,Seicento,Stilo,Stilo Multiwagon,Strada,Talento,Tipo,Ulysse,Uno,X1/9" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("775a85ea-f1d1-45f8-b382-62b25cf7315e"), "MINI", "Cooper,Cooper Cabrio,Cooper Clubman,Cooper D,Cooper D Clubman,Cooper S,Cooper S Cabrio,Cooper S Clubman,Countryman,Mini One,One D" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("d30cfd1f-e276-4a03-ba7e-31e6d933a864"), "Rover", "200,214,218,25,400,414,416,620,75" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("ec60a5ff-d2d6-4509-bde2-34c6f140fa66"), "Smart", "Cabrio,City-Coupé,Compact Pulse,Forfour,Fortwo cabrio,Fortwo coupé,Roadster" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("e7c31ef5-272a-422b-9b41-246d4c971284"), "Jeep", "Cherokee,Commander,Compass,Grand Cherokee,Patriot,Renegade,Wrangler" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("6554818c-3b02-48c4-89f9-1652fd32dfba"), "Saab", "9-3,9-3 Cabriolet,9-3 Coupé,9-3 SportCombi,9-5,9-5 SportCombi,900,900 C,900 C Turbo,9000" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("be8504ba-09e9-4d4e-86fa-22f3dfd05127"), "Hyundai", "Accent,Atos,Atos Prime,Coupé,Elantra,Galloper,Genesis,Getz,Grandeur,H 350,H1,H1 Bus,H1 Van,H200,i10,i20,i30,i30 CW,i40,i40 CW,ix20,ix35,ix55,Lantra,Matrix,Santa Fe,Sonata,Terracan,Trajet,Tucson,Veloster" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("4dd2bbd3-f641-471d-99b3-343d669975ad"), "Suzuki", "Alto,Baleno,Baleno kombi,Grand Vitara,Grand Vitara XL-7,Ignis,Jimny,Kizashi,Liana,Samurai,Splash,Swift,SX4,SX4 Sedan,Vitara,Wagon R+" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("8dd40faf-bc24-4372-87b8-470598ccd116"), "Mercedes-Benz", "100 D,115,124,126,190,190 D,190 E,200 - 300,200 D,200 E,210 Van,210 kombi,310 Van,310 kombi,230 - 300 CE Coupé,260 - 560 SE,260 - 560 SEL,500 - 600 SEC Coupé,Trieda A,A,A L,AMG GT,Trieda B,Trieda C,C,C Sportcoupé,C T,Citan,CL,CL,CLA,CLC,CLK Cabrio,CLK Coupé,CLS,Trieda E,E,E Cabrio,E Coupé,E T,Trieda G,G Cabrio,GL,GLA,GLC,GLE,GLK,Trieda M,MB 100,Trieda R,Trieda S,S,S Coupé,SL,SLC,SLK,SLR,Sprinter" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("e39a5076-1767-4bbf-9070-9f4ad9348c37"), "Peugeot", "1007,107,106,108,2008,205,205 Cabrio,206,206 CC,206 SW,207,207 CC,207 SW,306,307,307 CC,307 SW,308,308 CC,308 SW,309,4007,4008,405,406,407,407 SW,5008,508,508 SW,605,806,607,807,Bipper,RCZ" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("21820118-69a6-44ad-94f8-5d7c8d23757f"), "Dacia", "Dokker,Duster,Lodgy,Logan,Logan MCV,Logan Van,Sandero,Solenza" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("a862ce8c-8ca7-427c-b9b0-08c93ad60102"), "Citroën", "Berlingo,C-Crosser,C-Elissée,C-Zero,C1,C2,C3,C3 Picasso,C4,C4 Aircross,C4 Cactus,C4 Coupé,C4 Grand Picasso,C4 Sedan,C5,C5 Break,C5 Tourer,C6,C8,DS3,DS4,DS5,Evasion,Jumper,Jumpy,Saxo,Nemo,Xantia,Xsara" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("1aad7734-5ed2-4437-8907-70d1263676f9"), "Opel", "Agila,Ampera,Antara,Astra,Astra cabrio,Astra caravan,Astra coupé,Calibra,Campo,Cascada,Corsa,Frontera,Insignia,Insignia kombi,Kadett,Meriva,Mokka,Movano,Omega,Signum,Vectra,Vectra Caravan,Vivaro,Vivaro Kombi,Zafira" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("6182817d-d984-40ea-ab00-618ec5946476"), "Alfa Romeo", "145,146,147,155,156,156 Sportwagon,159,159 Sportwagon,164,166,4C,Brera,GTV,MiTo,Crosswagon,Spider,GT,Giulietta,Giulia" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("a73961f2-99d1-4432-84dc-582435b9e233"), "Škoda", "Favorit,Felicia,Citigo,Fabia,Fabia Combi,Fabia Sedan,Felicia Combi,Octavia,Octavia Combi,Roomster,Yeti,Rapid,Rapid Spaceback,Superb,Superb Combi" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("ec44b9e3-35c8-4853-acb4-7128cd0db623"), "Chevrolet", "Alero,Aveo,Camaro,Captiva,Corvette,Cruze,Cruze SW,Epica,Equinox,Evanda,HHR,Kalos,Lacetti,Lacetti SW,Lumina,Malibu,Matiz,Monte Carlo,Nubira,Orlando,Spark,Suburban,Tacuma,Tahoe,Trax" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("4b61541e-eec2-420e-9768-6810e2a7e6fe"), "Porsche", "911 Carrera,911 Carrera Cabrio,911 Targa,911 Turbo,924,944,997,Boxster,Cayenne,Cayman,Macan,Panamera" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("d3a302a9-d769-4dc2-8403-92d22367c38f"), "Renault", "Captur,Clio,Clio Grandtour,Espace,Express,Fluence,Grand Espace,Grand Modus,Grand Scenic,Kadjar,Kangoo,Kangoo Express,Koleos,Laguna,Laguna Grandtour,Latitude,Mascott,Mégane,Mégane CC,Mégane Combi,Mégane Grandtour,Mégane Coupé,Mégane Scénic,Scénic,Talisman,Talisman Grandtour,Thalia,Twingo,Wind,Zoé" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("0b84c58c-7466-4bbf-8170-bd38bbde57f7"), "Subaru", "BRZ,Forester,Impreza,Impreza Wagon,Justy,Legacy,Legacy Wagon,Legacy Outback,Levorg,Outback,SVX,Tribeca,Tribeca B9,XV" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("aeb16c59-629d-4495-b4bc-19893ec21255"), "Mazda", "121,2,3,323,323 Combi,323 Coupé,323 F,5,6,6 Combi,626,626 Combi,B-Fighter,B2500,BT,CX-3,CX-5,CX-7,CX-9,Demio,MPV,MX-3,MX-5,MX-6,Premacy,RX-7,RX-8,Xedox 6" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("9765e724-b2c9-4e72-8615-ebfae8e83e6b"), "Mitsubishi", "3000 GT,ASX,Carisma,Colt,Colt CC,Eclipse,Fuso canter,Galant,Galant Combi,Grandis,L200,L200 Pick up,L200 Pick up Allrad,L300,Lancer,Lancer Combi,Lancer Evo,Lancer Sportback,Outlander,Pajero,Pajeto Pinin,Pajero Pinin Wagon,Pajero Sport,Pajero Wagon,Space Star" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("93403500-ffc2-4deb-a68e-d1e06d5f3736"), "Lexus", "CT,GS,GS 300,GX,IS,IS 200,IS 250 C,IS-F,LS,LX,NX,RC F,RX,RX 300,RX 400h,RX 450h,SC 430" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("2250d510-0125-418e-b67c-ee2d37ebaf20"), "Toyota", "4-Runner,Auris,Avensis,Avensis Combi,Avensis Van Verso,Aygo,Camry,Carina,Celica,Corolla,Corolla Combi,Corolla sedan,Corolla Verso,FJ Cruiser,GT86,Hiace,Hiace Van,Highlander,Hilux,Land Cruiser,MR2,Paseo,Picnic,Prius,RAV4,Sequoia,Starlet,Supra,Tundra,Urban Cruiser,Verso,Yaris,Yaris Verso" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("855f5863-d4cb-49d4-89ca-0e8f2a97adfd"), "BMW", "i3,i8,M3,M4,M5,M6,Rad 1,Rad 1 Cabrio,Rad 1 Coupé,Rad 2,Rad 2 Active Tourer,Rad 2 Coupé,Rad 2 Gran Tourer,Rad 3,Rad 3 Cabrio,Rad 3 Compact,Rad 3 Coupé,Rad 3 GT,Rad 3 Touring,Rad 4,Rad 4 Cabrio,Rad 4 Gran Coupé,Rad 5,Rad 5 GT,Rad 5 Touring,Rad 6,Rad 6 Cabrio,Rad 6 Coupé,Rad 6 Gran Coupé,Rad 7,Rad 8 Coupé,X1,X3,X4,X5,X6,Z3,Z3 Coupé,Z3 Roadster,Z4,Z4 Roadster" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("56253ad6-c870-4997-82ed-56a2518e9b65"), "Volkswagen", "Amarok,Beetle,Bora,Bora Variant,Caddy,Caddy Van,Life,California,Caravelle,CC,Crafter,Crafter Van,Crafter Kombi,CrossTouran,Eos,Fox,Golf,Golf Cabrio,Golf Plus,Golf Sportvan,Golf Variant,Jetta,LT,Lupo,Multivan,New Beetle,New Beetle Cabrio,Passat,Passat Alltrack,Passat CC,Passat Variant,Passat Variant Van,Phaeton,Polo,Polo Van,Polo Variant,Scirocco,Sharan,T4,T4 Caravelle,T4 Multivan,T5,T5 Caravelle,T5 Multivan,T5 Transporter Shuttle,Tiguan,Touareg,Touran" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("029a9671-4fe5-47e5-bcb3-17d0d28e9bd5"), "Honda", "Accord,Accord Coupé,Accord Tourer,City,Civic,Civic Aerodeck,Civic Coupé,Civic Tourer,Civic Type R,CR-V,CR-X,CR-Z,FR-V,HR-V,Insight,Integra,Jazz,Legend,Prelude" });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("54fadb82-de4f-4170-99fb-4d21d834f691"), 20000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("8ed295c4-857e-4e46-8296-9119f7518777"), 50000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("eb2602ac-56f4-4d8a-83f5-12fd8e97cd5a"), 15000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("a01ea438-922e-45f8-8fa5-ae699edd8416"), 10000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("78f85bd6-6b1f-4aea-9da4-9bee86384a44"), 5000m });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "ID", "Value" },
                values: new object[] { new Guid("a509f585-b801-49c9-be4d-ea47a00f1fdd"), 1000m });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("c350d48b-4f73-41ea-b17d-d9798fd24cb8"), "Pendiente", 10 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("604d4028-b650-4c13-88cb-4d8f3693bf65"), "En Progreso", 20 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("67d3451e-759f-4d07-a14b-895917cd8b01"), "Postergado", 30 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("700ab857-9f08-4e00-82f5-ac2134f77e67"), "Finalizado", 40 });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("354cd9d9-c35f-43d0-bd23-a76220331f69"), "Cambio de Cubiertas " });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("f0cabcc9-cd0d-411f-a996-1376c865699f"), "Cambio de Aceite " });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("b22b2445-7829-4a98-a9f3-bd19575503f3"), "Mantenimiento 10000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("ccd1bd1c-5429-404e-bf77-ac380edb6b6a"), "Cambio de Cambio Filtros " });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("f91c14d0-9d8a-4940-9ae7-d28d0023ca5d"), "Mantenimiento 2000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("7fa539d2-5e20-4410-88b6-6b4cac9c86b8"), "Mantenimiento 1000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("46d89f23-5998-44d1-bdc9-f9df234ff7fb"), "Mantenimiento 5000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("541bc5a9-3526-4b90-8b66-7250b3634883"), "Cambio de Cambio Correa Distribucion " });

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
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Services");

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
