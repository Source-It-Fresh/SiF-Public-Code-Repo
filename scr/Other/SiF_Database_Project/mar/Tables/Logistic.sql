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
CREATE TABLE [mar].[Logistic] --ToDo: DB~courier waybill information
(
    [id]               UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [orderId]          UNIQUEIDENTIFIER NOT NULL,
    [deliveryConfigId] UNIQUEIDENTIFIER NOT NULL,
    --Deliver/pickup address --fill from TE_Loccation, editable free text
    --[otherDelviveryDetails] NVARCHAR(MAX)    NULL, -- like address/location (include current location(onFarm,Planter/growing/curring/packaging/store/driver location))
    [tripCostper_xKm]  MONEY            NULL, -- (fuel/AA rates formula for range+)
    [driverCost]       MONEY            NULL,
    [details]          NVARCHAR (MAX)   NULL,
    [rowVersion]       ROWVERSION       NOT NULL,
    CONSTRAINT [PK_Logistic] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Logistics_deliveryConfigId] FOREIGN KEY ([deliveryConfigId]) REFERENCES [cmd].[DeliveryConfig] ([id]),
    CONSTRAINT [FK_Logistics_orderId] FOREIGN KEY ([orderId]) REFERENCES [mar].[Order] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Logistic_id]
    ON [mar].[Logistic]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Logistic_orderId]
    ON [mar].[Logistic]([orderId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Logistic_deliveryConfigId]
    ON [mar].[Logistic]([deliveryConfigId] ASC);
