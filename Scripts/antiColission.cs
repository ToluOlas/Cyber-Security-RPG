using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antiColission : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Person"), LayerMask.NameToLayer("Person"));
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Person"), LayerMask.NameToLayer("Townperson"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
