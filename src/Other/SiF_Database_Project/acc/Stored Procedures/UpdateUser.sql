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

--CREATE PROCEDURE [acc].[UpdateUser]
--(
--    @BaseId                          NVARCHAR(50),
--    @DefaultAuthenticationProviderId INT,
--    @FacebookUserInfoFederatedId     NVARCHAR(50),
--    @GoogleUserInfoFederatedId       NVARCHAR(50),
--    @MicrosoftUserInfoFederatedId    NVARCHAR(50),
--    @Bio                             NVARCHAR(250),
--    @TrustworthyRating               INT,
--    --@PaidAccount                     BIT,
--    @DateModified                    DATETIME
--)
--AS
--/*
--    Update User

--    Revision History

--    2020/02/20-WPM-00000-Create
--*/
--BEGIN
--    SET NOCOUNT ON

--    BEGIN TRANSACTION [Tran_UpdateUser]

--    BEGIN TRY
--        IF EXISTS (SELECT 1 FROM [acc].[User] [use] WHERE [use].[facebookUserInfoFederatedId] = @FacebookUserInfoFederatedId AND [use].[baseId] <> @BaseId)
--        BEGIN
--            RAISERROR ('FacebookUser already Linked.', 16, 2)
--        END
--        ELSE IF EXISTS (SELECT 1 FROM [acc].[User] [use] WHERE [use].[googleUserInfoFederatedId] = @GoogleUserInfoFederatedId AND [use].[baseId] <> @BaseId)
--        BEGIN
--            RAISERROR ('GooglUser already Linked.', 16, 2)
--        END
--        ELSE IF EXISTS (SELECT 1 FROM [acc].[User] [use] WHERE [use].[microsoftUserInfoFederatedId] = @MicrosoftUserInfoFederatedId AND [use].[baseId] <> @BaseId)
--        BEGIN
--            RAISERROR ('MicrosoftUser already Linked.', 16, 2)
--        END
--        ELSE
--        BEGIN
--            UPDATE
--                [use]
--            SET
--                --[use].[baseId]                           = @BaseId,
--                [use].[defaultAuthenticationProviderId] = @DefaultAuthenticationProviderId,
--                [use].[facebookUserInfoFederatedId]     = @FacebookUserInfoFederatedId,
--                [use].[googleUserInfoFederatedId]       = @GoogleUserInfoFederatedId,
--                [use].[microsoftUserInfoFederatedId]    = @MicrosoftUserInfoFederatedId,
--                [use].[bio]                             = @Bio,
--                [use].[trustworthyRating]               = @TrustworthyRating,
--                --[use].[paidAccount]                    = @PaidAccount,
--                [use].[dateModified]                    = @DateModified
--            FROM
--                [acc].[User] [use]
--            WHERE
--                [use].[baseId] = @BaseId

--            IF @@ROWCOUNT = 0
--            BEGIN
--                RAISERROR ('Concurrent update error. Updated aborted.', 16, 2)
--            END
--        END

--        COMMIT TRANSACTION [Tran_UpdateUser]
--    END TRY
--    BEGIN CATCH
--        ROLLBACK TRANSACTION [Tran_UpdateUser]
--        EXEC RethrowError;
--    END CATCH

--    SET NOCOUNT OFF
--END
--GO

--GRANT EXECUTE
--    ON OBJECT::[acc].[UpdateUser]
--    TO [StoredProcedureRole]
--    AS [dbo];
--GO