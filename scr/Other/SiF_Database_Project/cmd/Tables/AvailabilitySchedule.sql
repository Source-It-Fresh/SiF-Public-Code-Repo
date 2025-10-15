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
CREATE TABLE [cmd].[AvailabilitySchedule]
(
    [id]               UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [commodityId]      UNIQUEIDENTIFIER NOT NULL,
    [deliveryConfigId] UNIQUEIDENTIFIER NOT NULL,
    [name]             NVARCHAR (50)    NOT NULL,
    [specificDate]     DATETIME         NULL, -- CONSTRAINT [DF_AvailabilitySchedule_specificDate] DEFAULT ('1900-01-01 00:00:00.000'),
    [recurring]        BIT              NULL,
    [dayOfTheWeek]     NVARCHAR (250)   NULL,
    [dayOfTheMonth]    NVARCHAR (250)   NULL,
    [dayOfTheYear]     NVARCHAR (250)   NULL,
    [driverUserId]     NVARCHAR (450)   NULL, -- Link to TE_Employee Id
    [dateCreated]      DATETIME         NOT NULL,
    [userCreated]      NVARCHAR (450)   NOT NULL,
    [dateModified]     DATETIME         NOT NULL,
    [userModified]     NVARCHAR (450)   NOT NULL,
    [rowVersion]       ROWVERSION       NOT NULL,
    CONSTRAINT [PK_AvailabilitySchedule] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_AvailabilitySchedule_Commodity] FOREIGN KEY ([commodityId]) REFERENCES [cmd].[Commodity] ([id]),
    --CONSTRAINT [FK_AvailabilitySchedule_DeliveryConfig] FOREIGN KEY ([driverUserId]) REFERENCES [acc].[SiF_Users] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_AvailabilitySchedule_id]
    ON [cmd].[AvailabilitySchedule]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_AvailabilitySchedule_driverUserId]
    ON [cmd].[AvailabilitySchedule]([driverUserId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_AvailabilitySchedule_commodityId]
    ON [cmd].[AvailabilitySchedule]([commodityId] ASC);
