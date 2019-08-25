using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos.x = 0f; pos.y = 10.5f; pos.z = 5f;
        transform.position = pos;
        transform.eulerAngles = new Vector3(0, 0, 0);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
