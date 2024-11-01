using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i <= 10; i++) {
            int m = Multiply(5, i);
            Debug.Log("5 x " + i + " = " + m);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Multiply(int a, int b)
    {
        int result = a*b;
        return result;
    }
}
