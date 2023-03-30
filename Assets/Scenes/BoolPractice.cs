using UnityEngine;

public class BoolPractice : MonoBehaviour
{   
    void Start()
    {

        bool b1 = true; //a bool egy eldöntendõ kérdésre adott válasz változója
        bool b2 = false;

        b1 = false;

        int i1 = 33, i2 = 33;

        bool intsAreEqual =  i1 == i2; // == egy összehasonlító operátor, vizsgálja, hogy a két operandusa egyezik-e, ha igen, igen, ha nem, nem / True
        bool i1IsHigherThani2 = i1 > i2; //false
        bool i1IsLowerThani2 = i1 < i2;  //false
        
        bool i1IsHigherOrEqualThani2 = i1 >= i2; //True
        bool i1IsLowerOrEqualThani2 = i1 <= i2;  //True

        bool intsAreNotEqual = i1 != i2; //False

        bool stringsAreEqual = "aaaa" == "AAAA"; // False
        bool stringsAreNotEqual = "aaaa" != "AAAA"; // True

        // -------------------------------

        int ammo = 50;
        bool isAlive = true;
        bool haveAmmo = ammo > 0;

        bool canShoot = isAlive && haveAmmo; //ha van lõszer és életben vagyunk, akkor canshoot az true

        float height = 12;
        bool canAirJump = false;

        bool canJump = canAirJump || height == 0; //a példában levegõben vagyok, és nem igaz, hogy tudnék ilyenkor ugrani. Tehát megnézi, hogy a magasságom vagy 0 (földön vagyok) vagy tudok-e airjumpolni

        bool isInAir = height > 0;

        bool isGrounded = !isInAir;

        canJump = canAirJump || !isInAir; //ugyanaz, csak negálva az isinair

        bool b3 = b1 ^ b2; //kizáróVagy vagy ez vagy az de mindegyik nem.
    }

}
