using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 100.0f;
    private float horizontalInput;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (transform.position.x < -26)
        {
            transform.position = new Vector3(-26, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 19)
        {
            transform.position = new Vector3(19, transform.position.y, transform.position.z);
        }
    }
}
