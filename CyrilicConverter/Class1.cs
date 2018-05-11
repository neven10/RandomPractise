using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrilicConverter
{
    public class CyrilicConverter
    {

        public static string ConvertCyrillicToLatin(string str)
        {

            str = str.Replace("б", "b");
            str = str.Replace("Б", "B");

            str = str.Replace("в", "v");
            str = str.Replace("В", "V");

            str = str.Replace("ґ", "g");
            str = str.Replace("Ґ", "G");

            str = str.Replace("д", "d");
            str = str.Replace("Д", "D");

            str = str.Replace("ђ", "đ");
            str = str.Replace("Ђ", "Đ");

            str = str.Replace("ж", "ž");
            str = str.Replace("Ж", "Ž");

            str = str.Replace("з", "z");
            str = str.Replace("З", "Z");

            str = str.Replace("и", "i");
            str = str.Replace("И", "I");

            str = str.Replace("л", "l");
            str = str.Replace("Л", "L");

            str = str.Replace("љ", "lj");
            str = str.Replace("Љ", "Lj");

            str = str.Replace("м", "m");
            str = str.Replace("M", "M");

            str = str.Replace("н", "n");
            str = str.Replace("Н", "N");

            str = str.Replace("њ", "nj");
            str = str.Replace("Њ", "Nj");

            str = str.Replace("п", "p");
            str = str.Replace("П", "P");

            str = str.Replace("р", "r");
            str = str.Replace("Р", "R");

            str = str.Replace("с", "s");
            str = str.Replace("С", "S");

            str = str.Replace("у", "u");//u
            str = str.Replace("У", "U");

            str = str.Replace("ф", "f");//f
            str = str.Replace("Ф", "F");

            str = str.Replace("x", "h");//h
            str = str.Replace("Х", "H");

            str = str.Replace("ц", "c");//c
            str = str.Replace("Ц", "C");

            str = str.Replace("ч", "č");
            str = str.Replace("Ч", "Č");

            str = str.Replace("џ", "dž");//dz
            str = str.Replace("Џ", "Dž");

            str = str.Replace("ш", "š");
            str = str.Replace("Ш", "Š");


            return str;
        }

        public static string ConvertLatinToCyrillic(string str)
        {

            str = str.Replace("b", "б");
            str = str.Replace("B", "Б");

            str = str.Replace("v", "в");
            str = str.Replace("V", "В");

            str = str.Replace("g", "ґ");
            str = str.Replace("G", "Ґ");

            str = str.Replace("d", "д");
            str = str.Replace("D", "Д");

            str = str.Replace("đ", "ђ");
            str = str.Replace("Đ", "Ђ");

            str = str.Replace("ž", "ж");
            str = str.Replace("Ž", "Ж");

            str = str.Replace("z", "з");
            str = str.Replace("Z", "З");

            str = str.Replace("i", "и");
            str = str.Replace("I", "И");

            str = str.Replace("l", "л");
            str = str.Replace("L", "Л");

            str = str.Replace("lj", "љ");
            str = str.Replace("Lj", "Љ");

            str = str.Replace("m", "м");
            str = str.Replace("M", "M");

            str = str.Replace("n", "н");
            str = str.Replace("N", "Н");

            str = str.Replace("nj", "њ");
            str = str.Replace("Nj", "Њ");

            str = str.Replace("p", "п");
            str = str.Replace("P", "П");

            str = str.Replace("r", "р");
            str = str.Replace("R", "Р");

            str = str.Replace("s", "с");
            str = str.Replace("S", "С");

            str = str.Replace("u", "у");//u
            str = str.Replace("U", "У");

            str = str.Replace("f", "ф");//f
            str = str.Replace("F", "Ф");

            str = str.Replace("h", "x");//h
            str = str.Replace("H", "Х");

            str = str.Replace("c", "ц");//c
            str = str.Replace("C", "Ц");

            str = str.Replace("č", "ч");
            str = str.Replace("Č", "Ч");

            str = str.Replace("dž", "џ");//dz
            str = str.Replace("Dž", "Џ");

            str = str.Replace("š", "ш");
            str = str.Replace("Š", "Ш");


            return str;
        }
    }




    }
