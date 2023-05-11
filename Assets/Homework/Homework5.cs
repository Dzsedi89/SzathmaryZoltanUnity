using UnityEngine;

public class Homework5 : MonoBehaviour
{
    private void Start()
    {
        int a = 4, b = 7;

        a += b;
        b -= a;
        b = -b;
        a -= b;
    }
}
