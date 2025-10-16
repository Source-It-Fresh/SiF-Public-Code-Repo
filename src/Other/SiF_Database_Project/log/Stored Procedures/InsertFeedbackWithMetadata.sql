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
CREATE PROCEDURE [log].[InsertFeedbackWithMetadata]
(
    @FeedbackId            UNIQUEIDENTIFIER,
    @BaseUserId            NVARCHAR(50),
    @FE_FeedbackTypeId     INT = 0,
    @FE_FeedbackCategoryId INT = 0,
    @FE_ApplicationVersion NVARCHAR(10),
    @FE_IdentityName       NVARCHAR(50),
    @FE_Email              NVARCHAR(200),
    @FE_Details            NVARCHAR(MAX),
    @FE_FeedbackMetadataId UNIQUEIDENTIFIER,
    --@FE_RespondedToo       BIT = 0,
    @FE_DateCreated        DATETIME = '1900-01-01 00:00:00.000',

    --@MetaDataId            UNIQUEIDENTIFIER,
    @MD_Location           NVARCHAR(100),
    @MD_OperatingSystem    NVARCHAR(100),
    @MD_Browser            NVARCHAR(100),
    @MD_BrowserPlugins     NVARCHAR(100),
    @MD_Cpu                NVARCHAR(100),
    @MD_PublicIP           NVARCHAR(100),
    @MD_ConnectionSpeed    NVARCHAR(100),
    @MD_ConnectedSocialMediaAcounts NVARCHAR(250)
    --@MD_DateCreated        DATETIME = '1900-01-01 00:00:00.000'
)
AS
/*
    Insert FeedbackWithMetadata

    Revision History

    2020/02/20-WPM-00000-Create
*/
BEGIN
    SET NOCOUNT ON

    BEGIN TRANSACTION [Tran_InsertFeedbackWithMetadata]

    BEGIN TRY
        BEGIN
            INSERT INTO [log].[FeedbackMetadata]
            (
                [id],
                [location],
                [operatingSystem],
                [browser],
                [browserPlugins],
                [cpu],
                [publicIP],
                [connectionSpeed],
                [connectedSocialMediaAcounts],
                [dateCreated]
            )
            VALUES
            (
                --@MD_id,
                @FE_FeedbackMetadataId,
                @MD_Location,
                @MD_OperatingSystem,
                @MD_Browser,
                @MD_BrowserPlugins,
                @MD_Cpu,
                @MD_PublicIP,
                @MD_ConnectionSpeed,
                @MD_ConnectedSocialMediaAcounts,
                @FE_DateCreated
            )

            INSERT INTO [log].[Feedback]
            (
                [id],
                [baseUserId],
                [feedbackTypeId],
                [feedbackCategoryId],
                [applicationVersion],
                [identityName],
                [email],
                [details],
                [feedbackMetadataId],
                --[respondedToo],
                [dateCreated]
            )
            VALUES
            (
                @FeedbackId,
                @BaseUserId,
                @FE_FeedbackTypeId,
                @FE_FeedbackCategoryId,
                @FE_ApplicationVersion,
                @FE_IdentityName,
                @FE_Email,
                @FE_Details,
                @FE_FeedbackMetadataId,
                --0, --@FE_RespondedToo,
                @FE_DateCreated
            )
        END

        COMMIT TRANSACTION [Tran_InsertFeedbackWithMetadata]
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION [Tran_InsertFeedbackWithMetadata]
        EXEC RethrowError;
    END CATCH

    SET NOCOUNT OFF
END
GO

GRANT EXECUTE
    ON OBJECT::[log].[InsertFeedbackWithMetadata]
    TO [StoredProcedureRole]
    AS [dbo];
GO