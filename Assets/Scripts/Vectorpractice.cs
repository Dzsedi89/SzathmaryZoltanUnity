using UnityEngine;

/* Vektorok. 2D koordin�ta rendszeren x,y sz�mot megadva megkapunk egy helyvektort, ami az orig�b�l indul ki. 3D eset�ben x,y,z sz�m. A vektorokon 
 v�gezhetek el �sszead�st. X �rt�ket X-szel, Y-t Y-nal. Ilyenkor az egyik vektor v�g�b�l indul a m�sik, az lesz az eredm�ny. Kivon�sn�l a kivonott sz�m v�g�b�l
indul a vektor a m�sik v�g�hez. Szorozhatjuk egy sz�mmal a vektort, vagy oszthatjuk egy sz�mmal. Magnitude-ot, azaz hosszt is sz�m�thatunk, ez tulk�pp egy 
pitagorasz t�teles sz�m�t�s (egy floatot kapunk a vektorb�l). Emellett normaliz�lhatjuk a vektort, ami a hossz�t teszi 1-gy�, az ir�ny�t meg megtartja.
A norm�ltvektor az egy fel�let/szakasz/ak�rmir�l 0 fokban kifel� mutat� vektor.*/

class Vectorpractice : MonoBehaviour
{
    void Start()
    {

        Vector2 v2; //2d vektor
        Vector3 v3; //3d vektor

        v2 = new Vector2(3, 7); //vektor megad�s�n�l ki kell �rni, hogy ez egy �j v�ltoz�, teh�t new.
        v3 = new Vector3(3, 7, 6); //ha a harmadik koordin�t�t itt nem �rjuk ki, az automatikusan 0 lesz.

        v3 = new Vector3(); //x, y, z = 0

        v3 = Vector3.zero; // x, y, z = 0
        v3 = Vector3.one;   //x, y, z = 1

        
        //egys�gvektorok:
        v3 = Vector3.right;   // x = 1, y = 0, z = 0
        v3 = Vector3.left;    // x = -1, y = 0, z = 0
        v3 = Vector3.up;      // x = 0, y = 1, z = 0
        v3 = Vector3.down;    // x = 0, y = -1, z = 0
        v3 = Vector3.forward; // x = 0, y = 0, z = 1
        v3 = Vector3.back;    // x = 0, y = 0, z = -1

        // M�veletek

        Vector3 vSum= v3 + new Vector3(1, 2, 3); //k�t 3D-s vektor �sszead�sa
        Vector3 vDif = vSum - Vector3.left;      //k�t 3d-s vektor kivon�sa
        Vector3 vMult = v3 * 10;                 //3d-s vektor szorz�sa sz�mmal
        Vector3 vDiv = vSum / 10;                //3d-s vektor oszt�sa sz�mmal

        float length = v3.magnitude;             //vektor hossz�nak k�rdez�se
        Vector3 normalized = v3.normalized;      //normaliz�lt, egys�ghossz� vektor lesz -> v3 �rt�ke nem v�ltozik
        v3.Normalize();                          //normaliz�l, egys�ghossz� vektor csin�l-> v3 �rt�ke v�ltozik

        //

        float x = v3.x;              //lek�rdezem az x floatot a vektorb�l
        float y = v3.y;
        float z = v3.z; 
    }
}
