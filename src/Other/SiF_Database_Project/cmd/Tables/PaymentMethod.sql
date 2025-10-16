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
CREATE TABLE [cmd].[PaymentMethod] --(ToDo: DB~add functionality for the phone app barcode scanning to update deliveryStatus & stock)
(
    [id]            UNIQUEIDENTIFIER NOT NULL  DEFAULT NEWID(), -- commodityId/type for primary key
    [commodityId]   UNIQUEIDENTIFIER NOT NULL,
    [name]          NVARCHAR (50)    NOT NULL,
    -- [customImage]   VARBINARY(MAX)   NULL, --(zaper,SnapScan,...or Logo)
    [paymentTypeId] INT              NOT NULL, -- [array of payment methods, one per type] --{Manage Payment methods (integrate with banking apps) look @ hyperleger & Authorize.Net} 
    [bankDetails]   NVARCHAR (MAX)   NOT NULL, --FormattedNoteText
    [dateCreated]   DATETIME         NOT NULL,
    [userCreated]   NVARCHAR (450)   NOT NULL,
    [dateModified]  DATETIME         NOT NULL,
    [userModified]  NVARCHAR (450)   NOT NULL,
    [rowVersion]    ROWVERSION       NOT NULL,
    CONSTRAINT [PK_PaymentMethod] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_PaymentMethod_Commodity] FOREIGN KEY ([commodityId]) REFERENCES [cmd].[Commodity] ([id]),
    CONSTRAINT [FK_PaymentMethod_PaymentType] FOREIGN KEY ([paymentTypeId]) REFERENCES [dbo].[PaymentType] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_PaymentMethod_id]
    ON [cmd].[PaymentMethod]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_PaymentMethod_paymentTypeId]
    ON [cmd].[PaymentMethod]([paymentTypeId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_PaymentMethod_commodityId]
    ON [cmd].[PaymentMethod]([commodityId] ASC);
