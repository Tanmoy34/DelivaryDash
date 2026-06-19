using NUnit.Framework.Constraints;
using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    bool isPackagePicked = false;
    
    [SerializeField] float destroyDelay = 0.3f;
    ParticleSystem delivaryParticle;
    [SerializeField] TMP_Text boostTextEffect;
    
    void Start()
    {
        delivaryParticle =  GetComponent<ParticleSystem>();
        boostTextEffect.gameObject.SetActive(false);
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.CompareTag("Package")&& !isPackagePicked)
        {
            Destroy(collision.gameObject,destroyDelay);
            isPackagePicked = true;
            
            delivaryParticle.Play();
            
        }
        if (collision.CompareTag("Customer") && isPackagePicked)
        {
            Destroy(collision.gameObject,destroyDelay);
            isPackagePicked = false;

            delivaryParticle.Stop();
            
        }
        if (collision.CompareTag("SpeedBoost"))
        {
            GetComponent<Driver>().SetBoostSpeed();
            Destroy(collision.gameObject,destroyDelay);
            boostTextEffect.gameObject.SetActive(true);
            boostTextEffect.SetText("Boosted");
        }


       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("WroldCollison"))
        {
            GetComponent<Driver>().SetMoveValueBackToNormal();
            boostTextEffect.gameObject.SetActive(false);

        }
    }


}
