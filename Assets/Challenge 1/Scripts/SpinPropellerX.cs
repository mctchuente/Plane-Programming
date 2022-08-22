using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float speed = 25.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.right * speed * Time.deltaTime);
        transform.Rotate (new Vector3 (0, 0, 45) * speed * Time.deltaTime);
    }
}
