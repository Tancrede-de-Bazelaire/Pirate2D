using UnityEngine;

// Il faut déplacer le fichier de ce script sur un gameobject pour que celui-ci fasse effet
// Attention à ce que le nom du fichier soit identique au nom de la classe, sans espace ou différence de majuscule
public class MoveController : MonoBehaviour
{
    public float moveSpeed = 2.5f;  // Ceci est une variable décimale public modifiable dans la fenêtre de l'Inspector
    Transform goTransform;          // Ceci est une référence privée vers un type Transform

    public float jumpforce = 5.5f;
    public Rigidbody2D body2D;

    public Animator animator;                       // ajout animation 
    public SpriteRenderer spriteRenderer;           // ajout animation 


    void Start(){
        // Ceci affiche du texte ou des variables dans la console
        Debug.Log ("Hello Dear User, " + "My Name is " + this.gameObject.name + ", Let us go on an adventure together");

        // On récupère le Transform présent sur l'objet où se trouve ce script
        goTransform = this.gameObject.GetComponent<Transform>();
    }

    void Update(){
        // On déplace l'objet par son Transfom stocké dans goTransform, en ajoutant à sa position, une direction fois une vitesse
        // goTransform.position += Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        // si c'est vrai
        if(Input.GetKeyDown(KeyCode.Space) && body2D.IsTouchingLayers())
        {
            // alors faire...
            body2D.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
                animator.SetBool("Jump" , true);
        } else if(body2D.IsTouchingLayers() && body2D.velocity.y <= 0)
                animator.SetBool("Jump" , false);

// version plateforme
       body2D.velocity = new Vector2( Input.GetAxis("Horizontal") * moveSpeed , body2D.velocity.y ) ;



      

    float characterVelocity = Mathf.Abs(body2D.velocity.x);    // ajout animation avec Float 
    animator.SetFloat("Speed" , characterVelocity);             // ajout animation avec Float 

   
 Flip(body2D.velocity.x);     // ajout animation changement de sense

    void Flip(float _velocity)                             
        {
            if(_velocity > 0.1f)                           
        {
            spriteRenderer.flipX = false;                  
        }
            else if(_velocity < -0.1f)                  
            {
                spriteRenderer.flipX = true;             
            }
    }

// version top down 
        // body2D.velocity = new Vector2( Input.GetAxis("Horizontal") * moveSpeed , Input.GetAxis("Vertical") * moveSpeed) ;
    }
}
