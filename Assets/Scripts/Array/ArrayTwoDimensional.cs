using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTwoDimensional : MonoBehaviour
{
    float [,] secondArray = new float[2,5];             // khai báo và khởi tạo 2 dòng, 5 cột (có thể khai báo 1 chỗ, và khởi tạo 1 chỗ)
    float [,] thirdArray = new float[,]                 // khai báo và khởi tạo 3 dòng, 2 cột (có thể khai báo 1 chỗ, và khởi tạo 1 chỗ)
    {
        {1.2f, 1.3f},
        {2.1f, 2.2f},
        {3.5f, 7.6f}
    };

    float [,] fourthArray =                            // Phải khởi tạo ngay lúc khai báo (vừa khai báo vừa khởi tạo)
    {
        {1.2f, 1.3f},
        {2.1f, 2.2f},
        {3.5f, 7.6f}
    };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("secondArray:");
        PrintArray(secondArray);

        Debug.Log("thirdArray:");
        PrintArray(thirdArray);

        Debug.Log("fourthArray:");
        PrintArray(fourthArray);
    }
    // Phương thức để in mảng hai chiều
    void PrintArray(float[,] array)
    {
        // int rows = array.GetLength(0);  // Lấy số dòng
        // int cols = array.GetLength(1);  // Lấy số cột

        // for (int i = 0; i < rows; i++)
        // {
        //     string rowValues = "";  // Khởi tạo chuỗi để lưu giá trị của dòng
        //     for (int j = 0; j < cols; j++)
        //     {
        //         rowValues += array[i, j] + " ";  // Thêm giá trị của từng cột vào chuỗi
        //     }
        //     Debug.Log(rowValues);  // In chuỗi của dòng
        // }

        // Sử dụng foreach để in từng phần tử
        foreach (float value in array)
        {
            Debug.Log(value + " ");
        }
    }
}
