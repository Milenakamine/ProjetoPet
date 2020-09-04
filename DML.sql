--DML: DATA MANIPULATION LANGUAGE
--INSERT:INSERIR
--UPDATE:ALTERSR
--DELE:EXCLUIR
USE PetShop;

--INSERT
INSERT INTO Clinica (Nome, Endereco) Values('Pet Care', 'Rio de Janeiro');
INSERT INTO Veterinario (Nome, CRV, IdClinica) Values ('Alex Gus', '75698429', 1);
INSERT INTO TipoPet(Descricao) Values ('Gato');
INSERT INTO Dono(Nome) Values ('Pamela Reis');
INSERT INTO Raca(Descricao, IdTipoPet) Values ('Persa', 2);
INSERT INTO Pet(Nome, DataNascimento, IdRaca, IdDono) Values ('Ravenna', '12/12/2016', 4, 1);
INSERT INTO Atendimento(Descricao, DataAtendimento, IdPet, IdVeterinario) Values ('Cirurgia','2020-07-24T23:59:59', '4', '2');

--DELETE POR DADOS
--DELETE FROM Clinica WHERE IdClinica = 3; 
DELETE FROM Raca WHERE IdRaca = 13; 

--Update 
--UPDATE Clinica SET
--	Nome= 'Petsss'


--Para conseguir visualizar oq esta acontecendo 
--DQL:SELECT
SELECT * FROM Clinica;
SELECT * FROM Veterinario;
SELECT * FROM TipoPet;
SELECT * FROM Dono;
SELECT * FROM Raca;
SELECT * FROM Pet;
SELECT * FROM Atendimento;