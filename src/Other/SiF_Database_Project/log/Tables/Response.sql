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
CREATE TABLE [log].[Response]
(
    [id]              UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [feedbackId]      UNIQUEIDENTIFIER NOT NULL,
    [responderUserId] UNIQUEIDENTIFIER NOT NULL,
    [responseText]    NVARCHAR (MAX)   NOT NULL,
    [dateCreated]     DATETIME         NOT NULL,
    [rowVersion]      ROWVERSION       NOT NULL,
    CONSTRAINT [PK_Response] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Response_Feedback] FOREIGN KEY ([feedbackId]) REFERENCES [log].[Feedback] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Response_id]
    ON [log].[Response]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Response_feedbackId]
    ON [log].[Response]([feedbackId] ASC);
