
using calculadoraSimplesAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace calculadoraSimplesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController: ControllerBase
    {
        [HttpGet("Somar/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Somar(double valor1, double valor2){
            var calc = new Calculadora(valor1, valor2);
            calc.Somar();
            return Ok(calc);
        }

        
        [HttpGet("Subtrair/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Subtrair(double valor1, double valor2){
            var calc = new Calculadora(valor1, valor2);
            calc.Subtrair();
            return Ok(calc);
        }

        [HttpGet("Multiplicar/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Multiplicar(double valor1, double valor2){
            var calc = new Calculadora(valor1, valor2);
            calc.Multiplicar();
            return Ok(calc);
        }

        [HttpGet("Dividir/{valor1}/{valor2}")]
        public ActionResult<Calculadora> Dividir(double valor1, double valor2){
             try
            {
                var calc = new Calculadora(valor1, valor2);
                calc.Dividir();
                return Ok(calc);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}