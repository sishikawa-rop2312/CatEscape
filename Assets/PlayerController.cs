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
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -9.5f)
        {
            transform.Translate(-3 * Time.deltaTime * 3, 0, 0);
        }

        // 右矢印押下 
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 9.5f)
        {
            transform.Translate(3 * Time.deltaTime * 3, 0, 0);
        }
    }
}
