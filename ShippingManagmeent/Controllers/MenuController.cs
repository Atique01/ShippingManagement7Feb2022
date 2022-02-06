using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShippingManagmeent.Controllers
{
    public class MenuController : Controller
    {
        private SAMYEntities db = new SAMYEntities();


        // GET: Menu
        public ActionResult Index()
        {

            List<Menu> menu = new List<Menu>();
            try
            {
                var data = db.Menus.ToList();

                menu = data.Select(x => new Menu
                {
                    Id = x.Id,
                    Menu1 = x.Menu1,
                  //  Submenu = getSubMenu(x.Id)
                }).ToList();

                Session["UserDetails"] = menu;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return View(menu);
        }

        private List<SubMenu> getSubMenu(int id)
        {
            List<SubMenu> subMenuList = new List<SubMenu>();
            var data = db.SubMenus.ToList();

            foreach (var item in data)
            {
                if(item.MenuId==id)
                {
                    var submenu = new SubMenu
                    {
                        SubMenu1 = item.SubMenu1,
                        PageUrl=item.PageUrl
                       
                    };
                    subMenuList.Add(submenu);
                }
            }

            return subMenuList;

           



        }
    }
}