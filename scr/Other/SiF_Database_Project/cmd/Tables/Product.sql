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
CREATE TABLE [cmd].[Product] --ToDo: DB~allow for custom products such as jam, dried fruit and other by products --Natural / processed / reworked (might need to add product category) plant, foodItem(intended for human consumption), feed(for animal), item/object, composting, other??
(
    [id]                         UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [commodityId]                UNIQUEIDENTIFIER NOT NULL,
    [name]                       NVARCHAR (50)    NOT NULL,
    [photo]                      VARBINARY (MAX)  NULL,
    [shortDescription]           NVARCHAR (250)   NULL,
    [fullDescription]            NVARCHAR (MAX)   NULL,
    [consumableId]               UNIQUEIDENTIFIER NULL, -- >> Link to Consumable >> Link to Crop
        -- Quantity Grade
        -- Date Produced
        -- Dimensions (length, width, height, weight, volume)
        -- Other
    [datePackaged]               DATETIME         NOT NULL CONSTRAINT [DF_Product_datePackaged] DEFAULT ('1900-01-01 00:00:00.000'), --ToDo: Add Consumable Expiration Date (calculated from production Date) / basted on harvest and storage
    [quantityInStock]            INT              NOT NULL, -- move out, is count stat
    [packageId]                  UNIQUEIDENTIFIER NULL, --(allow Custom details)[private/public]share list
        -- Package Specification (package biodegradable, no packaging)
        -- Packaged Dimensions (length, width, height, weight, volume)
        -- Other
    [priceExclVatTax_moneyUnits] DECIMAL (10, 2)  NOT NULL, --money unites of currency X
    [vat_pct]                    DECIMAL (10, 2)  NOT NULL, --percentage 
    [tax_pct]                    DECIMAL (10, 2)  NOT NULL, --percentage 
        -- ?price breakdown details ID group sub container (display only)?
        -- Production Cost (Average Per unit)
        -- Packaging Cost
        -- Storage Cost (minimize to zero)
    [allowDiscount]              BIT              NULL,
    [isOnSale]                   BIT              NULL, --Live/Now
    [discount_pct]               DECIMAL (10, 2)  NULL, --percentage
    [fixedPrice_moneyUnits]      DECIMAL (10, 2)  NULL, --money unites of currency X
    [newPriceTotal]              DECIMAL (10, 2)  NULL, --money unites of currency X
    [saleEndDate]                DATETIME         NULL CONSTRAINT [DF_Product_saleEndDate] DEFAULT ('1900-01-01 00:00:00.000'),
    [dateCreated]                DATETIME         NOT NULL,
    [userCreated]                NVARCHAR (450)   NOT NULL,
    [dateModified]               DATETIME         NOT NULL,
    [userModified]               NVARCHAR (450)   NOT NULL,
    [rowVersion]                 ROWVERSION       NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Product_Commodity] FOREIGN KEY ([commodityId]) REFERENCES [cmd].[Commodity] ([id]),
    CONSTRAINT [FK_Product_Consumable] FOREIGN KEY ([consumableId]) REFERENCES [cmd].[Consumable] ([id]),
    CONSTRAINT [FK_Product_Package] FOREIGN KEY ([packageId]) REFERENCES [cmd].[Packaging] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Product_id]
    ON [cmd].[Product]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Product_packageId]
    ON [cmd].[Product]([packageId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Product_consumableId]
    ON [cmd].[Product]([consumableId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Product_commodityId]
    ON [cmd].[Product]([commodityId] ASC);
