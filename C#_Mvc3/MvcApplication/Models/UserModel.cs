using System;

namespace MvcApplication.Models
{
    // 以業務為主的用戶模式
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
        public int Political { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Graduated { get; set; }
        public string Professional { get; set; }
        public DateTime GraduatedDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ImagePath { get; set; }
        public string Other { get; set; }
    }

    // 以頁面為主的用戶登錄模式
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    // 以頁面為主的用戶註冊模式
    public class RegeditModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
    }
}