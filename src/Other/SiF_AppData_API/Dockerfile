# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Directory.Packages.props", "."]
COPY ["Directory.Build.props", "."]
COPY ["Other/SiF_AppData_API/SiF_AppData_API.csproj", "Other/SiF_AppData_API/"]
COPY ["Common/Libs/SiF_Standard_ClassLibrary/SiF_Standard_ClassLibrary.csproj", "Common/Libs/SiF_Standard_ClassLibrary/"]
COPY ["Modules/Base/Discover/SiF_Base_Discover_API/SiF_Base_Discover_API.csproj", "Modules/Base/Discover/SiF_Base_Discover_API/"]
COPY ["Modules/Base/Discover/SiF_Base_Discover_Context/SiF_Base_Discover_Context.csproj", "Modules/Base/Discover/SiF_Base_Discover_Context/"]
COPY ["Modules/Base/Discover/SiF_Base_Discover_CoreClassLibrary/SiF_Base_Discover_CoreClassLibrary.csproj", "Modules/Base/Discover/SiF_Base_Discover_CoreClassLibrary/"]
COPY ["Modules/Base/Learn/SiF_Base_Learn_API/SiF_Base_Learn_API.csproj", "Modules/Base/Learn/SiF_Base_Learn_API/"]
COPY ["Modules/Base/Learn/SiF_Base_Learn_Context/SiF_Base_Learn_Context.csproj", "Modules/Base/Learn/SiF_Base_Learn_Context/"]
COPY ["Modules/Base/Learn/SiF_Base_Learn_CoreClassLibrary/SiF_Base_Learn_CoreClassLibrary.csproj", "Modules/Base/Learn/SiF_Base_Learn_CoreClassLibrary/"]
COPY ["Modules/Configure/AddIns/SiF_Configure_AddIns_API/SiF_Configure_AddIns_API.csproj", "Modules/Configure/AddIns/SiF_Configure_AddIns_API/"]
COPY ["Modules/Configure/AddIns/SiF_Configure_AddIns_Context/SiF_Configure_AddIns_Context.csproj", "Modules/Configure/AddIns/SiF_Configure_AddIns_Context/"]
COPY ["Modules/Configure/AddIns/SiF_Configure_AddIns_CoreClassLibrary/SiF_Configure_AddIns_CoreClassLibrary.csproj", "Modules/Configure/AddIns/SiF_Configure_AddIns_CoreClassLibrary/"]
COPY ["Modules/Configure/PaidServices/SiF_Configure_PaidServices_API/SiF_Configure_PaidServices_API.csproj", "Modules/Configure/PaidServices/SiF_Configure_PaidServices_API/"]
COPY ["Modules/Configure/PaidServices/SiF_Configure_PaidServices_Context/SiF_Configure_PaidServices_Context.csproj", "Modules/Configure/PaidServices/SiF_Configure_PaidServices_Context/"]
COPY ["Modules/Configure/PaidServices/SiF_Configure_PaidServices_CoreClassLibrary/SiF_Configure_PaidServices_CoreClassLibrary.csproj", "Modules/Configure/PaidServices/SiF_Configure_PaidServices_CoreClassLibrary/"]
COPY ["Modules/Configure/Settings/SiF_Configure_Settings_API/SiF_Configure_Settings_API.csproj", "Modules/Configure/Settings/SiF_Configure_Settings_API/"]
COPY ["Modules/Core/Login/SIF_Core_Login_CoreClassLibrary/SIF_Core_Login_CoreClassLibrary.csproj", "Modules/Core/Login/SIF_Core_Login_CoreClassLibrary/"]
COPY ["Modules/Configure/Settings/SiF_Configure_Settings_Context/SiF_Configure_Settings_Context.csproj", "Modules/Configure/Settings/SiF_Configure_Settings_Context/"]
COPY ["Modules/Configure/Settings/SiF_Configure_Settings_CoreClassLibrary/SiF_Configure_Settings_CoreClassLibrary.csproj", "Modules/Configure/Settings/SiF_Configure_Settings_CoreClassLibrary/"]
COPY ["Modules/Core/Help/SIF_Core_Help_API/SIF_Core_Help_API.csproj", "Modules/Core/Help/SIF_Core_Help_API/"]
COPY ["Modules/Core/Help/SIF_Core_Help_Context/SIF_Core_Help_Context.csproj", "Modules/Core/Help/SIF_Core_Help_Context/"]
COPY ["Modules/Core/Help/SIF_Core_Help_CoreClassLibrary/SIF_Core_Help_CoreClassLibrary.csproj", "Modules/Core/Help/SIF_Core_Help_CoreClassLibrary/"]
COPY ["Modules/Core/Identity/SIF_Core_Identity_API/SIF_Core_Identity_API.csproj", "Modules/Core/Identity/SIF_Core_Identity_API/"]
COPY ["Modules/Core/Identity/SIF_Core_Identity_Context/SIF_Core_Identity_Context.csproj", "Modules/Core/Identity/SIF_Core_Identity_Context/"]
COPY ["Modules/Core/Identity/SIF_Core_Identity_CoreClassLibrary/SIF_Core_Identity_CoreClassLibrary.csproj", "Modules/Core/Identity/SIF_Core_Identity_CoreClassLibrary/"]
COPY ["Modules/Core/Login/SIF_Core_Login_API/SIF_Core_Login_API.csproj", "Modules/Core/Login/SIF_Core_Login_API/"]
COPY ["Modules/Core/Login/SIF_Core_Login_Context/SIF_Core_Login_Context.csproj", "Modules/Core/Login/SIF_Core_Login_Context/"]
COPY ["Modules/ManageOrg/Accounts/SiF_ManageOrg_Accounts_API/SiF_ManageOrg_Accounts_API.csproj", "Modules/ManageOrg/Accounts/SiF_ManageOrg_Accounts_API/"]
COPY ["Modules/ManageOrg/Accounts/SiF_ManageOrg_Accounts_Context/SiF_ManageOrg_Accounts_Context.csproj", "Modules/ManageOrg/Accounts/SiF_ManageOrg_Accounts_Context/"]
COPY ["Modules/ManageOrg/Accounts/SiF_ManageOrg_Accounts_CoreClassLibrary/SiF_ManageOrg_Accounts_CoreClassLibrary.csproj", "Modules/ManageOrg/Accounts/SiF_ManageOrg_Accounts_CoreClassLibrary/"]
COPY ["Modules/ManageOrg/ActionLogs/SiF_ManageOrg_ActionLogs_API/SiF_ManageOrg_ActionLogs_API.csproj", "Modules/ManageOrg/ActionLogs/SiF_ManageOrg_ActionLogs_API/"]
COPY ["Modules/ManageOrg/ActionLogs/SiF_ManageOrg_ActionLogs_Context/SiF_ManageOrg_ActionLogs_Context.csproj", "Modules/ManageOrg/ActionLogs/SiF_ManageOrg_ActionLogs_Context/"]
COPY ["Modules/ManageOrg/ActionLogs/SiF_ManageOrg_ActionLogs_CoreClassLibrary/SiF_ManageOrg_ActionLogs_CoreClassLibrary.csproj", "Modules/ManageOrg/ActionLogs/SiF_ManageOrg_ActionLogs_CoreClassLibrary/"]
COPY ["Modules/ManageOrg/TraderEntity/SiF_ManageOrg_TraderEntity_API/SiF_ManageOrg_TraderEntity_API.csproj", "Modules/ManageOrg/TraderEntity/SiF_ManageOrg_TraderEntity_API/"]
COPY ["Modules/ManageOrg/TraderEntity/SiF_ManageOrg_TraderEntity_Context/SiF_ManageOrg_TraderEntity_Context.csproj", "Modules/ManageOrg/TraderEntity/SiF_ManageOrg_TraderEntity_Context/"]
COPY ["Modules/ManageOrg/TraderEntity/SiF_ManageOrg_TraderEntity_CoreClassLibrary/SiF_ManageOrg_TraderEntity_CoreClassLibrary.csproj", "Modules/ManageOrg/TraderEntity/SiF_ManageOrg_TraderEntity_CoreClassLibrary/"]
COPY ["Modules/Manage/Commodities/SiF_Manage_Commodities_API/SiF_Manage_Commodities_API.csproj", "Modules/Manage/Commodities/SiF_Manage_Commodities_API/"]
COPY ["Modules/Manage/Commodities/SiF_Manage_Commodities_Context/SiF_Manage_Commodities_Context.csproj", "Modules/Manage/Commodities/SiF_Manage_Commodities_Context/"]
COPY ["Modules/Manage/Commodities/SiF_Manage_Commodities_CoreClassLibrary/SiF_Manage_Commodities_CoreClassLibrary.csproj", "Modules/Manage/Commodities/SiF_Manage_Commodities_CoreClassLibrary/"]
COPY ["Modules/Manage/Farm/SiF_Manage_Farm_API/SiF_Manage_Farm_API.csproj", "Modules/Manage/Farm/SiF_Manage_Farm_API/"]
COPY ["Modules/Manage/Farm/SiF_Manage_Farm_Context/SiF_Manage_Farm_Context.csproj", "Modules/Manage/Farm/SiF_Manage_Farm_Context/"]
COPY ["Modules/Manage/Farm/SiF_Manage_Farm_CoreClassLibrary/SiF_Manage_Farm_CoreClassLibrary.csproj", "Modules/Manage/Farm/SiF_Manage_Farm_CoreClassLibrary/"]
COPY ["Modules/Market/Consumer/SiF_Market_Consumer_API/SiF_Market_Consumer_API.csproj", "Modules/Market/Consumer/SiF_Market_Consumer_API/"]
COPY ["Modules/Market/Consumer/SiF_Market_Consumer_Context/SiF_Market_Consumer_Context.csproj", "Modules/Market/Consumer/SiF_Market_Consumer_Context/"]
COPY ["Modules/Market/Consumer/SiF_Market_Consumer_CoreClassLibrary/SiF_Market_Consumer_CoreClassLibrary.csproj", "Modules/Market/Consumer/SiF_Market_Consumer_CoreClassLibrary/"]
COPY ["Modules/Market/Vendor/SiF_Market_Vendor_API/SiF_Market_Vendor_API.csproj", "Modules/Market/Vendor/SiF_Market_Vendor_API/"]
COPY ["Modules/Market/Vendor/SiF_Market_Vendor_Context/SiF_Market_Vendor_Context.csproj", "Modules/Market/Vendor/SiF_Market_Vendor_Context/"]
COPY ["Modules/Market/Vendor/SiF_Market_Vendor_CoreClassLibrary/SiF_Market_Vendor_CoreClassLibrary.csproj", "Modules/Market/Vendor/SiF_Market_Vendor_CoreClassLibrary/"]
RUN dotnet restore "./Other/SiF_AppData_API/SiF_AppData_API.csproj"
COPY . .
WORKDIR "/src/Other/SiF_AppData_API"
RUN dotnet build "./SiF_AppData_API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SiF_AppData_API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SiF_AppData_API.dll"]