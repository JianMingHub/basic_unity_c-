using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySortedList : MonoBehaviour
{
    private ArrayList studentArr;
    private SortedList studentList;
    // Start is called before the first frame update
    void Start()
    {
        studentList = new SortedList(new StudentSort());
        studentList.Add(new Student("H", 45, 2), 3);
        studentList.Add(new Student("F", 12, 0), "f");
        foreach(DictionaryEntry temp in studentList)
        {
            Student student = (Student)temp.Key;

            Debug.Log($"Key {student.age} Value {temp.Value}");
        }
    }
}
public class Student
{
    public string name;
    public int age;
    public int classRoom;

    public Student()
    {

    }
    public Student(string name, int age, int classRoom)
    {
        this.name = name;
        this.age = age;
        this.classRoom = classRoom;
    }
}
public class StudentSort : IComparer
{
    public int Compare(object x, object y)
    {
        Student s1 = x as Student;
        Student s2 = y as Student;

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
