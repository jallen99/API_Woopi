using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using API_Teste2.BLL;
using Mvc_MongoDB.Models;

namespace test.create.BLL
{
    /// <summary>
    /// Descrição resumida para ItemBLLTest
    /// </summary>
    [TestClass]
    public class ItemBLLTest
    {
        ItensBLL bll;
        public ItemBLLTest()
        {
            bll = new ItensBLL();
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtém ou define o contexto do teste que provê
        ///informação e funcionalidade da execução de teste atual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de teste adicionais
        //
        // É possível usar os seguintes atributos adicionais enquanto escreve os testes:
        //
        // Use ClassInitialize para executar código antes de executar o primeiro teste na classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para executar código após a execução de todos os testes em uma classe
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize para executar código antes de executar cada teste 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para executar código após execução de cada teste
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Nome nao pode ser null")]
        public void NomeDoItemNaoPodeSerNulo()
        {
            Item item = new Item();

            bll.CreateBLL(item);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Nome nao pode ser vazio")]
        public void NomeDoItemNaoPodeSerVazio()
        {
            Item item = new Item();
            item.NomeItem = "";

            bll.CreateBLL(item);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Quantidade não pode ser negarivo")]
        public void QuantidadeDoItemNaoPodeSerMenorQueZero()
        {
            Item item = new Item();
            item.QuantidadeItem = -1;
            item.NomeItem = "shinara";

            bll.CreateBLL(item);
        }


        [TestMethod]
        public void ItemValido()
        {
            Item item = new Item();
            item.NomeItem = "Chablau";
            bll.CreateBLL(item);
        }

        [TestMethod]
        public void ItemValido2()
        {
            Item item = new Item();
            item.NomeItem = "teste";
            bll.CreateBLL(item);
        }
    }
}
