CREATE TABLE [dbo].[Book] (
    [BookId]            INT            IDENTITY (1, 1) NOT NULL,
    [BookTitle]         NVARCHAR (MAX) NOT NULL,
    [BookPublishedDate] DATE           NOT NULL,
    PRIMARY KEY CLUSTERED ([BookId] ASC)
);

CREATE TABLE [dbo].[Image] (
    [ImageId]   INT           IDENTITY (1, 1) NOT NULL,
    [ImagePath] NVARCHAR (50) NOT NULL,
    [BookId]    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ImageId] ASC),
    CONSTRAINT [FK_Image_Book] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Book] ([BookId])
);

