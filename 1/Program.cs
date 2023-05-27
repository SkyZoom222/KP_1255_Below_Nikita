using System;
using System.Linq;
using System.Collections.Generic;

public static class PassGen
{


    public static Random rnd = new Random();


    public static void Main(string[] args)
    {
        int len = 16;
        int minL = 0, minD = 0;
        bool spec = false;
        bool upper = false;
        bool GetPass = true;
        bool UndefinedArg = false;

        string Password;
        try
        {
            len = Convert.ToInt32(args[0]);
        }
        catch
        {
            foreach (string arg in args)
            {
                UndefinedArg = true;
                if (arg.Contains("--length="))
                {
                    try
                    {
                        len = Convert.ToInt32(arg[9..]);
                    }
                    catch
                    {
                        Console.WriteLine("Неправильно введена длина пароля!");
                        GetPass = false;
                    }
                    UndefinedArg = false;
                }

                if (arg.Contains("--digits=") && minL == 0)
                {
                    try
                    {
                        minD = Convert.ToInt32(arg[9..]);
                    }
                    catch
                    {
                        Console.WriteLine("Неправильно введено кол-во цифр!");
                        GetPass = false;
                    }
                }
                else if (arg.Contains("--letters=") && minD == 0)
                {
                    try
                    {
                        minL = Convert.ToInt32(arg[10..]);
                    }
                    catch
                    {
                        Console.WriteLine("Неправильно введено кол-во букв!");
                        GetPass = false;
                    }
                }

                if (arg.Contains("--uppercase") || arg.Contains("-u"))
                {
                    upper = true;
                    UndefinedArg = false;
                }

                if (arg.Contains("--special") || arg.Contains("-s"))
                {
                    spec = true;
                    UndefinedArg = false;
                }

                if (arg.Contains("--digits=") || arg.Contains("--letters=")) UndefinedArg = false;

                if (UndefinedArg)
                {
                    Console.WriteLine("Возможно вы неправильно ввели параметр \"" + arg + "\"");
                    GetPass = false;
                    Console.WriteLine("Возможные параметры: --length= , --letters= , --digits= , --uppercase / -u , --special / -s \nТакже возможно использование \"//PassGen.exe 10 \", то же самое что \" // PassGen.exe --length=10 \"");
                    break;
                }

            }
        }

        if(len < minD)
        {
            Console.WriteLine($"Заданное кол-во цифр {minD} больше чем общая длина пароля {len}");
            GetPass = false;
        }
        if (len < minL)
        {
            Console.WriteLine($"Заданное кол-во букв {minL} больше чем общая длина пароля {len}");
            GetPass = false;
        }
                
        if (GetPass)
        {
            Password = GetRndPass(len, minL, minD, upper, spec);
            Console.WriteLine(Password);
        }
        else Console.WriteLine("Попробуйте еще раз");

    }







    public static string GetRndPass(int len, int minL = 0, int minD = 0, bool upper = false, bool spec = false)
    {
        char[] chars = new char[len];
        if (minL != 0)
        {
            for(int i = 0; i < minL; i++)
                chars[i] = GetRndChar(currentChar: 4);
            len -= minL;
        }
        else if (minD != 0)
        {
            for (int i = 0; i < minD; i++)
                chars[i] = GetRndChar(currentChar: 2);
            len -= minD;
        }

        for (int i = 1; i <= len; i++)
        {
            chars[chars.Length - i]= GetRndChar(upper, spec);
        }

        for (int i = 0; i < chars.Length; i++)
        {
            char temp = chars[i];
            int rndIndex = rnd.Next(chars.Length);
            chars[i] = chars[rndIndex];
            chars[rndIndex] = temp;
        }

        string result = "";
        foreach(char ch in chars)
        {
            result += ch;
        }

        return result;

    }



    public static char GetRndChar(bool upper = false, bool spec = false, int currentChar = -1) //4 rnd letter
    {
        int id;

        if (currentChar == 4) id = rnd.Next(2);
        else if (currentChar != -1) id = currentChar;
        else id = rnd.Next(4);
        switch (id)
        {
            default:
                return LowerLet();
            case 1:
                if (upper) return UpperLet();
                return GetRndChar(upper, spec, currentChar);
            case 2:
                return Digit();
            case 3:
                if (spec) return SpecS();
                return GetRndChar(upper, spec, currentChar);
        }
    }

    public static char UpperLet()
    {
        return (char)rnd.Next(65, 91);
    }


    public static char LowerLet()
    {
        return (char)rnd.Next(97, 123);
    }

    public static char SpecS()
    {
        char[] spec = new char[] { 'q' };
        return spec[rnd.Next(spec.Length)];
    }

    public static char Digit()
    {
        return Convert.ToChar(Convert.ToString(rnd.Next(10)));
    }

}