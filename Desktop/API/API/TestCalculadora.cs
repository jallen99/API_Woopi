using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using API_Teste2.Services;

namespace API_test2__Teste
{
    /// <summary>
    /// Descrição resumida para TestCalculadora
    /// </summary>
    [TestClass]
    public class TestCalculadora
    {

        Calculadora calculadora;
        public TestCalculadora()
        {
            calculadora = new Calculadora();
            //
            // TODO: Adicionar lógica de construtor aqui
            //
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
        public void TestSomaDouble()
        {
            Assert.AreEqual(3, calculadora.Sum(1, 2));
            Assert.AreEqual(4, calculadora.Sum(2, 2));
            Assert.AreEqual(10, calculadora.Sum(5, 5));
            Assert.AreEqual(0, calculadora.Sum(0, 0));
            Assert.AreEqual(-5, calculadora.Sum(-1, -4));
            Assert.AreEqual(3, calculadora.Sum(-3, 6));
            Assert.AreEqual(0, calculadora.Sum(-1, 1));

            Assert.AreNotEqual(-100, calculadora.Sum(50, 1000));

        }

        [TestMethod]
        public void TestSomaString()
        {
            Assert.AreEqual("3", calculadora.Sum("1", "2"));
            Assert.AreEqual("4", calculadora.Sum("2", "2"));
            Assert.AreEqual("10", calculadora.Sum("5", "5"));
            Assert.AreEqual("0", calculadora.Sum("0", "0"));
            Assert.AreEqual("-5", calculadora.Sum("-1", "-4"));
            Assert.AreEqual("3", calculadora.Sum("-3", "6"));
            Assert.AreEqual("0", calculadora.Sum("-1", "1"));

            Assert.AreNotEqual("-100", calculadora.Sum("50", "1000"));

            Assert.AreEqual(null, calculadora.Sum("gato", "cachorro"));
            Assert.AreEqual(null, calculadora.Sum("☺", "♀"));
            Assert.AreEqual(null, calculadora.Sum("0", "y"));
            Assert.AreEqual(null, calculadora.Sum("1", ""));
            
            //Assert.AreEqual("0,1", calculadora.Sum("-1.5", "1.6"));

            //Assert.AreEqual("0,1", calculadora.Sum("-1,5", "1,6"));

            //Assert.AreEqual("0,1", calculadora.Sum("-1..5", "1..6"));

            //Assert.AreEqual("0,1", calculadora.Sum("-1,5", "1,,6"));

        }
    }
}
