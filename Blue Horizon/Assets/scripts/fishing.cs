using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class fishing : MonoBehaviour
{
    public GameObject fishingspot;
    
     private GameObject GM;
    GameObject Player_UI;
    private GameObject dasas;
    private GameObject aaaaa;
    public GameObject ESystem;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
       GM=GameObject.Find("GameManager");
      aaaaa= GameObject.Find("Cube");
        // Debug.Log(aaaaa.GetComponent<xdsfjkuhysdf>().aa);
        ESystem = GameObject.Find("EventSystem");
        player=GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           
         

            player.GetComponent<boatMovement>().enabled = false;
      
            

            if (ESystem.GetComponent<tutorialScript>().hasBeenDone1)
            {
                ESystem.GetComponent<tutorialScript>().firstFishingSpot = true;
            }
            GameObject.Find("game manager").GetComponent<spawnFS>().EnableFishingUI();
            Vector2 temp;
            temp.x = Random.Range(10, 100);
            temp.y = Random.Range(10, 100);
            GameObject newfishingspot=Instantiate(fishingspot, new Vector3(temp.x, 0, temp.y), Quaternion.identity);
            newfishingspot.transform.localScale=new Vector3(5,100,5);
            //Debug.Log("the fishing has ended");
            Debug.Log("new coords "+temp);
           
            Destroy(gameObject);

        }
        
    }
}
