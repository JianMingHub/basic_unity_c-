using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Tạo đối tượng Player với giá trị mặc định
        Player defaultPlayer = new Player();
        defaultPlayer.PlayerInfo();

        // Player knight = new Player("Knight", 111f);
        // knight.name = "Knight";
        // knight.health = 144.3f;  
        // knight.PlayerInfo();

        // Player knight = new Player();   // được lưu trong heap memory
        // knight.name = "Knight";         // được lưu trong stack memory, chúng chỉ chứa địa chỉ của đối tượng
        // knight.health = 64;             // được lưu trong stack memory, chúng chỉ chứa địa chỉ của đối tượng
        

        // Player archer = new Player();
        // archer.name = "archer";
        // archer.health = 69;

        // archer = knight;                //  cả hai biến tham chiếu đều trỏ đến cùng một đối tượng trong heap memory.

        // // wizard.PlayerInfo();
        // knight.PlayerInfo();
        // archer.PlayerInfo();

        // print("=====================");

        // // Cả knight và archer đều trỏ tới đối tượng có name = "We have changed the knight name" và health = 144.3f.
        // knight.name = "We have changed the knight name ";
        // knight.health = 144.3f;   

        // knight.PlayerInfo();
        // archer.PlayerInfo(); 
    }
}
