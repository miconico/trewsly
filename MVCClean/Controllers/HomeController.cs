// <copyright file="HomeController.cs" company="trewsly">entry point</copyright>
// <summary> entry controller application</summary>
namespace MVCClean.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Models;

    /// <summary>
    /// Entry to application controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// GET: /Home/ 
        /// </summary>
        /// <returns>View based on logic</returns>
        public ActionResult Index()
        {
            UserProfileModel upmodel = new UserProfileModel();

            upmodel.BackGround = "looking for meaning";

            return this.View(upmodel);
        }
    }
}
