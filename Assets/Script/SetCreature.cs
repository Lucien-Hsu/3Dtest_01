using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCreature : MonoBehaviour
{
    //public GameObject Chick; //宣告物件
    public float time; //宣告浮點數，名稱time
    public ObjectPool pool;

    bool initialTimer = true;//計時器，用來做初始生物產生

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; //時間增加

        //第一秒先產生一隻生物
        if(time > 1f && initialTimer == true)
        {
            Vector3 pos = new Vector3(Random.Range(1.5f, -1.5f), Random.Range(1.5f, -1.5f), Random.Range(1.5f, -1.5f)); //宣告位置pos，Random.Range(-2.5f,2.5f)代表X是2.5到-2.5之間隨機
            //Vector3 pos = new Vector3(20,20,20); //宣告位置pos，Random.Range(-2.5f,2.5f)代表X是2.5到-2.5之間隨機
            //產生生物
            Debug.Log("產生生物");
            pool.Reuse(pos, Quaternion.Euler(0f, 0f, 0f));
            //Debug.Log("產生生物2");
            //Instantiate(Chick, pos, transform.rotation);
            time = 0f; //時間歸零
            initialTimer = false;
        }


        //後續每三秒產生一隻生物
        if (time > 3f) //如果時間大於3(秒)
        {
            Vector3 pos = new Vector3(Random.Range(1.5f, -1.5f), Random.Range(1.5f, -1.5f), Random.Range(1.5f, -1.5f)); //宣告位置pos，Random.Range(-2.5f,2.5f)代表X是2.5到-2.5之間隨機
            //Vector3 pos = new Vector3(20,20,20); //宣告位置pos，Random.Range(-2.5f,2.5f)代表X是2.5到-2.5之間隨機
            //產生生物
            Debug.Log("產生生物");
            pool.Reuse(pos, Quaternion.Euler(0f, 0f, 0f));
            //Debug.Log("產生生物2");
            //Instantiate(Chick, pos, transform.rotation);
            time = 0f; //時間歸零
        }

    }
}
