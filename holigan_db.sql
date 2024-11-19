-- --------------------------------------------------------
-- Sunucu:                       127.0.0.1
-- Sunucu sürümü:                8.2.0 - MySQL Community Server - GPL
-- Sunucu İşletim Sistemi:       Win64
-- HeidiSQL Sürüm:               12.4.0.6659
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- holigan_db için veritabanı yapısı dökülüyor
CREATE DATABASE IF NOT EXISTS `holigan_db` /*!40100 DEFAULT CHARACTER SET latin5 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `holigan_db`;

-- tablo yapısı dökülüyor holigan_db.admin
CREATE TABLE IF NOT EXISTS `admin` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin5;

-- holigan_db.admin: 1 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` (`id`, `username`, `password`) VALUES
	(1, 'admin', '1234');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;

-- tablo yapısı dökülüyor holigan_db.contact
CREATE TABLE IF NOT EXISTS `contact` (
  `id` int NOT NULL AUTO_INCREMENT,
  `namesurname` varchar(50) CHARACTER SET latin5 COLLATE latin5_turkish_ci NOT NULL,
  `phone` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin5;

-- holigan_db.contact: 0 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `contact` DISABLE KEYS */;
/*!40000 ALTER TABLE `contact` ENABLE KEYS */;

-- tablo yapısı dökülüyor holigan_db.login
CREATE TABLE IF NOT EXISTS `login` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin5;

-- holigan_db.login: 0 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` (`id`, `username`, `password`) VALUES
	(1, 'Testuser', '123456'),
	(2, 'Ahmet', '1234'),
	(3, 'ahmet', '12345'),
	(4, 'ahmet', '1234'),
	(5, 'test', '1234'),
	(6, 'test', '12356'),
	(7, 'test', '1234'),
	(8, 'test1', '123455'),
	(9, 'test', '1234');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;

-- tablo yapısı dökülüyor holigan_db.offer
CREATE TABLE IF NOT EXISTS `offer` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `moneyamount` varchar(50) NOT NULL,
  `datetime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin5;

-- holigan_db.offer: 0 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `offer` DISABLE KEYS */;
INSERT INTO `offer` (`id`, `username`, `moneyamount`, `datetime`) VALUES
	(2, 'Ahmet', '200', '2024-03-03 02:46:01');
/*!40000 ALTER TABLE `offer` ENABLE KEYS */;

-- tablo yapısı dökülüyor holigan_db.user
CREATE TABLE IF NOT EXISTS `user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `email` varchar(100) CHARACTER SET latin5 COLLATE latin5_turkish_ci NOT NULL,
  `username` varchar(100) CHARACTER SET latin5 COLLATE latin5_turkish_ci NOT NULL,
  `password` varchar(100) CHARACTER SET latin5 COLLATE latin5_turkish_ci NOT NULL,
  `name` varchar(50) CHARACTER SET latin5 COLLATE latin5_turkish_ci NOT NULL,
  `surname` varchar(50) CHARACTER SET latin5 COLLATE latin5_turkish_ci NOT NULL,
  `birthdate` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin5;

-- holigan_db.user: 1 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` (`id`, `email`, `username`, `password`, `name`, `surname`, `birthdate`) VALUES
	(2, 'test@mail.com', 'testusername', 'testsifre', 'cinar', 'göksu', '2024-03-03');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
