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

---------   -------   -------   dbo   -------   -------   -------
--SET IDENTITY_INSERT [dbo].[SystemParameter] ON
--INSERT [dbo].[SystemParameter] ([id], [name], [description], [value]) VALUES (1, N'DBVersion', N'DataBase Version Number', '1.0.0.7')
--SET IDENTITY_INSERT [dbo].[SystemParameter] OFF
--GO

--SET IDENTITY_INSERT [dbo].[FeedbackType] ON
--INSERT [dbo].[FeedbackType] ([id], [name], [description]) VALUES (0, N'Comment / Improvement idea', N'Comment / Improvement idea')
--INSERT [dbo].[FeedbackType] ([id], [name], [description]) VALUES (1, N'Bug / Issue Report',         N'Bug / Issue Report')
--INSERT [dbo].[FeedbackType] ([id], [name], [description]) VALUES (2, N'Question / Contact Us',      N'Question / Contact Us')
--SET IDENTITY_INSERT [dbo].[FeedbackType] OFF
--GO

--SET IDENTITY_INSERT [dbo].[FeedbackCategory] ON
--INSERT [dbo].[FeedbackCategory] ([id], [name], [description]) VALUES (0, N'Account',     N'Account')
--INSERT [dbo].[FeedbackCategory] ([id], [name], [description]) VALUES (1, N'Website',     N'Website')
--INSERT [dbo].[FeedbackCategory] ([id], [name], [description]) VALUES (2, N'Application', N'Application')
--INSERT [dbo].[FeedbackCategory] ([id], [name], [description]) VALUES (3, N'Links',       N'Links')
--INSERT [dbo].[FeedbackCategory] ([id], [name], [description]) VALUES (4, N'Services',    N'Services')
--INSERT [dbo].[FeedbackCategory] ([id], [name], [description]) VALUES (5, N'Other',       N'Other')
--SET IDENTITY_INSERT [dbo].[FeedbackCategory] OFF
--GO

----SET IDENTITY_INSERT [dbo].[AuthenticationProvider] ON
----INSERT [dbo].[AuthenticationProvider] ([id], [name], [newAccountUrl]) VALUES (0, N'Facebook',  N'https://www.facebook.com/')
----INSERT [dbo].[AuthenticationProvider] ([id], [name], [newAccountUrl]) VALUES (1, N'Google',    N'https://accounts.google.com/SignUp')
----INSERT [dbo].[AuthenticationProvider] ([id], [name], [newAccountUrl]) VALUES (4, N'Microsoft', N'https://signup.live.com/')
----INSERT [dbo].[AuthenticationProvider] ([id], [name], [newAccountUrl]) VALUES (7, N'Anonymous', N'N/A')
----SET IDENTITY_INSERT [dbo].[AuthenticationProvider] OFF
----GO

--SET IDENTITY_INSERT [dbo].[TraderType] ON
--INSERT [dbo].[TraderType] ([id], [name], [description]) VALUES (0, N'Personal',            N'For home use')
--INSERT [dbo].[TraderType] ([id], [name], [description]) VALUES (1, N'Online only',         N'No phisical store front')
--INSERT [dbo].[TraderType] ([id], [name], [description]) VALUES (2, N'Own Business',        N'Family-owned / one-man startup')
--INSERT [dbo].[TraderType] ([id], [name], [description]) VALUES (3, N'Dynamic location',    N'Roaming mobile store')
--INSERT [dbo].[TraderType] ([id], [name], [description]) VALUES (4, N'Registered Business', N'Established Business')
--INSERT [dbo].[TraderType] ([id], [name], [description]) VALUES (5, N'Enterprise',          N'Big Corporation')

----INSERT [dbo].[TraderType] ([id], [name], [description]) VALUES (6, N'Shop',                N'Just SEll?canBuy')
----INSERT [dbo].[TraderType] ([id], [name], [description]) VALUES (7, N'Farm',                N'Just Generate?canBuy')
----INSERT [dbo].[TraderType] ([id], [name], [description]) VALUES (8, N'Restorant',           N'Just BUy?canSell')
----INSERT [dbo].[TraderType] ([id], [name], [description]) VALUES (9, N'Inividual',           N'Buy&Sell?')

--SET IDENTITY_INSERT [dbo].[TraderType] OFF
--GO

--INSERT [dbo].[MunicipalityDetail] ([id], [name], [address], [policeContactDetails], [ambulanceContactDetails], [waterDepartmentContactDetails], [electricityDepartmentContactDetails], [fireDepartmentContactDetails]) VALUES ('00000000-0000-0000-0000-000000000001', N'N/A', N'None', NULL, NULL, NULL, NULL, NULL)
--GO

--SET IDENTITY_INSERT [dbo].[FarmCulture] ON
--INSERT [dbo].[FarmCulture] ([id], [name]) VALUES (0, N'Hybrid') --(Determined by zone)
--INSERT [dbo].[FarmCulture] ([id], [name]) VALUES (1, N'Polyculture')
--INSERT [dbo].[FarmCulture] ([id], [name]) VALUES (2, N'Monoculture')

--SET IDENTITY_INSERT [dbo].[FarmCulture] OFF
--GO

--SET IDENTITY_INSERT [dbo].[FarmAgriculture] ON
--INSERT [dbo].[FarmAgriculture] ([id], [name]) VALUES (0, N'Permaculture')
--INSERT [dbo].[FarmAgriculture] ([id], [name]) VALUES (1, N'Sustainable Agriculture')
--INSERT [dbo].[FarmAgriculture] ([id], [name]) VALUES (2, N'Traditional Agriculture')
--INSERT [dbo].[FarmAgriculture] ([id], [name]) VALUES (3, N'Alternative Agriculture')
--INSERT [dbo].[FarmAgriculture] ([id], [name]) VALUES (4, N'Organic Agriculture')
--INSERT [dbo].[FarmAgriculture] ([id], [name]) VALUES (5, N'Regenerative Agriculture')
--SET IDENTITY_INSERT [dbo].[FarmAgriculture] OFF
--GO

--SET IDENTITY_INSERT [dbo].[ZoneClassification] ON
--INSERT [dbo].[ZoneClassification] ([id], [name]) VALUES (0, N'Other')
--INSERT [dbo].[ZoneClassification] ([id], [name]) VALUES (1, N'Indoors - Greenhouse / geoDome')
--INSERT [dbo].[ZoneClassification] ([id], [name]) VALUES (2, N'Indoors - Room / Basement')
--INSERT [dbo].[ZoneClassification] ([id], [name]) VALUES (3, N'Outdoors - Rooftop')
--INSERT [dbo].[ZoneClassification] ([id], [name]) VALUES (4, N'Outdoors - Patch of open land / Garden')
--SET IDENTITY_INSERT [dbo].[ZoneClassification] OFF
--GO

--SET IDENTITY_INSERT [dbo].[GrowSpaceSetupType] ON
--INSERT [dbo].[GrowSpaceSetupType] ([id], [name]) VALUES (0, N'Custom')
--INSERT [dbo].[GrowSpaceSetupType] ([id], [name]) VALUES (1, N'Hydroponics')
--INSERT [dbo].[GrowSpaceSetupType] ([id], [name]) VALUES (2, N'Aquaponics')
--INSERT [dbo].[GrowSpaceSetupType] ([id], [name]) VALUES (3, N'Airoponix')
--INSERT [dbo].[GrowSpaceSetupType] ([id], [name]) VALUES (4, N'Classic Soil')
--INSERT [dbo].[GrowSpaceSetupType] ([id], [name]) VALUES (5, N'No Dig')
--INSERT [dbo].[GrowSpaceSetupType] ([id], [name]) VALUES (6, N'Raised Growbeds')
--INSERT [dbo].[GrowSpaceSetupType] ([id], [name]) VALUES (7, N'Pots')
--INSERT [dbo].[GrowSpaceSetupType] ([id], [name]) VALUES (8, N'Growbags')
--SET IDENTITY_INSERT [dbo].[GrowSpaceSetupType] OFF
--GO

--SET IDENTITY_INSERT [dbo].[GrowSpaceType] ON
--INSERT [dbo].[GrowSpaceType] ([id], [name]) VALUES (0, N'unknown')
--INSERT [dbo].[GrowSpaceType] ([id], [name]) VALUES (1, N'Row')
--INSERT [dbo].[GrowSpaceType] ([id], [name]) VALUES (2, N'Bed (Raised / Grow)')
--INSERT [dbo].[GrowSpaceType] ([id], [name]) VALUES (3, N'Tray')
--SET IDENTITY_INSERT [dbo].[GrowSpaceType] OFF
--GO

--SET IDENTITY_INSERT [dbo].[GrowMediumType] ON
--INSERT [dbo].[GrowMediumType] ([id], [name]) VALUES (0, N'unknown')
--INSERT [dbo].[GrowMediumType] ([id], [name]) VALUES (1, N'Water')
--INSERT [dbo].[GrowMediumType] ([id], [name]) VALUES (2, N'Air')
--INSERT [dbo].[GrowMediumType] ([id], [name]) VALUES (3, N'Gravel')
--INSERT [dbo].[GrowMediumType] ([id], [name]) VALUES (4, N'Sand / Silt')
--INSERT [dbo].[GrowMediumType] ([id], [name]) VALUES (5, N'Soil Clays / Mineral Colloids')
--INSERT [dbo].[GrowMediumType] ([id], [name]) VALUES (6, N'Organic Colloids')
--INSERT [dbo].[GrowMediumType] ([id], [name]) VALUES (7, N'Carbon and Terra Preta')
--INSERT [dbo].[GrowMediumType] ([id], [name]) VALUES (8, N'RockWool')
--INSERT [dbo].[GrowMediumType] ([id], [name]) VALUES (9, N'Synthetic Material')
--SET IDENTITY_INSERT [dbo].[GrowMediumType] OFF
--GO

----SET IDENTITY_INSERT [dbo].[GrowMediumDetail] ON
----INSERT INTO [dbo].[GrowMediumDetail] ([id], [growmediumTypeId], [texture], [structure], [density], [porosity], [consistency], [temperature], [colour], [resistivity], [waterRetention], [waterFlow]) VALUES ([id] [growmediumTypeId], [texture], [structure], [density], [porosity], [consistency], [temperature], [colour], [resistivity], [waterRetention], [waterFlow])

----[MediaType] [SurfaceArea_(m2/m3)] [pH] [Cost] [Weight] [Lifespan] [WaterRetention] [PlantSupport] [EaseToWorkWith]

----INSERT [dbo].[GrowMediumDetail] () VALUES (1, 'Volcanic gravel (tuff)',   '300–400',           'Neutral', 'Medium',      'Medium', 'Long',  'Medium–Poor', 'Excellent',   'Medium'
----INSERT [dbo].[GrowMediumDetail] () VALUES (2, 'Volcanic gravel (pumice)', '200–300',           'Neutral', 'Medium–High', 'Light',  'Long',  'Medium',      'Medium–Poor', 'Easy'
----INSERT [dbo].[GrowMediumDetail] () VALUES (3, 'Limestone gravel',         '150–200',           'Basic',   'Low',         'Heavy',  'Long',  'Poor',        'Excellent',   'Difficult'
----INSERT [dbo].[GrowMediumDetail] () VALUES (4, 'Expanded clay(LECA)',      '250–300',           'Neutral', 'High',        'Light',  'Long',  'Medium–Poor', 'Medium',      'Easy'
----INSERT [dbo].[GrowMediumDetail] () VALUES (5, 'Plastic bottle caps',      '50–100',            'Inert',   'Low',         'Light',  'Long',  'Poor',        'Poor',        'Easy'
----INSERT [dbo].[GrowMediumDetail] () VALUES (6, 'Coconut fibre',            '200–400(variable)', 'Neutral', 'Low–Medium',  'Light',  'Short', 'High',        'Medium',      'Easy'

----INSERT [dbo].[GrowMediumDetail] () VALUES (7, [growmediumTypeId], [texture], [structure], [density], [porosity], [consistency], [temperature], [colour], [resistivity], [waterRetention], [waterFlow])
----INSERT [dbo].[GrowMediumDetail] () VALUES (8, [growmediumTypeId], [texture], [structure], [density], [porosity], [consistency], [temperature], [colour], [resistivity], [waterRetention], [waterFlow])
----INSERT [dbo].[GrowMediumDetail] () VALUES (9, [growmediumTypeId], [texture], [structure], [density], [porosity], [consistency], [temperature], [colour], [resistivity], [waterRetention], [waterFlow])
----SET IDENTITY_INSERT [dbo].[GrowMediumDetail] OFF
----GO

--SET IDENTITY_INSERT [dbo].[ZoneClimateType] ON
--INSERT [dbo].[ZoneClimateType] ([id], [name], [simple], [details], [koppenGeiger]) VALUES (0, N'unknown',             ' ', 'N/A',                                            '[None]')
--INSERT [dbo].[ZoneClimateType] ([id], [name], [simple], [details], [koppenGeiger]) VALUES (1, N'Tropical',            'A', 'wet / wet & dry',                                '[Af,Am,Aw/As]')
--INSERT [dbo].[ZoneClimateType] ([id], [name], [simple], [details], [koppenGeiger]) VALUES (2, N'Desert / Dry',        'B', 'semiArid / Arid',                                '[BWh,BWk,BSh,BSk]')
--INSERT [dbo].[ZoneClimateType] ([id], [name], [simple], [details], [koppenGeiger]) VALUES (3, N'Temperate / Moderate','C', 'Meditieranean / HumedSubTropical',               '[Csa,Csb,Csc,Cwa,Cwb,Cwc,Cfa,Cfb,Cfc]')
--INSERT [dbo].[ZoneClimateType] ([id], [name], [simple], [details], [koppenGeiger]) VALUES (4, N'Continental / Cold',  'D', 'Humid / SubArctic',                               '[Dsa,Dsb,Dsc,Dsd,Dwa,Dwb,Dwc,Dwd,Dfa,Dfb,Dfc,Dfd]')
--INSERT [dbo].[ZoneClimateType] ([id], [name], [simple], [details], [koppenGeiger]) VALUES (5, N'Polar',               'E', 'Tundra / Icecap / highland s/ non-permanantIce', '[ET,EF]')
--SET IDENTITY_INSERT [dbo].[ZoneClimateType] OFF
--GO

--SET IDENTITY_INSERT [dbo].[GrowSpaceLightSourceType] ON
--INSERT [dbo].[GrowSpaceLightSourceType] ([id], [name]) VALUES (0, N'unknown')
--INSERT [dbo].[GrowSpaceLightSourceType] ([id], [name]) VALUES (1, N'natural')
--INSERT [dbo].[GrowSpaceLightSourceType] ([id], [name]) VALUES (2, N'sunlight')
--INSERT [dbo].[GrowSpaceLightSourceType] ([id], [name]) VALUES (3, N'artificial light')
--INSERT [dbo].[GrowSpaceLightSourceType] ([id], [name]) VALUES (4, N'Bulb')
--INSERT [dbo].[GrowSpaceLightSourceType] ([id], [name]) VALUES (5, N'LED')
--INSERT [dbo].[GrowSpaceLightSourceType] ([id], [name]) VALUES (6, N'CFL')
--INSERT [dbo].[GrowSpaceLightSourceType] ([id], [name]) VALUES (7, N'Fluorescent')
--SET IDENTITY_INSERT [dbo].[GrowSpaceLightSourceType] OFF
--GO

--SET IDENTITY_INSERT [dbo].[GrowSpaceDataEntryType] ON
--INSERT [dbo].[GrowSpaceDataEntryType] ([id], [name]) VALUES (0, N'Manual measure')
--INSERT [dbo].[GrowSpaceDataEntryType] ([id], [name]) VALUES (1, N'Automated digital monitory')
--SET IDENTITY_INSERT [dbo].[GrowSpaceDataEntryType] OFF
--GO

--SET IDENTITY_INSERT [dbo].[CropLifeCycleStage] ON
--INSERT [dbo].[CropLifeCycleStage] ([id], [name]) VALUES (0, N'Seed')
--INSERT [dbo].[CropLifeCycleStage] ([id], [name]) VALUES (1, N'Germination / Sprout')
--INSERT [dbo].[CropLifeCycleStage] ([id], [name]) VALUES (2, N'Seedling')
--INSERT [dbo].[CropLifeCycleStage] ([id], [name]) VALUES (3, N'Vegetative / Growing')
--INSERT [dbo].[CropLifeCycleStage] ([id], [name]) VALUES (4, N'Budding')
--INSERT [dbo].[CropLifeCycleStage] ([id], [name]) VALUES (5, N'Pollination')
--INSERT [dbo].[CropLifeCycleStage] ([id], [name]) VALUES (6, N'Flowering / Fruit')
--INSERT [dbo].[CropLifeCycleStage] ([id], [name]) VALUES (7, N'Ripening')
--INSERT [dbo].[CropLifeCycleStage] ([id], [name]) VALUES (8, N'Harvest / Reproduction')
--INSERT [dbo].[CropLifeCycleStage] ([id], [name]) VALUES (9, N'Clowning')
--INSERT [dbo].[CropLifeCycleStage] ([id], [name]) VALUES (10, N'Spreading Seeds / Dying')
--SET IDENTITY_INSERT [dbo].[CropLifeCycleStage] OFF
--GO

--SET IDENTITY_INSERT [dbo].[DeliveryMethod] ON
--INSERT [dbo].[DeliveryMethod] ([id], [name], [description]) VALUES (0, N'N/A',       N'Manage outside of system/application (Automated Delivery: (self-driving/drone) -add to roadmap)')
--INSERT [dbo].[DeliveryMethod] ([id], [name], [description]) VALUES (1, N'No',        N'Pick up only')
--INSERT [dbo].[DeliveryMethod] ([id], [name], [description]) VALUES (2, N'SomeTimes', N'Deliver on request for large orders')
--INSERT [dbo].[DeliveryMethod] ([id], [name], [description]) VALUES (3, N'Yes',       N'Company driver surviving surrounding areas')
--INSERT [dbo].[DeliveryMethod] ([id], [name], [description]) VALUES (4, N'Managed',   N'Local Courier companies (e.g. Mr Delivery)) {integrate with their API services}')
--SET IDENTITY_INSERT [dbo].[DeliveryMethod] OFF
--GO

--SET IDENTITY_INSERT [dbo].[PaymentType] ON
--INSERT [dbo].[PaymentType] ([id], [name], [description]) VALUES (0, N'N/A',           N'Manage outside of system/application')
--INSERT [dbo].[PaymentType] ([id], [name], [description]) VALUES (1, N'Cash_Local',    N'(cash) Local Currency')
--INSERT [dbo].[PaymentType] ([id], [name], [description]) VALUES (2, N'Cash_Specific', N'(cash) Specific Currency')
--INSERT [dbo].[PaymentType] ([id], [name], [description]) VALUES (3, N'EFT',           N'online / manualy @ bank')
--INSERT [dbo].[PaymentType] ([id], [name], [description]) VALUES (4, N'Managed',       N'PayPal (auto), GoogleWallet, Amazon, SamsunyPay, etc. ? Crypto Currency (Any / All) ?')
--SET IDENTITY_INSERT [dbo].[PaymentType] OFF
--GO

--SET IDENTITY_INSERT [dbo].[CurrencyISO4217] ON
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (784, 'AED', 2, 'United Arab Emirates dirham', ' United Arab Emirates')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (971, 'AFN', 2, 'Afghan afghani', ' Afghanistan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (8  , 'ALL', 2, 'Albanian lek', ' Albania')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (51 , 'AMD', 2, 'Armenian dram', ' Armenia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (532, 'ANG', 2, 'Netherlands Antillean guilder', ' Curaçao (CW),  Sint Maarten (SX)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (973, 'AOA', 2, 'Angolan kwanza', ' Angola')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (32 , 'ARS', 2, 'Argentine peso', ' Argentina')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (36 , 'AUD', 2, 'Australian dollar', ' Australia,  Christmas Island (CX),  Cocos (Keeling) Islands (CC),  Heard Island and McDonald Islands (HM),  Kiribati (KI),  Nauru (NR),  Norfolk Island (NF),  Tuvalu (TV)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (533, 'AWG', 2, 'Aruban florin', ' Aruba')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (944, 'AZN', 2, 'Azerbaijani manat', ' Azerbaijan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (977, 'BAM', 2, 'Bosnia and Herzegovina convertible mark', ' Bosnia and Herzegovina')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (52 , 'BBD', 2, 'Barbados dollar', ' Barbados')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (50 , 'BDT', 2, 'Bangladeshi taka', ' Bangladesh')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (975, 'BGN', 2, 'Bulgarian lev', ' Bulgaria')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (48 , 'BHD', 3, 'Bahraini dinar', ' Bahrain')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (108, 'BIF', 0, 'Burundian franc', ' Burundi')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (60 , 'BMD', 2, 'Bermudian dollar', ' Bermuda')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (96 , 'BND', 2, 'Brunei dollar', ' Brunei')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (68 , 'BOB', 2, 'Boliviano', ' Bolivia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (984, 'BOV', 2, 'Bolivian Mvdol (funds code)', ' Bolivia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (986, 'BRL', 2, 'Brazilian real', ' Brazil')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (44 , 'BSD', 2, 'Bahamian dollar', ' Bahamas')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (64 , 'BTN', 2, 'Bhutanese ngultrum', ' Bhutan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (72 , 'BWP', 2, 'Botswana pula', ' Botswana')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (933, 'BYN', 2, 'Belarusian ruble', ' Belarus')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (84 , 'BZD', 2, 'Belize dollar', ' Belize')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (124, 'CAD', 2, 'Canadian dollar', ' Canada')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (976, 'CDF', 2, 'Congolese franc', ' Democratic Republic of the Congo')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (947, 'CHE', 2, 'WIR Euro (complementary currency)', '  Switzerland')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (756, 'CHF', 2, 'Swiss franc', '  Switzerland,  Liechtenstein (LI)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (948, 'CHW', 2, 'WIR Franc (complementary currency)', '  Switzerland')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (990, 'CLF', 4, 'Unidad de Fomento (funds code)', ' Chile')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (152, 'CLP', 0, 'Chilean peso', ' Chile')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (156, 'CNY', 2, 'Chinese yuan', ' China')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (170, 'COP', 2, 'Colombian peso', ' Colombia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (970, 'COU', 2, 'Unidad de Valor Real (UVR) (funds code)', ' Colombia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (188, 'CRC', 2, 'Costa Rican colon', ' Costa Rica')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (931, 'CUC', 2, 'Cuban convertible peso', ' Cuba')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (192, 'CUP', 2, 'Cuban peso', ' Cuba')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (132, 'CVE', 2, 'Cape Verdean escudo', ' Cabo Verde')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (203, 'CZK', 2, 'Czech koruna', ' Czechia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (262, 'DJF', 0, 'Djiboutian franc', ' Djibouti')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (208, 'DKK', 2, 'Danish krone', ' Denmark,  Faroe Islands (FO),  Greenland (GL)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (214, 'DOP', 2, 'Dominican peso', ' Dominican Republic')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (12 , 'DZD', 2, 'Algerian dinar', ' Algeria')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (818, 'EGP', 2, 'Egyptian pound', ' Egypt')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (232, 'ERN', 2, 'Eritrean nakfa', ' Eritrea')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (230, 'ETB', 2, 'Ethiopian birr', ' Ethiopia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (978, 'EUR', 2, 'Euro', ' Åland Islands (AX),  European Union (EU),  Andorra (AD),  Austria (AT),  Belgium (BE),  Cyprus (CY),  Estonia (EE),  Finland (FI),  France (FR),  French Southern and Antarctic Lands (TF),  Germany (DE),  Greece (GR),  Guadeloupe (GP),  Ireland (IE),  Italy (IT),  Kosovo (XK),  Latvia (LV),  Lithuania (LT),  Luxembourg (LU),  Malta (MT),  French Guiana (GF),  Martinique (MQ),  Mayotte (YT),  Monaco (MC),  Montenegro (ME),  Netherlands (NL),  Portugal (PT),  Réunion (RE),  Saint Barthélemy (BL),  Saint Martin (MF),  Saint Pierre and Miquelon (PM),  San Marino (SM),  Slovakia (SK),  Slovenia (SI),  Spain (ES),   Vatican City (VA)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (242, 'FJD', 2, 'Fiji dollar', ' Fiji')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (238, 'FKP', 2, 'Falkland Islands pound', ' Falkland Islands (pegged to GBP 1:1)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (826, 'GBP', 2, 'Pound sterling', ' United Kingdom,  British Indian Ocean Territory (IO) (also uses USD), the  Isle of Man (IM, see Manx pound),  Jersey (JE, see Jersey pound), and  Guernsey (GG, see Guernsey pound)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (981, 'GEL', 2, 'Georgian lari', ' Georgia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (936, 'GHS', 2, 'Ghanaian cedi', ' Ghana')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (292, 'GIP', 2, 'Gibraltar pound', ' Gibraltar (pegged to GBP 1:1)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (270, 'GMD', 2, 'Gambian dalasi', ' Gambia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (324, 'GNF', 0, 'Guinean franc', ' Guinea')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (320, 'GTQ', 2, 'Guatemalan quetzal', ' Guatemala')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (328, 'GYD', 2, 'Guyanese dollar', ' Guyana')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (344, 'HKD', 2, 'Hong Kong dollar', ' Hong Kong')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (340, 'HNL', 2, 'Honduran lempira', ' Honduras')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (191, 'HRK', 2, 'Croatian kuna', ' Croatia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (332, 'HTG', 2, 'Haitian gourde', ' Haiti')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (348, 'HUF', 2, 'Hungarian forint', ' Hungary')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (360, 'IDR', 2, 'Indonesian rupiah', ' Indonesia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (376, 'ILS', 2, 'Israeli new shekel', ' Israel,  Palestinian Authority')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (356, 'INR', 2, 'Indian rupee', ' India,  Bhutan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (368, 'IQD', 3, 'Iraqi dinar', ' Iraq')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (364, 'IRR', 2, 'Iranian rial', ' Iran')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (352, 'ISK', 0, 'Icelandic króna', ' Iceland')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (388, 'JMD', 2, 'Jamaican dollar', ' Jamaica')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (400, 'JOD', 3, 'Jordanian dinar', ' Jordan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (392, 'JPY', 0, 'Japanese yen', ' Japan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (404, 'KES', 2, 'Kenyan shilling', ' Kenya')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (417, 'KGS', 2, 'Kyrgyzstani som', ' Kyrgyzstan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (116, 'KHR', 2, 'Cambodian riel', ' Cambodia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (174, 'KMF', 0, 'Comoro franc', ' Comoros')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (408, 'KPW', 2, 'North Korean won', ' North Korea')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (410, 'KRW', 0, 'South Korean won', ' South Korea')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (414, 'KWD', 3, 'Kuwaiti dinar', ' Kuwait')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (136, 'KYD', 2, 'Cayman Islands dollar', ' Cayman Islands')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (398, 'KZT', 2, 'Kazakhstani tenge', ' Kazakhstan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (418, 'LAK', 2, 'Lao kip', ' Laos')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (422, 'LBP', 2, 'Lebanese pound', ' Lebanon')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (144, 'LKR', 2, 'Sri Lankan rupee', ' Sri Lanka')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (430, 'LRD', 2, 'Liberian dollar', ' Liberia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (426, 'LSL', 2, 'Lesotho loti', ' Lesotho')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (434, 'LYD', 3, 'Libyan dinar', ' Libya')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (504, 'MAD', 2, 'Moroccan dirham', ' Morocco,  Western Sahara')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (498, 'MDL', 2, 'Moldovan leu', ' Moldova')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (969, 'MGA', 2, 'Malagasy ariary', ' Madagascar')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (807, 'MKD', 2, 'Macedonian denar', ' North Macedonia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (104, 'MMK', 2, 'Myanmar kyat', ' Myanmar')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (496, 'MNT', 2, 'Mongolian tögrög', ' Mongolia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (446, 'MOP', 2, 'Macanese pataca', ' Macau')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (929, 'MRU', 2, 'Mauritanian ouguiya', ' Mauritania')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (480, 'MUR', 2, 'Mauritian rupee', ' Mauritius')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (462, 'MVR', 2, 'Maldivian rufiyaa', ' Maldives')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (454, 'MWK', 2, 'Malawian kwacha', ' Malawi')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (484, 'MXN', 2, 'Mexican peso', ' Mexico')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (979, 'MXV', 2, 'Mexican Unidad de Inversion (UDI) (funds code)', ' Mexico')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (458, 'MYR', 2, 'Malaysian ringgit', ' Malaysia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (943, 'MZN', 2, 'Mozambican metical', ' Mozambique')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (516, 'NAD', 2, 'Namibian dollar', ' Namibia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (566, 'NGN', 2, 'Nigerian naira', ' Nigeria')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (558, 'NIO', 2, 'Nicaraguan córdoba', ' Nicaragua')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (578, 'NOK', 2, 'Norwegian krone', ' Norway,  Svalbard and  Jan Mayen (SJ),  Bouvet Island (BV)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (524, 'NPR', 2, 'Nepalese rupee', '   Nepal')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (554, 'NZD', 2, 'New Zealand dollar', ' New Zealand,  Cook Islands (CK),  Niue (NU),  Pitcairn Islands (PN; see also Pitcairn Islands dollar),  Tokelau (TK)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (512, 'OMR', 3, 'Omani rial', ' Oman')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (590, 'PAB', 2, 'Panamanian balboa', ' Panama')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (604, 'PEN', 2, 'Peruvian sol', ' Peru')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (598, 'PGK', 2, 'Papua New Guinean kina', ' Papua New Guinea')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (608, 'PHP', 2, 'Philippine peso', ' Philippines')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (586, 'PKR', 2, 'Pakistani rupee', ' Pakistan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (985, 'PLN', 2, 'Polish z?oty', ' Poland')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (600, 'PYG', 0, 'Paraguayan guaraní', ' Paraguay')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (634, 'QAR', 2, 'Qatari riyal', ' Qatar')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (946, 'RON', 2, 'Romanian leu', ' Romania')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (941, 'RSD', 2, 'Serbian dinar', ' Serbia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (643, 'RUB', 2, 'Russian ruble', ' Russia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (646, 'RWF', 0, 'Rwandan franc', ' Rwanda')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (682, 'SAR', 2, 'Saudi riyal', ' Saudi Arabia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (90 , 'SBD', 2, 'Solomon Islands dollar', ' Solomon Islands')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (690, 'SCR', 2, 'Seychelles rupee', ' Seychelles')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (938, 'SDG', 2, 'Sudanese pound', ' Sudan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (752, 'SEK', 2, 'Swedish krona/kronor', ' Sweden')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (702, 'SGD', 2, 'Singapore dollar', ' Singapore')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (654, 'SHP', 2, 'Saint Helena pound', ' Saint Helena (SH-SH),  Ascension Island (SH-AC),  Tristan da Cunha')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (694, 'SLL', 2, 'Sierra Leonean leone', ' Sierra Leone')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (706, 'SOS', 2, 'Somali shilling', ' Somalia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (968, 'SRD', 2, 'Surinamese dollar', ' Suriname')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (728, 'SSP', 2, 'South Sudanese pound', ' South Sudan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (930, 'STN', 2, 'São Tomé and Príncipe dobra', ' São Tomé and Príncipe')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (222, 'SVC', 2, 'Salvadoran colón', ' El Salvador')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (760, 'SYP', 2, 'Syrian pound', ' Syria')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (748, 'SZL', 2, 'Swazi lilangeni', ' Eswatini')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (764, 'THB', 2, 'Thai baht', ' Thailand')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (972, 'TJS', 2, 'Tajikistani somoni', ' Tajikistan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (934, 'TMT', 2, 'Turkmenistan manat', ' Turkmenistan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (788, 'TND', 3, 'Tunisian dinar', ' Tunisia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (776, 'TOP', 2, 'Tongan pa?anga', ' Tonga')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (949, 'TRY', 2, 'Turkish lira', ' Turkey,  Northern Cyprus')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (780, 'TTD', 2, 'Trinidad and Tobago dollar', ' Trinidad and Tobago')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (901, 'TWD', 2, 'New Taiwan dollar', ' Taiwan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (834, 'TZS', 2, 'Tanzanian shilling', ' Tanzania')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (980, 'UAH', 2, 'Ukrainian hryvnia', ' Ukraine')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (800, 'UGX', 0, 'Ugandan shilling', ' Uganda')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (840, 'USD', 2, 'United States dollar', ' United States,  American Samoa (AS),  Barbados (BB) (as well as Barbados Dollar),  Bermuda (BM) (as well as Bermudian Dollar),  British Indian Ocean Territory (IO) (also uses GBP),  British Virgin Islands (VG),  Caribbean Netherlands (BQ – Bonaire, Sint Eustatius and Saba),  Ecuador (EC),  El Salvador (SV),  Guam (GU),  Haiti (HT),  Marshall Islands (MH),  Federated States of Micronesia (FM),  Northern Mariana Islands (MP),  Palau (PW),  Panama (PA) (as well as Panamanian Balboa),  Puerto Rico (PR),  Timor-Leste (TL),  Turks and Caicos Islands (TC),  U.S. Virgin Islands (VI),  United States Minor Outlying Islands (UM)  Cambodia.')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (997, 'USN', 2, 'United States dollar (next day) (funds code)', ' United States')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (940, 'UYI', 0, 'Uruguay Peso en Unidades Indexadas (URUIURUI) (funds code)', ' Uruguay')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (858, 'UYU', 2, 'Uruguayan peso', ' Uruguay')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (927, 'UYW', 4, 'Unidad previsional', ' Uruguay')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (860, 'UZS', 2, 'Uzbekistan som', ' Uzbekistan')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (928, 'VES', 2, 'Venezuelan bolívar soberano', ' Venezuela')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (704, 'VND', 0, 'Vietnamese ??ng', ' Vietnam')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (548, 'VUV', 0, 'Vanuatu vatu', ' Vanuatu')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (882, 'WST', 2, 'Samoan tala', ' Samoa')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (950, 'XAF', 0, 'CFA franc BEAC', ' Cameroon (CM),  Central African Republic (CF),  Republic of the Congo (CG),  Chad (TD),  Equatorial Guinea (GQ),  Gabon (GA)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (961, 'XAG', NULL, 'Silver (one troy ounce)', '')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (959, 'XAU', NULL, 'Gold (one troy ounce)', '')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (955, 'XBA', NULL, 'European Composite Unit (EURCO) (bond market unit)', '')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (956, 'XBB', NULL, 'European Monetary Unit (E.M.U.-6) (bond market unit)', '')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (957, 'XBC', NULL, 'European Unit of Account 9 (E.U.A.-9) (bond market unit)', '')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (958, 'XBD', NULL, 'European Unit of Account 17 (E.U.A.-17) (bond market unit)', '')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (951, 'XCD', 2, 'East Caribbean dollar', ' Anguilla (AI),  Antigua and Barbuda (AG),  Dominica (DM),  Grenada (GD),  Montserrat (MS),  Saint Kitts and Nevis (KN),  Saint Lucia (LC),  Saint Vincent and the Grenadines (VC)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (960, 'XDR', NULL, 'Special drawing rights', 'International Monetary Fund')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (952, 'XOF', 0, 'CFA franc BCEAO', ' Benin (BJ),  Burkina Faso (BF),  Côte d''Ivoire (CI),  Guinea-Bissau (GW),  Mali (ML),  Niger (NE),  Senegal (SN),  Togo (TG)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (964, 'XPD', NULL, 'Palladium (one troy ounce)', '')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (953, 'XPF', 0, 'CFP franc (franc Pacifique)', 'French territories of the Pacific Ocean:  French Polynesia (PF),  New Caledonia (NC),  Wallis and Futuna (WF)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (962, 'XPT', NULL, 'Platinum (one troy ounce)', '')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (994, 'XSU', NULL, 'SUCRE', 'Unified System for Regional Compensation (SUCRE)')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (963, 'XTS', NULL, 'Code reserved for testing', '')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (965, 'XUA', NULL, 'ADB Unit of Account', 'African Development Bank')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (999, 'XXX', NULL, 'No currency ', '')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (886, 'YER', 2, 'Yemeni rial', ' Yemen')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (710, 'ZAR', 2, 'South African rand', 'Lesotho,  Namibia,  South Africa')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (967, 'ZMW', 2, 'Zambian kwacha', 'Zambia')
--INSERT [dbo].[CurrencyISO4217] ([id], [code], [postDecimalDigits], [currencyName], [usedLocations]) VALUES (932, 'ZWL', 2, 'Zimbabwean dollar', 'Zimbabwe')
--SET IDENTITY_INSERT [dbo].[CurrencyISO4217] OFF
--GO

--SET IDENTITY_INSERT [dbo].[OrderStatus] ON --(include current location(onFarm,Plnted/growing/cuerring/pacaging/@storeProcessing/driverlocation))
--INSERT [dbo].[OrderStatus] ([id], [name]) VALUES (0, N'Canseled')
--INSERT [dbo].[OrderStatus] ([id], [name]) VALUES (1, N'Preorder')
--INSERT [dbo].[OrderStatus] ([id], [name]) VALUES (2, N'Backorder')
--INSERT [dbo].[OrderStatus] ([id], [name]) VALUES (3, N'Ordered')
--INSERT [dbo].[OrderStatus] ([id], [name]) VALUES (4, N'Confirmed')
--INSERT [dbo].[OrderStatus] ([id], [name]) VALUES (5, N'DelayedByVendor')
--INSERT [dbo].[OrderStatus] ([id], [name]) VALUES (6, N'PosponedByCustomer')
--INSERT [dbo].[OrderStatus] ([id], [name]) VALUES (7, N'In-transet')
--INSERT [dbo].[OrderStatus] ([id], [name]) VALUES (8, N'Deleverd')
--INSERT [dbo].[OrderStatus] ([id], [name]) VALUES (9, N'ReturnedToDC')
--INSERT [dbo].[OrderStatus] ([id], [name]) VALUES (10, N'UnableToDeliver')
--SET IDENTITY_INSERT [dbo].[OrderStatus] OFF
--GO
---------   -------   -------   dbo   -------   -------   -------



---------   -------   -------   acc   -------   -------   -------
----INSERT [acc].[UserInfoFacebook] ([federatedId], [firstName], [lastName], [displayName], [email], [isEmailVerified], [profileImageUrl], [dateModified]) VALUES ('00000000-0000-0000-0000-000000000001', NULL, NULL, 'F_Sys_Admin', 'info@SourceItFresh.com', 1, NULL, '1900-01-01 00:00:00.000')
----GO

----INSERT [acc].[UserInfoGoogle] ([federatedId], [firstName], [lastName], [displayName], [email], [isEmailVerified], [profileImageUrl], [dateModified]) VALUES ('00000000-0000-0000-0000-000000000001', NULL, NULL, 'G_Sys_Admin', 'admin@SourceItFresh.com', 1, NULL, '1900-01-01 00:00:00.000')
----GO

----INSERT [acc].[UserInfoMicrosoft] ([federatedId], [firstName], [lastName], [displayName], [email], [isEmailVerified], [profileImageUrl], [dateModified]) VALUES ('00000000-0000-0000-0000-000000000001', NULL, NULL, 'M_Sys_Admin', 'support@SourceItFresh.com', 1, NULL, '1900-01-01 00:00:00.000')
----GO

--INSERT [acc].[SiF_Users] ([Id], [firstName], [lastName], [ProfilePicture], [bio], [UserInit], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount])
--VALUES ('00000000-0000-0000-0000-000000000001', 'Admin', 'SIF', NULL, 'Default Admin user', 1, 'Admin@SorceItFresh.com', 'ADMIN@SORCEITFRESH.COM', 'Admin@SorceItFresh.com', 'ADMIN@SORCEITFRESH.COM', 1, NULL, NULL, NULL, NULL, 0, 0, NULL, 1, 0)
--GO
---------   -------   -------   acc   -------   -------   -------



---------   -------   -------   trd   -------   -------   -------
--INSERT [trd].[TraderLocation] ([id], [gpsCoordinates], [mapImage], [countryRegion], [stateProvince], [city], [postalCode], [addressLine1], [addressLine2], [building], [floorLevel], [customDetails], [municipalityId], [dateModified], [userModified]) VALUES ('00000000-0000-0000-0000-000000000001', '0.0,0.0', NULL, 'N/A', 'N/A', 'N/A', 'N/A', 'N/A', 'N/A', 'N/A', 'N/A', '', '00000000-0000-0000-0000-000000000001', '1900-01-01 00:00:00.000', '00000000-0000-0000-0000-000000000001')
--GO
--INSERT [trd].[TraderContactDetail] ([id], [websiteUrl], [customerCareEmail], [phoneNumber], [otherDetails], [dateModified], [userModified]) VALUES ('00000000-0000-0000-0000-000000000001', 'N/A', 'N/A', 'N/A', 'N/A', '1900-01-01 00:00:00.000', '00000000-0000-0000-0000-000000000001')
--GO

--INSERT [trd].[TraderEntity] ([id], [name], [traderTypeId], [locationId], [contactDetailId], [vatNumber], [dateCreated], [userCreated], [dateModified], [userModified]) VALUES ('00000000-0000-0000-0000-000000000001', 'SystemPointer', 1, '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', 'N/A', '1900-01-01 00:00:00.000', '00000000-0000-0000-0000-000000000001', '1900-01-01 00:00:00.000', '00000000-0000-0000-0000-000000000001')
--GO
---------   -------   -------   trd   -------   -------   -------