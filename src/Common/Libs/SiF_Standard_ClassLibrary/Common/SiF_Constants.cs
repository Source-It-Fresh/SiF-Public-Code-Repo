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

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
### ### ###
See LICENSE.txt for more details or visit <https://www.gnu.org/licenses/>
### ### ### ### ### ### ###
*/

//using System.Globalization;
//using Microsoft.Extensions.Localization;

//Inject IStringLocalizer<Constants> _IStringLocalizer

using SourceItFresh.Shared.Helpers;

namespace SourceItFresh.Shared.Common
{
    public static partial class SiF_Constants
    {
        //ToDo: Add Globalization and localization - https://docs.microsoft.com/en-us/aspnet/core/fundamentals/localization?view=aspnetcore-6.0

        public static class MagicNumbers
        {
            public const int HiddenValue = 7;
            public const string ipstack = "GET_YOUR_OWN"; // ToDo: Move ApiKey to Azure private appconfig parm <<<<<<<
            public const string goldpricezApiKey = "GET_YOUR_OWN"; // ToDo: Move ApiKey to Azure private appconfig parm <<<<<<<

            public const string APIKEY = "GET_YOUR_OWN"; // ToDo: Move ApiKey to Azure private appconfig parm <<<<<<<
            public const string mapAPIKEY = "GET_YOUR_OWN"; // ToDo: Move ApiKey to Azure private appconfig parm <<<<<<<

            public const int minLocationAccuracy = 7777;
            public const int maxLocationRetrys = 3;

            public const string newSysGuid = "ABC00777-0330-5005-0123-000000000001";
            public const string defualtUserPassword = "GET_YOUR_OWN";
            public const int maxFreeTraderEntities = 5;

            public const int defaultTextAreaLines = 3;
        }

        public static List<SiF_Link> _MainNavLinks { get; set; } = new List<SiF_Link>
        {
            new SiF_Link
            {
                Name = "info",
                Url = "#",
                Icon = "fas fa-info-circle",
                NestedLinks = new List<SiF_Link>
                {
                    new SiF_Link { Name = "nested1", Url = "https://google.com", Icon = "fas fa-nested1" },
                    new SiF_Link { Name = "nested2", Url = "https://office.com", Icon = "fas fa-nested2" }
                }
            },
            new SiF_Link { Name = "wiki", Url = "https://dev.azure.com/yourorganization/yourproject/_wiki", Icon = "fas fa-book" }
        };

        public static class MudTableConfig
        {
            public static readonly int[] PageSizeOptions = new int[] { 3, 5, 7, 15, 25, 50 };
            public const int RowsPerPage = 7;
            //public const var Breakpoint = Breakpoint.Xs;
            public const bool FixedHeader = true;
            public const bool FixedFooter = true;
            public const bool Dense = true;
            //public const var LoadingProgressColor = Color.Info;
            public const string SortLabel = "Sort By";
            public const bool Hover = true;
            public const bool Striped = true;
            public const bool _Bordered_ = false;
            public const bool _IsEditRowSwitchingBlocked_ = true;
            public const string CommitEditTooltip = "Commit Edit";
            public const bool CanCancelEdit = true;
        }

        //public static class SiteUrls
        //{
        //    // ToDo: Lookup from DB
        //    public const string facebook = "https://www.facebook.com/";
        //    public const string google = "https://accounts.google.com/SignUp";
        //    public const string live = "https://signup.live.com/";
        //}

        public static class Enums
        {
            //    public enum AuthenticationProviders
            //    {
            //        Anonymous = 7,

            //        Facebook = 0,
            //        Google = 1,
            //        Microsoft = 4
            //    }

            public enum Roles
            {
                Owner,
                Admin,
                Moderator,
                Basic,
                Temp
            }

            public static class DemoSetupValues
            {
                public enum MultiplierIdentifier
                {
                    None = -1,
                    Small = 1,
                    Medium = 10,
                    Large = 100,
                    TEST_ALL = 999
                }

                public enum ZoneNames
                {
                    Balcony = 1,
                    BasementCellar = 2,
                    CommunityPark = 3,

                    Backyard = 10,
                    Greenhouse = 20,
                    Rooftop = 30,

                    EstablishedField = 100,
                    ExperimentalField = 200,
                    Orchard = 300
                }

                public enum GrowSpaceNames
                {
                    Pots = 11,
                    Buckets = 12,
                    GrowBags = 13,

                    DarkBox = 21,
                    ServerRack = 22,
                    Microgreens = 23,

                    CornerSection = 31,
                    Pathways = 32,
                    Shed = 33,

                    FoodForrest = 101,
                    GardenBeds = 102,
                    HangWall = 103,

                    HomeUse = 201,
                    ToSell = 202,
                    SproutingSpace = 203,

                    RaisedBeds = 301,
                    Aframes = 302,
                    Greenhouse = 303,

                    Perennials = 1001,
                    Spices = 1002,
                    Nuts = 1003,

                    NoDigRow = 2001,
                    TerraPretaPatch = 2002,
                    GrowBeds = 2003,

                    HillTop = 3001,
                    Peaches = 3002,
                    RiverSide = 3003,
                }

                public enum SubAreaNames
                {
                    RedPlasticPot = 111,
                    LongPotteryPot = 112,
                    DeepCementPot = 113,
                    Flowers = 121,
                    Herbs = 122,
                    Mixed = 123,
                    PerennialsAllYear = 131,
                    chillies = 132,
                    sprouts = 133,
                    Test = 211,
                    Damp = 212,
                    Dry = 213,
                    Tray1 = 221,
                    Tray2 = 222,
                    Tray3 = 223,
                    TrayA = 231,
                    TrayB = 232,
                    TrayC = 233,
                    Members = 311,
                    Volunteers = 312,
                    Rotating = 313,
                    Entrance = 321,
                    Parking = 322,
                    Walkway = 323,
                    Sponsored = 331,
                    Stable = 332,
                    Seedlings = 333,

                    TallBack = 1011,
                    MediumShrubs = 1012,
                    OuterRing = 1013,
                    ClaySection = 1021,
                    Shaded = 1022,
                    Perennials = 1023,
                    LastSun = 1031,
                    HalfShade = 1032,
                    SmallerPots = 1033,
                    CPOH = 2011,
                    BellSiphon = 2012,
                    DripFeed = 2013,
                    Row1 = 2021,
                    Row2 = 2022,
                    Row3 = 2023,
                    stage1 = 2031,
                    stage2 = 2032,
                    stage3 = 2033,
                    FlowerBeds = 3011,
                    Onions = 3012,
                    Carrots = 3013,
                    Cabbage = 3021,
                    KitchenHerbs = 3022,
                    Overflow = 3023,
                    BlueTank = 3031,
                    WhiteTank = 3032,
                    EnclosedTank = 3033,

                    PerennialFlowers = 10011,
                    Fruits = 10012,
                    Expansion = 10013,
                    Ginger = 10021,
                    Garlic = 10022,
                    Pepper = 10023,
                    Almonds = 10031,
                    Walnuts = 10032,
                    Cashew = 10033,
                    row1 = 20011,
                    row2 = 20012,
                    row3 = 20013,
                    GardenBed1 = 20021,
                    GardenBed2 = 20022,
                    GardenBed3 = 20023,
                    Bed_A = 20031,
                    Bed_B = 20032,
                    Bed_C = 20033,
                    Swale_1 = 30011,
                    Swale_2 = 30012,
                    Swale_3 = 30013,
                    TreeRow_1 = 30021,
                    TreeRow_2 = 30022,
                    TreeRow_3 = 30023,
                    WildBerries = 30031,
                    OakTrees = 30032,
                    foodforest = 30033
                }
            }
        }

        public static class LoggerStrings
        {
            public const string Success = @"Successfully {0} {1} with id: '{2}'";
            public const string Failed = @"Failed to {0} {1} with id: '{2}'";

            public const string ModelExceptionErrorMessage = @"{0} - ExceptionErrorMessage: {1}";
            public const string DbUpdateConflictExistingId = @"{0} DbUpdate Conflict - Existing ID.";
            public const string EntryNotFoundOrNotAccessible = @"{0} not found or not accessible.";

            public const string UnableToLoad = @"Unable to load {0} with id: '{1}'";
            public const string Invalid = @"Invalid ModelState with error count of: '{1}'";
            public const string Unexpected = @"Unexpected {0} with value of '{1}'";
        }

        public static class Actions
        {
            public static class Origin
            {
                public const string RazorPage = "RazorPage";
                public const string Service = "Service";
                public const string RazorComponent = "RazorComponent";
                public const string API = "API";
            }

            public static class Service
            {
                public const string Initialize = "Initialize";
                public const string AddAsync = "AddAsync";
                public const string GetAllAsync = "GetAllAsync";
                public const string GetSpecificByIdAsync = "GetSpecificByIdAsync";
                public const string GetCurrent = "GetCurrent";
                public const string UpdateAsync = "UpdateAsync";
                public const string DeleteByIdAsync = "DeleteByIdAsync";
                public const string Exists = "Exists";
                public const string HavePermission = "HavePermission";
                public const string CloneAsync = "CloneAsync";
            }

            public static class Page
            {
                public const string View = "View";
                public const string Delete = "Delete";

                public const string Add = "Add";
                public const string Edit = "Edit";
                public const string Find = "Find";
                public const string Save = "Save";
                public const string Remove = "Remove";
                public const string Copy = "Copy";

                public const string Added = "Added";
                public const string Edited = "Edited";
                public const string Found = "Found";
                public const string Saved = "Saved";
                public const string Removed = "Removed";
                public const string Copied = "Copied";
            }
        }

        public static class KeyWords
        {
            public const string User = "User";
            public const string Users = "Users";
            public const string Role = "Role";
            public const string Roles = "Roles";
            public const string Claim = "Claim";
            public const string Claims = "Claims";

            public const string None = "[None]";
            public const string NotApplicable = "N/A";
            public const string Private = "Private";
            public const string NotGiven = "Not Given";
            public const string New = "New";
        }

        public static class ButtonText
        {
            public const string Create = "Create"; // [+]
            public const string Select = "Select"; // [*]
            public const string Info = "Info";     // [#]
            public const string Update = "Update"; // [~]
            public const string Clone = "Clone";   // [=]
            public const string Delete = "Delete"; // [-]
            public const string Clear = "Clear";   // [_]
            public const string Back = "Back to Previous"; // [<]

            public const string Sell = "Sell";       // [^]
            public const string Buy = "Buy";         // [$]
            public const string Invoice = "Invoice"; // [@]
            public const string Search = "Search";   // [?]
            public const string Filter = "Filter";   // [%]

            public const string deliver = "...."; // [&]
            public const string order = "....";   // [!]
        }

        public static class Areas
        {
            public static class Base
            {
                public const string Discover = "Discover";
                public const string Learn = "Learn";
            }

            public static class Core
            {
                public const string Help = "Help";
                public const string Identity = "Identity";
                public const string Login = "Login";
            }

            public static class Configure
            {
                public const string AddIns = "AddIns";
                public const string Settings = "Settings";
                public const string PaidServices = "PaidServices";
            }

            public static class ManageOrg
            {
                public const string TraderEntity = "TraderEntity";
                public const string ActionLogs = "ActionLogs";
                public const string Accounts = "Accounts";
            }

            public static class Manage
            {
                public const string Farm = "Farm";
                public const string Commodities = "Commodities";
            }

            public static class Market
            {
                public const string Consumer = "Consumer";
                public const string Vendor = "Vendor";
            }
        }

        public static class AreaModels
        {
            public static class Base_Discover
            {
                public const string JargonExplained = "JargonExplained";
                public const string PlantInfoDataBase = "PlantInfoDataBase";

                public const string TrefleData = "TrefleData";
                //public const string TrefleDataCollection = "TrefleDataCollection";

                public const string Division = "Division";
                public const string Divisions = "Divisions";

                public const string Division_DivisionClass = "Division_DivisionClass";
                public const string Division_DivisionClasses = "Division_DivisionClasses";

                public const string DivisionClass = "DivisionClass";
                public const string DivisionClasses = "DivisionClasses";

                public const string DivisionClass_DivisionOrder = "DivisionClass_DivisionOrder";
                public const string DivisionClass_DivisionOrders = "DivisionClass_DivisionOrders";

                public const string DivisionOrder = "DivisionOrder";
                public const string DivisionOrders = "DivisionOrders";

                public const string DivisionOrder_Family = "DivisionOrder_Family";
                public const string DivisionOrder_Families = "DivisionOrder_Families";

                public const string Family = "Family";
                public const string Families = "Families";

                public const string Family_Genus = "Family_Genus";
                public const string Family_Genera = "Family_Genera";

                public const string Genus = "Genus";
                public const string Genuss = "Genera";

                public const string Genus_Plant = "Genus_Plant";
                public const string Genus_Plants = "Genus_Plants";

                public const string Kingdom = "Kingdom";
                public const string Kingdoms = "Kingdoms";

                public const string Kingdom_SubKingdom = "Kingdom_SubKingdom";
                public const string Kingdom_SubKingdoms = "Kingdom_SubKingdoms";

                public const string Plant = "Plant";
                public const string Plants = "Plants";

                public const string Plant_Species = "Plant_Species";
                //public const string Plant_SpeciesCollection = "Plant_SpeciesCollection";

                public const string Species = "Species";
                //public const string SpeciesCollection = "SpeciesCollection";

                public const string SubKingdom = "SubKingdom";
                public const string SubKingdoms = "SubKingdoms";

                public const string SubKingdom_Division = "SubKingdom_Division";
                public const string SubKingdom_Divisions = "SubKingdom_Divisions";
            }

            public static class Base_Learn
            {
                // [n/a].[none]
                public const string GoldPriceZ = "GoldPriceZ";
            }

            public static class Core_Help
            {
                public const string FeedbackCategory = "FeedbackCategory";
                public const string FeedbackCategories = "FeedbackCategories";

                public const string FeedbackType = "FeedbackType";
                public const string FeedbackTypes = "FeedbackTypes";

                public const string Feedback = "Feedback";
                public const string Feedbacks = "Feedbacks";

                public const string FeedbackMetadata = "FeedbackMetadata";
                //public const string FeedbackMetadataCollection = "FeedbackMetadataCollection";

                public const string Response = "Response";
                public const string Responses = "Responses";
            }

            public static class Core_Identity
            {
                public const string SIF_Role = "SIF_Role";
                public const string SIF_Roles = "SIF_Roles";

                public const string SIF_RoleClaim = "SIF_RoleClaim";
                public const string SIF_RoleClaims = "SIF_RoleClaims";

                public const string SIF_User = "SIF_User";
                public const string SIF_Users = "SIF_Users";

                public const string SIF_UserClaim = "SIF_UserClaim";
                public const string SIF_UserClaims = "SIF_UserClaims";

                public const string SIF_UserLogin = "SIF_UserLogin";
                public const string SIF_UserLogins = "SIF_UserLogins";

                public const string SIF_UserRole = "SIF_UserRole";
                public const string SIF_UserRoles = "SIF_UserRoles";

                public const string SIF_UserToken = "SIF_UserToken";
                public const string SIF_UserTokens = "SIF_UserTokens";
            }

            public static class Core_Login
            {
                public const string SetupWizard = "SetupWizard";
                public const string MainLanding = "MainLanding";

                public const string SystemParameter = "SystemParameter";
                public const string SystemParameters = "SystemParameters";

                public const string User_SecurityGroup = "User_SecurityGroup";
                public const string User_SecurityGroups = "User_SecurityGroups";

                public const string User_TraderEntity = "User_TraderEntity";
                public const string User_TraderEntities = "User_TraderEntities";
            }

            public static class Configure_AddIns
            {
                public const string SystemAddins = "SystemAddins";
                public const string ThirdPartyAddins = "ThirdPartyAddins";
            }

            public static class Configure_Settings
            {
                public const string TraderEntitySettingsDatum = "TraderEntitySettingsDatum";
                public const string TraderEntitySettingsData = "TraderEntitySettingsData";
            }

            public static class Configure_PaidServices
            {
                public const string PaidService = "PaidService";
                public const string PaidServices = "PaidServices";
            }

            public static class ManageOrg_TraderEntity
            {
                public const string MunicipalityDetail = "MunicipalityDetail";
                public const string MunicipalityDetails = "MunicipalityDetails";

                public const string TraderType = "TraderType";
                public const string TraderTypes = "TraderTypes";

                public const string TraderContactDetail = "TraderContactDetail";
                public const string TraderContactDetails = "TraderContactDetails";

                public const string TraderEntity = "TraderEntity";
                public const string TraderEntities = "TraderEntities";

                public const string TraderLocation = "TraderLocation";
                public const string TraderLocations = "TraderLocations";
            }

            public static class ManageOrg_ActionLogs
            {
                public const string ActionHistory = "ActionHistory";
                public const string ActionHistories = "ActionHistories";
            }

            public static class ManageOrg_Accounts
            {
                public const string ApplicationSection = "ApplicationSection";
                public const string ApplicationSections = "ApplicationSections";

                public const string PermissionDetail = "PermissionDetail";
                public const string PermissionDetails = "PermissionDetails";

                public const string SecurityGroup = "SecurityGroup";
                public const string SecurityGroups = "SecurityGroups";
            }

            public static class Manage_Farm
            {
                public const string CropLifeCycleStage = "CropLifeCycleStage";
                public const string CropLifeCycleStages = "CropLifeCycleStages";

                public const string FarmAgriculture = "FarmAgriculture";
                public const string FarmAgricultures = "FarmAgricultures";

                public const string FarmCulture = "FarmCulture";
                public const string FarmCultures = "FarmCultures";

                public const string GrowMediumDetail = "GrowMediumDetail";
                public const string GrowMediumDetails = "GrowMediumDetails";

                public const string GrowMediumType = "GrowMediumType";
                public const string GrowMediumTypes = "GrowMediumTypes";

                public const string GrowSpaceDataEntryType = "GrowSpaceDataEntryType";
                public const string GrowSpaceDataEntryTypes = "GrowSpaceDataEntryTypes";

                public const string GrowSpaceLightSourceType = "GrowSpaceLightSourceType";
                public const string GrowSpaceLightSourceTypes = "GrowSpaceLightSourceTypes";

                public const string GrowSpaceSetupType = "GrowSpaceSetupType";
                public const string GrowSpaceSetupTypes = "GrowSpaceSetupTypes";

                public const string GrowSpaceType = "GrowSpaceType";
                public const string GrowSpaceTypes = "GrowSpaceTypes";

                public const string ZoneClassification = "ZoneClassification";
                public const string ZoneClassifications = "ZoneClassifications";

                public const string ZoneClimateType = "ZoneClimateType";
                public const string ZoneClimateTypes = "ZoneClimateTypes";

                public const string Farm = "Farm";
                public const string Farms = "Farms";

                public const string GrowSpace = "GrowSpace";
                public const string GrowSpaces = "GrowSpaces";

                public const string SubArea = "SubArea";
                public const string SubAreas = "SubAreas";

                public const string Zone = "Zone";
                public const string Zones = "Zones";

                public const string GrowSpaceDatum = "GrowSpaceDatum";
                public const string GrowSpaceData = "GrowSpaceData";

                public const string SubAreaHarvestDatum = "SubAreaHarvestDatum";
                public const string SubAreaHarvestData = "SubAreaHarvestData";

                public const string SubAreaPlantfoodDatum = "SubAreaPlantfoodDatum";
                public const string SubAreaPlantfoodData = "SubAreaPlantfoodData";

                public const string SubAreaStatusDatum = "SubAreaStatusDatum";
                public const string SubAreaStatusData = "SubAreaStatusData";

                public const string SubAreaWaterDatum = "SubAreaWaterDatum";
                public const string SubAreaWaterData = "SubAreaWaterData";
            }

            public static class Manage_Commodities
            {
                public const string DeliveryMethod = "DeliveryMethod";
                public const string DeliveryMethods = "DeliveryMethods";

                public const string AvailabilitySchedule = "AvailabilitySchedule";
                public const string AvailabilitySchedules = "AvailabilitySchedules";

                public const string Commodity = "Commodity";
                public const string Commodities = "Commodities";

                public const string Consumable = "Consumable";
                public const string Consumables = "Consumables";

                public const string DeliveryConfig = "DeliveryConfig";
                public const string DeliveryConfigs = "DeliveryConfigs";

                public const string Packaging = "Packaging";
                public const string Packagings = "Packagings";

                public const string PaymentMethod = "PaymentMethod";
                public const string PaymentMethods = "PaymentMethods";

                public const string Permit = "Permit";
                public const string Permits = "Permits";

                public const string Product = "Product";
                public const string Products = "Products";
            }

            public static class Market_Consumer
            {
                public const string Wishlist = "Wishlist";
                public const string Wishlists = "Wishlists";
            }

            public static class Market_Vendor
            {
                public const string CurrencyISO4217 = "CurrencyISO4217";
                public const string CurrencyISO4217s = "CurrencyISO4217s";

                public const string OrderStatus = "OrderStatus";
                public const string OrderStatuses = "OrderStatuses";

                public const string PaymentType = "PaymentType";
                public const string PaymentTypes = "PaymentTypes";

                public const string Credit = "Credit";
                public const string Credits = "Credits";

                public const string Logistic = "Logistic";
                public const string Logistics = "Logistics";

                public const string Order = "Order";
                public const string Orders = "Orders";

                public const string OrderProduct = "OrderProduct";
                public const string OrderProducts = "OrderProducts";

                public const string Payment = "Payment";
                public const string Payments = "Payments";

                public const string Stock = "Stock";
                public const string Stocks = "Stocks";
            }
        }

        public static class ModelDisplayText
        {
            public const string Id = "Id";
            public const string Name = "Name";

            public const string LoadingOrNoDataFound = " No Data Found, Loading...";

            public const string DateCreated = "Date Created";
            public const string UserCreated = "User Created";
            public const string DateModified = "Date Modified";
            public const string UserModified = "User Modified";
        }

        public static class PageSpecific
        {
            public static class TraderLocation
            {
                public const string AutoRefresh = "[*] Auto Refresh Location Data";
                public const string GetGeoLocation = "[*] Get geoLocation from address.";
                public const string GetAddress = "[*] Get address from geoLocation.";
            }
        }
    }
}