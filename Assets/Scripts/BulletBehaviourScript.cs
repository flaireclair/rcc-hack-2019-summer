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
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            //public GameObject Bullet = (GameObject)Resources.Load ("Bullet");

            GameObject bullet = Instantiate(bulletClone); 
                                            //new Vector3(transform.position.x, transform.position.y + 4.8f, transform.position.z + 15.9f),
                                            //Quaternion.Euler(0,0,0));//初期位置の設定方法がわからん
                                            
            bullet.transform.position = new Vector3(transform.position.x, transform.position.y, 0) + transform.GetChild(0).transform.localPosition + new Vector3(-1.63f, 2.8f, -17.9f);
            bullet.transform.rotation = transform.GetChild(0).gameObject.transform.localRotation;

            float z = 50f;

            Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();

            rigidbody.AddForce(0.026f * z, 0, z, ForceMode.Impulse);
        }
    }
    
}
