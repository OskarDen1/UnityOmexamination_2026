using UnityEngine;

public class Hatscript : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public GameObject Target;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, 5 * Time.deltaTime);
        }
    }
}
