using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHashTable : MonoBehaviour
{
    private Hashtable hashtableDemo;
    private Hashtable hashtableDemo2;
    // Start is called before the first frame update
    void Start()
    {
        hashtableDemo = new Hashtable();
        hashtableDemo.Add("udev", 10);
        hashtableDemo.Add("siro", "my name siro");
        hashtableDemo.Add("tung", 12f);

        // Debug.Log(hashtableDemo["tung"]);
        // Debug.Log(hashtableDemo["siro"]);

        // var keys = hashtableDemo.Keys;
        // var values = hashtableDemo.Values;

        // foreach (var value in values)
        // {
        //     Debug.Log(value);
        // }

        foreach (var temp in hashtableDemo)
        {
            Debug.Log(temp.GetType());
        }
    }
}
