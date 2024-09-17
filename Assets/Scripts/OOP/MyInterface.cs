using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInterface : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Devil zombie = new Zombie();
        zombie.Move();
        Debug.Log("hp: " + zombie.hp); // Accessing through the instance
        Debug.Log("Damage: " + zombie.damage); // Accessing through the instance
        Debug.Log("Move Speed: " + zombie.moveSpeed); // Accessing through the instance
    }
}

public abstract class Devil : IEOther
{
    public float hp = 200f;
    public float damage = 100f;
    public float moveSpeed = 500f;

    public abstract void Move();
    public abstract void Die();
}

public interface IEDevil
{
    public void GetHIt(int dmg);
}

public interface IEOther
{
    
}

public class Zombie : Devil, IEDevil, IEOther
{
    public override void Move()
    {
        Debug.Log("Move Zombie");
    }

    public override void Die()
    {
        Debug.Log("Die Zombie");
    }

    public void GetHIt(int dmg)
    {
        hp -= dmg; // Giảm HP của zombie khi bị hit
        Debug.Log("Zombie got hit! HP left: " + hp);
    }
}
