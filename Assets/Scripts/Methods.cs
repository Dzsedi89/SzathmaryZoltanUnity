using UnityEngine;

class Methods : MonoBehaviour
{
    void Start()
    {

        //a Mathf.-ig eljutunk, ott ki�rja az �sszes matematikai f�ggv�ny lehet�s�get. A f�ggv�ny a v�g�n param�tereket v�r, azokat adjuk meg a z�r�jelben.
        int a = -45;

        int abs = Mathf.Abs(a); //megadja az abszol�tot
        int min = Mathf.Min(a, 10); //kiadja a kisebbet
        int max = Mathf.Max(a, 10, -5); //kiadja a nagyobbat

        int myAbs; //itt �n �rom meg az abszol�t�rt�k k�dj�t, �n �rom meg a met�dust.
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

        float sign = Mathf.Sign(-254); //el�jelf�ggv�ny, visszaad negat�v sz�mra egy -1-et, pozit�vre egy 1-est.

        MultiplicationTable(10); //ki�rja a szorz�t�bl�nkat 10ig
        MultiplicationTable(3);  //ki�rja a szorz�t�bl�nka 3ig. A aszorz�t�bla met�dus vagy miapicsa ott van lenn.

        float f;
        f = Mathf.Clamp(power, -10, 10); //b�rmilyen �rt�ket beszor�t 10 �s -10 k�z�, teh�t pl 200 az 10 lesz, 7 az 7, -23 az -10.
        f = Mathf.Clamp01(power2); //b�rmit beszor�t 0 �s 1 k�z�
        f = Mathf.Ceil(f); //egy sz�m felfel� kerek�t�se tizedesr�l. 33.2 -> 34 lesz
        f = Mathf.Floor(f); //egy sz�m lefel� kerek�t�se tizedesr�l. 33.2 -> 33 lesz
        f = Mathf.Round(f); //kerek�t a legk�zelebbire
        int i;
        i = Mathf.CeilToInt(f);  //ue. csak intet ad
        i = Mathf.FloorToInt(f); //ue. csak intet ad
        f = Mathf.FloorToInt(f);  //ue. csak intet ad

        f = Mathf.Pow(f, 10); //hatv�nyoz
        f = Mathf.Sqrt(f); //n�gyzetgy�k�t ad meg
        f = Mathf.Pow(f, 1/3f); //k�b vagy ak�rhanyadik gy�k�t ad meg


    }
    
    

    //met�dus �r�sa abszol�t�rt�kre//
    int MyAbs(int num) // milyen t�pus? intet v�runk a v�g�n, mi a neve, mi a bemenet t�pusa �s mi a neve a bemenet v�ltoz�nak
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
        return myAbs; //a v�g�n ezzel adom vissza (�rom ki, v�geztetem el) ezt az �rt�ket, ami a myabs f�ggv�ny

    }


    //met�dus �r�sa hatv�nyoz�sra
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
            result = -1; //vagy esetleg itt egyb�l return = -1;
        }
        else
        {
            result = 1; //vagy esetleg itt egyb�l return = 1;
        }
        return result; //ha fenn returnuk vannak, ott kil�pt�nk, ergo itt nem kell a return result.
    }

    //met�dus �r�sa szorz�t�bl�ra
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

    //max �s minimum keres� f�ggv�ny//

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


//a k�dism�tl�s elker�l�se a met�dusok feladata, de arra is j�, hogy egy met�dust egyb�l tudunk param�terezni.
