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
CREATE TABLE [frm].[GrowSpace]
(
    [id]                         UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [zoneId]                     UNIQUEIDENTIFIER NOT NULL,
    [name]                       NVARCHAR (50)    NOT NULL,
    --[3dBarcodeIdImage]           VARBINARY(MAX)   NULL, --[Generate On The Fly]
    [assignedWorkerId]           NVARCHAR (450)   NOT NULL,
    [setupTypeId]                INT              NOT NULL CONSTRAINT [DF_GrowSpace_setupTypeId] DEFAULT (0),
    [growSpaceTypeId]            INT              NOT NULL, --[display only depending on type? Cosmetic?]
    [growMediumTypeId]           INT              NOT NULL CONSTRAINT [DF_GrowSpace_growMediumTypeId] DEFAULT (0),
    --[atmosphereDetails]          NVARCHAR(50)     NULL, --(sound, vibrations and other resonating frequencies)
    [lightSourceTypeId]          INT              NOT NULL CONSTRAINT [DF_GrowSpace_lightSourceTypeId] DEFAULT (0), --link more info like 'https://www.sunlightinside.com/light-and-health/natural-light-vs-artificial-light/'
    [orientationFromLightSource] NVARCHAR (50)    NOT NULL, --(Direction / distance if available)
    --[topographyDetails]          NVARCHAR(50)     NULL, -- (& atmosphereicPresure)
    [totalAvailableSpace_m2]     DECIMAL (10, 2)  NOT NULL,
    [zoneOrder]                  INT              NOT NULL,
    [dateCreated]                DATETIME         NOT NULL,
    [userCreated]                NVARCHAR (450)   NOT NULL,
    [dateModified]               DATETIME         NOT NULL,
    [userModified]               NVARCHAR (450)   NOT NULL,
    [rowVersion]                 ROWVERSION       NOT NULL,
    CONSTRAINT [PK_GrowSpace] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_GrowSpace_growmediumTypeId] FOREIGN KEY ([growMediumTypeId]) REFERENCES [dbo].[GrowMediumType] ([id]),
    CONSTRAINT [FK_GrowSpace_growSpaceTypeId] FOREIGN KEY ([growSpaceTypeId]) REFERENCES [dbo].[GrowSpaceType] ([id]),
    CONSTRAINT [FK_GrowSpace_lightSourceTypeId] FOREIGN KEY ([lightSourceTypeId]) REFERENCES [dbo].[GrowSpaceLightSourceType] ([id]),
    CONSTRAINT [FK_GrowSpace_zoneId] FOREIGN KEY ([zoneId]) REFERENCES [frm].[Zone] ([id]),
    CONSTRAINT [FK_Zone_setupTypeIdId] FOREIGN KEY ([setupTypeId]) REFERENCES [dbo].[GrowSpaceSetupType] ([id])
    --CONSTRAINT [FK_GrowSpace_assignedWorkerId] FOREIGN KEY ([assignedWorkerId]) REFERENCES [acc].[SiF_Users] ([Id])

    --CONSTRAINT [FK_GrowSpace_subAreaIdArray] FOREIGN KEY ([subAreaIdArray]) REFERENCES [frm].[SubArea] ([id]) ON DELETE CASCADE
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_GrowSpace_id]
    ON [frm].[GrowSpace]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_GrowSpace_zoneId]
    ON [frm].[GrowSpace]([zoneId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_GrowSpace_setupTypeId]
    ON [frm].[GrowSpace]([setupTypeId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_GrowSpace_lightSourceTypeId]
    ON [frm].[GrowSpace]([lightSourceTypeId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_GrowSpace_growSpaceTypeId]
    ON [frm].[GrowSpace]([growSpaceTypeId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_GrowSpace_growMediumTypeId]
    ON [frm].[GrowSpace]([growMediumTypeId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_GrowSpace_assignedWorkerId]
    ON [frm].[GrowSpace]([assignedWorkerId] ASC);
