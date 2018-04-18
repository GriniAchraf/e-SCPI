CREATE DATABASE E_SCPI;
USE E_SCPI;
CREATE TABLE EMPLOYEE(
  id int NOT NULL AUTO_INCREMENT,
    login varchar(255),
    passwd varchar(255),
     PRIMARY KEY (id)
    
);

INSERT INTO EMPLOYEE VALUES(1,'admin','dauphine2018');

CREATE TABLE SCPI (
  id int NOT NULL AUTO_INCREMENT,
    nom varchar(255),
    capital decimal,
    frais decimal,
    date_creation date,
     PRIMARY KEY (id)
    
);

CREATE TABLE BIEN_IMMOBILIER (
  id int NOT NULL AUTO_INCREMENT,
    cadastre varchar(255),
    adresse varchar(255),
    images varchar(255),
    cout decimal,
    charges decimal,
    loyer decimal,
    SCPI_ID int,
    Position_SCPI int,
    type varchar(255),
     PRIMARY KEY (id),
     FOREIGN KEY (SCPI_ID) REFERENCES SCPI(id)
    
);

CREATE TABLE SOUSCRIPTEUR (
  id int NOT NULL AUTO_INCREMENT,
    nom varchar(255),
    cni varchar(255),
    prenom varchar(255),
    date_naissance date,
PRIMARY KEY (id)
    
);

CREATE TABLE PART (
	id int NOT NULL AUTO_INCREMENT,
	montant decimal,
	date_souscription date,
	SCPI_ID int,
    Position_SCPI int,
	SOUSCRIPTEUR_ID int,
    Position_SOUSCRIPTEUR int,
	PRIMARY KEY (id),
     FOREIGN KEY (SCPI_ID) REFERENCES SCPI(id),
     FOREIGN KEY (SOUSCRIPTEUR_ID) REFERENCES SOUSCRIPTEUR(id)
    
);