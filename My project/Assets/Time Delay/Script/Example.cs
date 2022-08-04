using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    void Start()
    {
        SubRoutine();
        Debug.Log("MainRoutine");
    }

    public void SubRoutine()
    {
        for(int i = 0; i < 3; i++)
        {
            Debug.Log("SubRoutine [" + i + "]");
        }
    }

    public IEnumerator Delay()
    {
        Debug.Log("Coroutine [1]");
        yield return new WaitForSeconds(1);
        Debug.Log("Coroutine [2]");
        Debug.Log("Coroutine [3]");
    }
}
