CREATE TABLE [dbo].[Todoes] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [CreatedDate] DATETIME       NOT NULL,
    [Done]        BIT            DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_dbo.Todoes] PRIMARY KEY CLUSTERED ([ID] ASC)
);

