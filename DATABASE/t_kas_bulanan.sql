-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 26 Bulan Mei 2023 pada 17.51
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
-- Struktur dari tabel `t_kas_bulanan`
--

CREATE TABLE `t_kas_bulanan` (
  `kas_bulanan_kode` char(3) NOT NULL COMMENT 'kode kas bulanan yang digunakan',
  `anggota_kode` char(3) NOT NULL COMMENT 'kode anggota yang digunakan',
  `tanggal_kas` date NOT NULL COMMENT 'tanggal penarikan kas',
  `nominalpembayaran_kas` int(10) NOT NULL COMMENT 'nominal uang kas yang perlu dibayarkan',
  `pembayaran_kas_anggota` int(10) NOT NULL COMMENT 'uang kas yang dibayarkan anggota',
  `keterangan` varchar(50) NOT NULL COMMENT 'keterangan lunas kas ataupun belum'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `t_kas_bulanan`
--

INSERT INTO `t_kas_bulanan` (`kas_bulanan_kode`, `anggota_kode`, `tanggal_kas`, `nominalpembayaran_kas`, `pembayaran_kas_anggota`, `keterangan`) VALUES
('K1', 'A1', '2022-01-04', 10000, 10000, 'Sudah membayar kas bulanan'),
('K2', 'A2', '2022-01-04', 5000, 0, 'Belum membayar kas bulanan'),
('K3', 'A3', '2022-01-04', 5000, 5000, 'Sudah membayar kas bulanan'),
('K4', 'A5', '2022-02-09', 10000, 10000, 'Sudah membayar kas bulanan'),
('K5', 'A4', '2022-02-09', 10000, 10000, 'Sudah membayar kas bulanan');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `t_kas_bulanan`
--
ALTER TABLE `t_kas_bulanan`
  ADD PRIMARY KEY (`kas_bulanan_kode`),
  ADD KEY `t_kas_bulanan` (`anggota_kode`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `t_kas_bulanan`
--
ALTER TABLE `t_kas_bulanan`
  ADD CONSTRAINT `t_kas_bulanan` FOREIGN KEY (`anggota_kode`) REFERENCES `t_anggota` (`anggota_kode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
