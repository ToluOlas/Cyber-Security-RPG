using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCameraTarget : MonoBehaviour
{
    private cameraController theCamera;
    // Start is called before the first frame update
    void Start()
    {
        theCamera = FindObjectOfType<cameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            theCamera.switchTarget();
            Destroy(gameObject);
        }
    }
}
