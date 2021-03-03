CREATE DATABASE  IF NOT EXISTS `db_clc` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_clc`;
-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: db_clc
-- ------------------------------------------------------
-- Server version	8.0.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aplicacion`
--

DROP TABLE IF EXISTS `aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aplicacion` (
  `pk_id_aplicacion` int NOT NULL AUTO_INCREMENT,
  `fk_id_modulo` int NOT NULL,
  `nombre_aplicacion` varchar(40) NOT NULL,
  `descripcion_aplicacion` varchar(45) NOT NULL,
  `estado_aplicacion` int NOT NULL,
  PRIMARY KEY (`pk_id_aplicacion`),
  KEY `pk_id_aplicacion` (`pk_id_aplicacion`),
  KEY `fk_aplicativo_modulo` (`fk_id_modulo`),
  CONSTRAINT `fk_aplicativo_modulo` FOREIGN KEY (`fk_id_modulo`) REFERENCES `modulo` (`pk_id_modulo`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacion`
--

LOCK TABLES `aplicacion` WRITE;
/*!40000 ALTER TABLE `aplicacion` DISABLE KEYS */;
INSERT INTO `aplicacion` VALUES (1,1,'Login','Ventana de Ingreso',1),(2,1,'Mantenimiento Usuario','Mantenimientos de usuario',1),(3,1,'Mantenimiento Aplicacion','ABC de las Aplicaciones',1),(4,1,'Mantenimiento Perfil','ABC de perfiles',1),(5,1,'Asignacion de Aplicaciones a Perfil','Asignacion Aplicacion y perfil',1),(6,1,'Asignacaion de Aplicaciones','Asignacion especificas a un usuario',1),(7,1,'Consulta Aplicacion','Mantenimiento de Aplicaciones',1),(8,1,'Agregar Modulo','Mantenimientos de Modulos',1),(9,1,'Consultar Perfil','Consultas de perfiles disponibles',1),(10,1,'Permisos','Asignar permisos a perfiles y aplicaciones',1),(11,1,'Bitacora','Guarda todos los movimientos',1);
/*!40000 ALTER TABLE `aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aplicacion_perfil`
--

DROP TABLE IF EXISTS `aplicacion_perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aplicacion_perfil` (
  `pk_id_aplicacion_perfil` int NOT NULL AUTO_INCREMENT,
  `fk_idaplicacion_aplicacion_perfil` int DEFAULT NULL,
  `fk_idperfil_aplicacion_perfil` int DEFAULT NULL,
  `fk_idpermiso_aplicacion_perfil` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_aplicacion_perfil`),
  KEY `fk_aplicacionperfil_aplicacion` (`fk_idaplicacion_aplicacion_perfil`),
  KEY `fk_aplicacionperfil_perfil` (`fk_idperfil_aplicacion_perfil`),
  KEY `fk_aplicacionperfil_permiso` (`fk_idpermiso_aplicacion_perfil`),
  CONSTRAINT `fk_aplicacionperfil_aplicacion` FOREIGN KEY (`fk_idaplicacion_aplicacion_perfil`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_aplicacionperfil_perfil` FOREIGN KEY (`fk_idperfil_aplicacion_perfil`) REFERENCES `perfil` (`pk_id_perfil`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_aplicacionperfil_permiso` FOREIGN KEY (`fk_idpermiso_aplicacion_perfil`) REFERENCES `permiso` (`pk_id_permiso`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacion_perfil`
--

LOCK TABLES `aplicacion_perfil` WRITE;
/*!40000 ALTER TABLE `aplicacion_perfil` DISABLE KEYS */;
INSERT INTO `aplicacion_perfil` VALUES (1,1,1,1),(2,4,1,2),(3,5,1,3),(4,2,1,4),(5,3,1,5),(6,6,1,6),(7,8,1,7),(8,2,3,8),(9,3,3,9),(10,4,3,11),(11,2,4,12),(12,8,4,13),(13,8,5,15);
/*!40000 ALTER TABLE `aplicacion_perfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aplicacion_usuario`
--

DROP TABLE IF EXISTS `aplicacion_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aplicacion_usuario` (
  `pk_id_aplicacion_usuario` int NOT NULL AUTO_INCREMENT,
  `fk_idlogin_aplicacion_usuario` int DEFAULT NULL,
  `fk_idaplicacion_aplicacion_usuario` int DEFAULT NULL,
  `fk_idpermiso_aplicacion_usuario` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_aplicacion_usuario`),
  KEY `fk_aplicacionusuario_login` (`fk_idlogin_aplicacion_usuario`),
  KEY `fk_aplicacionusuario_aplicacion` (`fk_idaplicacion_aplicacion_usuario`),
  KEY `fk_aplicacionusuario_permiso` (`fk_idpermiso_aplicacion_usuario`),
  CONSTRAINT `fk_aplicacionusuario_aplicacion` FOREIGN KEY (`fk_idaplicacion_aplicacion_usuario`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_aplicacionusuario_login` FOREIGN KEY (`fk_idlogin_aplicacion_usuario`) REFERENCES `login` (`pk_id_login`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_aplicacionusuario_permiso` FOREIGN KEY (`fk_idpermiso_aplicacion_usuario`) REFERENCES `permiso` (`pk_id_permiso`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacion_usuario`
--

LOCK TABLES `aplicacion_usuario` WRITE;
/*!40000 ALTER TABLE `aplicacion_usuario` DISABLE KEYS */;
INSERT INTO `aplicacion_usuario` VALUES (1,1,4,1),(2,1,5,2),(3,1,6,3),(4,3,8,10),(5,4,6,14),(6,5,5,16),(7,5,2,17);
/*!40000 ALTER TABLE `aplicacion_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `area`
--

DROP TABLE IF EXISTS `area`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `area` (
  `pk_idarea` int NOT NULL,
  `nombre_area` varchar(45) DEFAULT NULL,
  `descripcion_area` varchar(75) DEFAULT NULL,
  `estado_area` tinyint DEFAULT NULL,
  PRIMARY KEY (`pk_idarea`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `area`
--

LOCK TABLES `area` WRITE;
/*!40000 ALTER TABLE `area` DISABLE KEYS */;
/*!40000 ALTER TABLE `area` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `balance_detalle`
--

DROP TABLE IF EXISTS `balance_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `balance_detalle` (
  `pk_idbalanceencabezado` int NOT NULL,
  `pk_idcuenta` int NOT NULL,
  `debe_balance_detalle` double DEFAULT NULL,
  `haber_balance_detalle` double DEFAULT NULL,
  `deudor_balance_detalle` double DEFAULT NULL,
  `acreedor_balance_detalle` double DEFAULT NULL,
  PRIMARY KEY (`pk_idbalanceencabezado`),
  KEY `fk_balancedetalle_cuenta` (`pk_idcuenta`),
  CONSTRAINT `fk_balancedetalle_cuenta` FOREIGN KEY (`pk_idcuenta`) REFERENCES `cuenta_contable` (`pk_idcuenta`),
  CONSTRAINT `fk_balanceencabezado_detalle` FOREIGN KEY (`pk_idbalanceencabezado`) REFERENCES `balance_encabezado` (`pk_idbalanceencabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `balance_detalle`
--

LOCK TABLES `balance_detalle` WRITE;
/*!40000 ALTER TABLE `balance_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `balance_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `balance_encabezado`
--

DROP TABLE IF EXISTS `balance_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `balance_encabezado` (
  `pk_idbalanceencabezado` int NOT NULL,
  `descripcion_balance_encabezado` varchar(75) DEFAULT NULL,
  `fechaCreacion_balance_encabezado` datetime DEFAULT NULL,
  `totalDebeHaber_balance_encabezado` double DEFAULT NULL,
  `totalDeudorAcreedor_balance_encabezado` double DEFAULT NULL,
  PRIMARY KEY (`pk_idbalanceencabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `balance_encabezado`
--

LOCK TABLES `balance_encabezado` WRITE;
/*!40000 ALTER TABLE `balance_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `balance_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `banco`
--

DROP TABLE IF EXISTS `banco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `banco` (
  `pk_idbanco` int NOT NULL,
  `nombre_banco` varchar(50) DEFAULT NULL,
  `estado_banco` tinyint DEFAULT NULL,
  PRIMARY KEY (`pk_idbanco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `banco`
--

LOCK TABLES `banco` WRITE;
/*!40000 ALTER TABLE `banco` DISABLE KEYS */;
/*!40000 ALTER TABLE `banco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bitacora` (
  `pk_id_bitacora` int NOT NULL AUTO_INCREMENT,
  `fk_idusuario_bitacora` int DEFAULT NULL,
  `fk_idaplicacion_bitacora` int DEFAULT NULL,
  `fechahora_bitacora` varchar(50) DEFAULT NULL,
  `direccionhost_bitacora` varchar(20) DEFAULT NULL,
  `nombrehost_bitacora` varchar(20) DEFAULT NULL,
  `accion_bitacora` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`pk_id_bitacora`),
  KEY `fk_login_bitacora` (`fk_idusuario_bitacora`),
  KEY `fk_aplicacion_bitacora` (`fk_idaplicacion_bitacora`),
  CONSTRAINT `fk_aplicacion_bitacora` FOREIGN KEY (`fk_idaplicacion_bitacora`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_login_bitacora` FOREIGN KEY (`fk_idusuario_bitacora`) REFERENCES `login` (`pk_id_login`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=264 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
INSERT INTO `bitacora` VALUES (1,1,1,'21/10/2020 12:26:22','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(2,1,1,'21/10/2020 13:59:00','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(3,1,4,'21/10/2020 13:59:00','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(4,1,4,'21/10/2020 13:59:00','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(5,1,4,'21/10/2020 13:59:00','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(6,1,4,'21/10/2020 13:59:00','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(7,1,4,'21/10/2020 13:59:00','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(8,1,1,'21/10/2020 14:08:22','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(9,1,4,'21/10/2020 14:08:22','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(10,1,4,'21/10/2020 14:08:22','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(11,1,1,'21/10/2020 14:09:53','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(12,1,4,'21/10/2020 14:09:53','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(13,1,1,'21/10/2020 14:12:25','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(14,1,4,'21/10/2020 14:12:25','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(15,1,4,'21/10/2020 14:12:25','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(16,1,1,'21/10/2020 14:25:53','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(17,1,4,'21/10/2020 14:25:53','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(18,1,4,'21/10/2020 14:25:53','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(19,1,4,'21/10/2020 14:25:53','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(20,1,4,'21/10/2020 14:25:53','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(21,1,4,'21/10/2020 14:25:53','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(22,1,1,'21/10/2020 14:27:58','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(23,1,4,'21/10/2020 14:27:58','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(24,1,4,'21/10/2020 14:27:58','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(25,1,4,'21/10/2020 14:27:58','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(26,1,1,'21/10/2020 14:34:15','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(27,1,4,'21/10/2020 14:34:15','192.168.0.19','DESKTOP-L2EJSC3',' INSERT INTO perfil VALUES ( 2,  Sistema,  Administrador del sistema,  1) '),(28,1,4,'21/10/2020 14:34:15','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(29,1,4,'21/10/2020 14:34:15','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(30,1,4,'21/10/2020 14:34:15','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(31,1,4,'21/10/2020 14:34:15','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(32,1,1,'21/10/2020 14:43:54','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(33,1,1,'21/10/2020 14:44:55','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(34,1,1,'21/10/2020 14:46:22','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(35,1,4,'21/10/2020 14:46:22','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(36,1,1,'21/10/2020 14:53:32','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(37,1,1,'21/10/2020 14:56:31','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(38,1,1,'21/10/2020 15:01:24','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(39,1,4,'21/10/2020 15:01:24','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(42,1,1,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Logeo erroneo'),(43,1,1,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Logeo erroneo'),(44,1,1,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(45,1,3,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(46,1,3,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Consulta Aplicaciones'),(47,1,3,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Insercion de Aplicacion a perfil'),(48,1,3,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Consulta Aplicaciones'),(49,1,3,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Insercion de Aplicacion a perfil'),(50,1,3,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Consulta Aplicaciones'),(51,1,3,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Insercion de Aplicacion a perfil'),(52,1,3,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(53,1,3,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Consulta Aplicaciones'),(54,1,3,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Consulta Aplicaciones'),(55,1,3,'21/10/2020 18:44:39','192.168.0.19','DESKTOP-L2EJSC3','Insercion de Aplicacion a perfil'),(57,1,1,'21/10/2020 18:53:41','192.168.0.19','DESKTOP-L2EJSC3','Logeo erroneo'),(58,1,1,'21/10/2020 18:53:41','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(59,1,2,'21/10/2020 18:53:41','192.168.0.19','DESKTOP-L2EJSC3',' INSERT INTO login VALUES ( 3,  bmaza,  bmaza,  Bryan Mazariegos,  1) '),(60,1,2,'21/10/2020 18:53:41','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(61,1,4,'21/10/2020 18:53:41','192.168.0.19','DESKTOP-L2EJSC3',' INSERT INTO perfil VALUES ( 3,  Digitador,  Digitador para Cuentas,  1) '),(62,1,3,'21/10/2020 18:53:41','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(63,1,3,'21/10/2020 18:53:41','192.168.0.19','DESKTOP-L2EJSC3','Consulta Aplicaciones'),(64,1,3,'21/10/2020 18:53:41','192.168.0.19','DESKTOP-L2EJSC3','Insercion de Aplicacion a perfil'),(65,1,3,'21/10/2020 18:53:41','192.168.0.19','DESKTOP-L2EJSC3','Consulta Aplicaciones'),(66,1,3,'21/10/2020 18:53:41','192.168.0.19','DESKTOP-L2EJSC3','Insercion de Aplicacion a perfil'),(67,3,1,'21/10/2020 19:03:18','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(68,1,1,'21/10/2020 19:05:53','192.168.0.19','DESKTOP-L2EJSC3','Logeo erroneo'),(69,1,1,'21/10/2020 19:05:53','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(70,1,3,'21/10/2020 19:05:53','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(71,1,3,'21/10/2020 19:05:53','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(72,1,3,'21/10/2020 19:05:53','192.168.0.19','DESKTOP-L2EJSC3','Modificación de Aplicacion a perfil'),(73,1,3,'21/10/2020 19:05:53','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(74,3,2,'21/10/2020 19:05:53','192.168.0.19','DESKTOP-L2EJSC3','Refrescar Datos'),(75,3,2,'21/10/2020 19:05:53','192.168.0.19','DESKTOP-L2EJSC3','Refrescar Datos'),(76,3,1,'21/10/2020 19:12:18','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(77,1,3,'21/10/2020 19:12:18','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(78,1,3,'21/10/2020 19:12:18','192.168.0.19','DESKTOP-L2EJSC3','Eliminaciones de permisos Aplicacion a perfil'),(79,1,3,'21/10/2020 19:12:18','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(80,1,3,'21/10/2020 19:12:18','192.168.0.19','DESKTOP-L2EJSC3','Modificación de Aplicacion a perfil'),(81,1,3,'21/10/2020 19:12:18','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(82,1,3,'21/10/2020 19:12:18','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(83,3,1,'21/10/2020 19:26:21','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(84,1,3,'21/10/2020 19:26:21','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(85,1,3,'21/10/2020 19:26:21','192.168.0.19','DESKTOP-L2EJSC3','Consulta Aplicaciones'),(86,1,3,'21/10/2020 19:26:21','192.168.0.19','DESKTOP-L2EJSC3','Insercion de Aplicacion a perfil'),(87,3,1,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(88,1,3,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(89,1,3,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Modificación de Aplicacion a perfil'),(90,1,3,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(91,1,3,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Modificación de Aplicacion a perfil'),(92,1,2,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3',' INSERT INTO login VALUES ( 4,  jsican,  jsican,  Jeshua Sican,  1) '),(93,1,4,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3',' INSERT INTO perfil VALUES ( 4,  Consultor,  Unicamente consultas ,  1) '),(94,1,3,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(95,1,3,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Consulta Aplicaciones'),(96,1,3,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Insercion de Aplicacion a perfil'),(97,1,3,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(98,1,3,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(99,1,3,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Consulta Aplicaciones'),(100,1,3,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Insercion de Aplicacion a perfil'),(101,1,2,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Formulario de ayuda'),(102,1,2,'21/10/2020 19:47:17','192.168.0.19','DESKTOP-L2EJSC3','Salir de la aplicacion'),(103,1,1,'21/10/2020 20:19:38','192.168.0.19','DESKTOP-L2EJSC3','Logeo erroneo'),(104,1,1,'21/10/2020 20:19:38','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(105,1,1,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(106,3,1,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(107,2,1,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(108,2,1,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Logeo erroneo'),(109,1,1,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Logeo erroneo'),(110,1,1,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Logeo erroneo'),(111,1,1,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(112,1,2,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3',' INSERT INTO login VALUES ( 5,  jmorataya,  jmorataya,  Julio Morataya,  1) '),(113,1,2,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Cancelar'),(114,1,2,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','UPDATE login SET   usuario_login =  jmorataya,  contraseña_login =  123,  nombreCompleto_login =  Julio Morataya,  estado_login =  1  WHERE pk_id_login = 5; '),(115,1,4,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3',' INSERT INTO perfil VALUES ( 5,  Reportes,  Ingreso y consultas de reportes,  1) '),(116,1,3,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Consulta Perfiles'),(117,1,3,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Consulta Aplicaciones'),(118,1,3,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Insercion de Aplicacion a perfil'),(119,5,1,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Logeo erroneo'),(120,5,1,'21/10/2020 20:20:25','192.168.0.19','DESKTOP-L2EJSC3','Logeo Exitoso'),(121,1,1,'28/10/2020 11:56:33','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(122,1,1,'28/10/2020 11:58:49','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(123,1,1,'28/10/2020 12:11:24','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(124,1,1,'28/10/2020 12:14:54','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(125,2,1,'28/10/2020 12:23:02','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(126,3,1,'28/10/2020 12:23:02','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(127,1,1,'28/10/2020 12:23:02','192.168.0.18','DESKTOP-L2EJSC3','Logeo erroneo'),(128,1,1,'28/10/2020 12:23:02','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(129,1,1,'28/10/2020 12:36:08','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(130,1,1,'28/10/2020 12:42:18','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(131,1,1,'28/10/2020 12:44:25','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(132,1,1,'28/10/2020 12:50:46','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(133,1,1,'28/10/2020 12:51:57','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(134,1,1,'28/10/2020 12:57:07','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(135,1,1,'28/10/2020 12:59:27','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(136,1,1,'28/10/2020 13:03:39','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(137,1,1,'28/10/2020 13:12:06','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(138,1,1,'28/10/2020 13:13:39','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(139,1,2,'28/10/2020 13:13:39','192.168.0.18','DESKTOP-L2EJSC3','Cancelar'),(140,1,1,'28/10/2020 13:20:56','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(141,1,2,'28/10/2020 13:20:56','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(142,1,2,'28/10/2020 13:20:56','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(143,1,2,'28/10/2020 13:20:56','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(144,1,2,'28/10/2020 13:20:56','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(145,1,2,'28/10/2020 13:20:56','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(146,1,2,'28/10/2020 13:20:56','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(147,1,1,'28/10/2020 13:23:28','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(148,1,8,'28/10/2020 13:23:28','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(149,1,8,'28/10/2020 13:23:28','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(150,1,8,'28/10/2020 13:23:28','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(151,1,8,'28/10/2020 13:23:28','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(152,1,8,'28/10/2020 13:23:28','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(153,1,1,'28/10/2020 13:29:37','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(154,1,1,'28/10/2020 13:32:49','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(155,1,2,'28/10/2020 13:32:49','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(156,1,2,'28/10/2020 13:32:49','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(157,1,1,'28/10/2020 14:00:37','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(158,1,2,'28/10/2020 14:00:37','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(159,1,2,'28/10/2020 14:00:37','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(160,1,8,'28/10/2020 14:00:37','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(161,1,4,'28/10/2020 14:00:37','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(162,1,4,'28/10/2020 14:00:37','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(163,1,2,'28/10/2020 14:00:37','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(164,1,2,'28/10/2020 14:00:37','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(165,1,1,'28/10/2020 14:15:17','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(166,1,2,'28/10/2020 14:15:17','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(167,1,2,'28/10/2020 14:15:17','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(168,1,2,'28/10/2020 14:15:17','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(169,1,1,'28/10/2020 14:22:26','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(170,1,4,'28/10/2020 14:22:26','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(171,1,1,'28/10/2020 14:37:58','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(172,1,2,'28/10/2020 14:37:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(173,1,2,'28/10/2020 14:37:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(174,1,2,'28/10/2020 14:37:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(175,1,2,'28/10/2020 14:37:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(176,1,2,'28/10/2020 14:37:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(177,1,2,'28/10/2020 14:37:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(178,1,8,'28/10/2020 14:37:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(179,1,1,'28/10/2020 14:42:33','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(180,1,4,'28/10/2020 14:42:33','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(181,1,1,'28/10/2020 14:45:18','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(182,1,4,'28/10/2020 14:45:18','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(183,1,1,'28/10/2020 14:47:44','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(184,1,4,'28/10/2020 14:47:44','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(185,1,2,'28/10/2020 14:47:44','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(186,1,2,'28/10/2020 14:47:44','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(187,1,1,'28/10/2020 15:01:34','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(188,1,1,'28/10/2020 15:11:43','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(189,1,1,'28/10/2020 16:42:40','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(190,1,1,'28/10/2020 16:43:41','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(191,1,2,'28/10/2020 16:43:41','192.168.0.18','DESKTOP-L2EJSC3','Cancelar'),(192,1,1,'28/10/2020 16:49:42','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(193,1,2,'28/10/2020 16:49:42','192.168.0.18','DESKTOP-L2EJSC3','Cancelar'),(194,1,1,'28/10/2020 16:54:31','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(195,1,2,'28/10/2020 16:54:31','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(196,1,2,'28/10/2020 16:54:31','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(197,1,2,'28/10/2020 16:54:31','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(198,1,1,'28/10/2020 16:56:13','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(199,1,2,'28/10/2020 16:56:13','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(200,1,2,'28/10/2020 16:56:13','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(201,1,1,'28/10/2020 16:57:28','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(202,1,2,'28/10/2020 16:57:28','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(203,1,2,'28/10/2020 16:57:28','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(204,1,1,'28/10/2020 17:01:28','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(205,1,4,'28/10/2020 17:01:28','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(206,1,1,'28/10/2020 17:24:07','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(207,1,2,'28/10/2020 17:24:07','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(208,1,2,'28/10/2020 17:24:07','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(209,1,2,'28/10/2020 17:24:07','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(210,1,4,'28/10/2020 17:24:07','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(211,1,4,'28/10/2020 17:24:07','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(212,1,1,'28/10/2020 17:34:17','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(213,1,2,'28/10/2020 17:34:17','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(214,1,2,'28/10/2020 17:34:17','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(215,1,2,'28/10/2020 17:34:17','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(216,1,2,'28/10/2020 17:34:17','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(217,1,2,'28/10/2020 17:34:17','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(218,1,4,'28/10/2020 17:34:17','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(219,1,1,'28/10/2020 17:37:34','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(220,1,4,'28/10/2020 17:37:34','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(221,1,4,'28/10/2020 17:37:34','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(222,1,4,'28/10/2020 17:37:34','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(223,1,1,'28/10/2020 18:22:52','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(224,1,1,'28/10/2020 18:22:52','192.168.0.18','DESKTOP-L2EJSC3','Logeo erroneo'),(225,1,1,'28/10/2020 18:22:52','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(226,1,1,'28/10/2020 18:26:51','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(227,1,1,'28/10/2020 18:28:07','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(228,1,1,'28/10/2020 18:28:07','192.168.0.18','DESKTOP-L2EJSC3','Logeo erroneo'),(229,1,1,'28/10/2020 18:28:07','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(230,1,1,'28/10/2020 18:31:47','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(231,1,1,'28/10/2020 18:37:38','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(232,1,1,'28/10/2020 18:39:54','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(233,1,1,'28/10/2020 18:44:23','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(234,1,1,'28/10/2020 18:54:39','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(235,1,2,'28/10/2020 18:54:39','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(236,1,1,'28/10/2020 19:18:58','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(237,1,2,'28/10/2020 19:18:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(238,1,2,'28/10/2020 19:18:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(239,1,4,'28/10/2020 19:18:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(240,1,4,'28/10/2020 19:18:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(241,1,4,'28/10/2020 19:18:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(242,1,4,'28/10/2020 19:18:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(243,1,4,'28/10/2020 19:18:58','192.168.0.18','DESKTOP-L2EJSC3',' INSERT INTO perfil VALUES ( 6,  Pruebas,  pruebas,  1) '),(244,1,4,'28/10/2020 19:18:58','192.168.0.18','DESKTOP-L2EJSC3','Cancelar'),(245,1,8,'28/10/2020 19:18:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(246,1,8,'28/10/2020 19:18:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(247,1,8,'28/10/2020 19:18:58','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(248,1,1,'28/10/2020 19:29:30','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(249,1,4,'28/10/2020 19:29:30','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(250,1,1,'28/10/2020 19:34:52','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(251,1,1,'28/10/2020 20:17:59','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(252,1,2,'28/10/2020 20:17:59','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(253,1,2,'28/10/2020 20:17:59','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(254,1,4,'28/10/2020 20:17:59','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(255,1,1,'28/10/2020 20:20:11','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(256,1,2,'28/10/2020 20:20:11','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(257,1,1,'28/10/2020 20:43:02','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(258,1,2,'28/10/2020 20:43:02','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(259,1,2,'28/10/2020 20:43:02','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(260,1,1,'28/10/2020 20:44:40','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(261,1,2,'28/10/2020 20:44:40','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda'),(262,1,1,'28/10/2020 20:45:31','192.168.0.18','DESKTOP-L2EJSC3','Logeo Exitoso'),(263,1,8,'28/10/2020 20:45:31','192.168.0.18','DESKTOP-L2EJSC3','Formulario de ayuda');
/*!40000 ALTER TABLE `bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bodega`
--

DROP TABLE IF EXISTS `bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bodega` (
  `pk_id_bodega` int NOT NULL AUTO_INCREMENT,
  `fk_id_municipio` int NOT NULL,
  `dimensiones_bodega` double(5,2) NOT NULL,
  `direccion_bodega` varchar(45) NOT NULL,
  `telefono_bodega` int NOT NULL,
  `descripcion_bodega` varchar(45) NOT NULL,
  `estado_bodega` int NOT NULL,
  PRIMARY KEY (`pk_id_bodega`),
  KEY `pk_id_bodega` (`pk_id_bodega`),
  KEY `fk_bodega_municipio` (`fk_id_municipio`),
  CONSTRAINT `fk_bodega_municipio` FOREIGN KEY (`fk_id_municipio`) REFERENCES `municipio` (`pk_id_municipio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodega`
--

LOCK TABLES `bodega` WRITE;
/*!40000 ALTER TABLE `bodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `capacitacion`
--

DROP TABLE IF EXISTS `capacitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `capacitacion` (
  `pk_id_capacitacion` int NOT NULL,
  `fk_id_encabezado_capacitacion` int DEFAULT NULL,
  `fk_id_empleado_capacitacion` int DEFAULT NULL,
  `resultado_capacitacion` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`pk_id_capacitacion`),
  KEY `fk_encabezado_capacitacion` (`fk_id_encabezado_capacitacion`),
  KEY `fk_empleado_capacitacion` (`fk_id_empleado_capacitacion`),
  CONSTRAINT `fk_empleado_capacitacion` FOREIGN KEY (`fk_id_empleado_capacitacion`) REFERENCES `empleado` (`pk_id_empleado`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_encabezado_capacitacion` FOREIGN KEY (`fk_id_encabezado_capacitacion`) REFERENCES `encabezado_capacitacion` (`pk_id_encabezado_capacitacion`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `capacitacion`
--

LOCK TABLES `capacitacion` WRITE;
/*!40000 ALTER TABLE `capacitacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `capacitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria_producto`
--

DROP TABLE IF EXISTS `categoria_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria_producto` (
  `pk_id_categoria_producto` int NOT NULL AUTO_INCREMENT,
  `nombre_categoria_producto` varchar(35) NOT NULL,
  `descripcion_categoria_producto` varchar(60) NOT NULL,
  `estado_categoria_producto` int NOT NULL,
  PRIMARY KEY (`pk_id_categoria_producto`),
  KEY `pk_id_categoria_producto` (`pk_id_categoria_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria_producto`
--

LOCK TABLES `categoria_producto` WRITE;
/*!40000 ALTER TABLE `categoria_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `categoria_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria_tamaño`
--

DROP TABLE IF EXISTS `categoria_tamaño`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria_tamaño` (
  `pk_idcategoriatamaño` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_idcategoriatamaño`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria_tamaño`
--

LOCK TABLES `categoria_tamaño` WRITE;
/*!40000 ALTER TABLE `categoria_tamaño` DISABLE KEYS */;
/*!40000 ALTER TABLE `categoria_tamaño` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria_tipo`
--

DROP TABLE IF EXISTS `categoria_tipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria_tipo` (
  `pk_idcategoriatipo` int NOT NULL,
  `nombre_categoria_tipo` varchar(45) DEFAULT NULL,
  `descripcion_categoria_tipo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_idcategoriatipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria_tipo`
--

LOCK TABLES `categoria_tipo` WRITE;
/*!40000 ALTER TABLE `categoria_tipo` DISABLE KEYS */;
/*!40000 ALTER TABLE `categoria_tipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `pk_idcliente` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `fecha_de_nacimiento` date DEFAULT NULL,
  PRIMARY KEY (`pk_idcliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `competencia_desarrollo`
--

DROP TABLE IF EXISTS `competencia_desarrollo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `competencia_desarrollo` (
  `pk_id_encabezado_desarrollo` int NOT NULL,
  `fk_id_empleado_encabezado_desarrollo` int DEFAULT NULL,
  `fecha_inicio_encabezado_desarrollo` varchar(10) DEFAULT NULL,
  `fecha_fin_encabezado_desarrollo` varchar(10) DEFAULT NULL,
  `fk_id_competencia_encabezado_desarrollo` int DEFAULT NULL,
  `resultado_competencia_encabezado_desarrollo` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_encabezado_desarrollo`),
  KEY `fk_empleado_encabezado_desarrollo` (`fk_id_empleado_encabezado_desarrollo`),
  KEY `fk_competencia_encabezado_desarrollo` (`fk_id_competencia_encabezado_desarrollo`),
  CONSTRAINT `fk_competencia_encabezado_desarrollo` FOREIGN KEY (`fk_id_competencia_encabezado_desarrollo`) REFERENCES `tipo_competencia` (`pk_id_competencia`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_empleado_encabezado_desarrollo` FOREIGN KEY (`fk_id_empleado_encabezado_desarrollo`) REFERENCES `empleado` (`pk_id_empleado`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `competencia_desarrollo`
--

LOCK TABLES `competencia_desarrollo` WRITE;
/*!40000 ALTER TABLE `competencia_desarrollo` DISABLE KEYS */;
/*!40000 ALTER TABLE `competencia_desarrollo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra_detalle`
--

DROP TABLE IF EXISTS `compra_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compra_detalle` (
  `fk_id_compra_encabezado` int NOT NULL,
  `cod_linea_compra_detalle` int NOT NULL,
  `fk_id_producto` int NOT NULL,
  `cantidad_compra_detalle` int NOT NULL,
  `precio_unitario_compra_detalle` double(8,2) NOT NULL,
  `subtotal_compra_detalle` double(12,2) NOT NULL,
  `estado_compra_detalle` int NOT NULL,
  PRIMARY KEY (`fk_id_compra_encabezado`,`cod_linea_compra_detalle`),
  KEY `fk_id_compra_encabezado` (`fk_id_compra_encabezado`,`cod_linea_compra_detalle`),
  KEY `fk_compra_producto` (`fk_id_producto`),
  CONSTRAINT `fk_compra_detalle` FOREIGN KEY (`fk_id_compra_encabezado`) REFERENCES `compra_encabezado` (`pk_id_compra_encabezado`),
  CONSTRAINT `fk_compra_producto` FOREIGN KEY (`fk_id_producto`) REFERENCES `productoscm` (`pk_id_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra_detalle`
--

LOCK TABLES `compra_detalle` WRITE;
/*!40000 ALTER TABLE `compra_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `compra_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra_encabezado`
--

DROP TABLE IF EXISTS `compra_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compra_encabezado` (
  `pk_id_compra_encabezado` int NOT NULL,
  `fk_id_proveedor` int NOT NULL,
  `fec_compra_encabezado_compra` datetime NOT NULL,
  `total_compra_encabezado_compra` double(12,2) NOT NULL,
  `estado_encabezado_compra` int NOT NULL,
  PRIMARY KEY (`pk_id_compra_encabezado`),
  KEY `pk_id_compra_encabezado` (`pk_id_compra_encabezado`),
  KEY `fk_compra_proveedor` (`fk_id_proveedor`),
  CONSTRAINT `fk_compra_proveedor` FOREIGN KEY (`fk_id_proveedor`) REFERENCES `proveedor` (`pk_id_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra_encabezado`
--

LOCK TABLES `compra_encabezado` WRITE;
/*!40000 ALTER TABLE `compra_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `compra_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consulta_inteligente`
--

DROP TABLE IF EXISTS `consulta_inteligente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consulta_inteligente` (
  `pk_id_consulta_inteligente` int NOT NULL,
  `nombre_consulta_inteligente` varchar(100) DEFAULT NULL,
  `contenido_consulta_inteligente` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`pk_id_consulta_inteligente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consulta_inteligente`
--

LOCK TABLES `consulta_inteligente` WRITE;
/*!40000 ALTER TABLE `consulta_inteligente` DISABLE KEYS */;
/*!40000 ALTER TABLE `consulta_inteligente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contrato`
--

DROP TABLE IF EXISTS `contrato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contrato` (
  `pk_id_contrato` int NOT NULL,
  `nombre_contrato` varchar(45) DEFAULT NULL,
  `fecha_suscripcion_contrato` varchar(10) DEFAULT NULL,
  `fk_id_tipo_contrato` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_contrato`),
  KEY `fk_tipo_contrato` (`fk_id_tipo_contrato`),
  CONSTRAINT `fk_tipo_contrato` FOREIGN KEY (`fk_id_tipo_contrato`) REFERENCES `tipo_contrato` (`pk_id_tipo_contrato`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contrato`
--

LOCK TABLES `contrato` WRITE;
/*!40000 ALTER TABLE `contrato` DISABLE KEYS */;
/*!40000 ALTER TABLE `contrato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `control_empleado`
--

DROP TABLE IF EXISTS `control_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `control_empleado` (
  `pk_idControlEmpleado` int NOT NULL,
  `Horas_Efectivas_De_Trabajo` varchar(45) DEFAULT NULL,
  `Horas_Extras` varchar(45) DEFAULT NULL,
  `Comisiones` varchar(45) DEFAULT NULL,
  `fK_idEMPLEADO` int NOT NULL,
  `fk_idventa` int NOT NULL,
  PRIMARY KEY (`pk_idControlEmpleado`),
  KEY `fk_CONTROL_EMPLEADO_VENTA1` (`fk_idventa`),
  KEY `fk_CONTROL_EMPLEADO_EMPLEADO1` (`fK_idEMPLEADO`),
  CONSTRAINT `fk_CONTROL_EMPLEADO_EMPLEADO1` FOREIGN KEY (`fK_idEMPLEADO`) REFERENCES `empleado` (`pk_id_empleado`),
  CONSTRAINT `fk_CONTROL_EMPLEADO_VENTA1` FOREIGN KEY (`fk_idventa`) REFERENCES `venta` (`pk_idventa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `control_empleado`
--

LOCK TABLES `control_empleado` WRITE;
/*!40000 ALTER TABLE `control_empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `control_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controlcalidad`
--

DROP TABLE IF EXISTS `controlcalidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controlcalidad` (
  `pk_id_controlcalidad` int NOT NULL AUTO_INCREMENT,
  `fk_idordenproduccion_controlcalidad` int NOT NULL,
  `fk_idinventario_controlcalidad` int NOT NULL,
  `fk_idresponsable_controlcalidad` int NOT NULL,
  `resultado_controlcalidad` varchar(45) DEFAULT NULL,
  `estado_controlcalidad` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_controlcalidad`),
  KEY `fk_CONTROLCALIDAD_ORDENPRODUCCION1` (`fk_idordenproduccion_controlcalidad`),
  KEY `fk_CONTROLCALIDAD_INVENTARIO1` (`fk_idinventario_controlcalidad`),
  KEY `fk_EMPLEADOS_CONTROLCALIDAD1` (`fk_idresponsable_controlcalidad`),
  CONSTRAINT `fk_CONTROLCALIDAD_INVENTARIO1` FOREIGN KEY (`fk_idinventario_controlcalidad`) REFERENCES `inventariomrp` (`pk_id_inventario`),
  CONSTRAINT `fk_CONTROLCALIDAD_ORDENPRODUCCION1` FOREIGN KEY (`fk_idordenproduccion_controlcalidad`) REFERENCES `ordenproduccion` (`pk_id_ordenproduccion`),
  CONSTRAINT `fk_EMPLEADOS_CONTROLCALIDAD1` FOREIGN KEY (`fk_idresponsable_controlcalidad`) REFERENCES `empleado` (`pk_id_empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controlcalidad`
--

LOCK TABLES `controlcalidad` WRITE;
/*!40000 ALTER TABLE `controlcalidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `controlcalidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controlproducto`
--

DROP TABLE IF EXISTS `controlproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controlproducto` (
  `pk_id_controlproducto` int NOT NULL AUTO_INCREMENT,
  `fk_idordenproduccion_controlproducto` int DEFAULT NULL,
  `fk_idestadoproduccion_controlproducto` int DEFAULT NULL,
  `resultado_controlproducto` varchar(45) DEFAULT NULL,
  `estado_controlproducto` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_controlproducto`),
  KEY `fk_CONTROLPRODUCTO_ORDENPRODUCCION1` (`fk_idordenproduccion_controlproducto`),
  KEY `fk_CONTROLPRODUCTO_ESTADOPRODUCCION` (`fk_idestadoproduccion_controlproducto`),
  CONSTRAINT `fk_CONTROLPRODUCTO_ESTADOPRODUCCION` FOREIGN KEY (`fk_idestadoproduccion_controlproducto`) REFERENCES `estadoproduccion` (`pk_id_estadoproduccion`),
  CONSTRAINT `fk_CONTROLPRODUCTO_ORDENPRODUCCION1` FOREIGN KEY (`fk_idordenproduccion_controlproducto`) REFERENCES `ordenproduccion` (`pk_id_ordenproduccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controlproducto`
--

LOCK TABLES `controlproducto` WRITE;
/*!40000 ALTER TABLE `controlproducto` DISABLE KEYS */;
/*!40000 ALTER TABLE `controlproducto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `correo_cliente`
--

DROP TABLE IF EXISTS `correo_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `correo_cliente` (
  `pk_iddireccionCliente` int NOT NULL,
  `numero` varchar(45) DEFAULT NULL,
  `calle` varchar(45) DEFAULT NULL,
  `colonia` varchar(45) DEFAULT NULL,
  `ciudad` varchar(45) DEFAULT NULL,
  `fk_idcliente` int NOT NULL,
  PRIMARY KEY (`pk_iddireccionCliente`),
  KEY `fk_direccionCliente_cliente1` (`fk_idcliente`),
  CONSTRAINT `fk_direccionCliente_cliente1` FOREIGN KEY (`fk_idcliente`) REFERENCES `cliente` (`pk_idcliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `correo_cliente`
--

LOCK TABLES `correo_cliente` WRITE;
/*!40000 ALTER TABLE `correo_cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `correo_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `correo_proveedor`
--

DROP TABLE IF EXISTS `correo_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `correo_proveedor` (
  `pk_id_correo_proveedor` int NOT NULL AUTO_INCREMENT,
  `fk_id_proveedor` int NOT NULL,
  `correo_correo_proveedor` varchar(50) NOT NULL,
  PRIMARY KEY (`pk_id_correo_proveedor`),
  KEY `pk_id_correo_proveedor` (`pk_id_correo_proveedor`),
  KEY `fk_proveedor_correo` (`fk_id_proveedor`),
  CONSTRAINT `fk_proveedor_correo` FOREIGN KEY (`fk_id_proveedor`) REFERENCES `proveedor` (`pk_id_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `correo_proveedor`
--

LOCK TABLES `correo_proveedor` WRITE;
/*!40000 ALTER TABLE `correo_proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `correo_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuenta_bancaria`
--

DROP TABLE IF EXISTS `cuenta_bancaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuenta_bancaria` (
  `pk_idnumerocuenta` int NOT NULL,
  `fk_idbanco` int NOT NULL,
  `fk_idpropietario` int NOT NULL,
  `fk_idtipomoneda` int NOT NULL,
  `saldo_cuenta_bancaria` double DEFAULT NULL,
  `fecha_apertura_cuenta_bancaria` datetime DEFAULT NULL,
  `estado_apertura_cuenta` tinyint DEFAULT NULL,
  PRIMARY KEY (`pk_idnumerocuenta`),
  KEY `fk_cuentabancaria_banco` (`fk_idbanco`),
  KEY `fk_cuentabancaria_propietario` (`fk_idpropietario`),
  KEY `fk_cuentabancaria_tipomoneda` (`fk_idtipomoneda`),
  CONSTRAINT `fk_cuentabancaria_banco` FOREIGN KEY (`fk_idbanco`) REFERENCES `banco` (`pk_idbanco`),
  CONSTRAINT `fk_cuentabancaria_propietario` FOREIGN KEY (`fk_idpropietario`) REFERENCES `propietario` (`pk_idpropietario`),
  CONSTRAINT `fk_cuentabancaria_tipomoneda` FOREIGN KEY (`fk_idtipomoneda`) REFERENCES `tipo_moneda` (`pk_idtipomoneda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuenta_bancaria`
--

LOCK TABLES `cuenta_bancaria` WRITE;
/*!40000 ALTER TABLE `cuenta_bancaria` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuenta_bancaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuenta_contable`
--

DROP TABLE IF EXISTS `cuenta_contable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuenta_contable` (
  `pk_idcuenta` int NOT NULL,
  `nombre_cuenta_contable` varchar(75) DEFAULT NULL,
  `nivel_cuenta_contable` int DEFAULT NULL,
  `fk_cuentapadre` int DEFAULT NULL,
  `saldo_cuenta_contable` double DEFAULT NULL,
  `estado_cuenta_contable` tinyint DEFAULT NULL,
  PRIMARY KEY (`pk_idcuenta`),
  KEY `fk_cuentapadre_cuentahijo` (`fk_cuentapadre`),
  CONSTRAINT `fk_cuentapadre_cuentahijo` FOREIGN KEY (`fk_cuentapadre`) REFERENCES `cuenta_contable` (`pk_idcuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuenta_contable`
--

LOCK TABLES `cuenta_contable` WRITE;
/*!40000 ALTER TABLE `cuenta_contable` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuenta_contable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuentas_por_cobrar`
--

DROP TABLE IF EXISTS `cuentas_por_cobrar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuentas_por_cobrar` (
  `pk_idcuentacobrar` int NOT NULL AUTO_INCREMENT,
  `cuota` varchar(45) DEFAULT NULL,
  `abono` varchar(45) DEFAULT NULL,
  `fk_idfactura` int NOT NULL,
  `fk_idcliente` int NOT NULL,
  PRIMARY KEY (`pk_idcuentacobrar`),
  KEY `fk_cuentasporcobrar_factura1` (`fk_idfactura`),
  KEY `fk_cuentasporcobrar_cliente1` (`fk_idcliente`),
  CONSTRAINT `fk_cuentasporcobrar_cliente1` FOREIGN KEY (`fk_idcliente`) REFERENCES `cliente` (`pk_idcliente`),
  CONSTRAINT `fk_cuentasporcobrar_factura1` FOREIGN KEY (`fk_idfactura`) REFERENCES `factura` (`pk_idfactura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuentas_por_cobrar`
--

LOCK TABLES `cuentas_por_cobrar` WRITE;
/*!40000 ALTER TABLE `cuentas_por_cobrar` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuentas_por_cobrar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `curso`
--

DROP TABLE IF EXISTS `curso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `curso` (
  `pk_id_curso` int NOT NULL,
  `nombre_curso` varchar(45) DEFAULT NULL,
  `capacitador_curso` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_id_curso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `curso`
--

LOCK TABLES `curso` WRITE;
/*!40000 ALTER TABLE `curso` DISABLE KEYS */;
/*!40000 ALTER TABLE `curso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deduccion`
--

DROP TABLE IF EXISTS `deduccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deduccion` (
  `pk_id_deduccion` int NOT NULL,
  `nombre_deduccion` varchar(45) DEFAULT NULL,
  `monto_deduccion` double DEFAULT NULL,
  `descripcion_deduccion` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`pk_id_deduccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deduccion`
--

LOCK TABLES `deduccion` WRITE;
/*!40000 ALTER TABLE `deduccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `deduccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamento` (
  `pk_id_departamento` int NOT NULL AUTO_INCREMENT,
  `nombre_departamento` varchar(30) NOT NULL,
  `descripcion_departamento` varchar(45) NOT NULL,
  `estado_departamento` int NOT NULL,
  PRIMARY KEY (`pk_id_departamento`),
  KEY `pk_id_departamento` (`pk_id_departamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamento_empresarial`
--

DROP TABLE IF EXISTS `departamento_empresarial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamento_empresarial` (
  `pk_id__departamento_empresarial` int NOT NULL,
  `nombre_departamento_empresarial` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`pk_id__departamento_empresarial`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento_empresarial`
--

LOCK TABLES `departamento_empresarial` WRITE;
/*!40000 ALTER TABLE `departamento_empresarial` DISABLE KEYS */;
/*!40000 ALTER TABLE `departamento_empresarial` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_bitacora`
--

DROP TABLE IF EXISTS `detalle_bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_bitacora` (
  `pk_id_detalle_bitacora` int NOT NULL AUTO_INCREMENT,
  `fk_idbitacora_detalle_bitacora` int DEFAULT NULL,
  `querryantigua_detalle_bitacora` varchar(50) DEFAULT NULL,
  `querrynueva_detalle_bitacora` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`pk_id_detalle_bitacora`),
  KEY `fk_bitacora_detallebitacora` (`fk_idbitacora_detalle_bitacora`),
  CONSTRAINT `fk_bitacora_detallebitacora` FOREIGN KEY (`fk_idbitacora_detalle_bitacora`) REFERENCES `bitacora` (`pk_id_bitacora`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_bitacora`
--

LOCK TABLES `detalle_bitacora` WRITE;
/*!40000 ALTER TABLE `detalle_bitacora` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_consulta_inteligente`
--

DROP TABLE IF EXISTS `detalle_consulta_inteligente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_consulta_inteligente` (
  `pk_id_detalle_consulta_inteligente` int NOT NULL,
  `fk_id_empleado_detalle_consulta_inteligente` int DEFAULT NULL,
  `fk_id_consulta_detalle_consulta_inteligente` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_detalle_consulta_inteligente`),
  KEY `fk_empleado_detalle_consulta_inteligente` (`fk_id_empleado_detalle_consulta_inteligente`),
  KEY `fk_consulta_detalle_consulta_inteligente` (`fk_id_consulta_detalle_consulta_inteligente`),
  CONSTRAINT `fk_consulta_detalle_consulta_inteligente` FOREIGN KEY (`fk_id_consulta_detalle_consulta_inteligente`) REFERENCES `consulta_inteligente` (`pk_id_consulta_inteligente`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_empleado_detalle_consulta_inteligente` FOREIGN KEY (`fk_id_empleado_detalle_consulta_inteligente`) REFERENCES `empleado` (`pk_id_empleado`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_consulta_inteligente`
--

LOCK TABLES `detalle_consulta_inteligente` WRITE;
/*!40000 ALTER TABLE `detalle_consulta_inteligente` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_consulta_inteligente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_factura`
--

DROP TABLE IF EXISTS `detalle_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_factura` (
  `pk_id_detalle_factura` int NOT NULL,
  `fk_idfactura` int NOT NULL,
  `fk_idproducto` int NOT NULL,
  `cantidad` int DEFAULT NULL,
  `precio` float DEFAULT NULL,
  PRIMARY KEY (`pk_id_detalle_factura`),
  KEY `fk_DETALLE_FACTURA_FACTURA1` (`fk_idfactura`),
  KEY `fk_DETALLE_FACTURA_PRODUCTO1` (`fk_idproducto`),
  CONSTRAINT `fk_DETALLE_FACTURA_FACTURA1` FOREIGN KEY (`fk_idfactura`) REFERENCES `factura` (`pk_idfactura`),
  CONSTRAINT `fk_DETALLE_FACTURA_PRODUCTO1` FOREIGN KEY (`fk_idproducto`) REFERENCES `producto` (`pk_idproducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_factura`
--

LOCK TABLES `detalle_factura` WRITE;
/*!40000 ALTER TABLE `detalle_factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_nomina`
--

DROP TABLE IF EXISTS `detalle_nomina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_nomina` (
  `pk_id_detalle_nomina` int NOT NULL,
  `fk_id_encabezado_detalle_nomina` int DEFAULT NULL,
  `fk_id_empleado_detalle_nomina` int DEFAULT NULL,
  `fk_id_percepciones_detalle_nomina` int DEFAULT NULL,
  `fk_id_deducciones_detalle_nomina` int DEFAULT NULL,
  `salario_base_detalle_nomina` double DEFAULT NULL,
  PRIMARY KEY (`pk_id_detalle_nomina`),
  KEY `fk_encabezado_detalle_nomina` (`fk_id_encabezado_detalle_nomina`),
  KEY `fk_emplado_detalle_nomina` (`fk_id_empleado_detalle_nomina`),
  KEY `fk_percepcion_detalle_nomina` (`fk_id_percepciones_detalle_nomina`),
  KEY `fk_deduccion_detalle_nomina` (`fk_id_deducciones_detalle_nomina`),
  CONSTRAINT `fk_deduccion_detalle_nomina` FOREIGN KEY (`fk_id_deducciones_detalle_nomina`) REFERENCES `deduccion` (`pk_id_deduccion`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_emplado_detalle_nomina` FOREIGN KEY (`fk_id_empleado_detalle_nomina`) REFERENCES `empleado` (`pk_id_empleado`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_encabezado_detalle_nomina` FOREIGN KEY (`fk_id_encabezado_detalle_nomina`) REFERENCES `encabezado_nomina` (`pk_id_encabezado_nomina`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_percepcion_detalle_nomina` FOREIGN KEY (`fk_id_percepciones_detalle_nomina`) REFERENCES `percepcion` (`pk_id_percepcion`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_nomina`
--

LOCK TABLES `detalle_nomina` WRITE;
/*!40000 ALTER TABLE `detalle_nomina` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_nomina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_transaccion`
--

DROP TABLE IF EXISTS `detalle_transaccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_transaccion` (
  `pk_iddetalletransaccion` int NOT NULL,
  `fk_idencabezadotransaccion` int NOT NULL,
  `fk_idtipotransaccion` int NOT NULL,
  `monto_detalle_transaccion` double DEFAULT NULL,
  `descripcion_detalle_transaccion` varchar(75) DEFAULT NULL,
  PRIMARY KEY (`pk_iddetalletransaccion`),
  KEY `fk_detalle_encabezado` (`fk_idencabezadotransaccion`),
  KEY `fk_detalle_tipotransaccion` (`fk_idtipotransaccion`),
  CONSTRAINT `fk_detalle_encabezado` FOREIGN KEY (`fk_idencabezadotransaccion`) REFERENCES `encabezado_transaccion` (`pk_idencabezadotransaccion`),
  CONSTRAINT `fk_detalle_tipotransaccion` FOREIGN KEY (`fk_idtipotransaccion`) REFERENCES `tipo_transaccion` (`pk_idtipotransaccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_transaccion`
--

LOCK TABLES `detalle_transaccion` WRITE;
/*!40000 ALTER TABLE `detalle_transaccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_transaccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devolucion_detalle`
--

DROP TABLE IF EXISTS `devolucion_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `devolucion_detalle` (
  `fk_id_devolucion_encabezado` int NOT NULL,
  `cod_linea_devolucion_encabezado` int NOT NULL,
  `fk_id_producto` int NOT NULL,
  `fk_id_estado_producto` int NOT NULL,
  `cantidad_devolucion_encabezado` int NOT NULL,
  `iva_por_cobrar_devolucion_encabezado` double(8,2) NOT NULL,
  `precio_unitario_devolucion_encabezado` double(8,2) NOT NULL,
  `subtotal_devolucion_encabezado` double(12,2) NOT NULL,
  `estado_devolucion_encabezado` int NOT NULL,
  PRIMARY KEY (`fk_id_devolucion_encabezado`,`cod_linea_devolucion_encabezado`),
  KEY `fk_id_devolucion_encabezado` (`fk_id_devolucion_encabezado`,`cod_linea_devolucion_encabezado`),
  KEY `fk_devolucion_producto` (`fk_id_producto`),
  KEY `fk_devolucion_Estadoproducto` (`fk_id_estado_producto`),
  CONSTRAINT `fk_devolucion_Estadoproducto` FOREIGN KEY (`fk_id_estado_producto`) REFERENCES `estado_producto` (`pk_id_estado_producto`),
  CONSTRAINT `fk_devolucion_producto` FOREIGN KEY (`fk_id_producto`) REFERENCES `productoscm` (`pk_id_producto`),
  CONSTRAINT `fk_devolucionDetalle_encabezado` FOREIGN KEY (`fk_id_devolucion_encabezado`) REFERENCES `devolucion_encabezado` (`pk_id_devolucion_encabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devolucion_detalle`
--

LOCK TABLES `devolucion_detalle` WRITE;
/*!40000 ALTER TABLE `devolucion_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `devolucion_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devolucion_encabezado`
--

DROP TABLE IF EXISTS `devolucion_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `devolucion_encabezado` (
  `pk_id_devolucion_encabezado` int NOT NULL,
  `fk_id_fabrica` int NOT NULL,
  `fk_id_categoria_producto` int NOT NULL,
  `fec_devolucion_encabezado` datetime NOT NULL,
  `total_devolucion_encabezado` double(12,2) NOT NULL,
  `estado_devolucion_encabezado` int NOT NULL,
  PRIMARY KEY (`pk_id_devolucion_encabezado`),
  KEY `pk_id_devolucion_encabezado` (`pk_id_devolucion_encabezado`),
  KEY `fk_devolucion_fabrica` (`fk_id_fabrica`),
  KEY `fk_devolucion_categoria` (`fk_id_categoria_producto`),
  CONSTRAINT `fk_devolucion_categoria` FOREIGN KEY (`fk_id_categoria_producto`) REFERENCES `categoria_producto` (`pk_id_categoria_producto`),
  CONSTRAINT `fk_devolucion_fabrica` FOREIGN KEY (`fk_id_fabrica`) REFERENCES `fabrica` (`pk_id_fabrica`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devolucion_encabezado`
--

LOCK TABLES `devolucion_encabezado` WRITE;
/*!40000 ALTER TABLE `devolucion_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `devolucion_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diario_detalle`
--

DROP TABLE IF EXISTS `diario_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diario_detalle` (
  `pk_polizaencabezado` int NOT NULL,
  `pk_idcuenta` int NOT NULL,
  `monto_diario_detalle` double DEFAULT NULL,
  `debe_diario_detalle` tinyint DEFAULT NULL,
  PRIMARY KEY (`pk_polizaencabezado`),
  KEY `fk_diariodetalle_cuenta` (`pk_idcuenta`),
  CONSTRAINT `fk_diariodetalle_cuenta` FOREIGN KEY (`pk_idcuenta`) REFERENCES `cuenta_contable` (`pk_idcuenta`),
  CONSTRAINT `fk_diariodetalle_encabezado` FOREIGN KEY (`pk_polizaencabezado`) REFERENCES `diario_encabezado` (`pk_polizaencabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diario_detalle`
--

LOCK TABLES `diario_detalle` WRITE;
/*!40000 ALTER TABLE `diario_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `diario_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diario_encabezado`
--

DROP TABLE IF EXISTS `diario_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diario_encabezado` (
  `pk_polizaencabezado` int NOT NULL,
  `fecha_diarioencabezado` datetime DEFAULT NULL,
  `descripcion_diarioencabezado` varchar(75) DEFAULT NULL,
  `estado_diarioencabezado` tinyint DEFAULT NULL,
  `total_diarioencabezado` double DEFAULT NULL,
  PRIMARY KEY (`pk_polizaencabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diario_encabezado`
--

LOCK TABLES `diario_encabezado` WRITE;
/*!40000 ALTER TABLE `diario_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `diario_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `direccion`
--

DROP TABLE IF EXISTS `direccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `direccion` (
  `pk_id_direccion` int NOT NULL,
  `departamento_direccion` varchar(45) DEFAULT NULL,
  `zona_direccion` varchar(7) DEFAULT NULL,
  `municipio_direccion` varchar(100) DEFAULT NULL,
  `residencia_direccion` varchar(45) DEFAULT NULL,
  `fk_empleado_direccion` int DEFAULT NULL,
  `fk_reclutamiento_direccion` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_direccion`),
  KEY `fk_empleado_direccion` (`fk_empleado_direccion`),
  KEY `fk_reclutamiento_direccion` (`fk_reclutamiento_direccion`),
  CONSTRAINT `fk_empleado_direccion` FOREIGN KEY (`fk_empleado_direccion`) REFERENCES `empleado` (`pk_id_empleado`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_reclutamiento_direccion` FOREIGN KEY (`fk_reclutamiento_direccion`) REFERENCES `reclutamiento` (`pk_id_reclutamiento`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `direccion`
--

LOCK TABLES `direccion` WRITE;
/*!40000 ALTER TABLE `direccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `direccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `pk_id_empleado` int NOT NULL,
  `nombre1_empleado` varchar(45) DEFAULT NULL,
  `nombre2_empleado` varchar(45) DEFAULT NULL,
  `apellido1_empleado` varchar(45) DEFAULT NULL,
  `apellido2_empleado` varchar(45) DEFAULT NULL,
  `fecha_nacimiento_empleado` varchar(10) DEFAULT NULL,
  `dpi_empleado` int DEFAULT NULL,
  `fk_id_genero_empleado` int DEFAULT NULL,
  `fk_id_estado_civil_empleado` int DEFAULT NULL,
  `email_empleado` varchar(125) DEFAULT NULL,
  `telefono_empleado` int DEFAULT NULL,
  `numero_iggs_empleado` int DEFAULT NULL,
  `fk_id_licencia_conducir_empleado` int DEFAULT NULL,
  `fk_id_contrato_empleado` int DEFAULT NULL,
  `fk_id_puesto_empleado` int DEFAULT NULL,
  `cuenta_bancaria_empleado` int DEFAULT NULL,
  `fk_id_departamento_empresarial_empleado` int DEFAULT NULL,
  `estado_empleado` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_empleado`),
  KEY `fk_genero_empleado1` (`fk_id_genero_empleado`),
  KEY `fk_estado_civil_empleado` (`fk_id_estado_civil_empleado`),
  KEY `fk_licencia_conducir_empleado` (`fk_id_licencia_conducir_empleado`),
  KEY `fk_contrato_empleado` (`fk_id_contrato_empleado`),
  KEY `fk_puesto_empleado` (`fk_id_puesto_empleado`),
  KEY `fk_departamento_empresarial_empleado` (`fk_id_departamento_empresarial_empleado`),
  CONSTRAINT `fk_contrato_empleado` FOREIGN KEY (`fk_id_contrato_empleado`) REFERENCES `contrato` (`pk_id_contrato`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_departamento_empresarial_empleado` FOREIGN KEY (`fk_id_departamento_empresarial_empleado`) REFERENCES `departamento_empresarial` (`pk_id__departamento_empresarial`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_estado_civil_empleado` FOREIGN KEY (`fk_id_estado_civil_empleado`) REFERENCES `estado_civil` (`pk_id_estado_civil`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_genero_empleado1` FOREIGN KEY (`fk_id_genero_empleado`) REFERENCES `genero` (`pk_id_genero`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_licencia_conducir_empleado` FOREIGN KEY (`fk_id_licencia_conducir_empleado`) REFERENCES `licencia_conduccion` (`pk_id_licencia_conduccion`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_puesto_empleado` FOREIGN KEY (`fk_id_puesto_empleado`) REFERENCES `puesto` (`pk_id_puesto`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encabezado_capacitacion`
--

DROP TABLE IF EXISTS `encabezado_capacitacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `encabezado_capacitacion` (
  `pk_id_encabezado_capacitacion` int NOT NULL,
  `nombre_encabezado_capacitacion` varchar(45) DEFAULT NULL,
  `fecha_inicio_encabezado_capacitacion` varchar(10) DEFAULT NULL,
  `fecha_fin_encabezado_capacitacion` varchar(10) DEFAULT NULL,
  `fk_id_curso_encabezado_capacitacion` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_encabezado_capacitacion`),
  KEY `fk_curso_encabezado_capacitacion` (`fk_id_curso_encabezado_capacitacion`),
  CONSTRAINT `fk_curso_encabezado_capacitacion` FOREIGN KEY (`fk_id_curso_encabezado_capacitacion`) REFERENCES `curso` (`pk_id_curso`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encabezado_capacitacion`
--

LOCK TABLES `encabezado_capacitacion` WRITE;
/*!40000 ALTER TABLE `encabezado_capacitacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `encabezado_capacitacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encabezado_nomina`
--

DROP TABLE IF EXISTS `encabezado_nomina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `encabezado_nomina` (
  `pk_id_encabezado_nomina` int NOT NULL,
  `nombre_encabezado_nomina` varchar(45) DEFAULT NULL,
  `fecha_inicio_encabezado_nomina` varchar(10) DEFAULT NULL,
  `fecha_fin_encabezado_nomina` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`pk_id_encabezado_nomina`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encabezado_nomina`
--

LOCK TABLES `encabezado_nomina` WRITE;
/*!40000 ALTER TABLE `encabezado_nomina` DISABLE KEYS */;
/*!40000 ALTER TABLE `encabezado_nomina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encabezado_transaccion`
--

DROP TABLE IF EXISTS `encabezado_transaccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `encabezado_transaccion` (
  `pk_idencabezadotransaccion` int NOT NULL,
  `fk_idnumerocuenta` int NOT NULL,
  `fecha_encabezado_transaccion` datetime DEFAULT NULL,
  PRIMARY KEY (`pk_idencabezadotransaccion`),
  KEY `fk_encabezadotransaccion_numerocuenta` (`fk_idnumerocuenta`),
  CONSTRAINT `fk_encabezadotransaccion_numerocuenta` FOREIGN KEY (`fk_idnumerocuenta`) REFERENCES `cuenta_bancaria` (`pk_idnumerocuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encabezado_transaccion`
--

LOCK TABLES `encabezado_transaccion` WRITE;
/*!40000 ALTER TABLE `encabezado_transaccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `encabezado_transaccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encargado_bodega`
--

DROP TABLE IF EXISTS `encargado_bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `encargado_bodega` (
  `pk_id_encargado_bodega` int NOT NULL AUTO_INCREMENT,
  `fk_id_empleado` int NOT NULL,
  `fk_id_bodega` int NOT NULL,
  `estado_encargado_bodega` int NOT NULL,
  PRIMARY KEY (`pk_id_encargado_bodega`),
  KEY `pk_id_encargado_bodega` (`pk_id_encargado_bodega`),
  KEY `fk_empleado_encargado` (`fk_id_empleado`),
  KEY `fk_empleado_bodega1` (`fk_id_bodega`),
  CONSTRAINT `fk_empleado_bodega1` FOREIGN KEY (`fk_id_bodega`) REFERENCES `bodega` (`pk_id_bodega`),
  CONSTRAINT `fk_empleado_encargado` FOREIGN KEY (`fk_id_empleado`) REFERENCES `empleado` (`pk_id_empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encargado_bodega`
--

LOCK TABLES `encargado_bodega` WRITE;
/*!40000 ALTER TABLE `encargado_bodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `encargado_bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entrevista`
--

DROP TABLE IF EXISTS `entrevista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `entrevista` (
  `pk_id_entrevista` int NOT NULL,
  `fk_id_empleado_entrevista` int DEFAULT NULL,
  `fk_id_reclutamiento_entrevista` int DEFAULT NULL,
  `fk_id_tipo_entrevista` int DEFAULT NULL,
  `resultado_entrevista` int DEFAULT NULL,
  `comentarios_entrevistador_entrevista` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`pk_id_entrevista`),
  KEY `fk_empleado_entrevista` (`fk_id_empleado_entrevista`),
  KEY `fk_reclutamiento_entrevista` (`fk_id_reclutamiento_entrevista`),
  KEY `fk_tipo_entrevista` (`fk_id_tipo_entrevista`),
  CONSTRAINT `fk_empleado_entrevista` FOREIGN KEY (`fk_id_empleado_entrevista`) REFERENCES `empleado` (`pk_id_empleado`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_reclutamiento_entrevista` FOREIGN KEY (`fk_id_reclutamiento_entrevista`) REFERENCES `reclutamiento` (`pk_id_reclutamiento`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_tipo_entrevista` FOREIGN KEY (`fk_id_tipo_entrevista`) REFERENCES `tipo_entrevista` (`pk_id_tipo_entrevista`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entrevista`
--

LOCK TABLES `entrevista` WRITE;
/*!40000 ALTER TABLE `entrevista` DISABLE KEYS */;
/*!40000 ALTER TABLE `entrevista` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `envio_producto`
--

DROP TABLE IF EXISTS `envio_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `envio_producto` (
  `pk_id_envio_producto` int NOT NULL AUTO_INCREMENT,
  `fk_id_ruta` int NOT NULL,
  `fk_id_producto` int NOT NULL,
  `fk_id_empleado` int NOT NULL,
  `fk_id_vehiculo` int NOT NULL,
  `fec_envio_producto` datetime NOT NULL,
  `fec_recibido_envio_producto` datetime NOT NULL,
  `descripcion_envio_producto` varchar(45) NOT NULL,
  PRIMARY KEY (`pk_id_envio_producto`),
  KEY `pk_id_envio_producto` (`pk_id_envio_producto`),
  KEY `fk_envio_producto_vehiculo` (`fk_id_vehiculo`),
  KEY `fk_envio_producto` (`fk_id_producto`),
  KEY `fk_envio_empleado` (`fk_id_empleado`),
  KEY `fk_envio_ruta` (`fk_id_ruta`),
  CONSTRAINT `fk_envio_empleado` FOREIGN KEY (`fk_id_empleado`) REFERENCES `empleado` (`pk_id_empleado`),
  CONSTRAINT `fk_envio_producto` FOREIGN KEY (`fk_id_producto`) REFERENCES `productoscm` (`pk_id_producto`),
  CONSTRAINT `fk_envio_producto_vehiculo` FOREIGN KEY (`fk_id_vehiculo`) REFERENCES `vehiculo` (`pk_id_vehiculo`),
  CONSTRAINT `fk_envio_ruta` FOREIGN KEY (`fk_id_ruta`) REFERENCES `ruta` (`pk_id_ruta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `envio_producto`
--

LOCK TABLES `envio_producto` WRITE;
/*!40000 ALTER TABLE `envio_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `envio_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado_civil`
--

DROP TABLE IF EXISTS `estado_civil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estado_civil` (
  `pk_id_estado_civil` int NOT NULL,
  `nombre_estado_civil` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_id_estado_civil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado_civil`
--

LOCK TABLES `estado_civil` WRITE;
/*!40000 ALTER TABLE `estado_civil` DISABLE KEYS */;
/*!40000 ALTER TABLE `estado_civil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado_producto`
--

DROP TABLE IF EXISTS `estado_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estado_producto` (
  `pk_id_estado_producto` int NOT NULL AUTO_INCREMENT,
  `nombre_estado_producto` varchar(25) NOT NULL,
  `descripcion_estado_producto` varchar(45) NOT NULL,
  `estado_estado_producto` int NOT NULL,
  PRIMARY KEY (`pk_id_estado_producto`),
  KEY `pk_id_estado_producto` (`pk_id_estado_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado_producto`
--

LOCK TABLES `estado_producto` WRITE;
/*!40000 ALTER TABLE `estado_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `estado_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estadoproduccion`
--

DROP TABLE IF EXISTS `estadoproduccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estadoproduccion` (
  `pk_id_estadoproduccion` int NOT NULL AUTO_INCREMENT,
  `nombre_estadoproduccion` varchar(45) DEFAULT NULL,
  `duracion_estadoproduccion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_id_estadoproduccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estadoproduccion`
--

LOCK TABLES `estadoproduccion` WRITE;
/*!40000 ALTER TABLE `estadoproduccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `estadoproduccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fabrica`
--

DROP TABLE IF EXISTS `fabrica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fabrica` (
  `pk_id_fabrica` int NOT NULL AUTO_INCREMENT,
  `fk_id_municipio` int NOT NULL,
  `dimensiones_fabrica` double(5,2) NOT NULL,
  `direccion_fabrica` varchar(45) NOT NULL,
  `telefono_fabrica` int NOT NULL,
  `descripcion_fabrica` varchar(45) NOT NULL,
  `estado_fabrica` int NOT NULL,
  PRIMARY KEY (`pk_id_fabrica`),
  KEY `pk_id_fabrica` (`pk_id_fabrica`),
  KEY `fk_fabrica_municipio` (`fk_id_municipio`),
  CONSTRAINT `fk_fabrica_municipio` FOREIGN KEY (`fk_id_municipio`) REFERENCES `municipio` (`pk_id_municipio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fabrica`
--

LOCK TABLES `fabrica` WRITE;
/*!40000 ALTER TABLE `fabrica` DISABLE KEYS */;
/*!40000 ALTER TABLE `fabrica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `factura` (
  `pk_idfactura` int NOT NULL,
  `fk_idmodopago` int NOT NULL,
  `fk_idcliente` int NOT NULL,
  `fK_idEMPLEADO` int NOT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`pk_idfactura`),
  KEY `fk_factura_modopago1` (`fk_idmodopago`),
  KEY `fk_factura_cliente1` (`fk_idcliente`),
  KEY `fk_FACTURA_EMPLEADO1` (`fK_idEMPLEADO`),
  CONSTRAINT `fk_factura_cliente1` FOREIGN KEY (`fk_idcliente`) REFERENCES `cliente` (`pk_idcliente`),
  CONSTRAINT `fk_FACTURA_EMPLEADO1` FOREIGN KEY (`fK_idEMPLEADO`) REFERENCES `empleado` (`pk_id_empleado`),
  CONSTRAINT `fk_factura_modopago1` FOREIGN KEY (`fk_idmodopago`) REFERENCES `modo_de_pago` (`pk_idmodopago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `falta`
--

DROP TABLE IF EXISTS `falta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `falta` (
  `pk_id_falta` int NOT NULL,
  `nombre_falta` varchar(45) DEFAULT NULL,
  `descripción_falta` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_id_falta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `falta`
--

LOCK TABLES `falta` WRITE;
/*!40000 ALTER TABLE `falta` DISABLE KEYS */;
/*!40000 ALTER TABLE `falta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `falta_empleado`
--

DROP TABLE IF EXISTS `falta_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `falta_empleado` (
  `pk_id_falta_empleado` int NOT NULL,
  `fk_id_empleado_falta_empleado` int DEFAULT NULL,
  `fk_id_tipo_falta_empleado` int DEFAULT NULL,
  `fecha_falta_empleado` varchar(10) DEFAULT NULL,
  KEY `fk_empleado_falta` (`fk_id_empleado_falta_empleado`),
  KEY `fk_tipo_falta` (`fk_id_tipo_falta_empleado`),
  CONSTRAINT `fk_empleado_falta` FOREIGN KEY (`fk_id_empleado_falta_empleado`) REFERENCES `empleado` (`pk_id_empleado`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_tipo_falta` FOREIGN KEY (`fk_id_tipo_falta_empleado`) REFERENCES `falta` (`pk_id_falta`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `falta_empleado`
--

LOCK TABLES `falta_empleado` WRITE;
/*!40000 ALTER TABLE `falta_empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `falta_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formacion_academica`
--

DROP TABLE IF EXISTS `formacion_academica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `formacion_academica` (
  `pk_id_formacion_academica` int NOT NULL,
  `nombre_formacion_academica` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`pk_id_formacion_academica`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formacion_academica`
--

LOCK TABLES `formacion_academica` WRITE;
/*!40000 ALTER TABLE `formacion_academica` DISABLE KEYS */;
/*!40000 ALTER TABLE `formacion_academica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genero`
--

DROP TABLE IF EXISTS `genero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `genero` (
  `pk_id_genero` int NOT NULL,
  `nombre_genero` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_id_genero`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genero`
--

LOCK TABLES `genero` WRITE;
/*!40000 ALTER TABLE `genero` DISABLE KEYS */;
/*!40000 ALTER TABLE `genero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horaempleado`
--

DROP TABLE IF EXISTS `horaempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `horaempleado` (
  `pk_id_horaempleado` int NOT NULL AUTO_INCREMENT,
  `fk_idempleado_horaempleado` int DEFAULT NULL,
  `tiempo_horaempleado` int DEFAULT NULL,
  `fk_idordenproduccion_horaempleado` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_horaempleado`),
  KEY `fk_HORAEMPLEADO_ORDENPRODUCCION1` (`fk_idordenproduccion_horaempleado`),
  KEY `fk_HORAEMPLEADO_EMPLEADO` (`fk_idempleado_horaempleado`),
  CONSTRAINT `fk_HORAEMPLEADO_EMPLEADO` FOREIGN KEY (`fk_idempleado_horaempleado`) REFERENCES `empleado` (`pk_id_empleado`),
  CONSTRAINT `fk_HORAEMPLEADO_ORDENPRODUCCION1` FOREIGN KEY (`fk_idordenproduccion_horaempleado`) REFERENCES `ordenproduccion` (`pk_id_ordenproduccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horaempleado`
--

LOCK TABLES `horaempleado` WRITE;
/*!40000 ALTER TABLE `horaempleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `horaempleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horario`
--

DROP TABLE IF EXISTS `horario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `horario` (
  `pk_id_horario` int NOT NULL,
  `nombre_horario` varchar(45) DEFAULT NULL,
  `descripcion_horario` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_id_horario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horario`
--

LOCK TABLES `horario` WRITE;
/*!40000 ALTER TABLE `horario` DISABLE KEYS */;
/*!40000 ALTER TABLE `horario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventario`
--

DROP TABLE IF EXISTS `inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventario` (
  `pk_id_inventario` int NOT NULL AUTO_INCREMENT,
  `fk_id_bodega` int NOT NULL,
  `fk_id_producto` int NOT NULL,
  `existencia_inventario` int NOT NULL,
  `estado_inventario` int NOT NULL,
  PRIMARY KEY (`pk_id_inventario`),
  KEY `pk_id_inventario` (`pk_id_inventario`),
  KEY `fk_inventario_producto` (`fk_id_producto`),
  KEY `fk_inventario_bodega` (`fk_id_bodega`),
  CONSTRAINT `fk_inventario_bodega` FOREIGN KEY (`fk_id_bodega`) REFERENCES `bodega` (`pk_id_bodega`),
  CONSTRAINT `fk_inventario_producto` FOREIGN KEY (`fk_id_producto`) REFERENCES `productoscm` (`pk_id_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventario`
--

LOCK TABLES `inventario` WRITE;
/*!40000 ALTER TABLE `inventario` DISABLE KEYS */;
/*!40000 ALTER TABLE `inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventariocrm`
--

DROP TABLE IF EXISTS `inventariocrm`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventariocrm` (
  `pk_idinventario` int NOT NULL,
  `existencia` int DEFAULT NULL,
  `fk_idproducto` int NOT NULL,
  PRIMARY KEY (`pk_idinventario`),
  KEY `fk_inventario_producto1` (`fk_idproducto`),
  CONSTRAINT `fk_inventario_producto1` FOREIGN KEY (`fk_idproducto`) REFERENCES `producto` (`pk_idproducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventariocrm`
--

LOCK TABLES `inventariocrm` WRITE;
/*!40000 ALTER TABLE `inventariocrm` DISABLE KEYS */;
/*!40000 ALTER TABLE `inventariocrm` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventariomrp`
--

DROP TABLE IF EXISTS `inventariomrp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventariomrp` (
  `pk_id_inventario` int NOT NULL AUTO_INCREMENT,
  `fk_idmateriaprimainsumo_inventario` int DEFAULT NULL,
  `fk_idtipoinventario_inventario` int DEFAULT NULL,
  `fecha_inventario` date DEFAULT NULL,
  `cantidad_inventario` int DEFAULT NULL,
  `estado_inventario` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_inventario`),
  KEY `fk_INVENTARIO_MATERIAPRIMAINSUMO` (`fk_idmateriaprimainsumo_inventario`),
  KEY `fk_INVENTARIO_TIPOINVENTARIO` (`fk_idtipoinventario_inventario`),
  CONSTRAINT `fk_INVENTARIO_MATERIAPRIMAINSUMO` FOREIGN KEY (`fk_idmateriaprimainsumo_inventario`) REFERENCES `materiaprimainsumo` (`pk_id_materiaprimainsumo`),
  CONSTRAINT `fk_INVENTARIO_TIPOINVENTARIO` FOREIGN KEY (`fk_idtipoinventario_inventario`) REFERENCES `tipoinventario` (`pk_id_tipoinventario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventariomrp`
--

LOCK TABLES `inventariomrp` WRITE;
/*!40000 ALTER TABLE `inventariomrp` DISABLE KEYS */;
/*!40000 ALTER TABLE `inventariomrp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `licencia_conduccion`
--

DROP TABLE IF EXISTS `licencia_conduccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `licencia_conduccion` (
  `pk_id_licencia_conduccion` int NOT NULL,
  `tipo_licencia_conduccion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_id_licencia_conduccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `licencia_conduccion`
--

LOCK TABLES `licencia_conduccion` WRITE;
/*!40000 ALTER TABLE `licencia_conduccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `licencia_conduccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `linea_producto`
--

DROP TABLE IF EXISTS `linea_producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `linea_producto` (
  `pk_id_linea_producto` int NOT NULL AUTO_INCREMENT,
  `nombre_linea_producto` varchar(25) NOT NULL,
  `descripcion_linea_producto` varchar(50) NOT NULL,
  `estado_linea_producto` int NOT NULL,
  PRIMARY KEY (`pk_id_linea_producto`),
  KEY `pk_id_linea_producto` (`pk_id_linea_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `linea_producto`
--

LOCK TABLES `linea_producto` WRITE;
/*!40000 ALTER TABLE `linea_producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `linea_producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `login` (
  `pk_id_login` int NOT NULL AUTO_INCREMENT,
  `usuario_login` varchar(45) DEFAULT NULL,
  `contraseña_login` varchar(45) DEFAULT NULL,
  `nombreCompleto_login` varchar(100) DEFAULT NULL,
  `estado_login` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_login`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES (1,'sistema','bi0PL96rbxVRPKJQsLJJAg==','Usuario de prueba',1),(2,'bjsican','0FOYy5u5h0djKjzCYqfvkg==','Billy Sican',1),(3,'bmaza','xTfsC3/XR/CVyDvNr1Fs+g==','Bryan Mazariegos',1),(4,'jsican','jsican','Jeshua Sican',0),(5,'jmorataya','123','Julio Morataya',0);
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `marca` (
  `pk_id_marca` int NOT NULL AUTO_INCREMENT,
  `descripcion_marca` varchar(45) NOT NULL,
  `estado_marca` int NOT NULL,
  PRIMARY KEY (`pk_id_marca`),
  KEY `pk_id_marca` (`pk_id_marca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materiaprimainsumo`
--

DROP TABLE IF EXISTS `materiaprimainsumo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materiaprimainsumo` (
  `pk_id_materiaprimainsumo` int NOT NULL AUTO_INCREMENT,
  `nombre_materiaprimainsumo` varchar(45) DEFAULT NULL,
  `descripcion_materiaprimainsumo` varchar(45) DEFAULT NULL,
  `marca_materiaprimainsumo` varchar(45) DEFAULT NULL,
  `estado_materiaprimainsumo` tinyint(1) DEFAULT NULL,
  `precio_materiaprimainsumo` double DEFAULT NULL,
  PRIMARY KEY (`pk_id_materiaprimainsumo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materiaprimainsumo`
--

LOCK TABLES `materiaprimainsumo` WRITE;
/*!40000 ALTER TABLE `materiaprimainsumo` DISABLE KEYS */;
/*!40000 ALTER TABLE `materiaprimainsumo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mayor_detalle`
--

DROP TABLE IF EXISTS `mayor_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mayor_detalle` (
  `pk_idmayorencabezado` int NOT NULL,
  `pk_polizaencabezado` int NOT NULL,
  `subtotal_mayor_detalle` double DEFAULT NULL,
  PRIMARY KEY (`pk_idmayorencabezado`),
  KEY `fk_mayorencabezado_polizaencabezado` (`pk_polizaencabezado`),
  CONSTRAINT `fk_mayorencabezado_detallemayor` FOREIGN KEY (`pk_idmayorencabezado`) REFERENCES `mayor_encabezado` (`pk_idmayorencabezado`),
  CONSTRAINT `fk_mayorencabezado_polizaencabezado` FOREIGN KEY (`pk_polizaencabezado`) REFERENCES `diario_encabezado` (`pk_polizaencabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mayor_detalle`
--

LOCK TABLES `mayor_detalle` WRITE;
/*!40000 ALTER TABLE `mayor_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `mayor_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mayor_encabezado`
--

DROP TABLE IF EXISTS `mayor_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mayor_encabezado` (
  `pk_idmayorencabezado` int NOT NULL,
  `pk_idcuenta` int NOT NULL,
  `montoDebe_mayor_encabezado` double DEFAULT NULL,
  `montoHaber_mayor_encabezado` double DEFAULT NULL,
  `fecha_mayor_encabezado` datetime DEFAULT NULL,
  PRIMARY KEY (`pk_idmayorencabezado`),
  KEY `fk_mayorencabezado_cuenta` (`pk_idcuenta`),
  CONSTRAINT `fk_mayorencabezado_cuenta` FOREIGN KEY (`pk_idcuenta`) REFERENCES `cuenta_contable` (`pk_idcuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mayor_encabezado`
--

LOCK TABLES `mayor_encabezado` WRITE;
/*!40000 ALTER TABLE `mayor_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `mayor_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modo_de_pago`
--

DROP TABLE IF EXISTS `modo_de_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `modo_de_pago` (
  `pk_idmodopago` int NOT NULL,
  `tipo_pago` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_idmodopago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modo_de_pago`
--

LOCK TABLES `modo_de_pago` WRITE;
/*!40000 ALTER TABLE `modo_de_pago` DISABLE KEYS */;
/*!40000 ALTER TABLE `modo_de_pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modulo`
--

DROP TABLE IF EXISTS `modulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `modulo` (
  `pk_id_modulo` int NOT NULL AUTO_INCREMENT,
  `nombre_modulo` varchar(30) NOT NULL,
  `descripcion_modulo` varchar(50) NOT NULL,
  `estado_modulo` int NOT NULL,
  PRIMARY KEY (`pk_id_modulo`),
  KEY `pk_id_modulo` (`pk_id_modulo`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modulo`
--

LOCK TABLES `modulo` WRITE;
/*!40000 ALTER TABLE `modulo` DISABLE KEYS */;
INSERT INTO `modulo` VALUES (1,'Seguridad','Aplicaciones de seguridad',1),(2,'Consultas','Consultas Inteligentes',1),(3,'Reporteador','Aplicaciones de Reporteador',1),(4,'HRM','Aplicaciones de Recursos Humanos',1),(5,'FRM','Aplicaciones de Finanzas',1),(6,'SCM','Aplicaciones Control de Inventario',1),(7,'MRP','Aplicaciones de Produccion',1),(8,'CRM','Aplicaciones de Ventas',1);
/*!40000 ALTER TABLE `modulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_inventario`
--

DROP TABLE IF EXISTS `movimiento_inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimiento_inventario` (
  `pk_id_movimiento_inventario` int NOT NULL,
  `fecha_movimiento_inventario` datetime NOT NULL,
  `fk_id_tipo_movimiento` int NOT NULL,
  PRIMARY KEY (`pk_id_movimiento_inventario`),
  KEY `pk_id_movimiento_inventario` (`pk_id_movimiento_inventario`),
  KEY `fk_mov_inventario_tipo` (`fk_id_tipo_movimiento`),
  CONSTRAINT `fk_mov_inventario_tipo` FOREIGN KEY (`fk_id_tipo_movimiento`) REFERENCES `tipo_movimiento` (`pk_id_tipo_movimiento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_inventario`
--

LOCK TABLES `movimiento_inventario` WRITE;
/*!40000 ALTER TABLE `movimiento_inventario` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimiento_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_inventario_detalle`
--

DROP TABLE IF EXISTS `movimiento_inventario_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimiento_inventario_detalle` (
  `pk_id_movimiento_inventario_detalle` int NOT NULL,
  `fk_id_movimiento_inventario` int NOT NULL,
  `fk_id_producto` int NOT NULL,
  `cantidad` int NOT NULL,
  `origen` varchar(35) NOT NULL,
  `destino` varchar(35) NOT NULL,
  PRIMARY KEY (`pk_id_movimiento_inventario_detalle`),
  KEY `pk_id_movimiento_inventario_detalle` (`pk_id_movimiento_inventario_detalle`),
  KEY `fk_mov_inventario_detalle_mov` (`fk_id_movimiento_inventario`),
  KEY `fk_mov_inventario_detalle_producto` (`fk_id_producto`),
  CONSTRAINT `fk_mov_inventario_detalle_mov` FOREIGN KEY (`fk_id_movimiento_inventario`) REFERENCES `movimiento_inventario` (`pk_id_movimiento_inventario`),
  CONSTRAINT `fk_mov_inventario_detalle_producto` FOREIGN KEY (`fk_id_producto`) REFERENCES `productoscm` (`pk_id_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_inventario_detalle`
--

LOCK TABLES `movimiento_inventario_detalle` WRITE;
/*!40000 ALTER TABLE `movimiento_inventario_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimiento_inventario_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `municipio`
--

DROP TABLE IF EXISTS `municipio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `municipio` (
  `pk_id_municipio` int NOT NULL AUTO_INCREMENT,
  `fk_id_departamento` int NOT NULL,
  `nombre_municipio` varchar(30) NOT NULL,
  `descripcion_municipio` varchar(45) NOT NULL,
  `estado_municipio` int NOT NULL,
  PRIMARY KEY (`pk_id_municipio`),
  KEY `pk_id_municipio` (`pk_id_municipio`),
  KEY `fk_municipio_departamento` (`fk_id_departamento`),
  CONSTRAINT `fk_municipio_departamento` FOREIGN KEY (`fk_id_departamento`) REFERENCES `departamento` (`pk_id_departamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `municipio`
--

LOCK TABLES `municipio` WRITE;
/*!40000 ALTER TABLE `municipio` DISABLE KEYS */;
/*!40000 ALTER TABLE `municipio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordencompra`
--

DROP TABLE IF EXISTS `ordencompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordencompra` (
  `pk_id_ordencompra` int NOT NULL AUTO_INCREMENT,
  `fk_idmateriaprimainsumos_ordencompra` int DEFAULT NULL,
  `fechaenvio_ordencompra` date DEFAULT NULL,
  `cantidad_ordencompra` int DEFAULT NULL,
  `estado_ordencompra` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pk_id_ordencompra`),
  KEY `fk_ORDENCOMPRA_MATERIAPRIMAINSUMO` (`fk_idmateriaprimainsumos_ordencompra`),
  CONSTRAINT `fk_ORDENCOMPRA_MATERIAPRIMAINSUMO` FOREIGN KEY (`fk_idmateriaprimainsumos_ordencompra`) REFERENCES `materiaprimainsumo` (`pk_id_materiaprimainsumo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordencompra`
--

LOCK TABLES `ordencompra` WRITE;
/*!40000 ALTER TABLE `ordencompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `ordencompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordenproduccion`
--

DROP TABLE IF EXISTS `ordenproduccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordenproduccion` (
  `pk_id_ordenproduccion` int NOT NULL AUTO_INCREMENT,
  `fk_idtipoproducto_idordenproduccion` int DEFAULT NULL,
  `cantidad_ordenproduccion` int DEFAULT NULL,
  `fecha_ordenproduccion` varchar(45) DEFAULT NULL,
  `estado_ordenproduccion` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pk_id_ordenproduccion`),
  KEY `fk_ORDENPRODUCCION_TIPOINVENTARIO` (`fk_idtipoproducto_idordenproduccion`),
  CONSTRAINT `fk_ORDENPRODUCCION_TIPOINVENTARIO` FOREIGN KEY (`fk_idtipoproducto_idordenproduccion`) REFERENCES `tipoinventario` (`pk_id_tipoinventario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordenproduccion`
--

LOCK TABLES `ordenproduccion` WRITE;
/*!40000 ALTER TABLE `ordenproduccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `ordenproduccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pais`
--

DROP TABLE IF EXISTS `pais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pais` (
  `pk_id_pais` int NOT NULL AUTO_INCREMENT,
  `nombre_pais` varchar(40) NOT NULL,
  `capital_pais` varchar(40) NOT NULL,
  `estado_pais` int NOT NULL,
  PRIMARY KEY (`pk_id_pais`),
  KEY `pk_id_pais` (`pk_id_pais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pais`
--

LOCK TABLES `pais` WRITE;
/*!40000 ALTER TABLE `pais` DISABLE KEYS */;
/*!40000 ALTER TABLE `pais` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido_detalle`
--

DROP TABLE IF EXISTS `pedido_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido_detalle` (
  `fk_id_pedido_encabezado` int NOT NULL,
  `cod_linea_pedido_detalle` int NOT NULL,
  `fk_id_producto` int NOT NULL,
  `cantidad_pedido_detalle` int NOT NULL,
  `precio_unitario_pedido_detalle` double(8,2) NOT NULL,
  `subtotal_pedido_detalle` double(12,2) NOT NULL,
  `estado_pedido_detalle` int NOT NULL,
  PRIMARY KEY (`fk_id_pedido_encabezado`,`cod_linea_pedido_detalle`),
  KEY `fk_id_pedido_encabezado` (`fk_id_pedido_encabezado`,`cod_linea_pedido_detalle`),
  KEY `fk_pedido_producto` (`fk_id_producto`),
  CONSTRAINT `fk_encabezado_pedido` FOREIGN KEY (`fk_id_pedido_encabezado`) REFERENCES `pedido_encabezado` (`pk_id_pedido_encabezado`),
  CONSTRAINT `fk_pedido_producto` FOREIGN KEY (`fk_id_producto`) REFERENCES `productoscm` (`pk_id_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido_detalle`
--

LOCK TABLES `pedido_detalle` WRITE;
/*!40000 ALTER TABLE `pedido_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedido_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido_encabezado`
--

DROP TABLE IF EXISTS `pedido_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido_encabezado` (
  `pk_id_pedido_encabezado` int NOT NULL,
  `fk_id_fabrica` int NOT NULL,
  `fec_pedido_pedido_encabezado` datetime NOT NULL,
  `total_pedido_encabezado` double(12,2) NOT NULL,
  `estado_pedido_encabezado` int NOT NULL,
  PRIMARY KEY (`pk_id_pedido_encabezado`),
  KEY `pk_id_pedido_encabezado` (`pk_id_pedido_encabezado`),
  KEY `fk_pedido_fabrica` (`fk_id_fabrica`),
  CONSTRAINT `fk_pedido_fabrica` FOREIGN KEY (`fk_id_fabrica`) REFERENCES `fabrica` (`pk_id_fabrica`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido_encabezado`
--

LOCK TABLES `pedido_encabezado` WRITE;
/*!40000 ALTER TABLE `pedido_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedido_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `percepcion`
--

DROP TABLE IF EXISTS `percepcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `percepcion` (
  `pk_id_percepcion` int NOT NULL,
  `nombre_percepcion` varchar(45) DEFAULT NULL,
  `monto_percepcion` double DEFAULT NULL,
  `descripcion_percepcion` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`pk_id_percepcion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `percepcion`
--

LOCK TABLES `percepcion` WRITE;
/*!40000 ALTER TABLE `percepcion` DISABLE KEYS */;
/*!40000 ALTER TABLE `percepcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil`
--

DROP TABLE IF EXISTS `perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfil` (
  `pk_id_perfil` int NOT NULL AUTO_INCREMENT,
  `nombre_perfil` varchar(50) DEFAULT NULL,
  `descripcion_perfil` varchar(100) DEFAULT NULL,
  `estado_perfil` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil`
--

LOCK TABLES `perfil` WRITE;
/*!40000 ALTER TABLE `perfil` DISABLE KEYS */;
INSERT INTO `perfil` VALUES (1,'Admin','Administracion del programa',1),(2,'Sistema','Administrador del sistema',1),(3,'Digitador','Digitador para Cuentas',1),(4,'Consultor','Unicamente consultas ',1),(5,'Reportes','Ingreso y consultas de reportes',1),(6,'Pruebas','pruebas',1);
/*!40000 ALTER TABLE `perfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil_usuario`
--

DROP TABLE IF EXISTS `perfil_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfil_usuario` (
  `pk_id_perfil_usuario` int NOT NULL AUTO_INCREMENT,
  `fk_idusuario_perfil_usuario` int DEFAULT NULL,
  `fk_idperfil_perfil_usuario` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_perfil_usuario`),
  KEY `fk_perfil_usuario_login` (`fk_idusuario_perfil_usuario`),
  KEY `fk_perfil_usuario_perfil` (`fk_idperfil_perfil_usuario`),
  CONSTRAINT `fk_perfil_usuario_login` FOREIGN KEY (`fk_idusuario_perfil_usuario`) REFERENCES `login` (`pk_id_login`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_perfil_usuario_perfil` FOREIGN KEY (`fk_idperfil_perfil_usuario`) REFERENCES `perfil` (`pk_id_perfil`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil_usuario`
--

LOCK TABLES `perfil_usuario` WRITE;
/*!40000 ALTER TABLE `perfil_usuario` DISABLE KEYS */;
INSERT INTO `perfil_usuario` VALUES (1,1,1),(2,3,3),(4,4,1),(5,5,5);
/*!40000 ALTER TABLE `perfil_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permiso`
--

DROP TABLE IF EXISTS `permiso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permiso` (
  `pk_id_permiso` int NOT NULL AUTO_INCREMENT,
  `insertar_permiso` tinyint(1) DEFAULT NULL,
  `modificar_permiso` tinyint(1) DEFAULT NULL,
  `eliminar_permiso` tinyint(1) DEFAULT NULL,
  `consultar_permiso` tinyint(1) DEFAULT NULL,
  `imprimir_permiso` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pk_id_permiso`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permiso`
--

LOCK TABLES `permiso` WRITE;
/*!40000 ALTER TABLE `permiso` DISABLE KEYS */;
INSERT INTO `permiso` VALUES (1,1,1,1,1,1),(2,1,0,0,1,1),(3,1,1,1,0,0),(4,1,1,1,1,1),(5,1,1,1,1,1),(6,1,1,1,1,1),(7,1,1,1,1,1),(8,1,0,1,0,0),(9,1,1,0,0,0),(10,1,1,0,0,0),(11,1,1,1,1,1),(12,0,0,0,1,0),(13,0,0,0,1,0),(14,0,0,0,0,0),(15,1,0,0,1,0),(16,0,0,0,0,0),(17,1,1,0,0,0);
/*!40000 ALTER TABLE `permiso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `presupuesto`
--

DROP TABLE IF EXISTS `presupuesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `presupuesto` (
  `pk_idpresupuesto` int NOT NULL,
  `nombre_presupuesto` varchar(45) DEFAULT NULL,
  `cantidad_presupuesto` double DEFAULT NULL,
  `fk_idtipomoneda` int NOT NULL,
  `fk_area` int NOT NULL,
  `descripcion_presupuesto` varchar(75) DEFAULT NULL,
  `estado_presupuesto` tinyint DEFAULT NULL,
  PRIMARY KEY (`pk_idpresupuesto`),
  KEY `fk_presupuesto_tipomoneda` (`fk_idtipomoneda`),
  KEY `fk_presupuesto_area` (`fk_area`),
  CONSTRAINT `fk_presupuesto_area` FOREIGN KEY (`fk_area`) REFERENCES `area` (`pk_idarea`),
  CONSTRAINT `fk_presupuesto_tipomoneda` FOREIGN KEY (`fk_idtipomoneda`) REFERENCES `tipo_moneda` (`pk_idtipomoneda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `presupuesto`
--

LOCK TABLES `presupuesto` WRITE;
/*!40000 ALTER TABLE `presupuesto` DISABLE KEYS */;
/*!40000 ALTER TABLE `presupuesto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `pk_idproducto` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `precio` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `fk_idcategoriatamaño` int NOT NULL,
  `fk_idcategoriatipo` int NOT NULL,
  PRIMARY KEY (`pk_idproducto`),
  KEY `fk_producto_categoriatamaño1` (`fk_idcategoriatamaño`),
  KEY `fk_producto_categoriatipo1` (`fk_idcategoriatipo`),
  CONSTRAINT `fk_producto_categoriatamaño1` FOREIGN KEY (`fk_idcategoriatamaño`) REFERENCES `categoria_tamaño` (`pk_idcategoriatamaño`),
  CONSTRAINT `fk_producto_categoriatipo1` FOREIGN KEY (`fk_idcategoriatipo`) REFERENCES `categoria_tipo` (`pk_idcategoriatipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productodetalle`
--

DROP TABLE IF EXISTS `productodetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productodetalle` (
  `pk_id_productodetalle` int NOT NULL AUTO_INCREMENT,
  `fk_idtipoproductoencabezado_productodetalle` int DEFAULT NULL,
  `fk_idmateriaprimainsumo_productodetalle` int DEFAULT NULL,
  `cantidad_productodetalle` int DEFAULT NULL,
  `estado_productodetalle` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_productodetalle`),
  KEY `fk_PRODUCTODETALLE_TIPOPRODUCTOENCABEZADO` (`fk_idtipoproductoencabezado_productodetalle`),
  KEY `fk_PRODUCTODETALLE_MATERIAPRIMAINSUMO` (`fk_idmateriaprimainsumo_productodetalle`),
  CONSTRAINT `fk_PRODUCTODETALLE_MATERIAPRIMAINSUMO` FOREIGN KEY (`fk_idmateriaprimainsumo_productodetalle`) REFERENCES `materiaprimainsumo` (`pk_id_materiaprimainsumo`),
  CONSTRAINT `fk_PRODUCTODETALLE_TIPOPRODUCTOENCABEZADO` FOREIGN KEY (`fk_idtipoproductoencabezado_productodetalle`) REFERENCES `tipoproductoencabezado` (`pk_id_tipoproductoencabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productodetalle`
--

LOCK TABLES `productodetalle` WRITE;
/*!40000 ALTER TABLE `productodetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `productodetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productoscm`
--

DROP TABLE IF EXISTS `productoscm`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productoscm` (
  `pk_id_producto` int NOT NULL AUTO_INCREMENT,
  `fk_id_linea_producto` int NOT NULL,
  `fk_id_categoria_producto` int NOT NULL,
  `nombre_producto` varchar(50) NOT NULL,
  `precio_producto` double(12,2) NOT NULL,
  `medida_producto` double(5,2) NOT NULL,
  `descripcion_producto` varchar(45) NOT NULL,
  `estado_producto` int NOT NULL,
  PRIMARY KEY (`pk_id_producto`),
  KEY `pk_id_producto` (`pk_id_producto`),
  KEY `fk_producto_lineaProducto` (`fk_id_linea_producto`),
  KEY `fk_producto_categoriaProducto` (`fk_id_categoria_producto`),
  CONSTRAINT `fk_producto_categoriaProducto` FOREIGN KEY (`fk_id_categoria_producto`) REFERENCES `categoria_producto` (`pk_id_categoria_producto`),
  CONSTRAINT `fk_producto_lineaProducto` FOREIGN KEY (`fk_id_linea_producto`) REFERENCES `linea_producto` (`pk_id_linea_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productoscm`
--

LOCK TABLES `productoscm` WRITE;
/*!40000 ALTER TABLE `productoscm` DISABLE KEYS */;
/*!40000 ALTER TABLE `productoscm` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `propietario`
--

DROP TABLE IF EXISTS `propietario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `propietario` (
  `pk_idpropietario` int NOT NULL,
  `nombre_propietario` varchar(45) DEFAULT NULL,
  `descripcion_propietario` varchar(75) DEFAULT NULL,
  `estado_propietario` tinyint DEFAULT NULL,
  PRIMARY KEY (`pk_idpropietario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `propietario`
--

LOCK TABLES `propietario` WRITE;
/*!40000 ALTER TABLE `propietario` DISABLE KEYS */;
/*!40000 ALTER TABLE `propietario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `pk_id_proveedor` int NOT NULL AUTO_INCREMENT,
  `fk_id_pais` int NOT NULL,
  `razon_social_proveedor` varchar(45) NOT NULL,
  `representante_legal_proveedor` varchar(45) NOT NULL,
  `nit_proveedor` varchar(20) NOT NULL,
  `estado_proveedor` int NOT NULL,
  PRIMARY KEY (`pk_id_proveedor`),
  KEY `pk_id_proveedor` (`pk_id_proveedor`),
  KEY `fk_proveedor_pais` (`fk_id_pais`),
  CONSTRAINT `fk_proveedor_pais` FOREIGN KEY (`fk_id_pais`) REFERENCES `pais` (`pk_id_pais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `puesto`
--

DROP TABLE IF EXISTS `puesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `puesto` (
  `pk_id_puesto` int NOT NULL,
  `nombre_puesto` varchar(45) DEFAULT NULL,
  `salario_puesto` double DEFAULT NULL,
  `fk_id_horario_puesto` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_puesto`),
  KEY `fk_horario_puesto` (`fk_id_horario_puesto`),
  CONSTRAINT `fk_horario_puesto` FOREIGN KEY (`fk_id_horario_puesto`) REFERENCES `horario` (`pk_id_horario`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `puesto`
--

LOCK TABLES `puesto` WRITE;
/*!40000 ALTER TABLE `puesto` DISABLE KEYS */;
/*!40000 ALTER TABLE `puesto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reclutamiento`
--

DROP TABLE IF EXISTS `reclutamiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reclutamiento` (
  `pk_id_reclutamiento` int NOT NULL,
  `fk_id_empleado_reclutamiento` int DEFAULT NULL,
  `fk_id_formacion_academica_reclutamiento` int DEFAULT NULL,
  `nombre1_reclutamiento` varchar(45) DEFAULT NULL,
  `nombre2_reclutamiento` varchar(45) DEFAULT NULL,
  `apellido1_reclutamiento` varchar(45) DEFAULT NULL,
  `apellido2_reclutamiento` varchar(45) DEFAULT NULL,
  `fecha_nacimiento_reclutamiento` varchar(10) DEFAULT NULL,
  `dpi_reclutamiento` int DEFAULT NULL,
  `fk_id_genero_reclutamiento` int DEFAULT NULL,
  `fk_id_estado_civil_reclutamiento` int DEFAULT NULL,
  `email_reclutamiento` varchar(125) DEFAULT NULL,
  `telefono_reclutamiento` int DEFAULT NULL,
  `numero_igss_reclutamiento` int DEFAULT NULL,
  `fk_id_licencia_conducir_reclutamiento` int DEFAULT NULL,
  `fk_id_puesto_reclutamiento` int DEFAULT NULL,
  `estado_reclutado_entrevista` int DEFAULT NULL,
  `fk_id_departamento_empresarial_reclutamiento` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_reclutamiento`),
  KEY `fk_empleado_reclutamiento` (`fk_id_empleado_reclutamiento`),
  KEY `fk_formacion_academica_reclutamiento` (`fk_id_formacion_academica_reclutamiento`),
  KEY `fk_genero_reclutamiento` (`fk_id_genero_reclutamiento`),
  KEY `fk_estado_civil_reclutamiento` (`fk_id_estado_civil_reclutamiento`),
  KEY `fk_licencia_conducir_reclutamiento` (`fk_id_licencia_conducir_reclutamiento`),
  KEY `fk_puesto_reclutamiento` (`fk_id_puesto_reclutamiento`),
  KEY `fk_departamento_empresarial_reclutamiento` (`fk_id_departamento_empresarial_reclutamiento`),
  CONSTRAINT `fk_departamento_empresarial_reclutamiento` FOREIGN KEY (`fk_id_departamento_empresarial_reclutamiento`) REFERENCES `departamento_empresarial` (`pk_id__departamento_empresarial`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_empleado_reclutamiento` FOREIGN KEY (`fk_id_empleado_reclutamiento`) REFERENCES `empleado` (`pk_id_empleado`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_estado_civil_reclutamiento` FOREIGN KEY (`fk_id_estado_civil_reclutamiento`) REFERENCES `estado_civil` (`pk_id_estado_civil`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_formacion_academica_reclutamiento` FOREIGN KEY (`fk_id_formacion_academica_reclutamiento`) REFERENCES `formacion_academica` (`pk_id_formacion_academica`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_genero_reclutamiento` FOREIGN KEY (`fk_id_genero_reclutamiento`) REFERENCES `genero` (`pk_id_genero`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_licencia_conducir_reclutamiento` FOREIGN KEY (`fk_id_licencia_conducir_reclutamiento`) REFERENCES `licencia_conduccion` (`pk_id_licencia_conduccion`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_puesto_reclutamiento` FOREIGN KEY (`fk_id_puesto_reclutamiento`) REFERENCES `puesto` (`pk_id_puesto`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reclutamiento`
--

LOCK TABLES `reclutamiento` WRITE;
/*!40000 ALTER TABLE `reclutamiento` DISABLE KEYS */;
/*!40000 ALTER TABLE `reclutamiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporte`
--

DROP TABLE IF EXISTS `reporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reporte` (
  `pk_id_reporte` int NOT NULL AUTO_INCREMENT,
  `nombre_reporte` varchar(40) NOT NULL,
  `ruta_reporte` varchar(100) NOT NULL,
  `estado_reporte` int NOT NULL,
  PRIMARY KEY (`pk_id_reporte`),
  KEY `pk_id_reporte` (`pk_id_reporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte`
--

LOCK TABLES `reporte` WRITE;
/*!40000 ALTER TABLE `reporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `reporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporte_aplicativo`
--

DROP TABLE IF EXISTS `reporte_aplicativo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reporte_aplicativo` (
  `fk_id_reporte` int NOT NULL,
  `fk_id_aplicacion` int NOT NULL,
  `fk_id_modulo` int NOT NULL,
  `estado_reporte_aplicativo` int NOT NULL,
  PRIMARY KEY (`fk_id_reporte`,`fk_id_aplicacion`,`fk_id_modulo`),
  KEY `fk_id_reporte` (`fk_id_reporte`,`fk_id_aplicacion`,`fk_id_modulo`),
  KEY `fk_reporte_aplicativo_modulo` (`fk_id_modulo`),
  KEY `fk_report_aplicativo` (`fk_id_aplicacion`),
  CONSTRAINT `fk_report_aplicativo` FOREIGN KEY (`fk_id_aplicacion`) REFERENCES `aplicacion` (`pk_id_aplicacion`),
  CONSTRAINT `fk_reporte_aplicativo_modulo` FOREIGN KEY (`fk_id_modulo`) REFERENCES `modulo` (`pk_id_modulo`),
  CONSTRAINT `fk_reporte_aplicativo_reporte` FOREIGN KEY (`fk_id_reporte`) REFERENCES `reporte` (`pk_id_reporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte_aplicativo`
--

LOCK TABLES `reporte_aplicativo` WRITE;
/*!40000 ALTER TABLE `reporte_aplicativo` DISABLE KEYS */;
/*!40000 ALTER TABLE `reporte_aplicativo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporte_modulo`
--

DROP TABLE IF EXISTS `reporte_modulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reporte_modulo` (
  `fk_id_reporte` int NOT NULL,
  `fk_id_modulo` int NOT NULL,
  `estado_reporte_modulo` int NOT NULL,
  PRIMARY KEY (`fk_id_reporte`,`fk_id_modulo`),
  KEY `fk_id_reporte` (`fk_id_reporte`,`fk_id_modulo`),
  KEY `fk_reporte_de_modulo_reportes` (`fk_id_modulo`),
  CONSTRAINT `fk_reporte_de_modulo` FOREIGN KEY (`fk_id_reporte`) REFERENCES `reporte` (`pk_id_reporte`),
  CONSTRAINT `fk_reporte_de_modulo_reportes` FOREIGN KEY (`fk_id_modulo`) REFERENCES `modulo` (`pk_id_modulo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte_modulo`
--

LOCK TABLES `reporte_modulo` WRITE;
/*!40000 ALTER TABLE `reporte_modulo` DISABLE KEYS */;
/*!40000 ALTER TABLE `reporte_modulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ruta`
--

DROP TABLE IF EXISTS `ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ruta` (
  `pk_id_ruta` int NOT NULL AUTO_INCREMENT,
  `origen_ruta` int NOT NULL,
  `destino_ruta` int NOT NULL,
  `descripcion_ruta` varchar(45) NOT NULL,
  `estado_ruta` int NOT NULL,
  PRIMARY KEY (`pk_id_ruta`),
  KEY `pk_id_ruta` (`pk_id_ruta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
/*!40000 ALTER TABLE `ruta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saldo_historico`
--

DROP TABLE IF EXISTS `saldo_historico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `saldo_historico` (
  `pk_idcuenta` int NOT NULL,
  `fecha_saldo_historico` datetime NOT NULL,
  `monto_saldo_historico` double DEFAULT NULL,
  PRIMARY KEY (`pk_idcuenta`),
  CONSTRAINT `fk_saldo_cuenta` FOREIGN KEY (`pk_idcuenta`) REFERENCES `cuenta_contable` (`pk_idcuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saldo_historico`
--

LOCK TABLES `saldo_historico` WRITE;
/*!40000 ALTER TABLE `saldo_historico` DISABLE KEYS */;
/*!40000 ALTER TABLE `saldo_historico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sucursal`
--

DROP TABLE IF EXISTS `sucursal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sucursal` (
  `pk_id_sucursal` int NOT NULL AUTO_INCREMENT,
  `fk_id_municipio` int NOT NULL,
  `nombre_sucursal` varchar(45) NOT NULL,
  `direccion_sucursal` varchar(45) NOT NULL,
  `telefono_sucursal` int NOT NULL,
  `descripcion_sucursal` varchar(45) NOT NULL,
  `estado_sucursal` int NOT NULL,
  PRIMARY KEY (`pk_id_sucursal`),
  KEY `pk_id_sucursal` (`pk_id_sucursal`),
  KEY `fk_sucursal_municipio` (`fk_id_municipio`),
  CONSTRAINT `fk_sucursal_municipio` FOREIGN KEY (`fk_id_municipio`) REFERENCES `municipio` (`pk_id_municipio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursal`
--

LOCK TABLES `sucursal` WRITE;
/*!40000 ALTER TABLE `sucursal` DISABLE KEYS */;
/*!40000 ALTER TABLE `sucursal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefono_cliente`
--

DROP TABLE IF EXISTS `telefono_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `telefono_cliente` (
  `pk_idtelefono` int NOT NULL,
  `Numero_Telefono` varchar(8) DEFAULT NULL,
  `fk_idcliente` int NOT NULL,
  PRIMARY KEY (`pk_idtelefono`),
  KEY `fk_telefono_cliente1` (`fk_idcliente`),
  CONSTRAINT `fk_telefono_cliente1` FOREIGN KEY (`fk_idcliente`) REFERENCES `cliente` (`pk_idcliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefono_cliente`
--

LOCK TABLES `telefono_cliente` WRITE;
/*!40000 ALTER TABLE `telefono_cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `telefono_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefono_proveedor`
--

DROP TABLE IF EXISTS `telefono_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `telefono_proveedor` (
  `pk_id_telefono_proveedor` int NOT NULL AUTO_INCREMENT,
  `fk_id_proveedor` int NOT NULL,
  `telefono_telefono_proveedor` varchar(20) NOT NULL,
  PRIMARY KEY (`pk_id_telefono_proveedor`),
  KEY `pk_id_telefono_proveedor` (`pk_id_telefono_proveedor`),
  KEY `fk_proveedor_telefono` (`fk_id_proveedor`),
  CONSTRAINT `fk_proveedor_telefono` FOREIGN KEY (`fk_id_proveedor`) REFERENCES `proveedor` (`pk_id_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefono_proveedor`
--

LOCK TABLES `telefono_proveedor` WRITE;
/*!40000 ALTER TABLE `telefono_proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `telefono_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_competencia`
--

DROP TABLE IF EXISTS `tipo_competencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_competencia` (
  `pk_id_competencia` int NOT NULL,
  `nombre_competencia` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`pk_id_competencia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_competencia`
--

LOCK TABLES `tipo_competencia` WRITE;
/*!40000 ALTER TABLE `tipo_competencia` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_competencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_contrato`
--

DROP TABLE IF EXISTS `tipo_contrato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_contrato` (
  `pk_id_tipo_contrato` int NOT NULL,
  `nombre_tipo_contrato` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_id_tipo_contrato`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_contrato`
--

LOCK TABLES `tipo_contrato` WRITE;
/*!40000 ALTER TABLE `tipo_contrato` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_contrato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_entrevista`
--

DROP TABLE IF EXISTS `tipo_entrevista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_entrevista` (
  `pk_id_tipo_entrevista` int NOT NULL,
  `nombre_tipo_entrevista` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_id_tipo_entrevista`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_entrevista`
--

LOCK TABLES `tipo_entrevista` WRITE;
/*!40000 ALTER TABLE `tipo_entrevista` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_entrevista` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_moneda`
--

DROP TABLE IF EXISTS `tipo_moneda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_moneda` (
  `pk_idtipomoneda` int NOT NULL,
  `moneda_tipo_moneda` varchar(45) DEFAULT NULL,
  `simbolo_tipo_moneda` varchar(2) DEFAULT NULL,
  `descripcion_tipo_moneda` varchar(75) DEFAULT NULL,
  `estado_tipo_moneda` tinyint DEFAULT NULL,
  PRIMARY KEY (`pk_idtipomoneda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_moneda`
--

LOCK TABLES `tipo_moneda` WRITE;
/*!40000 ALTER TABLE `tipo_moneda` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_moneda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_movimiento`
--

DROP TABLE IF EXISTS `tipo_movimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_movimiento` (
  `pk_id_tipo_movimiento` int NOT NULL,
  `nombre_tipo_movimiento` varchar(45) NOT NULL,
  `signo_tipo` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`pk_id_tipo_movimiento`),
  KEY `pk_id_tipo_movimiento` (`pk_id_tipo_movimiento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_movimiento`
--

LOCK TABLES `tipo_movimiento` WRITE;
/*!40000 ALTER TABLE `tipo_movimiento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_movimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_transaccion`
--

DROP TABLE IF EXISTS `tipo_transaccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_transaccion` (
  `pk_idtipotransaccion` int NOT NULL,
  `nombre_tipo_transaccion` varchar(45) DEFAULT NULL,
  `descripcion_tipo_transaccion` varchar(75) DEFAULT NULL,
  `estado_tipo_transaccion` tinyint DEFAULT NULL,
  PRIMARY KEY (`pk_idtipotransaccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_transaccion`
--

LOCK TABLES `tipo_transaccion` WRITE;
/*!40000 ALTER TABLE `tipo_transaccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_transaccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoinventario`
--

DROP TABLE IF EXISTS `tipoinventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipoinventario` (
  `pk_id_tipoinventario` int NOT NULL AUTO_INCREMENT,
  `nombre_tipoinventario` varchar(45) DEFAULT NULL,
  `descripcion_tipo_inventario` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pk_id_tipoinventario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoinventario`
--

LOCK TABLES `tipoinventario` WRITE;
/*!40000 ALTER TABLE `tipoinventario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipoinventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoproductoencabezado`
--

DROP TABLE IF EXISTS `tipoproductoencabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipoproductoencabezado` (
  `pk_id_tipoproductoencabezado` int NOT NULL AUTO_INCREMENT,
  `nombre_tipoproductoencabezado` varchar(45) DEFAULT NULL,
  `descripcion_tipoproductoencabezado` varchar(45) DEFAULT NULL,
  `precio_tipoproductoencabezado` double DEFAULT NULL,
  `estado_tipoproductoencabezado` int DEFAULT NULL,
  PRIMARY KEY (`pk_id_tipoproductoencabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoproductoencabezado`
--

LOCK TABLES `tipoproductoencabezado` WRITE;
/*!40000 ALTER TABLE `tipoproductoencabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipoproductoencabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculo`
--

DROP TABLE IF EXISTS `vehiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehiculo` (
  `pk_id_vehiculo` int NOT NULL AUTO_INCREMENT,
  `fk_id_marca` int NOT NULL,
  `placa_vehiculo` varchar(45) NOT NULL,
  `modelo_vehiculo` varchar(45) NOT NULL,
  `color_vehiculo` varchar(45) NOT NULL,
  `anio_vehiculo` varchar(45) NOT NULL,
  `tipo_combustible_vehiculo` varchar(45) NOT NULL,
  `estado_vehiculo` int NOT NULL,
  PRIMARY KEY (`pk_id_vehiculo`),
  KEY `pk_id_vehiculo` (`pk_id_vehiculo`),
  KEY `fk_vehiculo_marca` (`fk_id_marca`),
  CONSTRAINT `fk_vehiculo_marca` FOREIGN KEY (`fk_id_marca`) REFERENCES `marca` (`pk_id_marca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehiculo`
--

LOCK TABLES `vehiculo` WRITE;
/*!40000 ALTER TABLE `vehiculo` DISABLE KEYS */;
/*!40000 ALTER TABLE `vehiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta` (
  `pk_idventa` int NOT NULL,
  `fecha` date DEFAULT NULL,
  `fk_idcliente` int NOT NULL,
  `fk_idproducto` int NOT NULL,
  PRIMARY KEY (`pk_idventa`),
  KEY `fk_venta_cliente` (`fk_idcliente`),
  KEY `fk_venta_producto1` (`fk_idproducto`),
  CONSTRAINT `fk_venta_cliente` FOREIGN KEY (`fk_idcliente`) REFERENCES `cliente` (`pk_idcliente`),
  CONSTRAINT `fk_venta_producto1` FOREIGN KEY (`fk_idproducto`) REFERENCES `producto` (`pk_idproducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'db_clc'
--

--
-- Dumping routines for database 'db_clc'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-28 20:56:50
