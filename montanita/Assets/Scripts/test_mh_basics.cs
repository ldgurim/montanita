using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class test_mh_basics : MonoBehaviour
{
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject, 1f);
            rb.AddForce(Vector3.up * 500);
        }
    }

    // OnMouseDown is called when clicking
    private void OnMouseDown()
    {
        rb.velocity = Vector3.forward * 5f;
        //Destroy(gameObject, 2f);
    }
}
