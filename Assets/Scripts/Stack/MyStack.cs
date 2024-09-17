using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStack : MonoBehaviour
{
    Stack stackDemo;
    Stack stackDemo2;
    ArrayList arrayListDemo;

    // Start is called before the first frame update
    void Start()
    {
        stackDemo =  new Stack();
        stackDemo.Push("udev");
        stackDemo.Push(1);
        stackDemo.Push(1.4f);

        Debug.Log(stackDemo.Pop());
        // foreach (var temp in stackDemo)
        // {
        //     Debug.Log(temp);
        // }
    }
}
public class Employee
{
    public string name;
    public int age;
    public int classRoom;

    public Employee()
    {

    }
    public Employee(string name, int age, int classRoom)
    {
        this.name = name;
        this.age = age;
        this.classRoom = classRoom;
    }
}
public class StaffSort : IComparer
{
    public int Compare(object x, object y)
    {
        Employee s1 = x as Employee;
        Employee s2 = y as Employee;

        if (s1.age < s2.age)
            return -1;
        else if (s1.age > s2.age)
            return 1;
        else 
            return 0;

        // if (string.Compare(s1.name, s2.name) < 0)
        //     return -1;
        // else if(string.Compare(s1.name, s2.name) > 0) 
        //     return 1;
        // else 
        //     return 0;
    }
}
