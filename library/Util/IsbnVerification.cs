using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Util
{
    class IsbnVerification
    {
        private static bool verification = false;
        private static double total;

        public static bool Isbn (String isbn)
        {
            char[] indice = isbn.Replace("-", "").ToCharArray();

            switch (indice.Length)
            {
                case 10:
                    total = ((int)char.GetNumericValue(indice[0]) * 10 
                        + (int)char.GetNumericValue(indice[1]) * 9
                        + (int)char.GetNumericValue(indice[2]) * 8
                        + (int)char.GetNumericValue(indice[3]) * 7
                        + (int)char.GetNumericValue(indice[4]) * 6
                        + (int)char.GetNumericValue(indice[5]) * 5
                        + (int)char.GetNumericValue(indice[6]) * 4
                        + (int)char.GetNumericValue(indice[7]) * 3
                        + (int)char.GetNumericValue(indice[8]) * 2
                        + (int)char.GetNumericValue(indice[9]) * 1);

                    if(total % 11 == 0)
                    {
                        verification = true;
                    }

                    break;
                case 13:
                    total = ((int)char.GetNumericValue(indice[0]) * 1
                        + (int)char.GetNumericValue(indice[1]) * 3
                        + (int)char.GetNumericValue(indice[2]) * 1
                        + (int)char.GetNumericValue(indice[3]) * 3
                        + (int)char.GetNumericValue(indice[4]) * 1
                        + (int)char.GetNumericValue(indice[5]) * 3
                        + (int)char.GetNumericValue(indice[6]) * 1
                        + (int)char.GetNumericValue(indice[7]) * 3
                        + (int)char.GetNumericValue(indice[8]) * 1
                        + (int)char.GetNumericValue(indice[9]) * 3
                        + (int)char.GetNumericValue(indice[10]) * 1
                        + (int)char.GetNumericValue(indice[11]) * 3
                        + (int)char.GetNumericValue(indice[12]) * 1);

                    if(total % 10 == 0)
                    {
                        verification = true;
                    }

                    break;
                default:
                    return false;
            }

            return verification;
            
        }

    }
}
