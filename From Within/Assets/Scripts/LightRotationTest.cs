using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotationTest : MonoBehaviour
{
    public float DegreesPerSecond;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(DegreesPerSecond*Time.deltaTime, 0.0f, 0.0f, Space.Self);
    }
}
