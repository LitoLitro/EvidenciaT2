using Microsoft.AspNetCore.Mvc;
using T2_Quispe_Gustavo.Datos;
using T2_Quispe_Gustavo.Models;

namespace T2_Quispe_Gustavo.Controllers
{
    public class DistribuidorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DistribuidorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Distribuidor> lista = _db.Distribuidor;
            return View(lista);
        }
    }
}
