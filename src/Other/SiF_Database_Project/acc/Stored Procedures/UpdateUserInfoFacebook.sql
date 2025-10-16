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

--CREATE PROCEDURE [acc].[UpdateUserInfoFacebook]
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
--    Update UserInfo-Facebook

--    Revision History

--    2020/02/20-WPM-00000-Create
--*/
--BEGIN
--    SET NOCOUNT ON

--    BEGIN TRANSACTION [Tran_UpdateUserInfoFacebook]

--    BEGIN TRY
--        IF EXISTS (SELECT 1 FROM [acc].[UserInfoFacebook] [uif] WHERE [uif].[email] = @Email AND [uif].[federatedId] != @FederatedId)
--        BEGIN
--            RAISERROR ('Email already Linked.', 16, 2)
--        END
--        ELSE
--        BEGIN
--            UPDATE
--                [uif]
--            SET
--                --[uif].[baseUserId]      = @BaseUserId,
--                --[uif].[federatedId]     = @FederatedId,
--                [uif].[firstName]       = @FirstName,
--                [uif].[lastName]        = @LastName,
--                [uif].[displayName]     = @DisplayName,
--                [uif].[email]           = @Email,
--                [uif].[isEmailVerified] = @IsEmailVerified,
--                [uif].[profileImageUrl] = @ProfileImageUrl,
--                [uif].[dateModified]    = @DateModified
--            FROM
--                [acc].[UserInfoFacebook] [uif]
--            WHERE
--                [uif].[federatedId]     = @FederatedId

--            IF @@ROWCOUNT = 0
--            BEGIN
--                RAISERROR ('Concurrent update error. Updated aborted.', 16, 2)
--            END
--        END

--        COMMIT TRANSACTION [Tran_UpdateUserInfoFacebook]
--    END TRY
--    BEGIN CATCH
--        ROLLBACK TRANSACTION [Tran_UpdateUserInfoFacebook]
--        EXEC RethrowError;
--    END CATCH

--    SET NOCOUNT OFF
--END
--GO

--GRANT EXECUTE
--    ON OBJECT::[acc].[UpdateUserInfoFacebook]
--    TO [StoredProcedureRole]
--    AS [dbo];
--GO