using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOverLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Robot robot = new Robot();
        robot.Move();
        robot.Move(1.1f);
    }
}

public class Robot
{
    public float hp = 200f;
    public float damage = 100f;
    public float moveSpeed;

    public void Move()
    {
        Debug.Log("Move Parent");
    }

    public void Move(float moveSpeed)
    {
        Debug.Log("Move Child");
    }
}

