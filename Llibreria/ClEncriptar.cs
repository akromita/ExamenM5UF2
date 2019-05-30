using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Llibreria
{
    public class ClEncriptar
    {

        public Boolean EsPrimer(Int32 n)
        {
            Boolean resultat = true;
            //7 nomes es pot dividir per ell mateix o per 1, sino torna residu
            Int32 minim_divisor = 1;    //aquest sempre sera el numero minim per el qual dividir
            Int32 minim = 1;
            Int32 residu = 0;
            Int32 residu_num1 = 1;
            //mentre que minim sigui diferent a n anem fent el bucle
            while (minim <= n && residu != 2)   //2 voldra dir que si es pot dividir i retorna 0
            {
                //mentre que el numero 
                Int32 operacio = n % minim; //aixo retornara el residu

                if (minim == 1 && operacio == 0)
                {
                    residu_num1 = 0;    //posa el residu de el numero 1 a 0
                    minim++;
                }
                else
                {
                    if (operacio == 0 && (minim != 1 || minim != n))
                    {
                        residu = 2;
                        resultat = false;   //no es primer
                    }
                    else
                    {
                        minim++;
                    }

                }
            }
            return resultat;
        }

        public Int32 EsMesGran(Int32 a, Int32 b)
        {
            Int32 resultat;

            if (a == b)
            {
                resultat = a;
            }

            if (a > b)
            {
                resultat = a;
            }
            else
            {
                resultat = b;
            }

            return resultat;
        }
    }
}

       