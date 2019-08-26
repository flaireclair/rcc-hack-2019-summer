using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetOperation : MonoBehaviour
{

    private Vector3 pos;
    private Transform tran;
    private Vector2 max;
    private Vector2 min;

    [SerializeField]
    private int playerID;

    // Start is called before the first frame update
    void Start()
    {
        tran = transform;
        pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        max = new Vector2(30, 61);
        min = new Vector2(-30, 1);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("JoyCon Horizontal " + playerID);
        float vertical = Input.GetAxisRaw("JoyCon Vertical " + playerID);

        Vector3 direction = new Vector3(vertical, horizontal, 0).normalized;

        //Debug.Log(direction);

        pos += direction * 0.5f;

        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);

        tran.position = pos;
    }
}
