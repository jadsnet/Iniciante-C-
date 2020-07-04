﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.DAL;
using Pizzaria.DTO;

namespace Pizzaria.BLL
{
    public class PizzaBLL
    {
        //INCUIR CLIENTES
        public static int IncluirClienteBLL(Pizza objPizza)
        {
            return PizzaDAL.IncluirClienteDAL(objPizza);
        }
        //INCLUIR PRODUTOS
        public static int IncluiProdutoBLL(Pizza objPizza)
        {
            return PizzaDAL.IncluirProdutoDAL(objPizza);
        }

        //PROCURA CLIENTES
        public static List<Pizza> ProcurarClienteBLL(string[] filtrosPesquisa)
        {
            return PizzaDAL.ProcurarClienteDAL(filtrosPesquisa);
        }
        //PROCURA PRODUTOS
        public static List<Pizza> ProcurarProdutoBLL(string[] filtrosPesquisa)
        {
            return PizzaDAL.ProcurarProdutoDAL(filtrosPesquisa);
        }
        //PROCURA CLIENTE2
        public static Pizza ProcurarClienteBLL(int CodigoCliente)
        {
            return PizzaDAL.ProcurarClienteDAL(CodigoCliente);
        }
        //PROCURA PRODUTO2
        public static Pizza ProcurarProdutoBLL(int CodigoCliente)
        {
            return PizzaDAL.ProcurarProdutoDAL(CodigoCliente);
        }
        //ATUALIZAR CLIENTE
        public static void AtualizarBLL(Pizza objPizza)
        {
            PizzaDAL.AtualizarDAL(objPizza);
        }
        //ATUALIZAR PRODUTO
        public static void AtualizarProdutoBLL(Pizza objPizza)
        {
            PizzaDAL.AtualizarProdutoDAL(objPizza);
        }
        //APAGAR CONTATO
        public static void ApagarContatoBLL(int CodigoCliente)
        {
            PizzaDAL.ApagarCliente(CodigoProduto);
        }
        //ATPAGAR PRODUTO
        public static void ApagarProdutoBLL(int CodigoProduto)
        {
            PizzaDAL.ApagarProduto(CodigoProduto);
        }


    }
}
