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
CREATE TABLE [log].[Feedback]
(
    [id]                 UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [baseUserId]         NVARCHAR (50)    NULL,
    [feedbackTypeId]     INT              NOT NULL CONSTRAINT [DF_Feedback_feedbackTypeId] DEFAULT (0),
    [feedbackCategoryId] INT              NOT NULL CONSTRAINT [DF_Feedback_feedbackCategoryId] DEFAULT (0),
    [applicationVersion] NVARCHAR (50)    NOT NULL,
    [identityName]       NVARCHAR (50)    NOT NULL,
    [email]              NVARCHAR (200)   NOT NULL,
    [details]            NVARCHAR (MAX)   NOT NULL,
    [feedbackMetadataId] UNIQUEIDENTIFIER NOT NULL,
    --[respondedToo]       BIT              NOT NULL CONSTRAINT [DF_Feedback_respondedToo] DEFAULT (0),
    [dateCreated]        DATETIME         NOT NULL,
    [rowVersion]         ROWVERSION       NOT NULL,
    CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90),
    CONSTRAINT [FK_Feedback_FeedbackCategory] FOREIGN KEY ([feedbackCategoryId]) REFERENCES [dbo].[FeedbackCategory] ([id]),
    CONSTRAINT [FK_Feedback_FeedbackMetadata] FOREIGN KEY ([feedbackMetadataId]) REFERENCES [log].[FeedbackMetadata] ([id]),
    CONSTRAINT [FK_Feedback_FeedbackType] FOREIGN KEY ([feedbackTypeId]) REFERENCES [dbo].[FeedbackType] ([id])
);

GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_Feedback_id]
    ON [log].[Feedback]([id] ASC) WITH (FILLFACTOR = 90);

GO
CREATE NONCLUSTERED INDEX [IX_Feedback_feedbackTypeId]
    ON [log].[Feedback]([feedbackTypeId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Feedback_feedbackMetadataId]
    ON [log].[Feedback]([feedbackMetadataId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_Feedback_feedbackCategoryId]
    ON [log].[Feedback]([feedbackCategoryId] ASC);
