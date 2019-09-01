using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ScreenControl
{
    public class OutDisplayPosition : MonoBehaviour
    {
        [SerializeField]
        Camera targetCamera; // 映っているか判定するカメラへの参照

        [SerializeField]
        GameObject Enemy; // 映っているか判定する対象への参照。inspectorで指定する

        private static Vector2 lb; // 左下の座標
        private static Vector2 rt; // 右上の座標
        private static Vector2 def;
        private static Transform tran;


        // Use this for initialization
        void Start()
        {

        }

        void Update()
        {
            lb = new Vector2(transform.position.x - 35f, transform.position.y - 43f); // 左下
            rt = new Vector2(transform.position.x + 35f, transform.position.y + 43f); // 右上

            Debug.Log("target pos : " + Enemy.transform.position);
            Debug.Log("lay lb pos : " + lb);
            Debug.Log("lay rt pos : " + rt);

            if (CheckInScreen(Enemy, this.transform) == Vector2.zero)
                ShowText(this.gameObject.name + "画面内にいるよ");
            else
                ShowText(this.gameObject.name + "画面外だよ");
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
        public static Vector2 CheckInScreen(GameObject targetObj, Transform thisObj)
        {
            tran = thisObj;
            /*if (targetObj.transform.position.x == 0.0f)
                def = new Vector2(30f, 30f / tran.position.y - 31f);
            if (targetObj.transform.position.y - 31f == 0.0f)
                def = new Vector2(30f / tran.position.x, 30f);
            else
                def = new Vector2(30f / tran.position.x, 30f / tran.position.y - 31f);*/
            def = new Vector2(1.0f, 1.5f);
            lb = new Vector2(tran.position.x - 31f, tran.position.y - 33f); // 左下
            rt = new Vector2(tran.position.x + 31f, tran.position.y + 42f); // 右上
            if (targetObj.transform.position.x < lb.x)
            {
                if (targetObj.transform.position.y < lb.y)
                    return new Vector2(lb.x + def.x, lb.y + def.y);
                if (rt.y < targetObj.transform.position.y)
                    return new Vector2(lb.x + def.x, rt.y + def.y);
                return new Vector3(lb.x + def.x, targetObj.transform.position.y + def.y);
            }
            else if (rt.x < targetObj.transform.position.x)
            {
                if (targetObj.transform.position.y < lb.y)
                    return new Vector2(rt.x - def.x, lb.y + def.y);
                if (rt.y < targetObj.transform.position.y)
                    return new Vector2(rt.x - def.x, rt.y + def.y);
                return new Vector2(rt.x - def.x, targetObj.transform.position.y + def.y);
            }
            else if (targetObj.transform.position.y < lb.y)
                return new Vector2(targetObj.transform.position.x, lb.y + def.y);
            else if (rt.y < targetObj.transform.position.y)
                return new Vector2(targetObj.transform.position.x, rt.y + def.y);

            return Vector2.zero;
        }

        // 以下はサンプルのUI表示用
        //[SerializeField]
        //Text uiText;
        void ShowText(string message)
        {
            //uiText.text = message;
            Debug.Log(message);
        }
    }
}