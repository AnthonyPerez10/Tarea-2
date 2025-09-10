// See https://aka.ms/new-console-template for more information

//Programa de manejo de String
//ID student: 11


Console.WriteLine("Ricardo Perez ID: ");
//Declaracion de las variables. 
int altura = 168;
int edad = 89;
string nombre = "Ricardo Perez";
string informacion = "Nacio en Hidalgo, es estudiante de gastronomia y astronomia";
var hobby = "Deportista";

string tarjetadeidentificacion = $"La informacion de {nombre} es la siguiente \nsu edad es de {edad} \nsu altura" +
    $"de {altura} cm \ninformacion revelante {informacion} \nhobby {hobby}\n" ;

//Console.WriteLine(informacion);
Console.WriteLine(tarjetadeidentificacion);
