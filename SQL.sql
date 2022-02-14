-- Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 
SELECT nome,evento FROM teste.tabela_pessoa
INNER JOIN teste.tabela_evento
ON tabela_evento.pessoa_id = tabela_pessoa.id;


-- Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.
SELECT * FROM teste.tabela_pessoa WHERE nome  LIKE "%Doe";


-- Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'.
INSERT INTO tabela_evento VALUES(5,"Evento E",5);


-- Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'Joh Doe'
UPDATE tabela_evento SET pessoa_id = 1 WHERE evento = "Evento D";

-- Crie uma query para remover o 'Evento B' na 'tabela_evento'.
DELETE FROM tabela_evento WHERE evento = "Evento B";


-- Crie uma query para remover todas as pessoas 'tabela_pessoa' que não possuem eventos 'tabela_evento' relacionados.
DELETE tabela_pessoa FROM  tabela_pessoa  LEFT OUTER JOIN tabela_evento ON tabela_pessoa.id = tabela_evento.pessoa_id
    WHERE tabela_evento.pessoa_id is null;
    
-- Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)
ALTER TABLE tabela_pessoa ADD idade INT;


-- Gerênciamento de tabelas -- 
CREATE TABLE tabela_telefone(
id int auto_increment unique,
telefone varchar(200),
pessoa_id int,
primary key(id),
foreign key(pessoa_id) references tabela_pessoa(id)

);

DROP TABLE tabela_telefone;
