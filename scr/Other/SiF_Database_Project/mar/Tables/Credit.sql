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
CREATE TABLE [mar].[Credit] --ToDo: DB~Calculate total for UI, both parties and system should be aware of this.
(
    [id]                UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [creditorId]        UNIQUEIDENTIFIER NOT NULL, --It is a person or institution to whom money is owed
    [debtorId]          UNIQUEIDENTIFIER NOT NULL, --A debtor is an entity that owes a debt to another entity
    [currencyISO4217Id] INT              NOT NULL,
    [amount]            MONEY            NULL,
    [details]           NVARCHAR (MAX)   NULL,
    [rowVersion]        ROWVERSION       NOT NULL,
    CONSTRAINT [PK_Credit] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Credit_creditorId] FOREIGN KEY ([creditorId]) REFERENCES [trd].[TraderEntity] ([id]),
    CONSTRAINT [FK_Credit_currencyISO4217Id] FOREIGN KEY ([currencyISO4217Id]) REFERENCES [dbo].[CurrencyISO4217] ([id]),
    CONSTRAINT [FK_Credit_debtorId] FOREIGN KEY ([debtorId]) REFERENCES [trd].[TraderEntity] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Credit_id]
    ON [mar].[Credit]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Credit_debtorId]
    ON [mar].[Credit]([debtorId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Credit_currencyISO4217Id]
    ON [mar].[Credit]([currencyISO4217Id] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Credit_creditorId]
    ON [mar].[Credit]([creditorId] ASC);
