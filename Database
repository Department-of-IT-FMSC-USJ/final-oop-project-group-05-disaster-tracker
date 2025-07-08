-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jul 08, 2025 at 02:12 AM
-- Server version: 8.3.0
-- PHP Version: 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `disaster_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `aid_requests`
--

CREATE DATABASE disaster_management;
USE disaster_management;


DROP TABLE IF EXISTS `aid_requests`;
CREATE TABLE IF NOT EXISTS `aid_requests` (
  `aid_id` int NOT NULL AUTO_INCREMENT,
  `date_time` datetime NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `contact_no` varchar(20) NOT NULL,
  `district` varchar(100) NOT NULL,
  `gn_division` varchar(100) NOT NULL,
  `type_support` varchar(100) NOT NULL,
  `family_size` int NOT NULL,
  `description` text NOT NULL,
  `gn_approve` enum('Pending','Approved','Rejected') NOT NULL DEFAULT 'Pending',
  `dmc_approve` enum('Pending','Approved','Rejected') NOT NULL DEFAULT 'Pending',
  `assign_gn` int DEFAULT NULL,
  PRIMARY KEY (`aid_id`),
  KEY `assign_gn` (`assign_gn`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `alerts`
--

DROP TABLE IF EXISTS `alerts`;
CREATE TABLE IF NOT EXISTS `alerts` (
  `alert_id` int NOT NULL AUTO_INCREMENT,
  `alert_type` varchar(50) NOT NULL,
  `district` varchar(100) NOT NULL,
  `gn_division` varchar(100) NOT NULL,
  `severity` enum('Low','Medium','High') NOT NULL,
  `date_time` datetime NOT NULL,
  `status` enum('Ongoing','Resolved') NOT NULL DEFAULT 'Ongoing',
  PRIMARY KEY (`alert_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `contributions`
--

DROP TABLE IF EXISTS `contributions`;
CREATE TABLE IF NOT EXISTS `contributions` (
  `contribution_id` int NOT NULL AUTO_INCREMENT,
  `volunteer_id` int NOT NULL,
  `district` varchar(100) NOT NULL,
  `type_support` varchar(100) NOT NULL,
  `description` text NOT NULL,
  `created_at` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`contribution_id`),
  KEY `volunteer_id` (`volunteer_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `dmc_officers`
--

DROP TABLE IF EXISTS `dmc_officers`;
CREATE TABLE IF NOT EXISTS `dmc_officers` (
  `dmc_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `name` varchar(100) NOT NULL,
  `contact_no` varchar(20) NOT NULL,
  `district` varchar(100) NOT NULL,
  PRIMARY KEY (`dmc_id`),
  KEY `user_id` (`user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `dmc_officers`
--

INSERT INTO `dmc_officers` (`dmc_id`, `user_id`, `name`, `contact_no`, `district`) VALUES
(1, 51, 'Lahiru Perera', '0712345678', 'Colombo'),
(2, 52, 'Nuwani Fernando', '0723456789', 'Gampaha'),
(3, 53, 'Kavindu Jayasinghe', '0709876543', 'Kalutara'),
(4, 54, 'Tharushi Senanayake', '0771234567', 'Kandy'),
(5, 55, 'Dilan Weerakoon', '0767654321', 'Matale'),
(6, 56, 'Sanduni Rathnayake', '0711223344', 'Nuwara Eliya'),
(7, 57, 'Chamara Silva', '0722334455', 'Galle'),
(8, 58, 'Priyanka Bandara', '0733445566', 'Matara'),
(9, 59, 'Isuru Rajapaksa', '0744556677', 'Hambantota'),
(10, 60, 'Anjali Karunaratne', '0755667788', 'Jaffna'),
(11, 61, 'Sampath Vidanage', '0766778899', 'Kilinochchi'),
(12, 62, 'Nadeesha Gamage', '0777889900', 'Mannar'),
(13, 63, 'Roshan Fernando', '0788990011', 'Vavuniya'),
(14, 64, 'Dilani Alwis', '0799001122', 'Mullaitivu'),
(15, 65, 'Thilina Peris', '0710011223', 'Batticaloa'),
(16, 66, 'Shanika Rathnayake', '0721122334', 'Ampara'),
(17, 67, 'Asanka Kumara', '0732233445', 'Trincomalee'),
(18, 68, 'Chathurika Peiris', '0743344556', 'Kurunegala'),
(19, 69, 'Nuwan Thilakarathne', '0754455667', 'Puttalam'),
(20, 70, 'Hiruni Silva', '0765566778', 'Anuradhapura'),
(21, 71, 'Sajeewa Bandara', '0776677889', 'Polonnaruwa'),
(22, 72, 'Chamari Athapaththu', '0787788990', 'Badulla'),
(23, 73, 'Lasith Malinga', '0798899001', 'Monaragala'),
(24, 74, 'Dinesh Chandimal', '0709900112', 'Ratnapura'),
(25, 75, 'Kushal Perera', '0710011223', 'Kegalle');

-- --------------------------------------------------------

--
-- Table structure for table `gn_officers`
--

DROP TABLE IF EXISTS `gn_officers`;
CREATE TABLE IF NOT EXISTS `gn_officers` (
  `gn_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `name` varchar(100) NOT NULL,
  `contact_no` varchar(20) NOT NULL,
  `district` varchar(100) NOT NULL,
  `gn_division` varchar(100) NOT NULL,
  PRIMARY KEY (`gn_id`),
  KEY `user_id` (`user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `gn_officers`
--

INSERT INTO `gn_officers` (`gn_id`, `user_id`, `name`, `contact_no`, `district`, `gn_division`) VALUES
(1, 1, 'Kamal Perera', '0759603020', 'Colombo', 'Nugegoda'),
(2, 2, 'Nadeesha Fernando', '0712955515', 'Colombo', 'Malabe West'),
(3, 3, 'Saman Kumara', '0762678746', 'Gampaha', 'Ragama'),
(4, 4, 'Anura Jayasinghe', '0742845513', 'Gampaha', 'Kelaniya'),
(5, 5, 'Iresha Madushani', '0721250742', 'Kalutara', 'Panadura North'),
(6, 6, 'Ruwan Wijesinghe', '0755225937', 'Kalutara', 'Beruwala Town'),
(7, 7, 'Sanduni Rajapaksha', '0738972447', 'Kandy', 'Bogambara'),
(8, 8, 'Thilina Abeywickrama', '0769059595', 'Kandy', 'Peradeniya'),
(9, 9, 'Chamari Senanayake', '0704235635', 'Matale', 'Madawala'),
(10, 10, 'Dinesh Bandara', '0705941690', 'Matale', 'Rattota'),
(11, 11, 'Nimali Ratnayake', '0725637938', 'Nuwara Eliya', 'Kalukelle'),
(12, 12, 'Upul Rathnayake', '0715851767', 'Nuwara Eliya', 'Padiyapelella'),
(13, 13, 'Dilani Silva', '0729307290', 'Galle', 'Galle Fort'),
(14, 14, 'Mahesh Nimal', '0707240835', 'Galle', 'Hikkaduwa Town'),
(15, 15, 'Shehani Dilhani', '0744461577', 'Matara', 'Matara North'),
(16, 16, 'Roshan Perera', '0733129182', 'Matara', 'Weligama Town'),
(17, 17, 'Harsha Jayalath', '0738180726', 'Hambantota', 'Tangalle Town'),
(18, 18, 'Isuru Lakshan', '0704790784', 'Hambantota', 'Ambalantota'),
(19, 19, 'Bimali Karunaratne', '0756997749', 'Jaffna', 'Nallur'),
(20, 20, 'Kavindu Sampath', '0712823805', 'Jaffna', 'Point Pedro'),
(21, 21, 'Pubudu Perera', '0753768174', 'Kilinochchi', 'Karachchi'),
(22, 22, 'Nirosha Udayangani', '0753386065', 'Kilinochchi', 'Poonakary'),
(23, 23, 'Asanka Jayawardena', '0703298457', 'Mannar', 'Mannar Town'),
(24, 24, 'Lahiru Ranasinghe', '0747172671', 'Mannar', 'Pesalai'),
(25, 25, 'Madushani Kumuduni', '0751892994', 'Vavuniya', 'Vavuniya Town'),
(26, 26, 'Tharindu Gunasekara', '0746303429', 'Vavuniya', 'Nedunkeni'),
(27, 27, 'Lasanthi Wickramasinghe', '0736587393', 'Mullaitivu', 'Puthukudiyiruppu'),
(28, 28, 'Manjula Herath', '0703371411', 'Mullaitivu', 'Maritimepattu'),
(29, 29, 'Supun Jayarathna', '0757184697', 'Batticaloa', 'Kattankudy'),
(30, 30, 'Shanika Priyadarshani', '0723768148', 'Batticaloa', 'Eravur Town'),
(31, 31, 'Chandima Gunawardena', '0716702876', 'Ampara', 'Kalmunai'),
(32, 32, 'Surangi Nisansala', '0795483895', 'Ampara', 'Akkaraipattu'),
(33, 33, 'Ashen Maduranga', '0745311597', 'Trincomalee', 'Trincomalee Town'),
(34, 34, 'Yasas Abeykoon', '0705746539', 'Trincomalee', 'Kinniya'),
(35, 35, 'Chathurika Senarath', '0727990468', 'Kurunegala', 'Kurunegala Town'),
(36, 36, 'Nilantha Wickrama', '0752518997', 'Kurunegala', 'Kuliyapitiya'),
(37, 37, 'Indika Sampath', '0727110705', 'Puttalam', 'Puttalam Town'),
(38, 38, 'Hiruni Hettiarachchi', '0771344625', 'Puttalam', 'Chilaw Town'),
(39, 39, 'Navodhani Mendis', '0766917776', 'Anuradhapura', 'Anuradhapura Town'),
(40, 40, 'Janith Liyanage', '0788398374', 'Anuradhapura', 'Kekirawa'),
(41, 41, 'Naduni Silva', '0748881276', 'Polonnaruwa', 'Polonnaruwa Town'),
(42, 42, 'Manoj Perera', '0724414457', 'Polonnaruwa', 'Medirigiriya'),
(43, 43, 'Rashmi Karunarathne', '0718939969', 'Badulla', 'Badulla Town'),
(44, 44, 'Eranga Weerasinghe', '0719739109', 'Badulla', 'Bandarawela'),
(45, 45, 'Thushara Dissanayake', '0759028848', 'Monaragala', 'Monaragala Town'),
(46, 46, 'Dinusha Senanayaka', '0722724997', 'Monaragala', 'Wellawaya'),
(47, 47, 'Kelum Rathnayake', '0729845073', 'Ratnapura', 'Ratnapura Town'),
(48, 48, 'Thisari Jayasinghe', '0721376496', 'Ratnapura', 'Balangoda'),
(49, 49, 'Kasun Rukshan', '0732648738', 'Kegalle', 'Kegalle Town'),
(50, 50, 'Kavindi Ekanayake', '0787398219', 'Kegalle', 'Mawanella');

-- --------------------------------------------------------

--
-- Table structure for table `symptoms`
--

DROP TABLE IF EXISTS `symptoms`;
CREATE TABLE IF NOT EXISTS `symptoms` (
  `report_id` int NOT NULL AUTO_INCREMENT,
  `date_time` datetime NOT NULL,
  `reporter_name` varchar(100) NOT NULL,
  `contact_no` varchar(20) NOT NULL,
  `district` varchar(100) NOT NULL,
  `gn_division` varchar(100) NOT NULL,
  `description` text NOT NULL,
  `image` varchar(255) DEFAULT NULL,
  `action` text,
  PRIMARY KEY (`report_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `password` varchar(255) NOT NULL,
  `email` varchar(100) NOT NULL,
  `role` enum('GN','DMC','volunteer') NOT NULL,
  `status` enum('active','inactive') NOT NULL DEFAULT 'active',
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `email` (`email`)
) ENGINE=MyISAM AUTO_INCREMENT=76 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `password`, `email`, `role`, `status`) VALUES
(1, 'GN@7535', 'kamal.perera@dms.gov.lk', 'GN', 'active'),
(2, 'GN@4422', 'nadeesha.fernando@dms.gov.lk', 'GN', 'active'),
(3, 'GN@9503', 'saman.kumara@dms.gov.lk', 'GN', 'active'),
(4, 'GN@2733', 'anura.jayasinghe@dms.gov.lk', 'GN', 'active'),
(5, 'GN@7924', 'iresha.madushani@dms.gov.lk', 'GN', 'active'),
(6, 'GN@8207', 'ruwan.wijesinghe@dms.gov.lk', 'GN', 'active'),
(7, 'GN@6841', 'sanduni.rajapaksha@dms.gov.lk', 'GN', 'active'),
(8, 'GN@8756', 'thilina.abeywickrama@dms.gov.lk', 'GN', 'active'),
(9, 'GN@5125', 'chamari.senanayake@dms.gov.lk', 'GN', 'active'),
(10, 'GN@7429', 'dinesh.bandara@dms.gov.lk', 'GN', 'active'),
(11, 'GN@7408', 'nimali.ratnayake@dms.gov.lk', 'GN', 'active'),
(12, 'GN@3756', 'upul.rathnayake@dms.gov.lk', 'GN', 'active'),
(13, 'GN@1723', 'dilani.silva@dms.gov.lk', 'GN', 'active'),
(14, 'GN@6925', 'mahesh.nimal@dms.gov.lk', 'GN', 'active'),
(15, 'GN@7539', 'shehani.dilhani@dms.gov.lk', 'GN', 'active'),
(16, 'GN@7712', 'roshan.perera@dms.gov.lk', 'GN', 'active'),
(17, 'GN@3948', 'harsha.jayalath@dms.gov.lk', 'GN', 'active'),
(18, 'GN@3747', 'isuru.lakshan@dms.gov.lk', 'GN', 'active'),
(19, 'GN@9292', 'bimali.karunaratne@dms.gov.lk', 'GN', 'active'),
(20, 'GN@6144', 'kavindu.sampath@dms.gov.lk', 'GN', 'active'),
(21, 'GN@4400', 'pubudu.perera@dms.gov.lk', 'GN', 'active'),
(22, 'GN@3388', 'nirosha.udayangani@dms.gov.lk', 'GN', 'active'),
(23, 'GN@7449', 'asanka.jayawardena@dms.gov.lk', 'GN', 'active'),
(24, 'GN@3386', 'lahiru.ranasinghe@dms.gov.lk', 'GN', 'active'),
(25, 'GN@5066', 'madushani.kumuduni@dms.gov.lk', 'GN', 'active'),
(26, 'GN@5328', 'tharindu.gunasekara@dms.gov.lk', 'GN', 'active'),
(27, 'GN@9170', 'lasanthi.wickramasinghe@dms.gov.lk', 'GN', 'active'),
(28, 'GN@3472', 'manjula.herath@dms.gov.lk', 'GN', 'active'),
(29, 'GN@1449', 'supun.jayarathna@dms.gov.lk', 'GN', 'active'),
(30, 'GN@7765', 'shanika.priyadarshani@dms.gov.lk', 'GN', 'active'),
(31, 'GN@1282', 'chandima.gunawardena@dms.gov.lk', 'GN', 'active'),
(32, 'GN@6889', 'surangi.nisansala@dms.gov.lk', 'GN', 'active'),
(33, 'GN@1844', 'ashen.maduranga@dms.gov.lk', 'GN', 'active'),
(34, 'GN@7373', 'yasas.abeykoon@dms.gov.lk', 'GN', 'active'),
(35, 'GN@2726', 'chathurika.senarath@dms.gov.lk', 'GN', 'active'),
(36, 'GN@9290', 'nilantha.wickrama@dms.gov.lk', 'GN', 'active'),
(37, 'GN@5950', 'indika.sampath@dms.gov.lk', 'GN', 'active'),
(38, 'GN@2629', 'hiruni.hettiarachchi@dms.gov.lk', 'GN', 'active'),
(39, 'GN@1718', 'navodhani.mendis@dms.gov.lk', 'GN', 'active'),
(40, 'GN@1549', 'janith.liyanage@dms.gov.lk', 'GN', 'active'),
(41, 'GN@3990', 'naduni.silva@dms.gov.lk', 'GN', 'active'),
(42, 'GN@9919', 'manoj.perera@dms.gov.lk', 'GN', 'active'),
(43, 'GN@1969', 'rashmi.karunarathne@dms.gov.lk', 'GN', 'active'),
(44, 'GN@6382', 'eranga.weerasinghe@dms.gov.lk', 'GN', 'active'),
(45, 'GN@4399', 'thushara.dissanayake@dms.gov.lk', 'GN', 'active'),
(46, 'GN@6059', 'dinusha.senanayaka@dms.gov.lk', 'GN', 'active'),
(47, 'GN@4997', 'kelum.rathnayake@dms.gov.lk', 'GN', 'active'),
(48, 'GN@8943', 'thisari.jayasinghe@dms.gov.lk', 'GN', 'active'),
(49, 'GN@4760', 'kasun.rukshan@dms.gov.lk', 'GN', 'active'),
(50, 'GN@3108', 'kavindi.ekanayake@dms.gov.lk', 'GN', 'active'),
(54, 'DMC@5454', 'tharushi.senanayake@dmc.gov.lk', 'DMC', 'active'),
(53, 'DMC@5353', 'kavindu.jayasinghe@dmc.gov.lk', 'DMC', 'active'),
(52, 'DMC@5252', 'nuwani.fernando@dmc.gov.lk', 'DMC', 'active'),
(51, 'DMC@5151', 'lahiru.perera@dmc.gov.lk', 'DMC', 'active'),
(55, 'DMC@5555', 'dilan.weerakoon@dmc.gov.lk', 'DMC', 'active'),
(56, 'DMC@5656', 'sanduni.rathnayake@dmc.gov.lk', 'DMC', 'active'),
(57, 'DMC@5757', 'chamara.silva@dmc.gov.lk', 'DMC', 'active'),
(58, 'DMC@5858', 'priyanka.bandara@dmc.gov.lk', 'DMC', 'active'),
(59, 'DMC@5959', 'isuru.rajapaksa@dmc.gov.lk', 'DMC', 'active'),
(60, 'DMC@6060', 'anjali.karunaratne@dmc.gov.lk', 'DMC', 'active'),
(61, 'DMC@6161', 'sampath.vidanage@dmc.gov.lk', 'DMC', 'active'),
(62, 'DMC@6262', 'nadeesha.gamage@dmc.gov.lk', 'DMC', 'active'),
(63, 'DMC@6363', 'roshan.fernando@dmc.gov.lk', 'DMC', 'active'),
(64, 'DMC@6464', 'dilani.alwis@dmc.gov.lk', 'DMC', 'active'),
(65, 'DMC@6565', 'thilina.peris@dmc.gov.lk', 'DMC', 'active'),
(66, 'DMC@6666', 'shanika.rathnayake@dmc.gov.lk', 'DMC', 'active'),
(67, 'DMC@6767', 'asanka.kumara@dmc.gov.lk', 'DMC', 'active'),
(68, 'DMC@6868', 'chathurika.peiris@dmc.gov.lk', 'DMC', 'active'),
(69, 'DMC@6969', 'nuwan.thilakarathne@dmc.gov.lk', 'DMC', 'active'),
(70, 'DMC@7070', 'hiruni.silva@dmc.gov.lk', 'DMC', 'active'),
(71, 'DMC@7171', 'sajeewa.bandara@dmc.gov.lk', 'DMC', 'active'),
(72, 'DMC@7272', 'chamari.athapaththu@dmc.gov.lk', 'DMC', 'active'),
(73, 'DMC@7373', 'lasith.malinga@dmc.gov.lk', 'DMC', 'active'),
(74, 'DMC@7474', 'dinesh.chandimal@dmc.gov.lk', 'DMC', 'active'),
(75, 'DMC@7575', 'kushal.perera@dmc.gov.lk', 'DMC', 'active');

-- --------------------------------------------------------

--
-- Table structure for table `volunteer`
--

DROP TABLE IF EXISTS `volunteer`;
CREATE TABLE IF NOT EXISTS `volunteer` (
  `volunteer_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `name` varchar(100) NOT NULL,
  `district` varchar(100) NOT NULL,
  `gn_division` varchar(100) NOT NULL,
  `availability` enum('Available','Unavailable') NOT NULL,
  PRIMARY KEY (`volunteer_id`),
  KEY `user_id` (`user_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
