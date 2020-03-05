using System.Web.Mvc;
using Mvc_MongoDB.Models;
using System.Collections.Generic;
using System;
using Mvc_MongoDB.Repository;
using API_Teste2.Services;

namespace Mvc_MongoDB.Controllers
{
    public class HomeController : Controller
    {

        ItemDB _itemDB = null;
        ItemService _itemService = null;
        public HomeController()
        {
            _itemDB = new ItemDB();
            _itemService = new ItemService();
        }
        public ActionResult Get()
        {
            //List<Item> items = JsonConvert.DeserializeObject<List<Item>>(collection.Find(x => x.NomeItem != null).ToJson());
            //return items;
            _itemService.GetBLL();
           List<Item> list = _itemDB.Get();
            return View(list);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Item _item)
        {

            try
            {
                _itemService.CreateBLL(_item);
                _itemDB.Create(_item);
            }
            catch (Exception)
            {
                //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE ="" JavaScript"">alert ("O nome nao pode repetir meo")</SCRIPT>);
                return new HttpStatusCodeResult(400);
            }
            return RedirectToAction("Get");
        }


        public ActionResult Edit(string Id)
        {
            List<Item> list = _itemDB.Get();
            foreach (var item in list)
            {
                if (item.Id == Id)
                    return View(item);
            }
            return View();         
        }


        [HttpPost]
        public ActionResult Edit(Item item)
        {

            //var Item = Builders<Item>.Filter.Eq(x => x.NomeItem, item.NomeItem);
            //Context.Itens.FindOneById(new ObjectId(Item.Id));
            //Context.Itens.Update(Query.EQ("NomeItem", item.NomeItem), item );
            try
            {
                _itemService.EditBLL(item);
                _itemDB.Edit(item);
            }
            catch (Exception)
            {
                return new HttpStatusCodeResult(400);
            }

            return RedirectToAction("Get") ; 
        }

        public ActionResult Delete(Item item)
        {

            try
            {
                _itemService.DeleteDLL(item);
                _itemDB.Delete(item);
            }
            catch (Exception)
            {
                return new HttpStatusCodeResult(400);
            }
            return RedirectToAction("Get");
        }

        [HttpGet]
        public ActionResult Delete(string Id)
        {
            List<Item> list = _itemDB.Get();
            foreach (var item in list)
            {
                if (item.Id == Id)
                    return View(item);
            }
            return View();
        }
    }
}