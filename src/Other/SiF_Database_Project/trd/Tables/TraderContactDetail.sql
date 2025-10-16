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
CREATE TABLE [trd].[TraderContactDetail]
(
    [id]                UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [websiteUrl]        NVARCHAR (100)   NOT NULL,
    [customerCareEmail] NVARCHAR (200)   NOT NULL,
    [phoneNumber]       NVARCHAR (50)    NULL,
    [otherDetails]      NVARCHAR (MAX)   NULL,
    --ToDo: DB~[landline]          INT               NOT NULL CONSTRAINT [DF_TraderEntity_traderTypeId] DEFAULT (0),
    --[skype]             UNIQUEIDENTIFIER  NOT NULL,
    --[callcenter]        UNIQUEIDENTIFIER  NOT NULL,
    [dateModified]      DATETIME         NOT NULL CONSTRAINT [DF_TraderContactDetail_dateModified] DEFAULT ('1900-01-01 00:00:00.000'),
    [userModified]      NVARCHAR (450)   NOT NULL,
    [rowVersion]        ROWVERSION       NOT NULL,
    CONSTRAINT [PK_TraderContactDetail] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90)
    --CONSTRAINT [FK_TraderContactDetail_User] FOREIGN KEY ([userModified]) REFERENCES [acc].[SiF_Users] ([Id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_TraderContactDetail_id]
    ON [trd].[TraderContactDetail]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_TraderContactDetail_userModified]
    ON [trd].[TraderContactDetail]([userModified] ASC);