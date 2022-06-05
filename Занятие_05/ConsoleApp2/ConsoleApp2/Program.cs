using ConsoleApp2;

City rostov = new City("Ростов-на-Дону", "Россия, Ростовская Область, Ростов-на-Дону", 10000, 1430000);
Megapolice moscow = new Megapolice("Москва", "Россия, Московская Область, Москва", 90000, 12430000);
Region rostovobl = new Region("Ростовcкая обл", "Россия, Ростовская Область", 10000, 45000);
rostovobl.sityAdd += new ConsoleApp2.EventHandler(Metodobrabotchik);
Console.WriteLine("Население Ростов.обл без Ростова в составе: " + rostovobl.Population);
rostovobl.add_city(rostov);
Console.WriteLine("Население Ростов.обл с доб. Ростова : " + rostovobl.Population);
Console.WriteLine("Население Ростова : " + rostov.Population);
Console.WriteLine("Ростов мегаполис : " + rostov.Check_megapolice());
rostov.population_people(4000000, "+");
Console.WriteLine("Население Ростова + 4000000 : " + rostov.Population);
Console.WriteLine("Ростов мегаполис : " + rostov.Check_megapolice());


static void Metodobrabotchik()

{

    Console.WriteLine("Ооо! Новый Город!");

}
