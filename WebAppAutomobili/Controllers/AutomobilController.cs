using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppAutomobili.Models;

namespace WebAppAutomobili.Controllers
{
    public class AutomobilController : Controller
    {
        private readonly IRepozitorijUpita _repozitorijUpita;
        public AutomobilController(IRepozitorijUpita repozitorijUpita)
        {
            _repozitorijUpita = repozitorijUpita;
        }
        public IActionResult Index()
        {
            return View(_repozitorijUpita.PopisAutomobil());
        }

        public IActionResult Create()
        {
            ViewData["KategorijaId"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Id", "Naziv");
            int sljedeciId = _repozitorijUpita.SljedeciId();
            Automobil automobil = new Automobil() { Id = sljedeciId };
            return View(automobil);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create([Bind("Id, Naziv, Cijena, GodinaProizvodnje, SlikaUrl, KategorijaId")] Automobil automobil)
        {
            ModelState.Remove("Kategorija"); 

            if (ModelState.IsValid)
            {
                _repozitorijUpita.Create(automobil);
                return RedirectToAction("Index"); 
            }
            
            ViewData["KategorijaId"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Id", "Naziv", automobil.KategorijaId);
            return View(automobil);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            Automobil automobil = _repozitorijUpita.DohvatiAutomobilSIdom(id);

            if (automobil == null) { return NotFound(); }

            ViewData["KategorijaId"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Id", "Naziv", automobil.KategorijaId);
            return View(automobil);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, [Bind("Id, Naziv, Cijena, GodinaProizvodnje, SlikaUrl, KategorijaId")] Automobil automobil)
        {
            if (id != automobil.Id)
            {
                return NotFound();
            }

            ModelState.Remove("Kategorija");

            if (ModelState.IsValid)
            {
                _repozitorijUpita.Update(automobil);
                return RedirectToAction("Index");
            }

            
            ViewData["KategorijaId"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Id", "Naziv", automobil.KategorijaId);
            return View(automobil);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var automobil = _repozitorijUpita.DohvatiAutomobilSIdom(Convert.ToInt16(id));

            if (automobil == null)
            {
                return NotFound();
            }

            return View(automobil);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var automobil = _repozitorijUpita.DohvatiAutomobilSIdom(id);
            _repozitorijUpita.Delete(automobil);
            return RedirectToAction("Index");

        }

        public ActionResult SearchIndex(string automobilModel, string searchString)
        {
            var model = new List<string>();

            var modelUpit = _repozitorijUpita.PopisKategorija();

            ViewData["automobilModel"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Naziv", "Naziv", modelUpit);

            var automobili = _repozitorijUpita.PopisAutomobil();

            if (!String.IsNullOrWhiteSpace(searchString))
            {
                automobili = automobili.Where(s => s.Naziv.Contains(searchString, StringComparison.OrdinalIgnoreCase)); // StringComparison.OrdinalIgnoreCase ignorira velika-mala slova 
            }

            if (string.IsNullOrWhiteSpace(automobilModel))
                return View(automobili);
            else
            {
                return View(automobili.Where(x => x.Kategorija.Naziv == automobilModel));
            }

        }

    }
}
