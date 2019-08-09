using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBehaviour : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        KillBrick();
    }

    void KillBrick()
    {
        Destroy(this.gameObject);
    }
    

}
