using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 target = new Vector3(19.3f, 1.13f, 0.0f);

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

      transform.RotateAround(target, Vector3.up, 15 * Time.deltaTime);
    }

}
