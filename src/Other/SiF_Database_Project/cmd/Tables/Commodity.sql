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
CREATE TABLE [cmd].[Commodity] --ToDo: DB~Link From Location / Name From TE
(
--ToDo: DB~ Add defaults to all Commodity/Harvest tbls as <tbl_name> + <rowID>
    [id]             UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [traderEntityId] UNIQUEIDENTIFIER NOT NULL,
    [name]           NVARCHAR (50)    NOT NULL, -- For _moneyUnits, Default based on location
    [currencyId]     INT              NOT NULL,
    --StorrageSpaceVolumes

    --Link to TE (name, location, etc.)
    --Combine/group crops produced as products (the layer between farm and shop)
    --Backorders (to be fulfilled)
    --Freshly Harvested (totals)
    --Packages (stock count per type)
    --Profit estimation (per x?)
    --discount recommendations on soon to expire items
    --Total stock
    --Other insights
    --Delivery escalation alerts and order logistics dashboard

    [dateCreated]    DATETIME         NOT NULL,
    [userCreated]    NVARCHAR (450)   NOT NULL,
    [dateModified]   DATETIME         NOT NULL,
    [userModified]   NVARCHAR (450)   NOT NULL,
    [rowVersion]     ROWVERSION       NOT NULL,
    CONSTRAINT [PK_Commodity] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Commodity_traderEntityId] FOREIGN KEY ([traderEntityId]) REFERENCES [trd].[TraderEntity] ([id])
    --CONSTRAINT [FK_Commodity_cultureId] FOREIGN KEY ([cultureId]) REFERENCES [dbo].[FarmCulture] ([id]),
    --CONSTRAINT [FK_Commodity_agricultureApproachId] FOREIGN KEY ([agricultureApproachId]) REFERENCES [dbo].[FarmAgriculture] ([id]),

    --CONSTRAINT [FK_Commodity_zoneIdArray] FOREIGN KEY ([zoneIdArray]) REFERENCES [frm].[Zone] ([id]) ON DELETE CASCADE
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Commodity_id]
    ON [cmd].[Commodity]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Commodity_traderEntityId]
    ON [cmd].[Commodity]([traderEntityId] ASC);
