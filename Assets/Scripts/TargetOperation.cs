using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetOperation : MonoBehaviour
{

    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKey(KeyCode.UpArrow))    pos.y = pos.y + 0.5f; 
        if (Input.GetKey(KeyCode.DownArrow))  pos.y = pos.y - 0.5f;
        if (Input.GetKey(KeyCode.LeftArrow))  pos.x = pos.x + 0.5f;
        if (Input.GetKey(KeyCode.RightArrow)) pos.x = pos.x - 0.5f;

        transform.position = pos;
    }
}
