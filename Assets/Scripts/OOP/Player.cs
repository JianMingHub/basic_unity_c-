using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Player
{
    // public: Truy cập được từ bất kỳ đâu (lớp khác, đối tượng khác).
    // private: Chỉ truy cập được từ trong cùng lớp.
    // protected: Truy cập được từ lớp khai báo và các lớp kế thừa.

    private float health = 100f;
    private string name = "Wizard";

    void Start()
    {
        // Enemy.lifeTime = 5.4f;
        // Debug.Log("Life Time: " + Enemy.lifeTime);
    }

    // **** Constructor *** //
    // Được gọi tự động khi một đối tượng của lớp đó được khởi tạo bằng từ khóa new.
    // Khởi tạo các giá trị ban đầu cho đối tượng.
    // Constructor có cùng tên với lớp và không có kiểu trả về (kể cả void).

    // This is Constructor  non parameter
    public Player()
    {
       
    }
    // This is Constructor  have parameter
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

public class Monster
{
    public static float lifeTime;
    public float hp = 10f;
    public float damage = 100f;
    public float moveSpeed = 300f;

    public Monster()
    {
        Debug.Log("cha");
    }
    public Monster(float dmg)
    {
        Debug.Log("cha");
    }
    public void Move()
    {
    
    }
}

public class Tiger: Monster
{
    // không hỗ trợ đa kế thừa (1 lớp kế thừa từ nhiều lớp) nhưng lại hỗ trợ thực thi nhiều interface
    // thành phần có phạm vi là private thì ko được kế thừa
    // thành phần có phạm vi là protected, public thì được kế thừa
    // phương thức khởi tạo và phương thức hủy bỏ thì ko được kế thừa

    public Tiger()
    {
        Debug.Log("con");
    }
    public Tiger(float dmg_copy) : base(dmg_copy)
    {

    }
}


// 1. Đóng gói (Encapsulation): Ẩn chi tiết và chỉ cung cấp các phương thức công khai để tương tác.
// 2. Kế thừa (Inheritance): Tái sử dụng các thuộc tính và phương thức từ lớp cha.
// 3. Đa hình (Polymorphism): Xử lý các đối tượng từ các lớp khác nhau thông qua cùng một giao diện.
// 4. Trừu tượng (Abstraction): Ẩn đi các chi tiết không cần thiết, tập trung vào phần quan trọng.