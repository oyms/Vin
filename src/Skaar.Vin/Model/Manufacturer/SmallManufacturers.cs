namespace Skaar.VehicleData.Model.Manufacturer;

class SmallManufacturers
{
    public string? GetManufacturer(string wmi, string secondaryVmi)
    {
        if (wmi.Length < 3 || secondaryVmi.Length < 3) return null;
        return Lookup.GetValueOrDefault(wmi)?.GetValueOrDefault(secondaryVmi);
    }
    
    private Dictionary<string, Dictionary<string, string>> Lookup
    {
        get { return field ??= CreateDictionary(); }
    }

    private static Dictionary<string, Dictionary<string, string>> CreateDictionary()
    {
        return new()
        {
            ["AA9"] = new() { ["CN1"] = "TR-Tec Pty Ltd. (South Africa)" },
            ["AC9"] = new() { ["BM1"] = "Beamish Beach Buggies (South Africa)" },
            ["AE9"] = new() { ["MT1"] = "Backdraft Racing (South Africa)" },
            ["KF9"] = new() { ["004"] = "Tomcar (Israel)" },
            ["KG9"] = new()
            {
                ["002"] = "Charash Ashdod (truck trailer) (Israel)",
                ["004"] = "H. Klein (truck trailer) (Israel)",
                ["007"] = "Agam Trailers (truck trailer) (Israel)",
                ["009"] = "Merkavey Noa (trailer) (Israel)",
                ["010"] = "Weingold Trailers (trailer) (Israel)",
                ["011"] = "Netzer Sereni (truck trailer) (Israel)",
                ["015"] = "Merkaz Hagrorim (trailer) (Israel)",
                ["035"] = "BEL Technologies (truck trailer) (Israel)",
                ["091"] = "Jansteel (truck trailer) (Israel)",
                ["101"] = "Bassamco (truck trailer) (Israel)",
                ["104"] = "Global Handasa (truck trailer) (Israel)"
            },
            ["LA9"] = new()
            {
                ["AYS"] = "Jiangsu Alfa Bus Co., Ltd. (bus)",
                ["BFC"] = "Beijing North Huade Neoplan Bus Co., Ltd.",
                ["FBC"] = "Xiamen Fengtai Bus & Coach International Co., Ltd. (FTBCI) (bus)",
                ["HFF"] = "Anhui Huaxia Vehicle Manufacturing Co., Ltd. (bus)",
                ["JXK"] = "CHTC Bonluck Bus Co., Ltd.",
                ["LC0"] = "BYD",
                ["LFJ"] = "Xinlongma Automobile",
                ["LM6"] = "SRM Shineray"
            },
            ["LD9"] = new() { ["L3A"] = "SiTech (FAW)" },
            ["LZ9"] = new() { ["LZX"] = "Raysince" },
            ["MC9"] = new() { ["RE1"] = "Reva Electric Car Company (Reva G-Wiz)" },
            ["ND9"] = new() { ["345"] = "Oghab Afshan (bus)" },
            ["NP9"] = new()
            {
                ["002"] = "OKT Trailer (truck trailer)",
                ["003"] = "Aksoylu Trailer (truck trailer)",
                ["011"] = "Güleryüz (bus)",
                ["021"] = "Dogumak (truck trailer)",
                ["022"] = "Alim (truck trailer)",
                ["042"] = "Ali Rıza Usta (truck trailer)",
                ["066"] = "Makinsan (truck trailer)",
                ["093"] = "BRF Trailer (truck trailer)",
                ["103"] = "Türkkar (bus)",
                ["106"] = "Çarsan Treyler (truck trailer)",
                ["107"] = "Arbus Perfect (bus)",
                ["108"] = "Guven Makina (truck trailer)",
                ["117"] = "Katmerciler (truck trailer)",
                ["300"] = "TCV (bus)",
                ["258"] = "Ceytrayler (truck trailer)",
                ["306"] = "Cryocan (truck trailer)"
            },
            ["NR9"] = new()
            {
                ["012"] = "Doğan Yıldız (truck trailer)",
                ["028"] = "Micansan (truck trailer)",
                ["029"] = "Yilteks (truck trailer)",
                ["034"] = "Akia (bus)",
                ["084"] = "Harsan (truck trailer)",
                ["257"] = "Vega Trailer (truck trailer)"
            },
            ["RA9"] = new() { ["015"] = "Al-Assri Industries (Trailers), UAE" },
            ["R19"] = new() { ["003"] = "GMI (bus) (Hong Kong)" },
            ["SA9"] = new()
            {
                ["A11"] = "Morgan Roadster (V6) (USA)",
                ["J00"] = "Morgan Aero 8 (USA)",
                ["004"] = "Morgan (4-wheel passenger cars)",
                ["005"] = "Panther",
                ["010"] = "Invicta S1",
                ["011"] = "Midas Cars",
                ["019"] = "TVR",
                ["022"] = "Triking Sports Cars",
                ["026"] = "Fleur de Lys",
                ["038"] = "DAX Cars",
                ["039"] = "Westfield Sportscars",
                ["048"] = "McLaren F1",
                ["050"] = "Marcos Engineering",
                ["062"] = "AC Cars (Brooklands Ace)",
                ["068"] = "Johnston Sweepers",
                ["073"] = "Tomita Auto UK (Tommykaira ZZ)",
                ["074"] = "Ascari",
                ["088"] = "Spectre Angel",
                ["105"] = "Mosler Europe Ltd.",
                ["113"] = "Noble",
                ["130"] = "MG Sport and Racing",
                ["141"] = "Wrightbus",
                ["202"] = "Morgan 3-Wheeler, Super 3",
                ["207"] = "Radical Sportscars",
                ["211"] = "BAC (Briggs Automotive Company Ltd.)",
                ["225"] = "Paneltex (truck trailer)",
                ["231"] = "Peel Engineering",
                ["337"] = "Ariel",
                ["341"] = "Zenos",
                ["438"] = "Charge Cars",
                ["458"] = "Gordon Murray Automotive",
                ["474"] = "Mellor (bus)",
                ["612"] = "Tiger Racing (kit car)",
                ["621"] = "AC Cars (Ace)"
            },
            ["SU9"] = new()
            {
                ["AR1"] = "Emtech (truck trailer)",
                ["BU1"] = "BODEX (truck trailer)",
                ["DE2"] = "Demarco (truck trailer)",
                ["EB1"] = "Elbo (truck trailer)",
                ["EZ1"] = "Enerco (truck trailer)",
                ["NC5"] = "Zasta (truck trailer)",
                ["NJ1"] = "Janmil (truck trailer)",
                ["PL1"] = "Plandex (truck trailer)",
                ["PN1"] = "Solaris Bus & Coach (Poland) - until 2004",
                ["RE1"] = "Redos (truck trailer)",
                ["RE2"] = "Gromex (trailer)",
                ["TR1"] = "Plavec (truck trailer)",
                ["YV1"] = "Pilea bus/ARP E-Vehicles (Poland)",
                ["ZC1"] = "Wolf (truck trailer)"
            },
            ["SV9"] = new()
            {
                ["BC2"] = "BC-LDS (truck trailer)",
                ["DR1"] = "Dromech (truck trailer)",
                ["RN1"] = "Prod-Rent (truck trailer)"
            },
            ["SW9"] = new()
            {
                ["BA1"] = "Solbus",
                ["WG3"] = "Grew / Opalenica (trailer)"
            },
            ["SX9"] = new()
            {
                ["GR0"] = "GRAS (truck trailer)",
                ["KT1"] = "AMZ - Kutno (bus)",
                ["PN1"] = "Polkon (truck trailer)",
                ["SP1"] = "SOMMER Polska (truck trailer)"
            },
            ["SY9"] = new()
            {
                ["FR1"] = "Feber (truck trailer)",
                ["PF1"] = "KEMPF (truck trailer)"
            },
            ["SZ9"] = new()
            {
                ["AE6"] = "Gewe (trailer)",
                ["BG1"] = "GALA Syriusz (trailer)",
                ["PW1"] = "PRO-WAM (truck trailer)",
                ["TU1"] = "Ovibos (truck trailer)"
            },
            ["S19"] = new()
            {
                ["AM0"] = "AMO Plant (bus) (Latvia)",
                ["EF1"] = "Electrify (minibus) (Latvia)",
                ["MT0"] = "Mono-Transserviss (truck trailer) (Latvia)"
            },
            ["TH9"] = new() { ["512"] = "Hess AG (bus, trolleybus) (Switzerland)" },
            ["TK9"] = new()
            {
                ["AH3"] = "Atmos Chrást s.r.o. (Czech Republic)",
                ["AP3"] = "Agados, spol. s.r.o. (trailer) (Czech Republic)",
                ["HP1"] = "Hipocar (truck trailer) (Czech Republic)",
                ["PP7"] = "Paragan Trucks (truck trailer) (Czech Republic)",
                ["SL5"] = "SOR Libchavy buses (Czech Republic)",
                ["SS5"] = "SVAN Chrudim (truck trailer) (Czech Republic)"
            },
            ["TM9"] = new()
            {
                ["CA2"] = "Oasa bus (Oprava a stavba automobilů) (Czech Republic)",
                ["SE3"] = "Škoda Transportation trolleybuses (Czech Republic)",
                ["SE4"] = "Škoda Transportation trolleybuses (Czech Republic)",
                ["TE6"] = "TEDOM bus (Czech Republic)"
            },
            ["TN9"] = new()
            {
                ["EE7"] = "Ekova (bus) (Czech Republic)",
                ["VP5"] = "VPS (truck trailer)"
            },
            ["TS9"] = new()
            {
                ["111"] = "NABI Autóbuszipari (bus) (Hungary)",
                ["130"] = "Enterprise Bus (Hungary)",
                ["131"] = "MJT bus (Hungary)",
                ["156"] = "Ikarus / ARC (Auto Rad Controlle Kft.) bus (Hungary)",
                ["167"] = "Hungarian Bus Kft. (Hungary)",
                ["170"] = "Csaba Metál bus (Hungary)"
            },
            ["TT9"] = new()
            {
                ["117"] = "Ikarus Egyedi Autobusz Gyarto Kft. / Magyar Autóbuszgyártó Kft. / MABI (Hungary)",
                ["123"] = "Ikarus Global Zrt. (Hungary)"
            },
            ["TX9"] = new() { ["046"] = "Riotrailer (truck trailer) (Portugal)" },
            ["T49"] = new()
            {
                ["BG7"] = "FAP (Serbia)",
                ["BH8"] = "Megabus (bus) (Serbia)",
                ["BM2"] = "Feniksbus (minibus) (Serbia)",
                ["V16"] = "MAZ made by BIK (bus) (Serbia)"
            },
            ["UH9"] = new()
            {
                ["DA3"] = "DAB - Danish Automobile Building (acquired by Scania) (Denmark)",
                ["FK1"] = "Dapa Trailer (truck trailer) (Denmark)",
                ["HF1"] = "HFR Trailer A/S (truck trailer) (Denmark)",
                ["HM1"] = "HMK Bilcon A/S (truck trailer) (Denmark)",
                ["NS1"] = "Nopa (truck trailer) (Denmark)",
                ["NT1"] = "Nordic Trailer (truck trailer) (Denmark)",
                ["VM2"] = "VM Tarm a/s (truck trailer) (Denmark)"
            },
            ["UN9"] = new() { ["089"] = "Brian Noone Ltd. bus (Ireland)" },
            ["UV9"] = new() { ["AT1"] = "ATP Trucks, ATP Bus" },
            ["U59"] = new() { ["ASO"] = "ASKO (truck trailer)" },
            ["U69"] = new()
            {
                ["NL1"] = "Novoplan (bus) (Slovakia)",
                ["SB1"] = "SlovBus (bus)",
                ["TR8"] = "Troliga Bus (Slovakia)"
            },
            ["VA9"] = new()
            {
                ["GS0"] = "Gsodam Fahrzeugbau (truck trailer)",
                ["ZT0"] = "Berger Fahrzeugtechnik (truck trailer)"
            },
            ["VF9"] = new()
            {
                ["024"] = "Legras Industries (truck trailer)",
                ["049"] = "G. Magyar (truck trailer)",
                ["063"] = "Maisonneuve (truck trailer)",
                ["132"] = "Jean CHEREAU S.A.S. (truck trailer)",
                ["300"] = "EvoBus France",
                ["435"] = "Merceron (truck trailer)",
                ["519"] = "Hommell",
                ["607"] = "Mathieu (sweeper)",
                ["673"] = "Venturi Automobiles",
                ["795"] = "Bugatti Automobiles S.A.S.",
                ["848"] = "G. Magyar (truck trailer)",
                ["880"] = "Bolloré Bluebus",
                ["938"] = "SAFRA (bus)"
            },
            ["VG9"] = new()
            {
                ["019"] = "Naya (autonomous vehicle)",
                ["061"] = "Alstom-NTL Aptis (bus)"
            },
            ["VS9"] = new()
            {
                ["001"] = "Setra Seida (Spain)",
                ["011"] = "Advanced Design Tramontana",
                ["013"] = "Mirofret (truck trailer) (Spain)",
                ["016"] = "Irizar bus (Spain)",
                ["019"] = "Cobos Hermanos (truck trailer) (Spain)",
                ["031"] = "Carrocerias Ayats (Spain)",
                ["032"] = "Parcisa (truck trailer) (Spain)",
                ["044"] = "Beulas bus (Spain) (Spain)",
                ["047"] = "Indox (truck trailers) (Spain)",
                ["052"] = "Montull (truck trailer) (Spain)",
                ["057"] = "SOR Ibérica (truck trailers) (Spain)",
                ["072"] = "Mecanicas Silva (truck trailer) (Spain)",
                ["098"] = "Sunsundegui bus (Spain)",
                ["172"] = "EvoBus Iberica",
                ["917"] = "Nogebus (Spain)"
            },
            ["VV9"] = new()
            {
                ["010"] = "Castrosúa bus (Spain)",
                ["125"] = "Indetruck (truck trailers)",
                ["130"] = "Vectia Mobility bus (Spain)",
                ["130"] = "UNVI bus (Spain)",
                ["359"] = "Hispano-Suiza"
            },
            ["V39"] = new()
            {
                ["AB8"] = "Rimac Automobili (Croatia)",
                ["CB3"] = "Eurobus (Croatia)",
                ["WB4"] = "Rasco (machinery) (Croatia)"
            },
            ["W09"] = new()
            {
                ["A55"] = "Artega Automobile",
                ["A71"] = "Apollo",
                ["B09"] = "Bitter Cars",
                ["B16"] = "Brabus",
                ["B48"] = "Bultmann (trailer)",
                ["B91"] = "Boerner (truck trailer)",
                ["C09"] = "Carnehl Fahrzeugbau (truck trailer)",
                ["D04"] = "DOLL (truck trailer)",
                ["D05"] = "Drögmöller (bus)",
                ["D17"] = "Dinkel (truck trailer)",
                ["E04"] = "Eder (trailer)",
                ["E27"] = "Esterer (truck trailer)",
                ["E32"] = "ES-GE (truck trailer)",
                ["E45"] = "Eurotank (truck trailer)",
                ["F46"] = "FSN Fahrzeugbau (truck trailer)",
                ["F57"] = "Twike",
                ["G10"] = "GOFA (truck trailer)",
                ["G64"] = "Gumpert",
                ["H10"] = "Heitling Fahrzeugbau",
                ["H21"] = "Dietrich Hisle GmbH (truck trailer)",
                ["H46"] = "Hendricks (truck trailer)",
                ["H49"] = "H&W Nutzfahrzeugtechnik GmbH (truck trailer)",
                ["J02"] = "Isdera",
                ["K27"] = "Krupp",
                ["K27"] = "Kotschenreuther (truck trailer)",
                ["L05"] = "Liebherr",
                ["L06"] = "LMC Caravan (recreational vehicles)",
                ["M09"] = "Meierling (truck trailer)",
                ["M29"] = "MAFA (truck trailer)",
                ["M40"] = "Franz Mersch (trailer)",
                ["M79"] = "MKF Matallbau (truck trailer)",
                ["N22"] = "NFP-Eurotrailer (truck trailer)",
                ["P13"] = "Pagenkopf (truck trailer)",
                ["P72"] = "De Tomaso Automobili (Capricorn)",
                ["R06"] = "RUF",
                ["R14"] = "Rancke (truck trailer)",
                ["R27"] = "Gebr. Recker Fahrzeugbau (truck trailer)",
                ["R30"] = "Reisch (truck trailer)",
                ["R38"] = "Rewaco",
                ["SG0"] = "Sileo (bus)",
                ["SG1"] = "SEKA (truck trailer)",
                ["S24"] = "Sommer (truck trailer)",
                ["S25"] = "Spermann (truck trailer)",
                ["S27"] = "Schröder (truck trailer)",
                ["W11"] = "Wilken (truck trailer)",
                ["W14"] = "Weka (truck trailer)",
                ["W16"] = "Wellmeyer (truck trailer)",
                ["W20"] = "Kurt Willig GmbH & Co. KG (truck trailer)",
                ["W29"] = "Wiese (truck trailer)",
                ["W35"] = "Wecon GmbH (truck trailer)",
                ["W46"] = "WT-Metall (trailer)",
                ["W59"] = "Wiesmann",
                ["W70"] = "Wüllhorst (truck trailer)",
                ["W86"] = "Web Trailer GmbH (truck trailer)",
                ["004"] = "ORTEN Fahrzeugbau (truck trailer)"
            },
            ["XF9"] = new()
            {
                ["B24"] = "NK Trailers (truck trailer) (Greece)",
                ["D44"] = "Militsis (trailer) (Greece)",
                ["J03"] = "Christos Nezis (truck trailer) (Greece)",
                ["J63"] = "Kaoussis (truck trailer) (Greece)"
            },
            ["XG9"] = new()
            {
                ["B01"] = "Sfakianakis bus Greece",
                ["H33"] = "Rappas Trailer (Greece)",
                ["H51"] = "Eurotrailer Tourlakopoulos (trailer) (Greece)",
                ["H92"] = "Diamantis N. & Co. (trailer) (Greece)",
                ["B21"] = "Hellenic Vehicle Industry - ELVO bus Greece",
                ["H08"] = "Poseidonas Litsakis (trailer) (Greece)",
                ["H34"] = "Flexi-Wheels (trailer) (Greece)"
            },
            ["XJ9"] = new()
            {
                ["001"] = "ESVE BV (truck trailers)",
                ["002"] = "Jumbo Groenewegen (truck trailers)",
                ["003"] = "Autobusfabriek Bova BV",
                ["004"] = "G.S. Meppel (truck trailers)",
                ["007"] = "Broshuis BV (truck trailer)",
                ["010"] = "Ginaf Trucks",
                ["014"] = "Contar (truck trailer)",
                ["017"] = "Van Eck (truck trailer)",
                ["021"] = "Donkervoort Cars",
                ["033"] = "Wijer (trailer)",
                ["039"] = "Talson (truck trailer)",
                ["042"] = "Den Oudsten Bussen",
                ["052"] = "Witteveen (trailer)",
                ["055"] = "Fripaan (truck trailer)",
                ["067"] = "HTF (truck trailer)",
                ["068"] = "Vogelzang (truck trailer)",
                ["069"] = "Kraker (truck trailer)",
                ["070"] = "Veldhuizen (truck trailers)",
                ["073"] = "Zwalve (truck trailers)",
                ["074"] = "Draco (truck trailers)",
                ["081"] = "EBO van Weel (truck trailers)",
                ["084"] = "Vocol (truck trailers)",
                ["089"] = "Meijvo (trailers)",
                ["092"] = "Bulthuis (truck trailers)",
                ["103"] = "D-TEC (truck trailers)",
                ["109"] = "Groenewold Carrosseriefabriek B.V. (car transporter)",
                ["150"] = "Univan (truck trailer)",
                ["251"] = "Spierings Mobile Cranes",
                ["320"] = "VDL Bova bus",
                ["348"] = "HOKA (trailer)",
                ["355"] = "Berdex (truck trailer)",
                ["363"] = "Spyker",
                ["423"] = "Tijhof (trailer)",
                ["461"] = "BK Market Trailers (trailer)",
                ["495"] = "BE-Combi (truck trailer)",
                ["508"] = "Talson (truck trailer)",
                ["527"] = "GINAF",
                ["530"] = "Ebusco",
                ["611"] = "Zocon (trailer)",
            },
            ["X89"] = new()
            {
                ["AD4"] = "ВМЗ (VMZ) bus",
                ["BF8"] = "Rosvan bus",
                ["CU2"] = "EvoBus Russland (bus)",
                ["DJ2"] = "VMK (bus)",
                ["EY4"] = "Brabill (minibus)",
                ["FF6"] = "Lotos (bus)",
                ["FY1"] = "Sherp"
            },
            ["X99"] = new() { ["000"] = "Marussia" },
            ["YA9"] = new()
            {
                ["111"] = "OVA (truck trailer)",
                ["121"] = "Atcomex (truck trailer)",
                ["128"] = "EOS (bus)",
                ["139"] = "ATM Maaseik (truck trailer)",
                ["168"] = "Forthomme s.a. (truck trailer)",
                ["169"] = "Automobiles Gillet",
                ["180"] = "EOS (bus)",
                ["191"] = "Stokota (truck trailers)",
                ["195"] = "Denolf & Depla (minibus)"
            },
            ["YF9"] = new() { ["050"] = "JYKI (truck trailer) (Finland)" },
            ["YK9"] = new()
            {
                ["003"] = "Kabus (bus)",
                ["008"] = "Lahden Autokori (-2013), SOE Busproduction Finland (2014-2024) (bus)",
                ["016"] = "Linkker (bus)"
            },
            ["YS9"] = new() { ["KV1"] = "Backaryd (minibus)" },
            ["YT9"] = new()
            {
                ["007"] = "Koenigsegg",
                ["034"] = "Carvia"
            },
            ["YY9"] = new() { ["017"] = "Skala Fabrikk (truck trailer) (Norway)" },
            ["Y29"] = new() { ["005"] = "Buddy Electric (Norway)" },
            ["Y39"] = new()
            {
                ["047"] = "Altant-M (minibus) (Belarus)",
                ["051"] = "Bus-Master (minibus) (Belarus)",
                ["052"] = "Aktriya (minibus) (Belarus)",
                ["072"] = "Klassikbus (minibus) (Belarus)",
                ["074"] = "Alterra (minibus) (Belarus)",
                ["135"] = "EuroDjet (minibus) (Belarus)",
                ["240"] = "Alizana (minibus) (Belarus)",
                ["241"] = "RSBUS (minibus) (Belarus)",
                ["323"] = "KF-AVTO (minibus) (Belarus)"
            },
            ["Y69"] = new()
            {
                ["B19"] = "Stryi Avto (bus) (Ukraine)",
                ["B98"] = "VESTT (truck trailer) (Ukraine)",
                ["C49"] = "TAD (truck trailer) (Ukraine)",
                ["D75"] = "Barrel Dash (truck trailer) (Ukraine)"
            },
            ["Y79"] = new()
            {
                ["A23"] = "OdAZ (truck trailer) (Ukraine)",
                ["B21"] = "Everlast (truck trailer) (Ukraine)",
                ["B65"] = "Avtoban (trailer) (Ukraine)"
            },
            ["Y89"] = new()
            {
                ["A98"] = "VARZ (trailer) (Ukraine)",
                ["B75"] = "Knott (trailer) (Ukraine)",
                ["C65"] = "Electron (Ukraine)"
            },
            ["Y99"] = new()
            {
                ["B32"] = "Santey (trailer) (Ukraine)",
                ["E21"] = "Zmiev-Trans (truck trailer) (Ukraine)",
                ["C79"] = "Electron (bus) (Ukraine)"
            },
            ["ZA9"] = new()
            {
                ["A12"] = "Lamborghini through mid-2003 (including LM002)",
                ["A17"] = "Carrozzeria Luigi Dalla Via (bus)",
                ["A18"] = "De Simon (bus)",
                ["A33"] = "Bucher Schörling Italia (sweeper)",
                ["A47"] = "Silver Car (truck trailer)",
                ["B09"] = "Mauri Bus System",
                ["B34"] = "Mistrall Siloveicoli (truck trailer)",
                ["B45"] = "Bolgan (truck trailer)",
                ["B49"] = "OMSP Macola (truck trailer)",
                ["B95"] = "Carrozzeria Autodromo Modena (bus)",
                ["C38"] = "Dulevo (sweeper)",
                ["D38"] = "Cizeta Automobili SRL",
                ["D39"] = "Bugatti Automobili S.p.A",
                ["D50"] = "Italdesign Giugiaro",
                ["E15"] = "Tecnobus Industries S.r.l.",
                ["E73"] = "Sitcar (bus)",
                ["E88"] = "Cacciamali (bus)",
                ["F16"] = "OMT (truck trailer)",
                ["F21"] = "FGM (truck trailer)",
                ["F48"] = "Rampini Carlo S.p.A. (bus)",
                ["F76"] = "Pagani Automobili S.p.A.",
                ["G97"] = "EPT Horus (bus)",
                ["H02"] = "O.ME.P.S. (truck trailer)",
                ["H44"] = "Green-technik by Green Produzione s.r.l. (machine trailer)",
                ["J21"] = "VRV (truck trailer)",
                ["J93"] = "Barbi (bus)",
                ["K98"] = "Esagono Energia S.r.l.",
                ["M09"] = "Italdesign Automobili Speciali",
                ["M27"] = "Dallara Stradale",
                ["M91"] = "Automobili Pininfarina",
                ["180"] = "De Simon (bus)"
            },
            ["ZX9"] = new()
            {
                ["KU0"] = "K-Bus / Kutsenits (bus) (Slovenia)",
                ["DUR"] = "TAM bus (Slovenia)",
                ["TV0"] = "TAM (Tovarna Vozil Maribor) bus (Slovenia)"
            },
            ["ZY9"] = new() { ["002"] = "Gorica (truck trailer) (Slovenia)" },
            ["Z29"] = new()
            {
                ["555"] = "Vozila FLuid (truck trailer) (Slovenia)",
                ["008"] = "Autogalantas (truck trailer) (Lithuania)",
                ["009"] = "Patikima Linija / Rimo (truck trailer) (Lithuania)",
            },
            ["1A9"] = new()
            {
                ["007"] = "Advance Mixer Inc.",
                ["111"] = "Amerisport Inc. (federalized late model DeTomaso Pantera)",
                ["398"] = "Ameritech (federalized McLaren F1 & Bugatti EB110)",
                ["569"] = "American Custom Golf Cars Inc. (AGC)"
            },
            ["1B9"] = new()
            {
                ["133"] = "Buell Motorcycle Company through mid-1995",
                ["274"] = "Brooks Brothers Trailers",
                ["275"] = "Boydstun Metal Works (truck trailer)",
                ["285"] = "Boss Hoss Cycles",
                ["374"] = "Big Dog Custom Motorcycles",
                ["975"] = "Motus Motorcycles"
            },
            ["1C9"] = new()
            {
                ["257"] = "CEI Equipment Company (truck trailer)",
                ["291"] = "CX Automotive",
                ["496"] = "Carlinville Truck Equipment (truck trailer)",
                ["535"] = "Chance Coach (bus)",
                ["772"] = "Cozad (truck trailer)",
                ["971"] = "Cool Amphibious Manufacturers International"
            },
            ["1D9"] = new()
            {
                ["008"] = "KME Fire Apparatus",
                ["791"] = "Dennis Eagle, Inc."
            },
            ["1E9"] = new()
            {
                ["007"] = "E.D. Etnyre & Co. (truck trailer)",
                ["190"] = "Electric Transit Inc. (trolleybus)",
                ["363"] = "E-SUV LLC (E-Ride Industries)",
                ["456"] = "Electric Motorsport (GPR-S electric motorcycle)",
                ["526"] = "Epic TORQ",
                ["581"] = "Vetter Razor"
            },
            ["1F9"] = new()
            {
                ["037"] = "Federal Motors Inc.",
                ["140"] = "Ferrara Fire Apparatus (incomplete vehicle)",
                ["458"] = "Faraday Future prototypes",
                ["FT1"] = "FWD Corp.",
                ["ST1"] = "Seagrave Fire Apparatus",
                ["ST2"] = "Seagrave Fire Apparatus",
            },
            ["1G9"] = new() { ["495"] = "Google & Waymo" },
            ["1H9"] = new() { ["674"] = "Hines Specialty Vehicle Group" },
            ["1K9"] = new() { ["058"] = "Kovatech Mobile Equipment (fire engine)" },
            ["1L9"] = new()
            {
                ["155"] = "LA Exotics",
                ["234"] = "Laforza"
            },
            ["1M9"] = new()
            {
                ["089"] = "Mauck Special Vehicles",
                ["682"] = "Mosler Automotive",
                ["816"] = "Proterra Through mid-2019"
            },
            ["1N9"] = new()
            {
                ["019"] = "Neoplan USA",
                ["084"] = "Eldorado National (California)",
                ["140"] = "North American Bus Industries",
                ["393"] = "Nikola Corporation"
            },
            ["1P9"] = new()
            {
                ["038"] = "Hawk Vehicles, Inc. (Trihawk motorcycles)",
                ["213"] = "Panoz",
                ["255"] = "Pinson Truck Equipment Company (truck trailer)"
            },
            ["1R9"] = new() { ["956"] = "Reede Fabrication and Design (motorcycles)" },
            ["1S9"] = new()
            {
                ["003"] = "Sutphen Corporation (fire engines - truck)",
                ["098"] = "Scania AB (Scania CN112 bus made in Orange, CT)",
                ["842"] = "Saleen S7",
                ["901"] = "Suckerpunch Sallys, LLC",
                ["944"] = "SSC North America"
            },
            ["1T9"] = new()
            {
                ["717"] = "Thunder Mountain Custom Cycles",
                ["825"] = "TICO Manufacturing Company (truck)",
                ["899"] = "Tomcar USA",
                ["970"] = "Three Two Chopper",
            },
            ["1V9"] = new()
            {
                ["048"] = "Vector Aeromotive",
                ["113"] = "Vantage Vehicle International Inc (low-speed vehicle)",
                ["190"] = "Vanderhall Motor Works"
            },
            ["1W9"] = new()
            {
                ["010"] = "Weld-It Company (truck trailer)",
                ["485"] = "Wheego Electric Cars",
            },
            ["1Z9"] = new() { ["170"] = "Orange County Choppers" },
            ["289"] = new() { ["001"] = "BWS Manufacturing (truck trailer)" },
            ["2C9"] = new()
            {
                ["145"] = "Campagna Motors",
                ["197"] = "Canadian Electric Vehicles"
            },
            ["2E9"] = new() { ["080"] = "Electra Meccanica Vehicles Corp. (Solo)" },
            ["2M9"] = new()
            {
                ["044"] = "Westward Industries",
                ["058"] = "Motor Coach Industries",
            },
            ["2P9"] = new() { ["001"] = "Prevost 1981–1995" },
            ["2T9"] = new() { ["206"] = "Triple E Canada Ltd." },
            ["2W9"] = new() { ["044"] = "Westward Industries" },
            ["3A9"] = new() { ["050"] = "MARGO (truck trailer)" },
            ["4B9"] = new() { ["038"] = "BYD Coach & Bus LLC" },
            ["4C9"] = new()
            {
                ["272"] = "Christini Technologies (motorcycle)",
                ["561"] = "Czinger",
                ["626"] = "Canoo Inc."
            },
            ["4S9"] = new()
            {
                ["197"] = "Smith Electric Vehicles",
                ["345"] = "Satellite Suites (trailer)",
                ["419"] = "Spartan Motors truck",
                ["454"] = "Scuderia Cameron Glickenhaus passenger car",
                ["520"] = "Signature Autosport, LLC (Osprey Custom Cars)",
                ["542"] = "Scuderia Cameron Glickenhaus SCG Boot (M.P.V.)",
                ["544"] = "Scuderia Cameron Glickenhaus passenger car",
                ["559"] = "Spartan Fire, LLC truck (formerly Spartan ER)",
                ["560"] = "Spartan Fire, LLC incomplete vehicle (formerly Spartan ER)",
                ["569"] = "SC Autosports, LLC (Kandi)"
            },
            ["4T9"] = new()
            {
                ["208"] = "Xos, Inc.",
                ["228"] = "Lumen Motors",
            }
        };
    }
}
