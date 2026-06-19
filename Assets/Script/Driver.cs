using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{



    [SerializeField] float steerSeed = 0.5f;
    [SerializeField] float currentSpeed = 5f;
    [SerializeField] float boostSpeed = 10f;
    [SerializeField] float regularSpeed = 5f;

    void Start()
    {
        SetMoveValueBackToNormal();
    }

    // Update is called once per frame
    void Update()
    {

        
        float move = 0f;
        float steer = 0f;
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;   
        }
        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }

        transform.Translate(0, currentSpeed * move * Time.deltaTime,0);
        transform.Rotate(0,0,steer * steerSeed * Time.deltaTime);

    }

    public void SetBoostSpeed()
    {
        Debug.Log("speed Bosted");
        currentSpeed =  boostSpeed;
    }
    public void SetMoveValueBackToNormal()
    {
        currentSpeed =  regularSpeed;
    }
    

    
}
 