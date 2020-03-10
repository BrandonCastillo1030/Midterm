using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Color;




public class trueDestroy : MonoBehaviour
{
    public int Opacity = 0;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Alpha>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        if (Destroy(GetComponent.GoodGuy))
        {
            Opacity = new Color(0, 0, 0, 1);
            
            image.color = new Color(0, 0, 0,Opacity);
        }
    }
}
