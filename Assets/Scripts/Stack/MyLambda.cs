using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLambda : MonoBehaviour
{
    public delegate void myDelegate();
    public delegate void myDelegate2(float a);

    // Start is called before the first frame update
    void Start()
    {
        myDelegate2 dele = (float x) =>
        {
            Debug.Log(x);
        };
        dele(10);

        myDelegate2 dele1 = (float x) => Hello(x);
        dele1(9);

        myDelegate dele2 = () => Hello2();
        dele2();
    }
    void Hello(float a)
    {
        Debug.Log(a);
    }
    void Hello2()
    {
        Debug.Log("phương thúc ko có tham số");
    }
}
