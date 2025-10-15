@echo off
@echo This cmd file creates a Data API Builder configuration based on the chosen database objects.
@echo To run the cmd, create an .env file with the following contents:
@echo dab-connection-string=your connection string
@echo ** Make sure to exclude the .env file from source control **
@echo **
dotnet tool install -g Microsoft.DataApiBuilder
dab init -c dab-config.json --database-type mssql --connection-string "@env('dab-connection-string')" --host-mode Development
@echo Adding tables
dab add "SiFRole" --source "[acc].[SiF_Role]" --fields.include "Id,Name,NormalizedName,ConcurrencyStamp" --permissions "anonymous:*" 
dab add "SiFRoleClaim" --source "[acc].[SiF_RoleClaim]" --fields.include "Id,RoleId,ClaimType,ClaimValue" --permissions "anonymous:*" 
dab add "SiFUser" --source "[acc].[SiF_User]" --fields.include "Id,firstName,lastName,ProfilePicture,bio,UserInit,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount" --permissions "anonymous:*" 
dab add "SiFUserClaim" --source "[acc].[SiF_UserClaim]" --fields.include "Id,UserId,ClaimType,ClaimValue" --permissions "anonymous:*" 
dab add "SiFUserLogin" --source "[acc].[SiF_UserLogin]" --fields.include "LoginProvider,ProviderKey,ProviderDisplayName,UserId" --permissions "anonymous:*" 
dab add "SiFUserRole" --source "[acc].[SiF_UserRole]" --fields.include "UserId,RoleId" --permissions "anonymous:*" 
dab add "SiFUserToken" --source "[acc].[SiF_UserToken]" --fields.include "UserId,LoginProvider,Name,Value" --permissions "anonymous:*" 
dab add "TraderEntitySettingsDatum" --source "[acc].[TraderEntitySettingsDatum]" --fields.include "id,name,traderEntity_PrimaryHexColor,traderEntity_SecondaryHexColor,layoutType_Simple,theme_Name,display_Titles,display_InputControlLabels,display_DynamicNav,infoBar_Show,infoBar_ServerTime,infoBar_LocalTime,infoBar_Alerts,infoBar_Weather,titleBar_Show,titleBar_Heading,titleBar_TopNavSubMenus,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "UserSecurityGroup" --source "[acc].[User_SecurityGroup]" --fields.include "userBaseId,securityGroupId,rowVersion" --permissions "anonymous:*" 
dab add "UserTraderEntity" --source "[acc].[User_TraderEntity]" --fields.include "userBaseId,traderEntityId,traderEntitySettingsDatumId,currentContext,rowVersion" --permissions "anonymous:*" 
dab add "AvailabilitySchedule" --source "[cmd].[AvailabilitySchedule]" --fields.include "id,commodityId,deliveryConfigId,name,specificDate,recurring,dayOfTheWeek,dayOfTheMonth,dayOfTheYear,driverUserId,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "Commodity" --source "[cmd].[Commodity]" --fields.include "id,traderEntityId,name,currencyId,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "Consumable" --source "[cmd].[Consumable]" --fields.include "id,commodityId,harvestId,name,actualPhoto,plantId,dateProduced,itemCountTotal,length,width,height,weight,volume,quantityGrade,storageDetails,comments,synonyms,varieties,naturalRange,uses,nutrition,production,reproduction,cultivation,pestsAndDiseases,storageAndTransport,ecology,botany,history,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "DeliveryConfig" --source "[cmd].[DeliveryConfig]" --fields.include "id,commodityId,name,deliveryMethodId,deliveryRange_km,deliveryRangePlotPoints,pricePer_km,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "Packaging" --source "[cmd].[Packaging]" --fields.include "id,commodityId,name,designImage,notSpecified,none,biodegradable,cardboard,recyclablePlastic,toxicPlastic,length,width,height,weight,volume,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "PaymentMethod" --source "[cmd].[PaymentMethod]" --fields.include "id,commodityId,name,paymentTypeId,bankDetails,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "Permit" --source "[cmd].[Permit]" --fields.include "id,commodityId,name,certificateImage,description,issuerOrgName,issuedDate,validFor_day,expirationDate,otherDetails,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "Product" --source "[cmd].[Product]" --fields.include "id,commodityId,name,photo,shortDescription,fullDescription,consumableId,datePackaged,quantityInStock,packageId,priceExclVatTax_moneyUnits,vat_pct,tax_pct,allowDiscount,isOnSale,discount_pct,fixedPrice_moneyUnits,newPriceTotal,saleEndDate,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "CropLifeCycleStage" --source "[dbo].[CropLifeCycleStage]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "CurrencyIso4217" --source "[dbo].[CurrencyISO4217]" --fields.include "id,code,postDecimalDigits,currencyName,usedLocations,rowVersion" --permissions "anonymous:*" 
dab add "DeliveryMethod" --source "[dbo].[DeliveryMethod]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "FarmAgriculture" --source "[dbo].[FarmAgriculture]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "FarmCulture" --source "[dbo].[FarmCulture]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "FeedbackCategory" --source "[dbo].[FeedbackCategory]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "FeedbackType" --source "[dbo].[FeedbackType]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "GrowMediumDetail" --source "[dbo].[GrowMediumDetail]" --fields.include "id,growMediumTypeId,texture,structure,density,porosity,consistency,temperature,colour,resistivity,waterRetention,waterFlow,rowVersion" --permissions "anonymous:*" 
dab add "GrowMediumType" --source "[dbo].[GrowMediumType]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "GrowSpaceDataEntryType" --source "[dbo].[GrowSpaceDataEntryType]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "GrowSpaceLightSourceType" --source "[dbo].[GrowSpaceLightSourceType]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "GrowSpaceSetupType" --source "[dbo].[GrowSpaceSetupType]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "GrowSpaceType" --source "[dbo].[GrowSpaceType]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "MunicipalityDetail" --source "[dbo].[MunicipalityDetail]" --fields.include "id,name,address,municipalityContactDetails,policeContactDetails,ambulanceContactDetails,waterDepartmentContactDetails,electricityDepartmentContactDetails,fireDepartmentContactDetails,rowVersion" --permissions "anonymous:*" 
dab add "OrderStatus" --source "[dbo].[OrderStatus]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "PaidService" --source "[dbo].[PaidService]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "PaymentType" --source "[dbo].[PaymentType]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "SystemParameter" --source "[dbo].[SystemParameter]" --fields.include "id,name,details,value,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "TraderType" --source "[dbo].[TraderType]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "TrefleDatum" --source "[dbo].[TrefleData]" --fields.include "id,scientific_name,rank,genus,family,year,author,bibliography,common_name,family_common_name,image_url,flower_color,flower_conspicuous,foliage_color,foliage_texture,fruit_color,fruit_conspicuous,fruit_months,bloom_months,ground_humidity,growth_form,growth_habit,growth_months,growth_rate,edible_part,vegetable,edible,light,soil_nutriments,soil_salinity,anaerobic_tolerance,atmospheric_humidity,average_height_cm,maximum_height_cm,minimum_root_depth_cm,ph_maximum,ph_minimum,planting_days_to_harvest,planting_description,planting_sowing_description,planting_row_spacing_cm,planting_spread_cm,synonyms,distributions,common_names,url_usda,url_tropicos,url_tela_botanica,url_powo,url_plantnet,url_gbif,url_openfarm,url_catminat,url_wikipedia_en" --permissions "anonymous:*" 
dab add "ZoneClassification" --source "[dbo].[ZoneClassification]" --fields.include "id,name,details,ownerId,rowVersion" --permissions "anonymous:*" 
dab add "ZoneClimateType" --source "[dbo].[ZoneClimateType]" --fields.include "id,name,simple,details,koppenGeiger,rowVersion" --permissions "anonymous:*" 
dab add "ZoneSetupType" --source "[dbo].[ZoneSetupType]" --fields.include "id,name,details,rowVersion" --permissions "anonymous:*" 
dab add "Farm" --source "[frm].[Farm]" --fields.include "id,traderEntityId,name,cultureId,agricultureApproachId,borderDetails,propertyArea_m2,speciesPreference,soilAndGrowMedium,waterManagement,nutrientsManagement,energyManagement,diseaseControlManagement,sustainabilityManagement,pestsManagement,weedsManagement,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "GrowSpace" --source "[frm].[GrowSpace]" --fields.include "id,zoneId,name,assignedWorkerId,setupTypeId,growSpaceTypeId,growMediumTypeId,lightSourceTypeId,orientationFromLightSource,totalAvailableSpace_m2,zoneOrder,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "SubArea" --source "[frm].[SubArea]" --fields.include "id,growSpaceId,name,cropId,plantSpacing_cm,numberOfSeeds,startPosition,datePlanted,estHarvestDate,growSpaceOrder,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "Zone" --source "[frm].[Zone]" --fields.include "id,farmId,name,managerBaseUserId,classificationTypeId,climateTypeId,totalAvailableSpace_m2,farmOrder,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "ActionHistory" --source "[log].[ActionHistory]" --fields.include "id,baseUserId,traderEntityId,actionType,area,rowId,details,dateCreated,rowVersion" --permissions "anonymous:*" 
dab add "Feedback" --source "[log].[Feedback]" --fields.include "id,baseUserId,feedbackTypeId,feedbackCategoryId,applicationVersion,identityName,email,details,feedbackMetadataId,dateCreated,rowVersion" --permissions "anonymous:*" 
dab add "FeedbackMetadatum" --source "[log].[FeedbackMetadata]" --fields.include "id,location,operatingSystem,browser,browserPlugins,cpu,publicIP,connectionSpeed,connectedSocialMediaAcounts,dateCreated,rowVersion" --permissions "anonymous:*" 
dab add "GrowSpaceDatum" --source "[log].[GrowSpaceDatum]" --fields.include "id,growSpaceId,entryTypeId,phLevel,temperature_?C,humidity_gpm3,comment,dateCreated,rowVersion" --permissions "anonymous:*" 
dab add "Response" --source "[log].[Response]" --fields.include "id,feedbackId,responderUserId,responseText,dateCreated,rowVersion" --permissions "anonymous:*" 
dab add "SubAreaHarvestDatum" --source "[log].[SubAreaHarvestDatum]" --fields.include "id,subAreaId,name,actualPhoto,plantId,dateHarvested,itemCountTotal,length,width,height,weight,volume,quantityGrade,storageDetails,comments,synonyms,varieties,naturalRange,uses,nutrition,production,reproduction,cultivation,pestsAndDiseases,storageAndTransport,ecology,botany,history,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "SubAreaPlantfoodDatum" --source "[log].[SubAreaPlantfoodDatum]" --fields.include "id,subAreaId,nutrientDetails,comment,dateCreated,rowVersion" --permissions "anonymous:*" 
dab add "SubAreaStatusDatum" --source "[log].[SubAreaStatusDatum]" --fields.include "id,subAreaId,cropPhoto,cropLifeCycleStageId,health,comment,dateCreated,rowVersion" --permissions "anonymous:*" 
dab add "SubAreaWaterDatum" --source "[log].[SubAreaWaterDatum]" --fields.include "id,subAreaId,amount_ml,duration_Time,comment,dateCreated,rowVersion" --permissions "anonymous:*" 
dab add "Credit" --source "[mar].[Credit]" --fields.include "id,creditorId,debtorId,currencyISO4217Id,amount,details,rowVersion" --permissions "anonymous:*" 
dab add "Logistic" --source "[mar].[Logistic]" --fields.include "id,orderId,deliveryConfigId,tripCostper_xKm,driverCost,details,rowVersion" --permissions "anonymous:*" 
dab add "Order" --source "[mar].[Order]" --fields.include "id,orderPlaced,buyer_TE_Id,requiredDate,customerInstruction,orderStatusId,orderFulfilmentDate,rowVersion" --permissions "anonymous:*" 
dab add "OrderProduct" --source "[mar].[OrderProduct]" --fields.include "id,orderId,productId,quantity,priceEach,currencyISO4217Id,customPriceValue,rowVersion" --permissions "anonymous:*" 
dab add "Payment" --source "[mar].[Payment]" --fields.include "id,orderId,currencyISO4217Id,paymentTypeId,depositAmount,isPaidInFull,outstandingAmount,paymentDate,paidBy,details,rowVersion" --permissions "anonymous:*" 
dab add "Stock" --source "[mar].[Stock]" --fields.include "id,te_id,name,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "Wishlist" --source "[mar].[Wishlist]" --fields.include "id,details,rowVersion" --permissions "anonymous:*" 
dab add "Division" --source "[plt].[Division]" --fields.include "id,name,rowVersion" --permissions "anonymous:*" 
dab add "DivisionDivisionClass" --source "[plt].[Division_DivisionClass]" --fields.include "divisionId,divisionClassId,rowVersion" --permissions "anonymous:*" 
dab add "DivisionClass" --source "[plt].[DivisionClass]" --fields.include "id,name,rowVersion" --permissions "anonymous:*" 
dab add "DivisionClassDivisionOrder" --source "[plt].[DivisionClass_DivisionOrder]" --fields.include "divisionClassId,divisionOrderId,rowVersion" --permissions "anonymous:*" 
dab add "DivisionOrder" --source "[plt].[DivisionOrder]" --fields.include "id,name,rowVersion" --permissions "anonymous:*" 
dab add "DivisionOrderFamily" --source "[plt].[DivisionOrder_Family]" --fields.include "divisionOrderId,familyId,rowVersion" --permissions "anonymous:*" 
dab add "Family" --source "[plt].[Family]" --fields.include "id,name,commonName,rowVersion" --permissions "anonymous:*" 
dab add "FamilyGenu" --source "[plt].[Family_Genus]" --fields.include "familyId,genusId,rowVersion" --permissions "anonymous:*" 
dab add "Genu" --source "[plt].[Genus]" --fields.include "id,name,rowVersion" --permissions "anonymous:*" 
dab add "GenusPlant" --source "[plt].[Genus_Plant]" --fields.include "genusId,plantId,rowVersion" --permissions "anonymous:*" 
dab add "Kingdom" --source "[plt].[Kingdom]" --fields.include "id,name,rowVersion" --permissions "anonymous:*" 
dab add "KingdomSubKingdom" --source "[plt].[Kingdom_SubKingdom]" --fields.include "kingdomId,subKingdomId,rowVersion" --permissions "anonymous:*" 
dab add "Plant" --source "[plt].[Plant]" --fields.include "id,scientificName,commonEnglishName,familyCommonName,imagesUrl,mainSpeciesId,nativeStatus,varieties,subSpecies,hybrids,forms,cultivars,genusId,familyId,divisionOrderId,divisionClassId,divisionId,rowVersion" --permissions "anonymous:*" 
dab add "PlantSpecy" --source "[plt].[Plant_Species]" --fields.include "plantId,speciesId,rowVersion" --permissions "anonymous:*" 
dab add "Species" --source "[plt].[Species]" --fields.include "id,scientificName,commonName,familyCommonName,synonym,imagesUrl,isMainSpecies,mainSpeciesId,type,status,nativeStatus,completeData,specification_Toxicity,specification_ShapeAndOrientation,specification_RegrowthRate,specification_NitrogenFixation,specification_MaxHeightAtBaseAge_cm,specification_MatureHeight_cm,specification_LowGrowingGrass,specification_Lifespan,specification_LeafRetention,specification_KnownAllelopath,specification_GrowthRate,specification_GrowthPeriod,specification_GrowthHabit,specification_GrowthForm,specification_FireResistance,specification_FallConspicuous,specification_CoppicePotential,specification_C_n_ratio,specification_Bloat,soilsAdaptation_Medium,soilsAdaptation_Fine,soilsAdaptation_Coarse,seed_VegetativeSpreadRate,seed_SmallGrain,seed_SeedsPerPound,seed_SeedlingVigor,seed_SpreadRate,seed_CommercialAvailability,seed_BloomPeriod,propagation_Tubers,propagation_Sprigs,propagation_Sod,propagation_Seed,propagation_Cuttings,propagation_Corms,propagation_Container,propagation_Bulbs,propagation_BareRoot,growth_TemperatureMinimum_deg_c,growth_ShadeTolerance,growth_SalinityTolerance,growth_RootDepthMinimum_cm,growth_ResproutAbility,growth_PrecipitationMinimum_cm,growth_PrecipitationMaximum_cm,growth_PlantingDensityMinimum_sqm,growth_PlantingDensityMaximum_sqm,growth_PhMinimum,growth_PhMaximum,growth_MoistureUse,growth_HedgeTolerance,growth_FrostFreeDaysMinimum,growth_FireTolerance,growth_FertilityRequirement,growth_DroughtTolerance,growth_ColdStratificationRequired,growth_CaCO3Tolerance,growth_AnaerobicTolerance,foliage_Texture,foliage_PorositySummer,foliage_PorosityWinter,foliage_Color,fruitOrSeed_Persistence,fruitOrSeed_PeriodBegin,fruitOrSeed_PeriodEnd,fruitOrSeed_Abundance,fruitOrSeed_Conspicuous,fruitOrSeed_Color,flower_Conspicuous,flower_Color,products_Veneer,products_Pulpwood,products_ProteinPotential,products_Post,products_PalatableHuman,products_PalatableGrazeAnimal,products_PalatableBrowseAnimal,products_NurseryStock,products_NavalStore,products_Lumber,products_Fuelwood,products_Fodder,products_ChristmasTree,products_BerryNutSeed,rowVersion" --permissions "anonymous:*" 
dab add "SubKingdom" --source "[plt].[SubKingdom]" --fields.include "id,name,rowVersion" --permissions "anonymous:*" 
dab add "SubKingdomDivision" --source "[plt].[SubKingdom_Division]" --fields.include "subKingdomId,divisionId,rowVersion" --permissions "anonymous:*" 
dab add "ApplicationSection" --source "[sec].[ApplicationSection]" --fields.include "id,path,name,canView,canAdd,canUpdate,canDelete,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "PermissionDetail" --source "[sec].[PermissionDetail]" --fields.include "id,securityGroupId,applicationSectionId,allowedView,allowedAdd,allowedUpdate,allowedDelete,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "SecurityGroup" --source "[sec].[SecurityGroup]" --fields.include "id,name,isSystemConfig,traderEntityOwnerId,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "TraderContactDetail" --source "[trd].[TraderContactDetail]" --fields.include "id,websiteUrl,customerCareEmail,phoneNumber,otherDetails,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "TraderEntity" --source "[trd].[TraderEntity]" --fields.include "id,name,logoImage,traderTypeId,locationId,contactDetailId,vatNumber,dateCreated,userCreated,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
dab add "TraderLocation" --source "[trd].[TraderLocation]" --fields.include "id,gpsCoordinates,mapImage,countryRegion,stateProvince,city,postalCode,addressLine1,addressLine2,building,floorLevel,customDetails,municipalityId,dateModified,userModified,rowVersion" --permissions "anonymous:*" 
@echo Adding views and tables without primary key
@echo Adding relationships
dab update SiFRoleClaim --relationship SiFRole --target.entity SiFRole --cardinality one
dab update SiFRole --relationship SiFRoleClaim --target.entity SiFRoleClaim --cardinality many
dab update SiFUserClaim --relationship SiFUser --target.entity SiFUser --cardinality one
dab update SiFUser --relationship SiFUserClaim --target.entity SiFUserClaim --cardinality many
dab update SiFUserLogin --relationship SiFUser --target.entity SiFUser --cardinality one
dab update SiFUser --relationship SiFUserLogin --target.entity SiFUserLogin --cardinality many
dab update SiFUserRole --relationship SiFRole --target.entity SiFRole --cardinality one
dab update SiFRole --relationship SiFUserRole --target.entity SiFUserRole --cardinality many
dab update SiFUserRole --relationship SiFUser --target.entity SiFUser --cardinality one
dab update SiFUser --relationship SiFUserRole --target.entity SiFUserRole --cardinality many
dab update SiFUserToken --relationship SiFUser --target.entity SiFUser --cardinality one
dab update SiFUser --relationship SiFUserToken --target.entity SiFUserToken --cardinality many
dab update UserSecurityGroup --relationship SecurityGroup --target.entity SecurityGroup --cardinality one
dab update SecurityGroup --relationship UserSecurityGroup --target.entity UserSecurityGroup --cardinality many
dab update UserTraderEntity --relationship TraderEntity --target.entity TraderEntity --cardinality one
dab update TraderEntity --relationship UserTraderEntity --target.entity UserTraderEntity --cardinality many
dab update UserTraderEntity --relationship TraderEntitySettingsDatum --target.entity TraderEntitySettingsDatum --cardinality one
dab update TraderEntitySettingsDatum --relationship UserTraderEntity --target.entity UserTraderEntity --cardinality many
dab update AvailabilitySchedule --relationship Commodity --target.entity Commodity --cardinality one
dab update Commodity --relationship AvailabilitySchedule --target.entity AvailabilitySchedule --cardinality many
dab update Commodity --relationship TraderEntity --target.entity TraderEntity --cardinality one
dab update TraderEntity --relationship Commodity --target.entity Commodity --cardinality many
dab update Consumable --relationship Commodity --target.entity Commodity --cardinality one
dab update Commodity --relationship Consumable --target.entity Consumable --cardinality many
dab update Consumable --relationship Plant --target.entity Plant --cardinality one
dab update Plant --relationship Consumable --target.entity Consumable --cardinality many
dab update Consumable --relationship SubAreaHarvestDatum --target.entity SubAreaHarvestDatum --cardinality one
dab update SubAreaHarvestDatum --relationship Consumable --target.entity Consumable --cardinality many
dab update DeliveryConfig --relationship Commodity --target.entity Commodity --cardinality one
dab update Commodity --relationship DeliveryConfig --target.entity DeliveryConfig --cardinality many
dab update DeliveryConfig --relationship DeliveryMethod --target.entity DeliveryMethod --cardinality one
dab update DeliveryMethod --relationship DeliveryConfig --target.entity DeliveryConfig --cardinality many
dab update Packaging --relationship Commodity --target.entity Commodity --cardinality one
dab update Commodity --relationship Packaging --target.entity Packaging --cardinality many
dab update PaymentMethod --relationship Commodity --target.entity Commodity --cardinality one
dab update Commodity --relationship PaymentMethod --target.entity PaymentMethod --cardinality many
dab update PaymentMethod --relationship PaymentType --target.entity PaymentType --cardinality one
dab update PaymentType --relationship PaymentMethod --target.entity PaymentMethod --cardinality many
dab update Permit --relationship Commodity --target.entity Commodity --cardinality one
dab update Commodity --relationship Permit --target.entity Permit --cardinality many
dab update Product --relationship Commodity --target.entity Commodity --cardinality one
dab update Commodity --relationship Product --target.entity Product --cardinality many
dab update Product --relationship Consumable --target.entity Consumable --cardinality one
dab update Consumable --relationship Product --target.entity Product --cardinality many
dab update Product --relationship Packaging --target.entity Packaging --cardinality one
dab update Packaging --relationship Product --target.entity Product --cardinality many
dab update GrowMediumDetail --relationship GrowMediumType --target.entity GrowMediumType --cardinality one
dab update GrowMediumType --relationship GrowMediumDetail --target.entity GrowMediumDetail --cardinality many
dab update Farm --relationship FarmAgriculture --target.entity FarmAgriculture --cardinality one
dab update FarmAgriculture --relationship Farm --target.entity Farm --cardinality many
dab update Farm --relationship FarmCulture --target.entity FarmCulture --cardinality one
dab update FarmCulture --relationship Farm --target.entity Farm --cardinality many
dab update Farm --relationship TraderEntity --target.entity TraderEntity --cardinality one
dab update TraderEntity --relationship Farm --target.entity Farm --cardinality many
dab update GrowSpace --relationship GrowMediumType --target.entity GrowMediumType --cardinality one
dab update GrowMediumType --relationship GrowSpace --target.entity GrowSpace --cardinality many
dab update GrowSpace --relationship GrowSpaceType --target.entity GrowSpaceType --cardinality one
dab update GrowSpaceType --relationship GrowSpace --target.entity GrowSpace --cardinality many
dab update GrowSpace --relationship GrowSpaceLightSourceType --target.entity GrowSpaceLightSourceType --cardinality one
dab update GrowSpaceLightSourceType --relationship GrowSpace --target.entity GrowSpace --cardinality many
dab update GrowSpace --relationship Zone --target.entity Zone --cardinality one
dab update Zone --relationship GrowSpace --target.entity GrowSpace --cardinality many
dab update GrowSpace --relationship GrowSpaceSetupType --target.entity GrowSpaceSetupType --cardinality one
dab update GrowSpaceSetupType --relationship GrowSpace --target.entity GrowSpace --cardinality many
dab update SubArea --relationship TrefleDatum --target.entity TrefleDatum --cardinality one
dab update TrefleDatum --relationship SubArea --target.entity SubArea --cardinality many
dab update SubArea --relationship GrowSpace --target.entity GrowSpace --cardinality one
dab update GrowSpace --relationship SubArea --target.entity SubArea --cardinality many
dab update Zone --relationship ZoneClassification --target.entity ZoneClassification --cardinality one
dab update ZoneClassification --relationship Zone --target.entity Zone --cardinality many
dab update Zone --relationship ZoneClimateType --target.entity ZoneClimateType --cardinality one
dab update ZoneClimateType --relationship Zone --target.entity Zone --cardinality many
dab update Zone --relationship Farm --target.entity Farm --cardinality one
dab update Farm --relationship Zone --target.entity Zone --cardinality many
dab update ActionHistory --relationship TraderEntity --target.entity TraderEntity --cardinality one
dab update TraderEntity --relationship ActionHistory --target.entity ActionHistory --cardinality many
dab update Feedback --relationship FeedbackCategory --target.entity FeedbackCategory --cardinality one
dab update FeedbackCategory --relationship Feedback --target.entity Feedback --cardinality many
dab update Feedback --relationship FeedbackMetadatum --target.entity FeedbackMetadatum --cardinality one
dab update FeedbackMetadatum --relationship Feedback --target.entity Feedback --cardinality many
dab update Feedback --relationship FeedbackType --target.entity FeedbackType --cardinality one
dab update FeedbackType --relationship Feedback --target.entity Feedback --cardinality many
dab update GrowSpaceDatum --relationship GrowSpaceDataEntryType --target.entity GrowSpaceDataEntryType --cardinality one
dab update GrowSpaceDataEntryType --relationship GrowSpaceDatum --target.entity GrowSpaceDatum --cardinality many
dab update GrowSpaceDatum --relationship GrowSpace --target.entity GrowSpace --cardinality one
dab update GrowSpace --relationship GrowSpaceDatum --target.entity GrowSpaceDatum --cardinality many
dab update Response --relationship Feedback --target.entity Feedback --cardinality one
dab update Feedback --relationship Response --target.entity Response --cardinality many
dab update SubAreaHarvestDatum --relationship TrefleDatum --target.entity TrefleDatum --cardinality one
dab update TrefleDatum --relationship SubAreaHarvestDatum --target.entity SubAreaHarvestDatum --cardinality many
dab update SubAreaHarvestDatum --relationship SubArea --target.entity SubArea --cardinality one
dab update SubArea --relationship SubAreaHarvestDatum --target.entity SubAreaHarvestDatum --cardinality many
dab update SubAreaPlantfoodDatum --relationship SubArea --target.entity SubArea --cardinality one
dab update SubArea --relationship SubAreaPlantfoodDatum --target.entity SubAreaPlantfoodDatum --cardinality many
dab update SubAreaStatusDatum --relationship CropLifeCycleStage --target.entity CropLifeCycleStage --cardinality one
dab update CropLifeCycleStage --relationship SubAreaStatusDatum --target.entity SubAreaStatusDatum --cardinality many
dab update SubAreaStatusDatum --relationship SubArea --target.entity SubArea --cardinality one
dab update SubArea --relationship SubAreaStatusDatum --target.entity SubAreaStatusDatum --cardinality many
dab update SubAreaWaterDatum --relationship SubArea --target.entity SubArea --cardinality one
dab update SubArea --relationship SubAreaWaterDatum --target.entity SubAreaWaterDatum --cardinality many
dab update Credit --relationship TraderEntity --target.entity TraderEntity --cardinality one
dab update TraderEntity --relationship Credit --target.entity Credit --cardinality many
dab update Credit --relationship CurrencyIso4217 --target.entity CurrencyIso4217 --cardinality one
dab update CurrencyIso4217 --relationship Credit --target.entity Credit --cardinality many
dab update Credit --relationship TraderEntity --target.entity TraderEntity --cardinality one
dab update TraderEntity --relationship Credit --target.entity Credit --cardinality many
dab update Logistic --relationship DeliveryConfig --target.entity DeliveryConfig --cardinality one
dab update DeliveryConfig --relationship Logistic --target.entity Logistic --cardinality many
dab update Logistic --relationship Order --target.entity Order --cardinality one
dab update Order --relationship Logistic --target.entity Logistic --cardinality many
dab update Order --relationship TraderEntity --target.entity TraderEntity --cardinality one
dab update TraderEntity --relationship Order --target.entity Order --cardinality many
dab update Order --relationship OrderStatus --target.entity OrderStatus --cardinality one
dab update OrderStatus --relationship Order --target.entity Order --cardinality many
dab update OrderProduct --relationship CurrencyIso4217 --target.entity CurrencyIso4217 --cardinality one
dab update CurrencyIso4217 --relationship OrderProduct --target.entity OrderProduct --cardinality many
dab update OrderProduct --relationship Order --target.entity Order --cardinality one
dab update Order --relationship OrderProduct --target.entity OrderProduct --cardinality many
dab update OrderProduct --relationship Product --target.entity Product --cardinality one
dab update Product --relationship OrderProduct --target.entity OrderProduct --cardinality many
dab update Payment --relationship CurrencyIso4217 --target.entity CurrencyIso4217 --cardinality one
dab update CurrencyIso4217 --relationship Payment --target.entity Payment --cardinality many
dab update Payment --relationship Order --target.entity Order --cardinality one
dab update Order --relationship Payment --target.entity Payment --cardinality many
dab update Payment --relationship PaymentType --target.entity PaymentType --cardinality one
dab update PaymentType --relationship Payment --target.entity Payment --cardinality many
dab update DivisionDivisionClass --relationship Division --target.entity Division --cardinality one
dab update Division --relationship DivisionDivisionClass --target.entity DivisionDivisionClass --cardinality many
dab update DivisionDivisionClass --relationship DivisionClass --target.entity DivisionClass --cardinality one
dab update DivisionClass --relationship DivisionDivisionClass --target.entity DivisionDivisionClass --cardinality many
dab update DivisionClassDivisionOrder --relationship DivisionClass --target.entity DivisionClass --cardinality one
dab update DivisionClass --relationship DivisionClassDivisionOrder --target.entity DivisionClassDivisionOrder --cardinality many
dab update DivisionClassDivisionOrder --relationship DivisionOrder --target.entity DivisionOrder --cardinality one
dab update DivisionOrder --relationship DivisionClassDivisionOrder --target.entity DivisionClassDivisionOrder --cardinality many
dab update DivisionOrderFamily --relationship DivisionOrder --target.entity DivisionOrder --cardinality one
dab update DivisionOrder --relationship DivisionOrderFamily --target.entity DivisionOrderFamily --cardinality many
dab update DivisionOrderFamily --relationship Family --target.entity Family --cardinality one
dab update Family --relationship DivisionOrderFamily --target.entity DivisionOrderFamily --cardinality many
dab update FamilyGenu --relationship Family --target.entity Family --cardinality one
dab update Family --relationship FamilyGenu --target.entity FamilyGenu --cardinality many
dab update FamilyGenu --relationship Genu --target.entity Genu --cardinality one
dab update Genu --relationship FamilyGenu --target.entity FamilyGenu --cardinality many
dab update GenusPlant --relationship Genu --target.entity Genu --cardinality one
dab update Genu --relationship GenusPlant --target.entity GenusPlant --cardinality many
dab update GenusPlant --relationship Plant --target.entity Plant --cardinality one
dab update Plant --relationship GenusPlant --target.entity GenusPlant --cardinality many
dab update KingdomSubKingdom --relationship Kingdom --target.entity Kingdom --cardinality one
dab update Kingdom --relationship KingdomSubKingdom --target.entity KingdomSubKingdom --cardinality many
dab update KingdomSubKingdom --relationship SubKingdom --target.entity SubKingdom --cardinality one
dab update SubKingdom --relationship KingdomSubKingdom --target.entity KingdomSubKingdom --cardinality many
dab update PlantSpecy --relationship Plant --target.entity Plant --cardinality one
dab update Plant --relationship PlantSpecy --target.entity PlantSpecy --cardinality many
dab update PlantSpecy --relationship Species --target.entity Species --cardinality one
dab update Species --relationship PlantSpecy --target.entity PlantSpecy --cardinality many
dab update SubKingdomDivision --relationship Division --target.entity Division --cardinality one
dab update Division --relationship SubKingdomDivision --target.entity SubKingdomDivision --cardinality many
dab update SubKingdomDivision --relationship SubKingdom --target.entity SubKingdom --cardinality one
dab update SubKingdom --relationship SubKingdomDivision --target.entity SubKingdomDivision --cardinality many
dab update PermissionDetail --relationship ApplicationSection --target.entity ApplicationSection --cardinality one
dab update ApplicationSection --relationship PermissionDetail --target.entity PermissionDetail --cardinality many
dab update PermissionDetail --relationship SecurityGroup --target.entity SecurityGroup --cardinality one
dab update SecurityGroup --relationship PermissionDetail --target.entity PermissionDetail --cardinality many
dab update SecurityGroup --relationship TraderEntity --target.entity TraderEntity --cardinality one
dab update TraderEntity --relationship SecurityGroup --target.entity SecurityGroup --cardinality many
dab update TraderEntity --relationship TraderContactDetail --target.entity TraderContactDetail --cardinality one
dab update TraderContactDetail --relationship TraderEntity --target.entity TraderEntity --cardinality many
dab update TraderEntity --relationship TraderLocation --target.entity TraderLocation --cardinality one
dab update TraderLocation --relationship TraderEntity --target.entity TraderEntity --cardinality many
dab update TraderEntity --relationship TraderType --target.entity TraderType --cardinality one
dab update TraderType --relationship TraderEntity --target.entity TraderEntity --cardinality many
dab update TraderLocation --relationship MunicipalityDetail --target.entity MunicipalityDetail --cardinality one
dab update MunicipalityDetail --relationship TraderLocation --target.entity TraderLocation --cardinality many
@echo Adding stored procedures
dab add "DeleteFullSecurityGroupById" --source "[sec].[DeleteFullSecurityGroupById]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "DeleteFullTraderEntityById" --source "[trd].[DeleteFullTraderEntityById]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "DeleteUserSecurityGroupRelationshipBySecurityGroupId" --source "[acc].[DeleteUserSecurityGroupRelationshipBySecurityGroupId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "DeleteUserSecurityGroupRelationshipByUserId" --source "[acc].[DeleteUserSecurityGroupRelationshipByUserId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "DeleteUserTraderEntityRelationshipByTraderId" --source "[acc].[DeleteUserTraderEntityRelationshipByTraderId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "DeleteUserTraderEntityRelationshipByUserId" --source "[acc].[DeleteUserTraderEntityRelationshipByUserId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetActionHistoryByTraderEntityId" --source "[log].[GetActionHistoryByTraderEntityId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetActionHistoryByUserId" --source "[log].[GetActionHistoryByUserId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetAllFromApplicationSection" --source "[sec].[GetAllFromApplicationSection]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetAllFromFeedbackCategory" --source "[dbo].[GetAllFromFeedbackCategory]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetAllFromFeedbackType" --source "[dbo].[GetAllFromFeedbackType]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetAllFromMunicipalityDetail" --source "[dbo].[GetAllFromMunicipalityDetail]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetAllFromSystemParameter" --source "[dbo].[GetAllFromSystemParameter]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetAllFromTraderType" --source "[dbo].[GetAllFromTraderType]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetAllNewFeedback" --source "[log].[GetAllNewFeedback]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetFeedbackById" --source "[log].[GetFeedbackById]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetFeedbackByUserId" --source "[log].[GetFeedbackByUserId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetFeedbackMetadataByFeedbackId" --source "[log].[GetFeedbackMetadataByFeedbackId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetFeedbackMetadataById" --source "[log].[GetFeedbackMetadataById]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetPermissionDetailById" --source "[sec].[GetPermissionDetailById]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetResponseByFeedbackId" --source "[log].[GetResponseByFeedbackId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetResponseById" --source "[log].[GetResponseById]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetSecurityGroupById" --source "[sec].[GetSecurityGroupById]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetTraderContactDetailById" --source "[trd].[GetTraderContactDetailById]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetTraderEntityById" --source "[trd].[GetTraderEntityById]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetTraderLocationById" --source "[trd].[GetTraderLocationById]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetUserSecurityGroupRelationshipBySecurityGroupId" --source "[acc].[GetUserSecurityGroupRelationshipBySecurityGroupId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetUserSecurityGroupRelationshipByUserId" --source "[acc].[GetUserSecurityGroupRelationshipByUserId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetUserTraderEntityRelationshipByTraderId" --source "[acc].[GetUserTraderEntityRelationshipByTraderId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "GetUserTraderEntityRelationshipByUserId" --source "[acc].[GetUserTraderEntityRelationshipByUserId]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "InsertFeedbackWithMetadatum" --source "[log].[InsertFeedbackWithMetadata]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "InsertFullTraderEntity" --source "[trd].[InsertFullTraderEntity]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "InsertResponse" --source "[log].[InsertResponse]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "InsertSecurityGroupBase" --source "[sec].[InsertSecurityGroupBase]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "InsertUserSecurityGroupRelationship" --source "[acc].[InsertUserSecurityGroupRelationship]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "InsertUserTraderEntityRelationship" --source "[acc].[InsertUserTraderEntityRelationship]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "RethrowError" --source "[dbo].[RethrowError]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "UpdatePermissionDetail" --source "[sec].[UpdatePermissionDetail]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "UpdateSecurityGroup" --source "[sec].[UpdateSecurityGroup]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "UpdateTraderContactDetail" --source "[trd].[UpdateTraderContactDetail]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "UpdateTraderEntity" --source "[trd].[UpdateTraderEntity]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
dab add "UpdateTraderLocation" --source "[trd].[UpdateTraderLocation]" --source.type "stored-procedure" --permissions "anonymous:execute" --rest.methods "get" --graphql.operation "query" 
@echo **
@echo ** run 'dab validate' to validate your configuration **
@echo ** run 'dab start' to start the development API host **
