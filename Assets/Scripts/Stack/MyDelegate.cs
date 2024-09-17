using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDelegate : MonoBehaviour
{
    delegate float myDelegate_(float a, float b);

    // Start is called before the first frame update
    void Start()
    {
        myDelegate_ tinhTongDele = new myDelegate_(TinhTong);
        myDelegate_ tinhHieuDele = new myDelegate_(TinhHieu);
        myDelegate_ multiCastDele =  tinhTongDele + tinhHieuDele;

        multiCastDele(4, 7);

        Main(tinhTongDele);
       
    }
    void Main(myDelegate_ tinhTongDele)
    {
        int a = 5;
        int b = 8;
        tinhTongDele(a, b);
    }
    float TinhTong(float x, float y)
    {
        Debug.Log(x + y);
        return x + y;
    }
    float TinhHieu(float x, float y)
    {
        Debug.Log(x - y);
        return x - y;
    }
}
