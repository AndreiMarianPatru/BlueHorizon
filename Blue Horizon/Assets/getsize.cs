using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getsize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 size = GetComponent<Renderer>().bounds.size;
        Debug.Log("size"+size);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
