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
CREATE TABLE [mar].[OrderProduct] --ToDo: DB~Add option to trade/swap -no need for money
(
    [id]                UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [orderId]           UNIQUEIDENTIFIER NOT NULL,
    [productId]         UNIQUEIDENTIFIER NOT NULL, -- (*Dont allow Delete but remove to archive products*)
    [quantity]          INT              NOT NULL,
    [priceEach]         MONEY            NOT NULL,
    [currencyISO4217Id] INT              NOT NULL,
    [customPriceValue]  MONEY            NULL, --Discount/OverCharge
    [rowVersion]        ROWVERSION       NOT NULL,
    CONSTRAINT [PK_OrderProducts] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_OrderProducts_currencyISO4217Id] FOREIGN KEY ([currencyISO4217Id]) REFERENCES [dbo].[CurrencyISO4217] ([id]),
    CONSTRAINT [FK_OrderProducts_orderId] FOREIGN KEY ([orderId]) REFERENCES [mar].[Order] ([id]),
    CONSTRAINT [FK_OrderProducts_productId] FOREIGN KEY ([productId]) REFERENCES [cmd].[Product] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_OrderProducts_id]
    ON [mar].[OrderProduct]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_OrderProduct_productId]
    ON [mar].[OrderProduct]([productId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_OrderProduct_orderId]
    ON [mar].[OrderProduct]([orderId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_OrderProduct_currencyISO4217Id]
    ON [mar].[OrderProduct]([currencyISO4217Id] ASC);
