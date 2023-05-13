-- MariaDB dump 10.19  Distrib 10.4.19-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: bancodosow
-- ------------------------------------------------------
-- Server version	10.4.19-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tb_adm`
--

DROP TABLE IF EXISTS `tb_adm`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_adm` (
  `id_adm` int(6) NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) NOT NULL,
  `email` varchar(50) NOT NULL,
  `data_nascimento` varchar(10) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `telefone` varchar(9) NOT NULL,
  PRIMARY KEY (`id_adm`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_adm`
--

LOCK TABLES `tb_adm` WRITE;
/*!40000 ALTER TABLE `tb_adm` DISABLE KEYS */;
INSERT INTO `tb_adm` VALUES (1,'zé','ze@gmail.com','21/06/2004','13293022901','419998017');
/*!40000 ALTER TABLE `tb_adm` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cadastro`
--

DROP TABLE IF EXISTS `tb_cadastro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_cadastro` (
  `id_cadastro` int(50) NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) NOT NULL,
  `datanascminto` varchar(8) DEFAULT NULL,
  `telefone` varchar(9) DEFAULT NULL,
  `cpf` varchar(11) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_cadastro`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cadastro`
--

LOCK TABLES `tb_cadastro` WRITE;
/*!40000 ALTER TABLE `tb_cadastro` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_cadastro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_categoria`
--

DROP TABLE IF EXISTS `tb_categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_categoria` (
  `id_categoria` int(50) NOT NULL AUTO_INCREMENT,
  `nome_categoria` varchar(20) NOT NULL,
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_categoria`
--

LOCK TABLES `tb_categoria` WRITE;
/*!40000 ALTER TABLE `tb_categoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cliente`
--

DROP TABLE IF EXISTS `tb_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_cliente` (
  `id_cliente` int(30) NOT NULL AUTO_INCREMENT,
  `nome_cliente` varchar(30) NOT NULL,
  `cpf_cliente` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cliente`
--

LOCK TABLES `tb_cliente` WRITE;
/*!40000 ALTER TABLE `tb_cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_devedor`
--

DROP TABLE IF EXISTS `tb_devedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_devedor` (
  `id_devedor` int(30) NOT NULL AUTO_INCREMENT,
  `fk_id_cliente` int(6) NOT NULL,
  `fk_id_item` int(6) NOT NULL,
  PRIMARY KEY (`id_devedor`),
  KEY `fk_id_cliente` (`fk_id_cliente`),
  KEY `fk_id_item` (`fk_id_item`),
  CONSTRAINT `tb_devedor_ibfk_1` FOREIGN KEY (`fk_id_cliente`) REFERENCES `tb_cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `tb_devedor_ibfk_2` FOREIGN KEY (`fk_id_item`) REFERENCES `tb_item` (`id_item`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_devedor`
--

LOCK TABLES `tb_devedor` WRITE;
/*!40000 ALTER TABLE `tb_devedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_devedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_estoque`
--

DROP TABLE IF EXISTS `tb_estoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_estoque` (
  `id_produto` int(6) NOT NULL AUTO_INCREMENT,
  `fk_id_categoria` int(6) NOT NULL,
  `quantidade` int(6) NOT NULL,
  PRIMARY KEY (`id_produto`),
  KEY `fk_id_categoria` (`fk_id_categoria`),
  CONSTRAINT `tb_estoque_ibfk_1` FOREIGN KEY (`fk_id_categoria`) REFERENCES `tb_categoria` (`id_categoria`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_estoque`
--

LOCK TABLES `tb_estoque` WRITE;
/*!40000 ALTER TABLE `tb_estoque` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_estoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_funcao`
--

DROP TABLE IF EXISTS `tb_funcao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_funcao` (
  `id_funcao` int(50) NOT NULL AUTO_INCREMENT,
  `funcao_funcionario` varchar(30) DEFAULT NULL,
  `salario` float DEFAULT NULL,
  PRIMARY KEY (`id_funcao`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_funcao`
--

LOCK TABLES `tb_funcao` WRITE;
/*!40000 ALTER TABLE `tb_funcao` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_funcao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_funcionario`
--

DROP TABLE IF EXISTS `tb_funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_funcionario` (
  `id_funcionario` int(50) NOT NULL AUTO_INCREMENT,
  `fk_id_cadastro` int(6) NOT NULL,
  `fk_id_funcao` int(6) NOT NULL,
  PRIMARY KEY (`id_funcionario`),
  KEY `fk_id_cadastro` (`fk_id_cadastro`),
  KEY `fk_id_funcao` (`fk_id_funcao`),
  CONSTRAINT `tb_funcionario_ibfk_1` FOREIGN KEY (`fk_id_cadastro`) REFERENCES `tb_cadastro` (`id_cadastro`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `tb_funcionario_ibfk_2` FOREIGN KEY (`fk_id_funcao`) REFERENCES `tb_funcao` (`id_funcao`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_funcionario`
--

LOCK TABLES `tb_funcionario` WRITE;
/*!40000 ALTER TABLE `tb_funcionario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_item`
--

DROP TABLE IF EXISTS `tb_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_item` (
  `id_item` int(50) NOT NULL AUTO_INCREMENT,
  `nome_item` varchar(20) NOT NULL,
  `valor` varchar(30) NOT NULL,
  `codigo` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_item`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_item`
--

LOCK TABLES `tb_item` WRITE;
/*!40000 ALTER TABLE `tb_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_subcategoria`
--

DROP TABLE IF EXISTS `tb_subcategoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_subcategoria` (
  `id_subcategoria` int(50) NOT NULL AUTO_INCREMENT,
  `nome_subcategoria` varchar(20) NOT NULL,
  `fk_id_item` int(6) NOT NULL,
  PRIMARY KEY (`id_subcategoria`),
  KEY `fk_id_item` (`fk_id_item`),
  CONSTRAINT `tb_subcategoria_ibfk_1` FOREIGN KEY (`fk_id_item`) REFERENCES `tb_item` (`id_item`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_subcategoria`
--

LOCK TABLES `tb_subcategoria` WRITE;
/*!40000 ALTER TABLE `tb_subcategoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_subcategoria` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-04 16:19:25
