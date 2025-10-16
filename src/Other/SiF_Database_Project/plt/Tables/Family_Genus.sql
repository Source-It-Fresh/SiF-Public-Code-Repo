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
CREATE TABLE [plt].[Family_Genus]
(
    [familyId]   INT        NOT NULL,
    [genusId]    INT        NOT NULL,
    [rowVersion] ROWVERSION NOT NULL,
    CONSTRAINT [PK_Family_Genus] PRIMARY KEY CLUSTERED ([familyId] ASC, [genusId] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Family_Genus_Family] FOREIGN KEY ([familyId]) REFERENCES [plt].[Family] ([id]),
    CONSTRAINT [FK_Family_Genus_Genus] FOREIGN KEY ([genusId]) REFERENCES [plt].[Genus] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Family_Genus_ID]
    ON [plt].[Family_Genus]([familyId] ASC, [genusId] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Family_Genus_genusId]
    ON [plt].[Family_Genus]([genusId] ASC);
