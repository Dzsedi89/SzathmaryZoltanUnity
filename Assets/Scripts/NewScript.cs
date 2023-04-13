using UnityEngine;
//2023.03.30.

public class NewScript : MonoBehaviour
{
    [SerializeField] [Min(0)] int intField = 5; //a fiel degy olyan v�ltoz�, amit nem egy met�duson bel�l hozunk l�tre. Met�dus az ami a Start ut�n j�n. 
    [SerializeField , Range(0,10)]float floatField = 7.77f;
    [SerializeField] string stringField = "hello";
    [SerializeField] bool boolField = true;

    //ez ut�na a unityben a komponens be�ll�t�saik�nt jelenik meg, amit ott m�dos�thatunk

    void Start()
    {
        int i = 4;
        float f = 1.54f; //lebeg�pontos sz�m, a 32 bitb�l egy bit azt jelzi, hogy hol a tizedesvessz�
        string s = "Ez az els� string-em";
        bool b1 = true;  //logikai �rt�k, igaz vagy hamis
        bool b2 = false;

        var v1 = "string"; //var, k�telez� defini�lni abban a sorban, automatikusan kital�lja, milyen v�ltoz�
        var v2 = 12.5f;

        float f1 = f + 4;
        float f2 = f1 + f;
        float f3 = f2 * f;
        float f4 = f2 / f;
        float f5 = f2 % f;

        // a bemenetek alapj�n kapjuk meg a kimenetet, k�t int oszt�sa nem lesz float, csak ha az egyik elem float - akkor automatikusan float a kimenet

        int i1 = 3, i2 = 2;

        float f7 = i1 / (float) i2; //pontos eredm�ny, a pontoss�ga v�ges, 1/3 az 0.3333333. 32 biten t�rolhat sz�mot. (float) az int �tkasztol�sa floatt�

        double d = 23.5688; //64 biten t�rolt t�rt sz�m

        long l = 12656; //64 biten t�rolt eg�sz sz�m

        float f8 = 5; //automatikus kasztol�s, mintha (float) 5;-�t �rn�k
        int i3 = (int) 34.56f; //itt viszont ki kell �rni a kasztol�st

        //Stringek

        string s2 = s + "Ak�rmi"; //sz�veg�sszef�z�s
        string s3 = s2 + 15; //a sz�mot �talak�tja sz�vegg�, �s �sszef�zi

        //jobb gomb rename az mindenhol �tnevezi a v�ltoz�t

        Debug.Log(s3);

        string s4 = "A korom:" + f1 + "A magass�gom:" + f2; //Ez a kett�
        string s5 = $"A korom {f1}, A magass�gom: {f2}";    //ugyanaz. Kapcsos z�r�jelet vagy spec karakter �gy �rok bele: dupl�zom {{ vagy \\

        string s6 = f7.ToString(); //f7-et (vagy b�rmilyen v�ltoz�t) �t�r string-g�
        string s7 = "76";
        int i4 = int.Parse(s7); //stringet �t�r v�ltoz�v�, nem garant�lt, hogy m�k�dik
    }

}
