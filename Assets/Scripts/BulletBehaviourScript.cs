using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletClone;

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 pos = transform.position;
        //pos.x = 0f; pos.y = 10.5f; pos.z = 5f;
        //transform.position = pos;
        //transform.eulerAngles = new Vector3(0, 0, 0);
        //gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 50);
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
        //public GameObject Bullet = (GameObject)Resources.Load ("Bullet");
            
            GameObject bullet = Instantiate(bulletClone, 
                                            new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), 
                                            Quaternion.identity);//初期位置の設定方法がわからん

            float z = 30f;

            //Rigidbody rigidbody = GetComponent<Rigidbody>();

            bullet.GetComponent<Rigidbody>().AddForce(0, 0, z, ForceMode.Impulse);
        }
    }
    
}
