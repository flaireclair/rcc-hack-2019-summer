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

    private void OnTriggerEnter(Collider bullet)
    {
        if(bullet.gameObject.tag == "Bullet")
            { Destroy(gameObject);
            //ここに被弾エフェクトのスクリプトを書く
        }
    }
}
