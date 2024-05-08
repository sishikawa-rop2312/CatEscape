using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // 左矢印押下
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LButtonDown();
        }

        // 右矢印押下 
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RButtonDown();
        }

        // GameOverでこのスクリプト自体を無効にする
        if (Time.timeScale <= 0)
        {
            this.enabled = false;
        }
    }

    // 左ボタン押下
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    // 右ボタン押下
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}
