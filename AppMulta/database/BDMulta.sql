CREATE DATABASE BDMulta;
#DROP DATABASE BDMulta;

USE BDMulta;

CREATE TABLE veiculo (
id_vei INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
modelo VARCHAR(300),
marca VARCHAR(300),
placa VARCHAR(8)
);

CREATE TABLE multa (
id INT PRIMARY KEY AUTO_INCREMENT,
descricao VARCHAR(300),
valor_multa DECIMAL(10,2),
id_veiculo_fk INT,
FOREIGN KEY (id_veiculo_fk) REFERENCES veiculo (id_vei)
);

SELECT * FROM veiculo;