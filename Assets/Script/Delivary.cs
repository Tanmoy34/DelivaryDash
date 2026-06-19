using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    bool isPackagePicked = false;
    
    [SerializeField] float destroyDelay = 0.3f;
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.CompareTag("Package")&& !isPackagePicked)
        {
            Destroy(collision.gameObject,destroyDelay);
            isPackagePicked = true;
            
        }
        if (collision.CompareTag("Customer") && isPackagePicked)
        {
            Destroy(collision.gameObject,destroyDelay);
            isPackagePicked = false;
            
        }
    }

    
}
