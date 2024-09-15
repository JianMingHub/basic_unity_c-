using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    [SerializeField]
    private GameObject [] items;
    [SerializeField]
    private List <GameObject> newItems = new List <GameObject>();
    [SerializeField]
     private List<GameObject> objectList;
    [SerializeField]
    public List <bool> listItems;
    // Start is called before the first frame update
    void Start()
    {
        items = new GameObject[5];                  // Khởi tạo Array
         
        objectList = new List<GameObject>();        // Khởi tạo List
    }

    // Array: Thích hợp khi bạn biết trước số lượng phần tử và không cần thêm/xóa phần tử trong quá trình chạy chương trình. 
    // Hiệu suất tốt hơn nhưng ít linh hoạt hơn.
    // List: Linh hoạt, dễ thêm/xóa phần tử, phù hợp với các tình huống mà bạn không biết trước số lượng phần tử 
    // hoặc cần thao tác trên tập dữ liệu thay đổi

    
}
