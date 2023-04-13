using UnityEngine;

public class Sumoffirstnumbers : MonoBehaviour
{
    [SerializeField, Min(0)] int number;
    void Start()
    {
        int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }
    }

    
}
