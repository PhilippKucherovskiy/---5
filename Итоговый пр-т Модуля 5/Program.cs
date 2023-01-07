using System;

namespace Итоговый_пр_т_Модуля_5
{
    class Program
    {
       static (string Name, string Surname, int Age) Main(string[] args)
       {
            (string Name, string Surname, int Age) User1;
            
            var tulpe = EnterUser();

            static (string Name, string Surname, int Age) EnterUser();
            
            { 
                Console.WriteLine("Введите Ваше имя:");
                User1.Name = Console.ReadLine();

                Console.WriteLine("Введите Вашу фамилию:");
                User1.Surname = Console.ReadLine();

                string age;
                int intage;
                do
                {
                    Console.WriteLine("Введите Ваш возраст цифрами:");
                    age = Console.ReadLine();
                    
                } while (CheckNum(age, out intage) == true); 

                User1.Age = intage;
                return User1;
            }
            //номер проверочный  метод
            static bool CheckNum(string number, out int corrnumber)
            {
                if (int.TryParse(number, out int intnum))
                {
                    if (intnum > 0)
                    {
                        corrnumber = intnum;
                        return false;
                    }
                }
                {
                    corrnumber = 0;
                    return true;
                }
            }
           
            
            //подсчет животных и проверка
            static bool CheckHasPets()
            {
                Console.WriteLine("У Вас есть домашние животные (Да/Нет?");

                string HasPetsLocal = Console.ReadLine();

                if (HasPetsLocal == "Да")
                { return true; }
                return false;
            }
             
            
           (bool HasPets, int PetsAmount, string [] PetsNames, bool HasColors, int ColorsAmount, string [] FavColors) User;
            CheckHasPets();
            User.HasPets = CheckHasPets();
            string petcount;
            int petamount;
            if (User.HasPets == true)
            {
                do
                {
                    Console.WriteLine("Введите количество питомцев цифрами:");
                    petcount = Console.ReadLine();

                } while (CheckNum(petcount, out petamount) == true);
            }
            User.PetsNames = PetsNames(petamount);
            PetsNames(petamount);
            //метод для массива имен животных
            static string[] PetsNames(int petamount)
            {
                var resultpet = new string[petamount];
                for (int i = 0; i < resultpet.Length; i++)
                {
                    Console.Write("Назовите клички Ваших питомцев");
                    Console.Write(i + 1 + ":");
                    resultpet[i] = Console.ReadLine();
                }
                Console.WriteLine("У Вас {0} питомцев. Клички ваших питомцев: ", petamount);
                foreach (var pets_names in resultpet)
                {
                    Console.Write(pets_names + ", ");
                }

                return resultpet;
            }
            HasColors();
            //введите любимые цвета
            static bool HasColors()
            {
                Console.WriteLine("У Вас есть любимые цвета (Да/Нет?");

                string HasColorsLocal = Console.ReadLine();

                if (HasColorsLocal == "Да")
                { return true; }
                return false;
            }
            User.HasColors = HasColors();
            string colorcount;
            int coloramount;
            if (User.HasColors == true)
            {
                do
                {
                    Console.WriteLine("Введите количество любимых цветов цифрами:");
                    colorcount = Console.ReadLine();

                } while (CheckNum(colorcount, out coloramount) == true);
            }
            User.FavColors = ColorsNames(coloramount);
            ColorsNames(coloramount);
            //метод для массива цветов 
            static string[] ColorsNames(int coloramount)
            {
                var resultcolor = new string[coloramount];
                for (int i = 0; i < resultcolor.Length; i++)
                {
                    Console.Write("Назовите Ваши любимые цвета:");
                    Console.Write(i + 1 + ":");
                    resultcolor[i] = Console.ReadLine();
                }
                Console.WriteLine("У Вас {0} любимых цветов. Названия Ваших любимых цветов: ", coloramount);
                foreach (var colors_names in resultcolor)
                {
                    Console.Write(colors_names + ", ");
                }

                return resultcolor;
            }
            Print();
            static void Print()
            {
                Console.WriteLine("Таким образом Ваша Анкета выглядит так:");
                Console.WriteLine("Ваше имя: {0}, /n Ваша фамилия:{1}, Есть ли домашние животные?{2}, Клички Ваших домашних животных:{3}, Есть ли любимые цвета? {4}, Любимые цвета: {5}");
            }
            Console.ReadKey();
        }
            

       
    }

}
