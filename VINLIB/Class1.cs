using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VINLIB
{
    public class Class1
    {
       
        public bool CheckVIN(string vin)
        {
            if (vin.Length != 17)
                return false;
            var result = 0;
            var index = 0;
            var checkDigit = 0;
            var checkSum = 0;
            var weight = 0;
            foreach (var c in vin.ToCharArray())
            {
                index++;
                var character = c.ToString().ToLower();
                if (char.IsNumber(c))
                    result = int.Parse(character);
                else
                {
                    switch (character)
                    {
                        case "a":
                        case "j":
                            result = 1;
                            break;
                        case "b":
                        case "k":
                        case "s":
                            result = 2;
                            break;
                        case "c":
                        case "l":
                        case "t":
                            result = 3;
                            break;
                        case "d":
                        case "m":
                        case "u":
                            result = 4;
                            break;
                        case "e":
                        case "n":
                        case "v":
                            result = 5;
                            break;
                        case "f":
                        case "w":
                            result = 6;
                            break;
                        case "g":
                        case "p":
                        case "x":
                            result = 7;
                            break;
                        case "h":
                        case "y":
                            result = 8;
                            break;
                        case "r":
                        case "z":
                            result = 9;
                            break;
                    }
                }


                if (index >= 1 && index <= 7 || index == 9)
                    weight = 9 - index;
                else if (index == 8)
                    weight = 10;
                else if (index >= 10 && index <= 17)
                    weight = 19 - index;
                if (index == 9)
                    checkDigit = character == "x" ? 10 : result;
                checkSum += (result * weight);
            }



            return checkSum % 11 == checkDigit;
        }
        public string GetVinCountry(string vin)
        {

            string i = vin.Remove(2, 16);
           if (i == "AA" || i == "AB" || i == "AC" || i == "AD" || i == "AE" || i == "AF" || i == "AG" || i == "AH")
            {
                return "ЮАР";
            }
           else if(i == "AJ" || i == "AK" || i == "AL" || i == "AM" || i == "AN")
            {
                return "Кот-д’Ивуар";
            }
            else if(i == "BA" || i == "BB" || i == "BC" || i == "BD" || i == "BE")
            {
                return "Ангола";
            }
            else if(i == "BF" || i == "BG" || i == "BH" || i == "BI" || i == "BJ" || i == "BK")
            {
                return "Кения";
            }
            else if(i == "BL" || i == "BM" || i == "BN" || i == "BO" || i == "BP" || i == "BQ" || i == "BR")
            {
                return "Танзания";
            }
            else if(i == "СA" || i == "СB" || i == "СC" || i == "СD" || i == "СE")
            {
                return "Бенин";
            }
            else if(i == "СF" || i == "СG" || i == "СH" || i == "СI" || i == "СJ" || i == "СK")
            {
                return "Мадагаскар";
            }
            else if(i == "СL" || i == "СM" || i == "СN" || i == "СO" || i == "СP" || i == "СQ" || i == "СR")
            {
                return "Тунис";
            }
           else
            {
                return "dwada";
            }

        }
    }
   
    
}
