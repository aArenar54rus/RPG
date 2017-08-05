using UnityEngine;
using System.Collections;

public class MouseControl : MonoBehaviour {
    void Start() {

    }

    void Update()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
