﻿  CREATE TABLE Produtos (
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	Sabor VARCHAR(500),
	Tamanho VARCHAR(100),
	Imagem VARCHAR(MAX),
	Preco DECIMAL
)