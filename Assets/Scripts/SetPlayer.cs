using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayer : MonoBehaviour
{
    void Start()
    {
        // use contructor non parametter
        Player defaultPlayer = new Player();
        defaultPlayer.PlayerInfo();

        // use contructor have parametter
        Player con = new Player("Contruct", 1234);
        con.PlayerInfo();

        // use get set 
        Player knight = new Player();
        
        knight.Health = 70f;
        knight.Name = "Wazil";

        knight.PlayerInfo();
        
    }
}
