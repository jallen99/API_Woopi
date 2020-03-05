using API_Teste2.BLL;
using Mvc_MongoDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Teste2.Services
{
    public class ItemService
    {
        ItensBLL bll = null;
        public ItemService (){
            bll = new ItensBLL();
        }

        
        public void CreateBLL(Item item)
        {
            bll.CreateBLL(item);
        }
        public void EditBLL(Item item)
        {
            bll.EditBLL(item);
        }
        public void GetBLL()
        {
            bll.GetBLL();
        }
        public void DeleteDLL(Item item)
        {
            bll.DeleteDLL(item);
        }


        internal void Regras(object item)
        {
            throw new NotImplementedException();
        }
    }
}