using ClimaTempoSimples.Data;
using ClimaTempoSimples.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ClimaTempoSimples.Controllers
{
    public class ClimaController : Controller
    {
        ClimaDbContext _context;

        public ClimaController()
        {
            _context = new ClimaDbContext();
        }

        public async Task<JsonResult> GetProximosDias(int cidade)
        {
            var proxDias = await ProcessarPrevisao.ProximosDias(_context, cidade);
            return Json(proxDias, JsonRequestBehavior.AllowGet); ;
        }
    }
}