// See https://aka.ms/new-console-template for more information

//Programas de Operadores Logicos
//ID student: 11

/*
bool val1 = true;
bool val2 = false;
bool val3 = false;
*/

//var (val1, val2, val3) = (true, true, false);

var (val1, val2, val3) = (true, true, true);

bool resultAnd = val1 && val2 && val3;
Console.WriteLine(resultAnd);

bool resultOr = val1 || val2 || val3;
Console.WriteLine(resultOr);

bool resultAndOr = (val1 && val2) || val3;
Console.WriteLine(resultAndOr);

bool resultNot = !val1;
Console.WriteLine(resultNot);

bool resultXor = (val1 ^ val2) ^ val3;
Console.WriteLine(resultXor);
