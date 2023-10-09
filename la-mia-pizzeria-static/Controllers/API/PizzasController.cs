using la_mia_pizzeria_static.Database;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace la_mia_pizzeria_static.Controllers.API
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class PizzasController : ControllerBase	
	{
		[HttpGet]
		public ActionResult GetPizze()
		{
			using (PizzaContext db = new PizzaContext()) 
			{
				List<Pizza> pizze = db.Pizze.Include(pizza => pizza.Gusti).ToList();

				return Ok(pizze);
			}
			
		}
	}
}
