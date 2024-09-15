using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Player
{
    private float health = 100f;
    private string name = "Wizard";

    // Được gọi tự động khi một đối tượng của lớp đó được khởi tạo bằng từ khóa new.
    // Khởi tạo các giá trị ban đầu cho đối tượng.
    // Constructor có cùng tên với lớp và không có kiểu trả về (kể cả void).

    // This is contructor non parametter
    public Player()
    {
        
    }
    // This is contructor have parametter
    public Player(string name_, float health_)
    {
        this.name = name_;
        this.health = health_;
    }
    // Get - Set
    public float Health
    {
        get {
            return health;
        }
        set {
            health = value;
        }
    }
    public string Name
    {
        get {
            return name;
        }
        set {
            name = value;
        }
    }
    public void PlayerInfo()
    {
        Debug.Log("Player Name Is: " + name + " And Player Health Is: " + health);
    }
}
