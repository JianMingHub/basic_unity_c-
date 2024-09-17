using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plymorphism : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal boss = new Dog();
        boss.Move();
        Debug.Log("hp: " + boss.hp); // Accessing through the instance
        Debug.Log("Damage: " + boss.damage); // Accessing through the instance
        Debug.Log("Move Speed: " + boss.moveSpeed); // Accessing through the instance
    }
}

public class Enemy
{
    public float hp = 200f;
    public float damage = 100f;
    public float moveSpeed = 500f;

    public virtual void Move()
    {
        Debug.Log("Move Enemy");
    }
}

public class Boss : Enemy
{
    public override void Move()
    {
        Debug.Log("Move Boss");
    }
}

public abstract class Animal
{
    public float hp = 200f;
    public float damage = 100f;
    public float moveSpeed = 500f;

    public abstract void Move();
    public abstract void Die();
}

public class Dog : Animal
{
    public override void Move()
    {
        Debug.Log("Move Dog");
    }

    public override void Die()
    {
        Debug.Log("Die Dog");
    }
}
