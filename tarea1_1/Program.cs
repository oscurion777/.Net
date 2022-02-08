// variable como string

var saludo = "Hello";




// variable como un int

var i = 5;

//variable como int[]

var a = new[] {0, 1, 2 };

//variable tipo parametro

var z =  (0, 0);

//Variable 

var incognito = new { Name = "Juan", Age = 18 };




// Variable List

var list = new List<int>();


// PUNTO 2 

// Conversiones Implicita

int ik = 1;
long h = 1;

long l = 1;
double d = 1;

// PUNTO 3

// Conversiones Explicita

int i2 = 2;
long l2 = (int)2;

long d2 = 2;
double d22 = (double)2;

// Punto 4


string value = "8970";

int numberValue = int.Parse(value);
Console.WriteLine(numberValue);




string zodiaco = "100";
double numberZodiaco = double.Parse(zodiaco);
Console.WriteLine(numberZodiaco);



string ki = "500";
int vegueta_ki = int.Parse(ki);
Console.WriteLine(ki);

//Punto 5

// Con error
try
{
    string value3 = "50000a";
    double numberValue3 = double.Parse(value3);
    Console.WriteLine(numberValue3);
}
catch (Exception)
{
    Console.WriteLine("Error de conversión");
}


// Sin error
try
{
    string value3 = "500000";
    double numberValue3 = double.Parse(value3);
    Console.WriteLine(numberValue3);
}
catch (Exception)
{
    Console.WriteLine("Error de conversión");
}
