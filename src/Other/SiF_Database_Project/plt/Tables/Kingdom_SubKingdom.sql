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
CREATE TABLE [plt].[Kingdom_SubKingdom]
(
    [kingdomId]    INT        NOT NULL,
    [subKingdomId] INT        NOT NULL,
    [rowVersion]   ROWVERSION NOT NULL,
    CONSTRAINT [PK_Kingdom_SubKingdom] PRIMARY KEY CLUSTERED ([kingdomId] ASC, [subKingdomId] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Kingdom_SubKingdom_Kingdom] FOREIGN KEY ([kingdomId]) REFERENCES [plt].[Kingdom] ([id]),
    CONSTRAINT [FK_Kingdom_SubKingdom_SubKingdom] FOREIGN KEY ([subKingdomId]) REFERENCES [plt].[SubKingdom] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Kingdom_SubKingdom_ID]
    ON [plt].[Kingdom_SubKingdom]([kingdomId] ASC, [subKingdomId] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Kingdom_SubKingdom_subKingdomId]
    ON [plt].[Kingdom_SubKingdom]([subKingdomId] ASC);
