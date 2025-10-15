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
CREATE TABLE [dbo].[TrefleData]
(
    [id]                          BIGINT          NOT NULL IDENTITY (1, 1),
    [scientific_name]             NVARCHAR (100)  NULL,
    [rank]                        NVARCHAR (100)  NULL,
    [genus]                       NVARCHAR (1500) NULL,
    [family]                      NVARCHAR (1500) NULL,
    [year]                        INT             NULL,
    [author]                      NVARCHAR (100)  NULL,
    [bibliography]                NVARCHAR (1000) NULL,
    [common_name]                 NVARCHAR (100)  NULL,
    [family_common_name]          NVARCHAR (100)  NULL,
    [image_url]                   NVARCHAR (250)  NULL,
    [flower_color]                NVARCHAR (50)   NULL,
    [flower_conspicuous]          BIT             NULL,
    [foliage_color]               NVARCHAR (50)   NULL,
    [foliage_texture]             NVARCHAR (100)  NULL,
    [fruit_color]                 NVARCHAR (50)   NULL,
    [fruit_conspicuous]           BIT             NULL,
    [fruit_months]                NVARCHAR (100)  NULL,
    [bloom_months]                NVARCHAR (100)  NULL,
    [ground_humidity]             DECIMAL (10, 2) NULL,
    [growth_form]                 NVARCHAR (50)   NULL,
    [growth_habit]                NVARCHAR (50)   NULL,
    [growth_months]               NVARCHAR (50)   NULL,
    [growth_rate]                 NVARCHAR (100)  NULL,
    [edible_part]                 NVARCHAR (100)  NULL,
    [vegetable]                   BIT             NULL,
    [edible]                      BIT             NULL,
    [light]                       SMALLINT        NULL,
    [soil_nutriments]             SMALLINT        NULL,
    [soil_salinity]               SMALLINT        NULL,
    [anaerobic_tolerance]         NVARCHAR (50)   NULL,
    [atmospheric_humidity]        SMALLINT        NULL,
    [average_height_cm]           SMALLINT        NULL,
    [maximum_height_cm]           SMALLINT        NULL,
    [minimum_root_depth_cm]       SMALLINT        NULL,
    [ph_maximum]                  DECIMAL (6, 4)  NULL,
    [ph_minimum]                  DECIMAL (6, 4)  NULL,
    [planting_days_to_harvest]    SMALLINT        NULL,
    [planting_description]        NVARCHAR (2000) NULL,
    [planting_sowing_description] NVARCHAR (1000) NULL,
    [planting_row_spacing_cm]     SMALLINT        NULL,
    [planting_spread_cm]          SMALLINT        NULL,
    [synonyms]                    NVARCHAR (MAX)  NULL,
    [distributions]               NVARCHAR (MAX)  NULL,
    [common_names]                NVARCHAR (MAX)  NULL,
    [url_usda]                    NVARCHAR (100)  NULL,
    [url_tropicos]                NVARCHAR (100)  NULL,
    [url_tela_botanica]           NVARCHAR (MAX)  NULL,
    [url_powo]                    NVARCHAR (MAX)  NULL,
    [url_plantnet]                NVARCHAR (MAX)  NULL,
    [url_gbif]                    NVARCHAR (MAX)  NULL,
    [url_openfarm]                NVARCHAR (MAX)  NULL,
    [url_catminat]                NVARCHAR (MAX)  NULL,
    [url_wikipedia_en]            NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_TrefleData] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90)
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_TrefleData_id]
    ON [dbo].[TrefleData]([id] ASC) WITH (FILLFACTOR = 90);
