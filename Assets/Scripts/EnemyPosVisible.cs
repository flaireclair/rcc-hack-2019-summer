using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScreenControl
{
    public class EnemyPosVisible : MonoBehaviour
    {

        [SerializeField]
        private GameObject targetObj;
        [SerializeField]
        private Transform thisObj;

        private GameObject Screen;
        private Vector2 targetPos;

        // Start is called before the first frame update
        void Start()
        {
            Screen = transform.GetChild(0).gameObject;
        }

        // Update is called once per frame
        void Update()
        {
            targetPos = OutDisplayPosition.CheckInScreen(targetObj, thisObj);
            if (targetPos == Vector2.zero)
            {
                Screen.SetActive(false);
            }
            else
            {
                transform.position = targetPos;
                Screen.SetActive(true);
            }
        }
    }
}
