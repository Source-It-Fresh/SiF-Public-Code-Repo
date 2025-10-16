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
CREATE TABLE [plt].[Plant_Species]
(
    [plantId]    BIGINT     NOT NULL,
    [speciesId]  BIGINT     NOT NULL,
    [rowVersion] ROWVERSION NOT NULL,
    CONSTRAINT [PK_Plant_Species] PRIMARY KEY CLUSTERED ([plantId] ASC, [speciesId] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Plant_Species_Plant] FOREIGN KEY ([plantId]) REFERENCES [plt].[Plant] ([id]),
    CONSTRAINT [FK_Plant_Species_Species] FOREIGN KEY ([speciesId]) REFERENCES [plt].[Species] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Plant_Species_ID]
    ON [plt].[Plant_Species]([plantId] ASC, [speciesId] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Plant_Species_speciesId]
    ON [plt].[Plant_Species]([speciesId] ASC);
