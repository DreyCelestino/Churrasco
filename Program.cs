Console.Clear();

/*

Item	         Por adulto	 Por criança
Carne	           400g	        200g
Acompanhamentos	   200g	        200g
Cerveja	            2l	         --
Refrigerante	   500ml	    500ml
Água	           400ml	    400ml



--- Churrasco ---

Adultos (que consomem bebidas alcoólicas).......: 5
Adultos (que não consomem bebidas alcoólicas)...: 3
Crianças........................................: 6

Carne.............: 4,4kg
Acompanhamentos...: 2,8kg
Cerveja...........: 10,0l
Refrigerante......: 4,5l
Água..............: 5,6l

*/

int adultoqbebe;
int adultonbebe;
int crianca;

int Carne = 400;
//int Carnecrianca = 200;
int Acompanhamentos = 200;
int Cerveja = 2;
int Refrigerante = 500;
int Agua = 400;

float totalCarne;
float totalAcompanhamentos;
float totalCerveja;
float totalRefrigerante;
float totalAgua;

Console.WriteLine("Numero de adultos que consomem bebidas alcoolicas:");
adultoqbebe = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Numero de adultos que NÃO consomem bebidas alcoolicas:");
adultonbebe = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Numero de crianças:");
crianca = Convert.ToInt32(Console.ReadLine()!);


totalCarne = Carne * (adultonbebe + adultoqbebe) + (Carne * crianca)/2;
totalAcompanhamentos = Acompanhamentos * (adultonbebe + adultoqbebe + crianca);
totalCerveja = Cerveja * adultoqbebe;
totalRefrigerante = Refrigerante * (adultonbebe + crianca);
totalAgua = Agua * (adultonbebe + adultoqbebe + crianca);

Console.Write("Carne:".PadRight(19, '.'));
Console.Write($"{Math.Round(totalCarne/1000, 1)}");
Console.WriteLine("kg");

Console.Write("Acompanhamentos:".PadRight(19, '.'));
Console.Write($"{Math.Round(totalAcompanhamentos/1000, 1)}");
Console.WriteLine("kg");

Console.Write("Cerveja:".PadRight(19, '.'));
Console.Write($"{Math.Round(totalCerveja, 1)}");
Console.WriteLine("l");

Console.Write("Refrigerante:".PadRight(19, '.'));
Console.Write($"{Math.Round(totalRefrigerante/1000, 1)}");
Console.WriteLine("l");

Console.Write("Água:".PadRight(19, '.'));
Console.Write($"{Math.Round(totalAgua/1000, 1)}");
Console.WriteLine("l");
