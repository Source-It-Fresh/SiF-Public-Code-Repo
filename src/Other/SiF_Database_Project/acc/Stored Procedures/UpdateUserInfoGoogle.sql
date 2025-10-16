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

--CREATE PROCEDURE [acc].[UpdateUserInfoGoogle]
--(
--    @FederatedId     NVARCHAR(50),
--    @FirstName       NVARCHAR(100),
--    @LastName        NVARCHAR(100),
--    @DisplayName     NVARCHAR(200),
--    @Email           NVARCHAR(200),
--    @IsEmailVerified BIT,
--    @ProfileImageUrl NVARCHAR(300),
--    @DateModified    DATETIME
--)
--AS
--/*
--    Update UserInfo-Google

--    Revision History

--    2020/02/20-WPM-00000-Create
--*/
--BEGIN
--    SET NOCOUNT ON

--    BEGIN TRANSACTION [Tran_UpdateUserInfoGoogle]

--    BEGIN TRY
--        IF EXISTS (SELECT 1 FROM [acc].[UserInfoGoogle] [uig] WHERE [uig].[email] = @Email AND [uig].[federatedId] != @FederatedId)
--        BEGIN
--            RAISERROR ('Email already Linked.', 16, 2)
--        END
--        ELSE
--        BEGIN
--            UPDATE
--                [uig]
--            SET
--                --[uig].[baseUserId]      = @BaseUserId,
--                --[uig].[federatedId]     = @FederatedId,
--                [uig].[firstName]       = @FirstName,
--                [uig].[lastName]        = @LastName,
--                [uig].[displayName]     = @DisplayName,
--                [uig].[email]           = @Email,
--                [uig].[isEmailVerified] = @IsEmailVerified,
--                [uig].[profileImageUrl] = @ProfileImageUrl,
--                [uig].[dateModified]    = @DateModified
--            FROM
--                [acc].[UserInfoGoogle] [uig]
--            WHERE
--                [uig].[federatedId]     = @FederatedId

--            IF @@ROWCOUNT = 0
--            BEGIN
--                RAISERROR ('Concurrent update error. Updated aborted.', 16, 2)
--            END
--        END

--        COMMIT TRANSACTION [Tran_UpdateUserInfoGoogle]
--    END TRY
--    BEGIN CATCH
--        ROLLBACK TRANSACTION [Tran_UpdateUserInfoGoogle]
--        EXEC RethrowError;
--    END CATCH

--    SET NOCOUNT OFF
--END
--GO

--GRANT EXECUTE
--    ON OBJECT::[acc].[UpdateUserInfoGoogle]
--    TO [StoredProcedureRole]
--    AS [dbo];
--GO