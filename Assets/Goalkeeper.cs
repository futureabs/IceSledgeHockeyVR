using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalkeeper : MonoBehaviour
{
    float xmove = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // transformを取得
        Transform myTransform = this.transform;

        // 座標を取得
        Vector3 pos = myTransform.position;
        if (pos.x < -1.8f){
            xmove = 0.05f;
        }
        else if (pos.x > 1.2f){
            xmove = -0.05f;
        }

        pos.x += xmove;
        myTransform.position = pos;  // 座標を設定
    }
}
