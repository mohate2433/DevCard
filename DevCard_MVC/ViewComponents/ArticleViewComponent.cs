using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DevCard_MVC.Models;

namespace DevCard_MVC.ViewComponents
{
    public class ArticleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Articles = new List<Article>
            {
                new Article (id:1,title:"مقاله اول",description:"این مقاله اول است" ,image :"blog-post-thumb-1.jpg" ),
                new Article (id:2,title:"مقاله دوم",description:"این مقاله دوم است" ,image :"blog-post-thumb-2.jpg" ),
                new Article (id:3,title:"مقاله سوم",description:"این مقاله سوم است" ,image :"blog-post-thumb-3.jpg" ),
                new Article (id:4,title:"مقاله چهارم",description:"این مقاله چهارم است" ,image :"blog-post-thumb-4.jpg" )
            };
            return View("_Article", Articles);
        }
    }
}
