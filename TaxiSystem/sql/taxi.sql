/*
Navicat MySQL Data Transfer

Source Server         : 111
Source Server Version : 50525
Source Host           : localhost:3306
Source Database       : taxi

Target Server Type    : MYSQL
Target Server Version : 50525
File Encoding         : 65001

Date: 2016-04-15 14:47:44
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for cars
-- ----------------------------
DROP TABLE IF EXISTS `cars`;
CREATE TABLE `cars` (
  `Id` int(11) NOT NULL,
  `model` varchar(30) DEFAULT NULL,
  `number` varchar(15) DEFAULT NULL,
  `color` tinyint(4) NOT NULL,
  `type` tinyint(4) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of cars
-- ----------------------------

-- ----------------------------
-- Table structure for drivers
-- ----------------------------
DROP TABLE IF EXISTS `drivers`;
CREATE TABLE `drivers` (
  `Id` int(11) NOT NULL,
  `carId` int(6) NOT NULL,
  `status` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of drivers
-- ----------------------------

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders` (
  `Id` int(10) NOT NULL AUTO_INCREMENT,
  `type` tinyint(4) NOT NULL,
  `status` tinyint(4) NOT NULL,
  `date` int(11) NOT NULL,
  `s_address` varchar(100) NOT NULL,
  `e_address` varchar(100) NOT NULL,
  `driverId` int(11) NOT NULL,
  `ownerId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `orderStatusUnique` (`status`,`ownerId`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of orders
-- ----------------------------
INSERT INTO `orders` VALUES ('3', '0', '0', '101', 'Гродно, Ленина, 18, Гродно, Ленина', 'Гродно, Советская, 5, Гродно, Советская', '0', '1');
INSERT INTO `orders` VALUES ('6', '1', '1', '1460181498', 'Гродно, Гагарина, 18, Гродно, Гагарина', 'Гродно, Ленина, 18, Гродно, Ленина', '0', '1');

-- ----------------------------
-- Table structure for ratings
-- ----------------------------
DROP TABLE IF EXISTS `ratings`;
CREATE TABLE `ratings` (
  `Id` int(11) NOT NULL,
  `driverId` int(10) NOT NULL,
  `rating` float NOT NULL,
  `date` int(11) NOT NULL,
  `comment` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ratings
-- ----------------------------

-- ----------------------------
-- Table structure for save_address
-- ----------------------------
DROP TABLE IF EXISTS `save_address`;
CREATE TABLE `save_address` (
  `ownerId` int(11) NOT NULL,
  `address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of save_address
-- ----------------------------
INSERT INTO `save_address` VALUES ('1', 'Гродно;Мира;2');
INSERT INTO `save_address` VALUES ('1', 'Гродно;Ленина;18');
INSERT INTO `save_address` VALUES ('1', 'Гродно;Гагарина;18');
INSERT INTO `save_address` VALUES ('1', 'Гродно;Советская;5');

-- ----------------------------
-- Table structure for taxi_type
-- ----------------------------
DROP TABLE IF EXISTS `taxi_type`;
CREATE TABLE `taxi_type` (
  `Id` smallint(5) unsigned NOT NULL DEFAULT '0',
  `name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of taxi_type
-- ----------------------------
INSERT INTO `taxi_type` VALUES ('1', 'Легковое');
INSERT INTO `taxi_type` VALUES ('2', 'Грузовое');

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `type` tinyint(4) NOT NULL DEFAULT '1',
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES ('1', '1', 'Orion', '45495879b92be04cd4d936d2ee91b7a1');
INSERT INTO `users` VALUES ('3', '1', 'Orion11', 'be0095c082ce1f513b7a69bc3c194fe4');
INSERT INTO `users` VALUES ('4', '1', 'Orion2', '049caf106196146ccca124129711ec3b');
