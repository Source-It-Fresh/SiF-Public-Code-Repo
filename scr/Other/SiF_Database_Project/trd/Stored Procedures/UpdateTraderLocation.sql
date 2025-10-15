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
CREATE PROCEDURE [trd].[UpdateTraderLocation]
(
    @TraderLocationId UNIQUEIDENTIFIER,

    @GpsCoordinates  NVARCHAR(100),
    @MapImage        VARBINARY(MAX),
    @CountryRegion   NVARCHAR(100),
    @StateProvince   NVARCHAR(100),
    @City            NVARCHAR(100),
    @PostalCode      NVARCHAR(100),
    @AddressLine1    NVARCHAR(100),
    @AddressLine2    NVARCHAR(100),
    @Building        NVARCHAR(100),
    @FloorLevel      NVARCHAR(100),
    @CustomDetails   NVARCHAR(MAX),
    @MunicipalityId  BIGINT,
    @DateModified    DATETIME,
    @UserModified    NVARCHAR(50)
)
AS
/*
    Update TraderLocation

    Revision History

    2020/02/20-WPM-00000-Create
*/
BEGIN
    SET NOCOUNT ON

    BEGIN TRANSACTION [Tran_UpdateTraderLocation]

    BEGIN TRY
        BEGIN
            UPDATE
                [trl]
            SET
                [trl].[gpsCoordinates] = @GpsCoordinates,
                [trl].[mapImage]       = @MapImage,
                [trl].[countryRegion]  = @CountryRegion,
                [trl].[stateProvince]  = @StateProvince,
                [trl].[city]           = @City,
                [trl].[postalCode]     = @PostalCode,
                [trl].[addressLine1]   = @AddressLine1,
                [trl].[addressLine2]   = @AddressLine2,
                [trl].[building]       = @Building,
                [trl].[floorLevel]     = @FloorLevel,
                [trl].[customDetails]  = @CustomDetails,
                [trl].[municipalityId] = @MunicipalityId,
                [trl].[dateModified]   = @DateModified,
                [trl].[userModified]   = @UserModified
            FROM
                [trd].[TraderLocation] [trl]
            WHERE
                [trl].[id] = @TraderLocationId

            IF @@ROWCOUNT = 0
            BEGIN
                RAISERROR ('Concurrent update error. Updated aborted.', 16, 2)
            END
        END

        COMMIT TRANSACTION [Tran_UpdateTraderLocation]
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION [Tran_UpdateTraderLocation]
        EXEC RethrowError;
    END CATCH

    SET NOCOUNT OFF
END
GO

GRANT EXECUTE
    ON OBJECT::[trd].[UpdateTraderLocation]
    TO [StoredProcedureRole]
    AS [dbo];
GO