using API_Teste2.BLL;
using Mvc_MongoDB.Models;
using System;
using TechTalk.SpecFlow;

namespace test.create
{
    [Binding]
    public class ItenstestSteps
    {
        ItensBLL bll = new ItensBLL();
        Item item = new Item();

        [Given(@"Quando eu crio uma categoria (.*)")]
        public void GivenQuandoEuCrioUmaCategoria(string p0)
        {
            item.CategoriaItem = p0;
        }
        
        [Given(@"a nomeio de (.*)")]
        public void GivenANomeioDe(string p0)
        {
            
            item.NomeItem = p0;
        }
        
        [Given(@"defino sua quantidade (.*)")]
        public void GivenDefinoSuaQuantidade(double p0)
        {
            item.QuantidadeItem = p0;
        }
        
        [When(@"Eu valido o Item")]
        public void WhenEuValidoOItem()
        {
            bll.CreateBLL(item);
        }
        
        [Then(@"o resultado nao deve lançar excecao")]
        public void ThenOResultadoNaoDeveLancarExcecao()
        {
        }
    }
}
