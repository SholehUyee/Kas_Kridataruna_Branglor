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
-- Struktur dari tabel `t_anggota`
--

CREATE TABLE `t_anggota` (
  `anggota_kode` char(3) NOT NULL COMMENT 'kode anggota yang digunakan',
  `statusanggota_kode` char(3) NOT NULL COMMENT 'kode status anggota yang digunakan',
  `nama_anggota` varchar(50) NOT NULL COMMENT 'nama dari anggota krida taruna',
  `jenis_kelamin` enum('Laki - Laki','Perempuan') NOT NULL COMMENT 'pilihan untuk Jenis Kelamin yang dipilih',
  `no_hp` varchar(20) NOT NULL COMMENT 'no hp'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `t_anggota`
--

INSERT INTO `t_anggota` (`anggota_kode`, `statusanggota_kode`, `nama_anggota`, `jenis_kelamin`, `no_hp`) VALUES
('A1', 'K18', 'Ahmad Janaka', 'Laki - Laki', '083810830883'),
('A2', 'S17', 'Andi Putra', 'Laki - Laki', '081838981891'),
('A3', 'S17', 'Ayu Putri', 'Perempuan', '089183190180'),
('A4', 'K27', 'Bayu Bagus', 'Laki - Laki', '087379183972'),
('A5', 'K37', 'Berlian Dwiana Putri', 'Perempuan', '081983983198');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_anggota_bendahara`
--

CREATE TABLE `t_anggota_bendahara` (
  `nourut` int(3) NOT NULL COMMENT 'kode anggota yang digunakan',
  `kas_bulanan_kode` char(3) NOT NULL COMMENT 'kode kas bulanan yang digunakan',
  `nama_anggota` varchar(50) NOT NULL COMMENT 'nama dari anggota krida taruna',
  `jenis_kelamin` enum('Laki - Laki','Perempuan') NOT NULL COMMENT 'pilihan untuk Jenis Kelamin yang dipilih',
  `status_bendahara` varchar(50) NOT NULL COMMENT 'status dari bendahara',
  `tanggung_jawab` varchar(50) NOT NULL COMMENT 'tanggung jawab dari tugas'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `t_anggota_bendahara`
--

INSERT INTO `t_anggota_bendahara` (`nourut`, `kas_bulanan_kode`, `nama_anggota`, `jenis_kelamin`, `status_bendahara`, `tanggung_jawab`) VALUES
(1, 'K1', 'Ayu Putri', 'Perempuan', 'Ketua Bendahara', 'Sudah terlaksana menarik uang kas bulanan anggota'),
(2, 'K2', 'Ayu Putri', 'Perempuan', 'Ketua Bendahara', 'Sudah terlaksana menarik uang kas bulanan anggota'),
(3, 'K3', 'Ayu Putri', 'Perempuan', 'Ketua Bendahara', 'Sudah terlaksana menarik uang kas bulanan anggota'),
(4, 'K4', 'Ayu Putri', 'Perempuan', 'Ketua Bendahara', 'Sudah terlaksana menarik uang kas bulanan anggota'),
(5, 'K5', 'Berlian Dwiana Putri', 'Perempuan', 'Wakil Ketua Bendahara', 'Sudah terlaksana menarik uang kas bulanan anggota');

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

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_statusanggota`
--

CREATE TABLE `t_statusanggota` (
  `statusanggota_kode` char(3) NOT NULL COMMENT 'kode status anggota yang digunakan',
  `status_anggota` enum('Pelajar','Pekerja') NOT NULL COMMENT 'pilihan untuk status anggota',
  `rt_rw` enum('01/08','01/07','02/07','03/07') NOT NULL COMMENT 'pilihan untuk RT dan RW yang dipilih'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `t_statusanggota`
--

INSERT INTO `t_statusanggota` (`statusanggota_kode`, `status_anggota`, `rt_rw`) VALUES
('K17', 'Pekerja', '01/07'),
('K18', 'Pekerja', '01/08'),
('K27', 'Pekerja', '02/07'),
('K37', 'Pekerja', '03/07'),
('S17', 'Pelajar', '01/07'),
('S18', 'Pelajar', '01/08'),
('S27', 'Pelajar', '02/07'),
('S37', 'Pelajar', '03/07');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_total_kas`
--

CREATE TABLE `t_total_kas` (
  `total_kas_kode` char(3) NOT NULL COMMENT 'kode kas bulanan yang digunakan',
  `kas_bulanan_kode` char(3) NOT NULL COMMENT 'kode kas bulanan yang digunakan',
  `tanggal_laporan` date NOT NULL COMMENT 'tanggal laporan kas',
  `jumlah_uang_masuk` int(11) NOT NULL COMMENT 'jumlah uang masuk',
  `jumlah_pengeluaran_kas` int(10) NOT NULL COMMENT 'jumlah uang kas',
  `jumlah_uang_kas` int(10) NOT NULL COMMENT 'jumlah uang kas'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `t_total_kas`
--

INSERT INTO `t_total_kas` (`total_kas_kode`, `kas_bulanan_kode`, `tanggal_laporan`, `jumlah_uang_masuk`, `jumlah_pengeluaran_kas`, `jumlah_uang_kas`) VALUES
('TK1', 'K1', '2022-01-04', 10000, 0, 10000),
('TK2', 'K2', '2022-01-04', 0, 0, 10000),
('TK3', 'K3', '2022-01-04', 5000, 0, 15000),
('TK4', 'K4', '2022-02-09', 10000, 0, 25000),
('TK5', 'K5', '2022-02-09', 10000, 5000, 30000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `t_anggota`
--
ALTER TABLE `t_anggota`
  ADD PRIMARY KEY (`anggota_kode`),
  ADD KEY `t_anggota` (`statusanggota_kode`);

--
-- Indeks untuk tabel `t_anggota_bendahara`
--
ALTER TABLE `t_anggota_bendahara`
  ADD PRIMARY KEY (`nourut`),
  ADD KEY `t_anggota_bendahara` (`kas_bulanan_kode`);

--
-- Indeks untuk tabel `t_kas_bulanan`
--
ALTER TABLE `t_kas_bulanan`
  ADD PRIMARY KEY (`kas_bulanan_kode`),
  ADD KEY `t_kas_bulanan` (`anggota_kode`);

--
-- Indeks untuk tabel `t_statusanggota`
--
ALTER TABLE `t_statusanggota`
  ADD PRIMARY KEY (`statusanggota_kode`);

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
-- Ketidakleluasaan untuk tabel `t_anggota`
--
ALTER TABLE `t_anggota`
  ADD CONSTRAINT `t_anggota` FOREIGN KEY (`statusanggota_kode`) REFERENCES `t_statusanggota` (`statusanggota_kode`);

--
-- Ketidakleluasaan untuk tabel `t_anggota_bendahara`
--
ALTER TABLE `t_anggota_bendahara`
  ADD CONSTRAINT `t_anggota_bendahara` FOREIGN KEY (`kas_bulanan_kode`) REFERENCES `t_kas_bulanan` (`kas_bulanan_kode`);

--
-- Ketidakleluasaan untuk tabel `t_kas_bulanan`
--
ALTER TABLE `t_kas_bulanan`
  ADD CONSTRAINT `t_kas_bulanan` FOREIGN KEY (`anggota_kode`) REFERENCES `t_anggota` (`anggota_kode`);

--
-- Ketidakleluasaan untuk tabel `t_total_kas`
--
ALTER TABLE `t_total_kas`
  ADD CONSTRAINT `t_total_kas` FOREIGN KEY (`kas_bulanan_kode`) REFERENCES `t_kas_bulanan` (`kas_bulanan_kode`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
