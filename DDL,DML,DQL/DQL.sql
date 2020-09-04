USE PetShop
--Selecionar tudo de tal tabela
SELECT * FROM Dono;
SELECT * FROM Clinica;
SELECT * FROM TipoPet;
SELECT * FROM Veterinario;
SELECT * FROM Pet;


--Seleciona um dado em específico 
SELECT * FROM Raca WHERE IdRaca=3 OR --(||) 
 IdRaca=1;

 --Seleciona uma busca com algo que tenha dentro da palavra
 SELECT * FROM Pet WHERE
	Nome LIKE '%Pi%';

SELECT * FROM Raca WHERE Descricao LIKE '%A%';
SELECT * FROM Veterinario WHERE 
	Nome LIKE '%S%' AND--(&&) 
	CRV LIKE '%9%';

--Ordenar de forma crescente PADRAO
SELECT * FROM TipoPet ORDER BY Descricao;

--Ordenar de forma crescente de outra maneira
SELECT * FROM Atendimento ORDER BY Descricao ASC;

--Ordenar de forma decrescente
SELECT * FROM Atendimento ORDER BY Descricao DESC;

--Condição especifica
SELECT * FROM Veterinario WHERE IdVeterinario >2 AND IdVeterinario<5;







