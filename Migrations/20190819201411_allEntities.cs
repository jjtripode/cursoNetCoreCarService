using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarServiceFronted.Migrations
{
    public partial class allEntities : Migration
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
                    Date = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    ServiceTypeID = table.Column<Guid>(nullable: true),
                    VehicleID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Services_ServicesType_ServiceTypeID",
                        column: x => x.ServiceTypeID,
                        principalTable: "ServicesType",
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
                values: new object[] { new Guid("22a54968-4b94-4c1d-b619-a200089ed420"), "Seat", "Alhambra,Altea,Altea XL,Arosa,Cordoba,Cordoba Vario,Exeo,Ibiza,Ibiza ST,Exeo ST,Leon,Leon ST,Inca,Mii,Toledo" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("bca90dd4-eb78-4d7d-9cf2-bb2e6bbf2fe5"), "Kia", "Avella,Besta,Carens,Carnival,Cee`d,Cee`d SW,Cerato,K 2500,Magentis,Opirus,Optima,Picanto,Pregio,Pride,Pro Cee`d,Rio,Rio Combi,Rio sedan,Sephia,Shuma,Sorento,Soul,Sportage,Venga" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("43d12622-64f3-4e4b-85a2-ca59254cc044"), "Land Rover", "109,Defender,Discovery,Discovery Sport,Freelander,Range Rover,Range Rover Evoque,Range Rover Sport" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("7ce4e5ac-ec03-4c7e-bf73-8f0a0e54dac8"), "Dodge", "Avenger,Caliber,Challenger,Charger,Grand Caravan,Journey,Magnum,Nitro,RAM,Stealth,Viper" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("14d34d6d-09da-4597-a1c7-80bd95db99d0"), "Ford", "Aerostar,B-Max,C-Max,Cortina,Cougar,Edge,Escort,Escort Cabrio,Escort kombi,Explorer,F-150,F-250,Fiesta,Focus,Focus C-Max,Focus CC,Focus kombi,Fusion,Galaxy,Grand C-Max,Ka,Kuga,Maverick,Mondeo,Mondeo Combi,Mustang,Orion,Puma,Ranger,S-Max,Sierra,Street Ka,Tourneo Connect,Tourneo Custom,Transit,Transit,Transit Bus,Transit Connect LWB,Transit Courier,Transit Custom,Transit kombi,Transit Tourneo,Transit Valnik,Transit Van,Transit Van 350,Windstar" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("c8bfbee0-c20b-4c4e-a803-63773b8bad86"), "Hummer", "H2,H3" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("9231ae74-247f-4ae8-88ab-cf54e2e74644"), "Hyundai", "Accent,Atos,Atos Prime,Coupé,Elantra,Galloper,Genesis,Getz,Grandeur,H 350,H1,H1 Bus,H1 Van,H200,i10,i20,i30,i30 CW,i40,i40 CW,ix20,ix35,ix55,Lantra,Matrix,Santa Fe,Sonata,Terracan,Trajet,Tucson,Veloster" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("d9811187-3784-4966-ba32-c8f008a3a98e"), "Infiniti", "EX,FX,G,G Coupé,M,Q,QX" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("ce2a41cb-ab93-47f7-8464-5a337eeca317"), "Audi", "100,100 Avant,80,80 Avant,80 Cabrio,90,A1,A2,A3,A3 Cabriolet,A3 Limuzina,A3 Sportback,A4,A4 Allroad,A4 Avant,A4 Cabriolet,A5,A5 Cabriolet,A5 Sportback,A6,A6 Allroad,A6 Avant,A7,A8,A8 Long,Q3,Q5,Q7,R8,RS4 Cabriolet,RS4/RS4 Avant,RS5,RS6 Avant,RS7,S3/S3 Sportback,S4 Cabriolet,S4/S4 Avant,S5/S5 Cabriolet,S6/RS6,S7,S8,SQ5,TT Coupé,TT Roadster,TTS" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("60e91220-0fcb-4785-9df5-90b2764a44c5"), "Jaguar", "Daimler,F-Pace,F-Type,S-Type,Sovereign,X-Type,X-type Estate,XE,XF,XJ,XJ12,XJ6,XJ8,XJ8,XJR,XK,XK8 Convertible,XKR,XKR Convertible" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("ec66b281-0335-466c-9af0-e79bdd00bfbf"), "Nissan", "100 NX,200 SX,350 Z,350 Z Roadster,370 Z,Almera,Almera Tino,Cabstar E - T,Cabstar TL2 Valnik,e-NV200,GT-R,Insterstar,Juke,King Cab,Leaf,Maxima,Maxima QX,Micra,Murano,Navara,Note,NP300 Pickup,NV200,NV400,Pathfinder,Patrol,Patrol GR,Pickup,Pixo,Primastar,Primastar Combi,Primera,Primera Combi,Pulsar,Qashqai,Serena,Sunny,Terrano,Tiida,Trade,Vanette Cargo,X-Trail" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("66a9ec18-d234-4efa-9f11-33047264331b"), "Volvo", "240,340,360,460,850,850 kombi,C30,C70,C70 Cabrio,C70 Coupé,S40,S60,S70,S80,S90,V40,V50,V60,V70,V90,XC60,XC70,XC90" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("c38fd76e-75b5-4bcb-9e60-fca682ffc755"), "Daewoo", "Espero,Kalos,Lacetti,Lanos,Leganza,Lublin,Matiz,Nexia,Nubira,Nubira kombi,Racer,Tacuma,Tico" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("5e3aac3c-4871-4e7a-b45f-b33bbb763b1e"), "Fiat", "1100,126,500,500L,500X,850,Barchetta,Brava,Cinquecento,Coupé,Croma,Doblo,Doblo Cargo,Doblo Cargo Combi,Ducato,Ducato Van,Ducato Kombi,Ducato Podvozok,Florino,Florino Combi,Freemont,Grande Punto,Idea,Linea,Marea,Marea Weekend,Multipla,Palio Weekend,Panda,Panda Van,Punto,Punto Cabriolet,Punto Evo,Punto Van,Qubo,Scudo,Scudo Van,Scudo Kombi,Sedici,Seicento,Stilo,Stilo Multiwagon,Strada,Talento,Tipo,Ulysse,Uno,X1/9" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("c9fec9e8-adbc-4374-aa2a-d5f8950047d8"), "MINI", "Cooper,Cooper Cabrio,Cooper Clubman,Cooper D,Cooper D Clubman,Cooper S,Cooper S Cabrio,Cooper S Clubman,Countryman,Mini One,One D" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("2dd0ea9c-3960-4462-9218-3777e9a5972e"), "Rover", "200,214,218,25,400,414,416,620,75" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("699841c9-3e88-441f-bcc8-f90a7e943a81"), "Smart", "Cabrio,City-Coupé,Compact Pulse,Forfour,Fortwo cabrio,Fortwo coupé,Roadster" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("0b3b8689-3860-466a-931f-5fc5f8cfe1ff"), "Jeep", "Cherokee,Commander,Compass,Grand Cherokee,Patriot,Renegade,Wrangler" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("ba24f26b-027b-44fd-bd5c-20887f796a7a"), "Saab", "9-3,9-3 Cabriolet,9-3 Coupé,9-3 SportCombi,9-5,9-5 SportCombi,900,900 C,900 C Turbo,9000" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("bf60bf26-0084-48ed-a9ac-17dbe36d6896"), "Chrysler", "300 C,300 C Touring,300 M,Crossfire,Grand Voyager,LHS,Neon,Pacifica,Plymouth,PT Cruiser,Sebring,Sebring Convertible,Stratus,Stratus Cabrio,Town & Country,Voyager" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("6db14124-9dc6-4dcb-8d6d-04bba20a644e"), "Suzuki", "Alto,Baleno,Baleno kombi,Grand Vitara,Grand Vitara XL-7,Ignis,Jimny,Kizashi,Liana,Samurai,Splash,Swift,SX4,SX4 Sedan,Vitara,Wagon R+" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("3cba2ef5-4a37-477b-80ea-cc86b86ce9f8"), "Renault", "Captur,Clio,Clio Grandtour,Espace,Express,Fluence,Grand Espace,Grand Modus,Grand Scenic,Kadjar,Kangoo,Kangoo Express,Koleos,Laguna,Laguna Grandtour,Latitude,Mascott,Mégane,Mégane CC,Mégane Combi,Mégane Grandtour,Mégane Coupé,Mégane Scénic,Scénic,Talisman,Talisman Grandtour,Thalia,Twingo,Wind,Zoé" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("3b7fec11-43cc-44c5-b117-616c04d0f294"), "Peugeot", "1007,107,106,108,2008,205,205 Cabrio,206,206 CC,206 SW,207,207 CC,207 SW,306,307,307 CC,307 SW,308,308 CC,308 SW,309,4007,4008,405,406,407,407 SW,5008,508,508 SW,605,806,607,807,Bipper,RCZ" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("54d94ceb-6044-4cb3-925f-353f96471094"), "Dacia", "Dokker,Duster,Lodgy,Logan,Logan MCV,Logan Van,Sandero,Solenza" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("2ed70af6-c5df-4db2-af94-2d54dc088fda"), "Mercedes-Benz", "100 D,115,124,126,190,190 D,190 E,200 - 300,200 D,200 E,210 Van,210 kombi,310 Van,310 kombi,230 - 300 CE Coupé,260 - 560 SE,260 - 560 SEL,500 - 600 SEC Coupé,Trieda A,A,A L,AMG GT,Trieda B,Trieda C,C,C Sportcoupé,C T,Citan,CL,CL,CLA,CLC,CLK Cabrio,CLK Coupé,CLS,Trieda E,E,E Cabrio,E Coupé,E T,Trieda G,G Cabrio,GL,GLA,GLC,GLE,GLK,Trieda M,MB 100,Trieda R,Trieda S,S,S Coupé,SL,SLC,SLK,SLR,Sprinter" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("5604e5ed-1506-49b1-b874-b27046067784"), "Opel", "Agila,Ampera,Antara,Astra,Astra cabrio,Astra caravan,Astra coupé,Calibra,Campo,Cascada,Corsa,Frontera,Insignia,Insignia kombi,Kadett,Meriva,Mokka,Movano,Omega,Signum,Vectra,Vectra Caravan,Vivaro,Vivaro Kombi,Zafira" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("49bd496b-ab62-4f32-b74e-43f2af20732c"), "Alfa Romeo", "145,146,147,155,156,156 Sportwagon,159,159 Sportwagon,164,166,4C,Brera,GTV,MiTo,Crosswagon,Spider,GT,Giulietta,Giulia" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("daa97edf-9a39-4292-942b-bc50b3619a02"), "Škoda", "Favorit,Felicia,Citigo,Fabia,Fabia Combi,Fabia Sedan,Felicia Combi,Octavia,Octavia Combi,Roomster,Yeti,Rapid,Rapid Spaceback,Superb,Superb Combi" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("1a926081-70b2-4659-aeca-8e482ae30c15"), "Chevrolet", "Alero,Aveo,Camaro,Captiva,Corvette,Cruze,Cruze SW,Epica,Equinox,Evanda,HHR,Kalos,Lacetti,Lacetti SW,Lumina,Malibu,Matiz,Monte Carlo,Nubira,Orlando,Spark,Suburban,Tacuma,Tahoe,Trax" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("2b1fe2b3-7c29-4fc0-9dcb-8fd7f8f9b9ae"), "Porsche", "911 Carrera,911 Carrera Cabrio,911 Targa,911 Turbo,924,944,997,Boxster,Cayenne,Cayman,Macan,Panamera" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("fc619198-d7e2-4ce4-8f85-0320a0e0810e"), "Citroën", "Berlingo,C-Crosser,C-Elissée,C-Zero,C1,C2,C3,C3 Picasso,C4,C4 Aircross,C4 Cactus,C4 Coupé,C4 Grand Picasso,C4 Sedan,C5,C5 Break,C5 Tourer,C6,C8,DS3,DS4,DS5,Evasion,Jumper,Jumpy,Saxo,Nemo,Xantia,Xsara" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("4cc2bedb-5645-414d-ad7a-dbb3b22703ff"), "Subaru", "BRZ,Forester,Impreza,Impreza Wagon,Justy,Legacy,Legacy Wagon,Legacy Outback,Levorg,Outback,SVX,Tribeca,Tribeca B9,XV" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("96bab860-18b0-4a5f-94aa-b91fe5ef2304"), "Mazda", "121,2,3,323,323 Combi,323 Coupé,323 F,5,6,6 Combi,626,626 Combi,B-Fighter,B2500,BT,CX-3,CX-5,CX-7,CX-9,Demio,MPV,MX-3,MX-5,MX-6,Premacy,RX-7,RX-8,Xedox 6" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("f462704b-fbcb-4e87-90a2-d0a1165d0018"), "Mitsubishi", "3000 GT,ASX,Carisma,Colt,Colt CC,Eclipse,Fuso canter,Galant,Galant Combi,Grandis,L200,L200 Pick up,L200 Pick up Allrad,L300,Lancer,Lancer Combi,Lancer Evo,Lancer Sportback,Outlander,Pajero,Pajeto Pinin,Pajero Pinin Wagon,Pajero Sport,Pajero Wagon,Space Star" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("c74ef8f3-afc6-4b34-9dc8-5df6f0880f6c"), "Lexus", "CT,GS,GS 300,GX,IS,IS 200,IS 250 C,IS-F,LS,LX,NX,RC F,RX,RX 300,RX 400h,RX 450h,SC 430" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("0bca854e-9413-4287-85ed-5b0622846df2"), "Toyota", "4-Runner,Auris,Avensis,Avensis Combi,Avensis Van Verso,Aygo,Camry,Carina,Celica,Corolla,Corolla Combi,Corolla sedan,Corolla Verso,FJ Cruiser,GT86,Hiace,Hiace Van,Highlander,Hilux,Land Cruiser,MR2,Paseo,Picnic,Prius,RAV4,Sequoia,Starlet,Supra,Tundra,Urban Cruiser,Verso,Yaris,Yaris Verso" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("d6146e69-c709-447a-b153-e864406ca219"), "BMW", "i3,i8,M3,M4,M5,M6,Rad 1,Rad 1 Cabrio,Rad 1 Coupé,Rad 2,Rad 2 Active Tourer,Rad 2 Coupé,Rad 2 Gran Tourer,Rad 3,Rad 3 Cabrio,Rad 3 Compact,Rad 3 Coupé,Rad 3 GT,Rad 3 Touring,Rad 4,Rad 4 Cabrio,Rad 4 Gran Coupé,Rad 5,Rad 5 GT,Rad 5 Touring,Rad 6,Rad 6 Cabrio,Rad 6 Coupé,Rad 6 Gran Coupé,Rad 7,Rad 8 Coupé,X1,X3,X4,X5,X6,Z3,Z3 Coupé,Z3 Roadster,Z4,Z4 Roadster" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("4a80cc92-0600-485f-a2dc-5d51eec82eed"), "Volkswagen", "Amarok,Beetle,Bora,Bora Variant,Caddy,Caddy Van,Life,California,Caravelle,CC,Crafter,Crafter Van,Crafter Kombi,CrossTouran,Eos,Fox,Golf,Golf Cabrio,Golf Plus,Golf Sportvan,Golf Variant,Jetta,LT,Lupo,Multivan,New Beetle,New Beetle Cabrio,Passat,Passat Alltrack,Passat CC,Passat Variant,Passat Variant Van,Phaeton,Polo,Polo Van,Polo Variant,Scirocco,Sharan,T4,T4 Caravelle,T4 Multivan,T5,T5 Caravelle,T5 Multivan,T5 Transporter Shuttle,Tiguan,Touareg,Touran" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Descripcion", "models" },
                values: new object[] { new Guid("554d98dc-9097-48d5-bb50-341d0ef9a774"), "Honda", "Accord,Accord Coupé,Accord Tourer,City,Civic,Civic Aerodeck,Civic Coupé,Civic Tourer,Civic Type R,CR-V,CR-X,CR-Z,FR-V,HR-V,Insight,Integra,Jazz,Legend,Prelude" });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("76e0605c-da0d-4ada-9665-9d62c5bddaea"), "Ended     ", 40 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("f02239ca-5fd4-49b4-bb74-d5d17fbb9652"), "Delayed   ", 30 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("68c6bea0-41e6-43c1-aa59-2e61369deb5a"), "InProgress", 20 });

            migrationBuilder.InsertData(
                table: "ServiceStatus",
                columns: new[] { "ID", "Descripcion", "IdStatus" },
                values: new object[] { new Guid("5eed8291-e6dd-4e6d-aed1-3ae05dc24f09"), "Pending   ", 10 });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("dfcb4919-14aa-4a6c-91b9-a02778000329"), "Cambio de Cambio Filtros " });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("38551fb8-e4c0-4701-8da2-0bc2ff157a11"), "Mantenimiento 1000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("1beb2531-208f-4c7b-b729-76615afd7ef9"), "Mantenimiento 2000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("5b76c998-6ba4-4523-94a2-0803d9a37e78"), "Mantenimiento 5000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("2f4b8fed-e1f3-4f76-96dc-e36738497a38"), "Mantenimiento 10000Km" });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("557c5e32-6cad-4c7f-a21a-848e63f35d4d"), "Cambio de Aceite " });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("15bf59b6-fea0-4d95-b7bd-468ea4585507"), "Cambio de Cubiertas " });

            migrationBuilder.InsertData(
                table: "ServicesType",
                columns: new[] { "ID", "Descripcion" },
                values: new object[] { new Guid("a35a0e17-8527-4e3a-9c77-7a0ab51a3c74"), "Cambio de Cambio Correa Distribucion " });

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceTypeID",
                table: "Services",
                column: "ServiceTypeID");

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
                name: "ServiceStatus");

            migrationBuilder.DropTable(
                name: "ServicesType");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
