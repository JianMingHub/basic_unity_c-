using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyArrayList : MonoBehaviour
{
    private ArrayList arrListDemo;
    private ArrayList arrListDemo2;

    // Start is called before the first frame update
    void Start()
    {
        arrListDemo = new ArrayList();
        arrListDemo.Add(10);
        arrListDemo.Add(12.5f);
        arrListDemo.Add("Udev");

        arrListDemo2 = new ArrayList();
        arrListDemo2.Add(2);
        arrListDemo2.Add(9.1f);
        arrListDemo2.Add("aa");

        // Debug.Log(arrListDemo.Count);
        // Debug.Log(arrListDemo.Capacity);

        arrListDemo.AddRange(arrListDemo2);
        // arrListDemo.Clear();

        // Debug.Log(arrListDemo.Contains(9.1f));
        // Debug.Log(arrListDemo.IndexOf("Udev"));

        arrListDemo.Insert(3, "100");
        arrListDemo.Remove("Udev");
        arrListDemo.Reverse();
        
        var arr = arrListDemo.ToArray();
        var arrClone = (ArrayList)arrListDemo.Clone();

        var arrCopy = arrListDemo.GetRange(2, 3);
        // Debug.Log(arrCopy.Count);

        foreach (var temp in arrListDemo)
        {
            Debug.Log(temp);
        }
    }
}
