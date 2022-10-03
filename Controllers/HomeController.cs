using ClimaTempoSimples.Data;
using System.Data.Entity;
using System.Threading.Tasks;
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

        
        public async Task<ActionResult> Index()
        {
            
            ViewBag.CidadesFrias = await Models.ProcessarPrevisao.CidadesMaisFrias(_context);
            ViewBag.CidadesQuentes = await Models.ProcessarPrevisao.CidadesMaisQuentes(_context);
            ViewBag.TodasCidades = await _context.Cidade.ToListAsync();

            return View();
        }

        public ActionResult About()
        {
            
            return View();
        }

        
    }
}