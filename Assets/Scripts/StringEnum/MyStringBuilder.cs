using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class MyStringBuilder : MonoBehaviour
{
    string s1 = "abcfvb1cuo";
    string s2 = "abc123";
    string s3 = "";
    StringBuilder s4;
    // Start is called before the first frame update
    void Start()
    {
        s4 = new StringBuilder("abcdef");       // gán chuỗi
        // Debug.Log(s4.Length);                // xem độ dài
        // Debug.Log(s4.Append("xyzt"));        // nối chuỗi
        var s4Copy = s4.ToString();             // chuyển sang kiểu String
        // Debug.Log(s4.Clear());               // xóa chuỗi
        Debug.Log(s4Copy);
    }
}
