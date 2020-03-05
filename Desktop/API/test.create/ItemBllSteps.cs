using API_Teste2.BLL;
using Mvc_MongoDB.Models;
using System;
using TechTalk.SpecFlow;

namespace test.create
{
    [Binding]
    public class ItemBllSteps
    {
        ItensBLL bll = new ItensBLL();
        Item u = new Item();

        [Given(@"Que o nome do item seja ""(.*)""")]
        public void GivenQueONomeDoItemSeja(string p0)
        {
            u.NomeItem = p0;
        }
        
        [Given(@"A quantidade  seja (.*)")]
        public void GivenAQuantidadeSeja(int p0)
        {
            u.QuantidadeItem = p0;
        }
        
        [When(@"Eu valido o item")]
        public void WhenEuValidoOItem()
        {
            bll.CreateBLL(u);
        }
        
        [Then(@"o resultado deve não deve dar erro")]
        public void ThenOResultadoDeveNaoDeveDarErro()
        {
        }
    }
}
