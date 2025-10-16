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
using System;

#nullable disable

namespace SIF_AppData_Context.Migrations
{
    public partial class InitalCreate_SIF_TBLs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "log");

            migrationBuilder.EnsureSchema(
                name: "sec");

            migrationBuilder.EnsureSchema(
                name: "cmd");

            migrationBuilder.EnsureSchema(
                name: "mar");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "plt");

            migrationBuilder.EnsureSchema(
                name: "frm");

            migrationBuilder.EnsureSchema(
                name: "trd");

            migrationBuilder.EnsureSchema(
                name: "acc");

            migrationBuilder.CreateTable(
                name: "ActionHistory",
                schema: "log",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    baseUserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    traderEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    actionType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionHistory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationSection",
                schema: "sec",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    canView = table.Column<bool>(type: "bit", nullable: false),
                    canAdd = table.Column<bool>(type: "bit", nullable: false),
                    canUpdate = table.Column<bool>(type: "bit", nullable: false),
                    canDelete = table.Column<bool>(type: "bit", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationSection", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Commodity",
                schema: "cmd",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    traderEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    currencyId = table.Column<int>(type: "int", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CropLifeCycleStage",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CropLifeCycleStage", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyISO4217",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    postDecimalDigits = table.Column<int>(type: "int", nullable: true),
                    currencyName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    usedLocations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyISO4217", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryMethod",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryMethod", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Division",
                schema: "plt",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DivisionClass",
                schema: "plt",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivisionClass", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DivisionOrder",
                schema: "plt",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivisionOrder", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Family",
                schema: "plt",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    commonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FarmAgriculture",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmAgriculture", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FarmCulture",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmCulture", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackCategory",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackCategory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackMetadata",
                schema: "log",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    operatingSystem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    browser = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    browserPlugins = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    cpu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    publicIP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    connectionSpeed = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    connectedSocialMediaAcounts = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackMetadata", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackType",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Genus",
                schema: "plt",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genus", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GrowMediumType",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowMediumType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GrowSpaceDataEntryType",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowSpaceDataEntryType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GrowSpaceLightSourceType",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowSpaceLightSourceType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GrowSpaceSetupType",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowSpaceSetupType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GrowSpaceType",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowSpaceType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Kingdom",
                schema: "plt",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kingdom", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MunicipalityDetail",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    municipalityContactDetails = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    policeContactDetails = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ambulanceContactDetails = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    waterDepartmentContactDetails = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    electricityDepartmentContactDetails = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fireDepartmentContactDetails = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MunicipalityDetail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PaidService",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaidService", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Plant",
                schema: "plt",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scientificName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    commonEnglishName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    familyCommonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    imagesUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    mainSpeciesId = table.Column<int>(type: "int", nullable: true),
                    nativeStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    varieties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subSpecies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hybrids = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    forms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cultivars = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genusId = table.Column<int>(type: "int", nullable: true),
                    familyId = table.Column<int>(type: "int", nullable: true),
                    divisionOrderId = table.Column<int>(type: "int", nullable: true),
                    divisionClassId = table.Column<int>(type: "int", nullable: true),
                    divisionId = table.Column<int>(type: "int", nullable: true),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityGroup",
                schema: "sec",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    isSystemConfig = table.Column<bool>(type: "bit", nullable: false),
                    traderEntityOwnerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityGroup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                schema: "plt",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scientificName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    commonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    familyCommonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    synonym = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    imagesUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    isMainSpecies = table.Column<bool>(type: "bit", nullable: true),
                    mainSpeciesId = table.Column<long>(type: "bigint", nullable: true),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nativeStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    completeData = table.Column<bool>(type: "bit", nullable: true),
                    specification_Toxicity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_ShapeAndOrientation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_RegrowthRate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_NitrogenFixation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_MaxHeightAtBaseAge_cm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_MatureHeight_cm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_LowGrowingGrass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_Lifespan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_LeafRetention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_KnownAllelopath = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_GrowthRate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_GrowthPeriod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_GrowthHabit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_GrowthForm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_FireResistance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_FallConspicuous = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_CoppicePotential = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_C_n_ratio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    specification_Bloat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    soilsAdaptation_Medium = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    soilsAdaptation_Fine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    soilsAdaptation_Coarse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    seed_VegetativeSpreadRate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    seed_SmallGrain = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    seed_SeedsPerPound = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    seed_SeedlingVigor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    seed_SpreadRate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    seed_CommercialAvailability = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    seed_BloomPeriod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    propagation_Tubers = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    propagation_Sprigs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    propagation_Sod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    propagation_Seed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    propagation_Cuttings = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    propagation_Corms = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    propagation_Container = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    propagation_Bulbs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    propagation_BareRoot = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_TemperatureMinimum_deg_c = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_ShadeTolerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_SalinityTolerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_RootDepthMinimum_cm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_ResproutAbility = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_PrecipitationMinimum_cm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_PrecipitationMaximum_cm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_PlantingDensityMinimum_sqm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_PlantingDensityMaximum_sqm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_PhMinimum = table.Column<decimal>(type: "decimal(6,4)", nullable: true),
                    growth_PhMaximum = table.Column<decimal>(type: "decimal(6,4)", nullable: true),
                    growth_MoistureUse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_HedgeTolerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_FrostFreeDaysMinimum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_FireTolerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_FertilityRequirement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_DroughtTolerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_ColdStratificationRequired = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_CaCO3Tolerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_AnaerobicTolerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    foliage_Texture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    foliage_PorositySummer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    foliage_PorosityWinter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    foliage_Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fruitOrSeed_Persistence = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fruitOrSeed_PeriodBegin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fruitOrSeed_PeriodEnd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fruitOrSeed_Abundance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fruitOrSeed_Conspicuous = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fruitOrSeed_Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    flower_Conspicuous = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    flower_Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_Veneer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_Pulpwood = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_ProteinPotential = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_Post = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_PalatableHuman = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_PalatableGrazeAnimal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_PalatableBrowseAnimal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_NurseryStock = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_NavalStore = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_Lumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_Fuelwood = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_Fodder = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_ChristmasTree = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    products_BerryNutSeed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                schema: "mar",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    te_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SubKingdom",
                schema: "plt",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubKingdom", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SystemParameter",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    value = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemParameter", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TraderContactDetail",
                schema: "trd",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    websiteUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    customerCareEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    otherDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraderContactDetail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TraderEntitySettingsDatum",
                schema: "acc",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    traderEntity_PrimaryHexColor = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    traderEntity_SecondaryHexColor = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    layoutType_Simple = table.Column<bool>(type: "bit", nullable: false),
                    theme_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    display_Titles = table.Column<bool>(type: "bit", nullable: false),
                    display_InputControlLabels = table.Column<bool>(type: "bit", nullable: false),
                    display_DynamicNav = table.Column<bool>(type: "bit", nullable: false),
                    infoBar_Show = table.Column<bool>(type: "bit", nullable: false),
                    infoBar_ServerTime = table.Column<bool>(type: "bit", nullable: false),
                    infoBar_LocalTime = table.Column<bool>(type: "bit", nullable: false),
                    infoBar_Alerts = table.Column<bool>(type: "bit", nullable: false),
                    infoBar_Weather = table.Column<bool>(type: "bit", nullable: false),
                    titleBar_Show = table.Column<bool>(type: "bit", nullable: false),
                    titleBar_Heading = table.Column<bool>(type: "bit", nullable: false),
                    titleBar_TopNavSubMenus = table.Column<bool>(type: "bit", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraderEntitySettingsDatum", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TraderType",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraderType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TrefleData",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scientific_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    rank = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    genus = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    family = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    year = table.Column<int>(type: "int", nullable: true),
                    author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    bibliography = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    common_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    family_common_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    image_url = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    flower_color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    flower_conspicuous = table.Column<bool>(type: "bit", nullable: true),
                    foliage_color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    foliage_texture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fruit_color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fruit_conspicuous = table.Column<bool>(type: "bit", nullable: true),
                    fruit_months = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    bloom_months = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ground_humidity = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    growth_form = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_habit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_months = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    growth_rate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    edible_part = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    vegetable = table.Column<bool>(type: "bit", nullable: true),
                    edible = table.Column<bool>(type: "bit", nullable: true),
                    light = table.Column<short>(type: "smallint", nullable: true),
                    soil_nutriments = table.Column<short>(type: "smallint", nullable: true),
                    soil_salinity = table.Column<short>(type: "smallint", nullable: true),
                    anaerobic_tolerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    atmospheric_humidity = table.Column<short>(type: "smallint", nullable: true),
                    average_height_cm = table.Column<short>(type: "smallint", nullable: true),
                    maximum_height_cm = table.Column<short>(type: "smallint", nullable: true),
                    minimum_root_depth_cm = table.Column<short>(type: "smallint", nullable: true),
                    ph_maximum = table.Column<decimal>(type: "decimal(6,4)", nullable: true),
                    ph_minimum = table.Column<decimal>(type: "decimal(6,4)", nullable: true),
                    planting_days_to_harvest = table.Column<short>(type: "smallint", nullable: true),
                    planting_description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    planting_sowing_description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    planting_row_spacing_cm = table.Column<short>(type: "smallint", nullable: true),
                    planting_spread_cm = table.Column<short>(type: "smallint", nullable: true),
                    synonyms = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    distributions = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    common_names = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    url_usda = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    url_tropicos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    url_tela_botanica = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    url_powo = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    url_plantnet = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    url_gbif = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    url_openfarm = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    url_catminat = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    url_wikipedia_en = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrefleData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User_SecurityGroup",
                schema: "acc",
                columns: table => new
                {
                    userBaseId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    securityGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_SecurityGroup", x => new { x.userBaseId, x.securityGroupId });
                });

            migrationBuilder.CreateTable(
                name: "User_TraderEntity",
                schema: "acc",
                columns: table => new
                {
                    userBaseId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    traderEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    traderEntitySettingsDatumId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    currentContext = table.Column<bool>(type: "bit", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_TraderEntity", x => new { x.userBaseId, x.traderEntityId });
                });

            migrationBuilder.CreateTable(
                name: "Wishlist",
                schema: "mar",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    details = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ZoneClassification",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ownerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneClassification", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ZoneClimateType",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    simple = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    details = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    koppenGeiger = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneClimateType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Consumable",
                schema: "cmd",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    commodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    harvestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    actualPhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    plantId = table.Column<long>(type: "bigint", nullable: true),
                    dateProduced = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    itemCountTotal = table.Column<int>(type: "int", nullable: true),
                    length = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    width = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    height = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    weight = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    volume = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    quantityGrade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    storageDetails = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    comments = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    synonyms = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    varieties = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    naturalRange = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    uses = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    nutrition = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    production = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    reproduction = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cultivation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    pestsAndDiseases = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    storageAndTransport = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ecology = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    botany = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    history = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumable", x => x.id);
                    table.ForeignKey(
                        name: "FK_Consumable_Commodity",
                        column: x => x.commodityId,
                        principalSchema: "cmd",
                        principalTable: "Commodity",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Packaging",
                schema: "cmd",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    commodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    designImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    notSpecified = table.Column<bool>(type: "bit", nullable: false),
                    none = table.Column<bool>(type: "bit", nullable: false),
                    biodegradable = table.Column<bool>(type: "bit", nullable: false),
                    cardboard = table.Column<bool>(type: "bit", nullable: false),
                    recyclablePlastic = table.Column<bool>(type: "bit", nullable: false),
                    toxicPlastic = table.Column<bool>(type: "bit", nullable: false),
                    length = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    width = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    height = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    weight = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    volume = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packaging", x => x.id);
                    table.ForeignKey(
                        name: "FK_Packaging_Commodity",
                        column: x => x.commodityId,
                        principalSchema: "cmd",
                        principalTable: "Commodity",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                schema: "cmd",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    commodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    paymentTypeId = table.Column<int>(type: "int", nullable: false),
                    bankDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.id);
                    table.ForeignKey(
                        name: "FK_PaymentMethod_Commodity",
                        column: x => x.commodityId,
                        principalSchema: "cmd",
                        principalTable: "Commodity",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Permit",
                schema: "cmd",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    commodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    certificateImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    issuerOrgName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    issuedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    validFor_day = table.Column<int>(type: "int", nullable: true),
                    expirationDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    otherDetails = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permit", x => x.id);
                    table.ForeignKey(
                        name: "FK_Permit_Commodity",
                        column: x => x.commodityId,
                        principalSchema: "cmd",
                        principalTable: "Commodity",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Credit",
                schema: "mar",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    creditorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    debtorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    currencyISO4217Id = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<decimal>(type: "money", nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credit", x => x.id);
                    table.ForeignKey(
                        name: "FK_Credit_currencyISO4217Id",
                        column: x => x.currencyISO4217Id,
                        principalSchema: "dbo",
                        principalTable: "CurrencyISO4217",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "DeliveryConfig",
                schema: "cmd",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    commodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    deliveryMethodId = table.Column<int>(type: "int", nullable: false),
                    deliveryRange_km = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    deliveryRangePlotPoints = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pricePer_km = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryConfig", x => x.id);
                    table.ForeignKey(
                        name: "FK_DeliveryConfig_Commodity",
                        column: x => x.commodityId,
                        principalSchema: "cmd",
                        principalTable: "Commodity",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_DeliveryConfig_DeliveryMethod",
                        column: x => x.deliveryMethodId,
                        principalSchema: "dbo",
                        principalTable: "DeliveryMethod",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Division_DivisionClass",
                schema: "plt",
                columns: table => new
                {
                    divisionId = table.Column<int>(type: "int", nullable: false),
                    divisionClassId = table.Column<int>(type: "int", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division_DivisionClass", x => new { x.divisionId, x.divisionClassId });
                    table.ForeignKey(
                        name: "FK_Division_DivisionClass_Division",
                        column: x => x.divisionId,
                        principalSchema: "plt",
                        principalTable: "Division",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Division_DivisionClass_DivisionClass",
                        column: x => x.divisionClassId,
                        principalSchema: "plt",
                        principalTable: "DivisionClass",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "DivisionClass_DivisionOrder",
                schema: "plt",
                columns: table => new
                {
                    divisionClassId = table.Column<int>(type: "int", nullable: false),
                    divisionOrderId = table.Column<int>(type: "int", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivisionClass_DivisionOrder", x => new { x.divisionClassId, x.divisionOrderId });
                    table.ForeignKey(
                        name: "FK_DivisionClass_DivisionOrder_DivisionClass",
                        column: x => x.divisionClassId,
                        principalSchema: "plt",
                        principalTable: "DivisionClass",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_DivisionClass_DivisionOrder_DivisionOrder",
                        column: x => x.divisionOrderId,
                        principalSchema: "plt",
                        principalTable: "DivisionOrder",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "DivisionOrder_Family",
                schema: "plt",
                columns: table => new
                {
                    divisionOrderId = table.Column<int>(type: "int", nullable: false),
                    familyId = table.Column<int>(type: "int", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivisionOrder_Family", x => new { x.divisionOrderId, x.familyId });
                    table.ForeignKey(
                        name: "FK_DivisionOrder_Family_Division",
                        column: x => x.divisionOrderId,
                        principalSchema: "plt",
                        principalTable: "DivisionOrder",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_DivisionOrder_Family_DivisionOrder",
                        column: x => x.familyId,
                        principalSchema: "plt",
                        principalTable: "Family",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Farm",
                schema: "frm",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    traderEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cultureId = table.Column<int>(type: "int", nullable: false),
                    agricultureApproachId = table.Column<int>(type: "int", nullable: false),
                    borderDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    propertyArea_m2 = table.Column<decimal>(type: "decimal(10,2)", nullable: true, defaultValueSql: "((0))"),
                    speciesPreference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soilAndGrowMedium = table.Column<bool>(type: "bit", nullable: false),
                    waterManagement = table.Column<bool>(type: "bit", nullable: false),
                    nutrientsManagement = table.Column<bool>(type: "bit", nullable: false),
                    energyManagement = table.Column<bool>(type: "bit", nullable: false),
                    diseaseControlManagement = table.Column<bool>(type: "bit", nullable: false),
                    sustainabilityManagement = table.Column<bool>(type: "bit", nullable: false),
                    pestsManagement = table.Column<bool>(type: "bit", nullable: false),
                    weedsManagement = table.Column<bool>(type: "bit", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farm", x => x.id);
                    table.ForeignKey(
                        name: "FK_Farm_agricultureApproachId",
                        column: x => x.agricultureApproachId,
                        principalSchema: "dbo",
                        principalTable: "FarmAgriculture",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Farm_cultureId",
                        column: x => x.cultureId,
                        principalSchema: "dbo",
                        principalTable: "FarmCulture",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                schema: "log",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    baseUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    feedbackTypeId = table.Column<int>(type: "int", nullable: false),
                    feedbackCategoryId = table.Column<int>(type: "int", nullable: false),
                    applicationVersion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    identityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    feedbackMetadataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.id);
                    table.ForeignKey(
                        name: "FK_Feedback_FeedbackCategory",
                        column: x => x.feedbackCategoryId,
                        principalSchema: "dbo",
                        principalTable: "FeedbackCategory",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Feedback_FeedbackMetadata",
                        column: x => x.feedbackMetadataId,
                        principalSchema: "log",
                        principalTable: "FeedbackMetadata",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Feedback_FeedbackType",
                        column: x => x.feedbackTypeId,
                        principalSchema: "dbo",
                        principalTable: "FeedbackType",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Family_Genus",
                schema: "plt",
                columns: table => new
                {
                    familyId = table.Column<int>(type: "int", nullable: false),
                    genusId = table.Column<int>(type: "int", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family_Genus", x => new { x.familyId, x.genusId });
                    table.ForeignKey(
                        name: "FK_Family_Genus_Family",
                        column: x => x.familyId,
                        principalSchema: "plt",
                        principalTable: "Family",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Family_Genus_Genus",
                        column: x => x.genusId,
                        principalSchema: "plt",
                        principalTable: "Genus",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "GrowMediumDetail",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    growMediumTypeId = table.Column<int>(type: "int", nullable: false),
                    texture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    structure = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    density = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    porosity = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    consistency = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    temperature = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    colour = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    resistivity = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    waterRetention = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    waterFlow = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowMediumDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_GrowMediumDetail_growMediumTypeId",
                        column: x => x.growMediumTypeId,
                        principalSchema: "dbo",
                        principalTable: "GrowMediumType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TraderLocation",
                schema: "trd",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    gpsCoordinates = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    mapImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    countryRegion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    stateProvince = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    city = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    postalCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    addressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    addressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    building = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    floorLevel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    customDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    municipalityId = table.Column<long>(type: "bigint", nullable: true, defaultValueSql: "('00000000-0000-0000-0000-000000000000')"),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraderLocation", x => x.id);
                    table.ForeignKey(
                        name: "FK_TraderLocation_MunicipalityDetail",
                        column: x => x.municipalityId,
                        principalSchema: "dbo",
                        principalTable: "MunicipalityDetail",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "mar",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    orderPlaced = table.Column<DateTime>(type: "datetime", nullable: false),
                    buyer_TE_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    requiredDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    customerInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orderStatusId = table.Column<int>(type: "int", nullable: false),
                    orderFulfilmentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                    table.ForeignKey(
                        name: "FK_Order_orderStatusId",
                        column: x => x.orderStatusId,
                        principalSchema: "dbo",
                        principalTable: "OrderStatus",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Genus_Plant",
                schema: "plt",
                columns: table => new
                {
                    genusId = table.Column<int>(type: "int", nullable: false),
                    plantId = table.Column<long>(type: "bigint", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genus_Plant", x => new { x.genusId, x.plantId });
                    table.ForeignKey(
                        name: "FK_Genus_Plant_Genus",
                        column: x => x.genusId,
                        principalSchema: "plt",
                        principalTable: "Genus",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Genus_Plant_Plant",
                        column: x => x.plantId,
                        principalSchema: "plt",
                        principalTable: "Plant",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "PermissionDetail",
                schema: "sec",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    securityGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    applicationSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    allowedView = table.Column<bool>(type: "bit", nullable: false),
                    allowedAdd = table.Column<bool>(type: "bit", nullable: false),
                    allowedUpdate = table.Column<bool>(type: "bit", nullable: false),
                    allowedDelete = table.Column<bool>(type: "bit", nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_PermissionDetail_ApplicationSection",
                        column: x => x.applicationSectionId,
                        principalSchema: "sec",
                        principalTable: "ApplicationSection",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_PermissionDetail_SecurityGroup",
                        column: x => x.securityGroupId,
                        principalSchema: "sec",
                        principalTable: "SecurityGroup",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Plant_Species",
                schema: "plt",
                columns: table => new
                {
                    plantId = table.Column<long>(type: "bigint", nullable: false),
                    speciesId = table.Column<long>(type: "bigint", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant_Species", x => new { x.plantId, x.speciesId });
                    table.ForeignKey(
                        name: "FK_Plant_Species_Plant",
                        column: x => x.plantId,
                        principalSchema: "plt",
                        principalTable: "Plant",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Plant_Species_Species",
                        column: x => x.speciesId,
                        principalSchema: "plt",
                        principalTable: "Species",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Kingdom_SubKingdom",
                schema: "plt",
                columns: table => new
                {
                    kingdomId = table.Column<int>(type: "int", nullable: false),
                    subKingdomId = table.Column<int>(type: "int", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kingdom_SubKingdom", x => new { x.kingdomId, x.subKingdomId });
                    table.ForeignKey(
                        name: "FK_Kingdom_SubKingdom_Kingdom",
                        column: x => x.kingdomId,
                        principalSchema: "plt",
                        principalTable: "Kingdom",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Kingdom_SubKingdom_SubKingdom",
                        column: x => x.subKingdomId,
                        principalSchema: "plt",
                        principalTable: "SubKingdom",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "SubKingdom_Division",
                schema: "plt",
                columns: table => new
                {
                    subKingdomId = table.Column<int>(type: "int", nullable: false),
                    divisionId = table.Column<int>(type: "int", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubKingdom_Division", x => new { x.subKingdomId, x.divisionId });
                    table.ForeignKey(
                        name: "FK_SubKingdom_Division_Division",
                        column: x => x.divisionId,
                        principalSchema: "plt",
                        principalTable: "Division",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_SubKingdom_Division_SubKingdom",
                        column: x => x.subKingdomId,
                        principalSchema: "plt",
                        principalTable: "SubKingdom",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "cmd",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    commodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    shortDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    fullDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    consumableId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    datePackaged = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    quantityInStock = table.Column<int>(type: "int", nullable: false),
                    packageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    priceExclVatTax_moneyUnits = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    vat_pct = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    tax_pct = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    allowDiscount = table.Column<bool>(type: "bit", nullable: true),
                    isOnSale = table.Column<bool>(type: "bit", nullable: true),
                    discount_pct = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    fixedPrice_moneyUnits = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    newPriceTotal = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    saleEndDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id);
                    table.ForeignKey(
                        name: "FK_Product_Commodity",
                        column: x => x.commodityId,
                        principalSchema: "cmd",
                        principalTable: "Commodity",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Product_Consumable",
                        column: x => x.consumableId,
                        principalSchema: "cmd",
                        principalTable: "Consumable",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Product_Package",
                        column: x => x.packageId,
                        principalSchema: "cmd",
                        principalTable: "Packaging",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "AvailabilitySchedule",
                schema: "cmd",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    commodityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    deliveryConfigId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    specificDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    recurring = table.Column<bool>(type: "bit", nullable: true),
                    dayOfTheWeek = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    dayOfTheMonth = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    dayOfTheYear = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    driverUserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailabilitySchedule", x => x.id);
                    table.ForeignKey(
                        name: "FK_AvailabilitySchedule_Commodity",
                        column: x => x.commodityId,
                        principalSchema: "cmd",
                        principalTable: "Commodity",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_AvailabilitySchedule_DeliveryConfig",
                        column: x => x.deliveryConfigId,
                        principalSchema: "cmd",
                        principalTable: "DeliveryConfig",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Zone",
                schema: "frm",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    farmId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    managerBaseUserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    classificationTypeId = table.Column<int>(type: "int", nullable: false),
                    climateTypeId = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    totalAvailableSpace_m2 = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    farmOrder = table.Column<int>(type: "int", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.id);
                    table.ForeignKey(
                        name: "FK_Zone_classificationTypeId",
                        column: x => x.classificationTypeId,
                        principalSchema: "dbo",
                        principalTable: "ZoneClassification",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Zone_climateTypeId",
                        column: x => x.climateTypeId,
                        principalSchema: "dbo",
                        principalTable: "ZoneClimateType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Zone_farmId",
                        column: x => x.farmId,
                        principalSchema: "frm",
                        principalTable: "Farm",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Response",
                schema: "log",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    feedbackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    responderUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    responseText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => x.id);
                    table.ForeignKey(
                        name: "FK_Response_Feedback",
                        column: x => x.feedbackId,
                        principalSchema: "log",
                        principalTable: "Feedback",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "TraderEntity",
                schema: "trd",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    traderTypeId = table.Column<int>(type: "int", nullable: false),
                    locationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    contactDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    logoImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    vatNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('Not Supplied')"),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraderEntity", x => x.id);
                    table.ForeignKey(
                        name: "FK_TraderEntity_TraderContactDetail",
                        column: x => x.contactDetailId,
                        principalSchema: "trd",
                        principalTable: "TraderContactDetail",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TraderEntity_TraderLocation",
                        column: x => x.locationId,
                        principalSchema: "trd",
                        principalTable: "TraderLocation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TraderEntity_TraderType",
                        column: x => x.traderTypeId,
                        principalSchema: "dbo",
                        principalTable: "TraderType",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Logistic",
                schema: "mar",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    orderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    deliveryConfigId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tripCostper_xKm = table.Column<decimal>(type: "money", nullable: true),
                    driverCost = table.Column<decimal>(type: "money", nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logistic", x => x.id);
                    table.ForeignKey(
                        name: "FK_Logistics_orderId",
                        column: x => x.orderId,
                        principalSchema: "mar",
                        principalTable: "Order",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                schema: "mar",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    orderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    productId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    priceEach = table.Column<decimal>(type: "money", nullable: false),
                    currencyISO4217Id = table.Column<int>(type: "int", nullable: false),
                    customPriceValue = table.Column<decimal>(type: "money", nullable: true),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_currencyISO4217Id",
                        column: x => x.currencyISO4217Id,
                        principalSchema: "dbo",
                        principalTable: "CurrencyISO4217",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_OrderProducts_orderId",
                        column: x => x.orderId,
                        principalSchema: "mar",
                        principalTable: "Order",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                schema: "mar",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    orderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    currencyISO4217Id = table.Column<int>(type: "int", nullable: false),
                    paymentTypeId = table.Column<int>(type: "int", nullable: false),
                    depositAmount = table.Column<decimal>(type: "money", nullable: false),
                    isPaidInFull = table.Column<bool>(type: "bit", nullable: false),
                    outstandingAmount = table.Column<decimal>(type: "money", nullable: true),
                    paymentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    paidBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Order_currencyISO4217Id",
                        column: x => x.currencyISO4217Id,
                        principalSchema: "dbo",
                        principalTable: "CurrencyISO4217",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Order_orderId",
                        column: x => x.orderId,
                        principalSchema: "mar",
                        principalTable: "Order",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Order_paymentTypeId",
                        column: x => x.paymentTypeId,
                        principalSchema: "dbo",
                        principalTable: "PaymentType",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "GrowSpace",
                schema: "frm",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    zoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    assignedWorkerId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    setupTypeId = table.Column<int>(type: "int", nullable: false),
                    growSpaceTypeId = table.Column<int>(type: "int", nullable: false),
                    growMediumTypeId = table.Column<int>(type: "int", nullable: false),
                    lightSourceTypeId = table.Column<int>(type: "int", nullable: false),
                    orientationFromLightSource = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    totalAvailableSpace_m2 = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    zoneOrder = table.Column<int>(type: "int", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowSpace", x => x.id);
                    table.ForeignKey(
                        name: "FK_GrowSpace_growmediumTypeId",
                        column: x => x.growMediumTypeId,
                        principalSchema: "dbo",
                        principalTable: "GrowMediumType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_GrowSpace_growSpaceTypeId",
                        column: x => x.growSpaceTypeId,
                        principalSchema: "dbo",
                        principalTable: "GrowSpaceType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_GrowSpace_lightSourceTypeId",
                        column: x => x.lightSourceTypeId,
                        principalSchema: "dbo",
                        principalTable: "GrowSpaceLightSourceType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_GrowSpace_zoneId",
                        column: x => x.zoneId,
                        principalSchema: "frm",
                        principalTable: "Zone",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Zone_setupTypeIdId",
                        column: x => x.setupTypeId,
                        principalSchema: "dbo",
                        principalTable: "GrowSpaceSetupType",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "GrowSpaceDatum",
                schema: "log",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    growSpaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    entryTypeId = table.Column<int>(type: "int", nullable: false),
                    phLevel = table.Column<decimal>(type: "decimal(6,4)", nullable: false),
                    temperature_C = table.Column<decimal>(name: "temperature_°C", type: "decimal(7,3)", nullable: false),
                    humidity_gpm3 = table.Column<decimal>(type: "decimal(7,3)", nullable: false),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrowSpaceDatum", x => x.id);
                    table.ForeignKey(
                        name: "FK_GrowSpaceDatum_entryTypeId",
                        column: x => x.entryTypeId,
                        principalSchema: "dbo",
                        principalTable: "GrowSpaceDataEntryType",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_GrowSpaceDatum_growSpaceId",
                        column: x => x.growSpaceId,
                        principalSchema: "frm",
                        principalTable: "GrowSpace",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "SubArea",
                schema: "frm",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    growSpaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cropId = table.Column<long>(type: "bigint", nullable: true),
                    plantSpacing_cm = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    numberOfSeeds = table.Column<int>(type: "int", nullable: false),
                    startPosition = table.Column<int>(type: "int", nullable: false),
                    datePlanted = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    estHarvestDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    growSpaceOrder = table.Column<int>(type: "int", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubArea", x => x.id);
                    table.ForeignKey(
                        name: "FK_SubArea_growSpaceId",
                        column: x => x.growSpaceId,
                        principalSchema: "frm",
                        principalTable: "GrowSpace",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "SubAreaHarvestDatum",
                schema: "log",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    subAreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    actualPhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    plantId = table.Column<long>(type: "bigint", nullable: true),
                    dateHarvested = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    itemCountTotal = table.Column<int>(type: "int", nullable: true),
                    length = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    width = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    height = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    weight = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    volume = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    quantityGrade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    storageDetails = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    synonyms = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    varieties = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    naturalRange = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    uses = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    nutrition = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    production = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    reproduction = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cultivation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    pestsAndDiseases = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    storageAndTransport = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ecology = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    botany = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    history = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    userCreated = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    userModified = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAreaHarvestDatum", x => x.id);
                    table.ForeignKey(
                        name: "FK_SubAreaHarvestDatum_SubArea",
                        column: x => x.subAreaId,
                        principalSchema: "frm",
                        principalTable: "SubArea",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "SubAreaPlantfoodDatum",
                schema: "log",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    subAreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nutrientDetails = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAreaPlantfoodDatum", x => x.id);
                    table.ForeignKey(
                        name: "FK_SubAreaPlantfoodDatum_subAreaId",
                        column: x => x.subAreaId,
                        principalSchema: "frm",
                        principalTable: "SubArea",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "SubAreaStatusDatum",
                schema: "log",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    subAreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cropPhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    cropLifeCycleStageId = table.Column<int>(type: "int", nullable: false),
                    health = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAreaStatusDatum", x => x.id);
                    table.ForeignKey(
                        name: "FK_SubAreaStatusDatum_cropLifeCycleStageId",
                        column: x => x.cropLifeCycleStageId,
                        principalSchema: "dbo",
                        principalTable: "CropLifeCycleStage",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_SubAreaStatusDatum_subAreaId",
                        column: x => x.subAreaId,
                        principalSchema: "frm",
                        principalTable: "SubArea",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "SubAreaWaterDatum",
                schema: "log",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    subAreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    amount_ml = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    duration_Time = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01 00:00:00.000')"),
                    rowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAreaWaterDatum", x => x.id);
                    table.ForeignKey(
                        name: "FK_SubAreaWaterDatum_subAreaId",
                        column: x => x.subAreaId,
                        principalSchema: "frm",
                        principalTable: "SubArea",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionHistory_baseUserId",
                schema: "log",
                table: "ActionHistory",
                column: "baseUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionHistory_traderEntityId",
                schema: "log",
                table: "ActionHistory",
                column: "traderEntityId");

            migrationBuilder.CreateIndex(
                name: "UQ_ActionHistory_id",
                schema: "log",
                table: "ActionHistory",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_ApplicationSection_Name",
                schema: "sec",
                table: "ApplicationSection",
                column: "name",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySchedule_commodityId",
                schema: "cmd",
                table: "AvailabilitySchedule",
                column: "commodityId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySchedule_deliveryConfigId",
                schema: "cmd",
                table: "AvailabilitySchedule",
                column: "deliveryConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySchedule_driverUserId",
                schema: "cmd",
                table: "AvailabilitySchedule",
                column: "driverUserId");

            migrationBuilder.CreateIndex(
                name: "UQ_AvailabilitySchedule_id",
                schema: "cmd",
                table: "AvailabilitySchedule",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_traderEntityId",
                schema: "cmd",
                table: "Commodity",
                column: "traderEntityId");

            migrationBuilder.CreateIndex(
                name: "UQ_Commodity_id",
                schema: "cmd",
                table: "Commodity",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Consumable_commodityId",
                schema: "cmd",
                table: "Consumable",
                column: "commodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumable_harvestId",
                schema: "cmd",
                table: "Consumable",
                column: "harvestId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumable_plantId",
                schema: "cmd",
                table: "Consumable",
                column: "plantId");

            migrationBuilder.CreateIndex(
                name: "UQ_Consumable_id",
                schema: "cmd",
                table: "Consumable",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Credit_creditorId",
                schema: "mar",
                table: "Credit",
                column: "creditorId");

            migrationBuilder.CreateIndex(
                name: "IX_Credit_currencyISO4217Id",
                schema: "mar",
                table: "Credit",
                column: "currencyISO4217Id");

            migrationBuilder.CreateIndex(
                name: "IX_Credit_debtorId",
                schema: "mar",
                table: "Credit",
                column: "debtorId");

            migrationBuilder.CreateIndex(
                name: "UQ_Credit_id",
                schema: "mar",
                table: "Credit",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_CropLifeCycleStage_id",
                schema: "dbo",
                table: "CropLifeCycleStage",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_CurrencyISO4217_id",
                schema: "dbo",
                table: "CurrencyISO4217",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryConfig_commodityId",
                schema: "cmd",
                table: "DeliveryConfig",
                column: "commodityId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryConfig_deliveryMethodId",
                schema: "cmd",
                table: "DeliveryConfig",
                column: "deliveryMethodId");

            migrationBuilder.CreateIndex(
                name: "UQ_DeliveryConfig_id",
                schema: "cmd",
                table: "DeliveryConfig",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_DeliveryMethod_id",
                schema: "dbo",
                table: "DeliveryMethod",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_Division_id",
                schema: "plt",
                table: "Division",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Division_DivisionClass_divisionClassId",
                schema: "plt",
                table: "Division_DivisionClass",
                column: "divisionClassId");

            migrationBuilder.CreateIndex(
                name: "UQ_Division_DivisionClass_ID",
                schema: "plt",
                table: "Division_DivisionClass",
                columns: new[] { "divisionId", "divisionClassId" },
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_DivisionClass_id",
                schema: "plt",
                table: "DivisionClass",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_DivisionClass_DivisionOrder_divisionOrderId",
                schema: "plt",
                table: "DivisionClass_DivisionOrder",
                column: "divisionOrderId");

            migrationBuilder.CreateIndex(
                name: "UQ_DivisionClass_DivisionOrder_ID",
                schema: "plt",
                table: "DivisionClass_DivisionOrder",
                columns: new[] { "divisionClassId", "divisionOrderId" },
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_DivisionOrder_id",
                schema: "plt",
                table: "DivisionOrder",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_DivisionOrder_Family_familyId",
                schema: "plt",
                table: "DivisionOrder_Family",
                column: "familyId");

            migrationBuilder.CreateIndex(
                name: "UQ_DivisionOrder_Family_ID",
                schema: "plt",
                table: "DivisionOrder_Family",
                columns: new[] { "divisionOrderId", "familyId" },
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_Family_id",
                schema: "plt",
                table: "Family",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Family_Genus_genusId",
                schema: "plt",
                table: "Family_Genus",
                column: "genusId");

            migrationBuilder.CreateIndex(
                name: "UQ_Family_Genus_ID",
                schema: "plt",
                table: "Family_Genus",
                columns: new[] { "familyId", "genusId" },
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Farm_agricultureApproachId",
                schema: "frm",
                table: "Farm",
                column: "agricultureApproachId");

            migrationBuilder.CreateIndex(
                name: "IX_Farm_cultureId",
                schema: "frm",
                table: "Farm",
                column: "cultureId");

            migrationBuilder.CreateIndex(
                name: "IX_Farm_traderEntityId",
                schema: "frm",
                table: "Farm",
                column: "traderEntityId");

            migrationBuilder.CreateIndex(
                name: "UQ_Farm_id",
                schema: "frm",
                table: "Farm",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_FarmAgriculture_id",
                schema: "dbo",
                table: "FarmAgriculture",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_FarmCulture_id",
                schema: "dbo",
                table: "FarmCulture",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_feedbackCategoryId",
                schema: "log",
                table: "Feedback",
                column: "feedbackCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_feedbackMetadataId",
                schema: "log",
                table: "Feedback",
                column: "feedbackMetadataId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_feedbackTypeId",
                schema: "log",
                table: "Feedback",
                column: "feedbackTypeId");

            migrationBuilder.CreateIndex(
                name: "UQ_Feedback_id",
                schema: "log",
                table: "Feedback",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_FeedbackCategory_Name",
                schema: "dbo",
                table: "FeedbackCategory",
                column: "name",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_FeedbackMetadata_id",
                schema: "log",
                table: "FeedbackMetadata",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_FeedbackType_Name",
                schema: "dbo",
                table: "FeedbackType",
                column: "name",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_Genus_id",
                schema: "plt",
                table: "Genus",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Genus_Plant_plantId",
                schema: "plt",
                table: "Genus_Plant",
                column: "plantId");

            migrationBuilder.CreateIndex(
                name: "UQ_Genus_Plant_ID",
                schema: "plt",
                table: "Genus_Plant",
                columns: new[] { "genusId", "plantId" },
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_GrowMediumDetail_growMediumTypeId",
                schema: "dbo",
                table: "GrowMediumDetail",
                column: "growMediumTypeId");

            migrationBuilder.CreateIndex(
                name: "UQ_GrowMediumDetail_id",
                schema: "dbo",
                table: "GrowMediumDetail",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_GrowMediumType_id",
                schema: "dbo",
                table: "GrowMediumType",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_GrowSpace_assignedWorkerId",
                schema: "frm",
                table: "GrowSpace",
                column: "assignedWorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowSpace_growMediumTypeId",
                schema: "frm",
                table: "GrowSpace",
                column: "growMediumTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowSpace_growSpaceTypeId",
                schema: "frm",
                table: "GrowSpace",
                column: "growSpaceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowSpace_lightSourceTypeId",
                schema: "frm",
                table: "GrowSpace",
                column: "lightSourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowSpace_setupTypeId",
                schema: "frm",
                table: "GrowSpace",
                column: "setupTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowSpace_zoneId",
                schema: "frm",
                table: "GrowSpace",
                column: "zoneId");

            migrationBuilder.CreateIndex(
                name: "UQ_GrowSpace_id",
                schema: "frm",
                table: "GrowSpace",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_GrowSpaceDataEntryType_id",
                schema: "dbo",
                table: "GrowSpaceDataEntryType",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_GrowSpaceDatum_entryTypeId",
                schema: "log",
                table: "GrowSpaceDatum",
                column: "entryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GrowSpaceDatum_growSpaceId",
                schema: "log",
                table: "GrowSpaceDatum",
                column: "growSpaceId");

            migrationBuilder.CreateIndex(
                name: "UQ_GrowSpaceDatum_id",
                schema: "log",
                table: "GrowSpaceDatum",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_GrowSpaceLightSourceType_id",
                schema: "dbo",
                table: "GrowSpaceLightSourceType",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_GrowSpaceSetupType_id",
                schema: "dbo",
                table: "GrowSpaceSetupType",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_GrowSpaceType_id",
                schema: "dbo",
                table: "GrowSpaceType",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_Kingdom_id",
                schema: "plt",
                table: "Kingdom",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Kingdom_SubKingdom_subKingdomId",
                schema: "plt",
                table: "Kingdom_SubKingdom",
                column: "subKingdomId");

            migrationBuilder.CreateIndex(
                name: "UQ_Kingdom_SubKingdom_ID",
                schema: "plt",
                table: "Kingdom_SubKingdom",
                columns: new[] { "kingdomId", "subKingdomId" },
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Logistic_deliveryConfigId",
                schema: "mar",
                table: "Logistic",
                column: "deliveryConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_Logistic_orderId",
                schema: "mar",
                table: "Logistic",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "UQ_Logistic_id",
                schema: "mar",
                table: "Logistic",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_MunicipalityDetail_Name",
                schema: "dbo",
                table: "MunicipalityDetail",
                column: "name",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Order_buyer_TE_Id",
                schema: "mar",
                table: "Order",
                column: "buyer_TE_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_orderStatusId",
                schema: "mar",
                table: "Order",
                column: "orderStatusId");

            migrationBuilder.CreateIndex(
                name: "UQ_Order_id",
                schema: "mar",
                table: "Order",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_currencyISO4217Id",
                schema: "mar",
                table: "OrderProduct",
                column: "currencyISO4217Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_orderId",
                schema: "mar",
                table: "OrderProduct",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_productId",
                schema: "mar",
                table: "OrderProduct",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "UQ_OrderProducts_id",
                schema: "mar",
                table: "OrderProduct",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_OrderStatus_id",
                schema: "dbo",
                table: "OrderStatus",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Packaging_commodityId",
                schema: "cmd",
                table: "Packaging",
                column: "commodityId");

            migrationBuilder.CreateIndex(
                name: "UQ_Packaging_id",
                schema: "cmd",
                table: "Packaging",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_PaidService_id",
                schema: "dbo",
                table: "PaidService",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_currencyISO4217Id",
                schema: "mar",
                table: "Payment",
                column: "currencyISO4217Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_orderId",
                schema: "mar",
                table: "Payment",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_paymentTypeId",
                schema: "mar",
                table: "Payment",
                column: "paymentTypeId");

            migrationBuilder.CreateIndex(
                name: "UQ_Payment_id",
                schema: "mar",
                table: "Payment",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_commodityId",
                schema: "cmd",
                table: "PaymentMethod",
                column: "commodityId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_paymentTypeId",
                schema: "cmd",
                table: "PaymentMethod",
                column: "paymentTypeId");

            migrationBuilder.CreateIndex(
                name: "UQ_PaymentMethod_id",
                schema: "cmd",
                table: "PaymentMethod",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_PaymentType_id",
                schema: "dbo",
                table: "PaymentType",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_PermissionDetail_applicationSectionId",
                schema: "sec",
                table: "PermissionDetail",
                column: "applicationSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionDetail_securityGroupId",
                schema: "sec",
                table: "PermissionDetail",
                column: "securityGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionDetail_userModified",
                schema: "sec",
                table: "PermissionDetail",
                column: "userModified");

            migrationBuilder.CreateIndex(
                name: "UQ_PermissionDetail_id",
                schema: "sec",
                table: "PermissionDetail",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Permit_commodityId",
                schema: "cmd",
                table: "Permit",
                column: "commodityId");

            migrationBuilder.CreateIndex(
                name: "UQ_Permit_id",
                schema: "cmd",
                table: "Permit",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_Plant_id",
                schema: "plt",
                table: "Plant",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Plant_Species_speciesId",
                schema: "plt",
                table: "Plant_Species",
                column: "speciesId");

            migrationBuilder.CreateIndex(
                name: "UQ_Plant_Species_ID",
                schema: "plt",
                table: "Plant_Species",
                columns: new[] { "plantId", "speciesId" },
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Product_commodityId",
                schema: "cmd",
                table: "Product",
                column: "commodityId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_consumableId",
                schema: "cmd",
                table: "Product",
                column: "consumableId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_packageId",
                schema: "cmd",
                table: "Product",
                column: "packageId");

            migrationBuilder.CreateIndex(
                name: "UQ_Product_id",
                schema: "cmd",
                table: "Product",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Response_feedbackId",
                schema: "log",
                table: "Response",
                column: "feedbackId");

            migrationBuilder.CreateIndex(
                name: "UQ_Response_id",
                schema: "log",
                table: "Response",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_SecurityGroup_traderEntityOwnerId",
                schema: "sec",
                table: "SecurityGroup",
                column: "traderEntityOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityGroup_userCreated",
                schema: "sec",
                table: "SecurityGroup",
                column: "userCreated");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityGroup_userModified",
                schema: "sec",
                table: "SecurityGroup",
                column: "userModified");

            migrationBuilder.CreateIndex(
                name: "UQ_SecurityGroup_id",
                schema: "sec",
                table: "SecurityGroup",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_Species_id",
                schema: "plt",
                table: "Species",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_Stock_id",
                schema: "mar",
                table: "Stock",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_SubArea_cropId",
                schema: "frm",
                table: "SubArea",
                column: "cropId");

            migrationBuilder.CreateIndex(
                name: "IX_SubArea_growSpaceId",
                schema: "frm",
                table: "SubArea",
                column: "growSpaceId");

            migrationBuilder.CreateIndex(
                name: "UQ_SubArea_id",
                schema: "frm",
                table: "SubArea",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_SubAreaHarvestDatum_plantId",
                schema: "log",
                table: "SubAreaHarvestDatum",
                column: "plantId");

            migrationBuilder.CreateIndex(
                name: "IX_SubAreaHarvestDatum_subAreaId",
                schema: "log",
                table: "SubAreaHarvestDatum",
                column: "subAreaId");

            migrationBuilder.CreateIndex(
                name: "UQ_SubAreaHarvestDatum_id",
                schema: "log",
                table: "SubAreaHarvestDatum",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_SubAreaPlantfoodDatum_subAreaId",
                schema: "log",
                table: "SubAreaPlantfoodDatum",
                column: "subAreaId");

            migrationBuilder.CreateIndex(
                name: "UQ_SubAreaPlantfoodDatum_id",
                schema: "log",
                table: "SubAreaPlantfoodDatum",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_SubAreaStatusDatum_cropLifeCycleStageId",
                schema: "log",
                table: "SubAreaStatusDatum",
                column: "cropLifeCycleStageId");

            migrationBuilder.CreateIndex(
                name: "IX_SubAreaStatusDatum_subAreaId",
                schema: "log",
                table: "SubAreaStatusDatum",
                column: "subAreaId");

            migrationBuilder.CreateIndex(
                name: "UQ_SubAreaStatusDatum_id",
                schema: "log",
                table: "SubAreaStatusDatum",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_SubAreaWaterDatum_subAreaId",
                schema: "log",
                table: "SubAreaWaterDatum",
                column: "subAreaId");

            migrationBuilder.CreateIndex(
                name: "UQ_SubAreaWaterDatum_id",
                schema: "log",
                table: "SubAreaWaterDatum",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_SubKingdom_id",
                schema: "plt",
                table: "SubKingdom",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_SubKingdom_Division_divisionId",
                schema: "plt",
                table: "SubKingdom_Division",
                column: "divisionId");

            migrationBuilder.CreateIndex(
                name: "UQ_SubKingdom_Division_ID",
                schema: "plt",
                table: "SubKingdom_Division",
                columns: new[] { "subKingdomId", "divisionId" },
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_SystemParameter_Name",
                schema: "dbo",
                table: "SystemParameter",
                column: "name",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_TraderContactDetail_userModified",
                schema: "trd",
                table: "TraderContactDetail",
                column: "userModified");

            migrationBuilder.CreateIndex(
                name: "UQ_TraderContactDetail_id",
                schema: "trd",
                table: "TraderContactDetail",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_TraderEntity_contactDetailId",
                schema: "trd",
                table: "TraderEntity",
                column: "contactDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_TraderEntity_locationId",
                schema: "trd",
                table: "TraderEntity",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_TraderEntity_traderTypeId",
                schema: "trd",
                table: "TraderEntity",
                column: "traderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TraderEntity_userCreated",
                schema: "trd",
                table: "TraderEntity",
                column: "userCreated");

            migrationBuilder.CreateIndex(
                name: "IX_TraderEntity_userModified",
                schema: "trd",
                table: "TraderEntity",
                column: "userModified");

            migrationBuilder.CreateIndex(
                name: "UQ_TraderEntity_id",
                schema: "trd",
                table: "TraderEntity",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_TraderEntitySettingsDatum_id",
                schema: "acc",
                table: "TraderEntitySettingsDatum",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_TraderLocation_municipalityId",
                schema: "trd",
                table: "TraderLocation",
                column: "municipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_TraderLocation_userModified",
                schema: "trd",
                table: "TraderLocation",
                column: "userModified");

            migrationBuilder.CreateIndex(
                name: "UQ_TraderLocation_id",
                schema: "trd",
                table: "TraderLocation",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_TraderType_Name",
                schema: "dbo",
                table: "TraderType",
                column: "name",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_TrefleData_id",
                schema: "dbo",
                table: "TrefleData",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_User_SecurityGroup_securityGroupId",
                schema: "acc",
                table: "User_SecurityGroup",
                column: "securityGroupId");

            migrationBuilder.CreateIndex(
                name: "UQ_User_SecurityGroup_Id",
                schema: "acc",
                table: "User_SecurityGroup",
                columns: new[] { "userBaseId", "securityGroupId" },
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_User_TraderEntity_traderEntityId",
                schema: "acc",
                table: "User_TraderEntity",
                column: "traderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_User_TraderEntity_traderEntitySettingsDatumId",
                schema: "acc",
                table: "User_TraderEntity",
                column: "traderEntitySettingsDatumId");

            migrationBuilder.CreateIndex(
                name: "UQ_User_TraderEntity_Id",
                schema: "acc",
                table: "User_TraderEntity",
                columns: new[] { "userBaseId", "traderEntityId" },
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_Wishlist_id",
                schema: "mar",
                table: "Wishlist",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_Zone_classificationTypeId",
                schema: "frm",
                table: "Zone",
                column: "classificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Zone_climateTypeId",
                schema: "frm",
                table: "Zone",
                column: "climateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Zone_farmId",
                schema: "frm",
                table: "Zone",
                column: "farmId");

            migrationBuilder.CreateIndex(
                name: "IX_Zone_managerBaseUserId",
                schema: "frm",
                table: "Zone",
                column: "managerBaseUserId");

            migrationBuilder.CreateIndex(
                name: "UQ_Zone_id",
                schema: "frm",
                table: "Zone",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_ZoneClassification_id",
                schema: "dbo",
                table: "ZoneClassification",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "UQ_ZoneClimatType_id",
                schema: "dbo",
                table: "ZoneClimateType",
                column: "id",
                unique: true)
                .Annotation("SqlServer:FillFactor", 90);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionHistory",
                schema: "log");

            migrationBuilder.DropTable(
                name: "AvailabilitySchedule",
                schema: "cmd");

            migrationBuilder.DropTable(
                name: "Credit",
                schema: "mar");

            migrationBuilder.DropTable(
                name: "Division_DivisionClass",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "DivisionClass_DivisionOrder",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "DivisionOrder_Family",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "Family_Genus",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "Genus_Plant",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "GrowMediumDetail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GrowSpaceDatum",
                schema: "log");

            migrationBuilder.DropTable(
                name: "Kingdom_SubKingdom",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "Logistic",
                schema: "mar");

            migrationBuilder.DropTable(
                name: "OrderProduct",
                schema: "mar");

            migrationBuilder.DropTable(
                name: "PaidService",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Payment",
                schema: "mar");

            migrationBuilder.DropTable(
                name: "PaymentMethod",
                schema: "cmd");

            migrationBuilder.DropTable(
                name: "PermissionDetail",
                schema: "sec");

            migrationBuilder.DropTable(
                name: "Permit",
                schema: "cmd");

            migrationBuilder.DropTable(
                name: "Plant_Species",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "cmd");

            migrationBuilder.DropTable(
                name: "Response",
                schema: "log");

            migrationBuilder.DropTable(
                name: "Stock",
                schema: "mar");

            migrationBuilder.DropTable(
                name: "SubAreaHarvestDatum",
                schema: "log");

            migrationBuilder.DropTable(
                name: "SubAreaPlantfoodDatum",
                schema: "log");

            migrationBuilder.DropTable(
                name: "SubAreaStatusDatum",
                schema: "log");

            migrationBuilder.DropTable(
                name: "SubAreaWaterDatum",
                schema: "log");

            migrationBuilder.DropTable(
                name: "SubKingdom_Division",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "SystemParameter",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TraderEntity",
                schema: "trd");

            migrationBuilder.DropTable(
                name: "TraderEntitySettingsDatum",
                schema: "acc");

            migrationBuilder.DropTable(
                name: "TrefleData",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "User_SecurityGroup",
                schema: "acc");

            migrationBuilder.DropTable(
                name: "User_TraderEntity",
                schema: "acc");

            migrationBuilder.DropTable(
                name: "Wishlist",
                schema: "mar");

            migrationBuilder.DropTable(
                name: "DeliveryConfig",
                schema: "cmd");

            migrationBuilder.DropTable(
                name: "DivisionClass",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "DivisionOrder",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "Family",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "Genus",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "GrowSpaceDataEntryType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Kingdom",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "CurrencyISO4217",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "mar");

            migrationBuilder.DropTable(
                name: "PaymentType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ApplicationSection",
                schema: "sec");

            migrationBuilder.DropTable(
                name: "SecurityGroup",
                schema: "sec");

            migrationBuilder.DropTable(
                name: "Plant",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "Species",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "Consumable",
                schema: "cmd");

            migrationBuilder.DropTable(
                name: "Packaging",
                schema: "cmd");

            migrationBuilder.DropTable(
                name: "Feedback",
                schema: "log");

            migrationBuilder.DropTable(
                name: "CropLifeCycleStage",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SubArea",
                schema: "frm");

            migrationBuilder.DropTable(
                name: "Division",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "SubKingdom",
                schema: "plt");

            migrationBuilder.DropTable(
                name: "TraderContactDetail",
                schema: "trd");

            migrationBuilder.DropTable(
                name: "TraderLocation",
                schema: "trd");

            migrationBuilder.DropTable(
                name: "TraderType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DeliveryMethod",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrderStatus",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Commodity",
                schema: "cmd");

            migrationBuilder.DropTable(
                name: "FeedbackCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FeedbackMetadata",
                schema: "log");

            migrationBuilder.DropTable(
                name: "FeedbackType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GrowSpace",
                schema: "frm");

            migrationBuilder.DropTable(
                name: "MunicipalityDetail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GrowMediumType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GrowSpaceType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GrowSpaceLightSourceType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Zone",
                schema: "frm");

            migrationBuilder.DropTable(
                name: "GrowSpaceSetupType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ZoneClassification",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ZoneClimateType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Farm",
                schema: "frm");

            migrationBuilder.DropTable(
                name: "FarmAgriculture",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FarmCulture",
                schema: "dbo");
        }
    }
}