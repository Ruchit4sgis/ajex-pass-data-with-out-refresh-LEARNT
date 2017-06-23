using async_learn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace async_learn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new test())
            {
                var model = new allmodel
                {
                    ed = db.employee_detils.OrderByDescending(a => a.id).ToList(),
                    sd = db.Student_detail.OrderByDescending(a => a.id).ToList()
                };

                return View(model);
            }
        }

        //public PartialViewResult index()
        //{

        //    return PartialView("")
        //}

        


        public ActionResult updatestu(string name,string std)
        {
            
            using (var db = new test())
            {
                var model = new allmodel
                {
                    ed = db.employee_detils.ToList(),
                    sd = db.Student_detail.OrderByDescending(a => a.id).ToList()
                };

                return PartialView("_Studentdetail_index",model.sd);
            }

        }

        public ActionResult addstu(string name, string std)
        {
            Student_detail rec = new Student_detail
            {
                Name = name,
                Standard = std,

            };
            using (var qwer = new test())
            {
                qwer.Student_detail.Add(rec);
                qwer.SaveChanges();
            }
            {
                using (var db = new test())
                {
                    var model = new allmodel
                    {
                        ed = db.employee_detils.ToList(),
                        sd = db.Student_detail.OrderByDescending(a => a.id).ToList()
                    };

                    return PartialView("_Studentdetail_index", model.sd);
                }

              //  return PartialView("_Studentdetail_index", model.sd);
            }


        


        }
    }


   
}



   

