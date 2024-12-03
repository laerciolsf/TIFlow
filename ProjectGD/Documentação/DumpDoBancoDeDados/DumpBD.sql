CREATE DATABASE  IF NOT EXISTS `gd_bd` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `gd_bd`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: gd_bd
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `chamados`
--

DROP TABLE IF EXISTS `chamados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chamados` (
  `id` int NOT NULL AUTO_INCREMENT,
  `hora_inicio` time NOT NULL,
  `hora_final` time NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `id_grupo_chamado` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_chamados_grupo` (`id_grupo_chamado`),
  CONSTRAINT `fk_chamados_grupo` FOREIGN KEY (`id_grupo_chamado`) REFERENCES `grupo_chamados` (`id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chamados`
--

LOCK TABLES `chamados` WRITE;
/*!40000 ALTER TABLE `chamados` DISABLE KEYS */;
INSERT INTO `chamados` VALUES (1,'24:00:00','24:00:00','fdasfdsfasdf',2),(2,'24:00:00','48:00:00','teste chamdo 1',3),(3,'72:00:00','96:00:00','teste chamdo 2',3),(4,'120:00:00','120:00:00','não estou suportando mais',4),(5,'48:00:00','72:00:00','Pelo amor de deus funcione',5),(6,'96:00:00','96:00:00','socorro',6),(7,'12:00:00','15:00:00','Teste 40569',6),(8,'09:30:00','10:00:00','socorro',7),(9,'10:00:00','11:59:00','Montar PC info 01',7),(10,'13:30:00','14:50:00','abadabadu',8),(11,'168:00:00','192:00:00','sdfgsdfgs',9),(12,'240:00:00','264:00:00',' zvdavcsdac',9),(13,'09:45:00','17:46:00','Arrumar NVR',10),(14,'08:00:00','08:45:00','Configurar o ramal do Adriando',10),(15,'08:00:00','09:00:00','Internet lenta',11),(16,'08:00:00','08:40:00','Problemas de login no SESI',12),(17,'09:00:00','11:00:00','Portabilidade de telefonia',12),(18,'08:00:00','08:45:00','Configurar o ramal do Adriano',10),(19,'12:00:00','13:45:00','Rede 02 Caiu',13),(20,'13:34:00','14:00:00','Computador não liga',13),(21,'08:00:00','09:50:00','rede 02',15),(22,'10:00:00','12:00:00','fiz nada',15),(23,'10:00:00','12:00:00','fiz tudo',15);
/*!40000 ALTER TABLE `chamados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grupo_chamados`
--

DROP TABLE IF EXISTS `grupo_chamados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grupo_chamados` (
  `id` int NOT NULL AUTO_INCREMENT,
  `titulo` varchar(45) NOT NULL,
  `qtde_chamados` int DEFAULT NULL,
  `qtde_tempo` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupo_chamados`
--

LOCK TABLES `grupo_chamados` WRITE;
/*!40000 ALTER TABLE `grupo_chamados` DISABLE KEYS */;
INSERT INTO `grupo_chamados` VALUES (1,'teste01',NULL,NULL),(2,'teste',NULL,NULL),(3,'teste 3699',NULL,NULL),(4,'teste 1 bilhao',NULL,NULL),(5,'teste 99494944949',NULL,NULL),(6,'teste um zilhão',NULL,NULL),(7,'teste q se DEUS quiser vai da certo',NULL,NULL),(8,'123',NULL,NULL),(9,'abc',NULL,NULL),(10,'teste do juizo final',NULL,NULL),(11,'test',NULL,NULL),(12,'03/12/24',NULL,NULL),(13,'04/08/2024',NULL,NULL),(14,'03/12/2025',NULL,NULL),(15,'03/12/2024',NULL,NULL);
/*!40000 ALTER TABLE `grupo_chamados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nomeCompleto` varchar(128) NOT NULL,
  `login` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `nivelAcesso` int NOT NULL DEFAULT '4',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Administrador','admin','202cb962ac59075b964b07152d234b70',1),(2,'','','d41d8cd98f00b204e9800998ecf8427e',4),(3,'sdfdsfdsf','dfdsfdsf','d16ed6fe91c22bddb78e15d56e4c9cfe',0),(4,'Laercio','laio','caf1a3dfb505ffed0d024130f58c5cfa',4),(5,'cxvcxv','xcvxcv','0376f6bba322ff9b8c3c692914e9de19',4),(6,'laio','laio soares','202cb962ac59075b964b07152d234b70',3);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'gd_bd'
--

--
-- Dumping routines for database 'gd_bd'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-03 11:51:56
