BULK INSERT comentarios
FROM 'C:\Dados_Importacao/comentarios.csv'
WITH (
	FIELDTERMINATOR = ';',
	ROWTERMINATOR  = '\n',
	FIRSTROW = 2,
	CODEPAGE = 'acp'
);