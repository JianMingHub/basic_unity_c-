using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // PrintSomething();
        StartCoroutine (PrintAffterDelay(3f));
    }
    IEnumerator PrintAffterDelay(float time)
    {
        yield return new WaitForSeconds(time);
        print  ("Printed after 3 second");
    }
}
