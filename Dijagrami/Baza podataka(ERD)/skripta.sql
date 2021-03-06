-- MySQL Script generated by MySQL Workbench
-- 05/19/17 23:06:24
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema Bolnica
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Bolnica
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Bolnica` DEFAULT CHARACTER SET utf8 ;
USE `Bolnica` ;

-- -----------------------------------------------------
-- Table `Bolnica`.`Osoba`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bolnica`.`Osoba` (
  `jmbg` INT NOT NULL,
  `ime` VARCHAR(45) NOT NULL,
  `Prezime` VARCHAR(45) NOT NULL,
  `datumRodjenja` DATE NULL,
  `adresaStanovanja` VARCHAR(45) NULL,
  `brojTelefona` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  PRIMARY KEY (`jmbg`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bolnica`.`Odjeli`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bolnica`.`Odjeli` (
  `idOdjeli` INT NOT NULL,
  `naziv` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idOdjeli`),
  UNIQUE INDEX `naziv_UNIQUE` (`naziv` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bolnica`.`RadnoMjesto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bolnica`.`RadnoMjesto` (
  `idRadnoMjesto` INT NOT NULL,
  `naziv` VARCHAR(45) NULL,
  PRIMARY KEY (`idRadnoMjesto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bolnica`.`Uposlenik`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bolnica`.`Uposlenik` (
  `idUposlenik` INT NOT NULL,
  `plata` FLOAT NOT NULL,
  `RadnoMjesto_idRadnoMjesto` INT NOT NULL,
  `Odjeli_idOdjeli` INT NOT NULL,
  `Osoba_jmbg` INT NOT NULL,
  PRIMARY KEY (`idUposlenik`),
  INDEX `fk_Uposlenik_RadnoMjesto1_idx` (`RadnoMjesto_idRadnoMjesto` ASC),
  INDEX `fk_Uposlenik_Odjeli1_idx` (`Odjeli_idOdjeli` ASC),
  INDEX `fk_Uposlenik_Osoba1_idx` (`Osoba_jmbg` ASC),
  CONSTRAINT `fk_Uposlenik_RadnoMjesto1`
    FOREIGN KEY (`RadnoMjesto_idRadnoMjesto`)
    REFERENCES `Bolnica`.`RadnoMjesto` (`idRadnoMjesto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Uposlenik_Odjeli1`
    FOREIGN KEY (`Odjeli_idOdjeli`)
    REFERENCES `Bolnica`.`Odjeli` (`idOdjeli`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Uposlenik_Osoba1`
    FOREIGN KEY (`Osoba_jmbg`)
    REFERENCES `Bolnica`.`Osoba` (`jmbg`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bolnica`.`Pacijent`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bolnica`.`Pacijent` (
  `idPacijenta` INT NOT NULL,
  `Osoba_jmbg` INT NOT NULL,
  PRIMARY KEY (`idPacijenta`),
  INDEX `fk_Pacijent_Osoba1_idx` (`Osoba_jmbg` ASC),
  CONSTRAINT `fk_Pacijent_Osoba1`
    FOREIGN KEY (`Osoba_jmbg`)
    REFERENCES `Bolnica`.`Osoba` (`jmbg`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bolnica`.`LaboratorijskaAnaliza`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bolnica`.`LaboratorijskaAnaliza` (
  `idLaboratorijskaAnaliza` INT NOT NULL,
  `VrstaAnalize_idVrstaAnalize` INT NOT NULL,
  `komentar` MEDIUMTEXT NULL,
  `datum` DATE NULL,
  `LaboratorijskaAnalizacol` VARCHAR(45) NULL,
  `Pacijent_jmbg` INT NOT NULL,
  `Uposlenik_idUposlenik` INT NOT NULL,
  PRIMARY KEY (`idLaboratorijskaAnaliza`, `Uposlenik_idUposlenik`),
  INDEX `fk_LaboratorijskaAnaliza_Pacijent1_idx` (`Pacijent_jmbg` ASC),
  INDEX `fk_LaboratorijskaAnaliza_Uposlenik1_idx` (`Uposlenik_idUposlenik` ASC),
  CONSTRAINT `fk_LaboratorijskaAnaliza_Pacijent1`
    FOREIGN KEY (`Pacijent_jmbg`)
    REFERENCES `Bolnica`.`Pacijent` (`idPacijenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_LaboratorijskaAnaliza_Uposlenik1`
    FOREIGN KEY (`Uposlenik_idUposlenik`)
    REFERENCES `Bolnica`.`Uposlenik` (`idUposlenik`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bolnica`.`Lijekovi`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bolnica`.`Lijekovi` (
  `idLijekovi` INT NOT NULL,
  `kolicinaNaStanju` INT NULL,
  `cijena` FLOAT NULL,
  `naziv` INT NULL,
  PRIMARY KEY (`idLijekovi`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bolnica`.`ZahtjevZaLijekom`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bolnica`.`ZahtjevZaLijekom` (
  `idZahtjevZaLijekom` INT NOT NULL,
  `datum` DATE NULL,
  `kolicina` INT NULL,
  `Pacijent_jmbg` INT NOT NULL,
  `Lijekovi_idLijekovi` INT NOT NULL,
  `Uposlenik_idUposlenik` INT NOT NULL,
  PRIMARY KEY (`idZahtjevZaLijekom`, `Lijekovi_idLijekovi`),
  INDEX `fk_ZahtjevZaLijekom_Pacijent1_idx` (`Pacijent_jmbg` ASC),
  INDEX `fk_ZahtjevZaLijekom_Lijekovi1_idx` (`Lijekovi_idLijekovi` ASC),
  INDEX `fk_ZahtjevZaLijekom_Uposlenik1_idx` (`Uposlenik_idUposlenik` ASC),
  CONSTRAINT `fk_ZahtjevZaLijekom_Pacijent1`
    FOREIGN KEY (`Pacijent_jmbg`)
    REFERENCES `Bolnica`.`Pacijent` (`idPacijenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ZahtjevZaLijekom_Lijekovi1`
    FOREIGN KEY (`Lijekovi_idLijekovi`)
    REFERENCES `Bolnica`.`Lijekovi` (`idLijekovi`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ZahtjevZaLijekom_Uposlenik1`
    FOREIGN KEY (`Uposlenik_idUposlenik`)
    REFERENCES `Bolnica`.`Uposlenik` (`idUposlenik`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bolnica`.`table1`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bolnica`.`table1` (
)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bolnica`.`Pregledi`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bolnica`.`Pregledi` (
  `idPregledi` INT NOT NULL,
  `datum` DATE NULL,
  `izvjestaj` MEDIUMTEXT NULL,
  `Pacijent_jmbg` INT NOT NULL,
  `Uposlenik_idUposlenik` INT NOT NULL,
  PRIMARY KEY (`idPregledi`),
  INDEX `fk_Pregledi_Pacijent1_idx` (`Pacijent_jmbg` ASC),
  INDEX `fk_Pregledi_Uposlenik1_idx` (`Uposlenik_idUposlenik` ASC),
  CONSTRAINT `fk_Pregledi_Pacijent1`
    FOREIGN KEY (`Pacijent_jmbg`)
    REFERENCES `Bolnica`.`Pacijent` (`idPacijenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pregledi_Uposlenik1`
    FOREIGN KEY (`Uposlenik_idUposlenik`)
    REFERENCES `Bolnica`.`Uposlenik` (`idUposlenik`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bolnica`.`ListaCekanjaPregleda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bolnica`.`ListaCekanjaPregleda` (
  `idListaCekanjaPregleda` INT NOT NULL,
  `datumVrijeme` DATETIME NULL,
  `Pacijent_idPacijenta` INT NOT NULL,
  `Odjeli_idOdjeli` INT NOT NULL,
  PRIMARY KEY (`idListaCekanjaPregleda`),
  INDEX `fk_ListaCekanjaPregleda_Pacijent1_idx` (`Pacijent_idPacijenta` ASC),
  INDEX `fk_ListaCekanjaPregleda_Odjeli1_idx` (`Odjeli_idOdjeli` ASC),
  CONSTRAINT `fk_ListaCekanjaPregleda_Pacijent1`
    FOREIGN KEY (`Pacijent_idPacijenta`)
    REFERENCES `Bolnica`.`Pacijent` (`idPacijenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ListaCekanjaPregleda_Odjeli1`
    FOREIGN KEY (`Odjeli_idOdjeli`)
    REFERENCES `Bolnica`.`Odjeli` (`idOdjeli`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
