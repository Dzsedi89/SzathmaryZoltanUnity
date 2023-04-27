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

        float[] array1 = new float[10]; // 10 elem� float t�mb, 10 darab floatot tartalmazhat

        array1[0] = 0.55f;              // itt index�lunk, mindig a 0. index sz�mmal kezd�nk
        array1[1] = 1.53f;

        for (int i = 9; i < array1.Length; i++)
        {
            array1[i] = i + 1;
        }

        string[] array2 = new string[] { "Alma", "K�rte", "Ban�n" }; */

        //LIST�K - olyan elemsorozat aminek v�ltozik az elemsz�ma

        List<int> list1 = new List<int>();   //l�trehozni list1 nev� list�t
        list1.Add(1);       //hoz�adni elemet a list�hoz
        list1.Add(2);
        list1.Add(56);
        Debug.Log(list1[0]);
        list1[1] = 10;

        list1.RemoveAt(1); //kivenni a list�b�l a valahanyadik elemet
        list1.Remove(2);   //kiveszi a list�b�l a konkr�t sz�mot, �rt�ket

        bool success = list1.Remove(56);  //siker�lt vagy nem kivenni ezt az �rt�ket
        list1.Insert(0, 12);          //beillesztek 0. index� helyre egy �rt�ket.

        list1.Clear();        //t�r�l minden elemet a list�b�l

        bool contains = list1.Contains(12);   //megn�zz�k, h tartalmazza-e az �rt�ket
        int index = list1.IndexOf(12);        //mi a konkr�t �rt�k indexe?

        list1.Sort();           //sorba teszi az �rt�keket


        //�j fajta ciklus jajdej�
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

    float Mean(params float[] array)                 // ak�rh�ny sz�mot adok meg, annyinak adja meg az �tlag�t.
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

        foreach (float f in array)       //�J CIKLUS A FOREACH, a t�mb vagy lista minden elem�n v�gigmegy�nk
        {
            if (f < min)
                min = f;
        }
        return min;
    }
}
