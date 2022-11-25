namespace Свойства_класса_треш;

class EzDate
{
    private DateTime date;
    public DateTime Date 
   {
       get => date;
       set
       {
           date = value;
       }
   }

    public bool Viso
    {
        get
        {
            return DateTime.IsLeapYear(date.Year);
        }
    }

   public EzDate() => this.date = new DateTime(2009,01,01); //Конструктор по умолчанию
   public EzDate(DateTime date) => this.date = date; //Кастом конструктор
   
   public void PresentDay() => WriteLine($"Нынешняя дата: {date.Day:00}.{date.Month:00}.{date.Year:0000}"); // текущий день

   public void PreviousDay() //предыдущий день
   {
       var prev = date.AddDays(-1);
       WriteLine($"Предыдущий день: {prev.ToShortDateString()}");
   } 
   public void NextDay() // Следующий день
   {
       var next = date.AddDays(1);
       WriteLine($"Следующий день: {next.ToShortDateString()}");
   }
   public void EndMonth() => WriteLine($"До конца месяца осталось {DateTime.DaysInMonth(date.Year, date.Month)-date.Day} дней");
   

}