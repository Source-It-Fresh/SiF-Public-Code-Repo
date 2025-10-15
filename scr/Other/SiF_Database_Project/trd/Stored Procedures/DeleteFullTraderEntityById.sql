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
CREATE PROCEDURE [trd].[DeleteFullTraderEntityById]
(
    @TraderEntityId UNIQUEIDENTIFIER
)
AS
/*
    Delete Full TraderEntity By Id

    Revision History

    2020/02/20-WPM-00000-Create
*/
BEGIN
    SET NOCOUNT ON

    BEGIN TRANSACTION [Tran_DeleteFullTraderEntityById]

    BEGIN TRY
        DELETE
            [trl]
        FROM
            [trd].[TraderLocation] [trl]
        WHERE
            [trl].[id] = (SELECT [tre].[locationId] FROM [trd].[TraderEntity] [tre] WHERE [tre].[id] = @TraderEntityId)

        DELETE
            [tcd]
        FROM
            [trd].[TraderContactDetail] [tcd]
        WHERE
            [tcd].[id] = (SELECT [tre].[contactDetailId] FROM [trd].[TraderEntity] [tre] WHERE [tre].[id] = @TraderEntityId)

        DELETE
            [tre]
        FROM
            [trd].[TraderEntity] [tre]
        WHERE
            [tre].[id] = @TraderEntityId

        DELETE
            [ute]
        FROM
            [acc].[User_TraderEntity] [ute]
        WHERE
            [ute].[traderEntityId] = @TraderEntityId

        DELETE
            [seg]
        FROM
            [sec].[SecurityGroup] [seg]
        WHERE
            [seg].[traderEntityOwnerId] = @TraderEntityId --Add cascading delete and call delete SP instead of custom delete (update all delete procs's)

            COMMIT TRANSACTION [Tran_DeleteFullTraderEntityById]
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION [Tran_DeleteFullTraderEntityById]
        EXEC RethrowError;
    END CATCH

    SET NOCOUNT OFF
END
GO

GRANT EXECUTE
    ON OBJECT::[trd].[DeleteFullTraderEntityById]
    TO [StoredProcedureRole]
    AS [dbo];
GO