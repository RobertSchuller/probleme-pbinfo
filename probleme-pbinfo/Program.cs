using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Xml.Schema;

namespace pbinfo
{
    internal class Program
    {
        private  static bool PatratPerfect(int x)
        {
            bool b = false;
            for(int i = 1; i * i <= x; i++)
            {
                if (i * i == x)
                    b = true;
                else
                    b = false;
            }
            if (b)
                return true;
            else
                return false;
        }
        private static int div(int x)
        {
            int cnt = 0;
            for (int i = 1; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    cnt++;
                    if (x / i != i)
                        cnt++;
                }
            }
            return cnt;
        }
        static void Swap(ref int x, ref int y)
        {
            int tempswap = x;
            x = y;
            y = tempswap;
        }

        static void Main(string[] args)
        {
            //  4.04.2022

            //P2263();
            //P3210();
            //P3978();
            //P3180();
            //P3182();
            //P3181();
            //P2201();
            //P2617();
            //P2938();
            //P2599();
            //P1289();
            //P2602();
            //P3803();


            //Structuri repetitive

            //P1261();??
            //P327();
            //P328();
            //P3984();
            //P3983();
            //P3231();
            //P330();
            //P3232();
            //P331();
            //P3233();
            //P2222();
            //P1681();
            //P2747();
            //P348();
            //P2572();
            //P351();
            //P1684();
            //P456();
            //P457();
            //P2();
            //P51();
            //P2299();
            //P459();
            //P52();
            //P115();
            //P3074();
            //P2915();
            //P1650();
            //P2766();
            //P654();
            //P2757();
            //P246();
            //P560();
            //P254();


            // Structura de decizie

            //P3275();
            //3060
            //2616
            //1464
            //P2419();
            //P2311();
            //P1303();
            //P3805();
            //P3185();
            //P1310();
            //P2752();
            //P1625();
            //P833();
            //P1002


            //Algoritmi elementari

            //P860();
            //P3183();
            //P1544();
            //P1468();
            //P354();
            //P347();
            //P54();
            //P171();
            //P346();
            //P2269();
            //P119();
            //P3284();
            //P2257();
            //P2223();
            //P1613();
            //P3933();
            //P3079();
            //P4018();
            //P127();
            //P3251();
            //P370();
            //P977();
            //P2289();
            //P340();
            //P3076();
            //P360();
            //P2661();
            //P363();
            //P2290();
            //P364();
            //P365();
            //P376();
            //P387();
            //P3270();
            //P388();
            //P3663();
            //P61();



            // Vectori

            //P633()
            //P546();
            //P489();
            //P486();
            //P553(); 
            //P98();
            //P99();
            //Balog1();
            //Balog2();
            //Balog3();
            //Balog4();
            //Balog5();
            //Balog6();
            //Balog7();
            //Balog8();
            //P287();
            //P2689();
            //P2938();
            //P1329();
            //P510();
            //P272();
            //P618();
            //P180();
            //P513();
            //P1608();
            //P183();
            //P241();
            //P3824();
            P250();


        }

        //Algoritmi elementari
        private static void P61()
        {
            string[] d = Console.ReadLine().Split(' ');
            int a = int.Parse(d[0]);
            int b = int.Parse(d[1]);
            int r = 0;
            int n = 0;
            if (a == 0)
            {
                n = b;
            }
            else if (b == 0)
            {
                n = a;
            }
            else
            {
                while (b != 0)
                {
                    r = a % b;
                    a = b;
                    b = r;
                }
                n = a;
            }
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        private static void P3663()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                }
            }
            Console.WriteLine(min * min);
        }
        private static void P388()
        {
            int n = int.Parse(Console.ReadLine());
            int contor = 0;
            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i % 2 == 0)
                    {
                        contor++;
                    }
                    if (n / i != i && (n / i) % 2 == 0)
                    {
                        contor++;
                    }
                }
            }
            Console.WriteLine(contor);
        }
        private static void P3270()
        {
            int n = int.Parse(Console.ReadLine());
            long S = 0;
            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i % 2 == 0)
                    {
                        S += i;
                    }
                    if (n / i != i && (n / i) % 2 == 0)
                    {
                        S += n / i;
                    }
                }
            }
            Console.WriteLine(S);
        }
        private static void P387()
        {
            int n = int.Parse(Console.ReadLine());
            long S = 0;
            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i % 2 == 1)
                    {
                        S += i;
                    }
                    if (n / i != i && (n / i) % 2 == 1)
                    {
                        S += n / i;
                    }
                }
            }
            Console.WriteLine(S);
        }
        private static void P376()
        {
            int n = int.Parse(Console.ReadLine());
            int S = 0;
            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    S += i;
                    if (n / i != i)
                    {
                        S += n / i;
                    }
                }
            }
            Console.WriteLine(S);
        }
        private static void P365()
        {
            string[] d = Console.ReadLine().Split(' ');
            int n = int.Parse(d[0]);
            int m = int.Parse(d[1]);
            int aux = 0;
            int b = 0;
            bool a = false;
            while (n != 0)
            {
                aux = n % 10;
                b = m;
                while (b != 0)
                {
                    int aux1 = b % 10;
                    b /= 10;
                    if (aux == aux1)
                    {
                        a = true;
                    }
                }
                n /= 10;
            }
            if (a)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }
        }
        private static void P364()
        {
            int n = int.Parse(Console.ReadLine());
            int M = 0;
            string[] d = Console.ReadLine().Split(' ');
            int oglindit = 0;
            int a = 0;
            int maxim = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(d[i]);
                int aux = m;
                oglindit = 0;
                while (aux != 0)
                {
                    oglindit = oglindit * 10 + aux % 10;
                    aux /= 10;
                }
                a = oglindit % 10;
                if (a > maxim)
                {
                    maxim = a;
                    M = m;
                }
                if (a == maxim)
                {
                    if (m > M)
                    {
                        M = m;
                    }
                }
            }
            Console.WriteLine(M);
        }
        private static void P2290()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int min = int.MaxValue;
            int ret = 0;
            for (int i = 0; i < n; i++)
            {
                int oglindit = 0;
                int m = int.Parse(d[i]);
                int aux = m;
                while (aux != 0)
                {
                    oglindit = oglindit * 10 + aux % 10;
                    aux /= 10;
                }
                int a = Math.Abs(m - oglindit);
                if (a < min)
                {
                    min = a;
                    ret = m;
                }
                if (a == min)
                {
                    if (m < ret)
                    {
                        ret = m;
                    }
                }
            }
            Console.WriteLine(ret);
        }
        private static void P363()
        {
            int n = int.Parse(Console.ReadLine());
            int S = 0;
            int oglindit = 0;
            while (n != 0)
            {
                oglindit = oglindit * 10 + n % 10;
                n /= 10;
            }
            while (oglindit != 0)
            {
                S += oglindit % 10;
                oglindit /= 100;
            }
            Console.WriteLine(S);


        }
        private static void P2661()
        {
            long n = long.Parse(Console.ReadLine());
            long aux = n, putere = 1;
            long a = 0, b = 0;
            while (aux >= putere)
            {
                aux /= 10;
                putere *= 10;
            }
            a = aux;
            putere /= 10;
            b = n % putere;
            Console.WriteLine(a * putere + b);
        }
        private static void P360()
        {
            string[] d = Console.ReadLine().Split(' ');
            int n = int.Parse(d[0]);
            int c = int.Parse(d[1]);
            int M = 0;
            int putere = 1;
            int contor = 0;
            int cif = 0;
            int aux = n;
            while (aux != 0)
            {
                contor++;
                if (aux % 10 == c)
                {
                    cif++;
                }
                aux /= 10;
            }
            if (contor == cif)
            {
                Console.WriteLine("-1");
            }
            else
            {
                while (n != 0)
                {
                    cif = n % 10;
                    if (cif != c)
                    {
                        M += cif * putere;
                        putere *= 10;
                    }
                    n /= 10;
                }
            }
            Console.WriteLine(M);
        }
        private static void P3076()
        {
            int n = int.Parse(Console.ReadLine());
            int S = 0;
            int aux = 0;
            int contor = 0;
            int putere = 1;
            while (n != 0)
            {
                contor++;
                aux += n % 10;
                n /= 10;
            }
            for (int i = 1; i <= contor; i++)
            {
                S += aux * putere;
                putere *= 10;
            }
            Console.WriteLine(S);
        }
        private static void P340()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int c = 0;
            int sum1 = 0;
            if (n > 9)
            {
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                while (sum > 0)
                {
                    c += sum % 10;
                    sum /= 10;
                }
                while (c > 0)
                {
                    sum1 += c % 10;
                    c /= 10;
                }
            }
            Console.WriteLine(sum1);
        }
        private static void P2289()
        {
            string[] d = Console.ReadLine().Split(' ');
            int n = int.Parse(d[0]);
            int m = int.Parse(d[1]);
            int cif = 0;
            int cif1 = 0;
            int p = 1;
            int p1 = 1;
            int a = n;
            int b = m;
            if (n % 2 == 0)
            {
                while (n != 0)
                {
                    if (n % 10 % 2 == 0)
                    {
                        cif += n % 10 * p;
                        p *= 10;
                    }
                    n /= 10;
                }
            }
            if (n % 2 == 1)
            {
                while (n != 0)
                {
                    if (n % 10 % 2 == 1)
                    {
                        cif += n % 10 * p;
                        p *= 10;
                    }
                    n /= 10;
                }
            }
            if (m % 2 == 0)
            {
                while (m != 0)
                {
                    if (m % 10 % 2 == 0)
                    {
                        cif1 += m % 10 * p1;
                        p1 *= 10;
                    }
                    m /= 10;
                }
            }
            if (m % 2 == 1)
            {
                while (m != 0)
                {
                    if (m % 10 % 2 == 1)
                    {
                        cif1 += m % 10 * p1;
                        p1 *= 10;
                    }
                    m /= 10;
                }
            }
            if (cif == cif1)
            {
                if (a > b)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            else if (cif > cif1)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }

        }
        private static void P977()
        {
            int n = int.Parse(Console.ReadLine());
            int r = 0;
            int aux;
            int putere = 1;
            while (putere <= n)
            {
                int p = putere * 10;
                aux = n / (p * 10) * putere + n % putere;
                if (aux != 0)
                {
                    if (n % aux > r)
                    {
                        r = n % aux;

                    }
                }
                putere *= 10;
            }
            Console.WriteLine(r);

        }
        private static void P370()
        {
            string[] d = Console.ReadLine().Split(' ');
            int k = int.Parse(d[0]);
            int n = int.Parse(d[1]);
            string[] s = Console.ReadLine().Split(' ');
            int S = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                int m = int.Parse(s[i]);
                int aux = m;
                while (m > 0)
                {
                    sum += m % 10;
                    m /= 10;
                }
                if (sum % k == 0)
                {
                    S += aux;
                }
            }
            Console.WriteLine(S);

        }
        private static void P3251()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int c = 0;
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(d[i]);
                int numar = 0;
                int palindrom = 0;
                int putere = 1;
                while (m > 0)
                {
                    if (m % 2 == 0)
                    {
                        numar += (m % 10) * putere;
                        putere *= 10;
                    }
                    m /= 10;
                }
                a = numar;
                while (a > 0)
                {
                    palindrom = palindrom * 10 + a % 10;
                    a /= 10;
                }
                if (palindrom == numar)
                {
                    c++;
                }
            }
            Console.WriteLine(c);

        }
        private static void P127()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int S = 0;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(d[i]);
                while (m / 10 != 0)
                {
                    m /= 10;
                }
                S = S + m;

            }
            Console.WriteLine(S);
        }
        private static void P4018()
        {
            string[] d = Console.ReadLine().Split(' ');
            long n = int.Parse(d[0]);
            long p = int.Parse(d[1]);
            long k = int.Parse(d[2]);
            long rezultat = 0;
            long oglindit1 = 0;
            long putere = 1;
            long oglindit = 0;
            if (n < p + k)
            {
                Console.WriteLine("imposibil");
            }
            while (k > 0)
            {
                oglindit = oglindit * 10 + n % 10;
                putere *= 10;
                k--;
                n /= 10;
            }
            while (n > Math.Pow(10, p))
            {
                oglindit = putere * (n % 10) + oglindit;
                putere *= 10;
                n /= 10;
            }
            while (n > 0)
            {
                oglindit1 = oglindit1 * 10 + n % 10;
                n /= 10;
            }
            rezultat = oglindit1 * putere + oglindit;
            Console.Write(rezultat);
        }
        private static void P3079()
        {
            string[] d = Console.ReadLine().Split(' ');
            int a = int.Parse(d[0]);
            int b = int.Parse(d[1]);
            int c = 0;
            int p = 1;
            while (a > 0)
            {
                c += (a % 10 + b % 10) / 2 * p;
                a /= 10;
                b /= 10;
                p *= 10;
            }
            Console.Write(c);
        }
        private static void P3933()
        {
            int n = int.Parse(Console.ReadLine());
            int nr1 = 0;
            int nr0 = 0;
            bool ok = false;
            while (n > 0)
            {
                if (n % 10 == 1)
                {
                    nr1++;
                }
                else if (n % 10 == 0)
                {
                    nr0++;
                }
                else
                {
                    ok = true;
                }
                n /= 10;
            }
            if (ok == false && nr0 >= 1 && nr1 >= 1)
            {
                Console.WriteLine("da");
            }
            else
            {
                Console.WriteLine("nu");
            }
        }
        private static void P1613()
        {
            int n = int.Parse(Console.ReadLine());
            int nr1 = 0, nr2 = 0, p1 = 1, p2 = 1;
            while (n > 0)
            {
                if ((n % 10) % 2 == 0)
                {
                    nr1 += p1 * (n % 10);
                    p1 *= 10;

                }
                else
                {
                    nr2 += p2 * (n % 10);
                    p2 *= 10;
                }
                n /= 10;
            }
            Console.WriteLine(Math.Abs(nr1 - nr2));
        }
        private static void P2223()
        {
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int contor = 0, rezultat = 0;
            while (n != 0)
            {
                suma += n % 10;
                n /= 10;
            }
            if (suma < 10)
            {
                Console.Write(suma);
                for (int i = 1; i < suma; i++)
                {
                    Console.Write("0");
                }
            }
            else
            {
                contor = suma / 9;
                rezultat = suma % 9;
                for (int i = 1; i <= contor; i++)
                {
                    Console.Write("9");
                }
                Console.Write(rezultat);
                for (int i = 1; i <= suma - contor - 1; i++)
                {
                    Console.Write("0");
                }

            }


        }
        private static void P2257()
        {
            int n = int.Parse(Console.ReadLine());
            double d;
            double max = double.MinValue;
            string[] s = Console.ReadLine().Split(' ');
            int p = 0;
            int u = 0;
            for (int i = 0; i < n; i++)
            {
                d = double.Parse(s[i]);
                if (d > max)
                {
                    max = d;
                    p = i + 1;
                }
                if (d == max)
                {
                    u = i + 1;
                }

            }
            Console.Write(p + " " + u);

        }
        private static void P3284()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int x = 0;
            int y = -1;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(d[i]);
                if ((i + 1) % 2 == 0)
                {
                    if (m > x)
                    {
                        x = m;
                    }
                }
                if (m > 9 && m < 100)
                {
                    if (y == -1)
                    {
                        y = m;
                    }
                    if (m < y)
                    {
                        y = m;
                    }
                }
            }

            Console.WriteLine(x + " " + y);
        }
        private static void P119()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int x = int.Parse(d[0]);
            int y = int.Parse(d[1]);
            if (x < y)
            {
                int aux = x;
                x = y;
                y = aux;
            }
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(d[i]);
                if (m > x)
                {
                    y = x;
                    x = m;
                }
                else if (m > y)
                {
                    y = m;
                }
            }
            Console.WriteLine(x + " " + y);
        }
        private static void P2269()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int max = int.MinValue;
            int contor = 0;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(d[i]);
                if (m > max && m % 2 == 0)
                {
                    max = m;
                    contor++;
                }
            }
            Console.WriteLine(max + " " + contor);
        }
        private static void P346()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int max = int.MinValue;
            int contor = 0;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(d[i]);
                if (m > max)
                {
                    max = m;
                    contor++;
                }
            }
            Console.WriteLine(max + " " + contor);
        }
        private static void P171()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int min = 9;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(d[i]);
                int a = m;
                while (a > 9)
                {
                    a /= 10;
                }
                if (a < min)
                {
                    min = a;
                    max = m;
                }
                else if (a == min)
                {
                    if (m > max)
                    {
                        max = m;
                    }
                }
            }
            Console.WriteLine(max);
        }
        private static void P54()
        {

            string[] d = Console.ReadLine().Split(' ');
            int m = int.Parse(d[0]);
            int max = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                m = int.Parse(d[i]);
                if (m == 0)
                {
                    break;
                }
                if (m > max)
                {
                    max = m;
                }
            }
            Console.WriteLine(max);
        }
        private static void P347()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(d[i]);
                if (m > max)
                {
                    max = m;
                }
                if (m < min)
                {
                    min = m;
                }
            }
            Console.WriteLine(max + min);
        }
        private static void P354()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(d[i]);
                if (m > max)
                {
                    max = m;
                }
            }
            Console.WriteLine(max);

        }
        private static void P1468()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int min = 100;
            int contor = 0;
            int s = 0;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(d[i]);

                if (m <= min)
                {
                    if (s + m > max)
                        max = s + m;
                    contor++;
                    min = m;
                    s = m;
                }
                if (m > min)
                    s += m;

            }
            Console.Write(contor + " ");
            Console.Write(max);
        }
        private static void P1544()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (d[i] == "do1")
                    sum += 0;
                if (d[i] == "re")
                    sum += 1;
                if (d[i] == "mi")
                    sum += 2;
                if (d[i] == "fa")
                    sum += 3;
                if (d[i] == "sol")
                    sum += 4;
                if (d[i] == "la")
                    sum += 5;
                if (d[i] == "si")
                    sum += 6;
                if (d[i] == "do2")
                    sum += 7;
            }
            int a = sum % n;
            if (a == 0)
                Console.WriteLine("do1");
            if (a == 1)
                Console.WriteLine("re");
            if (a == 2)
                Console.WriteLine("mi");
            if (a == 3)
                Console.WriteLine("fa");
            if (a == 4)
                Console.WriteLine("sol");
            if (a == 5)
                Console.WriteLine("la");
            if (a == 6)
                Console.WriteLine("si");
            if (a == 7)
                Console.WriteLine("do2");
        }
        private static void P3183()
        {
            string[] d = Console.ReadLine().Split(' ');
            int n = int.Parse(d[0]); // perechi xy
            int x = int.Parse(d[1]); // ordinul statiei
            int y = int.Parse(d[2]); // limita aglomeratie autobuz
            int p = int.Parse(d[3]); // cerinta a sau b
            int sum = 0, dif = 0;
            int contor = 0;
            if (p == 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    int xi = int.Parse(s[0]);
                    int yi = int.Parse(s[1]);
                    sum += xi;
                    dif += yi;
                }
                Console.WriteLine(sum + " " + dif + " " + (sum - dif));

            }
            else if (p == 2)
            {
                for (int i = 1; i <= n; i++)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    int xi = int.Parse(s[0]);
                    int yi = int.Parse(s[1]);
                    sum += xi;
                    dif += yi;
                    if (i == x && (sum - dif) < y)
                    {
                        contor = 0;

                    }
                    if (i == x && (sum - dif) > y)
                    {
                        contor = 1;
                    }

                }
                if (contor == 0)
                {
                    Console.WriteLine("NU");
                }
                else
                {
                    Console.WriteLine("DA");
                }



            }
            else
            {
                Console.WriteLine("Nu exista cerinta pentru P = {0}.", p);
            }
        }
        private static void P860()
        {
            string[] d = Console.ReadLine().Split(' ');
            int n = int.Parse(d[0]);
            int C = int.Parse(d[1]);
            int contor = 0;
            int x = 1;
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(s[i]);
                if (x + m <= C)
                {
                    x += m;
                }
                else
                {
                    contor++;


                }
            }
            Console.WriteLine(contor);
        }

        //Structuri repetitive
        private static void P254()
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[10001];
            int[] b = new int[10001];
            int p;
            for (int i = 1; i <= n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                b[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                p = 1;
                while (p * 2 <= Math.Max(b[i], a[i]))
                {
                    p *= 2;
                }
                if (p >= Math.Min(a[i], b[i]))
                {
                    Console.Write(p + " ");
                }
                else
                    Console.WriteLine("0");
            }
        }
        private static void P560()
        {
            int n = int.Parse(Console.ReadLine());
            int randuri = 0;
            int i = 0;
            int x = 0;

            if (n % 5 == 0)
            {
                randuri = n / 5;
                Console.WriteLine(randuri);
                Console.WriteLine("DA");
            }
            else
            {
                randuri = n / 5 + 1;
                Console.WriteLine(randuri);
                Console.WriteLine("NU");
            }
            while (i < n)
            {
                i++;
                x += i;
                if (x > randuri)
                {
                    break;
                }
            }

            if (i % 2 == 0)
            {
                Console.WriteLine("panselute");
            }
            else
            {
                Console.WriteLine("micsunele");
            }
        }
        private static void P246()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int a = -1, b = -1;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(d[i]);

                if (m % 2 == 1)
                {
                    b = a;
                    a = m;
                }
            }
            if (a != -1 && b != -1)
            {
                Console.WriteLine(b + " " + a);
            }
            else
            {
                Console.WriteLine("Numere insuficiente");
            }
        }
        private static void P2757()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int rezulat = 0;
            int nr = 0;
            int nr_cifre = 0;
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(d[i]);
                nr = 100;
                nr_cifre = 3;
                while (nr_cifre < k && k <= 2700)
                {
                    nr_cifre += 3;
                    nr++;
                }
                if (k > 2700)
                {
                    Console.Write("- ", d[i]);
                    continue;
                }
                if (nr_cifre - k == 2)
                {
                    rezulat = nr / 100;
                }
                else if (nr_cifre - k == 1)
                {
                    rezulat = (nr / 10) % 10;
                }
                else
                {
                    rezulat = nr % 10;
                }
                Console.Write(rezulat + " ");

            }

        }
        private static void P654()
        {
            int n = int.Parse(Console.ReadLine());
            int C = 1;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = n * 3 + 1;
                }
                C++;
            }
            Console.WriteLine(C);
        }
        private static void P2766()
        {
            string[] d = Console.ReadLine().Split(' ');
            int R1 = int.Parse(d[0]);
            int G1 = int.Parse(d[1]);
            int B1 = int.Parse(d[2]);
            int R2 = int.Parse(d[3]);
            int G2 = int.Parse(d[4]);
            int B2 = int.Parse(d[5]);
            int n = int.Parse(d[6]);
            int r, g, b;
            r = R2 - R1;
            g = G2 - G1;
            b = B2 - B1;
            n--;
            Console.WriteLine(R1 + ", " + G1 + ", " + B1);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine((int)(R1 + r * i / (double)n) + ", " + (int)(G1 + g * i / (double)n) + ", "
                    + (int)(B1 + b * i / (double)n));
            }

        }
        private static void P1650()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int s = 0;
            for (int i = 0; i < k; i++)
            {
                s += int.Parse(d[i]);
            }
            if (s == 0)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }
        }
        private static void P2915()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 0, c = 0;
            bool m = false;
            for (int i = 1; i * i <= n; i++)
            {
                a = i * i;
                b = n - a;
                c = (int)Math.Sqrt(b);
                if (c * c == b && m == false)
                {
                    m = true;
                    Console.WriteLine(a + " " + b);
                }
            }
            if (!m)
            {
                Console.WriteLine("NU");
            }
        }
        private static void P3074()
        {
            string[] d = Console.ReadLine().Split(' ');
            int n = int.Parse(d[0]);
            int s = int.Parse(d[1]);
            int x = 1, y, a, b, suma;
            int contor = 0;
            for (int i = 1; i < n; i++)
            {
                x *= 10;
            }
            y = x * 10 - 1;
            for (a = x; a <= y; a++)
            {
                b = a;
                suma = 0;
                while (b > 0)
                {
                    suma += b % 10;
                    b /= 10;
                }

                if (suma == s)
                {
                    contor++;
                    Console.Write(a + " ");

                }

            }
            if (contor > 0)
            {
                Console.WriteLine("\n" + contor);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
        private static void P115()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            double m = 0;
            int contor = 0;
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(d[i]) % 2 == 0)
                {
                    contor++;
                    m += int.Parse(d[i]);
                }


            }
            Console.WriteLine("{0:0.00}", m / contor);

        }
        private static void P52()
        {
            string[] d = Console.ReadLine().Split(' ');
            int n = 0;
            int s = 0;
            while (d[n] != "0")
            {
                if (int.Parse(d[n]) % 2 == 0)
                {
                    s += int.Parse(d[n]);
                }
                n++;
            }
            Console.WriteLine(s);

        }
        private static void P459()
        {
            string[] d = Console.ReadLine().Split(' ');
            int s = 0;
            int x = 0;
            while (d[x] != d[x + 1])
            {

                s += int.Parse(d[x]);
                x++;
            }
            Console.WriteLine(s + int.Parse(d[x]) + int.Parse(d[x + 1]));
        }
        private static void P2299()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int p = 1;
            for (int i = 0; i < n; i++)
            {

                p *= int.Parse(d[i]);
            }
            double a = (double)1 / n;
            Console.WriteLine("{0:0.000}", Math.Pow(p, a));

        }
        private static void P51()
        {
            string[] d = Console.ReadLine().Split(' ');
            int n = 0;
            int s = 0;
            while (d[n] != "0")
            {
                s += int.Parse(d[n]);
                n++;
            }
            Console.WriteLine(s);
        }
        private static void P2()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int s = 0;
            int a;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(d[i]);
                s += a;
            }
            Console.WriteLine(s);
        }
        private static void P457()
        {
            int n = int.Parse(Console.ReadLine());
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)
                    {
                        Console.Write(c);
                    }
                    else
                        Console.Write(d);
                }
                Console.WriteLine(" ");
            }
        }
        private static void P456()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine(" ");
            }

        }
        private static void P1684()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + (int)Math.Pow((i + 1), 2);
                Console.WriteLine(sum);
            }
        }
        private static void P351()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine(" ");
            }
        }
        private static void P2572()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            bool m = false;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(d[i]);
                for (int j = 2; j < x; j++)
                {
                    if (j * j == x)
                    {
                        m = true;
                        break;
                    }
                    else
                    {
                        m = false;

                    }
                }

                if (m)
                {
                    Console.WriteLine("DA");
                }
                else
                {
                    Console.WriteLine("NU");
                }

            }




        }
        private static void P348()
        {
            string[] d = Console.ReadLine().Split(' ');
            int n = int.Parse(d[0]);
            int m = int.Parse(d[1]);
            int p = 1;
            while (p <= m)
            {
                Console.Write(p + " ");
                p *= n;
            }

        }
        private static void P2747()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int p = 1;
            while (m > n)
            {
                p++;
                m /= n;
            }
            Console.WriteLine(p);



        }
        private static void P1681()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int p = 1;

            for (int i = 1; i <= b; i++)
            {
                p *= a;
            }
            Console.WriteLine(p);

        }
        private static void P2222()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(n, k));

        }
        private static void P3233()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
            {
                for (int i = n; i >= 1; i -= 2)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                for (int i = n - 1; i >= 1; i -= 2)
                {
                    Console.Write(i + " ");
                }
            }
        }
        private static void P331()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n * 2 - 1; i >= 1; i -= 2)
            {
                Console.Write(i + " ");
            }

        }
        private static void P3232()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i += 2)
            {
                Console.Write(i + " ");
            }
        }
        private static void P330()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n * 2; i += 2)
            {
                Console.Write(i + " ");
            }

        }
        private static void P3231()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = n; i >= 1; i--)
            {
                Console.Write(i + " ");
            }


        }
        private static void P3983()
        {
            string[] d = Console.ReadLine().Split(' ');
            int m = int.Parse(d[0]);
            int n = int.Parse(d[1]);
            int c = 0;
            for (int i = m; i >= 1; i--)
            {
                c = i * n;
                Console.Write(c + " ");
            }
        }
        private static void P3984()
        {
            string[] d = Console.ReadLine().Split(' ');
            int a = int.Parse(d[0]);
            int b = int.Parse(d[1]);
            int c = 0;
            for (int i = 1; i <= b; i++)
            {
                c += a;
                Console.Write(c + " ");
            }

        }
        private static void P328()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                Console.Write(i + " ");
            }
        }
        private static void P327()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }


        }
        private static void P1261()
        {
            int c = 0, n, ok = 1;
            while (ok == 1)
            {
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    ok = 0;
                }
                else if (n % 2 == 0)
                {
                    c++;
                }
                if (c != 0)
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine("NU EXISTA");
                }

            }
        }



        // Structura de decizie
        private static void P1002()
        {
            int n = int.Parse(Console.ReadLine());
            int v, p = 0;
            v = n / 792;
            n = n % 792;
            int a = 0;
            if (n > 0)
            {
                v++;
                if (n <= 10)
                {
                    p = n;
                }
                else
                {
                    if (n <= 189)
                    {
                        n -= 9;
                        if (n % 2 == 1)
                        {
                            a = 1;
                        }
                        else
                        {
                            p = 9 + n / 2;
                        }
                    }
                    else
                    {
                        n -= 189;
                        if (n % 3 != 0)
                        {
                            a = 1;
                        }
                        else
                        {
                            p = 99 + n / 3;
                        }
                    }
                }
            }
            if (a == 1)
            {
                Console.WriteLine("IMPOSIBIL");
            }
            else
            {
                Console.WriteLine("{0} {1}", v, p);
            }
        }
        private static void P833()
        {
            string[] d = Console.ReadLine().Split(' ');
            int a = int.Parse(d[0]);
            int b = int.Parse(d[1]);
            int x = 0;
            if (b > a)
            {
                x = b - a;
                Console.WriteLine("Al doilea copil este mai mare cu {0} ani", x);
            }
            else
            {
                x = a - b;
                Console.WriteLine("Primul copil este mai mare cu {0} ani", x);
            }
            if (a == b)
            {
                Console.WriteLine("Copiii au varste egale");
            }
        }
        private static void P1625()
        {
            string[] d = Console.ReadLine().Split(' ');
            double a = double.Parse(d[0]);
            double b = double.Parse(d[1]);
            double c = double.Parse(d[2]);
            double x1, x2;
            double delta = b * b - 4 * a * c;


            if (delta < 0)
            {
                Console.WriteLine("Nu are solutii reale");
            }
            else if (delta == 0)
            {
                x1 = x2 = ((-b) + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Radacina dubla {0:0.00}", x1);
            }
            else
            {
                x1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(delta)) / (2 * a);
                if (x1 > x2)
                {
                    Console.Write("{0:0.00} {1:0.00}", x1, x2);
                }
                else
                {
                    Console.Write("{0:0.00} {1:0.00}", x2, x1);
                }

            }






        }
        private static void P2752()
        {
            int k = int.Parse(Console.ReadLine());
            int l, c;
            if (k >= 1 && k <= 180)
            {
                l = k / 20 + 1;
                if (k % 2 == 1)
                {
                    c = l;
                }
                else
                {
                    if (k % 20 == 0)
                    {
                        c = 9;
                    }
                    else
                    {
                        c = (k % 20) / 2 - 1;
                    }
                }
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("Numarul trebuie sa fie de la 1 pana la 180.");
            }
        }
        private static void P1310()
        {
            string[] d = Console.ReadLine().Split(' ');
            int n = int.Parse(d[0]);
            int m = int.Parse(d[1]);
            int x, y, z, i = 0;
            x = n % 10;
            y = (n / 10) % 10;
            z = n / 100;
            if (m % x == 0)
            {
                i++;
            }
            if (m % y == 0)
            {
                i++;
            }
            if (m % z == 0)
            {
                i++;
            }
            Console.WriteLine(i);


        }
        private static void P3185()
        {
            string[] d = Console.ReadLine().Split(' ');
            int a = int.Parse(d[0]);
            int b = int.Parse(d[1]);
            int n = int.Parse(d[2]);
            if (1 <= a && a <= b && b <= n && n <= 1000 && a <= n && n <= b)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }

        }
        private static void P3805()
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;
            double A = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double r = (a * b * c) / (4 * A);
            Console.WriteLine(r);
        }
        private static void P1303()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            string c = Console.ReadLine();
            if (a > b)
            {
                if (c == "+")
                {
                    Console.WriteLine(a + b);
                    return;
                }
                if (c == "-")
                {
                    Console.WriteLine(a - b);
                    return;
                }
                if (c == "*")
                {
                    Console.WriteLine(a * b);
                    return;

                }
                if (c == "/")
                {
                    Console.WriteLine(a / b);
                    return;
                }
            }
            else
            {
                Console.WriteLine("nu se poate efectua operatia daca a<b");

            }






        }
        private static void P2311()
        {
            int n = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int zile = 0;
            while (n > 0)
            {
                zile++;
                n = n - m1 - m2;

            }
            Console.WriteLine(zile);
        }
        private static void P2419()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int s = 0, x = 0, y = 0, mij;
            mij = (a + b) / 2;
            for (int i = a; i < mij; i++)
            {
                if (mij % 2 == 0)
                {
                    x = x + 1;
                    y = y + 1;
                    s += x + y;
                }
            }





        }
        private static void P3275()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = 0;
            max = a % 10 + a / 10;
            if (b % 10 + b / 10 > max)
            {
                max = b % 10 + b / 10;
            }
            if (c % 10 + c / 10 > max)
            {
                max = c % 10 + c / 10;
            }
            if (max == a % 10 + a / 10)
            {
                Console.Write(a + " ");
            }
            if (max == b % 10 + b / 10)
            {
                Console.Write(b + " ");
            }
            if (max == c % 10 + c / 10)
            {
                Console.Write(c + " ");
            }



        }

        // Vectori
        private static void P250()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int m = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int k = n + m;
            int[] v = new int[n];
            int[] v1 = new int[m];
            int[] c = new int[k];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(d[i]);
            }
            for (int j = 0; j < m; j++)
            {
                v1[j] = int.Parse(s[j]);
            }
            for (int i = 0; i < n; i++)
            {
                c[i] = v[i];
            }
            int e = 0;
            for (int j = n; j < k; j++)
            {
                c[j] = v1[e];
                e++;
            }
            for (int i = 0; i < k; i++)
            {
                int p = i;
                while (p > 0 && c[p] < c[p - 1])
                {
                    int aux = c[p];
                    c[p] = c[p - 1];
                    c[p - 1] = aux;
                    p--;
                }
            }
            for (int i = 0; i < k - 1; i++)
            {
                if (c[i] == c[i + 1])
                {
                    continue;
                }
                else
                Console.Write(c[i] + " ");
            }
            for (int i = k - 1; i < k; i++)
            {
                Console.Write(c[i]);
            }


        }
        private static void P3824()
        {
            string[] d = Console.ReadLine().Split(' ');
            int n = int.Parse(d[0]);
            string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int[] x = new int[n];
            int[] y = new int[m];
            int p = 0;
            int cnt = 0;
            for (int i = 1; i <= n; i++)
            {
                x[p] = int.Parse(d[i]);
                p++;
            }
            p = 0;
            for (int j = 1; j <= m; j++)
            {
                y[p] = int.Parse(s[j]);
                p++;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (x[i] == y[j])
                    {
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);



        }
        private static void P241()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int m = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int k = n + m;
            int[] v = new int[n];
            int[] v1 = new int[m];
            int[] c = new int[k];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(d[i]);
            }
            for (int j = 0; j < m; j++)
            {
                v1[j] = int.Parse(s[j]);
            }
            for(int i = 0; i < n; i++)
            {
                c[i] = v[i];
            }
            int e = 0;
            for(int j = n; j < k; j++)
            {
                c[j] = v1[e];
                e++;
            }
            for(int i = 1; i < k; i++)
            {
                int p = i;
                while (p > 0 && c[p] < c[p - 1])
                {
                    int aux = c[p];
                    c[p] = c[p - 1];
                    c[p - 1] = aux;
                    p--;
                }
            }
            for (int i = 0; i < k; i++)
            {
                if (i % 10 == 9)
                    Console.Write(c[i] + "\n");
                else
                    Console.Write(c[i] + " ");
            }
        }
        private static void P183()
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] v = new int[n];
             
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (PatratPerfect(v[i]) && PatratPerfect(v[j]) && v[j] < v[i])
                    {
                        Swap(ref v[i], ref v[j]);
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
        private static void P1608()
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(s[i]);
            }
            bool sort;
            do
            {
                sort = true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (div(v[i]) < div(v[i + 1]))
                    {
                        int aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        sort = false;
                    }
                }
            }
            while (!sort);
            foreach (int x in v)
                Console.Write(x + " ");
        }
        private static void P513()
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            int temp = 0;
            string[] d = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(d[i]);
            }
            for (int l = 0; l < k; l++)
            {
                for (int i = l; i < n; i++)
                {
                    for (int j = i; j < n; j += k)
                    {
                        if (v[i] > v[j])
                        {
                            temp = v[i];
                            v[i] = v[j];
                            v[j] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
        private static void P180()
        {
                int n = int.Parse(Console.ReadLine());
                string[] d = Console.ReadLine().Split(' ');
                int min = int.MaxValue;
                int max = int.MinValue;
                int imin = 0, imax = 0;
                int[] v = new int[n];
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(d[i]);
                    if (v[i] < min)
                    {
                        min = v[i];
                        imin = i;
                    }
                    if (v[i] > max)
                    {
                        max = v[i];
                        imax = i;
                    }
                }
                if (imin > imax)
                {
                    Swap(ref imin, ref imax);
                }
                for (int i = imin; i < imax; i++)
                {
                    for (int j = i + 1; j <= imax; j++)
                    {
                        if (v[i] > v[j])
                        {
                            Swap(ref v[i], ref v[j]);
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write(v[i] + " ");
                }
        }
        private static void P618()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            int INF = int.MaxValue;
            int[] v = new int[n];
            int poz = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(d[i]);
            }
            for (int i = 0; i < n; ++i)
            {
                int min = INF;
                poz = 0;
                for (int j = 0; j < n; ++j)
                {
                    if (v[j] < min)
                    {
                        min = v[j];
                        poz = j;
                    }
                }
                v[poz] = INF;
                Console.Write(poz + 1 + " ");
            }
        }
        private static void P272()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            bool sortare = false;
            int temp = 0;
            int cnt = 0;
            int[] v = new int[n];
            int[] v1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(d[i]);
                if (v[i] % 2 == 0)
                {
                    v1[cnt] = v[i];
                    cnt++;
                }
            }
            while (!sortare)
            {
                sortare = true;
                for (int i = 0; i < cnt - 1; i++)
                {
                    if (v1[i] > v1[i + 1])
                    {
                        temp = v1[i];
                        v1[i] = v1[i + 1];
                        v1[i + 1] = temp;
                        sortare = false;
                    }
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine("nu exista");
            }
            else
            {
                Console.WriteLine(cnt);
                for (int i = 0; i < cnt; i++)
                {
                    Console.Write(v1[i] + " ");
                }
            }



        }
        private static void P510()
        {
            int n = int.Parse(Console.ReadLine());
            string[] d = Console.ReadLine().Split(' ');
            bool sortare = false;
            int temp = 0;
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(d[i]);
            }
            while (!sortare)
            {
                sortare = true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        temp = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = temp;
                        sortare = false;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                bool prim = true;
                if (v[i] < 2)
                {
                    prim = false;
                }
                if (v[i] % 2 == 0)
                {
                    prim = false;
                }
                for (int j = 3; j * j <= v[i]; j += 2)
                {
                    if (v[i] % j == 0)
                    {
                        prim = false;
                    }
                }
                if (prim == true)
                {
                    Console.Write(v[i] + " ");
                }
            }

        }
        private static void P1329()
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            bool b = true;
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < n - 2; i++)
            {
                if (v[i] < v[i + 1])
                {
                    if (v[i + 1] < v[i + 2])
                        b = false;
                }
                else
                {
                    if (v[i] > v[i + 1])
                    {
                        if (v[i + 1] > v[i + 2])
                            b = false;
                    }
                }
                if (v[i] == v[i + 1])
                    b = false;
            }
            if (b == false)
            {
                Console.WriteLine("NU");
            }
            else
            {
                Console.WriteLine("DA");
            }
        }
        private static void P293()
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            bool b = true;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(s[i]);
                int aux = x;
                int cnt = 0;
                while (aux != 0)
                {
                    aux /= 10;
                    cnt++;
                }
                int[] v = new int[cnt];
                for (int j = 0; j < cnt; j++)
                {
                    v[j] = x % 10;
                    x /= 10;
                }
                for (int k = 0; k < cnt - 1; k++)
                {
                    for (int l = k + 1; l <= cnt - 1; l++)
                    {
                        if (v[k] == v[l])
                        {
                            b = false;
                            break;
                        }
                    }
                }
            }
            if (b)
                Console.WriteLine("DA");
            else
                Console.WriteLine("NU");

        }
        private static void P2689()
        {
            int n = int.Parse(Console.ReadLine());
            string[] v = Console.ReadLine().Split(' ');
            int x = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                x += (int)Math.Pow(10, i) * int.Parse(v[i]);
            }
            Console.WriteLine(x);
            int ogl = 0;
            int aux = x;
            while (x != 0)
            {
                ogl = ogl * 10 + (x % 10);
                x /= 10;
            }
            if (ogl == aux)
                Console.WriteLine("DA");
            else
                Console.WriteLine("NU");

        }
        private static void P287()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] rezultat = new int[n];
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                string[] d = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    v[j] = int.Parse(d[j]);
                    bool cresc = true;
                    for (int k = 2; k < m; j++)
                    {
                        if (v[k] < v[k - 1])
                        {
                            cresc = false;
                        }
                        if (cresc == true)
                        {
                            rezultat[i] = 1;
                        }
                        else
                        {
                            rezultat[i] = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(rezultat[i] + " ");
            }
        }
        private static void Balog8()
        {
            //Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.
            //Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] v = new int[100];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                v[i - 1] = v[i];
                v[i] = v[0];
                Console.WriteLine(v[i]);


            }

        }
        private static void Balog7()
        {
            //Se da un vector cu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
            //Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.

            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(s[i]);
                a[n - 1 - i] = v[i];

            }

            for (int i = 0; i < n; i++)
            {

                v[i] = a[i];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
        private static void Balog6()
        {
            //  Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k.
            //  Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.
            string[] d = Console.ReadLine().Split(' ');
            int n = int.Parse(d[0]);
            int k = int.Parse(d[1]);
            int[] v = new int[n];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                if (i < k)
                {
                    v[i] = int.Parse(s[i]);
                }
                if (i == k)
                {
                    v[i] = int.Parse(s[i - 1]);
                    i++;
                }
                if (i > k)
                {
                    v[i] = int.Parse(s[i - 1]);
                }
                Console.Write(v[i] + " ");
            }
        }
        private static void Balog5()
        {
            //Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
            //Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.
            string[] d = Console.ReadLine().Split(' ');
            int n = int.Parse(d[0]);
            int e = int.Parse(d[1]);
            int k = int.Parse(d[2]);
            int[] v = new int[n + 1];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i <= n; i++)
            {
                if (i < k)
                {
                    v[i] = int.Parse(s[i]);
                }
                if (i == k)
                {
                    v[i] = e;
                }
                if (i > k)
                {
                    v[i] = int.Parse(s[i - 1]);
                }
                Console.Write(v[i] + " ");
            }

        }
        private static void Balog4()
        {
            //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxa = 0;
            int mina = 0;
            string[] v = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(v[i]) == max)
                {
                    maxa++;
                }
                if (int.Parse(v[i]) == min)
                {
                    mina++;
                }
                if (int.Parse(v[i]) > max)
                {
                    max = int.Parse(v[i]);
                    maxa = 1;
                }
                if (int.Parse(v[i]) < min)
                {
                    min = int.Parse(v[i]);
                    mina = 1;
                }

            }
            Console.WriteLine(min + " " + mina + " " + max + " " + maxa);
        }
        private static void Balog3()
        {
            //"Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxi = 0;
            int mini = 0;
            string[] v = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(v[i]) > max)
                {
                    max = int.Parse(v[i]);
                    maxi = i;
                }
                if (int.Parse(v[i]) < min)
                {
                    min = int.Parse(v[i]);
                    mini = i;
                }
            }
            Console.WriteLine(maxi + " " + mini);
        }
        private static void Balog2()
        {
            //Se da un vector cu n elemente si o valoare k.Se cere sa se determine prima pozitie din vector pe care apare k.
            //Daca k nu apare in vector rezultatul va fi -1.
            string[] d = Console.ReadLine().Split(' ');
            int n = int.Parse(d[0]);
            int k = int.Parse(d[1]);
            int poz = 0;
            string[] v = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(v[i]) == k)
                {
                    poz = i + 1;
                    break;
                }
            }
            Console.WriteLine(poz);
            if (poz == 0)
            {
                Console.WriteLine("-1");
            }

        }
        private static void Balog1()
        {
            // Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            string[] v = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(v[i]);
            }
            Console.WriteLine(sum);
        }
        private static void P99()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] d = Console.ReadLine().Split(' ');
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(d[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] == n)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
        private static void P98()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] d = Console.ReadLine().Split(' ');
            int nrmax = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(d[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] > max)
                {
                    max = v[i];
                    nrmax = 1;
                }
                else if (v[i] == max)
                {
                    nrmax++;
                }
            }
            Console.WriteLine(max + " " + nrmax);
        }
        private static void P553()

        {
            int n = int.Parse(Console.ReadLine());
            int imin = 1, imax = 1, min, max;
            int[] v = new int[n];
            min = max = n;
            string[] d = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(d[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] < min)
                {
                    min = v[i];
                    imin = i + 1;
                }
                if (v[i] > max)
                {
                    max = v[i];
                    imax = i + 1;
                }

            }
            Console.Write(imin + " " + imax);

        }
        private static void P486()
        {

            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] d = Console.ReadLine().Split(' ');
            int minim = n, maxim = n;

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(d[i]);

                if (v[i] < minim)
                {
                    minim = v[i];
                }
                if (v[i] > maxim)
                {
                    maxim = v[i];
                }
            }

            Console.Write(minim + " " + maxim);

        }
        private static void P489()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] data = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(v[i] + " " + v[n - 1 - i] + " ");
            }
            if (n % 2 == 1)
            {
                Console.Write(v[n / 2]);
            }
        }
        private static void P546()
        {
            int[] v;
            int n;
            n = int.Parse(Console.ReadLine());
            v = new int[n];
            string[] d = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(d[i]);
            }
            for (int i = 1; i <= n; i++)
            {
                if (v[i] % v[n] == 0)
                {
                    Console.Write(v[i] + " ");
                }
            }




        }
        private static void P633()
        {
            int[] v;
            int n, nrp = 0, nri = 0;
            n = int.Parse(Console.ReadLine());
            v = new int[n];
            string[] d = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(d[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] % 2 == 0)
                    nrp++;
                else
                    nri++;
            }
            if (nrp > nri)
            {
                Console.WriteLine(nrp - nri);
            }
            else
                Console.WriteLine(nri - nrp);


        }

        //  4.04.2022
        private static void P2602()
        {
            double a, s = 0;
            a = double.Parse(Console.ReadLine());
            s = a % 10;
            Console.WriteLine(s);


        }
        private static void P1289()
        {
            double n;
            n = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(n);
            Console.WriteLine(r);
        }
        private static void P2599()
        {
            double a;
            a = double.Parse(Console.ReadLine());
            if (0 <= a && a <= 9)
            {
                double s = Math.Pow(a, 16);
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Numerele acceptate sunt de la 0 la 9.");
            }


        }
        private static void P2938()
        {
            long n, s = 0;
            n = long.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Albina nu a fost harnica!!!");
            }
            if (n == 1)
            {
                s = 1;
                Console.WriteLine(s);
                return;
            }
            else
            {
                s = 1 + 3 * (n - 1) * n;
            }
            Console.WriteLine(s);

        }
        private static void P2617()
        {
            int N, M, S = 0;
            N = int.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());
            S = (N - 1) + N * (M - 1);
            Console.WriteLine(S);
        }
        private static void P2201()
        {
            int n, s = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s += n - i;
            }
            Console.WriteLine(s);
        }
        private static void P3181()
        {
            int x, y, n;
            x = int.Parse(Console.ReadLine()); // nr zile din an
            y = int.Parse(Console.ReadLine()); // nr de ore
            n = int.Parse(Console.ReadLine()); // antene
            int a = 0, z = 0, h;
            while (n - y >= 0)
            {
                z++;
                n = n - y;
            }
            while (z - x >= 0)
            {
                a++;
                z = z - x;
            }
            h = n % y;
            Console.WriteLine($"{a} {z} {h}");





        }
        private static void P2263()
        {
            int n, m, z, t1, t2;
            t1 = int.Parse(Console.ReadLine());
            t2 = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            Console.WriteLine((t1 * n + t2 * m) * z);
        }
        private static void P3210()
        {
            int B, S;
            B = int.Parse(Console.ReadLine());
            S = int.Parse(Console.ReadLine());
            Console.WriteLine($"{S / B} {B - (S % B)}");
        }
        private static void P3978()
        {

            int a, b, c, i, s1, s2, s3;
            s1 = 0;
            s2 = 0;
            s3 = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a <= b && b <= c)
            {
                for (i = a; i <= b; i++)
                    s1 += i;
                for (i = b; i <= c; i++)
                    s2 += i;
                for (i = a; i <= c; i++)
                    s3 += i;
            }
            Console.WriteLine($"{s1} {s2} {s3}");

        }
        private static void P3180()
        {
            int a, b, c, m, n, p;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            Console.WriteLine((a * m) + (b * n) + (c * p));
        }
        private static void P3182()
        {
            int z, n;
            z = int.Parse((Console.ReadLine()));
            n = int.Parse((Console.ReadLine()));
            Console.WriteLine(n / z);
        }

    }
}

