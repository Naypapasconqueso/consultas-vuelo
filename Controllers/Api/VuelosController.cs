using Microsoft.AspNetCore.Mvc;

[Route("api/vuelos")]
public class VuelosController : ControllerBase {

    [HttpGet("ciudades-origen")]
    public IActionResult CiudadesOrigen(){
        return Ok();
    }
    
    [HttpGet("ciudades-destino")]
    pu
 }

