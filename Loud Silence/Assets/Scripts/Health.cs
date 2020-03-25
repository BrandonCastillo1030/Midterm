using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//public var text1 = Texture;
//public var text2 = Texture;
//public var text3 = Texture;
//public var text4 = Texture;

//public float health = 100.0;

//private float maxHealth = 100.0;
//private boolean clickCollider;


public class Health : MonoBehaviour
{
    public float Score = 0;

    public Text mytext = null;
    public Text mytext_sc = null;

    public float health = 5.0f;

    /*private float maxHealth = 10.0f;*/

    public float damage = 1f;
    public float range = 100f;

    public Camera fpCam;
    public ParticleSystem muzzleFlash;

    void Update()
    {
      mytext.text = health.ToString("F1");
      mytext_sc.text = Score.ToString("F1");

        if (health == 0 ) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Score == 15.0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
        Debug.Log(health);
        if (Input.GetMouseButtonDown(0))
        {
            Detect();
        }

        /*if(health > maxHealth)
        {
            health = maxHealth;
        }*/
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BadGuy")
        {
            health -= 1;
        }
    }

    void Detect()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpCam.transform.position, fpCam.transform.forward, out hit, range))
        {
            //Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);

                health = health - 1;
            }
            TargetR targetR = hit.transform.GetComponent<TargetR>();
            if (targetR != null)
            {
                targetR.TakeDamage(damage);

                Score = Score + 1;

                print("SCORE"+Score);
            }
        }

    }

}
