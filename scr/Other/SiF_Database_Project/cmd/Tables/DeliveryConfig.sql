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
CREATE TABLE [cmd].[DeliveryConfig]
(
    [id]                      UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [commodityId]             UNIQUEIDENTIFIER NOT NULL,
    [name]                    NVARCHAR (50)    NOT NULL,
    [deliveryMethodId]        INT              NOT NULL,
    [deliveryRange_km]        DECIMAL (10, 2)  NOT NULL,
    [deliveryRangePlotPoints] NVARCHAR (MAX)   NOT NULL, --(Delivering range can custom map with google plots/pins area)
    [pricePer_km]             DECIMAL (10, 2)  NOT NULL,
    -- [configDetails] (For Existing APIs e.g MrDelivery)
    -- {ToDo: DB~Add: paid service for delivery via phone-gps (Tracing, EstDeliver Time (from location, including traffic), Rough, Accident detection alert)}
    [dateCreated]             DATETIME         NOT NULL,
    [userCreated]             NVARCHAR (450)   NOT NULL,
    [dateModified]            DATETIME         NOT NULL,
    [userModified]            NVARCHAR (450)   NOT NULL,
    [rowVersion]              ROWVERSION       NOT NULL,
    CONSTRAINT [PK_DeliveryConfig] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_DeliveryConfig_Commodity] FOREIGN KEY ([commodityId]) REFERENCES [cmd].[Commodity] ([id]),
    CONSTRAINT [FK_DeliveryConfig_DeliveryMethod] FOREIGN KEY ([deliveryMethodId]) REFERENCES [dbo].[DeliveryMethod] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_DeliveryConfig_id]
    ON [cmd].[DeliveryConfig]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_DeliveryConfig_deliveryMethodId]
    ON [cmd].[DeliveryConfig]([deliveryMethodId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_DeliveryConfig_commodityId]
    ON [cmd].[DeliveryConfig]([commodityId] ASC);
