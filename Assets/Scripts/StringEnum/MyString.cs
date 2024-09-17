using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyString : MonoBehaviour
{
    string s1 = "abcfvb1cuo";
    string s2 = "abc123";
    string s3 = "";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Độ dài của chuỗi s1 là {s1.Length}");

        if (string.Compare(s1, s2) == 0)            // Compare so sánh 2 chuỗi dự theo theo thứ tự Unicode
        {
            Debug.Log("Chuỗi S1 bằng chuỗi s2");
        }
        else if (string.Compare(s1, s2) > 0)
        {
            Debug.Log("Chuỗi S1 lớn hơn chuỗi s2");
        }
        else
        {
            Debug.Log("Chuỗi S1 nhỏ hơn chuỗi s2");
        }

        Debug.Log(String.Concat(s1, s2));                                //  nối chuỗi
        Debug.Log(s1.IndexOf("b"));                                      // lấy vị trí đầu của ký tự trong chuỗi
        Debug.Log(s1.Insert(2, "x"));                                    // chèn 1 vào ký sau vị trí nào đó
        Debug.Log(String.IsNullOrEmpty(s3));                             // nếu null or empty thì trả về true
        Debug.Log(s1.LastIndexOf("l"));                                  // lấy vị trí cuối cùng của ký tự trong chuỗi, nếu ko có trả về -1
        Debug.Log(s1.Remove(1, 3));                                      // loại bỏ các ký tự (bắt đầu từ vị trí 1 và 3 ký tự tiếp theo, tính luôn vị trí 1)
        Debug.Log(s1.Replace("ab", "tec"));                              // sửa ký tự
        var s1SplitArray = s1.Split(new char[] {'b', 'c'});              // cắt chuỗi theo ký truyền vào, lưu lại vào mảng mới
        for (int i = 0; i < s1SplitArray.Length; i++)
        {
            Debug.Log(s1SplitArray[i]);
        }

        Debug.Log(s1.Substring(3));                                       // vị trí bắt đầu, và số lượng cắt, ra 1 chuỗi mới, nếu ko truyền vào số lượng thì sẽ lấy đến cuối chuỗi                       
    }
}
