


double priceV = double.Parse(Console.ReadLine());
double priceF = double.Parse(Console.ReadLine());
double kgV = double.Parse(Console.ReadLine());
double kgF = double.Parse(Console.ReadLine());

double fullPriceV = priceV * kgV;
double fullPriceF = priceF * kgF;

double finalPrice = fullPriceF + fullPriceV;
double finalPriceEuro = finalPrice / 1.94;

Console.WriteLine($"{finalPriceEuro:f2}");