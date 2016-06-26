using BLL.Interfacies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPL.Controllers
{
    public class TestController : Controller
    {
        private ITestRepository testRepository;
        public TestController(ITestRepository testRepository)
        {
            this.testRepository = testRepository;
        }

        public ViewResult List()
        {
            return View(testRepository.Tests);
        }

    }
}
