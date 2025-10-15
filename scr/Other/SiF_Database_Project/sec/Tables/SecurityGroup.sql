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
CREATE TABLE [sec].[SecurityGroup]
(
    [id]                  UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [name]                NVARCHAR (50)    NOT NULL,
    [isSystemConfig]      BIT              NOT NULL CONSTRAINT [DF_SecurityGroup_isSystemConfig] DEFAULT (0),
    [traderEntityOwnerId] UNIQUEIDENTIFIER NOT NULL,
    [dateCreated]         DATETIME         NOT NULL,
    [userCreated]         NVARCHAR (450)   NOT NULL,
    [dateModified]        DATETIME         NOT NULL CONSTRAINT [DF_SecurityGroup_dateModified] DEFAULT ('1900-01-01 00:00:00.000'),
    [userModified]        NVARCHAR (450)   NOT NULL,
    [rowVersion]          ROWVERSION       NOT NULL,
    CONSTRAINT [PK_SecurityGroup] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_SecurityGroup_TraderEntity] FOREIGN KEY ([traderEntityOwnerId]) REFERENCES [trd].[TraderEntity] ([id])
    --CONSTRAINT [FK_SecurityGroup_UserC] FOREIGN KEY ([userCreated]) REFERENCES [acc].[SiF_Users] ([Id]),
    --CONSTRAINT [FK_SecurityGroup_UserM] FOREIGN KEY ([userModified]) REFERENCES [acc].[SiF_Users] ([Id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_SecurityGroup_id]
    ON [sec].[SecurityGroup]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_SecurityGroup_userModified]
    ON [sec].[SecurityGroup]([userModified] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_SecurityGroup_userCreated]
    ON [sec].[SecurityGroup]([userCreated] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_SecurityGroup_traderEntityOwnerId]
    ON [sec].[SecurityGroup]([traderEntityOwnerId] ASC);
