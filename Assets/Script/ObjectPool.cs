using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//物件池
public class ObjectPool : MonoBehaviour
{
    //設定物件
    public GameObject prefab;
    //初始物件數量
    public int initailSize = 6;
    //設定佇列
    private Queue<GameObject> my_pool = new Queue<GameObject>();

    private void Awake()
    {
        for(int cnt = 0; cnt < initailSize; cnt++ )
        {
            GameObject realPrefab = Instantiate(prefab);
            my_pool.Enqueue(realPrefab);
            realPrefab.SetActive(false);
        }
    }

    //取用佇列中物件
    public void Reuse(Vector3 position, Quaternion rotation)
    {
        if (my_pool.Count > 0)
        {
            GameObject reuse = my_pool.Dequeue();
            reuse.transform.position = position;
            reuse.transform.rotation = rotation;
            reuse.SetActive(true);
        }
        else
        {
            //若佇列無物件則不生成
            //GameObject realPrefab = Instantiate(prefab);
            //realPrefab.transform.position = position;
            //realPrefab.transform.rotation = rotation;
        }
    }

    //回收佇列中物件
    public void Recovery(GameObject recovery)
    {
        my_pool.Enqueue(recovery);
        recovery.SetActive(false);
    }
 
}
