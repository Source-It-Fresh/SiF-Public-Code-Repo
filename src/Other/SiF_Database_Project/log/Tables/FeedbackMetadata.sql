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
CREATE TABLE [log].[FeedbackMetadata] --ToDo: DB~webkay
(
    [id]                          UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [location]                    NVARCHAR (100)   NULL,
    [operatingSystem]             NVARCHAR (100)   NULL,
    [browser]                     NVARCHAR (100)   NULL,
    [browserPlugins]              NVARCHAR (100)   NULL,
    [cpu]                         NVARCHAR (100)   NULL,
    [publicIP]                    NVARCHAR (100)   NULL,
    [connectionSpeed]             NVARCHAR (100)   NULL,
    [connectedSocialMediaAcounts] NVARCHAR (250)   NULL,
    [dateCreated]                 DATETIME         NOT NULL,
    [rowVersion]                  ROWVERSION       NOT NULL,
    CONSTRAINT [PK_FeedbackMetadata] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90)
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_FeedbackMetadata_id]
    ON [log].[FeedbackMetadata]([id] ASC) WITH (FILLFACTOR = 90);
