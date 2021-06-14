CREATE TABLE [dbo].[TabelaTeste]
(
	[Código] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Descricao] VARCHAR(250) NULL, 
    [CampoUm] VARCHAR(250) NULL, 
    [CampoDois] VARCHAR(250) NULL, 
    [CampoTres] VARCHAR(250) NULL, 
    [CampoQuatro] VARCHAR(250) NULL, 
    [CampoBool] BIT NULL, 
    [CampoData] DATETIME NULL
)
