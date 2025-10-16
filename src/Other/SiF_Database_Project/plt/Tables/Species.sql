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
CREATE TABLE [plt].[Species]
(
    [id]                                  BIGINT          NOT NULL IDENTITY (1, 1),
    [scientificName]                      NVARCHAR (50)   NOT NULL,
    [commonName]                          NVARCHAR (50)   NULL,
    [familyCommonName]                    NVARCHAR (50)   NULL,
    [synonym]                             NVARCHAR (50)   NULL,
    [imagesUrl]                           NVARCHAR (200)  NULL,
    [isMainSpecies]                       BIT             NULL,
    [mainSpeciesId]                       BIGINT          NULL,
    [type]                                NVARCHAR (50)   NULL,
    [status]                              NVARCHAR (50)   NULL,
    [nativeStatus]                        NVARCHAR (50)   NULL,
    [completeData]                        BIT             NULL,
    [specification_Toxicity]              NVARCHAR (50)   NULL,
    [specification_ShapeAndOrientation]   NVARCHAR (50)   NULL,
    [specification_RegrowthRate]          NVARCHAR (50)   NULL,
    [specification_NitrogenFixation]      NVARCHAR (50)   NULL,
    [specification_MaxHeightAtBaseAge_cm] NVARCHAR (50)   NULL,
    [specification_MatureHeight_cm]       NVARCHAR (50)   NULL,
    [specification_LowGrowingGrass]       NVARCHAR (50)   NULL,
    [specification_Lifespan]              NVARCHAR (50)   NULL,
    [specification_LeafRetention]         NVARCHAR (50)   NULL,
    [specification_KnownAllelopath]       NVARCHAR (50)   NULL,
    [specification_GrowthRate]            NVARCHAR (50)   NULL,
    [specification_GrowthPeriod]          NVARCHAR (50)   NULL,
    [specification_GrowthHabit]           NVARCHAR (50)   NULL,
    [specification_GrowthForm]            NVARCHAR (50)   NULL,
    [specification_FireResistance]        NVARCHAR (50)   NULL,
    [specification_FallConspicuous]       NVARCHAR (50)   NULL,
    [specification_CoppicePotential]      NVARCHAR (50)   NULL,
    [specification_C_n_ratio]             NVARCHAR (50)   NULL,
    [specification_Bloat]                 NVARCHAR (50)   NULL,
    [soilsAdaptation_Medium]              NVARCHAR (50)   NULL,
    [soilsAdaptation_Fine]                NVARCHAR (50)   NULL,
    [soilsAdaptation_Coarse]              NVARCHAR (50)   NULL,
    [seed_VegetativeSpreadRate]           NVARCHAR (50)   NULL,
    [seed_SmallGrain]                     NVARCHAR (50)   NULL,
    [seed_SeedsPerPound]                  NVARCHAR (50)   NULL,
    [seed_SeedlingVigor]                  NVARCHAR (50)   NULL,
    [seed_SpreadRate]                     NVARCHAR (50)   NULL,
    [seed_CommercialAvailability]         NVARCHAR (50)   NULL,
    [seed_BloomPeriod]                    NVARCHAR (50)   NULL,
    [propagation_Tubers]                  NVARCHAR (50)   NULL,
    [propagation_Sprigs]                  NVARCHAR (50)   NULL,
    [propagation_Sod]                     NVARCHAR (50)   NULL,
    [propagation_Seed]                    NVARCHAR (50)   NULL,
    [propagation_Cuttings]                NVARCHAR (50)   NULL,
    [propagation_Corms]                   NVARCHAR (50)   NULL,
    [propagation_Container]               NVARCHAR (50)   NULL,
    [propagation_Bulbs]                   NVARCHAR (50)   NULL,
    [propagation_BareRoot]                NVARCHAR (50)   NULL,
    [growth_TemperatureMinimum_deg_c]     NVARCHAR (50)   NULL,
    [growth_ShadeTolerance]               NVARCHAR (50)   NULL,
    [growth_SalinityTolerance]            NVARCHAR (50)   NULL,
    [growth_RootDepthMinimum_cm]          NVARCHAR (50)   NULL,
    [growth_ResproutAbility]              NVARCHAR (50)   NULL,
    [growth_PrecipitationMinimum_cm]      NVARCHAR (50)   NULL,
    [growth_PrecipitationMaximum_cm]      NVARCHAR (50)   NULL,
    [growth_PlantingDensityMinimum_sqm]   NVARCHAR (50)   NULL,
    [growth_PlantingDensityMaximum_sqm]   NVARCHAR (50)   NULL,
    [growth_PhMinimum]                    DECIMAL (6, 4)  NULL,
    [growth_PhMaximum]                    DECIMAL (6, 4)  NULL,
    [growth_MoistureUse]                  NVARCHAR (50)   NULL,
    [growth_HedgeTolerance]               NVARCHAR (50)   NULL,
    [growth_FrostFreeDaysMinimum]         NVARCHAR (50)   NULL,
    [growth_FireTolerance]                NVARCHAR (50)   NULL,
    [growth_FertilityRequirement]         NVARCHAR (50)   NULL,
    [growth_DroughtTolerance]             NVARCHAR (50)   NULL,
    [growth_ColdStratificationRequired]   NVARCHAR (50)   NULL,
    [growth_CaCO3Tolerance]               NVARCHAR (50)   NULL,
    [growth_AnaerobicTolerance]           NVARCHAR (50)   NULL,
    [foliage_Texture]                     NVARCHAR (50)   NULL,
    [foliage_PorositySummer]              NVARCHAR (50)   NULL,
    [foliage_PorosityWinter]              NVARCHAR (50)   NULL,
    [foliage_Color]                       NVARCHAR (50)   NULL,
    [fruitOrSeed_Persistence]             NVARCHAR (50)   NULL,
    [fruitOrSeed_PeriodBegin]             NVARCHAR (50)   NULL,
    [fruitOrSeed_PeriodEnd]               NVARCHAR (50)   NULL,
    [fruitOrSeed_Abundance]               NVARCHAR (50)   NULL,
    [fruitOrSeed_Conspicuous]             NVARCHAR (50)   NULL,
    [fruitOrSeed_Color]                   NVARCHAR (50)   NULL,
    [flower_Conspicuous]                  NVARCHAR (50)   NULL,
    [flower_Color]                        NVARCHAR (50)   NULL,
    [products_Veneer]                     NVARCHAR (50)   NULL,
    [products_Pulpwood]                   NVARCHAR (50)   NULL,
    [products_ProteinPotential]           NVARCHAR (50)   NULL,
    [products_Post]                       NVARCHAR (50)   NULL,
    [products_PalatableHuman]             NVARCHAR (50)   NULL,
    [products_PalatableGrazeAnimal]       NVARCHAR (50)   NULL,
    [products_PalatableBrowseAnimal]      NVARCHAR (50)   NULL,
    [products_NurseryStock]               NVARCHAR (50)   NULL,
    [products_NavalStore]                 NVARCHAR (50)   NULL,
    [products_Lumber]                     NVARCHAR (50)   NULL,
    [products_Fuelwood]                   NVARCHAR (50)   NULL,
    [products_Fodder]                     NVARCHAR (50)   NULL,
    [products_ChristmasTree]              NVARCHAR (50)   NULL,
    [products_BerryNutSeed]               NVARCHAR (50)   NULL,
    [rowVersion]                          ROWVERSION      NOT NULL,
    CONSTRAINT [PK_Species] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90)
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Species_id]
    ON [plt].[Species]([id] ASC) WITH (FILLFACTOR = 90);

--SourcesData:
    --[sourceUrl]  NVARCHAR(50) NOT NULL
    --[sourceId]   INT          NOT NULL
    --[sourcename] NVARCHAR(50) NOT NULL
    --[lastUpdate] DATETIME     NOT NULL
