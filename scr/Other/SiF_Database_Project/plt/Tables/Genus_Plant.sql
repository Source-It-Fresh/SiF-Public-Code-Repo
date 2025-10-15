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
CREATE TABLE [plt].[Genus_Plant]
(
    [genusId]    INT        NOT NULL,
    [plantId]    BIGINT     NOT NULL,
    [rowVersion] ROWVERSION NOT NULL,
    CONSTRAINT [PK_Genus_Plant] PRIMARY KEY CLUSTERED ([genusId] ASC, [plantId] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Genus_Plant_Genus] FOREIGN KEY ([genusId]) REFERENCES [plt].[Genus] ([id]),
    CONSTRAINT [FK_Genus_Plant_Plant] FOREIGN KEY ([plantId]) REFERENCES [plt].[Plant] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Genus_Plant_ID]
    ON [plt].[Genus_Plant]([genusId] ASC, [plantId] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Genus_Plant_plantId]
    ON [plt].[Genus_Plant]([plantId] ASC);
