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
CREATE TABLE [cmd].[Packaging]
(
    [id]                UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [commodityId]       UNIQUEIDENTIFIER NOT NULL,
    [name]              NVARCHAR (50)    NOT NULL,
    [designImage]       VARBINARY (MAX)  NULL,
    --- ComponentSpecification(s): (multiSelector)
    [notSpecified]      BIT              NOT NULL, -- >solo selection<
    [none]              BIT              NOT NULL, -- (Delivered via crates) >solo selection<
    [biodegradable]     BIT              NOT NULL,
    [cardboard]         BIT              NOT NULL,
    [recyclablePlastic] BIT              NOT NULL,
    [toxicPlastic]      BIT              NOT NULL,
    --ToDo: DB~Also list bleatches chemicals or other sub components
    --- SharedStatus[private - for my use only/publicly shared]list
--Dimensions:
    [length]            DECIMAL (10, 2)  NULL,
    [width]             DECIMAL (10, 2)  NULL,
    [height]            DECIMAL (10, 2)  NULL,
    [weight]            DECIMAL (10, 2)  NULL,
    [volume]            DECIMAL (10, 2)  NULL,

    [dateCreated]       DATETIME         NOT NULL,
    [userCreated]       NVARCHAR (450)   NOT NULL,
    [dateModified]      DATETIME         NOT NULL,
    [userModified]      NVARCHAR (450)   NOT NULL,
    [rowVersion]        ROWVERSION       NOT NULL,
    CONSTRAINT [PK_Packaging] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Packaging_Commodity] FOREIGN KEY ([commodityId]) REFERENCES [cmd].[Commodity] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Packaging_id]
    ON [cmd].[Packaging]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Packaging_commodityId]
    ON [cmd].[Packaging]([commodityId] ASC);
