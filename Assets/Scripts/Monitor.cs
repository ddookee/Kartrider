using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //컴퓨터 칩셋이 나빠서 화면비가 제대로 나오지 않을때 사용
    private void setResolution()
    {
        float targetRatio = 9f / 16f;//fhd
        float ratio = (float)Screen.width/(float)Screen.height;
        float scaleHeight = ratio / targetRatio;
        float fixedWidth = (float)Screen.width / scaleHeight;

        Screen.SetResolution((int)fixedWidth, Screen.height, true);
    }
}
