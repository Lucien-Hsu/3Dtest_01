using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : MonoBehaviour
{
    
    public float Speed = 0.001f;
    private float timer = 0f;
    private float randomX = 0f;
    private float randomZ = 0f;

    public Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //設定計時器
        timer += Time.deltaTime;

        //每一秒重設一次隨機數
        if (timer > 1)
        {
            randomX = Random.Range(-0.5f, 0.5f);
            randomZ = Random.Range(0f, 0.5f);
            timer = 0;
        }

        //大於0.5秒向本地X軸移動
        if (timer > 0.5)
        {
            //將本地座標設為自己的世界座標
            Vector3 dirX = transform.TransformDirection(randomX * Speed * Time.deltaTime, 0, 0);
            //移動到指定位置，這裡是自己位置加上移動向量
            rb.MovePosition(rb.position + dirX);
        }

        //小於等於0.5秒向本地Z軸移動
        if (timer <= 0.5)
        {
            //將本地座標設為自己的世界座標
            Vector3 dirZ = transform.TransformDirection(0, 0, randomZ * Speed * Time.deltaTime);
            //移動到指定位置，這裡是自己位置加上移動向量
            rb.MovePosition(rb.position + dirZ);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
