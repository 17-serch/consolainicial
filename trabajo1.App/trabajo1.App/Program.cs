using System;

namespace trabajo1.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            string edad = Console.ReadLine();
            int edad1 = int.Parse(edad);

            Console.Write("Ingrese su numero telefonico: ");
            var numTel = Console.ReadLine();

            Console.Write("Estado civil: ");
            var estadoCiv = Console.ReadLine();

            Console.Write("Ingrese su tipo de sangre: ");
            var grupoSang = Console.ReadLine();

            Console.Write("ingrese su peso: ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("ingrese su talla en metros: ");
            float talla = float.Parse(Console.ReadLine());

            Console.Write("¿Te gustaría ganar dinero?");
            bool dinero = Console.ReadLine().ToUpper()=="SI";

            var persona = new Persona();
            persona.nombre = nombre;
            persona.edad = edad;
            persona.peso = peso;
            persona.talla = talla;
            persona.numTel = numTel;
            persona.estadoCiv = estadoCiv;
            persona.grupoSang = grupoSang;
            persona.dinero = dinero;

            Console.WriteLine("la información que ingreso es la siguiente:");
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("edad: " + edad);
            Console.WriteLine("numero telefónico: " + numTel);
            Console.WriteLine("estado civil: " + estadoCiv);
            Console.WriteLine("tipo de sangre: " + grupoSang);
            Console.WriteLine("peso: " + peso);
            Console.WriteLine("talla: " + talla);
            Console.WriteLine("¿Te gustaría ganar dinero?: " + dinero);

            
        }
        static void SaludoInicial(string[]args)
        {
            if (args.Length > 0)
                Console.WriteLine("BIENVENIDO {0} {1} {2} {3}", args[0], args[1], args[2], args[3]);
            else
            {
                Console.WriteLine("BIENVENIDO DESCONOCIDO");
            }
            Console.WriteLine("¿CÓMO ESTÁS?");
            var estado = Console.ReadLine();
            Console.WriteLine("mmm, entiendo!");
            Console.ReadLine();
            Console.WriteLine(estado);
        }
    }
}
