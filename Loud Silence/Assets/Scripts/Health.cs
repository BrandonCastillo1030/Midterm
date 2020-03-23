using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//public var text1 = Texture;
//public var text2 = Texture;
//public var text3 = Texture;
//public var text4 = Texture;

//public float health = 100.0;

//private float maxHealth = 100.0;
//private boolean clickCollider;


public class Health : MonoBehaviour
{
    public float health = 100.0f;

    private float maxHealth = 200.0f;

    public float damage = 1f;
    public float range = 100f;

    public Camera fpCam;
    public ParticleSystem muzzleFlash;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Detect();
        }
       
        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }
    
    void Detect()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpCam.transform.position, fpCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);

                health = health + 1;
            }
            TargetR targetR = hit.transform.GetComponent<TargetR>();
            if (targetR != null)
            {
                targetR.TakeDamage(damage);

                health = health - 1;
            }
        }
        
    }

}
