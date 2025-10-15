CREATE TABLE [dbo].[ZoneSetupType] (
    [id]         SMALLINT       IDENTITY (1, 1) NOT NULL,
    [name]       NVARCHAR (50)  NOT NULL,
    [details]    NVARCHAR (150) NULL,
    [rowVersion] ROWVERSION     NOT NULL,
    CONSTRAINT [PK_ZoneSetupType] PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_ZoneSetupType_id]
    ON [dbo].[ZoneSetupType]([id] ASC);

