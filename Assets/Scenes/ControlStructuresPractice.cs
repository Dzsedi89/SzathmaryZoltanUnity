using System.Globalization;
using System.Threading;
using UnityEngine;

public class ControlStructuresPractice : MonoBehaviour
{
    [SerializeField] int a, b;

    private void Start()
    {
        // Kezdet

        if (a > b) //elágazás, ha igaz, fut a kódrészlet
        {
            Debug.Log("A nagyobb mint B.");
        }
        else  if (a < b)
        {
            Debug.Log("A kisebb mint B.");
        }
        else
        {
            Debug.Log("A és B egyenlõ.");
        }

        // --------------------- A páros, vagy páratlan
        
        if (a % 2 == 0)
        {
            Debug.Log("A Páros.");
        } 
        else
        {
            Debug.Log("A Páratlan.");
        }

        //if (a % b == 0)
        //{
        //    Debug.Log("A Osztható B-vel.");
        //}
        //else if (b % a == 0)
        //{
        //    Debug.Log("B osztható A-val.");
        //}
        //else
        //{
        //    Debug.Log("Egyik sem osztható a másikkal maradék nélkül.");
        //}

        bool aDividableB = a % b == 0;
        bool bDividableA = b % a == 0;

        if (aDividableB)
        {
            Debug.Log("A osztható B-vel");
        }
        if (bDividableA)
        {
            Debug.Log("B osztható A-val");
        }
        if (!aDividableB && !bDividableA)
        {
            Debug.Log("A és B nem osztható egymással.");
        }

        //-------------------------------- Ez egy if nem eldöntentõkre, hanem konkrét értékre.

        int number = 12354;
        int lastDigit = number % 10;

        switch (lastDigit)
        {
            case 1:
                Debug.Log("Egy");
                break;
            case 2:
                Debug.Log("Kettõ");
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

        pairity = number % 2 == 0 ? "Páros" : "Páratlan"; //ha a feltétel, hogy number:2-vel nem ad maradékot, akkor visszaadja, hogy páros, egyébként páratlan. Ez egy feltételes operátor.


        //--------------------------------Írjuk ki a számokat 1-tõl 100ig. Ez egy ciklus.

        /*int i = 0;
        while (i <= 100)
        {
            Debug.Log(i);
            i++;
        }
        */
        //------------------- 0 és 100 között osztható hárommal és 7tel
        int i = 0;

        
        while (i <= 100)
        {
            bool isDividableby3 = i % 3 == 0; //a bool változót itt bele kell rakni a ciklusba, h újra nézze mindig!!!!!
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

        //változók életciklusa: Ha egy parancssoron belül hozok létre változót, az csak addig él, amíg lefut az a kódrészlet.

        //Három vezérlési szerkezet: elágazás (if, else, switch), feltételektõl függõen más irány. Ciklus: while, do while, for ciklus. Szekvencia: csak kiírjuk egmyás után a mûveleteket.
        //ahogy fut a kód, az a control flow. 
    
        //Ideáig
    }
}
