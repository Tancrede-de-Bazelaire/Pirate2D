using UnityEngine;

public class Teleport : MonoBehaviour
{
    public LayerMask layerFilter;
    public Transform exit;
    public enum ExitWay
    {
        unchanged, toLeft, toRight
    }
    public ExitWay redirection = ExitWay.unchanged;

    void OnTriggerEnter2D(Collider2D other)
    {
        if ((layerFilter.value & 1 << other.gameObject.layer) > 0)  // Si l'objet détecté est sur un bon layer
            other.transform.position = exit.position;               // Alors on téléporte cet objet à la sortie

        if (redirection != ExitWay.unchanged)   // Si on souhaite spécifier une direction de sortie
        {
            Rigidbody2D body = other.GetComponent<Rigidbody2D>();
            if (body)   // Si l'objet a un rigidbody (pour pouvoir accéder à sa vitesse)
            {
                Vector2 currentVelocity = body.velocity;
                // Si l'objet va dans la mauvaise direction on le retourne
                if ((currentVelocity.x > 0 && redirection == ExitWay.toLeft) || (currentVelocity.x < 0 && redirection == ExitWay.toRight))
                    body.velocity = new Vector2(currentVelocity.x * -1, currentVelocity.y);
            }
        }
    }
}
