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
CREATE TABLE [plt].[Plant]
(
    [id]                BIGINT         NOT NULL IDENTITY (1, 1),
    [scientificName]    NVARCHAR (50)  NOT NULL,
    [commonEnglishName] NVARCHAR (50)  NULL,
    [familyCommonName]  NVARCHAR (50)  NULL,
    [imagesUrl]         NVARCHAR (200) NULL,
    [mainSpeciesId]     INT            NULL,
    [nativeStatus]      NVARCHAR (50)  NULL,
    [varieties]         NVARCHAR (MAX) NULL,
    [subSpecies]        NVARCHAR (MAX) NULL,
    [hybrids]           NVARCHAR (MAX) NULL,
    [forms]             NVARCHAR (MAX) NULL,
    [cultivars]         NVARCHAR (MAX) NULL,
    [genusId]           INT            NULL,
    [familyId]          INT            NULL,
    [divisionOrderId]   INT            NULL,
    [divisionClassId]   INT            NULL,
    [divisionId]        INT            NULL,
    [rowVersion]        ROWVERSION     NOT NULL,
    CONSTRAINT [PK_Plant] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90)
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Plant_id]
    ON [plt].[Plant]([id] ASC) WITH (FILLFACTOR = 90);

--SourcesData:
    --[sourceUrl]  NVARCHAR(50) NOT NULL
    --[sourceId]   INT          NOT NULL
    --[sourcename] NVARCHAR(50) NOT NULL
    --[lastUpdate] DATETIME     NOT NULL
