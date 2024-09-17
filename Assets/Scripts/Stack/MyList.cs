using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyList : MonoBehaviour
{
    List<float> scoreArr;
    List<float> scoreArr2;
    // Start is called before the first frame update
    void Start()
    {
        scoreArr = new List<float>(scoreArr2);
        scoreArr.AddRange(scoreArr2);
        scoreArr.Add(1f);
        scoreArr.Remove(1);
        scoreArr.RemoveAt(1);
    }
}
