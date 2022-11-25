using System.Collections;
using System.Diagnostics;
using Свойства_класса_треш;

WriteLine("Программа для работы с датами.");
Nachalo:
WriteLine("Введите 1, если хотите ввести дату вручную");
WriteLine("Введите 2, если хотите получить дату по стандарту");
WriteLine("Введите 3, если хотите получить сегодняшний день");
string choise = ReadLine();
EzDate Date = new EzDate();

switch (choise)
{
    case "1":
        Write("Введите год в формате Day.Month.Year   ");
        var ReadDate = ReadLine();
        while (DateTime.TryParse(ReadDate, out var z)==false)
            {
                Write("Неверный формат даты. Попробуйте еще раз: ");
                ReadDate = ReadLine();
            }
        var dateSplit= ReadDate.Split(".");
        Date = new EzDate(new DateTime(int.Parse(dateSplit[2]), int.Parse(dateSplit[1]), int.Parse(dateSplit[0])));
        break;
    
    case "2":
        Date = new EzDate();
        break;
    case "3":
        Date.Date = DateTime.Now;
        break;
    default:
        WriteLine("Вы ввели неверную дату");
        WriteLine();
        goto Nachalo;
        break;
        }

WriteLine();
Date.PreviousDay();
Date.PresentDay();
Date.NextDay();
Date.EndMonth();
WriteLine(Date.Viso == true ? "Год является високосным." : "Год не является високосным");