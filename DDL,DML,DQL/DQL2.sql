USE PetShop;
--Pega todos os dados da tabela da esquerda mesmo que esteja faltando algo e da tabela da direita ele ignora quem esta faltando,
--Ocorre a mesma coisa right join, mas ele pega tudo da tabela da direita msm que esteja falntando e da esquerda ele so pega quem tem amarrações
--E tambem tem o outro que pega tudo, tendo amarracao ou nao
--DQL JOINS
SELECT * FROM Atendimento;
SELECT * FROM Clinica;
SELECT * FROM Dono;
SELECT * FROM Pet;
SELECT * FROM Raca;
SELECT * FROM TipoPet;
SELECT * FROM Veterinario;

SELECT
	Pet.Nome,
	Veterinario.Nome,
	Atendimento.Descricao 
FROM Atendimento
	INNER JOIN Pet ON Atendimento.IdPet= Pet.IdPet 
	INNER JOIN Veterinario ON Atendimento.IdVeterinario=Veterinario.IdVeterinario
;
	--Mostrando qual animal foi atendindo por qual veterinario e oq ocorreu.

	

