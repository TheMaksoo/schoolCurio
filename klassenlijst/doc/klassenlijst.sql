SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

--
-- Database: `klassenlijst`
--
DROP DATABASE IF EXISTS `klassenlijst`;
CREATE DATABASE IF NOT EXISTS `klassenlijst` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `klassenlijst`;

--
-- Tabel: `studenten`
--

DROP TABLE IF EXISTS `studenten`;
CREATE TABLE IF NOT EXISTS `studenten` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(255) NOT NULL,
  `leeftijd` int(11) NOT NULL,
  `woonplaats` varchar(255) DEFAULT NULL,
  `geboortedatum` date NOT NULL,
  `ingeschreven` tinyint(1) NOT NULL DEFAULT 0,
  `niveau` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;


INSERT INTO `studenten` (`naam`, `leeftijd`, `woonplaats`, `geboortedatum`, `ingeschreven`, `niveau`) VALUES
('S. Tudent', 18, 'Breda', '2000-08-01', 1, NULL);
