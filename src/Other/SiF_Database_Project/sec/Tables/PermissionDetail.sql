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
CREATE TABLE [sec].[PermissionDetail]
(
    [id]                   UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [securityGroupId]      UNIQUEIDENTIFIER NOT NULL,
    [applicationSectionId] UNIQUEIDENTIFIER NOT NULL,
    [allowedView]          BIT              NOT NULL CONSTRAINT [DF_PermissionDetail_allowedView] DEFAULT (0),
    [allowedAdd]           BIT              NOT NULL CONSTRAINT [DF_PermissionDetail_allowedAdd] DEFAULT (0),
    [allowedUpdate]        BIT              NOT NULL CONSTRAINT [DF_PermissionDetail_allowedUpdate] DEFAULT (0),
    [allowedDelete]        BIT              NOT NULL CONSTRAINT [DF_PermissionDetail_allowedDelete] DEFAULT (0),
    [dateModified]         DATETIME         NOT NULL CONSTRAINT [DF_PermissionDetail_dateModified] DEFAULT ('1900-01-01 00:00:00.000'),
    [userModified]         NVARCHAR (450)   NOT NULL,
    [rowVersion]           ROWVERSION       NOT NULL,
    CONSTRAINT [PK_PermissionDetail] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_PermissionDetail_ApplicationSection] FOREIGN KEY ([applicationSectionId]) REFERENCES [sec].[ApplicationSection] ([id]),
    CONSTRAINT [FK_PermissionDetail_SecurityGroup] FOREIGN KEY ([securityGroupId]) REFERENCES [sec].[SecurityGroup] ([id])
    --CONSTRAINT [FK_PermissionDetail_User] FOREIGN KEY ([userModified]) REFERENCES [acc].[SiF_Users] ([Id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_PermissionDetail_id]
    ON [sec].[PermissionDetail]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_PermissionDetail_userModified]
    ON [sec].[PermissionDetail]([userModified] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_PermissionDetail_securityGroupId]
    ON [sec].[PermissionDetail]([securityGroupId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_PermissionDetail_applicationSectionId]
    ON [sec].[PermissionDetail]([applicationSectionId] ASC);
