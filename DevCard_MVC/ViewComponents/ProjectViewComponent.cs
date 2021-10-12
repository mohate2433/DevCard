using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DevCard_MVC.Models;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Projects = new List<Project>
            {
                new Project(id : 1 , name : "پروژه" , description : "پروژه اول" , client : "proj" , image :"Project-1.jpg" ),
                new Project(id : 2 , name : "پروژه" , description : "پروژه دوم" , client : "proj" , image :"Project-2.jpg" ),
                new Project(id : 3 , name : "پروژه" , description : "پروژه سوم" , client : "proj" , image :"Project-3.jpg" ),
                new Project(id : 4 , name : "پروژه" , description : "پروژه چهارم" , client : "proj" , image :"Project-4.jpg" ),
            };
            return View("_Project",Projects);
        }
    }
}
