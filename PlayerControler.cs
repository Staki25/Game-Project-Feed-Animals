using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 12.0f;
    public float xRange = 10.0f;
    public GameObject pizzaPrifab;
    public float zRange = 18f;
    public float zEnd = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);



        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if (transform.position.z < zEnd)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zEnd);
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pizzaPrifab, transform.position, pizzaPrifab.transform.rotation);
        }
    }
}
