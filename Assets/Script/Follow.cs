using UnityEngine;

public class Follow : MonoBehaviour
{
    [Header("Cas 1: suivre une cible")]
    public Transform followOneTarget;
    [Header("Cas 2: suivre un chemin")]
    public Transform[] followPath;
    public float speed = 5f;
    public float precision = 0.2f;
    public bool pathIsOpen;

    int currentPath = 0;
    bool loopingBack = false;
    Vector3 vFollow = Vector3.zero;

    void Start()
    {
        if (!followOneTarget)
            transform.position = followPath[currentPath].position;
    }

    void Update()
    {
        if (followOneTarget)
        {
            Vector3 vFollow = (followOneTarget.position - transform.position) * 0.9f * Time.deltaTime;
            vFollow.z = 0f;
            transform.position += vFollow;
        }
        else
        {
            if (Vector2.Distance(followPath[currentPath].position, transform.position) <= precision)
            {
                currentPath += loopingBack ? -1 : 1;

                if (!loopingBack && currentPath > followPath.Length - 1)
                {
                    currentPath = pathIsOpen ? currentPath - 1 : 0;
                    loopingBack = pathIsOpen ? !loopingBack : false;
                }
                else if (loopingBack && currentPath < 0)
                {
                    currentPath = 1;
                    loopingBack = false;
                }

                vFollow = (followPath[currentPath].position - transform.position).normalized;
                vFollow.z = 0f;
            }
            transform.position += vFollow * speed * Time.deltaTime;
        }
    }
}
