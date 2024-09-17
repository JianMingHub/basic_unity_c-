using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MyLinq : MonoBehaviour
{
    public List<int> listA;
    public List<int> listB;
    // Start is called before the first frame update
    void Start()
    {
        listA = new List<int>();
        listB = new List<int>();

        listA.Add(2);
        listA.Add(1);
        listA.Add(4);
        listA.Add(8);
        listA.Add(7);
        listA.Add(8);
        listA.Add(1);
        listA.Add(5);

        listB.Add(9);
        listB.Add(1);
        listB.Add(4);
        listB.Add(7);
        listB.Add(10);
        listB.Add(2);

        // var result = listA.Distinct().ToArray();
        // var result = listA.Except(listB);
        // var result = listA.Intersect(listB);
        // var result = listA.Union(listB);
        // var result = listA.Where(r => r > 2 && r < 6).ToArray();
        // var result = listA.Where(r => r <=5).Take(5).ToArray();
        var result = listA.Intersect(listB).Where(r => r == 7).ToArray();
        // var result = listA.Take(4);

        foreach (int item in result)
        {
            Debug.Log(item);
        }
    }
}
