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
CREATE TABLE [frm].[SubArea]
(
    [id]              UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [growSpaceId]     UNIQUEIDENTIFIER NOT NULL,
    [name]            NVARCHAR (50)    NOT NULL,
    --[3dBarcodeIdImage]    VARBINARY(MAX)   NULL, --[Generate On The Fly]
    [cropId]          BIGINT           NULL, -- ToDo: DB~Link >>> (all details)
    [plantSpacing_cm] DECIMAL (10, 2)  NOT NULL,  --(ToDo: DB~auto: dynamic/SiF_appDetermand)||(manual: 15mm apart)
    [numberOfSeeds]   INT              NOT NULL,
    [startPosition]   INT              NOT NULL, -- (Display in grid image topdown layout plan)
    [datePlanted]     DATETIME         NOT NULL CONSTRAINT [DF_SubArea_datePlanted] DEFAULT ('1900-01-01 00:00:00.000'),
    [estHarvestDate]  DATETIME         NOT NULL CONSTRAINT [DF_SubArea_estHarvestDate] DEFAULT ('1900-01-01 00:00:00.000'),
    [growSpaceOrder]  INT              NOT NULL,
    
    --ToDo: DB~Chemistry
    --**Cation and anion exchange
    --###Cation exchange capacity (CEC)
    --###Anion exchange capacity (AEC)
    --**Reactivity (pH)
    --###Base saturation percentage
    --**Buffering

    --ToDo: DB~Nutrients
    --**Uptake processes
    --**Carbon
    --**Nitrogen
    --####Gains
    --####Sequestration
    --####Losses
    --**Phosphorus
    --**Potassium
    --**Calcium
    --**Magnesium
    --**Sulfur
    --**Micro-nutrients
    --**Non-essential nutrients

    -- {Add: paid service for Plant health-care - analyze leave image to determine plate illness/deficiencies}
    [dateCreated]     DATETIME         NOT NULL,
    [userCreated]     NVARCHAR (450)   NOT NULL,
    [dateModified]    DATETIME         NOT NULL,
    [userModified]    NVARCHAR (450)   NOT NULL,
    [rowVersion]      ROWVERSION       NOT NULL,
    CONSTRAINT [PK_SubArea] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_SubArea_cropId] FOREIGN KEY ([cropId]) REFERENCES [dbo].[TrefleData] ([id]),
    CONSTRAINT [FK_SubArea_growSpaceId] FOREIGN KEY ([growSpaceId]) REFERENCES [frm].[GrowSpace] ([id])

    --CONSTRAINT [FK_SubArea_growSpaceIdArray] FOREIGN KEY ([growSpaceIdArray]) REFERENCES [frm].[GrowSpace] ([id]) ON DELETE CASCADE
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_SubArea_id]
    ON [frm].[SubArea]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_SubArea_growSpaceId]
    ON [frm].[SubArea]([growSpaceId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_SubArea_cropId]
    ON [frm].[SubArea]([cropId] ASC);
