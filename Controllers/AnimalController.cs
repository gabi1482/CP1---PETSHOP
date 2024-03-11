using Microsoft.AspNetCore.Mvc;

namespace CP1___PETSHOP.Controllers
{

    [ApiController]
    [Route("/api/[controller]")]
    public class AnimalController : ControllerBase
    {
        public static Animal Cachorro = new Animal();

        [HttpGet]
        public ActionResult<Animal> get()
        {
            return Ok(Cachorro);
        }
    }
}
