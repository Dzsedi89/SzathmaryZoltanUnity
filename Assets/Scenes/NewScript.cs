using UnityEngine;
//2023.03.30.

public class NewScript : MonoBehaviour
{
    [SerializeField] [Min(0)] int intField = 5; //a fiel degy olyan változó, amit nem egy metóduson belül hozunk létre. Metódus az ami a Start után jön. 
    [SerializeField , Range(0,10)]float floatField = 7.77f;
    [SerializeField] string stringField = "hello";
    [SerializeField] bool boolField = true;

    //ez utána a unityben a komponens beállításaiként jelenik meg, amit ott módosíthatunk

    void Start()
    {
        int i = 4;
        float f = 1.54f; //lebegõpontos szám, a 32 bitbõl egy bit azt jelzi, hogy hol a tizedesvesszõ
        string s = "Ez az elsõ string-em";
        bool b1 = true;  //logikai érték, igaz vagy hamis
        bool b2 = false;

        var v1 = "string"; //var, kötelezõ definiálni abban a sorban, automatikusan kitalálja, milyen változó
        var v2 = 12.5f;

        float f1 = f + 4;
        float f2 = f1 + f;
        float f3 = f2 * f;
        float f4 = f2 / f;
        float f5 = f2 % f;

        // a bemenetek alapján kapjuk meg a kimenetet, két int osztása nem lesz float, csak ha az egyik elem float - akkor automatikusan float a kimenet

        int i1 = 3, i2 = 2;

        float f7 = i1 / (float) i2; //pontos eredmény, a pontossága véges, 1/3 az 0.3333333. 32 biten tárolhat számot. (float) az int átkasztolása floattá

        double d = 23.5688; //64 biten tárolt tört szám

        long l = 12656; //64 biten tárolt egész szám

        float f8 = 5; //automatikus kasztolás, mintha (float) 5;-öt írnék
        int i3 = (int) 34.56f; //itt viszont ki kell írni a kasztolást

        //Stringek

        string s2 = s + "Akármi"; //szövegösszefûzés
        string s3 = s2 + 15; //a számot átalakítja szöveggé, és összefûzi

        //jobb gomb rename az mindenhol átnevezi a változót

        Debug.Log(s3);

        string s4 = "A korom:" + f1 + "A magasságom:" + f2; //Ez a kettõ
        string s5 = $"A korom {f1}, A magasságom: {f2}";    //ugyanaz. Kapcsos zárójelet vagy spec karakter így írok bele: duplázom {{ vagy \\

        string s6 = f7.ToString(); //f7-et (vagy bármilyen változót) átír string-gé
        string s7 = "76";
        int i4 = int.Parse(s7); //stringet átír változóvá, nem garantált, hogy mûködik
    }

}
