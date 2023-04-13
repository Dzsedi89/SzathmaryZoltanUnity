using UnityEngine;

public class MyFirstHomework : MonoBehaviour
{
    [SerializeField] int Number1, Number2;
    [SerializeField] string Result;
    void OnValidate()
    {
        int quotient = Number1 / Number2;
        int rest = Number1 % Number2;

        Result = Number1 + "-ban " + Number2 + " megvan " + quotient + "-szer, a maradék: " + rest;
    }
}
