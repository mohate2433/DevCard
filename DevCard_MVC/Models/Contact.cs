using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required (ErrorMessage =" ابن فیلد اجباری است ")]
        [MinLength(3,ErrorMessage ="حداقل 3 کاراکتر ")]
        [MaxLength(350,ErrorMessage ="حداکثر 350 کاراکتر ")]
        public string Name { get; set; }
        [Required(ErrorMessage = " ابن فیلد اجباری است ")]
        [EmailAddress(ErrorMessage = " لطفا ایمیل خود را صحیح وارد کنید ")]
        public string Email { get; set; }
        public string message { get; set; }
        public string Service { get; set; }
        public SelectList Services {  get; set; }
    }
}
