using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{

    public float speed;


    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }



    //// Update is called once per frame
    //void Update()
    //{

    //    transform.Translate(Input.GetAxis("Vertical") * Vector3.forward * 4 * Time.deltaTime);
    //    transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * 4 * Time.deltaTime);

    //}


}