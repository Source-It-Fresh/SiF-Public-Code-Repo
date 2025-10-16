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
CREATE TABLE [log].[ActionHistory]
(
    [id]             UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [baseUserId]     NVARCHAR (450)   NOT NULL,
    [traderEntityId] UNIQUEIDENTIFIER NOT NULL,
    [actionType]     NVARCHAR (30)    NOT NULL,
    [area]           NVARCHAR (MAX)   NOT NULL,
    [rowId]          UNIQUEIDENTIFIER NOT NULL,
    [details]        NVARCHAR (MAX)   NOT NULL,
    [dateCreated]    DATETIME         NOT NULL,
    [rowVersion]     ROWVERSION       NOT NULL,
    CONSTRAINT [PK_ActionHistory] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_ActionHistory_TraderEntity] FOREIGN KEY ([traderEntityId]) REFERENCES [trd].[TraderEntity] ([id])
    --CONSTRAINT [FK_ActionHistory_User] FOREIGN KEY ([baseUserId]) REFERENCES [acc].[SiF_Users] ([Id]),
    --CONSTRAINT [FK_ActionHistory_ApplicationSection] FOREIGN KEY ([areaId]) REFERENCES [sec].[ApplicationSection] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_ActionHistory_id]
    ON [log].[ActionHistory]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_ActionHistory_traderEntityId]
    ON [log].[ActionHistory]([traderEntityId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_ActionHistory_baseUserId]
    ON [log].[ActionHistory]([baseUserId] ASC);

GO

--ToDo: DB~CREATE TRIGGER [trd].[tblName_Trigger]
--    ON [trd].[tblName]
--    AFTER
--        INSERT, UPDATE, DELETE
--AS
--/*
--    Trigger for tblName

--    Revision History

--    2020/02/20-WPM-00000-Create
--*/
--BEGIN
--    DECLARE
--        @DateModified   DATETIME,
--        @UserModifiedId NVARCHAR(50)

--        SET @DateModified = GETDATE()
--        SELECT @UserModifiedId = [userModified] FROM INSERTED
--        --SET @UserModifiedId =  [acc].[GetUserBaseId](@UserModifiedId)

--        IF (EXISTS(SELECT * FROM INSERTED))
--            BEGIN -- INSERT / UPDATE
--                UPDATE
--                    [trd].[tblName]
--                SET
--                    [dateModified] = @DateModified,
--                    [userModified] = @UserModified
--                FROM
--                    INSERTED
--                WHERE
--                    INSERTED.[id] = [tblName].[id]
--            END

--        IF (EXISTS(SELECT * FROM INSERTED)) AND (NOT EXISTS(SELECT * FROM DELETED))
--            BEGIN -- INSERTED
--                INSERT
--                    [log].[ActionHistory]
--                SELECT
--                    NEWID(),                   --[id]
--                    ISNULL(@UserModifiedId, INSERTED.[userModified]), --[baseUserId]
--                    INSERTED.[traderEntityId], --[traderEntityId]
--                    'UPDATED',                 --[actionType]
--                    INSERTED.[areaId],         --[areaId]
--                    INSERTED.[id],             --[rowId]
--                    INSERTED.[details],        --[details]
--                    ISNULL(@DateModified, DELETED.[dateModified]) --[dateCreated]
--                FROM
--                    INSERTED
--            END
--        ELSE IF (EXISTS(SELECT * FROM INSERTED)) AND (EXISTS(SELECT * FROM DELETED))
--            BEGIN -- UPDATED
--                INSERT
--                    [log].[ActionHistory]
--                SELECT
--                    NEWID(),                   --[id]
--                    ISNULL(@UserModifiedId, INSERTED.[userModified]), --[baseUserId]
--                    INSERTED.[traderEntityId], --[traderEntityId]
--                    'UPDATED',                 --[actionType]
--                    INSERTED.[areaId],         --[areaId]
--                    INSERTED.[id],             --[rowId]
--                    INSERTED.[details],        --[details]
--                    ISNULL(@DateModified, DELETED.[dateModified]) --[dateCreated]
--                FROM
--                    INSERTED
--            END
--        ELSE IF (NOT EXISTS(SELECT * FROM INSERTED)) AND (EXISTS(SELECT * FROM DELETED))
--            BEGIN -- DELETED
--                INSERT
--                    [log].[ActionHistory]
--                SELECT
--                    NEWID(),                  --[id]
--                    ISNULL(@UserModifiedId, DELETED.[userModified]), --[baseUserId]
--                    DELETED.[traderEntityId], --[traderEntityId]
--                    'DELETED',                --[actionType]
--                    DELETED.[areaId],         --[areaId]
--                    DELETED.[id],             --[rowId]
--                    DELETED.[details],        --[details]
--                    ISNULL(@DateModified, DELETED.[dateModified]) --[dateCreated]
--                FROM
--                    DELETED
--            END
--END
--GO
