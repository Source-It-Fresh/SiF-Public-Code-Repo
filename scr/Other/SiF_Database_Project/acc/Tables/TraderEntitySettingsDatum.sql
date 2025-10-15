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
CREATE TABLE [acc].[TraderEntitySettingsDatum]
(
    [id]                             UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [name]                           NVARCHAR (50)    NOT NULL,
    [traderEntity_PrimaryHexColor]   NVARCHAR (7)     NULL,
    [traderEntity_SecondaryHexColor] NVARCHAR (7)     NULL,
    [layoutType_Simple]              BIT              NOT NULL,
    [theme_Name]                     NVARCHAR (50)    NULL,
    [display_Titles]                 BIT              NOT NULL,
    [display_InputControlLabels]     BIT              NOT NULL,
    [display_DynamicNav]             BIT              NOT NULL,
    [infoBar_Show]                   BIT              NOT NULL,
    [infoBar_ServerTime]             BIT              NOT NULL,
    [infoBar_LocalTime]              BIT              NOT NULL,
    [infoBar_Alerts]                 BIT              NOT NULL,
    [infoBar_Weather]                BIT              NOT NULL,
    [titleBar_Show]                  BIT              NOT NULL,
    [titleBar_Heading]               BIT              NOT NULL,
    [titleBar_TopNavSubMenus]        BIT              NOT NULL,
    [dateCreated]                    DATETIME         NOT NULL,
    [userCreated]                    NVARCHAR (450)   NOT NULL,
    [dateModified]                   DATETIME         NOT NULL,
    [userModified]                   NVARCHAR (450)   NOT NULL,
    [rowVersion]                     ROWVERSION       NOT NULL,
    CONSTRAINT [PK_TraderEntitySettingsDatum] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90)
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_TraderEntitySettingsDatum_id]
    ON [acc].[TraderEntitySettingsDatum]([id] ASC) WITH (FILLFACTOR = 90);
