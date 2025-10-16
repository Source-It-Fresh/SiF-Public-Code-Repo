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
CREATE TABLE [frm].[Farm] --ToDo: DB~Climate From Location / Name From TE
(
    [id]                       UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [traderEntityId]           UNIQUEIDENTIFIER NOT NULL,
    [name]                     NVARCHAR (50)    NOT NULL,
    [cultureId]                INT              NOT NULL CONSTRAINT [DF_Farm_Culture] DEFAULT (0),
    [agricultureApproachId]    INT              NOT NULL CONSTRAINT [DF_Farm_AgricultureApproach] DEFAULT (0),
    [borderDetails]            NVARCHAR (MAX)   NULL,
    [propertyArea_m2]          DECIMAL (10, 2)  NULL     CONSTRAINT [DF_Farm_GrowArea] DEFAULT (0),
    [speciesPreference]        NVARCHAR (MAX)   NULL,
    [soilAndGrowMedium]        BIT              NOT NULL CONSTRAINT [DF_Farm_SoilAndGrowMedium] DEFAULT (1),
    [waterManagement]          BIT              NOT NULL CONSTRAINT [DF_Farm_Water] DEFAULT (1),
    [nutrientsManagement]      BIT              NOT NULL CONSTRAINT [DF_Farm_Nutrients] DEFAULT (1),
    [energyManagement]         BIT              NOT NULL CONSTRAINT [DF_Farm_Energy] DEFAULT (1),
    [diseaseControlManagement] BIT              NOT NULL CONSTRAINT [DF_Farm_DiseaseControl] DEFAULT (1),
    [sustainabilityManagement] BIT              NOT NULL CONSTRAINT [DF_Farm_Sustainability] DEFAULT (1),
    [pestsManagement]          BIT              NOT NULL CONSTRAINT [DF_Farm_Pests] DEFAULT (1),
    [weedsManagement]          BIT              NOT NULL CONSTRAINT [DF_Farm_Weed] DEFAULT (1),
    [dateCreated]              DATETIME         NOT NULL,
    [userCreated]              NVARCHAR (450)   NOT NULL,
    [dateModified]             DATETIME         NOT NULL,
    [userModified]             NVARCHAR (450)   NOT NULL,
    [rowVersion]               ROWVERSION       NOT NULL,
    CONSTRAINT [PK_Farm] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Farm_agricultureApproachId] FOREIGN KEY ([agricultureApproachId]) REFERENCES [dbo].[FarmAgriculture] ([id]),
    CONSTRAINT [FK_Farm_cultureId] FOREIGN KEY ([cultureId]) REFERENCES [dbo].[FarmCulture] ([id]),
    CONSTRAINT [FK_Farm_traderEntityId] FOREIGN KEY ([traderEntityId]) REFERENCES [trd].[TraderEntity] ([id])

    --CONSTRAINT [FK_Farm_zoneIdArray] FOREIGN KEY ([zoneIdArray]) REFERENCES [frm].[Zone] ([id]) ON DELETE CASCADE
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Farm_id]
    ON [frm].[Farm]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Farm_traderEntityId]
    ON [frm].[Farm]([traderEntityId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Farm_cultureId]
    ON [frm].[Farm]([cultureId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Farm_agricultureApproachId]
    ON [frm].[Farm]([agricultureApproachId] ASC);
