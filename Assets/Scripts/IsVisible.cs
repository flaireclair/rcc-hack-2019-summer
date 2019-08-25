using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsVisible : MonoBehaviour
{
    [SerializeField]
    Camera targetCamera; // 映っているか判定するカメラへの参照

    [SerializeField]
    Transform targetObj; // 映っているか判定する対象への参照。inspectorで指定する

    Vector3 lb; // 左下の座標
    Vector3 rt; // 右上の座標
    Transform tran;


    // Use this for initialization
    void Start()
    {
        tran = transform;
    }

    void Update()
    {
        lb = new Vector3(tran.position.x - 35.9f, tran.position.y - 47.4f, 30.0f); // 左下
        rt = new Vector3(tran.position.x + 35.9f, tran.position.y + 43.3f, 30.0f); // 右上

        /*Debug.Log("target pos : " + targetObj.transform.position);
        Debug.Log("lay lb pos : " + lb);
        Debug.Log("lay rt pos : " + rt);*/

        if (CheckInScreen())
            ShowText("画面内にいるよ");
        else
            ShowText("画面外だよ");
    }

    // カメラからRayを飛ばしてhitした位置を返す
    Vector3 GetRayhitPos(Vector3 targetPos)
    {
        Ray ray = targetCamera.ViewportPointToRay(targetPos);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) 
        {
            Debug.Log(hit.point);
            return hit.point;
        }

        return Vector3.zero; // 何もヒットしなければ(0, 0, 0)を返す
    }

    // 対象のオブジェクトの位置から画面内かどうか判定して返す
    bool CheckInScreen()
    {
        if (targetObj.position.x < lb.x || rt.x < targetObj.position.x || targetObj.position.y < lb.y || rt.y < targetObj.position.y)
            return false;

        return true;
    }

    // 以下はサンプルのUI表示用
    [SerializeField]
    Text uiText;
    void ShowText(string message)
    {
        uiText.text = message;
    }


}