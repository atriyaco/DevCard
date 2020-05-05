using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public PartialViewResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public ContentResult Index()
        //{
        //    //return Content("<h1>hello Asp.net Core MVC Student");
        //    return Content($"<h1>hello Asp.net Core MVC Student</h1><script>confirm('این سوال من است؟');</script>",
        //        "text/html");
        //}

        //public EmptyResult Index()
        //{
        //    //return null;
        //    return new EmptyResult();
        //}

        //public FileResult Index()
        //{
        //    //return File("~/test.txt", "text/html");
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string fileName = "testFile.txt";
        //    return File(fileByte, MediaTypeNames.Text.Plain, fileName);
        //}

        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        id = 12,
        //        name = "hossein",
        //        job = "programmer",
        //        site = "atriya.com"
        //    });
        //}

        //public JavascriptResult Index()
        //{
        //    return new JavascriptResult("alert('salam salam hamegi salam!!!')");
        //}

        //public RedirectResult Index()
        //{
        //    return Redirect("http://www.atriya.com");
        //}

        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}

        public IActionResult Index()
        {
            //return new OkResult();
            //return new NotFoundResult();
            //return new BadRequestResult();
            //return new NoContentResult();
            return new StatusCodeResult(401);
        }
    }

    //public class JavascriptResult : ContentResult
    //{
    //    public JavascriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }
    //}
}