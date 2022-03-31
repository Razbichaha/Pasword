using System;

namespace Pasword
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "1234";
            string secretMessage = "Секретное сообщение";
            int tryCount = 3;

            for(int i = 0;i<tryCount;i++)
            {
                Console.Write("Введите пароль ");

                if(Console.ReadLine()==password)
                {
                    Console.WriteLine(secretMessage);
                    break;
                }else
                {
                    Console.WriteLine("Введен не верный пароль у вас осталось - " + (tryCount - i) + " попыток");
                }
            }

            Console.ReadLine();
        }
    }
}
