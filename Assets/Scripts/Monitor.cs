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
    //��ǻ�� Ĩ���� ������ ȭ��� ����� ������ ������ ���
    private void setResolution()
    {
        float targetRatio = 9f / 16f;//fhd
        float ratio = (float)Screen.width/(float)Screen.height;
        float scaleHeight = ratio / targetRatio;
        float fixedWidth = (float)Screen.width / scaleHeight;

        Screen.SetResolution((int)fixedWidth, Screen.height, true);
    }
}