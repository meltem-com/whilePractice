int i = 1;
while (i <= 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

Console.WriteLine("-----------------------");

int k = 1;
while (k <=20)
{
    Console.WriteLine(k);
    k++;
}

Console.WriteLine("-------------------------");


int j = 1;
while (j <= 20)
{
    if (j % 2 == 0)

    { Console.WriteLine(j);

    }
    j++;
}

Console.WriteLine("---------------------------");


int toplam = 0;
int m = 50;

while (m <= 150)
{
    toplam += m; // Her sayıyı toplama ekle
    m++;
}

Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}");

Console.WriteLine("-----------------------------------");


int tekToplam = 0;
int ciftToplam = 0;
int p = 1;

while (p <= 120)
{
    if (p % 2 == 0) // Eğer sayı çift ise
    {
        ciftToplam += p;
    }
    else // Eğer sayı tek ise
    {
        tekToplam += p;
    }
    p++;
}

Console.WriteLine($"Tek sayıların toplamı: {tekToplam}");
Console.WriteLine($"Çift sayıların toplamı: {ciftToplam}");