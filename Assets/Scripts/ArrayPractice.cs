using System.Collections.Generic;
using UnityEngine;

class ArrayPractice : MonoBehaviour
{
    [SerializeField] float[] testArray;
    [SerializeField] float mean;
    [SerializeField] float max;

    void OnValidate()
    {
        mean = Mean(testArray);
        max = Max(testArray);

        /*float mean1 = Mean(2, 6);
        float mean2 = Mean(2, 6, 7);

        float[] a1= new float[] { 1, 2, 3, 4, 5, 6, 7 };
        float mean3 = Mean(a1);
        Debug.Log(mean3);

        float[] array1 = new float[10]; // 10 elemû float tömb, 10 darab floatot tartalmazhat

        array1[0] = 0.55f;              // itt indexálunk, mindig a 0. index számmal kezdünk
        array1[1] = 1.53f;

        for (int i = 9; i < array1.Length; i++)
        {
            array1[i] = i + 1;
        }

        string[] array2 = new string[] { "Alma", "Körte", "Banán" }; */

        //LISTÁK - olyan elemsorozat aminek változik az elemszáma

        List<int> list1 = new List<int>();   //létrehozni list1 nevû listát
        list1.Add(1);       //hozáadni elemet a listához
        list1.Add(2);
        list1.Add(56);
        Debug.Log(list1[0]);
        list1[1] = 10;

        list1.RemoveAt(1); //kivenni a listából a valahanyadik elemet
        list1.Remove(2);   //kiveszi a listából a konkrét számot, értéket

        bool success = list1.Remove(56);  //sikerült vagy nem kivenni ezt az értéket
        list1.Insert(0, 12);          //beillesztek 0. indexû helyre egy értéket.

        list1.Clear();        //töröl minden elemet a listából

        bool contains = list1.Contains(12);   //megnézzük, h tartalmazza-e az értéket
        int index = list1.IndexOf(12);        //mi a konkrét érték indexe?

        list1.Sort();           //sorba teszi az értékeket


        //új fajta ciklus jajdejó
    }

    float Mean (float f1, float f2)
    {
        float mean = (f1 + f2) / 2;
        return mean;
    }

    float Mean (float n1, float n2, float n3)
    {
        return (n1 + n2 + n3) / 3;
    }

    float Mean(params float[] array)                 // akárhány számot adok meg, annyinak adja meg az átlagát.
    {
        float sum = 0;
        for (int i= 0; i <array.Length; i++)
        {
            float current = array[i];
            sum += current;
        }
        return sum / array.Length;
    }

    float Max(params float[] array)
    {
        if (array.Length == 0)
            return 0;
        float max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            float current = array[i];
            if(current > max) 
                max = current;
        }
        return max;
    }


    float Min(params float[] array)
    {
        if (array.Length == 0)
            return float.MaxValue;
        
        float min = array[0];

        foreach (float f in array)       //ÚJ CIKLUS A FOREACH, a tömb vagy lista minden elemén végigmegyünk
        {
            if (f < min)
                min = f;
        }
        return min;
    }
}
