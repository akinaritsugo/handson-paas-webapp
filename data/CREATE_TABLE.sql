IF OBJECT_ID(N'prefectures', N'U') IS NOT NULL DROP TABLE [prefectures];
CREATE TABLE [dbo].[prefectures] (
    [code] INT        IDENTITY (1, 1) NOT NULL,
    [name] NCHAR (10) NULL,
    CONSTRAINT [PK_CODE] PRIMARY KEY CLUSTERED ([code] ASC)
);

IF OBJECT_ID(N'[work]', N'U') IS NOT NULL DROP TABLE [work];
CREATE TABLE [dbo].[work] (
    [prefectures_code] INT NOT NULL,
    [survey_year]      INT NOT NULL,
    [employees]        INT NOT NULL,
    CONSTRAINT [PK_WORK_1] PRIMARY KEY CLUSTERED ([prefectures_code] ASC, [survey_year] ASC)
);


