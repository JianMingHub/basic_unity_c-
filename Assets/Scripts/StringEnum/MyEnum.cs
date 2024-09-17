using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnum : MonoBehaviour
{
    // là danh sách các hằng số định nghĩa trạng thái của nhân vật: Starting, Playing, Win, GameOver...theo kiểu int

    enum GameState{
        Starting,
        Playing = 1,
        Win,
        GameOver
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GameState.Win);
        Debug.Log((int)GameState.GameOver);
        Debug.Log((GameState)1);                // ép kiểu
    }
}
