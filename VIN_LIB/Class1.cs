using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {
        string symbs = "ABCDEFGHJKLMNPRSTUVWXYZ"; //бувы в номере
        string symbsAndNums = "ABCDEFGHJKLMNPRSTUVWXYZ123456789"; //буквы и цифры, в сумме 32 символа
        int flag = 0; 

        public bool CheckVin(string vin)
        {
            if (vin.Length != 17) //уникальный код должен состоять из 17 знаков
            {
                return false;
            }
            
            for (int i = 0; i < symbs.Length; i++) //для WMI
            {
                for (int j = 0; j < 1; j++)
                {
                    if (vin[j] == symbs[i])
                    {
                        flag = 1;
                        break;
                    }
                }
            }

            if (flag == 0)
            {
               return false;
            }

            if (!((Convert.ToInt32(vin[9]) >= 0 && Convert.ToInt32(vin[9]) <= 9) || vin[9] == 'X')) //для VDS
            {
                return false;
            }

            for (int i = 13; i < 17; i++) //для VIS
            {
                Convert.ToInt32(vin[i]);
            }


            flag = 0;

            for (int i = 0; i < symbsAndNums.Length; i++)
            {
                if (vin[9] == symbs[i])
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                return false;


            return true;
        }

        public string GetVINCountry(string vin)
        {
            int num = -1;

            for (int i = 0; i < symbsAndNums.Length; i++) 
            {
                if (vin[0] == symbsAndNums[i])
                {
                    num = i;
                    break;
                }
            }


            //ориентируемся на коды географических континентов и определяем конкретные по условию

            if (num == -1)
            {
                return "Невозможно определить";
            }

            if (num >= 0 && num <= 7) //от A до H
            {
                return "Африка";
            }

            else if (num >= 8 && num <= 14) //от J до R
            {
                return "Азия";
            }

            else if (num >= 15 && num <= 22) //от S до Z
            {
                return "Европа";
            }

            else if (num >= 23 && num <= 27) //от 1 да 5
            {
                return "Северная Америка";
            }

            else if (num >= 28 && num <= 29) //от 6 до 7
            {
                return "Океания";
            }

            else if (num >= 30 && num <= 31) //от 8 до 9
            {
                return "Южная Америка";            
            }
            

            return "Ошибка";
        }
    }
}
