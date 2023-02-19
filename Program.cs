namespace Ejercicios_Capitulo_10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduzca que ejericicio desea ejecutar: ");
            Console.WriteLine("1. Ejericio 1\n2. Ejercio 2\n3. Ejercicio 3\n4. Ejercicio 4\n5. Ejercicio 5\n6. Salir");
            int op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    Ejericio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Ejerccio4();
                    break;
                case 5:
                    Ejercicio5();
                    break;

            }
            
        }

        public static void Ejericio1()
        {
            Inventario inventario = new Inventario();

            inventario.AgregarProducto(new Producto { Codigo = 1, Nombre = "Leche", Precio = 2.5m, Cantidad = 10 });
            inventario.AgregarProducto(new Producto { Codigo = 2, Nombre = "Pan", Precio = 1.0m, Cantidad = 20 });
            inventario.AgregarProducto(new Producto { Codigo = 3, Nombre = "Huevos", Precio = 0.5m, Cantidad = 30 });

            Producto producto = inventario.BuscarProducto(2);
            Console.WriteLine($"Producto encontrado: {producto.Nombre}");
        }

        public static void Ejercicio2()
        {
            Escuela escuela = new Escuela();

            // Agregar estudiantes
            escuela.AgregarEstudiante(new Estudiante { Nombre = "Juan Soto", Edad = 27, Grado = 12 });
            escuela.AgregarEstudiante(new Estudiante { Nombre = "Luis Toribio", Edad = 22, Grado = 10 });
            escuela.AgregarEstudiante(new Estudiante { Nombre = "Vladimir Guerrero Jr", Edad = 26, Grado = 12 });

            // Buscar un estudiante
            Estudiante estudiante = escuela.BuscarEstudiante("Maria Gomez");
            Console.WriteLine($"Estudiante encontrado: {estudiante}");

        }
        public static void Ejercicio3()
        {
            Console.WriteLine("Sin informacion");
        }
        public static void Ejerccio4()
        {
            Console.WriteLine("Sin informacion");

        }
        public static void Ejercicio5()
        {
            Poligono p = new Poligono(5, 8.0);

            Console.WriteLine(p.ToString());
        }

    }

}