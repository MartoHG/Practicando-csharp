using System.Numerics;

class HolaMundo
{
    struct Punto
    {
        int X , Y; 
        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public int WriteX()
        {
            return X;
        }
    }
    static void Main(string[] args)
    {
        Punto p =  new Punto(10,20);

        Console.WriteLine(p);

        Console.WriteLine(p.WriteX());
        
        Console.WriteLine("Hola Mundo");

        byte miByte = 15;
        Console.WriteLine(miByte);

        sbyte misByte = -120;
        Console.WriteLine(misByte);

        short miShort = 9121;
        Console.WriteLine(miShort);

        ushort miuShort = 60000;
        Console.WriteLine(miuShort);

        Console.Write("este es el resultado: ");
        Console.WriteLine(miuShort + miShort);

        int miEntero = 9122018;
        Console.WriteLine(miEntero);

        long miLong = 101278371293012;
        Console.WriteLine(miLong);
        //variables numericas con decimales
        float miFloat = 3.1422f;    //hay que usar la letra F al final
        Console.WriteLine(miFloat);

        double miDoble = 3.14172343f;
        Console.WriteLine(miDoble);

        decimal miDecimal = 0.234354353424343452452m;
        Console.WriteLine(miDecimal);

        //Variables logicas 

        bool miBoolean = false;

        string miString = "Esto es una cadena de texto";
        Console.WriteLine(miString);

        object miObjeto;

        miObjeto = 42;             // Un int
        miObjeto = "Hola Mundo";    // Un string
        miObjeto = 3.14;            // Un double
        miObjeto = new object();   // Una instancia de una clase

        Console.WriteLine("Ingresa tu edad:");
        string edad = Console.ReadLine();
        Console.WriteLine("Tu edad es: " + edad);

        //arrays

        int[] miArray = new int[5];
        miArray[0] = 2;
        miArray[1] = 4;
        miArray[2] = 6;
        miArray[3] = 8;
        miArray[4] = 10;

        Console.WriteLine(miArray[4]);

        int[,] matriz = new int[5, 2];
        matriz[0, 0] = 1;
        matriz[1, 0] = 30;
        matriz[2, 0] = 27;
        matriz[3, 0] = 120;
        matriz[4, 0] = 999;
        matriz[0, 1] = 42;
        matriz[0, 2] = 43;
        
        
    }
}

