using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchCount : MonoBehaviour
{
    public ObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //如果按下滑鼠並且點擊到物件則執行
        if (Input.GetMouseButton(0) && Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.name == "chick_02(Clone)")    //如果碰撞的点所在的物体的名字是“StartButton”(collider就是检测碰撞所需的碰撞器)
            {
                Debug.Log("抓到小雞~~~~~~");
                pool.Recovery(hit.collider.gameObject);
                UIController.Instance.AddScore();
            }
            
        }
    }
}
