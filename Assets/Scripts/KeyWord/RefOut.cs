using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefOut : MonoBehaviour
{
    int myNumberRef = 5;
    int myNumberOut;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Before: " + myNumberRef);   // Output: 5

        Increase(ref myNumberRef);
        
        Debug.Log("After: " + myNumberRef);  // Output: 15

        SetNumber(out myNumberOut);

        Debug.Log("Value of myNumberOut: " + myNumberOut);  // Output: 10
    }
    static void Increase(ref int numberRef)
    {
        numberRef += 10;
    }
    static void SetNumber(out int numberOut)
    {
        numberOut = 10;  // Phải gán giá trị cho biến
    }
}
