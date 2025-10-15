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
CREATE TABLE [log].[GrowSpaceDatum]
(
    [id]             UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [growSpaceId]    UNIQUEIDENTIFIER NOT NULL,
    [entryTypeId]    INT              NOT NULL CONSTRAINT [DF_GrowSpaceDatum_entryTypeId] DEFAULT (0),
    [phLevel]        DECIMAL (6, 4)   NOT NULL,
    [temperature_°C] DECIMAL (7, 3)   NOT NULL,
    [humidity_gpm3]  DECIMAL (7, 3)   NOT NULL,
    [comment]        NVARCHAR (MAX)   NULL,
    [dateCreated]    DATETIME         NOT NULL CONSTRAINT [DF_GrowSpaceDatum_dateCreated] DEFAULT ('1900-01-01 00:00:00.000'),
    [rowVersion]     ROWVERSION       NOT NULL,
    CONSTRAINT [PK_GrowSpaceDatum] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_GrowSpaceDatum_entryTypeId] FOREIGN KEY ([entryTypeId]) REFERENCES [dbo].[GrowSpaceDataEntryType] ([id]),
    CONSTRAINT [FK_GrowSpaceDatum_growSpaceId] FOREIGN KEY ([growSpaceId]) REFERENCES [frm].[GrowSpace] ([id])

    --CONSTRAINT [FK_Farm_growSpaceIdArray] FOREIGN KEY ([growSpaceIdArray]) REFERENCES [frm].[GrowSpace] ([id]) ON DELETE CASCADE
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_GrowSpaceDatum_id]
    ON [log].[GrowSpaceDatum]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_GrowSpaceDatum_growSpaceId]
    ON [log].[GrowSpaceDatum]([growSpaceId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_GrowSpaceDatum_entryTypeId]
    ON [log].[GrowSpaceDatum]([entryTypeId] ASC);
