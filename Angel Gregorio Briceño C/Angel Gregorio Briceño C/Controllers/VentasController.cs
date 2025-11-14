using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Angel_Gregorio_Briceño_C_.Models;
using System.Linq;
using System.Threading.Tasks;
using Angel_Gregorio_Briceno_C._Data;

namespace Angel_Gregorio_Briceño_C_.Controllers
{
    public class VentasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VentasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ventas
        public async Task<IActionResult> Index()
        {
            var ventas = await _context.Ventas
                .Include(v => v.Cliente)
                .Include(v => v.VentaDetalles)
                    .ThenInclude(vd => vd.Producto)
                .OrderByDescending(v => v.FechaVenta)
                .ToListAsync();
            return View(ventas);
        }

        // GET: Ventas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Ventas
                .Include(v => v.Cliente)
                .Include(v => v.VentaDetalles)
                    .ThenInclude(vd => vd.Producto)
                .FirstOrDefaultAsync(m => m.VentaId == id);

            if (venta == null)
            {
                return NotFound();
            }

            return View(venta);
        }

        // GET: Ventas/Create
        public IActionResult Create()
        {
            // Cargar productos con información de precio
            var productos = _context.Productos.Select(p => new {
                p.ProductoId,
                p.Nombre,
                p.Precio
            }).ToList();

            ViewData["Clientes"] = new SelectList(_context.Clientes, "ClienteId", "Nombre");
            ViewData["Productos"] = new SelectList(productos.Select(p => new SelectListItem
            {
                Value = p.ProductoId.ToString(),
                Text = $"{p.Nombre} - ${p.Precio}"
            }), "Value", "Text");

            return View();
        }

        // GET: Ventas/GetPrecioProducto
        [HttpGet]
        public async Task<JsonResult>
            GetPrecioProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                return Json(new { precio = producto.Precio });
            }
            return Json(new { precio = 0 });
        }

        // POST: Ventas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Venta venta)
        {
            // LIMPIAR errores de relaciones de navegación que no vienen del formulario
            ModelState.Remove("VentaDetalles[0].Venta");
            ModelState.Remove("VentaDetalles[0].Producto");
            ModelState.Remove("Cliente");

            // También limpia el error del Total (lo calcularemos después)
            ModelState.Remove("Total");

            if (ModelState.IsValid)
            {
                try
                {
                    // Calcular el total manualmente
                    venta.Total = venta.VentaDetalles.Sum(vd => vd.Cantidad * vd.Precio);
                    venta.FechaVenta = DateTime.Now;

                    _context.Ventas.Add(venta);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error al crear la venta: " + ex.Message);
                }
            }
            else
            {
                // Ver errores restantes (si los hay)
                var errors = ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .Select(x => new { Field = x.Key, Error = x.Value.Errors.First().ErrorMessage });

                foreach (var error in errors)
                {
                    Console.WriteLine($"ERROR POST-LIMPIEZA: {error.Field} - {error.Error}");
                }
            }

            ViewData["Clientes"] = new SelectList(_context.Clientes, "ClienteId", "Nombre");
            ViewData["Productos"] = new SelectList(_context.Productos, "ProductoId", "Nombre");
            return View(venta);
        }

        // GET: Ventas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Ventas
                .Include(v => v.Cliente)
                .Include(v => v.VentaDetalles)
                    .ThenInclude(vd => vd.Producto)
                .FirstOrDefaultAsync(m => m.VentaId == id);

            if (venta == null)
            {
                return NotFound();
            }

            return View(venta);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);
            _context.Ventas.Remove(venta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Ventas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Ventas
                .Include(v => v.VentaDetalles)
                .FirstOrDefaultAsync(m => m.VentaId == id);

            if (venta == null)
            {
                return NotFound();
            }

            ViewData["Clientes"] = new SelectList(_context.Clientes, "ClienteId", "Nombre", venta.ClienteId);
            ViewData["Productos"] = new SelectList(_context.Productos, "ProductoId", "Nombre");
            return View(venta);
        }
    }
}