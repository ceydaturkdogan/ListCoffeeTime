List<string> coffee=new List<string>(5);

Console.WriteLine("Lütfen 5 adet kahve ismi giriniz");


for (int i = 0; i < 5; i++)
{
    Console.Write($"Kahve {i+1}:");
    string coffeeItem = Console.ReadLine();
    coffee.Add(coffeeItem);
}

Console.WriteLine("Girilen Kahve İsimleri");

foreach (string item in coffee)
{
    Console.WriteLine(item); 
}