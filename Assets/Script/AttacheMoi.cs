using UnityEngine;

public class AttacheMoi : MonoBehaviour
{
    public LayerMask layerFilter;

    void ExecuteEvent(LayerMask objLayer, Transform target)
    {
        // Si le contact détecté est bien celui désiré et sur le bon layer...
        if ( (layerFilter.value & 1 << objLayer) > 0)
        {
            // Si la cible n'a pas de parrent
            if ( target.parent == null)
                target.parent = transform; // Alors on l'attache à nous
            else
                target.parent = null; // Sinon on le détache
        }
    }

    void OnCollisionEnter2D(Collision2D other) // A l'entrée parente moi !
    {
        ExecuteEvent(other.gameObject.layer, other.gameObject.GetComponent<Transform>());
    }

    void OnCollisionExit2D(Collision2D other) // A la sortie déparente moi !
    {
        ExecuteEvent(other.gameObject.layer, other.gameObject.GetComponent<Transform>());
    }
}
