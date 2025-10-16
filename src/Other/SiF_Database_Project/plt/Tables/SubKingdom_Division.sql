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
CREATE TABLE [plt].[SubKingdom_Division]
(
    [subKingdomId] INT        NOT NULL,
    [divisionId]   INT        NOT NULL,
    [rowVersion]   ROWVERSION NOT NULL,
    CONSTRAINT [PK_SubKingdom_Division] PRIMARY KEY CLUSTERED ([subKingdomId] ASC, [divisionId] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_SubKingdom_Division_Division] FOREIGN KEY ([divisionId]) REFERENCES [plt].[Division] ([id]),
    CONSTRAINT [FK_SubKingdom_Division_SubKingdom] FOREIGN KEY ([subKingdomId]) REFERENCES [plt].[SubKingdom] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_SubKingdom_Division_ID]
    ON [plt].[SubKingdom_Division]([subKingdomId] ASC, [divisionId] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_SubKingdom_Division_divisionId]
    ON [plt].[SubKingdom_Division]([divisionId] ASC);
