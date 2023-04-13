using UnityEngine;

/* Vektorok. 2D koordináta rendszeren x,y számot megadva megkapunk egy helyvektort, ami az origóból indul ki. 3D esetében x,y,z szám. A vektorokon 
 végezhetek el összeadást. X értéket X-szel, Y-t Y-nal. Ilyenkor az egyik vektor végébõl indul a másik, az lesz az eredmény. Kivonásnál a kivonott szám végébõl
indul a vektor a másik végéhez. Szorozhatjuk egy számmal a vektort, vagy oszthatjuk egy számmal. Magnitude-ot, azaz hosszt is számíthatunk, ez tulképp egy 
pitagorasz tételes számítás (egy floatot kapunk a vektorból). Emellett normalizálhatjuk a vektort, ami a hosszát teszi 1-gyé, az irányát meg megtartja.
A normáltvektor az egy felület/szakasz/akármirõl 0 fokban kifelé mutató vektor.*/

class Vectorpractice : MonoBehaviour
{
    void Start()
    {

        Vector2 v2; //2d vektor
        Vector3 v3; //3d vektor

        v2 = new Vector2(3, 7); //vektor megadásánál ki kell írni, hogy ez egy új változó, tehát new.
        v3 = new Vector3(3, 7, 6); //ha a harmadik koordinátát itt nem írjuk ki, az automatikusan 0 lesz.

        v3 = new Vector3(); //x, y, z = 0

        v3 = Vector3.zero; // x, y, z = 0
        v3 = Vector3.one;   //x, y, z = 1

        
        //egységvektorok:
        v3 = Vector3.right;   // x = 1, y = 0, z = 0
        v3 = Vector3.left;    // x = -1, y = 0, z = 0
        v3 = Vector3.up;      // x = 0, y = 1, z = 0
        v3 = Vector3.down;    // x = 0, y = -1, z = 0
        v3 = Vector3.forward; // x = 0, y = 0, z = 1
        v3 = Vector3.back;    // x = 0, y = 0, z = -1

        // Mûveletek

        Vector3 vSum= v3 + new Vector3(1, 2, 3); //két 3D-s vektor összeadása
        Vector3 vDif = vSum - Vector3.left;      //két 3d-s vektor kivonása
        Vector3 vMult = v3 * 10;                 //3d-s vektor szorzása számmal
        Vector3 vDiv = vSum / 10;                //3d-s vektor osztása számmal

        float length = v3.magnitude;             //vektor hosszának kérdezése
        Vector3 normalized = v3.normalized;      //normalizált, egységhosszú vektor lesz -> v3 értéke nem változik
        v3.Normalize();                          //normalizál, egységhosszú vektor csinál-> v3 értéke változik

        //

        float x = v3.x;              //lekérdezem az x floatot a vektorból
        float y = v3.y;
        float z = v3.z; 
    }
}
