-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 20, 2018 at 05:42 AM
-- Server version: 10.1.33-MariaDB
-- PHP Version: 7.2.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payrollsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `deductions`
--

CREATE TABLE `deductions` (
  `ID` varchar(20) DEFAULT NULL,
  `Gsis` double DEFAULT NULL,
  `Loan` double DEFAULT NULL,
  `Tax` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `deductions`
--

INSERT INTO `deductions` (`ID`, `Gsis`, `Loan`, `Tax`) VALUES
('1', 50, 50, 1140),
('3', 40, 40, 1594),
('4', 80, 50, 1814),
('5', 50, 50, 1140),
('6', 60, 60, 1368);

-- --------------------------------------------------------

--
-- Table structure for table `earnings`
--

CREATE TABLE `earnings` (
  `ID` varchar(20) DEFAULT NULL,
  `Monthly` double DEFAULT NULL,
  `Increase` double DEFAULT NULL,
  `Allowance` double DEFAULT NULL,
  `Differential` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `earnings`
--

INSERT INTO `earnings` (`ID`, `Monthly`, `Increase`, `Allowance`, `Differential`) VALUES
('1', 5000, 600, 50, 50),
('3', 7000, 840, 70, 60),
('4', 8000, 960, 60, 50),
('5', 5000, 600, 50, 50),
('6', 6000, 720, 60, 60);

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `ID` varchar(20) DEFAULT NULL,
  `Name` varchar(30) DEFAULT NULL,
  `Position` varchar(30) DEFAULT NULL,
  `Department` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`ID`, `Name`, `Position`, `Department`) VALUES
('1', 'Mina', 'Professor', 'Biology'),
('3', 'Liezheel', 'Instructor II', 'Computer Science'),
('4', 'Mynhaa', 'Professor', 'Computer Science'),
('5', 'Kevin', 'Professor', 'Computer Science'),
('6', 'Minaaa', 'Professor', 'Computer Science');

-- --------------------------------------------------------

--
-- Table structure for table `salary`
--

CREATE TABLE `salary` (
  `ID` varchar(20) DEFAULT NULL,
  `Earnings` double DEFAULT NULL,
  `Deductions` double DEFAULT NULL,
  `NetPay` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `salary`
--

INSERT INTO `salary` (`ID`, `Earnings`, `Deductions`, `NetPay`) VALUES
('1', 5700, 1240, 4460),
('3', 7970, 1674, 6296),
('4', 9070, 1944, 7126),
('5', 5700, 1240, 4460),
('6', 6840, 1488, 5352);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
