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
CREATE TABLE [log].[SubAreaWaterDatum]
(
    [id]            UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [subAreaId]     UNIQUEIDENTIFIER NOT NULL,
    [amount_ml]     DECIMAL (10, 2)  NOT NULL,
    [duration_Time] NVARCHAR (50)    NULL,
    [comment]       NVARCHAR (MAX)   NULL,
    [dateCreated]   DATETIME         NOT NULL CONSTRAINT [DF_SubAreaWaterDatum_dateCreated] DEFAULT ('1900-01-01 00:00:00.000'),
    [rowVersion]    ROWVERSION       NOT NULL,
    CONSTRAINT [PK_SubAreaWaterDatum] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_SubAreaWaterDatum_subAreaId] FOREIGN KEY ([subAreaId]) REFERENCES [frm].[SubArea] ([id])
    
    --CONSTRAINT [FK_SubAreaWaterDatum_growSpaceIdArray] FOREIGN KEY ([growSpaceIdArray]) REFERENCES [frm].[GrowSpace] ([id]) ON DELETE CASCADE
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_SubAreaWaterDatum_id]
    ON [log].[SubAreaWaterDatum]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_SubAreaWaterDatum_subAreaId]
    ON [log].[SubAreaWaterDatum]([subAreaId] ASC);
