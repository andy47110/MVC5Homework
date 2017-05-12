using MVC5Homework1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Homework1.Controllers
{
    public class CustDataManageController : Controller
    {
        客戶資料Entities db = new 客戶資料Entities();
        // GET: CustDataManage

        public ActionResult 客戶關聯資料表()
        {
            return View(db.vw客戶關聯資料統計表.ToList());
        }

        public ActionResult Index(string keyword)
        {
            //var all = db.客戶資料.AsQueryable();
            //var data = db.客戶資料.Where(x => x.是否已刪除 == false).ToList();

            //新增搜尋功能
            var data = db.客戶資料.Where(x => x.是否已刪除 == false).AsQueryable();

            if (!String.IsNullOrEmpty(keyword))
            {
                data = data.Where(x => x.客戶名稱.Contains(keyword));
            }
            return View(data.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(客戶資料 CustData)
        {
            if(ModelState.IsValid)
            {
                    db.客戶資料.Add(CustData); 
                    db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(CustData);
        }

        public ActionResult Edit(int id)
        {
            var item = db.客戶資料.Find(id);
            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(int id ,客戶資料 CustData)
        {
            if(ModelState.IsValid)
            {
                var item = db.客戶資料.Find(id);

                item.客戶名稱 = CustData.客戶名稱;
                item.統一編號 = CustData.統一編號;
                item.電話 = CustData.電話;
                item.傳真 = CustData.傳真;
                item.地址 = CustData.地址;
                item.Email = CustData.Email;

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(CustData);
        }

        public ActionResult Delete(int id)
        {
                var item  =db.客戶資料.Find(id);
                item.是否已刪除 = true; 

                db.SaveChanges();
                return RedirectToAction("Index");
        }

        public ActionResult Detail(int id)
        {
            var item = db.客戶資料.Find(id);
            return View(item);
        }
    }
}