using System;

namespace TaskJunior2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int setValues;

            for (setValues = 5; setValues < 104; setValues += 7)
            {
                Console.WriteLine(setValues);
            }
            /// Учитывая тот факт что у нас имеется заданные (конкретные) значения начало (5)
            /// и конец (103), а также промежутки (7), поэтому мы выбрали цикл с параметром (for).
            /// А если у нас небыло конкретных значений начала или конца программы, ты мы бы выбрали цикл с условием (while).
        }
    }
}
