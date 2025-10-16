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

--CREATE PROCEDURE [acc].[InsertUser]
--(
--    @BaseId                          NVARCHAR(50),
--    @DefaultAuthenticationProviderId INT,
--    @FacebookUserInfoFederatedId     NVARCHAR(50),
--    @GoogleUserInfoFederatedId       NVARCHAR(50),
--    @MicrosoftUserInfoFederatedId    NVARCHAR(50),
--    @Bio                             NVARCHAR(250),
--    @TrustworthyRating               INT,
--    --@PaidAccount                     BIT,
--    @DateCreated                     DATETIME,
--    @DateModified                    DATETIME = '1900-01-01 00:00:00.000'
--)
--AS
--/*
--    Insert User

--    Revision History

--    2020/02/20-WPM-00000-Create
--*/
--BEGIN
--    SET NOCOUNT ON

--    BEGIN TRANSACTION [Tran_InsertUser]

--    BEGIN TRY
--        IF EXISTS (SELECT 1 FROM [acc].[User] [use] WHERE [use].[baseId] = @BaseId)
--        BEGIN
--            RAISERROR ('User already exist.', 16, 2)
--        END
--        ELSE IF EXISTS (SELECT 1 FROM [acc].[User] [use] WHERE [use].[facebookUserInfoFederatedId] = @FacebookUserInfoFederatedId)
--        BEGIN
--            RAISERROR ('FacebookUser already Linked.', 16, 2)
--        END
--        ELSE IF EXISTS (SELECT 1 FROM [acc].[User] [use] WHERE [use].[googleUserInfoFederatedId] = @GoogleUserInfoFederatedId)
--        BEGIN
--            RAISERROR ('GooglUser already Linked.', 16, 2)
--        END
--        ELSE IF EXISTS (SELECT 1 FROM [acc].[User] [use] WHERE [use].[microsoftUserInfoFederatedId] = @MicrosoftUserInfoFederatedId)
--        BEGIN
--            RAISERROR ('MicrosoftUser already Linked.', 16, 2)
--        END
--        ELSE
--        BEGIN
--            INSERT INTO [acc].[User]
--            (
--                [baseId],
--                [defaultAuthenticationProviderId],
--                [facebookUserInfoFederatedId],
--                [googleUserInfoFederatedId],
--                [microsoftUserInfoFederatedId],
--                [bio],
--                [trustworthyRating],
--                --[traderType],
--                --[payedAccount],
--                [dateCreated],
--                [dateModified]
--            )
--            VALUES
--            (
--                @BaseId,
--                @DefaultAuthenticationProviderId,
--                @FacebookUserInfoFederatedId,
--                @GoogleUserInfoFederatedId,
--                @MicrosoftUserInfoFederatedId,
--                @Bio,
--                @TrustworthyRating,
--                --@TraderType,
--                --@PaidAccount,
--                @DateCreated,
--                @DateModified
--            )
--        END

--        COMMIT TRANSACTION [Tran_InsertUser]
--    END TRY
--    BEGIN CATCH
--        ROLLBACK TRANSACTION [Tran_InsertUser]
--        EXEC RethrowError;
--    END CATCH

--    SET NOCOUNT OFF
--END
--GO

--GRANT EXECUTE
--    ON OBJECT::[acc].[InsertUser]
--    TO [StoredProcedureRole]
--    AS [dbo];
--GO