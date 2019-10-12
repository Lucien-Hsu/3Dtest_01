using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text ScoreText;
    public int MonCnt;
    //因為此物件沒有實體，所以建立實體
    public static UIController Instance;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        MonCnt += 1;
        ScoreText.text = "捕捉數量：" + MonCnt;

    }


}
