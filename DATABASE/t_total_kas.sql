-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 25 Bulan Mei 2023 pada 20.08
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kas_kridataruna_branglor`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_total_kas`
--

CREATE TABLE `t_total_kas` (
  `total_kas_kode` char(3) NOT NULL COMMENT 'kode kas bulanan yang digunakan',
  `kas_bulanan_kode` char(3) NOT NULL COMMENT 'kode kas bulanan yang digunakan',
  `tanggal_laporan` date NOT NULL COMMENT 'tanggal laporan kas',
  `jumlah_pengeluaran_kas` int(10) NOT NULL COMMENT 'jumlah uang kas',
  `jumlah_uang_kas` int(10) NOT NULL COMMENT 'jumlah uang kas',
  `keterangan` varchar(50) NOT NULL COMMENT 'keterangan'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `t_total_kas`
--
ALTER TABLE `t_total_kas`
  ADD PRIMARY KEY (`total_kas_kode`),
  ADD KEY `t_total_kas` (`kas_bulanan_kode`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `t_total_kas`
--
ALTER TABLE `t_total_kas`
  ADD CONSTRAINT `t_total_kas` FOREIGN KEY (`kas_bulanan_kode`) REFERENCES `t_kas_bulanan` (`kas_bulanan_kode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
