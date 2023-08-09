using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public GameObject Balle;
    Rigidbody2D Body2D;
    public float moveSpeed;
    public float X;
    public float Y; 


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject BalleClone = Instantiate(Balle, transform.position,Quaternion.identity);
            Body2D = BalleClone.GetComponent<Rigidbody2D>(); // sur la Balle tu récupère le rigidBody2D
            Vector2 direction2D = new Vector2(X , Y);
            // Body2D.velocity = direction2D * moveSpeed;
            Body2D.velocity = transform.right * moveSpeed;
        }
    }
}