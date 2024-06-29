-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 15, 2023 at 02:39 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lubang_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `table_logged`
--

CREATE TABLE `table_logged` (
  `LOGID` int(11) NOT NULL,
  `QRCODE` varchar(250) NOT NULL,
  `LOGDATE` date NOT NULL,
  `TIMEIN` varchar(250) NOT NULL,
  `AM_STATUS` varchar(150) NOT NULL,
  `TIMEOUT` varchar(250) NOT NULL,
  `PM_STATUS` varchar(150) NOT NULL,
  `ATTENDACE_STATUS` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `table_logged`
--

INSERT INTO `table_logged` (`LOGID`, `QRCODE`, `LOGDATE`, `TIMEIN`, `AM_STATUS`, `TIMEOUT`, `PM_STATUS`, `ATTENDACE_STATUS`) VALUES
(35, '107015000000', '2022-03-24', '07:31 pm', 'Punch-In', '07:31 pm', 'Punch-Out', ''),
(37, '107014000000', '2022-10-12', '05:15 pm', 'Punch-In', '05:17 pm', 'Punch-Out', ''),
(38, '107015000000', '2022-03-30', '09:01 pm', 'Punch-In', '09:17 pm', 'Punch-Out', ''),
(40, '107012000000', '2022-05-08', '07:31 pm', 'Punch-In', '07:31 pm', 'Punch-Out', ''),
(41, '107013000000', '2022-05-08', '07:44 pm', 'Punch-In', '07:44 pm', 'Punch-Out', ''),
(42, '107011000000', '2022-05-31', '12:07 pm', 'Punch-In', '', '', ''),
(43, '107010000000', '2022-05-31', '12:07 pm', 'Punch-In', '', '', ''),
(51, '107005000000', '2022-08-19', '05:01 PM', 'Punch-In', '05:01 PM', 'Punch-Out', ''),
(52, '107003000000', '2022-08-19', '05:02 PM', 'Punch-In', '05:04 PM', 'Punch-Out', ''),
(53, '107008000000', '2022-08-19', '05:02 PM', 'Punch-In', '', '', ''),
(54, '107015000000', '2022-08-20', '04:26 AM', 'Punch-In', '04:26 AM', 'Punch-Out', ''),
(55, '107015000000', '2022-10-18', '11:14 AM', 'Punch-In', '11:15 AM', 'Punch-Out', ''),
(56, '107001000000', '2022-12-15', '09:31 AM', 'Punch-In', '09:35 AM', 'Punch-Out', ''),
(59, '6941399045934', '2022-12-15', '09:56 AM', 'Punch-In', '09:57 AM', 'Punch-Out', ''),
(62, '107002000000', '2023-01-14', '11:06 AM', 'Punch-In', '', '', ''),
(67, '6941399045934', '2023-01-14', '11:24 AM', 'Punch-In', '02:25 PM', 'Punch-Out', 'Present'),
(81, '107002000069', '2023-01-21', '11:22 PM', 'Punch-In', '', '', 'Late'),
(82, '107015000000', '2023-01-21', '11:23 PM', 'Punch-In', '', '', 'Present');

-- --------------------------------------------------------

--
-- Table structure for table `table_notify`
--

CREATE TABLE `table_notify` (
  `ID` int(11) NOT NULL,
  `SENDER_NAME` text NOT NULL,
  `AR_MESSAGE` text NOT NULL,
  `DEP_MESSAGE` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `table_notify`
--

INSERT INTO `table_notify` (`ID`, `SENDER_NAME`, `AR_MESSAGE`, `DEP_MESSAGE`) VALUES
(1, 'MPCES', 'Leave the school on', 'Enter the school on'),
(2, 'aa', 'aa', 'aa');

-- --------------------------------------------------------

--
-- Table structure for table `table_parent`
--

CREATE TABLE `table_parent` (
  `PID` int(11) NOT NULL,
  `PARENTID` varchar(250) NOT NULL,
  `QRCODE` varchar(250) NOT NULL,
  `FIRSTNAME` varchar(250) NOT NULL,
  `MI` varchar(50) NOT NULL,
  `LASTNAME` varchar(250) NOT NULL,
  `AGE` varchar(250) NOT NULL,
  `GENDER` varchar(50) NOT NULL,
  `ADDRESS` varchar(250) NOT NULL,
  `PHONENUM` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `table_parent`
--

INSERT INTO `table_parent` (`PID`, `PARENTID`, `QRCODE`, `FIRSTNAME`, `MI`, `LASTNAME`, `AGE`, `GENDER`, `ADDRESS`, `PHONENUM`) VALUES
(7, '01222700061550', 'SY03-1144', 'Tresa', 'P', 'Jario', '65', 'Female', 'Mabinay Negros Oriental', '09306247025');

-- --------------------------------------------------------

--
-- Table structure for table `table_sms`
--

CREATE TABLE `table_sms` (
  `SMSID` int(11) NOT NULL,
  `QRCODE` varchar(250) NOT NULL,
  `MESSAGETO` varchar(250) NOT NULL,
  `SENDFROM` varchar(250) NOT NULL,
  `MESSAGETEXT` text NOT NULL,
  `SENDTIME` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `table_sms`
--

INSERT INTO `table_sms` (`SMSID`, `QRCODE`, `MESSAGETO`, `SENDFROM`, `MESSAGETEXT`, `SENDTIME`) VALUES
(1, '4806513690563', '09306247025', 'Source Code Ph', 'Andres P Jario Enter the school on when September 07, 2021 - 07:33:47 pm. From:NORSU ', '07/09/2021 7:33:48 pm'),
(2, '4806513690563', '09306247025', 'Source Code Ph', 'Andres P Jario Leave the school on was September 07, 2021 - 07:39:50 pm. From: NORSU ', '07/09/2021 7:39:51 pm'),
(3, 'SY01-1122', '09306247025', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on September 10, 2021 - 06:25:39 pm. From: Source Code Ph', '10/09/2021 6:25:46 pm'),
(4, 'SY01-1122', '09306247025', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on January 27, 2022 - 11:32:45 pm. From: Source Code Ph', '27/01/2022 11:32:49 pm'),
(7, 'SY03-1144', '09306247025', 'Source Code Ph', 'John P Cena Enter the school on when March 15, 2022 - 10:17:28 pm. From:NORSU ', '15/03/2022 10:17:30 pm'),
(8, 'SY03-1144', '09306247025', 'Source Code Ph', 'John P Cena Leave the school on was March 15, 2022 - 10:19:48 pm. From: NORSU ', '15/03/2022 10:19:56 pm'),
(9, 'SY03-1144', '09306247025', 'Source Code Ph', 'John P Cena Enter the school on when March 15, 2022 - 10:20:27 pm. From:NORSU ', '15/03/2022 10:20:39 pm'),
(10, 'SY03-1144', '09306247025', 'Source Code Ph', 'John P Cena Leave the school on was March 15, 2022 - 10:20:45 pm. From: NORSU ', '15/03/2022 10:20:46 pm'),
(11, 'SY03-1144', '09306247025', 'Source Code Ph', 'John P Cena Enter the school on when March 15, 2022 - 10:22:30 pm. From:NORSU ', '15/03/2022 10:22:32 pm'),
(12, 'SY03-1144', '09306247025', 'Source Code Ph', 'John P Cena Leave the school on was March 15, 2022 - 10:24:44 pm. From: NORSU ', '15/03/2022 10:24:44 pm'),
(13, 'SY03-1144', '09306247025', 'Source Code Ph', 'John P Cena Enter the school on when March 15, 2022 - 10:38:14 pm. From:NORSU ', '15/03/2022 10:38:15 pm'),
(14, 'SY03-1144', '09306247025', 'Source Code Ph', 'John P Cena Enter the school on when March 17, 2022 - 10:14:04 pm. From:NORSU ', '17/03/2022 10:14:05 pm'),
(15, 'SY03-1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on was March 17, 2022 - 11:09:40 pm. From: STATESWEEP ', '17/03/2022 11:09:40 pm'),
(16, 'SY03-1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on March 18, 2022 - 12:35:52 am. From:STATESWEEP ', '18/03/2022 12:35:52 am'),
(17, 'SY03-1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on was March 18, 2022 - 12:36:32 am. From: STATESWEEP ', '18/03/2022 12:36:33 am'),
(18, 'SY03-1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on March 20, 2022 - 09:37:25 am. From:STATESWEEP ', '20/03/2022 9:37:25 am'),
(19, 'SY01-1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on March 21, 2022 - 07:16:02 am. From:MPCES ', '21/03/2022 7:16:21 am'),
(20, 'SY01-1122', '', 'Source Code Ph', 'Mark Ryan P Catian Leave the school on March 21, 2022 - 07:19:11 am. From: MPCES ', '21/03/2022 7:19:11 am'),
(21, 'SY01-1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on March 21, 2022 - 07:22:48 am. From:MPCES ', '21/03/2022 7:22:48 am'),
(22, 'SY01-1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on March 21, 2022 - 07:24:27 am. From:MPCES ', '21/03/2022 7:24:28 am'),
(23, 'SY01-1122', '', 'Source Code Ph', 'Mark Ryan P Catian Leave the school on March 21, 2022 - 07:24:32 am. From: MPCES ', '21/03/2022 7:24:32 am'),
(24, 'SY01-1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on March 21, 2022 - 07:24:50 am. From:MPCES ', '21/03/2022 7:24:50 am'),
(25, 'SY01-1122', '', 'Source Code Ph', 'Mark Ryan P Catian Leave the school on March 21, 2022 - 07:26:20 am. From: MPCES ', '21/03/2022 7:26:20 am'),
(26, 'SY01-1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on March 21, 2022 - 07:26:29 am. From:MPCES ', '21/03/2022 7:26:29 am'),
(27, 'SY01-1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on March 21, 2022 - 07:31:53 am. From:MPCES ', '21/03/2022 7:31:53 am'),
(28, 'SY01-1122', '', 'Source Code Ph', 'Mark Ryan P Catian Leave the school on March 21, 2022 - 07:32:03 am. From: MPCES ', '21/03/2022 7:32:03 am'),
(29, 'SY03-1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on March 21, 2022 - 07:32:26 am. From:MPCES ', '21/03/2022 7:32:26 am'),
(30, 'SY03-1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on March 21, 2022 - 07:33:01 am. From: MPCES ', '21/03/2022 7:33:01 am'),
(31, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on March 21, 2022 - 07:38:03 am. From:MPCES ', '21/03/2022 7:38:03 am'),
(32, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Leave the school on March 21, 2022 - 07:38:10 am. From: MPCES ', '21/03/2022 7:38:10 am'),
(33, 'SY02-1133', '', 'Source Code Ph', 'Alucard P Fighter Enter the school on March 21, 2022 - 07:38:32 am. From:MPCES ', '21/03/2022 7:38:32 am'),
(34, 'SY02-1133', '', 'Source Code Ph', 'Alucard P Fighter Leave the school on March 21, 2022 - 07:38:41 am. From: MPCES ', '21/03/2022 7:38:41 am'),
(35, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on March 21, 2022 - 07:41:35 am. From:MPCES ', '21/03/2022 7:41:35 am'),
(36, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on March 21, 2022 - 07:42:14 am. From:MPCES ', '21/03/2022 7:42:14 am'),
(37, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Leave the school on March 21, 2022 - 07:47:11 am. From: MPCES ', '21/03/2022 7:47:11 am'),
(38, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on March 21, 2022 - 07:47:23 am. From: MPCES ', '21/03/2022 7:47:23 am'),
(39, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on March 21, 2022 - 07:53:19 am. From:MPCES ', '21/03/2022 7:53:19 am'),
(40, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on March 21, 2022 - 07:53:28 am. From:MPCES ', '21/03/2022 7:53:28 am'),
(41, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Leave the school on March 21, 2022 - 07:53:40 am. From: MPCES ', '21/03/2022 7:53:40 am'),
(42, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on March 21, 2022 - 07:58:15 am. From: MPCES ', '21/03/2022 7:58:16 am'),
(43, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on March 21, 2022 - 07:58:46 am. From:MPCES ', '21/03/2022 7:58:46 am'),
(44, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on March 21, 2022 - 07:58:56 am. From:MPCES ', '21/03/2022 7:58:56 am'),
(45, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Leave the school on March 21, 2022 - 08:06:36 am. From: MPCES ', '21/03/2022 8:06:36 am'),
(46, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on March 24, 2022 - 07:31:03 pm. From:MPCES ', '24/03/2022 7:31:05 pm'),
(47, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Leave the school on March 24, 2022 - 07:31:09 pm. From: MPCES ', '24/03/2022 7:31:09 pm'),
(48, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on March 24, 2022 - 07:31:38 pm. From:MPCES ', '24/03/2022 7:31:38 pm'),
(49, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Leave the school on March 24, 2022 - 07:31:49 pm. From: MPCES ', '24/03/2022 7:31:49 pm'),
(50, '6985425442151', '', 'Source Code Ph', 'Andres P Jario Enter the school on March 29, 2022 - 05:05:26 pm. From:MPCES ', '29/03/2022 5:06:14 pm'),
(51, '6985425442151', '', 'Source Code Ph', 'Andres P Jario Leave the school on March 29, 2022 - 05:07:44 pm. From: MPCES ', '29/03/2022 5:07:44 pm'),
(52, '6985425442151', '', 'Source Code Ph', 'Andres P Jario Enter the school on March 29, 2022 - 05:15:54 pm. From:MPCES ', '29/03/2022 5:15:54 pm'),
(53, '6985425442151', '', 'Source Code Ph', 'Andres P Jario Leave the school on March 29, 2022 - 05:17:59 pm. From: MPCES ', '29/03/2022 5:17:59 pm'),
(54, 'SY02-1133', '', 'Source Code Ph', 'Alucard P Fighter Enter the school on May 08, 2022 - 07:26:30 pm. From:MPCES ', '08/05/2022 7:27:02 pm'),
(55, 'SY02-1133', '', 'Source Code Ph', 'Alucard P Fighter Leave the school on May 08, 2022 - 07:30:53 pm. From: MPCES ', '08/05/2022 7:30:53 pm'),
(56, 'SY02-1133', '', 'Source Code Ph', 'Alucard P Fighter Enter the school on May 08, 2022 - 07:31:48 pm. From:MPCES ', '08/05/2022 7:31:48 pm'),
(57, 'SY02-1133', '', 'Source Code Ph', 'Alucard P Fighter Leave the school on May 08, 2022 - 07:31:57 pm. From: MPCES ', '08/05/2022 7:31:57 pm'),
(58, 'SY01-1114', '', 'Source Code Ph', 'Antonio T Moreno Enter the school on May 08, 2022 - 07:44:28 pm. From:MPCES ', '08/05/2022 7:44:29 pm'),
(59, 'SY01-1114', '', 'Source Code Ph', 'Antonio T Moreno Leave the school on May 08, 2022 - 07:44:36 pm. From: MPCES ', '08/05/2022 7:44:36 pm'),
(60, 'SY01-1115', '', 'Source Code Ph', 'Ana Trujillo y Emparedados  Enter the school on May 31, 2022 - 12:07:22 pm. From:MPCES ', '31/05/2022 12:07:40 pm'),
(61, 'SY01-1115', '', 'Source Code Ph', 'Ana Trujillo y Emparedados  Enter the school on May 31, 2022 - 12:07:54 pm. From:MPCES ', '31/05/2022 12:08:11 pm'),
(62, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on June 01, 2022 - 11:21:00 pm. From:MPCES ', '01/06/2022 11:21:01 pm'),
(63, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on June 01, 2022 - 11:21:13 pm. From: MPCES ', '01/06/2022 11:21:13 pm'),
(64, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on August 19, 2022 - 04:27:26 PM. From:MPCES ', '8/19/2022 4:27:26 PM'),
(65, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on August 19, 2022 - 04:27:39 PM. From: MPCES ', '8/19/2022 4:27:39 PM'),
(66, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on August 19, 2022 - 04:47:41 PM. From:MPCES ', '8/19/2022 4:47:41 PM'),
(67, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on August 19, 2022 - 04:47:53 PM. From: MPCES ', '8/19/2022 4:47:53 PM'),
(68, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on August 19, 2022 - 04:48:22 PM. From:MPCES ', '8/19/2022 4:48:22 PM'),
(69, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on August 19, 2022 - 04:52:27 PM. From: MPCES ', '8/19/2022 4:52:27 PM'),
(70, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on August 19, 2022 - 04:53:01 PM. From:MPCES ', '8/19/2022 4:53:01 PM'),
(71, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on August 19, 2022 - 04:56:49 PM. From: MPCES ', '8/19/2022 4:56:49 PM'),
(72, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on August 19, 2022 - 04:58:13 PM. From:MPCES ', '8/19/2022 4:58:15 PM'),
(73, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Leave the school on August 19, 2022 - 04:58:21 PM. From: MPCES ', '8/19/2022 4:58:23 PM'),
(74, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on August 19, 2022 - 04:58:31 PM. From:MPCES ', '8/19/2022 4:58:31 PM'),
(75, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on August 19, 2022 - 04:58:39 PM. From: MPCES ', '8/19/2022 4:58:39 PM'),
(76, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on August 19, 2022 - 05:01:34 PM. From:MPCES ', '8/19/2022 5:01:34 PM'),
(77, '1144', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on August 19, 2022 - 05:01:40 PM. From: MPCES ', '8/19/2022 5:01:40 PM'),
(78, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Enter the school on August 19, 2022 - 05:02:00 PM. From:MPCES ', '8/19/2022 5:02:00 PM'),
(79, 'SY04-1155', '', 'Source Code Ph', 'Johnrey D Mamba Enter the school on August 19, 2022 - 05:02:17 PM. From:MPCES ', '8/19/2022 5:02:17 PM'),
(80, '1122', '', 'Source Code Ph', 'Mark Ryan P Catian Leave the school on August 19, 2022 - 05:04:43 PM. From: MPCES ', '8/19/2022 5:04:43 PM'),
(81, '4806517372038', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Enter the school on August 20, 2022 - 04:26:30 AM. From:MPCES ', '8/20/2022 4:26:30 AM'),
(82, '4806517372038', '09276182445', 'Source Code Ph', 'CRYSTAL  P CASUPANAN Leave the school on August 20, 2022 - 04:26:46 AM. From: MPCES ', '8/20/2022 4:26:46 AM');

-- --------------------------------------------------------

--
-- Table structure for table `table_student`
--

CREATE TABLE `table_student` (
  `ID` int(11) NOT NULL,
  `QRCODE` varchar(250) NOT NULL,
  `FIRSTNAME` varchar(250) NOT NULL,
  `MI` varchar(10) NOT NULL,
  `LASTNAME` varchar(250) NOT NULL,
  `AGE` varchar(250) NOT NULL,
  `GENDER` varchar(100) NOT NULL,
  `DOB` varchar(250) NOT NULL,
  `YEARLEVEL` varchar(50) NOT NULL,
  `SECTION` varchar(50) NOT NULL,
  `COURSE` varchar(250) NOT NULL,
  `IMAGE` varchar(250) NOT NULL,
  `CONTACT` varchar(20) NOT NULL,
  `PROFILE` varchar(250) NOT NULL,
  `ADDRESS` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `table_student`
--

INSERT INTO `table_student` (`ID`, `QRCODE`, `FIRSTNAME`, `MI`, `LASTNAME`, `AGE`, `GENDER`, `DOB`, `YEARLEVEL`, `SECTION`, `COURSE`, `IMAGE`, `CONTACT`, `PROFILE`, `ADDRESS`) VALUES
(37, '107002000069', 'AIZEL', 'ADIONG', 'BARING', '0', '', '1/13/2023', 'GRADE 4', 'APOLINARIO MABINI', 'none', '', '09306247025', 'slam_dunk.jpg', '3030 Sylvia'),
(38, '107002000000', 'HALARIE CHLOE', 'SALVILLA', 'BOADO', '8', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9105642146', 'none', ''),
(39, '107003000000', 'RUSSIANA', 'SANTIAGO', 'CABIGTING', '8', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9383328312', 'none', ''),
(40, '107004000000', 'SHELVYN', 'SALUNGA', 'CAPULONG', '9', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9750690412', 'none', ''),
(41, '107005000000', 'SOFIA COLEEN', 'BANAYAT', 'CORONEL', '8', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9610042881', 'none', ''),
(42, '107006000000', 'BRIGIET', 'LABORDO', 'DAYRIT', '9', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9657203186', 'none', ''),
(43, '107007000000', 'JOMAICA', '', 'MIANO', '9', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9091782362', 'none', ''),
(44, '107008000000', 'MARJAYLIN', 'LAGUNA', 'EGNEO', '10', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9630814901', 'none', ''),
(45, '107009000000', 'CARRIANE', 'FIGUEROA', 'GARCIA', '9', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9260925650', 'none', ''),
(46, '107010000000', 'ANGELMY', 'LACEBAL', 'JINGCO', '8', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9074174654', 'none', ''),
(47, '107011000000', 'PRINCESS JOY', 'CUNTAPAY', 'NAGUIT', '8', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9263482518', 'none', ''),
(48, '109320000000', 'PRINCESS XHYRIL', 'ADIONG', 'BARING', '10', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9268033114', 'none', ''),
(49, '106321000000', 'KATHLYN', 'YANGA', 'REYES', '8', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9217965461', 'none', ''),
(50, '107061000000', 'DIOSAMAE SIERYL', 'RIMARIM', 'TERIA', '8', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9101411241', 'none', ''),
(51, '107012000000', 'MARGARET SAAB', 'TOLENTINO', 'YAMBAO', '8', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9078915882', 'none', ''),
(52, '107013000000', 'MARICAR', 'BONDOC', 'MALONZO', '10', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9923656732', 'none', ''),
(53, '107014000000', 'PRINCESS SHANELL', 'TERANTE', 'NARCISO', '8', 'F', '', 'GRADE 4', 'APOLINARIO MABINI', '', '', '9488527623', 'none', ''),
(54, '107015000000', 'ANDRES', 'P', 'JARIO', '32', 'MALE', 'MAY 10 1990', 'V', 'A', '', 'JARIO, ANDRES P.png', '09306247025', '83403527_2708148609272343_2007264407578476544_n.jpg', 'DUMAGUETE'),
(55, '930627025', 'JOHN', 'C', 'CENA', '25', 'Male', '12/14/2022', 'none', 'NONE', '', '930627025.png', '0930627025', 'slam_dunk.jpg', 'NONE'),
(56, '9998888', 'TEST', 'T', 'TEST', '121', 'male', '12/14/2022', 'TEST', 'TEST', '', '9998888.png', '1212121', 'davis_anthony1280.jpg', 'TEST'),
(57, '88992', 'JASON', 'J', 'TATUM', '32', 'MALE', '6/7/1990', 'NONE', 'NONE', '', '88992.png', '', 'i (6).png', 'NONE'),
(58, '12121121', 'TESTING', 'R', 'TESTING', '121', 'FEMALE', '12/14/1901', 'a', 'a', '', '12121121.png', '099882', '1-8.png', 'a'),
(59, 'TEST', 'ANDRES', 'P', 'JARIO', '3', 'FEMALE', '7/6/2020', 'I', 'NONE', '', 'TEST.png', '12121', 'download (1).jpeg', 'DUMAGUETE'),
(60, '2025', 'TESTING', 'TESTING', 'TESTING', '33', 'FEMALE', '10/5/1990', 'TESTING', 'TESTING', '', 'TESTING, TESTING TESTING.png', 'TESTING', '1.jpg', 'TESTING');

-- --------------------------------------------------------

--
-- Table structure for table `table_user`
--

CREATE TABLE `table_user` (
  `USERID` int(11) NOT NULL,
  `FIRSTNAME` varchar(250) NOT NULL,
  `MI` varchar(20) NOT NULL,
  `LASTNAME` varchar(250) NOT NULL,
  `ROLE` varchar(150) NOT NULL,
  `USERNAME` varchar(250) NOT NULL,
  `PASSWORD` varchar(250) NOT NULL,
  `IMAGE` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `table_user`
--

INSERT INTO `table_user` (`USERID`, `FIRSTNAME`, `MI`, `LASTNAME`, `ROLE`, `USERNAME`, `PASSWORD`, `IMAGE`) VALUES
(1, 'Crischel', 'P', 'Amorio', 'Member', 'amorio201', '1994', ''),
(2, 'Andres', 'P', 'Jario', 'Administrator', 'admin', 'admin', 'user8-128x128.jpg'),
(15, 'Crischel', 'T', 'Amorio', 'Member', 'amorio', 'amorio', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `table_logged`
--
ALTER TABLE `table_logged`
  ADD PRIMARY KEY (`LOGID`);

--
-- Indexes for table `table_notify`
--
ALTER TABLE `table_notify`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `table_parent`
--
ALTER TABLE `table_parent`
  ADD PRIMARY KEY (`PID`);

--
-- Indexes for table `table_sms`
--
ALTER TABLE `table_sms`
  ADD PRIMARY KEY (`SMSID`);

--
-- Indexes for table `table_student`
--
ALTER TABLE `table_student`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `table_user`
--
ALTER TABLE `table_user`
  ADD PRIMARY KEY (`USERID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `table_logged`
--
ALTER TABLE `table_logged`
  MODIFY `LOGID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=83;

--
-- AUTO_INCREMENT for table `table_notify`
--
ALTER TABLE `table_notify`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `table_parent`
--
ALTER TABLE `table_parent`
  MODIFY `PID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `table_sms`
--
ALTER TABLE `table_sms`
  MODIFY `SMSID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=83;

--
-- AUTO_INCREMENT for table `table_student`
--
ALTER TABLE `table_student`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT for table `table_user`
--
ALTER TABLE `table_user`
  MODIFY `USERID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
