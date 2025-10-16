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
CREATE TABLE [trd].[TraderLocation]
(
    [id]             UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [gpsCoordinates] NVARCHAR (100)   NOT NULL,
    [mapImage]       VARBINARY (MAX)  NULL,
    [countryRegion]  NVARCHAR (100)   NOT NULL,
    [stateProvince]  NVARCHAR (100)   NOT NULL,
    [city]           NVARCHAR (100)   NOT NULL,
    [postalCode]     NVARCHAR (100)   NOT NULL,
    [addressLine1]   NVARCHAR (100)   NOT NULL,
    [addressLine2]   NVARCHAR (100)   NOT NULL,
    [building]       NVARCHAR (100)   NOT NULL,
    [floorLevel]     NVARCHAR (100)   NOT NULL,
    [customDetails]  NVARCHAR (MAX)   NOT NULL,
    [municipalityId] BIGINT           NULL     CONSTRAINT [DF_TraderLocation_municipalityId] DEFAULT ('00000000-0000-0000-0000-000000000000'), /*N/A script in*/
    [dateModified]   DATETIME         NOT NULL CONSTRAINT [DF_TraderLocation_dateModified] DEFAULT ('1900-01-01 00:00:00.000'),
    [userModified]   NVARCHAR (450)   NOT NULL,
    [rowVersion]     ROWVERSION       NOT NULL,
    CONSTRAINT [PK_TraderLocation] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_TraderLocation_MunicipalityDetail] FOREIGN KEY ([municipalityId]) REFERENCES [dbo].[MunicipalityDetail] ([id])
    --CONSTRAINT [FK_TraderLocation_User] FOREIGN KEY ([userModified]) REFERENCES [acc].[SiF_Users] ([Id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_TraderLocation_id]
    ON [trd].[TraderLocation]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_TraderLocation_userModified]
    ON [trd].[TraderLocation]([userModified] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_TraderLocation_municipalityId]
    ON [trd].[TraderLocation]([municipalityId] ASC);
