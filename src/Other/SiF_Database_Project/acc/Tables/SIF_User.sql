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
CREATE TABLE [acc].[SiF_User]
(
    [Id]                   NVARCHAR (450)     NOT NULL,
    [firstName]            NVARCHAR (100)     NULL,
    [lastName]             NVARCHAR (100)     NULL,
    [ProfilePicture]       VARBINARY(MAX)     NULL,
    [bio]                  NVARCHAR (250)     NULL,
    [UserInit]             BIT                NOT NULL,
    [UserName]             NVARCHAR (256)     NULL,
    [NormalizedUserName]   NVARCHAR (256)     NULL,
    [Email]                NVARCHAR (256)     NULL,
    [NormalizedEmail]      NVARCHAR (256)     NULL,
    [EmailConfirmed]       BIT                NOT NULL,
    [PasswordHash]         NVARCHAR (MAX)     NULL,
    [SecurityStamp]        NVARCHAR (MAX)     NULL,
    [ConcurrencyStamp]     NVARCHAR (MAX)     NULL,
    [PhoneNumber]          NVARCHAR (MAX)     NULL,
    [PhoneNumberConfirmed] BIT                NOT NULL,
    [TwoFactorEnabled]     BIT                NOT NULL,
    [LockoutEnd]           DATETIMEOFFSET (7) NULL,
    [LockoutEnabled]       BIT                NOT NULL,
    [AccessFailedCount]    INT                NOT NULL,
    CONSTRAINT [PK_SiF_User] PRIMARY KEY CLUSTERED ([Id] ASC),
--    CONSTRAINT [FK_SiF_User_defaultAuthenticationProviderId] FOREIGN KEY ([defaultAuthenticationProviderId]) REFERENCES [dbo].[AuthenticationProvider] ([id]),
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex]
    ON [acc].[SiF_User]([NormalizedUserName] ASC) WHERE ([NormalizedUserName] IS NOT NULL);

GO
CREATE NONCLUSTERED INDEX [EmailIndex]
    ON [acc].[SiF_User]([NormalizedEmail] ASC);
