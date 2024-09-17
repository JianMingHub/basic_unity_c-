using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    int [] scoreArray; 
    int [] scoreArray1 = new int[10];                            // khai báo và khởi tạo array
    int [] scoreArray2 = new int[10]{1,2,3,4,5,6,7,8,9,10};     // khai báo và khởi tạo array
    int [] scoreArray3 = {1,2,3,4,5,6};                         // khai báo và khởi tạo array
    [SerializeField]
    private GameObject [] items;                                // khai báo Array
    [SerializeField]
    private List <GameObject> newItems = new List <GameObject>();
    [SerializeField]
     private List<GameObject> objectList;                       // khai báo List
    [SerializeField]
    public List <bool> listItems;
    // Start is called before the first frame update
    void Start()
    {
        items = new GameObject[5];                  // Khởi tạo Array
         
        objectList = new List<GameObject>();        // Khởi tạo List

        scoreArray = new int[] {32,44,67}; 
        // Debug.Log(scoreArray[0]);
        // Debug.Log(scoreArray[1]);
        // Debug.Log(scoreArray[2]);

        // Debug.Log(scoreArray2[0]);
        // Debug.Log(scoreArray2[1]);
        // Debug.Log(scoreArray2[2]);
        // Debug.Log(scoreArray2[3]);
        // Debug.Log(scoreArray2[4]);
        // Debug.Log(scoreArray2[5]);
        // Debug.Log(scoreArray2[6]);
        // Debug.Log(scoreArray2[7]);
        // Debug.Log(scoreArray2[8]);
        // Debug.Log(scoreArray2[9]);

        for (int i = 0; i < 3; i ++)
        {
            Debug.Log(scoreArray[i]);
        }

        for (int z = 0; z < scoreArray2.Length; z ++)
        {
            Debug.Log(scoreArray2[z]);
        }

        int count = 0;
        while (count < scoreArray2.Length)
        {
            Debug.Log(scoreArray2[count]);
            count++;
        }

        int count_ = 0;
        do {
            Debug.Log(scoreArray2[count_]);
            count++;
        }
        while (count_ < scoreArray2.Length);
        
        // Sử dụng foreach với mảng scoreArray
        Debug.Log("Using foreach with scoreArray:");
        foreach (int score in scoreArray)
        {
            Debug.Log(score);
        }

        // Sử dụng foreach với mảng scoreArray2
        Debug.Log("Using foreach with scoreArray2:");
        foreach (int score in scoreArray2)
        {
            Debug.Log(score);
        }

        // Sử dụng foreach với danh sách objectList (GameObjects)
        Debug.Log("Using foreach with objectList:");
        foreach (GameObject obj in objectList)
        {
            Debug.Log(obj);
        }

        // Sử dụng foreach với danh sách bool listItems
        Debug.Log("Using foreach with listItems:");
        foreach (bool item in listItems)
        {
            Debug.Log(item);
        }
    }

    // Array: Thích hợp khi bạn biết trước số lượng phần tử và không cần thêm/xóa phần tử trong quá trình chạy chương trình. 
    // Hiệu suất tốt hơn nhưng ít linh hoạt hơn.
    // List: Linh hoạt, dễ thêm/xóa phần tử, phù hợp với các tình huống mà bạn không biết trước số lượng phần tử 
    // hoặc cần thao tác trên tập dữ liệu thay đổi

    
}
