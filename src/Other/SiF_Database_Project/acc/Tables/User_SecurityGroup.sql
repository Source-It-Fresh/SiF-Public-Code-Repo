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
CREATE TABLE [acc].[User_SecurityGroup]
(
    [userBaseId]      NVARCHAR (450)   NOT NULL,
    [securityGroupId] UNIQUEIDENTIFIER NOT NULL,
    [rowVersion]      ROWVERSION       NOT NULL,
    CONSTRAINT [PK_User_SecurityGroup] PRIMARY KEY CLUSTERED ([userBaseId] ASC, [securityGroupId] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_User_SecurityGroup_SecurityGroup] FOREIGN KEY ([securityGroupId]) REFERENCES [sec].[SecurityGroup] ([id])
    --CONSTRAINT [FK_User_SecurityGroup_User] FOREIGN KEY ([userBaseId]) REFERENCES [acc].[SiF_Users] ([Id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_User_SecurityGroup_Id]
    ON [acc].[User_SecurityGroup]([userBaseId] ASC, [securityGroupId] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_User_SecurityGroup_securityGroupId]
    ON [acc].[User_SecurityGroup]([securityGroupId] ASC);
