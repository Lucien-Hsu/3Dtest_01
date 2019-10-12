using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{
    //[方法一]宣告一個吸引體，然後參考場景中的星球物件並呼叫其吸引函數。無法用在prefab。
    //public Attraction attractor;
    //設定一個變數，等一下用來取得此物體的位置
    private Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        //鎖定此物件的旋轉
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        //禁止此物件的重力
        GetComponent<Rigidbody>().useGravity = false;
        //取得此物體的位置
        myTransform = transform;

    }
     
    // Update is called once per frame
    void Update()
    {

    }
    
    private void LateUpdate()
    {
        //[方法一]吸引體吸引此物件
        //attractor.Attract(myTransform);

        //[方法二]將星球吸引的類設為靜態，直接呼叫其方法
        Attraction.Attract(myTransform);

        //[方法三]用Find找到星球，找尋吸引器的元件，調用其吸引函數，效能較差，物件多時不可行
        //GameObject.Find("Planet").GetComponent<Attraction>().Attract(myTransform);

    }

}
