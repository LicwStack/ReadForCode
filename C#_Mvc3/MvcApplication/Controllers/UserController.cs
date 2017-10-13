using System.Web.Mvc;
using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            if (loginModel.UserName == "張三" && loginModel.Password == "123")
            {
                Response.Write("正確！");
            }
            else
            {
                Response.Write("不正確！");
            }
            return View();
        }

        public ActionResult UserDetail()
        {
            var userModel = new UserModel
            {
                UserName = "用戶名",
                Password = "密碼",
                Sex = 0,
                Age = 30,
                Height = 170,
                Weight = 70,
                Graduated = "畢業院校"
            };
            return View(userModel);
        }

        public ActionResult UserEdit()
        {
            var userModel = new UserModel
            {
                UserName = "用户名",
                Password = "密碼",
                Sex = 0,
                Age = 30,
                Height = 170,
                Weight = 70,
                Graduated = "畢業院校"
            };
            return View(userModel);
        }

        [HttpPost]//UserEdit
        public ActionResult UserEdit(UserModel userModel)
        {
            Response.Write(userModel.UserName);
            Response.Write("<br />");
            Response.Write(userModel.Password);
            Response.Write("<br />");
            Response.Write(userModel.Sex);
            Response.Write("<br />");
            Response.Write(userModel.Age);
            Response.Write("<br />");
            Response.Write(userModel.Height);
            Response.Write("<br />");
            Response.Write(userModel.Weight);
            Response.Write("<br />");
            Response.Write(userModel.Graduated);
            Response.Write("<br />");
            return View();
        }

        public ActionResult UserEdit_01()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserEdit_01(FormCollection form)
        {
            Response.Write(form["UserName"]);
            Response.Write("<br />");
            Response.Write(form[1]);
            Response.Write("<br />");
            return View();
        }
    }
}
