using UnityEngine;

class Methods : MonoBehaviour
{
    void Start()
    {

        //a Mathf.-ig eljutunk, ott kiírja az összes matematikai függvény lehetõséget. A függvény a végén paramétereket vár, azokat adjuk meg a zárójelben.
        int a = -45;

        int abs = Mathf.Abs(a); //megadja az abszolútot
        int min = Mathf.Min(a, 10); //kiadja a kisebbet
        int max = Mathf.Max(a, 10, -5); //kiadja a nagyobbat

        int myAbs; //itt én írom meg az abszolútérték kódját, én írom meg a metódust.
        if(a < 0)
        {
            myAbs = -a;
        }
        else
        {
            myAbs = a;
        }

        float power = Mathf.Pow(23.5f, 4);
        float power2 = MyPow(23.5f, 4);

        float sign = Mathf.Sign(-254); //elõjelfüggvény, visszaad negatív számra egy -1-et, pozitívre egy 1-est.

        MultiplicationTable(10); //kiírja a szorzótáblánkat 10ig
        MultiplicationTable(3);  //kiírja a szorzótáblánka 3ig. A aszorzótábla metódus vagy miapicsa ott van lenn.

        float f;
        f = Mathf.Clamp(power, -10, 10); //bármilyen értéket beszorít 10 és -10 közé, tehát pl 200 az 10 lesz, 7 az 7, -23 az -10.
        f = Mathf.Clamp01(power2); //bármit beszorít 0 és 1 közé
        f = Mathf.Ceil(f); //egy szám felfelé kerekítése tizedesrõl. 33.2 -> 34 lesz
        f = Mathf.Floor(f); //egy szám lefelé kerekítése tizedesrõl. 33.2 -> 33 lesz
        f = Mathf.Round(f); //kerekít a legközelebbire
        int i;
        i = Mathf.CeilToInt(f);  //ue. csak intet ad
        i = Mathf.FloorToInt(f); //ue. csak intet ad
        f = Mathf.FloorToInt(f);  //ue. csak intet ad

        f = Mathf.Pow(f, 10); //hatványoz
        f = Mathf.Sqrt(f); //négyzetgyököt ad meg
        f = Mathf.Pow(f, 1/3f); //köb vagy akárhanyadik gyököt ad meg


    }
    
    

    //metódus írása abszolútértékre//
    int MyAbs(int num) // milyen típus? intet várunk a végén, mi a neve, mi a bemenet típusa és mi a neve a bemenet változónak
    {
        int myAbs; 
        if (num < 0)
        {
            myAbs = -num;
        }
        else
        {
            myAbs = num;
        }
        return myAbs; //a végén ezzel adom vissza (írom ki, végeztetem el) ezt az értéket, ami a myabs függvény

    }


    //metódus írása hatványozásra
    float MyPow(float baseNumber, int exponent)
    {
        float result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }

    float MySign(float number)
    {
        int result;
        if (number < 0)
        {
            result = -1; //vagy esetleg itt egybõl return = -1;
        }
        else
        {
            result = 1; //vagy esetleg itt egybõl return = 1;
        }
        return result; //ha fenn returnuk vannak, ott kiléptünk, ergo itt nem kell a return result.
    }

    //metódus írása szorzótáblára
    void MultiplicationTable(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= number; j++)
            {
                string s = $"{j} * {i} = {i * j}";
                Debug.Log(s);
            }
        }
    }

    //max és minimum keresõ függvény//

    float Min(float a, float b)
    {
        //if (a < b)
        //{
        //    return a;
        //}
        //else
        //{
        //    return b;
        //}

        //ez ugyanaz://
        return a < b ? a: b;
    }

    float Max(float a, float b)
    {
        //if (a > b)
        //{
        //    return a;
        //}
        //else
        //{
        //    return b;
        //}

        //ez ugyanaz
        return a > b ? a : b;
    }
}


//a kódismétlés elkerülése a metódusok feladata, de arra is jó, hogy egy metódust egybõl tudunk paraméterezni.
