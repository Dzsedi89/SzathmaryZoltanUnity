using UnityEngine;

public class BoolPractice : MonoBehaviour
{   
    void Start()
    {

        bool b1 = true; //a bool egy eld�ntend� k�rd�sre adott v�lasz v�ltoz�ja
        bool b2 = false;

        b1 = false;

        int i1 = 33, i2 = 33;

        bool intsAreEqual =  i1 == i2; // == egy �sszehasonl�t� oper�tor, vizsg�lja, hogy a k�t operandusa egyezik-e, ha igen, igen, ha nem, nem / True
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

        bool canShoot = isAlive && haveAmmo; //ha van l�szer �s �letben vagyunk, akkor canshoot az true

        float height = 12;
        bool canAirJump = false;

        bool canJump = canAirJump || height == 0; //a p�ld�ban leveg�ben vagyok, �s nem igaz, hogy tudn�k ilyenkor ugrani. Teh�t megn�zi, hogy a magass�gom vagy 0 (f�ld�n vagyok) vagy tudok-e airjumpolni

        bool isInAir = height > 0;

        bool isGrounded = !isInAir;

        canJump = canAirJump || !isInAir; //ugyanaz, csak neg�lva az isinair

        bool b3 = b1 ^ b2; //kiz�r�Vagy vagy ez vagy az de mindegyik nem.
    }

}
