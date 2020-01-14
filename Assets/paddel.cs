using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddel : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up);
            
            transform.Rotate(Vector3.forward,rotationSpeed*Time.deltaTime);
        }
    }
}
