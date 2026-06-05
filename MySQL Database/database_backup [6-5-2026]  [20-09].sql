-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 05, 2026 at 04:39 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `traveldb`
--

-- --------------------------------------------------------

--
-- Table structure for table `district`
--

CREATE TABLE `district` (
  `ID` int(11) NOT NULL,
  `Title` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `district`
--

INSERT INTO `district` (`ID`, `Title`) VALUES
(1, 'Colombo'),
(5, 'Galle'),
(2, 'Gampaha'),
(3, 'Kalutara'),
(4, 'Kandy');

-- --------------------------------------------------------

--
-- Table structure for table `hotel_owner`
--

CREATE TABLE `hotel_owner` (
  `HotelOwnerID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  `Email` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hotel_owner`
--

INSERT INTO `hotel_owner` (`HotelOwnerID`, `Name`, `Phone`, `Email`, `Password`) VALUES
(99, 'UstedComoSabeMiNombre', '071339938213213', 'UstedComoSabeMiNombre@gmail.com', '123456789'),
(101, 'Hi', '07135566', 'hi@gmail.com', '123'),
(103, 'Rishan Rajapaksha', '0', 'pubuth@gmail.com', '111773437422464278766'),
(104, 'Coma', '078456789', 'coma@gmail.com', '123');

-- --------------------------------------------------------

--
-- Table structure for table `property`
--

CREATE TABLE `property` (
  `ID` int(11) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `LongDescription` text DEFAULT NULL,
  `PropertyCategory` varchar(100) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `DistrictID` int(11) DEFAULT NULL,
  `PictureURL` varchar(500) DEFAULT NULL,
  `price_per_one_person` decimal(10,2) DEFAULT NULL,
  `additional_guest_prices` decimal(10,2) DEFAULT NULL,
  `HotelOwnerID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `property`
--

INSERT INTO `property` (`ID`, `Title`, `LongDescription`, `PropertyCategory`, `Address`, `DistrictID`, `PictureURL`, `price_per_one_person`, `additional_guest_prices`, `HotelOwnerID`) VALUES
(1, 'Sea View Hotel', 'Beautiful hotel near the beach', 'Hotel', 'Mount Lavinia', 1, NULL, 1000.00, 1000.00, NULL),
(2, 'Hill Top Villa', 'Luxury villa with mountain view', 'Villa', 'Kandy City', 4, NULL, 2000.00, 500.00, NULL),
(3, 'City Apartment', 'Modern apartment in city center', 'Apartment', 'Colombo 03', 1, NULL, 8000.00, 1500.00, NULL),
(4, 'Green Garden Resort', 'Nature surrounded resort', 'Resort', 'Kalutara Beach Road', 3, NULL, 10000.00, 800.00, NULL),
(5, 'Royal Stay Hotel', 'Comfortable stay with all facilities', 'Hotel', 'Galle Fort', 5, NULL, 50000.00, 5000.00, NULL),
(6, 'Hotel', 'HotelHotelHotelHotelHotelHotel', 'Apartment', 'Hi Kohomada?', 1, '0', 100.00, 100.00, NULL),
(7, 'Hotel', 'HotelHotelHotelHotelHotelHotel', 'Apartment', '1', NULL, '0', 100.00, 100.00, NULL),
(8, 'This is test hotel', 'This is test hotel This is test hotel This is test hotel', 'Guest House', '1', NULL, '0', 200.00, 200000.00, NULL),
(9, 'TEts', 'TEts', 'Guest House', '1', NULL, '0', 0.00, 0.00, NULL),
(10, 'TEts', 'TEts', 'Guest House', '1', NULL, '0', 0.00, 0.00, NULL),
(11, 'TEts', 'TEts', 'Guest House', '1', NULL, '0', 0.00, 0.00, NULL),
(12, 'PictureURL', 'PictureURLPictureURL', 'Guest House', '1', NULL, 'PictureURLPictureURLPictureURLPictureURL', 1000.00, 1000.00, NULL),
(13, 'Hi', 'HiHiHiHiHiHiHiHiHiHiHi', 'Luxury', 'HiHiHiHiHiHiHiHi', 1, 'HiHiHiHiHiHiHi', 100.00, 100.00, NULL),
(14, 'Galadari', 'Galadari is the best hotel in colombo', 'Resort', '8/3, Maradana Para, Colombo 10', 1, 'ColomboColomboColomboColombo', 1000.00, 100.00, NULL),
(15, 'Water Villa', 'Hey', 'Resort', '\"D:\\Previous Document Folder\\AI Based C# Project\\Test Photo.jpg\"', 1, 'htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://htps://', 500.00, 500.00, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `district`
--
ALTER TABLE `district`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Title` (`Title`);

--
-- Indexes for table `hotel_owner`
--
ALTER TABLE `hotel_owner`
  ADD PRIMARY KEY (`HotelOwnerID`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `property`
--
ALTER TABLE `property`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_property_owner` (`HotelOwnerID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `district`
--
ALTER TABLE `district`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `hotel_owner`
--
ALTER TABLE `hotel_owner`
  MODIFY `HotelOwnerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=105;

--
-- AUTO_INCREMENT for table `property`
--
ALTER TABLE `property`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `property`
--
ALTER TABLE `property`
  ADD CONSTRAINT `fk_property_owner` FOREIGN KEY (`HotelOwnerID`) REFERENCES `hotel_owner` (`HotelOwnerID`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
