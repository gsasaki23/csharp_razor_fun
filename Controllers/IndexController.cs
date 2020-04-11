    using Microsoft.AspNetCore.Mvc;
    namespace razor_fun
    {
        public class IndexController : Controller
        {
            // Index Page
            // 5000/
            [HttpGet]
            [Route("")]
            public ViewResult Index()
            {
                // View() implies View(Index) because it looks for file matching function name
                // First in Views/FunctionName/FunctionName.cshtml, then in Views/Shared/same
                return View();
            }

            // You can serve the same view from other routes
            [HttpGet("elsewhere")]
            public ViewResult Elsewhere()
            {
                return View("Index");
            }
        }
    }
