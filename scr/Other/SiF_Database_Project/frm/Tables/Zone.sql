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
CREATE TABLE [frm].[Zone]
(
    [id]                     UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [farmId]                 UNIQUEIDENTIFIER NOT NULL,
    [name]                   NVARCHAR (50)    NOT NULL,
    [managerBaseUserId]      NVARCHAR (450)   NOT NULL,
    [classificationTypeId]   INT              NOT NULL CONSTRAINT [DF_Zone_classificationTypeId] DEFAULT (0),
    [climateTypeId]          INT              NULL     CONSTRAINT [DF_Zone_climateTypeId] DEFAULT (0),
    [totalAvailableSpace_m2] DECIMAL (10, 2)  NOT NULL,
    [farmOrder]              INT              NOT NULL,
    [dateCreated]            DATETIME         NOT NULL,
    [userCreated]            NVARCHAR (450)   NOT NULL,
    [dateModified]           DATETIME         NOT NULL,
    [userModified]           NVARCHAR (450)   NOT NULL,
    [rowVersion]             ROWVERSION       NOT NULL,
    CONSTRAINT [PK_Zone] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Zone_classificationTypeId] FOREIGN KEY ([classificationTypeId]) REFERENCES [dbo].[ZoneClassification] ([id]),
    CONSTRAINT [FK_Zone_climateTypeId] FOREIGN KEY ([climateTypeId]) REFERENCES [dbo].[ZoneClimateType] ([id]),
    CONSTRAINT [FK_Zone_farmId] FOREIGN KEY ([farmId]) REFERENCES [frm].[Farm] ([id])
    --CONSTRAINT [FK_Zone_managerBaseUserId] FOREIGN KEY ([managerBaseUserId]) REFERENCES [acc].[SiF_Users] ([Id])

    --CONSTRAINT [FK_Zone_growSpaceIdArray] FOREIGN KEY ([growSpaceIdArray]) REFERENCES [frm].[GrowSpace] ([id]) ON DELETE CASCADE

);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Zone_id]
    ON [frm].[Zone]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Zone_managerBaseUserId]
    ON [frm].[Zone]([managerBaseUserId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Zone_farmId]
    ON [frm].[Zone]([farmId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Zone_climateTypeId]
    ON [frm].[Zone]([climateTypeId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Zone_classificationTypeId]
    ON [frm].[Zone]([classificationTypeId] ASC);
