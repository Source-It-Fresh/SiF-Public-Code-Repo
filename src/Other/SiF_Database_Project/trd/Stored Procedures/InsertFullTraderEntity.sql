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
CREATE PROCEDURE [trd].[InsertFullTraderEntity]
(
    @UserBaseId            NVARCHAR(50),
    @TraderEntityId        UNIQUEIDENTIFIER,

    @TE_Name               NVARCHAR(50),
    @TE_TraderTypeId       INT = 0,
    @TE_ContactDetailId    UNIQUEIDENTIFIER,
    @TE_LocationId         UNIQUEIDENTIFIER,
    @TE_VatNumber          NVARCHAR(100) = 'Not Supplied',
    @TE_DateCreated        DATETIME,
    @TE_UserCreated        NVARCHAR(50),
    @TE_DateModified       DATETIME = '1900-01-01 00:00:00.000',
    @TE_UserModified       NVARCHAR(50),

    --@TraderContactDetailId UNIQUEIDENTIFIER,
    @TCD_WebsiteUrl        NVARCHAR(100),
    @TCD_CustomerCareEmail NVARCHAR(200),
    @TCD_PhoneNumber       NVARCHAR(50),
    @TCD_OtherDetails      NVARCHAR(MAX),
    --@TCD_DateModified      DATETIME = '1900-01-01 00:00:00.000',
    --@TCD_UserModified      NVARCHAR(50),

    --@TraderLocationId    UNIQUEIDENTIFIER,
    @TRL_GpsCoordinates  NVARCHAR(100),
    @TRL_MapImage        VARBINARY(MAX),
    @TRL_CountryRegion   NVARCHAR(100),
    @TRL_StateProvince   NVARCHAR(100),
    @TRL_City            NVARCHAR(100),
    @TRL_PostalCode      NVARCHAR(100),
    @TRL_AddressLine1    NVARCHAR(100),
    @TRL_AddressLine2    NVARCHAR(100),
    @TRL_Building        NVARCHAR(100),
    @TRL_FloorLevel      NVARCHAR(100),
    @TRL_CustomDetails   NVARCHAR(MAX),
    @TRL_MunicipalityId  BIGINT = '-999' /*N/A*/
    --@TRL_DateModified    DATETIME = '1900-01-01 00:00:00.000',
    --@TRL_UserModified    NVARCHAR(50)
)
AS
/*
    Insert Full TraderEntity

    Revision History

    2020/02/20-WPM-00000-Create
*/
BEGIN
    SET NOCOUNT ON

    BEGIN TRANSACTION [Tran_InsertFullTraderEntity]

    BEGIN TRY
        BEGIN
            INSERT INTO [trd].[TraderLocation]
            (
                [id],
                [gpsCoordinates],
                [countryRegion],
                [stateProvince],
                [city],
                [postalCode],
                [addressLine1],
                [addressLine2],
                [building],
                [floorLevel],
                [customDetails],
                [municipalityId],
                [dateModified],
                [userModified]
            )
            VALUES
            (
                --@TraderLocationId,
                @TE_LocationId,
                @TRL_GpsCoordinates,
                @TRL_CountryRegion,
                @TRL_StateProvince,
                @TRL_City,
                @TRL_PostalCode,
                @TRL_AddressLine1,
                @TRL_AddressLine2,
                @TRL_Building,
                @TRL_FloorLevel,
                @TRL_CustomDetails,
                @TRL_MunicipalityId,
                @TE_DateModified,
                @TE_UserModified
            )

            INSERT INTO [trd].[TraderContactDetail]
            (
                [id],
                [websiteUrl],
                [customerCareEmail],
                [phoneNumber],
                [otherDetails],
                [dateModified],
                [userModified]
            )
            VALUES
            (
                --@TraderContactDetailId
                @TE_ContactDetailId,
                @TCD_WebsiteUrl,
                @TCD_CustomerCareEmail,
                @TCD_PhoneNumber,
                @TCD_OtherDetails,
                @TE_DateModified,
                @TE_UserModified
            )

            INSERT INTO [trd].[TraderEntity]
            (
                [id],
                [name],
                [traderTypeId],
                [contactDetailId],
                [locationId],
                [vatNumber],
                [dateCreated],
                [userCreated],
                [dateModified],
                [userModified] 
            )
            VALUES
            (
                @TraderEntityId,
                @TE_Name,
                @TE_TraderTypeId,
                @TE_ContactDetailId,
                @TE_LocationId,
                @TE_VatNumber,
                @TE_DateCreated,
                @TE_UserCreated,
                @TE_DateModified,
                @TE_UserModified
            )

            INSERT INTO [acc].[User_TraderEntity]
            (
                [userBaseId],
                [traderEntityId]
            )
            VALUES
            (
                @UserBaseId,
                @TraderEntityId
            )
        END

        COMMIT TRANSACTION [Tran_InsertFullTraderEntity]
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION [Tran_InsertFullTraderEntity]
        EXEC RethrowError;
    END CATCH

    SET NOCOUNT OFF
END
GO

GRANT EXECUTE
    ON OBJECT::[trd].[InsertFullTraderEntity]
    TO [StoredProcedureRole]
    AS [dbo];
GO