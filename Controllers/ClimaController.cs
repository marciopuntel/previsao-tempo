using ClimaTempoSimples.Data;
using ClimaTempoSimples.Models;
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

        public JsonResult GetProximosDias(int cidade)
        {
            var proxDias = ProcessarPrevisao.ProximosDias(_context, cidade);
            return Json(proxDias, JsonRequestBehavior.AllowGet); ;
        }
    }
}