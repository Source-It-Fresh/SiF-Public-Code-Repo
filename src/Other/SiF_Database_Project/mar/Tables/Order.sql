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
CREATE TABLE [mar].[Order]--transacton --ToDo: DB~add contacpersondetails for delivery
(
    [id]                  UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(), --orderNumber/IncoiceID --QuoteID/Reference
    [orderPlaced]         DATETIME         NOT NULL,
    --[seller_TE_Id] (link from Product, what if discontinued)
    [buyer_TE_Id]         UNIQUEIDENTIFIER NOT NULL,
    [requiredDate]        DATETIME         NULL,
    [customerInstruction] NVARCHAR (MAX)   NULL,
    --[paymentId]           UNIQUEIDENTIFIER NULL,
        --[paymentTypeId]       SMALLINT         NOT NULL,
        -- account/credit...???
        --[isPaidInFull]       BIT              NOT NULL,
        --[depositAmount]       BIT              NOT NULL,
    --[outstandingAmount]   MONEY            NULL,
    [orderStatusId]       INT              NOT NULL, --(Display %orders canceled /honored per consumer)
    --[logisticId]          UNIQUEIDENTIFIER NOT NULL,
        --Delivery method Id
        --Deliver/pickup address --fill from TE_Loccation, editable free text
        --Other Delivery Details  like address/location
        --tripCostper xKm (fuel/AA rates formula for range+)
        --driverCost,
    [orderFulfilmentDate] DATETIME         NULL,
    [rowVersion]          ROWVERSION       NOT NULL,
    --Link to all reviews for this product / vendor / (?specific order?)
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Order_buyer_TE_Id] FOREIGN KEY ([buyer_TE_Id]) REFERENCES [trd].[TraderEntity] ([id]),
    CONSTRAINT [FK_Order_orderStatusId] FOREIGN KEY ([orderStatusId]) REFERENCES [dbo].[OrderStatus] ([id])
    --CONSTRAINT [FK_Order_paymentId] FOREIGN KEY ([paymentId]) REFERENCES [mar].[Payment] ([id]),
    --CONSTRAINT [FK_Order_paymentTypeId] FOREIGN KEY ([paymentTypeId]) REFERENCES [dbo].[PaymentType] ([id]),
    --CONSTRAINT [FK_Order_orderStatusId] FOREIGN KEY ([orderStatusId]) REFERENCES [mar].[Logistic] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Order_id]
    ON [mar].[Order]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Order_orderStatusId]
    ON [mar].[Order]([orderStatusId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Order_buyer_TE_Id]
    ON [mar].[Order]([buyer_TE_Id] ASC);
