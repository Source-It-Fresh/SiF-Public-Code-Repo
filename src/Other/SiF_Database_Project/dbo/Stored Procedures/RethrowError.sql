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
CREATE PROCEDURE [dbo].[RethrowError]
AS
/*
    Rethrow Error

    Revision History

    2020/02/20-WPM-00000-Create
*/
BEGIN
    SET NOCOUNT ON

    /* Return if there is no error information to retrieve. */
    IF ERROR_NUMBER() IS NULL
        RETURN;

    DECLARE
        @ErrorMessage   NVARCHAR(4000),
        @ErrorNumber    INT,
        @ErrorSeverity  INT,
        @ErrorState     INT,
        @ErrorLine      INT,
        @ErrorProcedure NVARCHAR(200);

    /* Assign variables to error-handling functions that capture information for RAISERROR. */
    SELECT
        @ErrorNumber =    ERROR_NUMBER(),
        @ErrorSeverity =  ERROR_SEVERITY(),
        @ErrorState =     ERROR_STATE(),
        @ErrorLine =      ERROR_LINE(),
        @ErrorProcedure = ISNULL(ERROR_PROCEDURE(), '-');

    /* Building the message string that will contain original error information. */
    SELECT
        @ErrorMessage = N'Error %d, Level %d, State %d, Procedure %s, Line %d, Message: ' + ERROR_MESSAGE();

    /* Raise an error: msg_str parameter of RAISERROR will contain the original error information. */
    RAISERROR
    (
        @ErrorMessage, @ErrorSeverity, 1,
        @ErrorNumber,     /* parameter: original error number. */
        @ErrorSeverity,   /* parameter: original error severity. */
        @ErrorState,      /* parameter: original error state. */
        @ErrorProcedure,  /* parameter: original error procedure name. */
        @ErrorLine        /* parameter: original error line number. */
    );

    SET NOCOUNT OFF
END
GO

GRANT EXECUTE
    ON OBJECT::[dbo].[RethrowError]
    TO [StoredProcedureRole]
    AS [dbo];
GO