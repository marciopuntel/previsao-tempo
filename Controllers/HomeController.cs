using ClimaTempoSimples.Data;
using System.Linq;
using System.Web.Mvc;

namespace ClimaTempoSimples.Controllers
{
    public class HomeController : Controller
    {
        ClimaDbContext _context;

        public HomeController()
        {
            _context = new ClimaDbContext();
        }

        
        public ActionResult Index()
        {
            
            ViewBag.CidadesFrias = Models.ProcessarPrevisao.CidadesMaisFrias(_context);
            ViewBag.CidadesQuentes = Models.ProcessarPrevisao.CidadesMaisQuentes(_context);
            ViewBag.TodasCidades = _context.Cidade.ToList();

            return View();
        }

        public ActionResult About()
        {
            
            return View();
        }

        
    }
}