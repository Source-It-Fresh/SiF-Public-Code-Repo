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
CREATE TABLE [log].[SubAreaHarvestDatum] --ToDo: DB~To Track outcomes and facilitate goods > consumable details _#ScockOverviewDashboard as SQL view?
(
    [id]                  UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [subAreaId]           UNIQUEIDENTIFIER NULL, --Make not null and default goods or subarea to get duale use for userser only utilizing a potion of the app
    [name]                NVARCHAR (50)    NOT NULL,
    [actualPhoto]         VARBINARY (MAX)  NULL,
    [plantId]             BIGINT           NULL, --(get Category: plant, flower, fruit, other)
            --[commonEnglishName]    NVARCHAR(50)     NOT NULL,
            --[botanicalName]        NVARCHAR(50)     NOT NULL,
            --[description]          NVARCHAR(250)    NOT NULL,
            --[conservationStatusId] SMALLINT         NULL, --Conservation status: (Color Border) integrate with {NatureServe_conservation_status} via (IUCN RedList) International Union for Conservation of Nature
            --Category: plant, flower, fruit, other
            --(More uses and details) ? Associated plants / Associated goods ? [available from products]? (Manually mange and get from farm output ) ? (Growing A might give A,B and E as sell-able goods)
            --Scientific_Classification {from global plant list} (Kingdom(Subkingdom), DivisionClass&Order(Phylum,Clade), Family, Genus, Species)
            --Other:
            --  - Best growing technique (list with each)
            --  - Best farmType, plant time ect
    [dateHarvested]       DATETIME         NULL CONSTRAINT [DF_SubAreaHarvestDatum_dateProduced] DEFAULT ('1900-01-01 00:00:00.000'), --(Harvested / manufactured / made) --pull from harvest if avalible
    [itemCountTotal]      INT              NULL, --(plants, fruits, flowers, seeds, backed goods) by count and or weight, volume
    --[IndividualAverage]    INT              NULL,  -- by count and or weight, volume (plants, fruits, flowers, seeds, backed goods) 
    --Actual/Average_Size/Dimensions: --pull from harvest if available
    [length]              DECIMAL (10, 2)  NULL,
    [width]               DECIMAL (10, 2)  NULL,
    [height]              DECIMAL (10, 2)  NULL,
    [weight]              DECIMAL (10, 2)  NULL,
    [volume]              DECIMAL (10, 2)  NULL,
    [quantityGrade]       NVARCHAR (50)    NULL,
    [storageDetails]      NVARCHAR (250)   NULL, --Intended storage(full sub expansion for storageAndTransport app idea)
    [comments]            NVARCHAR (MAX)   NULL, --OtherCustomDetails
--AdditionalHarvestDetailsId
    [synonyms]            NVARCHAR (250)   NULL,
    [varieties]           NVARCHAR (250)   NULL,
    [naturalRange]        NVARCHAR (250)   NULL,
    [uses]                NVARCHAR (250)   NULL,
    [nutrition]           NVARCHAR (250)   NULL,
    [production]          NVARCHAR (250)   NULL,
    [reproduction]        NVARCHAR (250)   NULL,
    [cultivation]         NVARCHAR (250)   NULL,
    [pestsAndDiseases]    NVARCHAR (250)   NULL,
    [storageAndTransport] NVARCHAR (250)   NULL,
    [ecology]             NVARCHAR (250)   NULL,
    [botany]              NVARCHAR (250)   NULL,
    [history]             NVARCHAR (250)   NULL,

    [dateCreated]         DATETIME         NOT NULL,
    [userCreated]         NVARCHAR (450)   NOT NULL,
    [dateModified]        DATETIME         NOT NULL,
    [userModified]        NVARCHAR (450)   NOT NULL,
    [rowVersion]          ROWVERSION       NOT NULL,
    CONSTRAINT [PK_SubAreaHarvestDatum] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_SubAreaHarvestDatum_Plant] FOREIGN KEY ([plantId]) REFERENCES [dbo].[TrefleData] ([id]),
    CONSTRAINT [FK_SubAreaHarvestDatum_SubArea] FOREIGN KEY ([subAreaId]) REFERENCES [frm].[SubArea] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_SubAreaHarvestDatum_id]
    ON [log].[SubAreaHarvestDatum]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_SubAreaHarvestDatum_subAreaId]
    ON [log].[SubAreaHarvestDatum]([subAreaId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_SubAreaHarvestDatum_plantId]
    ON [log].[SubAreaHarvestDatum]([plantId] ASC);
