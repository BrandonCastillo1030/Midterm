using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotationSpeed;
    public float smoothSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate((Vector3.up * rotationSpeed) * (Time.deltaTime * smoothSpeed), Space.Self);
    }
}
