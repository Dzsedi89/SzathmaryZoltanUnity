using UnityEngine;

public class Circle : MonoBehaviour
{

    [SerializeField] float radius = 1;

    [SerializeField] float circumferance;
    [SerializeField] float area;

    void OnValidate() //buildben, játékban, sosem fog lefutni, ez a fejlesztõnek segít, mindig lefut, nem csak objekt kreáláskor
    {
        circumferance = 2 * radius * 3.14f;  //kör kerület btw. Mathf.PI az 3.14 magában is
        area = radius * radius * 3.14f;      //kör terület

        // Debug.Log($"Ker: {circumferance}, Ter: {area}"); kiírja a kerületet és területet
    }
}
