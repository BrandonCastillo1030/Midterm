using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock_mouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
