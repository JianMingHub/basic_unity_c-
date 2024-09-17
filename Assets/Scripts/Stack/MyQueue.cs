using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyQueue : MonoBehaviour
{
    Queue queueDemo;
    Queue queueDemo2;
    ArrayList arrayListDemo;
    // Start is called before the first frame update
    void Start()
    {
        queueDemo = new Queue();
        queueDemo.Enqueue(12);
        queueDemo.Enqueue(2.9f);
        queueDemo.Enqueue("udev");

        Debug.Log(queueDemo.Dequeue());

        foreach (var temp in queueDemo)
        {
            Debug.Log(temp);
        }
    }
}
