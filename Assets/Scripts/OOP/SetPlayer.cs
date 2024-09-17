using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayer : MonoBehaviour
{
    void Start()
    {
        // use Constructor non parameter
        Player defaultPlayer = new Player();
        defaultPlayer.PlayerInfo();

        // use Constructor have parameter
        Player con = new Player("Constructor", 1234);
        con.PlayerInfo();

        // use get set 
        Player knight = new Player();
        
        knight.Health = 70f;
        knight.Name = "Wazil";

        knight.PlayerInfo();
        
    }
}
