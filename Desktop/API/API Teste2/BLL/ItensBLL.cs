using Mvc_MongoDB.Controllers;
using Mvc_MongoDB.Models;
using Mvc_MongoDB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API_Teste2.BLL
{
    public class ItensBLL
    {
        ItemDB itemdb = new ItemDB();

        public void CreateBLL(Item item)
        {
            /*
            foreach (var it in itemdb.Get())
            {
                if(it.NomeItem == item.NomeItem)
                {
                    throw new System.ArgumentException("Nome nao pode ser igual", "Nome");
                }
            }
            */
            if (item.NomeItem == null)
            {
                throw new System.ArgumentException("Nome nao pode ser null","Nome");
            }
            if(item.NomeItem == "")
            {
                throw new System.ArgumentException("Nome nao pode ser vazio","Nome");
            }
            if(item.QuantidadeItem < 0)
            {
                throw new System.ArgumentException("Quantidade não pode ser negarivo", "Quantidade");
            }
        }
        public void EditBLL(Item item)
        {
            foreach (var it in itemdb.Get())
            {
                if (it.NomeItem == item.NomeItem)
                {
                    
                    throw new System.ArgumentException("Nome nao pode ser igual", "Nome");
                }
                
            }
            if (item.NomeItem == null)
            {
                throw new System.ArgumentException("Nome nao pode ser null", "Nome");
            }
            if (item.NomeItem == "")
            {
                throw new System.ArgumentException("Nome nao pode ser vazio", "Nome");
            }
            if (item.QuantidadeItem < 0)
            {
                throw new System.ArgumentException("Quantidade não pode ser negarivo", "Quantidade");
            }
        }
        public void GetBLL()
        {
           //ADD rule to Get
        }
        public void DeleteDLL(Item item)
        {
          //ADD rule to delete
        }
    }
}