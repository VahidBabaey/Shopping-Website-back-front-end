using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Areas.Admin.Models
{
    public class CustomerRegisterModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "نام را وارد نمایید")]
        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "نام خانوادگی را وارد نمایید")]
        public string LastName { get; set; }

        [Display(Name = "کلمه کاربری")]
        [Remote("CheckUserNameAsync", "Account", "Admin", ErrorMessage = "این کلمه کاربری قبلا استفاده شده است", HttpMethod = "Post")]
        [Required(ErrorMessage = "کلمه کاربری  را وارد نمایید")]
        
        public string UserName { get; set; }

        [Display(Name = "شماره همراه")]
        [Required(ErrorMessage = "شماره همراه را وارد نمایید")]
        [MaxLength(11,ErrorMessage = "شماره همراه باید 11 رقم باشد")]
        [MinLength(11, ErrorMessage = "شماره همراه باید 11 رقم باشد")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "رمز عبور را وارد نمایید")]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Display(Name = "تایید رمز عبور")]
        [Required(ErrorMessage = "رمز عبور مجدد را وارد نمایید")]
        [Compare("Password", ErrorMessage = "رمز عبور ها یکسان نیست")]
        public string ConfirmPassword { get; set; }

        [EmailAddress(ErrorMessage = "فرمت پست الکترونیکی  را  صحیح وارد نمایید")]
        [Required(ErrorMessage = "پست الکترونیکی مجدد را وارد نمایید")]
        [Display(Name = "پست الکترونیکی")]
        public string Email { get; set; }
    }

    public class CustomerLoginModel
    {

        public string returnUrl { get; set; }

        [Display(Name = "کلمه کاربری")]
        [Required(ErrorMessage = "کلمه کاربری خانوادگی را وارد نمایید")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "رمز عبور را وارد نمایید")]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بیاور")]
        public bool RememberMe { get; set; }
    }
    public class CustomerActivateModel
    {
        [Display(Name = "کد تایید")]
        [Required(ErrorMessage = "لطفا کد تایید را وارد نمایید")]
        [MaxLength(6, ErrorMessage = "کد تایید باید 6 رقمی باشد")]
        [MinLength(6, ErrorMessage = "کد تایید باید 6 رقمی باشد")]
        public string ActivateCode { get; set; }
    }
    public class CustomerForgetModel
    {
        [Display(Name = "شماره همراه")]
        [Required(ErrorMessage = "شماره همراه را وارد نمایید")]
        [MaxLength(11, ErrorMessage = "شماره همراه باید 11 رقم باشد")]
        [MinLength(11, ErrorMessage = "شماره همراه باید 11 رقم باشد")]
        public string PhoneNumber { get; set; }
    }
    public class CustomerResetModel
    {
        [Display(Name = "کد تایید")]
        [Required(ErrorMessage = "لطفا کد تایید را وارد نمایید")]
        [MaxLength(6, ErrorMessage = "کد تایید باید 6 رقمی باشد")]
        [MinLength(6, ErrorMessage = "کد تایید باید 6 رقمی باشد")]
        public string ActivateCode { get; set; }

        [Required(ErrorMessage = "رمز عبور را وارد نمایید")]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Display(Name = "تایید رمز عبور")]
        [Required(ErrorMessage = "رمز عبور مجدد را وارد نمایید")]
        [Compare("Password", ErrorMessage = "رمز عبور ها یکسان نیست")]
        public string ConfirmPassword { get; set; }
    }
    public class SellerRegisterModel
    {
        public string returnUrl { get; set; }
        public int Id { get; set; }

        [Display(Name = "کلمه کاربری (نام شرکت)")]
        [Remote("CheckUserNameAsync", "Account", "Admin", ErrorMessage = "این کلمه کاربری قبلا استفاده شده است", HttpMethod = "Post")]
        [Required(ErrorMessage = "کلمه کاربری  را وارد نمایید")]

        public string UserName { get; set; }

        //[Display(Name = "نام شرکت")]
        //[Remote("CheckUserNameAsync", "Account", "Admin", ErrorMessage = "این نام شرکت قبلا استفاده شده است", HttpMethod = "Post")]
        //[Required(ErrorMessage = "نام شرکت  را وارد نمایید")]

        //public string CompanyName { get; set; }

        [EmailAddress(ErrorMessage = "فرمت پست الکترونیکی  را  صحیح وارد نمایید")]
        [Required(ErrorMessage = "پست الکترونیکی مجدد را وارد نمایید")]
        [Display(Name = "پست الکترونیکی")]
        public string Email { get; set; }

        [Required(ErrorMessage = "آدرس را وارد نمایید")]
        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [Required(ErrorMessage = "رمز عبور را وارد نمایید")]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Display(Name = "تایید رمز عبور")]
        [Required(ErrorMessage = "رمز عبور مجدد را وارد نمایید")]
        [Compare("Password", ErrorMessage = "رمز عبور ها یکسان نیست")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "تلفن")]
        [Required(ErrorMessage = "تلفن را وارد نمایید")]
        [MaxLength(11, ErrorMessage = "تلفن باید 11 رقم باشد")]
        [MinLength(8, ErrorMessage = "تلفن باید 8 رقم باشد")]
        public string Tel { get; set; }
        public int SellerID { get; set; }
    }
    public class SellerLoginModel
    {
        public string returnUrl { get; set; }

        //[Display(Name = "ایمیل")]
        //[Required(ErrorMessage = "ایمیل را وارد نمایید")]
        //public string Email { get; set; }
        [Display(Name = "کلمه کاربری")]
        [Required(ErrorMessage = "کلمه کاربری خانوادگی را وارد نمایید")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "رمز عبور را وارد نمایید")]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بیاور")]
        public bool RememberMe { get; set; }
    }
}
