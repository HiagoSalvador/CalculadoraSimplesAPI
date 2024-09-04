namespace calculadoraSimplesAPI.Models
{
    public class Calculadora
    {
        public double Valor1{get; set;}

         public double Valor2{get; set;}

          public double Resultado{get; set;}

          public Calculadora(){

          }

          public Calculadora(double valor1, double valor2){
            this.Valor1 = valor1;
            this.Valor2 = valor2;
          }

          public void Somar(){
            Resultado = Valor1 + Valor2;
          }

            public void Subtrair(){
            Resultado = Valor1 - Valor2;
          }

            public void Multiplicar(){
            Resultado = Valor1 * Valor2;
          }

            public void Dividir(){

              if (Valor2 == 0)
            {
                throw new DivideByZeroException("is not possible to divide by zero");
            }


            Resultado = Valor1 / Valor2;
          }
    }
}