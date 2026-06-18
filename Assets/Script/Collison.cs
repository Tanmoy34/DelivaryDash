using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OOuch");
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exist Out");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger entered");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Trigger Exist");
    }
}
