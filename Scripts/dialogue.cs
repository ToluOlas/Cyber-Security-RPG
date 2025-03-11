using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class dialogue 
{ 
    [TextArea(2, 10)]
    public string[] names;

    [TextArea(4, 10)]
    public string[] sentences;
}
