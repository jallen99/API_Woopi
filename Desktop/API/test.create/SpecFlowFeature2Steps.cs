using API_Teste2.BLL;
using Mvc_MongoDB.Models;
using System;
using TechTalk.SpecFlow;

namespace test.create
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        ItensBLL bll = new ItensBLL();
        Item item = new Item();

        [Given(@"a name to item ""(.*)""")]
        public void GivenANameToItem(string p0)
        {
            item.NomeItem = p0;
        }
        
        [Given(@"one category for item ""(.*)""")]
        public void GivenOneCategoryForItem(string p0)
        {
            item.CategoriaItem = p0;
        }
        
        [Given(@"gives him a amount (.*)")]
        public void GivenGivesHimAAmount(double p0)
        {
            item.QuantidadeItem = p0;
        }
        
        [When(@"I authenticate him")]
        public void WhenIAuthenticateHim()
        {
            bll.CreateBLL(item);
        }
        
        [Then(@"the result shouldn't thow a exception")]
        public void ThenTheResultShouldnTThowAException()
        {
        }
    }
}
