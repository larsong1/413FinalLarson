using _413FinalLarson.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _413FinalLarson.Controllers
{
    public class HomeController : Controller
    {
        private IFinalRepository _repo;

        public HomeController(IFinalRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Entertainers()
        {
            var entertainers = _repo.Entertainers.ToList();

            return View(entertainers);
        }

        public IActionResult ViewEntertainer(int id)
        {
            var recordToView = _repo.Entertainers.Single(x => x.EntertainerId == id);

            return View(recordToView);
        }

        [HttpPost]
        public IActionResult Edit(Entertainer ent)
        {
            _repo.UpdateEntertainer(ent);
            return RedirectToAction("Entertainers");
        }

        public IActionResult Delete(int id)
        {
            var recordToDelete = _repo.Entertainers.Single(x => x.EntertainerId == id);

            _repo.DeleteEntertainer(recordToDelete);
            return RedirectToAction("Entertainers");
        }

        [HttpGet]
        public IActionResult Add ()
        {
            return View(new Entertainer());
        }

        [HttpPost]
        public IActionResult Add(Entertainer ent)
        {
            _repo.AddEntertainer(ent);
            return RedirectToAction("Entertainers");
        }
    }
}
