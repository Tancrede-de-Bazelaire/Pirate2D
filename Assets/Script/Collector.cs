using UnityEngine;

public class Collector : MonoBehaviour
{
    public LayerMask layerFilter;                   // A régler dans l'Inspector pour filtrer les contacts selon les layers
    public bool centerObjectWithCollector = true;   // Doit on centrer l'objet que l'on récupère sur notre position ?

    void OnTriggerEnter2D(Collider2D other)
    {
        // Si le contact détecté est bien celui désiré et sur le bon layer...
        if ((layerFilter.value & 1 << other.gameObject.layer) > 0)
        {
            other.gameObject.transform.parent = transform;  // On attache l'objet
            if(centerObjectWithCollector)                   // Et le centrons éventuellement
                other.gameObject.transform.localPosition = Vector3.zero;
        }
    }
}
