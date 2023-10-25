-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 15-Ago-2022 às 13:25
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 7.3.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `db_cafeteria`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_pedido`
--

CREATE TABLE `tb_pedido` (
  `PdQtde` int(11) NOT NULL,
  `PdDescricao` varchar(30) NOT NULL,
  `PdUnitario` decimal(30,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_pedido`
--

INSERT INTO `tb_pedido` (`PdQtde`, `PdDescricao`, `PdUnitario`) VALUES
(1, 'Bolo Individual', '7');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_produtos`
--

CREATE TABLE `tb_produtos` (
  `PdCodigo` int(11) NOT NULL,
  `PdDescricao` varchar(50) NOT NULL,
  `PdTipo` varchar(30) NOT NULL,
  `PdQtde` int(11) NOT NULL,
  `PdUnitario` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_produtos`
--

INSERT INTO `tb_produtos` (`PdCodigo`, `PdDescricao`, `PdTipo`, `PdQtde`, `PdUnitario`) VALUES
(1, 'Café Expresso', 'Bebida', 1, '3,00'),
(2, 'Café Coado', 'Bebida', 1, '3,00'),
(3, 'Café com Leite', 'Bebida', 1, '3,50'),
(4, 'Achocolatado', 'Bebida', 1, '3,50'),
(5, 'Cappuccino', 'Bebida', 1, '5,00'),
(6, 'Água', 'Bebida', 1, '3,00'),
(7, 'Refrigerante', 'Bebida', 1, '3,00'),
(8, 'Bolo Individual', 'Sobremesa', 1, '5,00'),
(9, 'Bolo Inteiro', 'Sobremesa', 1, '12,00'),
(10, 'Brownie com Sorvete', 'Sobremesa', 1, '10,00'),
(11, 'Açaí', 'Sobremesa', 1, '5,00'),
(12, 'Batata Recheada', 'Salgados', 1, '5,00'),
(13, 'Frango Creme', 'Salgados', 1, '5,00'),
(14, 'Empadinha', 'Salgados', 1, '3,00'),
(15, 'Misto Quente', 'Salgados', 1, '5,00'),
(16, 'Pão na Chapa', 'Salgados', 1, '3,00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuario`
--

CREATE TABLE `tb_usuario` (
  `userCodigo` int(11) NOT NULL,
  `userLogin` varchar(30) NOT NULL,
  `userSenha` varchar(30) NOT NULL,
  `userLogado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_usuario`
--

INSERT INTO `tb_usuario` (`userCodigo`, `userLogin`, `userSenha`, `userLogado`) VALUES
(2, 'ADM', '123', 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_pedido`
--
ALTER TABLE `tb_pedido`
  ADD PRIMARY KEY (`PdQtde`);

--
-- Índices para tabela `tb_produtos`
--
ALTER TABLE `tb_produtos`
  ADD PRIMARY KEY (`PdCodigo`);

--
-- Índices para tabela `tb_usuario`
--
ALTER TABLE `tb_usuario`
  ADD PRIMARY KEY (`userCodigo`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_pedido`
--
ALTER TABLE `tb_pedido`
  MODIFY `PdQtde` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `tb_produtos`
--
ALTER TABLE `tb_produtos`
  MODIFY `PdCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT de tabela `tb_usuario`
--
ALTER TABLE `tb_usuario`
  MODIFY `userCodigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
