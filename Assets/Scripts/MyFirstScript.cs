using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello " + name); //Kiírja a a Hello és a GameObject nevét
        Debug.Log("Hello Zoli!"); /* Kiírja a debug consoleba, hogy Hello Zoli! */

        int a;

        a = 10;
        a = 20;

        Debug.Log(a);

        int age = 33;
        Debug.Log(age);

        int x = 2, y = 3, z = 4;

        int v1 = x + y; // összeadja x-yt, 5
        int v2 = x - z; // kivon, -2
        int v3 = v1 * v2;   //szoroz, -10
        int v4 = y / x; // oszt, de csak egészt ad meg, ergo lecsapja a végét, tehát 1.5 helyett 1. Nem az INT típus adja meg, hanem az, hogy két intel csinálom a műveletet.

        int v5 = 15 % 4; //3 (15ben a négy az 3szor megvan, maradék a 3)
        int v6 = -v5; //-3

        v6 = v6 + 5; // v6 += 5;
        v6 = x - v6;

        x++; //x += 1;    x = x+1;
        x--; //x -= 1;    x = x-1;

        // ------------------------------------------- //

        x = 2;
        y = 6;
        z = 3;

        int v7 = x + y * z; // van műveleti sorrend, előbb szoroz, aztán hozzáad x-et, 20
        int v8 = (x + y) * z; // zárójelez, betartja, 24
        int v9 = x + (y * z); 

        // -------------------------------2023.03.30. //
    }
}
