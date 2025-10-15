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

--CREATE PROCEDURE [dbo].[UpdateUserInfoMicrosoft]
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
--    Update UserInfo-Microsoft

--    Revision History

--    2020/02/20-WPM-00000-Create
--*/
--BEGIN
--    SET NOCOUNT ON

--    BEGIN TRANSACTION [Tran_UpdateUserInfoMicrosoft]

--    BEGIN TRY
--        IF EXISTS (SELECT 1 FROM [acc].[UserInfoMicrosoft] [uim] WHERE [uim].[email] = @Email AND [uim].[federatedId] != @FederatedId)
--        BEGIN
--            RAISERROR ('Email already Linked.', 16, 2)
--        END
--        ELSE
--        BEGIN
--            UPDATE
--                [uim]
--            SET
--                --[uim].[baseUserId]      = @BaseUserId,
--                --[uim].[federatedId]     = @FederatedId,
--                [uim].[firstName]       = @FirstName,
--                [uim].[lastName]        = @LastName,
--                [uim].[displayName]     = @DisplayName,
--                [uim].[email]           = @Email,
--                [uim].[isEmailVerified] = @IsEmailVerified,
--                [uim].[profileImageUrl] = @ProfileImageUrl,
--                [uim].[dateModified]    = @DateModified
--            FROM
--                [acc].[UserInfoMicrosoft] [uim]
--            WHERE
--                [uim].[federatedId]     = @FederatedId

--            IF @@ROWCOUNT = 0
--            BEGIN
--                RAISERROR ('Concurrent update error. Updated aborted.', 16, 2)
--            END
--        END

--        COMMIT TRANSACTION [Tran_UpdateUserInfoMicrosoft]
--    END TRY
--    BEGIN CATCH
--        ROLLBACK TRANSACTION [Tran_UpdateUserInfoMicrosoft]
--        EXEC RethrowError;
--    END CATCH

--    SET NOCOUNT OFF
--END
--GO

--GRANT EXECUTE
--    ON OBJECT::[dbo].[UpdateUserInfoMicrosoft]
--    TO [StoredProcedureRole]
--    AS [dbo];
--GO