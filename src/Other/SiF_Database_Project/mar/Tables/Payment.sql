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
CREATE TABLE [mar].[Payment]
(
    [id]                UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [orderId]           UNIQUEIDENTIFIER NOT NULL,
    [currencyISO4217Id] INT              NOT NULL,
    -- TotalAmmountDue
    [paymentTypeId]     INT              NOT NULL,
    -- account/credit...???
    [depositAmount]     MONEY            NOT NULL,
    [isPaidInFull]      BIT              NOT NULL,
    [outstandingAmount] MONEY            NULL,
    [paymentDate]       DATETIME         NULL,
    [paidBy]            NVARCHAR (50)    NULL, --ToDo: DB~ LinkTo TE, what about walk in customer
    [details]           NVARCHAR (MAX)   NULL,
    [rowVersion]        ROWVERSION       NOT NULL,
    CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Order_currencyISO4217Id] FOREIGN KEY ([currencyISO4217Id]) REFERENCES [dbo].[CurrencyISO4217] ([id]),
    CONSTRAINT [FK_Order_orderId] FOREIGN KEY ([orderId]) REFERENCES [mar].[Order] ([id]),
    CONSTRAINT [FK_Order_paymentTypeId] FOREIGN KEY ([paymentTypeId]) REFERENCES [dbo].[PaymentType] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Payment_id]
    ON [mar].[Payment]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Payment_paymentTypeId]
    ON [mar].[Payment]([paymentTypeId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Payment_orderId]
    ON [mar].[Payment]([orderId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Payment_currencyISO4217Id]
    ON [mar].[Payment]([currencyISO4217Id] ASC);
