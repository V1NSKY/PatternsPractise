-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema GameLibraryDB
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema GameLibraryDB
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `GameLibraryDB` DEFAULT CHARACTER SET utf8 ;
USE `GameLibraryDB` ;

-- -----------------------------------------------------
-- Table `GameLibraryDB`.`UserRole`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GameLibraryDB`.`UserRole` (
  `idUserRole` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `userRoleName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idUserRole`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `GameLibraryDB`.`User`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GameLibraryDB`.`User` (
  `idUser` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `idUserRole` INT UNSIGNED NOT NULL,
  `userName` VARCHAR(45) NOT NULL,
  `userSurname` VARCHAR(45) NOT NULL,
  `userMiddleName` VARCHAR(45) NULL,
  `userLogin` VARCHAR(45) NOT NULL,
  `userPassword` VARCHAR(45) NOT NULL,
  `userPhone` VARCHAR(16) NULL,
  `userDescription` TEXT NULL,
  PRIMARY KEY (`idUser`),
  INDEX `fk_User_UserCategory1_idx` (`idUserRole` ASC) VISIBLE,
  CONSTRAINT `fk_User_UserCategory1`
    FOREIGN KEY (`idUserRole`)
    REFERENCES `GameLibraryDB`.`UserRole` (`idUserRole`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `GameLibraryDB`.`Game`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GameLibraryDB`.`Game` (
  `idGame` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `gameDeveloper` VARCHAR(45) NOT NULL,
  `gamePublisher` VARCHAR(45) NOT NULL,
  `gameName` VARCHAR(45) NOT NULL,
  `gamePrice` FLOAT(6,2) UNSIGNED NOT NULL,
  `gameDateOfRelease` DATE NOT NULL,
  `gameDescription` TEXT NULL,
  PRIMARY KEY (`idGame`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `GameLibraryDB`.`GameGenre`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GameLibraryDB`.`GameGenre` (
  `idGameGenre` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `genreName` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idGameGenre`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `GameLibraryDB`.`UserGameLibrary`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GameLibraryDB`.`UserGameLibrary` (
  `idGame` INT UNSIGNED NOT NULL,
  `idUser` INT UNSIGNED NOT NULL,
  `dateAdded` DATE NOT NULL,
  `hoursPlayed` INT UNSIGNED NULL,
  `dateLastPlayed` DATE NULL,
  PRIMARY KEY (`idGame`, `idUser`),
  INDEX `fk_Games_has_User_User1_idx` (`idUser` ASC) VISIBLE,
  INDEX `fk_Games_has_User_Games1_idx` (`idGame` ASC) VISIBLE,
  CONSTRAINT `fk_Games_has_User_Games1`
    FOREIGN KEY (`idGame`)
    REFERENCES `GameLibraryDB`.`Game` (`idGame`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Games_has_User_User1`
    FOREIGN KEY (`idUser`)
    REFERENCES `GameLibraryDB`.`User` (`idUser`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `GameLibraryDB`.`SpecificGenre`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GameLibraryDB`.`SpecificGenre` (
  `idGame` INT UNSIGNED NOT NULL,
  `idGameGenre` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`idGame`, `idGameGenre`),
  INDEX `fk_Game_has_GameGenre_GameGenre1_idx` (`idGameGenre` ASC) VISIBLE,
  INDEX `fk_Game_has_GameGenre_Game1_idx` (`idGame` ASC) VISIBLE,
  CONSTRAINT `fk_Game_has_GameGenre_Game1`
    FOREIGN KEY (`idGame`)
    REFERENCES `GameLibraryDB`.`Game` (`idGame`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Game_has_GameGenre_GameGenre1`
    FOREIGN KEY (`idGameGenre`)
    REFERENCES `GameLibraryDB`.`GameGenre` (`idGameGenre`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `GameLibraryDB`.`SystemReq`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GameLibraryDB`.`SystemReq` (
  `idSystemReq` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `sr_OS` VARCHAR(45) NOT NULL,
  `sr_processor` VARCHAR(45) NOT NULL,
  `sr_RAM` INT UNSIGNED NOT NULL,
  `sr_video` VARCHAR(45) NOT NULL,
  `sr_space` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`idSystemReq`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `GameLibraryDB`.`GameSR`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GameLibraryDB`.`GameSR` (
  `idGame` INT UNSIGNED NOT NULL,
  `idSystemReq` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`idGame`, `idSystemReq`),
  INDEX `fk_Game_has_SystemReq_SystemReq1_idx` (`idSystemReq` ASC) VISIBLE,
  INDEX `fk_Game_has_SystemReq_Game1_idx` (`idGame` ASC) VISIBLE,
  CONSTRAINT `fk_Game_has_SystemReq_Game1`
    FOREIGN KEY (`idGame`)
    REFERENCES `GameLibraryDB`.`Game` (`idGame`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Game_has_SystemReq_SystemReq1`
    FOREIGN KEY (`idSystemReq`)
    REFERENCES `GameLibraryDB`.`SystemReq` (`idSystemReq`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
