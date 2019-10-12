using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attraction : MonoBehaviour
{
    public static float gravity = -360;

    public static void Attract(Transform body)
    {
        //被吸引物的位置-吸引體的位置，得到一個向量，再將其正規化，結果就是得到被吸引體與吸引體的單位法線向量
        Vector3 gravityUp = body.position.normalized;
        //被吸引物件的y軸
        Vector3 bodyUp = body.up;

        //對被吸引物(需為鋼體)施加一個力，此力為被吸引物與吸引物的法線向量*重力值
        body.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

        //將被吸引物件的y軸轉向到引力體的法線，即將"需旋轉的角度"乘上"被吸引物的角度"
        Quaternion targetRotation = Quaternion.FromToRotation(bodyUp, gravityUp) * body.rotation;
        //不懂，應該是利用四元數做旋轉
        body.rotation = Quaternion.Slerp(body.rotation, targetRotation, 50 * Time.deltaTime);

    }

}
