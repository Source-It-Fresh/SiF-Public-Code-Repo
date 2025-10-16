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

------------------------------------------
--- Move TrefleData From old to new DB ---
------------------------------------------

--SET IDENTITY_INSERT [dbo].[TrefleData] ON

--INSERT INTO [dbo].[TrefleData]([id]
--      ,[scientific_name]
--      ,[rank]
--      ,[genus]
--      ,[family]
--      ,[year]
--      ,[author]
--      ,[bibliography]
--      ,[common_name]
--      ,[family_common_name]
--      ,[image_url]
--      ,[flower_color]
--      ,[flower_conspicuous]
--      ,[foliage_color]
--      ,[foliage_texture]
--      ,[fruit_color]
--      ,[fruit_conspicuous]
--      ,[fruit_months]
--      ,[bloom_months]
--      ,[ground_humidity]
--      ,[growth_form]
--      ,[growth_habit]
--      ,[growth_months]
--      ,[growth_rate]
--      ,[edible_part]
--      ,[vegetable]
--      ,[edible]
--      ,[light]
--      ,[soil_nutriments]
--      ,[soil_salinity]
--      ,[anaerobic_tolerance]
--      ,[atmospheric_humidity]
--      ,[average_height_cm]
--      ,[maximum_height_cm]
--      ,[minimum_root_depth_cm]
--      ,[ph_maximum]
--      ,[ph_minimum]
--      ,[planting_days_to_harvest]
--      ,[planting_description]
--      ,[planting_sowing_description]
--      ,[planting_row_spacing_cm]
--      ,[planting_spread_cm]
--      ,[synonyms]
--      ,[distributions]
--      ,[common_names]
--      ,[url_usda]
--      ,[url_tropicos]
--      ,[url_tela_botanica]
--      ,[url_powo]
--      ,[url_plantnet]
--      ,[url_gbif]
--      ,[url_openfarm]
--      ,[url_catminat]
--      ,[url_wikipedia_en]) SELECT [id]
--      ,[scientific_name]
--      ,[rank]
--      ,[genus]
--      ,[family]
--      ,[year]
--      ,[author]
--      ,[bibliography]
--      ,[common_name]
--      ,[family_common_name]
--      ,[image_url]
--      ,[flower_color]
--      ,[flower_conspicuous]
--      ,[foliage_color]
--      ,[foliage_texture]
--      ,[fruit_color]
--      ,[fruit_conspicuous]
--      ,[fruit_months]
--      ,[bloom_months]
--      ,[ground_humidity]
--      ,[growth_form]
--      ,[growth_habit]
--      ,[growth_months]
--      ,[growth_rate]
--      ,[edible_part]
--      ,[vegetable]
--      ,[edible]
--      ,[light]
--      ,[soil_nutriments]
--      ,[soil_salinity]
--      ,[anaerobic_tolerance]
--      ,[atmospheric_humidity]
--      ,[average_height_cm]
--      ,[maximum_height_cm]
--      ,[minimum_root_depth_cm]
--      ,[ph_maximum]
--      ,[ph_minimum]
--      ,[planting_days_to_harvest]
--      ,[planting_description]
--      ,[planting_sowing_description]
--      ,[planting_row_spacing_cm]
--      ,[planting_spread_cm]
--      ,[synonyms]
--      ,[distributions]
--      ,[common_names]
--      ,[url_usda]
--      ,[url_tropicos]
--      ,[url_tela_botanica]
--      ,[url_powo]
--      ,[url_plantnet]
--      ,[url_gbif]
--      ,[url_openfarm]
--      ,[url_catminat]
--      ,[url_wikipedia_en] FROM [dbo].[TrefleData_old]

--SET IDENTITY_INSERT [dbo].[TrefleData] OFF