using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class MyGeneric : MonoBehaviour
{
    int a, b;
    // Start is called before the first frame update
    void Start()
    {
        // Swap<int>(ref a, ref b);
        GenericDemo<int> genericDemo = new GenericDemo<int>();
    }
    public void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    public void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    public class GenericDemo<T>
    {
        public T propertyDemo;
        public GenericDemo()
        {
            Debug.Log(propertyDemo.GetType());
        }
    }
}
