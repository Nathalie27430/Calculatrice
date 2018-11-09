using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
//classe qui identifie le signe et choisi la bonne methode en fonction de celui ci
{
    public class DispatchOperation
    {
        public string ChooseOperation(string result)
        {

            Operation operation = new Operation();
            string resultFinal = "";
            //split separe la chaine selon un signe défini  et met les deux éléments de chaque cote dans un tableau
            //string[] numbers = result.Split('+');
            string[] numarray;

            //recuperer et convertir les result en double
            double num1;
            double num2 ;

            //si le result contient un caractere spécifique alors je fais la methode voulue
            if (result.Contains("+"))
            {
                numarray = retrievenumberSplit("+", result);
                num1 = double.Parse(numarray[0]);
                num2 = double.Parse(numarray[1]);

                resultFinal = operation.Addition(num1, num2).ToString();
            }

            if (result.Contains("-"))
            {
                numarray = retrievenumberSplit("-", result);
                num1 = double.Parse(numarray[0]);
                num2 = double.Parse(numarray[1]);
                resultFinal = operation.Soustraction(num1, num2).ToString();
            }

            if (result.Contains("*"))
            {
                numarray = retrievenumberSplit("*", result);
                num1 = double.Parse(numarray[0]);
                num2 = double.Parse(numarray[1]);
                resultFinal = operation.Soustraction(num1, num2).ToString();
            }

            return resultFinal;
        }
        private string[] retrievenumberSplit(string symbole, string result)
        {
            
            string[] numbers = result.Split(Convert.ToChar(symbole));
            //recuperer et convertir les result en double
            return numbers;

        }
        
    }
 

}
