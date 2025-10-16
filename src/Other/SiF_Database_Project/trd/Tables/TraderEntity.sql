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
CREATE TABLE [trd].[TraderEntity]
(
    [id]              UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [name]            NVARCHAR (50)    NOT NULL,
    [logoImage]       VARBINARY (MAX)  NULL,    --CONSTRAINT [DF_TraderEntity_logo] DEFAULT ('SiF_User_logo.png'),
    [traderTypeId]    INT              NOT NULL CONSTRAINT [DF_TraderEntity_traderTypeId] DEFAULT (0),
    [locationId]      UNIQUEIDENTIFIER NOT NULL,
    [contactDetailId] UNIQUEIDENTIFIER NOT NULL,
    --[manageGoods]            NVARCHAR(100)    NULL,
    --[deliveryPaymentMethods] NVARCHAR(100)    NULL,
    [vatNumber]       NVARCHAR (100)   NULL     CONSTRAINT [DF_TraderEntity_vatNumber] DEFAULT ('Not Supplied'),
    [dateCreated]     DATETIME         NOT NULL,
    [userCreated]     NVARCHAR (450)   NOT NULL,
    [dateModified]    DATETIME         NOT NULL CONSTRAINT [DF_TraderEntity_dateModified] DEFAULT ('1900-01-01 00:00:00.000'),
    [userModified]    NVARCHAR (450)   NOT NULL,
    [rowVersion]      ROWVERSION       NOT NULL,
    CONSTRAINT [PK_TraderEntity] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_TraderEntity_TraderContactDetail] FOREIGN KEY ([contactDetailId]) REFERENCES [trd].[TraderContactDetail] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TraderEntity_TraderLocation] FOREIGN KEY ([locationId]) REFERENCES [trd].[TraderLocation] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TraderEntity_TraderType] FOREIGN KEY ([traderTypeId]) REFERENCES [dbo].[TraderType] ([id])
    --CONSTRAINT [FK_TraderEntity_UserC] FOREIGN KEY ([userCreated]) REFERENCES [acc].[SiF_Users] ([Id]),
    --CONSTRAINT [FK_TraderEntity_UserM] FOREIGN KEY ([userModified]) REFERENCES [acc].[SiF_Users] ([Id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_TraderEntity_id]
    ON [trd].[TraderEntity]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_TraderEntity_userModified]
    ON [trd].[TraderEntity]([userModified] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_TraderEntity_userCreated]
    ON [trd].[TraderEntity]([userCreated] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_TraderEntity_traderTypeId]
    ON [trd].[TraderEntity]([traderTypeId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_TraderEntity_locationId]
    ON [trd].[TraderEntity]([locationId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_TraderEntity_contactDetailId]
    ON [trd].[TraderEntity]([contactDetailId] ASC);
