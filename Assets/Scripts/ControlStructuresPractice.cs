using System.Globalization;
using System.Threading;
using UnityEngine;

public class ControlStructuresPractice : MonoBehaviour
{
    [SerializeField] int a, b;

    private void Start()
    {
        // Kezdet

        if (a > b) //el�gaz�s, ha igaz, fut a k�dr�szlet
        {
            Debug.Log("A nagyobb mint B.");
        }
        else  if (a < b)
        {
            Debug.Log("A kisebb mint B.");
        }
        else
        {
            Debug.Log("A �s B egyenl�.");
        }

        // --------------------- A p�ros, vagy p�ratlan
        
        if (a % 2 == 0)
        {
            Debug.Log("A P�ros.");
        } 
        else
        {
            Debug.Log("A P�ratlan.");
        }

        //if (a % b == 0)
        //{
        //    Debug.Log("A Oszthat� B-vel.");
        //}
        //else if (b % a == 0)
        //{
        //    Debug.Log("B oszthat� A-val.");
        //}
        //else
        //{
        //    Debug.Log("Egyik sem oszthat� a m�sikkal marad�k n�lk�l.");
        //}

        bool aDividableB = a % b == 0;
        bool bDividableA = b % a == 0;

        if (aDividableB)
        {
            Debug.Log("A oszthat� B-vel");
        }
        if (bDividableA)
        {
            Debug.Log("B oszthat� A-val");
        }
        if (!aDividableB && !bDividableA)
        {
            Debug.Log("A �s B nem oszthat� egym�ssal.");
        }

        //-------------------------------- Ez egy if nem eld�ntent�kre, hanem konkr�t �rt�kre.

        int number = 12354;
        int lastDigit = number % 10;

        switch (lastDigit)
        {
            case 1:
                Debug.Log("Egy");
                break;
            case 2:
                Debug.Log("Kett�");
                break;
            //...
            case 9:
                Debug.Log("Kilenc");
                break;

            default:
                Debug.Log("Nulla");
                break;
        }

        //--------------------------------

        string pairity;

        pairity = number % 2 == 0 ? "P�ros" : "P�ratlan"; //ha a felt�tel, hogy number:2-vel nem ad marad�kot, akkor visszaadja, hogy p�ros, egy�bk�nt p�ratlan. Ez egy felt�teles oper�tor.


        //--------------------------------�rjuk ki a sz�mokat 1-t�l 100ig. Ez egy ciklus.

        /*int i = 0;
        while (i <= 100)
        {
            Debug.Log(i);
            i++;
        }
        */
        //------------------- 0 �s 100 k�z�tt oszthat� h�rommal �s 7tel
        int i = 0;

        
        while (i <= 100)
        {
            bool isDividableby3 = i % 3 == 0; //a bool v�ltoz�t itt bele kell rakni a ciklusba, h �jra n�zze mindig!!!!!
            bool isDividableby7 = i % 7 == 0;

            if (isDividableby3 && isDividableby7)
            {
                Debug.Log(i);
            }
            i++;
        }
        //------------for ciklus
        
        for (int j = 0; j < 100; j++)
        {

        }

        //v�ltoz�k �letciklusa: Ha egy parancssoron bel�l hozok l�tre v�ltoz�t, az csak addig �l, am�g lefut az a k�dr�szlet.

        //H�rom vez�rl�si szerkezet: el�gaz�s (if, else, switch), felt�telekt�l f�gg�en m�s ir�ny. Ciklus: while, do while, for ciklus. Szekvencia: csak ki�rjuk egmy�s ut�n a m�veleteket.
        //ahogy fut a k�d, az a control flow. 
    
        //Ide�ig
    }
}
