using Actividad1;
Metodos mimetodo = new Metodos();
int op;
do
{
    Console.WriteLine("1- Vectores en tiempo de ejecución");
    Console.WriteLine("2- Memoria dinamica");
    Console.WriteLine("3- Salir");
    Console.Write("Seleccione una opción: ");
    if (!int.TryParse(Console.ReadLine(), out op))
    {
        Console.WriteLine("opción no valida");
        continue;
    }
    switch(op)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Ingresa el tramaño del vergtor");
            int tamaño = int.Parse(Console.ReadLine());
            int[] vector = new int[tamaño];
            Random rnd = new Random();
            for (int i = 0; i < tamaño; i++)
            {
                vector[i] = rnd.Next(1, 101);
            }
            for (int i = 0; i < tamaño; i++)
            {
                string cadena;
                cadena = "Numero: " + vector[i];
                Console.WriteLine(cadena);
            }
            Console.WriteLine("Enter para continuar");
            Console.ReadKey();
            Console.Clear();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Que numero quieres agregar a memoria dinamica");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Número inválido. Intenta nuevamente.");
                break;
            }
            Console.Clear();
            Console.WriteLine(mimetodo.Agregar(n));
            Console.ReadKey();
            Console.Clear();
            break;
    }
}
while (op != 3);