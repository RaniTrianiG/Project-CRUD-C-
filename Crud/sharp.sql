-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Sep 14, 2017 at 05:09 AM
-- Server version: 5.6.26
-- PHP Version: 5.6.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sharp`
--

-- --------------------------------------------------------

--
-- Table structure for table `data`
--

CREATE TABLE IF NOT EXISTS `data` (
  `id` bigint(20) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `no_telp` varchar(10) NOT NULL,
  `no_hp` varchar(16) NOT NULL,
  `email` varchar(50) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `tgl_lahir` date NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data`
--

INSERT INTO `data` (`id`, `nama`, `no_telp`, `no_hp`, `email`, `alamat`, `tgl_lahir`) VALUES
(1, 'RaniTG', '0895320765', '0895320765708', 'jln.sampora', 'jln.sampora', '2017-09-13'),
(2, 'roy', '0998', '0832986274', 'ra@gmail.com', 'jln.saman', '2010-08-07'),
(3, 'reza', '0874', '0834276423', 'tasa@gmail.com', 'jln.sasmaps', '2000-09-05'),
(4, 'ryando', '0937', '098338', 'jlasj@gmail.com', 'jln.afadd', '2001-09-09'),
(5, 'raniad', '0849', '0273', 'ryando@gmail.com', 'jln.samsaals', '2002-09-03'),
(6, 'triani', '092367', '089834245', 'trai@gmail.com', 'jln.samsa', '2009-09-04'),
(7, 'gustia', '0983', '0989346713', 'triani@gmail.com', 'jln.mutiara', '1999-09-11'),
(8, 'roni', '012471', '0892346724', 'roni@gmail.com', 'jln.kasih sayang :v', '2000-09-05'),
(9, 'habeahan', '236', '0893462346', 'habeahan@gmail.com', 'jln.habeahan', '1998-09-04'),
(10, 'tinar mila anartza', '26843', '089532176570', 'tinarmilaanartza@gmail.com', 'jln.sukamenak Gg.sukamanah II Rt.01/16', '2022-05-23'),
(11, 'ASD', '1099', '1230980', 'wqelj@lkjsad', 'asldkjlj;', '2000-02-20'),
(12, 'roy ryando', '0638', '0895320765708', 'triani@gmail.com', 'jln.sukamenak', '2000-05-05'),
(13, 'Roy', '022 4898', '0829321', 'asjdlkjlas@lksad.as', 'lkasjdl alj Slk d', '2010-03-09'),
(14, 'rani', 'sayang', 'i love u', 'roy ryando', 'roni habeahan', '2017-09-11'),
(15, 'rani', 'sayang', 'roy', 'ryando', 'roni', '2017-09-12'),
(16, '^^', 'i', '<3', 'you', 'roy', '2017-09-12'),
(17, 'kl', 'lkk', 'lkl', 'k', 'lk', '2017-09-12'),
(18, 'dat1', 'dat2', 'dat3', 'dat4', 'dat5', '2017-04-04'),
(19, 'dat1', 'dat2', 'dat3', 'dat4', 'dat5', '2017-09-12'),
(20, 'jkh', 'kjh', 'kjh', 'kj', 'hlk', '2017-09-12'),
(21, 'RoYrYa', 'ajjkk', 'kjk', 'jkjk', 'kj', '2017-09-12'),
(22, 'Rani', 'inar', 'aksdal', 'lkjlk', 'jlk', '2017-09-12');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `uname` varchar(50) NOT NULL,
  `pwd` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`uname`, `pwd`) VALUES
('admin', '58acb7acccce58ffa8b953b12b5a7702bd42dae441c1ad85057fa70b');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data`
--
ALTER TABLE `data`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`uname`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `data`
--
ALTER TABLE `data`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=23;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
