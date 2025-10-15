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
CREATE TABLE [dbo].[GrowMediumDetail]
(
    [id]               INT              NOT NULL IDENTITY (1, 1),
    [growMediumTypeId] INT              NOT NULL,
    [texture]          NVARCHAR (250)   NOT NULL,
    [structure]        NVARCHAR (250)   NOT NULL,
    [density]          NVARCHAR (250)   NOT NULL,
    [porosity]         NVARCHAR (250)   NOT NULL,
    [consistency]      NVARCHAR (250)   NOT NULL,
    [temperature]      NVARCHAR (250)   NOT NULL,
    [colour]           NVARCHAR (250)   NOT NULL,
    [resistivity]      NVARCHAR (250)   NOT NULL,
    [waterRetention]   NVARCHAR (250)   NOT NULL,
    [waterFlow]        NVARCHAR (250)   NOT NULL,
    [rowVersion]       ROWVERSION       NOT NULL,
    CONSTRAINT [PK_GrowMediumDetail] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_GrowMediumDetail_growMediumTypeId] FOREIGN KEY ([growMediumTypeId]) REFERENCES [dbo].[GrowMediumType] ([id]) ON DELETE CASCADE
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_GrowMediumDetail_id]
    ON [dbo].[GrowMediumDetail]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_GrowMediumDetail_growMediumTypeId]
    ON [dbo].[GrowMediumDetail]([growMediumTypeId] ASC);

--GO
--GRANT SELECT
--    ON OBJECT::[dbo].[GrowMediumDetail]
--    TO [StoredProcedureRole]
--    AS [dbo];
