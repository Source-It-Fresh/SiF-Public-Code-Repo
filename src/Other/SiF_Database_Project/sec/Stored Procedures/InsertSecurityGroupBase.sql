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
CREATE PROCEDURE [sec].[InsertSecurityGroupBase]
(
    @UserBaseId          NVARCHAR(50),

    @SecurityGroupId     UNIQUEIDENTIFIER,
    @Name                NVARCHAR(50),
    @IsSystemConfig      BIT,
    @TraderEntityOwnerId UNIQUEIDENTIFIER,
    @DateCreated         DATETIME,
    @UserCreated         NVARCHAR(50),
    @DateModified        DATETIME = '1900-01-01 00:00:00.000',
    @UserModified        NVARCHAR(50)
)
AS
/*
    Insert SecurityGroup Base

    Revision History

    2020/02/20-WPM-00000-Create
*/
BEGIN
    SET NOCOUNT ON

    BEGIN TRANSACTION [Tran_InsertSecurityGroupBase]

    BEGIN TRY
        BEGIN
            DECLARE @tmpId UNIQUEIDENTIFIER

            DECLARE myCursor CURSOR LOCAL FAST_FORWARD FOR
                SELECT [id] FROM [sec].[ApplicationSection]
            OPEN myCursor
            FETCH NEXT FROM myCursor INTO @tmpId
            WHILE @@FETCH_STATUS = 0 BEGIN

                INSERT INTO [sec].[PermissionDetail]
                (
                    [id],
                    [securityGroupId],
                    [applicationSectionId],
                    [allowedView],
                    [allowedAdd],
                    [allowedUpdate],
                    [allowedDelete],
                    [dateModified],
                    [userModified]
                )
                VALUES
                (
                    NEWID(),
                    @SecurityGroupId,
                    @tmpId,
                    0,
                    0,
                    0,
                    0,
                    @DateModified,
                    @UserModified
                )

                FETCH NEXT FROM myCursor INTO @tmpId
            END

            CLOSE myCursor
            DEALLOCATE myCursor

            INSERT INTO [sec].[SecurityGroup]
            (
                [id],
                [name],
                [isSystemConfig],
                [traderEntityOwnerId],
                [dateCreated],
                [userCreated],
                [dateModified],
                [userModified]
            )
            VALUES
            (
                @SecurityGroupId,
                @Name,
                @IsSystemConfig,
                @TraderEntityOwnerId,
                @DateCreated,
                @UserCreated,
                @DateModified,
                @UserModified
            )

            INSERT INTO [acc].[User_SecurityGroup]
            (
                [userBaseId],
                [securityGroupId]
            )
            VALUES
            (
                @UserBaseId,
                @SecurityGroupId
            )
        END

        COMMIT TRANSACTION [Tran_InsertSecurityGroupBase]
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION [Tran_InsertSecurityGroupBase]
        EXEC RethrowError;
    END CATCH

    SET NOCOUNT OFF
END
GO

GRANT EXECUTE
    ON OBJECT::[sec].[InsertSecurityGroupBase]
    TO [StoredProcedureRole]
    AS [dbo];
GO