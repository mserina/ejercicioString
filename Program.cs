
namespace ejercicioString
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Texto original
            Console.WriteLine("TEXTO ORIGINAL");
            string texto = "Es un lenguaje de programación multiparadigma desarrollado y est" +
                "andarizado por la empresa Microsoft como parte de su plataforma .NET, que despué" +
                "s fue aprobado como un estándar por la ECMA e, ISO. C# es uno de los lenguajes de pro" +
                "gramación diseñados para la infraestructura de lenguaje común";
            Console.WriteLine(texto);
            Console.WriteLine(" ");


            //Añadir espacios
            Console.WriteLine("TEXTO ESPACIOS");
            string separado = String.Concat(" "," " ,texto," ", " ");
            Console.WriteLine(separado);
            Console.WriteLine(" ");

            //Quitar espacios
            Console.WriteLine("ESPACIOS DERECHA E IZQUIERDA REMOVIDOS");
            string quitarEspaciostexto = separado.Trim();
            Console.WriteLine(quitarEspaciostexto);
            Console.WriteLine(" ");


            //Dividir texto por un caracter
            Console.WriteLine("DIVIDIR TEXTO POR CARACTER");
            string[] textoSeparado = texto.Split(", ");

            foreach (string parrafos in textoSeparado)
            {
                Console.WriteLine(parrafos);
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");

            //Contar " a "
            Console.WriteLine("CONTAR A");
        }       
    }
}