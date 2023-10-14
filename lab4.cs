using System;
using System.Collections.Generic;

namespace laboratorio_4
{
    class Rectangulo
    {
        public float Ancho { get; set; }
        public float Alto { get; set; }

        public Rectangulo(float ancho, float alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public float Perimetro()
        {
            return 2 * (Ancho + Alto);
        }

        public float Area()
        {
            return Ancho * Alto;
        }
    }

    class Avion
    {
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public float Velocidad_Maxima { get; set; }

        public Avion(string modelo, int capacidad, float velocidad_maxima)
        {
            Modelo = modelo;
            Capacidad = capacidad;
            Velocidad_Maxima = velocidad_maxima;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Capacidad de Pasajeros: {Capacidad}");
            Console.WriteLine($"Velocidad Máxima: {Velocidad_Maxima} km/h");
            Console.WriteLine();
        }
    }

    class Factura
    {
        public int Numero_factura { get; set; }
        public string Fecha_factura { get; set; }
        public double[] Productos_comprados { get; set; }

        public Factura(int numero_factura, string fecha_factura, double[] productos_comprados)
        {
            Numero_factura = numero_factura;
            Fecha_factura = fecha_factura;
            Productos_comprados = productos_comprados;
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var producto in Productos_comprados)
            {
                total += producto;
            }
            return total;
        }
    }

    class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string TipoAnimal { get; set; }

        public Mascota(string nombre, int edad, string tipoAnimal)
        {
            Nombre = nombre;
            Edad = edad;
            TipoAnimal = tipoAnimal;
        }
    }

    class Pelota
    {
        public string Tipo { get; set; }
        public float Diametro { get; set; }

        public Pelota(string tipo, float diametro)
        {
            Tipo = tipo;
            Diametro = diametro;
        }
    }

    class Restaurante
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<string> Menu { get; set; } = new List<string>();

        public void AgregarPlatoAlMenu(string plato)
        {
            Menu.Add(plato);
        }

        public void TomarPedido()
        {
            Console.WriteLine("Tomando pedido...");
            // Lógica para tomar pedidos
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("" +
                "\n---------MENU DE OPCIONES---------\n" +
                "1. Clase Rectángulo\n" +
                "2. Clase Avión\n" +
                "3. Clase Factura\n" +
                "4. Clase Mascota\n" +
                "5. Clase Pelota\n" +
                "6. Clase Restaurante\n\nIngresa una opción: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Rectangulo();
                    break;
                case 2:
                    Aviones();
                    break;
                case 3:
                    Facturas();
                    break;
                case 4:
                    Mascotas();
                    break;
                case 5:
                    Pelotas();
                    break;
                case 6:
                    Restaurantes();
                    break;
            }
        }

        public static void Rectangulo()
        {
            Console.WriteLine("Ingrese el ancho del rectángulo: ");
            float ancho = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el largo del rectángulo: ");
            float largo = float.Parse(Console.ReadLine());

            Rectangulo rectangulo = new Rectangulo(ancho, largo);

            Console.WriteLine("Rectángulo:");
            Console.WriteLine($"Área: {rectangulo.Area()}");
            Console.WriteLine($"Perímetro: {rectangulo.Perimetro()}");
            Console.WriteLine();
        }

        public static void Aviones()
        {
            int n_Aviones;

            Console.WriteLine("Ingrese la cantidad de aviones: ");
            n_Aviones = int.Parse(Console.ReadLine());
            Avion[] aviones = new Avion[n_Aviones];

            for (int i = 0; i < n_Aviones; i++)
            {
                Console.WriteLine($"\nIngresa la información del avión {i + 1}:");

                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();

                Console.Write("Capacidad de pasajeros: ");
                int capacidad = int.Parse(Console.ReadLine());

                Console.Write("Velocidad máxima: ");
                float velocidad_maxima = float.Parse(Console.ReadLine());

                aviones[i] = new Avion(modelo, capacidad, velocidad_maxima);
            }

            Console.WriteLine("\nInformación de los aviones:");
            foreach (var avion in aviones)
            {
                avion.MostrarInfo();
            }
        }

        public static void Facturas()
        {
            Console.WriteLine("Ingresa la cantidad de facturas: ");
            int cantidad_facturas = int.Parse(Console.ReadLine());

            Factura[] facturas = new Factura[cantidad_facturas];
            for (int i = 0; i < cantidad_facturas; i++)
            {
                Console.WriteLine($"FACTURA {i + 1}");
                Console.WriteLine("Ingresa el número de factura: ");
                int n_Factura = int.Parse(Console.ReadLine());

                Console.WriteLine(("Ingresa la fecha de la factura DD/MM/YY: "));
                string fecha_factura = Console.ReadLine();

                Console.WriteLine("Ingresa la cantidad de productos comprados: ");
                int cantidad_productos = int.Parse(Console.ReadLine());
                double[] productos = new double[cantidad_productos];

                for (int a = 0; a < cantidad_productos; a++)
                {
                    Console.WriteLine($"PRODUCTO {a + 1}: ");
                    Console.WriteLine("Ingresa el precio del producto: ");
                    productos[a] = double.Parse(Console.ReadLine());
                }

                facturas[i] = new Factura(n_Factura, fecha_factura, productos);

                Console.WriteLine("Productos comprados:");
                foreach (var producto in facturas[i].Productos_comprados)
                {
                    Console.WriteLine($"  Precio: {producto}");
                }

                Console.WriteLine($"Total: {facturas[i].CalcularTotal():C}");
            }
        }

        public static void Mascotas()
        {
            Console.WriteLine("Ingrese la cantidad de mascotas: ");
            int cantidadMascotas = int.Parse(Console.ReadLine());

            Mascota[] mascotas = new Mascota[cantidadMascotas];
            for (int i = 0; i < cantidadMascotas; i++)
            {
                Console.WriteLine($"\nIngrese información de la mascota {i + 1}:");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Tipo de animal: ");
                string tipoAnimal = Console.ReadLine();

                mascotas[i] = new Mascota(nombre, edad, tipoAnimal);
            }

            Console.WriteLine("\nInformación de las mascotas:");
            foreach (var mascota in mascotas)
            {
                Console.WriteLine($"Nombre: {mascota.Nombre}, Edad: {mascota.Edad}, Tipo: {mascota.TipoAnimal}");
            }
        }

        public static void Pelotas()
        {
            Console.WriteLine("Ingrese la cantidad de pelotas: ");
            int cantidadPelotas = int.Parse(Console.ReadLine());

            Pelota[] pelotas = new Pelota[cantidadPelotas];
            for (int i = 0; i < cantidadPelotas; i++)
            {
                Console.WriteLine($"\nIngrese información de la pelota {i + 1}:");

                Console.Write("Tipo: ");
                string tipo = Console.ReadLine();

                Console.Write("Diámetro: ");
                float diametro = float.Parse(Console.ReadLine());

                pelotas[i] = new Pelota(tipo, diametro);
            }

            Console.WriteLine("\nInformación de las pelotas:");
            foreach (var pelota in pelotas)
            {
                Console.WriteLine($"Tipo: {pelota.Tipo}, Diámetro: {pelota.Diametro}");
            }
        }

        public static void Restaurantes()
        {
            Console.WriteLine("Ingrese la cantidad de restaurantes: ");
            int cantidadRestaurantes = int.Parse(Console.ReadLine());

            Restaurante[] restaurantes = new Restaurante[cantidadRestaurantes];
            for (int i = 0; i < cantidadRestaurantes; i++)
            {
                Console.WriteLine($"\nIngrese información del restaurante {i + 1}:");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Dirección: ");
                string direccion = Console.ReadLine();

                restaurantes[i] = new Restaurante { Nombre = nombre, Direccion = direccion };

                Console.WriteLine("Ingrese platos al menú (ingrese 'fin' para terminar):");
                string plato;
                while ((plato = Console.ReadLine().ToLower()) != "fin")
                {
                    restaurantes[i].AgregarPlatoAlMenu(plato);
                }
            }

            Console.WriteLine("\nInformación de los restaurantes:");
            foreach (var restaurante in restaurantes)
            {
                Console.WriteLine($"Restaurante: {restaurante.Nombre}, Dirección: {restaurante.Direccion}");
                Console.WriteLine("Menú:");
                foreach (var plato in restaurante.Menu)
                {
                    Console.WriteLine($"  - {plato}");
                }
                Console.WriteLine();
            }
        }
    }
}
