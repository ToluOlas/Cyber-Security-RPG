using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject followTarget;
    public GameObject followTarget2;
    private Vector3 targetPosition;
    public float moveSpeed;

    private int currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        currentTarget = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTarget==1)
        {
            targetPosition = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        }
        else if(currentTarget==2)
        {
            targetPosition = new Vector3(followTarget2.transform.position.x, followTarget2.transform.position.y, transform.position.z);
        }
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed*Time.deltaTime);
    }

    public void switchTarget()
    {
        if(currentTarget==1)
        {
            currentTarget = 2;
        }
        else if(currentTarget==2)
        {
            currentTarget = 1;
        }
    }
}
