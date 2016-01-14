-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.1.8-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win32
-- HeidiSQL Version:             9.1.0.4867
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for example
DROP DATABASE IF EXISTS `example`;
CREATE DATABASE IF NOT EXISTS `example` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `example`;


-- Dumping structure for table example.barang
DROP TABLE IF EXISTS `barang`;
CREATE TABLE IF NOT EXISTS `barang` (
  `barang_id` char(10) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`barang_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table example.barang: ~2 rows (approximately)
/*!40000 ALTER TABLE `barang` DISABLE KEYS */;
INSERT INTO `barang` (`barang_id`, `nama`) VALUES
	('B000000001', 'Bodrex'),
	('B000000002', 'Autan'),
	('B000000003', 'Baygon');
/*!40000 ALTER TABLE `barang` ENABLE KEYS */;


-- Dumping structure for table example.detail
DROP TABLE IF EXISTS `detail`;
CREATE TABLE IF NOT EXISTS `detail` (
  `transaksi_id` char(10) NOT NULL,
  `barang_id` char(10) NOT NULL,
  `jumlah` int(11) DEFAULT NULL,
  PRIMARY KEY (`transaksi_id`,`barang_id`),
  KEY `barang_id` (`barang_id`),
  CONSTRAINT `barang_id` FOREIGN KEY (`barang_id`) REFERENCES `barang` (`barang_id`),
  CONSTRAINT `transaksi_id` FOREIGN KEY (`transaksi_id`) REFERENCES `transaksi` (`transaksi_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table example.detail: ~0 rows (approximately)
/*!40000 ALTER TABLE `detail` DISABLE KEYS */;
INSERT INTO `detail` (`transaksi_id`, `barang_id`, `jumlah`) VALUES
	('T000000001', 'B000000001', 1),
	('T000000001', 'B000000002', 2);
/*!40000 ALTER TABLE `detail` ENABLE KEYS */;


-- Dumping structure for table example.pengguna
DROP TABLE IF EXISTS `pengguna`;
CREATE TABLE IF NOT EXISTS `pengguna` (
  `user_id` char(6) NOT NULL,
  `username` varchar(50) NOT NULL,
  `kata_sandi` varchar(50) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `jenis_kelamin` char(1) DEFAULT NULL,
  `tempat_lahir` varchar(50) DEFAULT NULL,
  `tanggal_lahir` date DEFAULT NULL,
  `foto` blob,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table example.pengguna: ~3 rows (approximately)
/*!40000 ALTER TABLE `pengguna` DISABLE KEYS */;
INSERT INTO `pengguna` (`user_id`, `username`, `kata_sandi`, `nama`, `jenis_kelamin`, `tempat_lahir`, `tanggal_lahir`, `foto`) VALUES
	('U00001', 'admin', 'admin', 'Administrator', '-', 'Malang', '2010-12-22', NULL),
	('U00003', 'clala', 'clala', 'clala santa', 'P', 'Malang', '1995-05-30', NULL);
/*!40000 ALTER TABLE `pengguna` ENABLE KEYS */;


-- Dumping structure for table example.transaksi
DROP TABLE IF EXISTS `transaksi`;
CREATE TABLE IF NOT EXISTS `transaksi` (
  `transaksi_id` char(10) NOT NULL,
  `nama` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`transaksi_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table example.transaksi: ~0 rows (approximately)
/*!40000 ALTER TABLE `transaksi` DISABLE KEYS */;
INSERT INTO `transaksi` (`transaksi_id`, `nama`) VALUES
	('T000000001', 'Test');
/*!40000 ALTER TABLE `transaksi` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
