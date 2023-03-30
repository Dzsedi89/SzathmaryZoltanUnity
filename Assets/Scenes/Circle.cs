using UnityEngine;

public class Circle : MonoBehaviour
{

    [SerializeField] float radius = 1;

    [SerializeField] float circumferance;
    [SerializeField] float area;

    void OnValidate() //buildben, j�t�kban, sosem fog lefutni, ez a fejleszt�nek seg�t, mindig lefut, nem csak objekt kre�l�skor
    {
        circumferance = 2 * radius * 3.14f;  //k�r ker�let btw. Mathf.PI az 3.14 mag�ban is
        area = radius * radius * 3.14f;      //k�r ter�let

        // Debug.Log($"Ker: {circumferance}, Ter: {area}"); ki�rja a ker�letet �s ter�letet
    }
}
