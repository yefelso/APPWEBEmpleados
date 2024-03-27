using Microsoft.AspNetCore.Mvc;
using MVCCRUD.Models; // Asegúrate de importar el espacio de nombres donde tengas tus clases de modelo

namespace MVCCRUD.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmpleadoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmpleadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Empleado empleado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Empleados.Add(empleado);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al guardar el empleado: " + ex.Message);
            }
            return View(empleado);
        }
    }
}
