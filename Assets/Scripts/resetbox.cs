using UnityEngine;

public class resetbox : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Vector3 orginalPosition = gameObject.transform.position;
        if(other.gameObject.tag == "End")
        {
            gameObject.transform.position = orginalPosition;
        }
  
    }
}
