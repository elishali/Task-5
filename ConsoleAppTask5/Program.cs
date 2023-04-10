namespace ConsoleAppTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tapsiriq1();
            //Tapsiriq2();
            //Tapsiriq3();
            //Tapsiriq4();
            //Tapsiriq5();
            //Tapsiriq6();
            //Tapsiriq7();
            //Tapsiriq8();
            //Tapsiriq9();
            //Tapsiriq10();
            //Tapsiriq11();
            //Tapsiriq12();
            //Tapsiriq13();
            //Tapsiriq14();
            //Tapsiriq15();

        }
        static int SumOf(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static bool IsPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static bool ContainsAnyDigit(int number, int[] digits)
        {
            foreach (char c in number.ToString())
            {
                if (Array.IndexOf(digits, int.Parse(c.ToString())) >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool ContainsSumOfDigits(int number, int sum)
        {
            int total = 0;
            foreach (char c in number.ToString())
            {
                total += int.Parse(c.ToString());
            }
            return total == sum;
        }

        private static void Tapsiriq15()
        {
            /* 1-10000 qeder ederlerin icerisinden  ele ededleri cap etki :
               hem sade eded olsun
               hem ededin ozunun daxilinde 0,1,5,7,9 reqemleri olmasin
               hem ededin reqemleri ceminde 2 reqemi olmasin*/

            for (int i = 1; i <= 10000; i++)
            {
                if (IsPrime(i) && !ContainsAnyDigit(i, new[] { 0, 1, 5, 7, 9 }) && !ContainsSumOfDigits(i, 2))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void Tapsiriq14()
        {
            /*1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
              hem ededin ozunun daxilinde minimum 2 dene 5 olsun,
              hem ededin ozunun daxilinde 2 dene yanashi gelen 1 reqemi olsun
              hem ededin reqemleri cemi 7- 15 arasinda olsun.
              hem ededin reqemlerinin daxilinde 6 reqemi olmasin*/

            for (int i = 1; i <= 100000; i++)
            {
                if (i.ToString().Split('5').Length - 1 >= 2 && i.ToString().Contains("11") && !i.ToString().Contains("6"))
                {
                    int sam = 0;
                    foreach (char c in i.ToString())
                    {
                        sam += int.Parse(c.ToString());
                    }
                    if (sam >= 7 && sam <= 15)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        private static void Tapsiriq13()
        {
            /* 1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
               hem butun reqemleri yalniz tek ededlerden ibaret olsun,
               polindrom olsun,
               daxilinde minimum 1 dene 5 reqemi olsun*/

            for (int i = 1; i <= 100000; i++)
            {
                bool oddnumber = true;
                foreach (char c in i.ToString())
                {
                    int number = int.Parse(c.ToString());
                    if (number % 2 == 0)
                    {
                        oddnumber = false;
                        break;
                    }
                }

                if (oddnumber)
                {
                    string rev = "";
                    foreach (char c in i.ToString())
                    {
                        rev = c.ToString() + rev;
                    }
                    if (i.ToString() == rev)
                    {
                        if (i.ToString().Contains("5"))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }

        private static void Tapsiriq12()
        {
            /* 1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
               hem butun reqemleri eyni olsun,
               hem reqemleri cemi 5 den boyuk olsun
               hem reqemleri arasinda 5 reqemi olmasin */

            int sumDigit;

            for (int i = 1; i <= 100000; i++)

            {
                int newn = 0, m, q;
                m = i;
                while (m != 0)
                {
                    q = m % 10;
                    newn = newn * 10 + q;
                    m = m / 10;
                }
                if (i % 10 == 5)
                {
                    continue;
                }
                if ((i / 10) % 10 == 5)
                {
                    continue;
                }
                if ((i / 100) % 10 == 5)
                {
                    continue;
                }
                if ((i / 1000) % 10 == 5)
                {
                    continue;
                }
                if ((i / 10000) % 10 == 5)
                {
                    continue;
                }
                if (i / 100000 == 5)
                {
                    continue;
                }
                sumDigit = SumOf(i);

                if (sumDigit > 5)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void Tapsiriq11()
        {
            /*1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
               hem polindrom olsun,
               hem ededin reqemleri daxilinde 3 olmasin
               hem ededin reqemleri cemi 10 dan boyuk olsun*/

            int sumDigit;
            for (int i = 1; i <= 1000; i++)

            {
                int newn = 0, m, q;
                m = i;
                while (m != 0)
                {
                    q = m % 10;
                    newn = newn * 10 + q;
                    m = m / 10;
                }

                if (newn == i && i % 10 != 3 && (i / 10) % 10 != 3 && i / 100 != 3)
                {
                    sumDigit = SumOf(i);

                    if (sumDigit > 10)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }

        private static void Tapsiriq10()
        {
            /*1-1000 qeder CUT ederlerin icerisinde
             reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir?*/

            int sumDigit;

            for (int i = 1; i <= 1000; i++)
            {

                if (i / 2 == 0)
                {
                    continue;
                }
                sumDigit = SumOf(i);

                if (sumDigit > 5 && sumDigit < 7)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void Tapsiriq9()
        {
            /* 1-1000 qeder ederlerin icerisinde
            11-e bolunub reqemleri cemi 11-den boyuk olan 
            11-ci eded hansidir?*/

            int sumDigit;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 11 == 0)
                {
                    continue;
                }
                sumDigit = SumOf(i);

                if (sumDigit > 11)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void Tapsiriq8()
        {
            /*1-1000 qeder ederlerin icerisinden,
            daxilinde 3 reqemi olmayib,
            reqemleri cemi 3 olan en sonuncu eded hansidir?*/

            int sumDigit;
            for (int i = 1; i <= 1000; i++)
            {

                if (i % 10 == 3)
                {
                    continue;
                }
                if ((i / 10) % 10 == 3)
                {
                    continue;
                }
                if ((i / 100) % 10 == 3)
                {
                    continue;
                }
                sumDigit = SumOf(i);

                if (sumDigit != 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        private static void Tapsiriq7()
        {
            /*1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
              hemin ededin daxilinde 3 reqemi umumiyyetle olmasin*/


            for (int i = 1; i <= 1000; i++)
            {

                if (i % 10 != 3 && (i / 10) % 10 != 3 && i / 100 != 3)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void Tapsiriq6()
        {
            /* 1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
               hem ozu cut eded olsun,
               hem reqemleri cemi tek eded olsun,
               hem I reqemi tek eded olsun*/

            int sumDigit;
            int firstDigit;
            int countDigit;
            for (int i = 1; i <= 1000; i++)
            {
                if ((i % 2) != 0)
                {
                    continue;
                }
                sumDigit = SumOf(i);

                if (sumDigit % 2 == 0)
                {
                    continue;
                }
                countDigit = (int)Math.Log10(i);
                int pow = (int)Math.Pow(10, countDigit);
                firstDigit = i / pow;

                if (firstDigit % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void Tapsiriq5()
        {
            /*1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
               hem reqemleri cemi 5-e bolunsun,
               hem de ozu 5-e bolunsun*/


            for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;
                int a = i;
                while (a != 0)
                {
                    int r = a % 10;
                    a /= 10;
                    sum += r;
                }
                if (sum % 5 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }

        private static void Tapsiriq4()
        {
            /*1-1000 qeder ederlerin icerisinden ele ededleri cap etki
           reqemleri cemi 3 e bolunsun ve sonuncu reqem 3 olmasin.*/

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 10 != 3)
                    {
                        Console.WriteLine($"{i}");
                    }

                }
            }
        }

        private static void Tapsiriq3()
        {
            /* 1-1000 qeder ederlerin icerisinden  ele ededleri cap et ki, reqemleri cemi 3-e bolunsun*/

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}");

                }
            }
        }

        private static void Tapsiriq2()
        {
            /*1-1000 qeder ededlerin icerisinde hem 7-e, hemde 8-e bolunenlerin siyahisi*/

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0 && i % 8 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }

        private static void Tapsiriq1()
        {
            /*1-1000 qeder ededlerin cemi 7 bolunurmu?*/


            for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;
                int a = i;
                while (a != 0)
                {
                    int r = a % 10;
                    a /= 10;
                    sum += r;
                }
                if (sum % 7 == 0)

                    Console.WriteLine(i);
            }
        }
    }
}
