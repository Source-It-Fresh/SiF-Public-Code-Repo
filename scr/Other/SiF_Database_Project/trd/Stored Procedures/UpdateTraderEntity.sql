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
CREATE PROCEDURE [trd].[UpdateTraderEntity]
(
    @TraderEntityId   UNIQUEIDENTIFIER,
    @Name             NVARCHAR(50),
    @TraderTypeId     INT = 0,
    @ContactDetailId  UNIQUEIDENTIFIER,
    @LocationId       UNIQUEIDENTIFIER,
    @VatNumber        NVARCHAR(100),
    --@DateCreated      DATETIME,
    --@UserCreated      NVARCHAR(50)
    @DateModified     DATETIME,
    @UserModified     NVARCHAR(50)
)
AS
/*
    Update TraderEntity

    Revision History

    2020/02/20-WPM-00000-Create
*/
BEGIN
    SET NOCOUNT ON

    BEGIN TRANSACTION [Tran_UpdateTraderEntity]

    BEGIN TRY
        BEGIN
            UPDATE
                [tre]
            SET
                [tre].[name]             = @Name,
                [tre].[traderTypeId]     = @TraderTypeId,
                [tre].[contactDetailId] = @ContactDetailId,
                [tre].[locationId]       = @LocationId,
                [tre].[vatNumber]        = @VatNumber,
                --[tre].[dateCreated]      = @DateCreated,
                --[tre].[userCreated]      = @UserCreated,
                [tre].[dateModified]     = @DateModified,
                [tre].[userModified]     = @UserModified
            FROM
                [trd].[TraderEntity] [tre]
            WHERE
                [tre].[id] = @TraderEntityId

            IF @@ROWCOUNT = 0
            BEGIN
                RAISERROR ('Concurrent update error. Updated aborted.', 16, 2)
            END
        END

        COMMIT TRANSACTION [Tran_UpdateTraderEntity]
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION [Tran_UpdateTraderEntity]
        EXEC RethrowError;
    END CATCH

    SET NOCOUNT OFF
END
GO

GRANT EXECUTE
    ON OBJECT::[trd].[UpdateTraderEntity]
    TO [StoredProcedureRole]
    AS [dbo];
GO