﻿using ConsoleApp1;

//Book b4 = new Book("Толстой Л.Н.", "Анна Каренина", "Знание", 1204,
//2014, 103, true);
//Book b5 = new Book("Неш Т", "Программирование для профессионалов",
//"Вильямс", 1200, 2014, 108, true);

//b4.ReturnSrok = true;
//b5.ReturnSrok = true;



//Console.WriteLine("\nКниги возвращены в срок:");
//b4.ProcessPaperbackBooks(Operation.PrintTitle);
//b5.ProcessPaperbackBooks(Operation.PrintTitle);

Gamer gamerOne = new Gamer("Василий");

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine("Выпало количество очков " + gamerOne.SeansGame() + " для игрокапо имени " + gamerOne.ToString());
}


