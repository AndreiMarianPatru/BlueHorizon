using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static Vector3 position;
    public static Vector3 rotation;
  
   
    
    public static string biome;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        position = gameObject.transform.position;
        rotation = gameObject.transform.rotation.eulerAngles;
    }
    public void setPositionandRotation()
    {
        gameObject.transform.position = position;
        gameObject.transform.rotation.eulerAngles.Set(rotation.x, rotation.y, rotation.z);
    }

  
}
