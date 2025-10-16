/*
### ### ### ### ### ### ###
SourceItFresh - Copyright (C) 2020
This SiF file is licensed under v3 of the GNU Affero General Public License.
### ### ###
GNU AGPLv3 lets people do almost anything they want with the project, except distributing closed-source versions.

Permissions of this strongest copyleft license are conditioned on:
Making available the complete source code of works and modifications,
 which include larger works using a licensed work, under the same license.
Copyright and license notices must be preserved.
Contributors provide an express grant of patent rights.
When a modified version is used to provide a service over a network,
 the complete source code of the modified version must be made available.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY,
 without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
### ### ###
See LICENSE.txt for more details or visit <https://www.gnu.org/licenses/>
### ### ### ### ### ### ###
*/

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIF_AppData_Context.Migrations
{
    public partial class Initializedbodbdatawithconfigseeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "CropLifeCycleStage",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "9,090909091 : 32,72727273", "Seed", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "18,18181818 : 65,45454545", "Germination / Sprout", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "27,27272727 : 98,18181818", "Seedling", "ABC00777-0330-5005-0123-000000000001" },
                    { 4, "36,36363636 : 130,9090909", "Vegetative / Growing", "ABC00777-0330-5005-0123-000000000001" },
                    { 5, "45,45454545 : 163,6363636", "Budding", "ABC00777-0330-5005-0123-000000000001" },
                    { 6, "54,54545455 : 196,3636364", "Pollination", "ABC00777-0330-5005-0123-000000000001" },
                    { 7, "63,63636364 : 229,0909091", "Flowering / Fruit", "ABC00777-0330-5005-0123-000000000001" },
                    { 8, "72,72727273 : 261,8181818", "Ripening", "ABC00777-0330-5005-0123-000000000001" },
                    { 9, "81,81818182 : 294,5454545", "Harvest / Reproduction", "ABC00777-0330-5005-0123-000000000001" },
                    { 10, "90,90909091 : 327,2727273", "Cloning", "ABC00777-0330-5005-0123-000000000001" },
                    { 11, "100,0000000 : 360,0000000", "Spreading Seeds / Dying", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "CurrencyISO4217",
                columns: new[] { "id", "code", "currencyName", "postDecimalDigits", "usedLocations" },
                values: new object[,]
                {
                    { 8, "ALL", "Albanian lek", 2, " Albania" },
                    { 12, "DZD", "Algerian dinar", 2, " Algeria" },
                    { 32, "ARS", "Argentine peso", 2, " Argentina" },
                    { 36, "AUD", "Australian dollar", 2, " Australia,  Christmas Island (CX),  Cocos (Keeling) Islands (CC),  Heard Island and McDonald Islands (HM),  Kiribati (KI),  Nauru (NR),  Norfolk Island (NF),  Tuvalu (TV)" },
                    { 44, "BSD", "Bahamian dollar", 2, " Bahamas" },
                    { 48, "BHD", "Bahraini dinar", 3, " Bahrain" },
                    { 50, "BDT", "Bangladeshi taka", 2, " Bangladesh" },
                    { 51, "AMD", "Armenian dram", 2, " Armenia" },
                    { 52, "BBD", "Barbados dollar", 2, " Barbados" },
                    { 60, "BMD", "Bermudian dollar", 2, " Bermuda" },
                    { 64, "BTN", "Bhutanese ngultrum", 2, " Bhutan" },
                    { 68, "BOB", "Boliviano", 2, " Bolivia" },
                    { 72, "BWP", "Botswana pula", 2, " Botswana" },
                    { 84, "BZD", "Belize dollar", 2, " Belize" },
                    { 90, "SBD", "Solomon Islands dollar", 2, " Solomon Islands" },
                    { 96, "BND", "Brunei dollar", 2, " Brunei" },
                    { 104, "MMK", "Myanmar kyat", 2, " Myanmar" },
                    { 108, "BIF", "Burundian franc", 0, " Burundi" },
                    { 116, "KHR", "Cambodian riel", 2, " Cambodia" },
                    { 124, "CAD", "Canadian dollar", 2, " Canada" },
                    { 132, "CVE", "Cape Verdean escudo", 2, " Cabo Verde" },
                    { 136, "KYD", "Cayman Islands dollar", 2, " Cayman Islands" },
                    { 144, "LKR", "Sri Lankan rupee", 2, " Sri Lanka" },
                    { 152, "CLP", "Chilean peso", 0, " Chile" },
                    { 156, "CNY", "Chinese yuan", 2, " China" },
                    { 170, "COP", "Colombian peso", 2, " Colombia" },
                    { 174, "KMF", "Comoro franc", 0, " Comoros" },
                    { 188, "CRC", "Costa Rican colon", 2, " Costa Rica" },
                    { 191, "HRK", "Croatian kuna", 2, " Croatia" },
                    { 192, "CUP", "Cuban peso", 2, " Cuba" },
                    { 203, "CZK", "Czech koruna", 2, " Czechia" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "CurrencyISO4217",
                columns: new[] { "id", "code", "currencyName", "postDecimalDigits", "usedLocations" },
                values: new object[,]
                {
                    { 208, "DKK", "Danish krone", 2, " Denmark,  Faroe Islands (FO),  Greenland (GL)" },
                    { 214, "DOP", "Dominican peso", 2, " Dominican Republic" },
                    { 222, "SVC", "Salvadoran colón", 2, " El Salvador" },
                    { 230, "ETB", "Ethiopian birr", 2, " Ethiopia" },
                    { 232, "ERN", "Eritrean nakfa", 2, " Eritrea" },
                    { 238, "FKP", "Falkland Islands pound", 2, " Falkland Islands (pegged to GBP 1:1)" },
                    { 242, "FJD", "Fiji dollar", 2, " Fiji" },
                    { 262, "DJF", "Djiboutian franc", 0, " Djibouti" },
                    { 270, "GMD", "Gambian dalasi", 2, " Gambia" },
                    { 292, "GIP", "Gibraltar pound", 2, " Gibraltar (pegged to GBP 1:1)" },
                    { 320, "GTQ", "Guatemalan quetzal", 2, " Guatemala" },
                    { 324, "GNF", "Guinean franc", 0, " Guinea" },
                    { 328, "GYD", "Guyanese dollar", 2, " Guyana" },
                    { 332, "HTG", "Haitian gourde", 2, " Haiti" },
                    { 340, "HNL", "Honduran lempira", 2, " Honduras" },
                    { 344, "HKD", "Hong Kong dollar", 2, " Hong Kong" },
                    { 348, "HUF", "Hungarian forint", 2, " Hungary" },
                    { 352, "ISK", "Icelandic króna", 0, " Iceland" },
                    { 356, "INR", "Indian rupee", 2, " India,  Bhutan" },
                    { 360, "IDR", "Indonesian rupiah", 2, " Indonesia" },
                    { 364, "IRR", "Iranian rial", 2, " Iran" },
                    { 368, "IQD", "Iraqi dinar", 3, " Iraq" },
                    { 376, "ILS", "Israeli new shekel", 2, " Israel,  Palestinian Authority" },
                    { 388, "JMD", "Jamaican dollar", 2, " Jamaica" },
                    { 392, "JPY", "Japanese yen", 0, " Japan" },
                    { 398, "KZT", "Kazakhstani tenge", 2, " Kazakhstan" },
                    { 400, "JOD", "Jordanian dinar", 3, " Jordan" },
                    { 404, "KES", "Kenyan shilling", 2, " Kenya" },
                    { 408, "KPW", "North Korean won", 2, " North Korea" },
                    { 410, "KRW", "South Korean won", 0, " South Korea" },
                    { 414, "KWD", "Kuwaiti dinar", 3, " Kuwait" },
                    { 417, "KGS", "Kyrgyzstani som", 2, " Kyrgyzstan" },
                    { 418, "LAK", "Lao kip", 2, " Laos" },
                    { 422, "LBP", "Lebanese pound", 2, " Lebanon" },
                    { 426, "LSL", "Lesotho loti", 2, " Lesotho" },
                    { 430, "LRD", "Liberian dollar", 2, " Liberia" },
                    { 434, "LYD", "Libyan dinar", 3, " Libya" },
                    { 446, "MOP", "Macanese pataca", 2, " Macau" },
                    { 454, "MWK", "Malawian kwacha", 2, " Malawi" },
                    { 458, "MYR", "Malaysian ringgit", 2, " Malaysia" },
                    { 462, "MVR", "Maldivian rufiyaa", 2, " Maldives" },
                    { 480, "MUR", "Mauritian rupee", 2, " Mauritius" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "CurrencyISO4217",
                columns: new[] { "id", "code", "currencyName", "postDecimalDigits", "usedLocations" },
                values: new object[,]
                {
                    { 484, "MXN", "Mexican peso", 2, " Mexico" },
                    { 496, "MNT", "Mongolian tögrög", 2, " Mongolia" },
                    { 498, "MDL", "Moldovan leu", 2, " Moldova" },
                    { 504, "MAD", "Moroccan dirham", 2, " Morocco,  Western Sahara" },
                    { 512, "OMR", "Omani rial", 3, " Oman" },
                    { 516, "NAD", "Namibian dollar", 2, " Namibia" },
                    { 524, "NPR", "Nepalese rupee", 2, " Nepal" },
                    { 532, "ANG", "Netherlands Antillean guilder", 2, " Curaçao (CW), Sint Maarten (SX)" },
                    { 533, "AWG", "Aruban florin", 2, " Aruba" },
                    { 548, "VUV", "Vanuatu vatu", 0, " Vanuatu" },
                    { 554, "NZD", "New Zealand dollar", 2, " New Zealand,  Cook Islands (CK),  Niue (NU),  Pitcairn Islands (PN; see also Pitcairn Islands dollar),  Tokelau (TK)" },
                    { 558, "NIO", "Nicaraguan córdoba", 2, " Nicaragua" },
                    { 566, "NGN", "Nigerian naira", 2, " Nigeria" },
                    { 578, "NOK", "Norwegian krone", 2, " Norway,  Svalbard and  Jan Mayen (SJ),  Bouvet Island (BV)" },
                    { 586, "PKR", "Pakistani rupee", 2, " Pakistan" },
                    { 590, "PAB", "Panamanian balboa", 2, " Panama" },
                    { 598, "PGK", "Papua New Guinean kina", 2, " Papua New Guinea" },
                    { 600, "PYG", "Paraguayan guaraní", 0, " Paraguay" },
                    { 604, "PEN", "Peruvian sol", 2, " Peru" },
                    { 608, "PHP", "Philippine peso", 2, " Philippines" },
                    { 634, "QAR", "Qatari riyal", 2, " Qatar" },
                    { 643, "RUB", "Russian ruble", 2, " Russia" },
                    { 646, "RWF", "Rwandan franc", 0, " Rwanda" },
                    { 654, "SHP", "Saint Helena pound", 2, " Saint Helena (SH-SH),  Ascension Island (SH-AC),  Tristan da Cunha" },
                    { 682, "SAR", "Saudi riyal", 2, " Saudi Arabia" },
                    { 690, "SCR", "Seychelles rupee", 2, " Seychelles" },
                    { 694, "SLL", "Sierra Leonean leone", 2, " Sierra Leone" },
                    { 702, "SGD", "Singapore dollar", 2, " Singapore" },
                    { 704, "VND", "Vietnamese ??ng", 0, " Vietnam" },
                    { 706, "SOS", "Somali shilling", 2, " Somalia" },
                    { 710, "ZAR", "South African rand", 2, "Lesotho,  Namibia,  South Africa" },
                    { 728, "SSP", "South Sudanese pound", 2, " South Sudan" },
                    { 748, "SZL", "Swazi lilangeni", 2, " Eswatini" },
                    { 752, "SEK", "Swedish krona/kronor", 2, " Sweden" },
                    { 756, "CHF", "Swiss franc", 2, " Switzerland,  Liechtenstein (LI)" },
                    { 760, "SYP", "Syrian pound", 2, " Syria" },
                    { 764, "THB", "Thai baht", 2, " Thailand" },
                    { 776, "TOP", "Tongan pa?anga", 2, " Tonga" },
                    { 780, "TTD", "Trinidad and Tobago dollar", 2, " Trinidad and Tobago" },
                    { 784, "AED", "United Arab Emirates dirham", 2, " United Arab Emirates" },
                    { 788, "TND", "Tunisian dinar", 3, " Tunisia" },
                    { 800, "UGX", "Ugandan shilling", 0, " Uganda" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "CurrencyISO4217",
                columns: new[] { "id", "code", "currencyName", "postDecimalDigits", "usedLocations" },
                values: new object[,]
                {
                    { 807, "MKD", "Macedonian denar", 2, " North Macedonia" },
                    { 818, "EGP", "Egyptian pound", 2, " Egypt" },
                    { 826, "GBP", "Pound sterling", 2, " United Kingdom,  British Indian Ocean Territory (IO) (also uses USD), the  Isle of Man (IM, see Manx pound),  Jersey (JE, see Jersey pound), and  Guernsey (GG, see Guernsey pound)" },
                    { 834, "TZS", "Tanzanian shilling", 2, " Tanzania" },
                    { 840, "USD", "United States dollar", 2, " United States,  American Samoa (AS),  Barbados (BB) (as well as Barbados Dollar),  Bermuda (BM) (as well as Bermudian Dollar),  British Indian Ocean Territory (IO) (also uses GBP),  British Virgin Islands (VG),  Caribbean Netherlands (BQ – Bonaire, Sint Eustatius and Saba),  Ecuador (EC),  El Salvador (SV),  Guam (GU),  Haiti (HT),  Marshall Islands (MH),  Federated States of Micronesia (FM),  Northern Mariana Islands (MP),  Palau (PW),  Panama (PA) (as well as Panamanian Balboa),  Puerto Rico (PR),  Timor-Leste (TL),  Turks and Caicos Islands (TC),  U.S. Virgin Islands (VI),  United States Minor Outlying Islands (UM)  Cambodia." },
                    { 858, "UYU", "Uruguayan peso", 2, " Uruguay" },
                    { 860, "UZS", "Uzbekistan som", 2, " Uzbekistan" },
                    { 882, "WST", "Samoan tala", 2, " Samoa" },
                    { 886, "YER", "Yemeni rial", 2, " Yemen" },
                    { 901, "TWD", "New Taiwan dollar", 2, " Taiwan" },
                    { 927, "UYW", "Unidad previsional", 4, " Uruguay" },
                    { 928, "VES", "Venezuelan bolívar soberano", 2, " Venezuela" },
                    { 929, "MRU", "Mauritanian ouguiya", 2, " Mauritania" },
                    { 930, "STN", "São Tomé and Príncipe dobra", 2, " São Tomé and Príncipe" },
                    { 931, "CUC", "Cuban convertible peso", 2, " Cuba" },
                    { 932, "ZWL", "Zimbabwean dollar", 2, "Zimbabwe" },
                    { 933, "BYN", "Belarusian ruble", 2, " Belarus" },
                    { 934, "TMT", "Turkmenistan manat", 2, " Turkmenistan" },
                    { 936, "GHS", "Ghanaian cedi", 2, " Ghana" },
                    { 938, "SDG", "Sudanese pound", 2, " Sudan" },
                    { 940, "UYI", "Uruguay Peso en Unidades Indexadas (URUIURUI) (funds code)", 0, " Uruguay" },
                    { 941, "RSD", "Serbian dinar", 2, " Serbia" },
                    { 943, "MZN", "Mozambican metical", 2, " Mozambique" },
                    { 944, "AZN", "Azerbaijani manat", 2, " Azerbaijan" },
                    { 946, "RON", "Romanian leu", 2, " Romania" },
                    { 947, "CHE", "WIR Euro (complementary currency)", 2, " Switzerland" },
                    { 948, "CHW", "WIR Franc (complementary currency)", 2, " Switzerland" },
                    { 949, "TRY", "Turkish lira", 2, " Turkey,  Northern Cyprus" },
                    { 950, "XAF", "CFA franc BEAC", 0, " Cameroon (CM),  Central African Republic (CF),  Republic of the Congo (CG),  Chad (TD),  Equatorial Guinea (GQ),  Gabon (GA)" },
                    { 951, "XCD", "East Caribbean dollar", 2, " Anguilla (AI),  Antigua and Barbuda (AG),  Dominica (DM),  Grenada (GD),  Montserrat (MS),  Saint Kitts and Nevis (KN),  Saint Lucia (LC),  Saint Vincent and the Grenadines (VC)" },
                    { 952, "XOF", "CFA franc BCEAO", 0, " Benin (BJ),  Burkina Faso (BF),  Côte d''Ivoire (CI),  Guinea-Bissau (GW),  Mali (ML),  Niger (NE),  Senegal (SN),  Togo (TG)" },
                    { 953, "XPF", "CFP franc (franc Pacifique)", 0, "French territories of the Pacific Ocean:  French Polynesia (PF),  New Caledonia (NC),  Wallis and Futuna (WF)" },
                    { 955, "XBA", "European Composite Unit (EURCO) (bond market unit)", null, "" },
                    { 956, "XBB", "European Monetary Unit (E.M.U.-6) (bond market unit)", null, "" },
                    { 957, "XBC", "European Unit of Account 9 (E.U.A.-9) (bond market unit)", null, "" },
                    { 958, "XBD", "European Unit of Account 17 (E.U.A.-17) (bond market unit)", null, "" },
                    { 959, "XAU", "Gold (one troy ounce)", null, "" },
                    { 960, "XDR", "Special drawing rights", null, "International Monetary Fund" },
                    { 961, "XAG", "Silver (one troy ounce)", null, "" },
                    { 962, "XPT", "Platinum (one troy ounce)", null, "" },
                    { 963, "XTS", "Code reserved for testing", null, "" },
                    { 964, "XPD", "Palladium (one troy ounce)", null, "" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "CurrencyISO4217",
                columns: new[] { "id", "code", "currencyName", "postDecimalDigits", "usedLocations" },
                values: new object[,]
                {
                    { 965, "XUA", "ADB Unit of Account", null, "African Development Bank" },
                    { 967, "ZMW", "Zambian kwacha", 2, "Zambia" },
                    { 968, "SRD", "Surinamese dollar", 2, " Suriname" },
                    { 969, "MGA", "Malagasy ariary", 2, " Madagascar" },
                    { 970, "COU", "Unidad de Valor Real (UVR) (funds code)", 2, " Colombia" },
                    { 971, "AFN", "Afghan afghani", 2, " Afghanistan" },
                    { 972, "TJS", "Tajikistani somoni", 2, " Tajikistan" },
                    { 973, "AOA", "Angolan kwanza", 2, " Angola" },
                    { 975, "BGN", "Bulgarian lev", 2, " Bulgaria" },
                    { 976, "CDF", "Congolese franc", 2, " Democratic Republic of the Congo" },
                    { 977, "BAM", "Bosnia and Herzegovina convertible mark", 2, " Bosnia and Herzegovina" },
                    { 978, "EUR", "Euro", 2, " Åland Islands (AX),  European Union (EU),  Andorra (AD),  Austria (AT),  Belgium (BE),  Cyprus (CY),  Estonia (EE),  Finland (FI),  France (FR),  French Southern and Antarctic Lands (TF),  Germany (DE),  Greece (GR),  Guadeloupe (GP),  Ireland (IE),  Italy (IT),  Kosovo (XK),  Latvia (LV),  Lithuania (LT),  Luxembourg (LU),  Malta (MT),  French Guiana (GF),  Martinique (MQ),  Mayotte (YT),  Monaco (MC),  Montenegro (ME),  Netherlands (NL),  Portugal (PT),  Réunion (RE),  Saint Barthélemy (BL),  Saint Martin (MF),  Saint Pierre and Miquelon (PM),  San Marino (SM),  Slovakia (SK),  Slovenia (SI),  Spain (ES),   Vatican City (VA)" },
                    { 979, "MXV", "Mexican Unidad de Inversion (UDI) (funds code)", 2, " Mexico" },
                    { 980, "UAH", "Ukrainian hryvnia", 2, " Ukraine" },
                    { 981, "GEL", "Georgian lari", 2, " Georgia" },
                    { 984, "BOV", "Bolivian Mvdol (funds code)", 2, " Bolivia" },
                    { 985, "PLN", "Polish z?oty", 2, " Poland" },
                    { 986, "BRL", "Brazilian real", 2, " Brazil" },
                    { 990, "CLF", "Unidad de Fomento (funds code)", 4, " Chile" },
                    { 994, "XSU", "SUCRE", null, "Unified System for Regional Compensation (SUCRE)" },
                    { 997, "USN", "United States dollar (next day) (funds code)", 2, " United States" },
                    { 999, "XXX", "No currency ", null, "" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "DeliveryMethod",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "Manage outside of system/application (Automated Delivery: (self-driving/drone) -add to roadmap)", "N/A", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "Pick up only", "No", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "Deliver on request for large orders", "SomeTimes", "ABC00777-0330-5005-0123-000000000001" },
                    { 4, "Company driver surviving surrounding areas", "Yes", "ABC00777-0330-5005-0123-000000000001" },
                    { 5, "Local Courier companies (e.g. Mr Delivery)) {integrate with their API services}", "Managed", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FarmAgriculture",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "Permaculture is an approach to land management and philosophy that adopts arrangements observed in flourishing natural ecosystems. It includes a set of design principles derived using whole systems thinking. It uses these principles in fields such as regenerative agriculture, rewilding, and community resilience", "Permaculture", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "Sustainable agriculture is farming in sustainable ways meeting society's present food and textile needs, without compromising the ability for current or future generations to meet their needs. It can be based on an understanding of ecosystem services", "Sustainable Agriculture", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "Traditional farming methods to produce food crops. Rural farming tools such as the hoe and animal traction are the main implements used to prepare land.", "Traditional Agriculture", "ABC00777-0330-5005-0123-000000000001" },
                    { 4, "Alternative agriculture, the most practised form of agriculture around the world, became commonplace following the two world wars, as it was during that era that knowledge about chemistry greatly increased. Traditional agriculture is based on treating the soil and plants with products that are more likely than not noxious, and more likely than not synthetically produced in a laboratory. These products are used to prevent disease or pests from blighting the plant.", "Alternative Agriculture", "ABC00777-0330-5005-0123-000000000001" },
                    { 5, "Organic farming is an agricultural system which originated early in the 20th century in reaction to rapidly changing farming practices. 'Certified organic agriculture accounts for 70 million hectares globally.'", "Organic Agriculture", "ABC00777-0330-5005-0123-000000000001" },
                    { 6, "Regenerative agriculture is a conservation and rehabilitation approach to food and farming systems. It focuses on topsoil regeneration, increasing biodiversity, improving the water cycle, enhancing ecosystem services, supporting biosequestration, increasing resilience to climate change, and strengthening the health and vitality of farm soil.", "Regenerative Agriculture", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FarmCulture",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "Poly-/Mono-culture practiced in separate locations. Rotational grazing, mixed crop rotation, cover cropping, and composting...", "Hybrid", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "Polyculture is a form of agriculture in which more than one species is grown at the same time and place in imitation of the diversity of natural ecosystems. Polyculture is the opposite of monoculture, in which only members of one plant or animal species are cultivated together", "Polyculture", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "Monoculture is the agricultural practice of growing a single crop, plant, or livestock species, variety, or breed in a field or farming system at a time. Polyculture, where more than one crop species is grown in the same space at the same time, is the alternative to monoculture.", "Monoculture", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeedbackCategory",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "Account Related", "Account", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "Website Related", "Website", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "Application Related", "Application", "ABC00777-0330-5005-0123-000000000001" },
                    { 4, "Links Related", "Links", "ABC00777-0330-5005-0123-000000000001" },
                    { 5, "Services Related", "Services", "ABC00777-0330-5005-0123-000000000001" },
                    { 6, "Related something else.", "Other", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FeedbackType",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "Comment / Improvement idea", "Comment / Improvement idea", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "Bug / Issue Report", "Bug / Issue Report", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "Question / Contact Us", "Question / Contact Us", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "GrowMediumType",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "[None]", "unknown", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "(floats)", "Water", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "(suspended)", "Air", "ABC00777-0330-5005-0123-000000000001" },
                    { 4, "Loose aggregation of rock fragments", "Gravel", "ABC00777-0330-5005-0123-000000000001" },
                    { 5, "Sand ranges from 0.075mm - 4.75mm / Silt ranges from 0.002mm - 0.06 mm", "Sand / Silt", "ABC00777-0330-5005-0123-000000000001" },
                    { 6, " It consists of microscopic and sub-microscopic particles derived from the chemical decomposition of rocks", "Soil Clays / Mineral Colloids", "ABC00777-0330-5005-0123-000000000001" },
                    { 7, "Organic colloids are tiny bits of organic matter that are resistant to decay.", "Organic Colloids", "ABC00777-0330-5005-0123-000000000001" },
                    { 8, "Terra preta is characterized by the presence of low-temperature charcoal residues in high concentrations; of high quantities of tiny pottery shards; of organic matter such as plant residues, animal feces, fish and animal bones, and other material; and of nutrients such as nitrogen, phosphorus, calcium, zinc and manganese. Fertile soils such as terra preta show high levels of microorganic activities and other specific characteristics within particular ecosystems.", "Carbon and Terra Preta", "ABC00777-0330-5005-0123-000000000001" },
                    { 9, "RockWool insulation is a rock-based mineral fiber insulation comprised of Basalt rock and Recycled Slag. Basalt is a volcanic rock (abundant in the earth), and slag is a by-product of the steel and copper industry. The minerals are melted and spun into fibers.", "RockWool", "ABC00777-0330-5005-0123-000000000001" },
                    { 10, "Not Given", "Synthetic Material", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "GrowSpaceDataEntryType",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "Humanly Captured", "Manual measure", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "Machine Records", "Automated digital monitory", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "GrowSpaceLightSourceType",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "[None]", "unknown", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "The polar opposite of brightness, is understood as a lack of illumination or an absence of visible light.", "natural - Darkness/noLight", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "Sunlight is a portion of the electromagnetic radiation given off by the Sun, in particular infrared, visible, and ultraviolet light.", "natural - Sunlight", "ABC00777-0330-5005-0123-000000000001" },
                    { 4, "In a Typical bulb an tungsten filament glows when the current passes through it, illuminating the bulb. The tungsten filament is surrounded by a vacuum or nitrogen gas", "artificial - Incandescent Bulb", "ABC00777-0330-5005-0123-000000000001" },
                    { 5, "An Light-Emitting Diode is a semiconductor device in which the electricity is applied to the negatively charged diode, resulting in the flow of electron and release of the photon. The photons combine to emit light from the diode", "artificial - LED", "ABC00777-0330-5005-0123-000000000001" },
                    { 6, "In a fluorescent tube, the electric current passes between the cathodes, exciting mercury and other gasses which are filled inside, radiating energy. The phosphorous coating at the outside converts radiant energy into visible light", "artificial - Fluorescent", "ABC00777-0330-5005-0123-000000000001" },
                    { 7, "Compact Fluorescent Lamps", "artificial - CFL", "ABC00777-0330-5005-0123-000000000001" },
                    { 8, "A lamp using a filament surrounded by the vapour of iodine or another halogen.", "artificial - Halogen", "ABC00777-0330-5005-0123-000000000001" },
                    { 9, "A sodium-vapor lamp is a gas-discharge lamp that uses sodium in an excited state to produce light at a characteristic wavelength near 589 nm", "artificial - Sodium", "ABC00777-0330-5005-0123-000000000001" },
                    { 10, "A mercury-vapor lamp is a gas-discharge lamp that uses an electric arc through vaporized mercury to produce light.", "artificial - Mercury", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "GrowSpaceSetupType",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "Not Given", "Custom", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "Hydroponics is a type of horticulture and a subset of hydroculture which involves growing plants (usually crops) without soil, by using mineral nutrient solutions in an aqueous solvent. Terrestrial plants may grow with their roots exposed to the nutritious liquid, or, in addition, the roots may be physically supported by an inert medium such as perlite, gravel, or other substrates.", "Hydroponics", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "Aquaponics refers to a food production system that couples aquaculture (raising aquatic animals such as fish, crayfish, snails or prawns in tanks) with hydroponics (cultivating plants in water) whereby the nutrient rich aquaculture water is fed to hydroponic grown plant, involving nitrifying bacteria for converting ammonia into nitrates.", "Aquaponics", "ABC00777-0330-5005-0123-000000000001" },
                    { 4, "Aeroponics is the process of growing plants in an air or mist environment without the use of soil or an aggregate medium. Aeroponic culture differs from both conventional hydroponics, aquaponics, and in-vitro growing.", "Aeroponics", "ABC00777-0330-5005-0123-000000000001" },
                    { 5, "Soil is a natural body comprised of solids (minerals and organic matter)", "Classic Soil", "ABC00777-0330-5005-0123-000000000001" },
                    { 6, "No-till farming is an agricultural technique for growing crops or pasture without disturbing the soil through tillage. No-till farming decreases the amount of soil erosion tillage causes in certain soils, especially in sandy and dry soils on sloping terrain.", "No-Dig", "ABC00777-0330-5005-0123-000000000001" },
                    { 7, "Growbeds / on legs or otherwise elevated earth containers. ", "Raised/Grow-beds", "ABC00777-0330-5005-0123-000000000001" },
                    { 8, "Mixture of containers", "Potted Container", "ABC00777-0330-5005-0123-000000000001" },
                    { 9, "Movable bags filled with GrowMedium.", "Growbags", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "GrowSpaceType",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "[None]", "unknown", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "Linear rows.", "Rows", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "Raised / Grow / Garden beds.", "Beds", "ABC00777-0330-5005-0123-000000000001" },
                    { 4, "Vertical Stacked racks", "Trays", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "OrderStatus",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "Will not take place.", "Canceled", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "Place an order for (an item) before it is available for purchase.", "Pre-Order", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "Temporarily out of stock with the supplier.", "Backorder", "ABC00777-0330-5005-0123-000000000001" },
                    { 4, "Requested (something) to be made, supplied, or served.", "Ordered", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "OrderStatus",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 5, "Accepted", "Confirmed", "ABC00777-0330-5005-0123-000000000001" },
                    { 6, "Not Given", "DelayedByVendor", "ABC00777-0330-5005-0123-000000000001" },
                    { 7, "Not Given", "PosponedByCustomer", "ABC00777-0330-5005-0123-000000000001" },
                    { 8, "Being taken from one place to another.", "In-transit", "ABC00777-0330-5005-0123-000000000001" },
                    { 9, "Provided (something promised or expected).", "Delivered", "ABC00777-0330-5005-0123-000000000001" },
                    { 10, "Back at Distribution Center.", "ReturnedToDC", "ABC00777-0330-5005-0123-000000000001" },
                    { 11, "Not Given", "UnableToDeliver", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PaymentType",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "Manage outside of system/application", "N/A", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "(cash) Local Currency", "Cash_Local", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "(cash) Specific Currency", "Cash_Specific", "ABC00777-0330-5005-0123-000000000001" },
                    { 4, "online / manualy @ bank", "EFT", "ABC00777-0330-5005-0123-000000000001" },
                    { 5, "PayPal (auto), GoogleWallet, Amazon, SamsunyPay, etc. ? Crypto Currency (Any / All) ?", "Managed", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "TraderType",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "For home use", "Personal", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "No physical store front", "Online only", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "Family-owned / one-man startup", "Own Business", "ABC00777-0330-5005-0123-000000000001" },
                    { 4, "Roaming mobile store", "Dynamic location", "ABC00777-0330-5005-0123-000000000001" },
                    { 5, "Established Business", "Registered Business", "ABC00777-0330-5005-0123-000000000001" },
                    { 6, "Big Corporation", "Enterprise", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ZoneClassification",
                columns: new[] { "id", "details", "name", "ownerId" },
                values: new object[,]
                {
                    { 1, "N/A", "Other", "ABC00777-0330-5005-0123-000000000001" },
                    { 2, "N/A", "Indoors - Greenhouse / geoDome", "ABC00777-0330-5005-0123-000000000001" },
                    { 3, "N/A", "Indoors - Room / Basement", "ABC00777-0330-5005-0123-000000000001" },
                    { 4, "N/A", "Outdoors - Rooftop", "ABC00777-0330-5005-0123-000000000001" },
                    { 5, "N/A", "Outdoors - Patch of open land / Garden", "ABC00777-0330-5005-0123-000000000001" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ZoneClimateType",
                columns: new[] { "id", "details", "koppenGeiger", "name", "simple" },
                values: new object[,]
                {
                    { 1, "N/A", "[None]", "unknown", " " },
                    { 2, "wet / wet & dry", "[Af,Am,Aw/As]", "Tropical", "A" },
                    { 3, "semiArid / Arid", "[BWh,BWk,BSh,BSk]", "Desert / Dry", "B" },
                    { 4, "Mediterranean / HumedSubTropical", "[Csa,Csb,Csc,Cwa,Cwb,Cwc,Cfa,Cfb,Cfc]", "Temperate / Moderate", "C" },
                    { 5, "Humid / SubArctic", "[Dsa,Dsb,Dsc,Dsd,Dwa,Dwb,Dwc,Dwd,Dfa,Dfb,Dfc,Dfd]", "Continental / Cold", "D" },
                    { 6, "Tundra / Icecap / highland s/ non-permanantIce", "[ET,EF]", "Polar", "E" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CropLifeCycleStage",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CropLifeCycleStage",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CropLifeCycleStage",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CropLifeCycleStage",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CropLifeCycleStage",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CropLifeCycleStage",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CropLifeCycleStage",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CropLifeCycleStage",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CropLifeCycleStage",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CropLifeCycleStage",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CropLifeCycleStage",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "CurrencyISO4217",
                keyColumn: "id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DeliveryMethod",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DeliveryMethod",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DeliveryMethod",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DeliveryMethod",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "DeliveryMethod",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FarmAgriculture",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FarmAgriculture",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FarmAgriculture",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FarmAgriculture",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FarmAgriculture",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FarmAgriculture",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FarmCulture",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FarmCulture",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FarmCulture",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeedbackCategory",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeedbackCategory",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeedbackCategory",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeedbackCategory",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeedbackCategory",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeedbackCategory",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeedbackType",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeedbackType",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FeedbackType",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowMediumType",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowMediumType",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowMediumType",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowMediumType",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowMediumType",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowMediumType",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowMediumType",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowMediumType",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowMediumType",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowMediumType",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceDataEntryType",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceDataEntryType",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceLightSourceType",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceLightSourceType",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceLightSourceType",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceLightSourceType",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceLightSourceType",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceLightSourceType",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceLightSourceType",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceLightSourceType",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceLightSourceType",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceLightSourceType",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceSetupType",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceSetupType",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceSetupType",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceSetupType",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceSetupType",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceSetupType",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceSetupType",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceSetupType",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceSetupType",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceType",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceType",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceType",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GrowSpaceType",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "OrderStatus",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "OrderStatus",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "OrderStatus",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "OrderStatus",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "OrderStatus",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "OrderStatus",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "OrderStatus",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "OrderStatus",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "OrderStatus",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "OrderStatus",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "OrderStatus",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PaymentType",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PaymentType",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PaymentType",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PaymentType",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "PaymentType",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "TraderType",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "TraderType",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "TraderType",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "TraderType",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "TraderType",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "TraderType",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ZoneClassification",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ZoneClassification",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ZoneClassification",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ZoneClassification",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ZoneClassification",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ZoneClimateType",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ZoneClimateType",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ZoneClimateType",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ZoneClimateType",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ZoneClimateType",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ZoneClimateType",
                keyColumn: "id",
                keyValue: 6);
        }
    }
}