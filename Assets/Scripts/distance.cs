using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{
    Vector3 a;
    Vector3 b;
    // Start is called before the first frame update
    void Start()
    {
        a = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        b = new Vector3(0.0f, 1.0f, -30.0f);

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(a,b);
        Debug.Log(dist);

    }
}
