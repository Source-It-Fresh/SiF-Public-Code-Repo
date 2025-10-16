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
CREATE PROCEDURE [sec].[GetSecurityGroupById]
(
    @SecurityGroupId UNIQUEIDENTIFIER
)
AS
/*
    Get SecurityGroup By Id

    Revision History

    2020/02/20-WPM-00000-Create
*/
BEGIN
    SET NOCOUNT ON

    SELECT
        [seg].[id],
        [seg].[name],
        [seg].[isSystemConfig],
        [seg].[traderEntityOwnerId],
        [seg].[dateCreated],
        [seg].[userCreated],
        [seg].[dateModified],
        [seg].[userModified]
    FROM
        [sec].[SecurityGroup] [seg]
    WHERE
        [seg].[id] = @SecurityGroupId

    SET NOCOUNT OFF
END
GO

GRANT EXECUTE
    ON OBJECT::[sec].[GetSecurityGroupById]
    TO [StoredProcedureRole]
    AS [dbo];
GO