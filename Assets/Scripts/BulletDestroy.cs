using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider t)
    {
        Debug.Log(t.gameObject.name);
        if (t.gameObject.name == "1p")
        {
            Debug.Log("Hit!");
            Destroy(this.gameObject);
        }
    }
}
