CREATE TABLE [dbo].[Users_Authors] (
    [AuthorId] [int] NOT NULL IDENTITY,
    [Bio] [nvarchar](max),
    [Title] [nvarchar](max),
    [User_UserId] [int],
    CONSTRAINT [PK_dbo.Users_Authors] PRIMARY KEY ([AuthorId])
)
CREATE TABLE [dbo].[Users] (
    [UserId] [int] NOT NULL IDENTITY,
    [Email] [nvarchar](max),
    [Login] [nvarchar](max),
    [Password] [nvarchar](max),
    [FirstName] [nvarchar](max),
    [LastName] [nvarchar](max),
    [MiddleName] [nvarchar](max),
    [FullName] [nvarchar](max),
    [DOB] [nvarchar](max),
    [Gender] [bit] NOT NULL,
    [RegisteredDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY ([UserId])
)
CREATE TABLE [dbo].[Videos] (
    [VideoId] [int] NOT NULL IDENTITY,
    [Title] [nvarchar](max),
    [Description] [nvarchar](max),
    [ReleasedDate] [datetime] NOT NULL,
    [UpdatedDate] [datetime] NOT NULL,
    [Duration] [int] NOT NULL,
    [NumberOfviewers] [int] NOT NULL,
    [NumberOfSubscribers] [int] NOT NULL,
    [Size] [int] NOT NULL,
    [Url] [nvarchar](max),
    [ImagePath] [nvarchar](max),
    [Category_CategoryId] [int],
    [Topic_TopicId] [int],
    [AuthorI_AuthorId] [int],
    [Language_LanguageId] [int],
    [Author_AuthorId] [int],
    [Author_AuthorId1] [int],
    CONSTRAINT [PK_dbo.Videos] PRIMARY KEY ([VideoId])
)
CREATE TABLE [dbo].[Categories] (
    [CategoryId] [int] NOT NULL IDENTITY,
    [Title] [nvarchar](max),
    [Description] [nvarchar](max),
    [Topic_TopicId] [int],
    CONSTRAINT [PK_dbo.Categories] PRIMARY KEY ([CategoryId])
)
CREATE TABLE [dbo].[Topics] (
    [TopicId] [int] NOT NULL IDENTITY,
    [Title] [nvarchar](max),
    [Description] [nvarchar](max),
    [Library_LibraryId] [int],
    CONSTRAINT [PK_dbo.Topics] PRIMARY KEY ([TopicId])
)
CREATE TABLE [dbo].[Libraries] (
    [LibraryId] [int] NOT NULL IDENTITY,
    [Title] [nvarchar](max),
    [Description] [nvarchar](max),
    CONSTRAINT [PK_dbo.Libraries] PRIMARY KEY ([LibraryId])
)
CREATE TABLE [dbo].[Languages] (
    [LanguageId] [int] NOT NULL IDENTITY,
    [Title] [nvarchar](max),
    [Description] [nvarchar](max),
    CONSTRAINT [PK_dbo.Languages] PRIMARY KEY ([LanguageId])
)
CREATE TABLE [dbo].[Plans] (
    [PlanId] [int] NOT NULL IDENTITY,
    [Title] [nvarchar](max),
    [Description] [nvarchar](max),
    [Price] [decimal](18, 2) NOT NULL,
    CONSTRAINT [PK_dbo.Plans] PRIMARY KEY ([PlanId])
)
CREATE INDEX [IX_User_UserId] ON [dbo].[Users_Authors]([User_UserId])
CREATE INDEX [IX_Category_CategoryId] ON [dbo].[Videos]([Category_CategoryId])
CREATE INDEX [IX_Topic_TopicId] ON [dbo].[Videos]([Topic_TopicId])
CREATE INDEX [IX_AuthorI_AuthorId] ON [dbo].[Videos]([AuthorI_AuthorId])
CREATE INDEX [IX_Language_LanguageId] ON [dbo].[Videos]([Language_LanguageId])
CREATE INDEX [IX_Author_AuthorId] ON [dbo].[Videos]([Author_AuthorId])
CREATE INDEX [IX_Author_AuthorId1] ON [dbo].[Videos]([Author_AuthorId1])
CREATE INDEX [IX_Topic_TopicId] ON [dbo].[Categories]([Topic_TopicId])
CREATE INDEX [IX_Library_LibraryId] ON [dbo].[Topics]([Library_LibraryId])
ALTER TABLE [dbo].[Users_Authors] ADD CONSTRAINT [FK_dbo.Users_Authors_dbo.Users_User_UserId] FOREIGN KEY ([User_UserId]) REFERENCES [dbo].[Users] ([UserId])
ALTER TABLE [dbo].[Videos] ADD CONSTRAINT [FK_dbo.Videos_dbo.Categories_Category_CategoryId] FOREIGN KEY ([Category_CategoryId]) REFERENCES [dbo].[Categories] ([CategoryId])
ALTER TABLE [dbo].[Videos] ADD CONSTRAINT [FK_dbo.Videos_dbo.Topics_Topic_TopicId] FOREIGN KEY ([Topic_TopicId]) REFERENCES [dbo].[Topics] ([TopicId])
ALTER TABLE [dbo].[Videos] ADD CONSTRAINT [FK_dbo.Videos_dbo.Users_Authors_AuthorI_AuthorId] FOREIGN KEY ([AuthorI_AuthorId]) REFERENCES [dbo].[Users_Authors] ([AuthorId])
ALTER TABLE [dbo].[Videos] ADD CONSTRAINT [FK_dbo.Videos_dbo.Languages_Language_LanguageId] FOREIGN KEY ([Language_LanguageId]) REFERENCES [dbo].[Languages] ([LanguageId])
ALTER TABLE [dbo].[Videos] ADD CONSTRAINT [FK_dbo.Videos_dbo.Users_Authors_Author_AuthorId] FOREIGN KEY ([Author_AuthorId]) REFERENCES [dbo].[Users_Authors] ([AuthorId])
ALTER TABLE [dbo].[Videos] ADD CONSTRAINT [FK_dbo.Videos_dbo.Users_Authors_Author_AuthorId1] FOREIGN KEY ([Author_AuthorId1]) REFERENCES [dbo].[Users_Authors] ([AuthorId])
ALTER TABLE [dbo].[Categories] ADD CONSTRAINT [FK_dbo.Categories_dbo.Topics_Topic_TopicId] FOREIGN KEY ([Topic_TopicId]) REFERENCES [dbo].[Topics] ([TopicId])
ALTER TABLE [dbo].[Topics] ADD CONSTRAINT [FK_dbo.Topics_dbo.Libraries_Library_LibraryId] FOREIGN KEY ([Library_LibraryId]) REFERENCES [dbo].[Libraries] ([LibraryId])

