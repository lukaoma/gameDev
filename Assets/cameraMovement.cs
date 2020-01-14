using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GOFollow = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(GOFollow.transform.position.x,GOFollow.transform.position.y,-1);
        transform.position = pos;
    }
}
