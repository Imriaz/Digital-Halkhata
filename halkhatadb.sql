-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 17, 2021 at 08:33 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `halkhatadb`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `Admin_ID` int(10) NOT NULL,
  `Admin_First_Name` varchar(20) DEFAULT NULL,
  `Admin_Last_Name` varchar(20) DEFAULT NULL,
  `Admin_Email` varchar(50) DEFAULT NULL,
  `Admin_Password` varchar(20) DEFAULT NULL,
  `Admin_Phone_Number` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`Admin_ID`, `Admin_First_Name`, `Admin_Last_Name`, `Admin_Email`, `Admin_Password`, `Admin_Phone_Number`) VALUES
(181921, 'Md. Imriaz', 'Uddin', 'imriaz.cse.bubt@gmail.com', 'imriaz', '01521227844'),
(181922, 'Shoibal', 'Das', 'shoibalshantu@gmail.com', 'Shoibal', '01401298280');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `Halkhata_ID` int(10) NOT NULL,
  `First_Name` varchar(20) DEFAULT NULL,
  `Last_Name` varchar(20) DEFAULT NULL,
  `Email` varchar(20) DEFAULT NULL,
  `Address` varchar(100) DEFAULT NULL,
  `Phone_Number` varchar(20) DEFAULT NULL,
  `Gender` varchar(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`Halkhata_ID`, `First_Name`, `Last_Name`, `Email`, `Address`, `Phone_Number`, `Gender`) VALUES
(201901, 'Amirul', 'Islam', 'amirulislamtajbid@gm', 'Chittagong', '01521527354', 'Male'),
(201902, 'Walid', 'Hossain', 'walid.nafis@gmail.co', 'Chittagong', '01516708155', 'Male');

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `Transaction_ID` int(20) NOT NULL,
  `Customer_Name` varchar(20) DEFAULT NULL,
  `Customer_Phone_Number` varchar(20) DEFAULT NULL,
  `Purchase_Amount` int(15) DEFAULT NULL,
  `Payment` int(15) DEFAULT NULL,
  `Date_Time` datetime(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`Transaction_ID`, `Customer_Name`, `Customer_Phone_Number`, `Purchase_Amount`, `Payment`, `Date_Time`) VALUES
(6538427, 'Amirul Islam', '01521527354', 10000, 5000, '2021-03-17 03:31:00.000000'),
(6538428, 'Walid Hossain', '01516708155', 1000, 500, '2021-03-17 03:32:00.000000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`Admin_ID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`Halkhata_ID`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`Transaction_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `Admin_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=181923;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `Halkhata_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=201903;

--
-- AUTO_INCREMENT for table `transaction`
--
ALTER TABLE `transaction`
  MODIFY `Transaction_ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6538429;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
