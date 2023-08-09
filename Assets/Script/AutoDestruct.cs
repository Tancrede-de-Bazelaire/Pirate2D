using UnityEngine;

public class AutoDestruct : MonoBehaviour
{
    public float timer;

/* void Start(){
        Destroy(gameObject, timer);
    }
*/

    void Update()
    {
        timer = timer - Time.fixedDeltaTime;

        if(timer <= 0f)
        {
            Destroy(gameObject);
        }
    }

    public void AutoDestroyNow (){
        Destroy(gameObject);
    }
}
