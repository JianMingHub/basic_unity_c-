using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDictionary : MonoBehaviour
{
    Dictionary<string, int> dicDemo;
    Dictionary<string, int> dicDemo2;
    int dicDemoValue;

    // Start is called before the first frame update
    void Start()
    {
        dicDemo = new Dictionary<string, int>();
        dicDemo.Add("Udev", 1);
        dicDemo.Add("Student", 5);
        dicDemo.Add("Teacher", 3);

        Debug.Log(dicDemo.TryGetValue("Udev", out dicDemoValue));

        // var keys = dicDemo.Keys;
        // var value = dicDemo.Values;
    }
}
