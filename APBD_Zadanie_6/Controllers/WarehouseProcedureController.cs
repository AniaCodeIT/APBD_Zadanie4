using APBD_Task_6.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie_6.Controllers
{
    [Route("api/warehouse2")]
    [ApiController]
    public class WarehouseProcedureController : Controller
    {
        [HttpPost]
        public IActionResult AddProductToWarehouse(ProductWarehouse productWarehouse)
        {
            return View();
        }
    }
}
