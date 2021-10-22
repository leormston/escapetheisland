using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.UI;

public class checkInSight : MonoBehaviour
{
    RaycastHit hit;

    //public Text hungerText;


    /*private void Start()
    {
        GameObject hungerDisplay = GameObject.Find("HungerDisplay");
        hungerReduce hungerScript = hungerDisplay.GetComponent<hungerReduce>();
    }*/

    private void Update()
    {
        //call hunger
        GameObject hungerDisplay = GameObject.Find("HungerDisplay");
        hungerReduce hungerScript = hungerDisplay.GetComponent<hungerReduce>();

        //get player controller for the uion flag
        GameObject PlayerController = GameObject.Find("player");
        playerController playerScript = PlayerController.GetComponent<playerController>();

        //call resource
        ResourceCounter resourceScript = PlayerController.GetComponent<ResourceCounter>();

        //a foward vector 
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (playerScript.uiOn == false) {
            if (Physics.Raycast(transform.position, fwd, out hit))
            {
                if (Keyboard.current.eKey.wasPressedThisFrame) {
                    if (hit.collider.name == "berries")
                    {
                        Destroy(hit.transform.gameObject);

                        //hunger increase
                        hungerScript.hungerIncrease();
                    }
                    else if (hit.collider.name == "wood") {
                        Destroy(hit.transform.gameObject);

                        resourceScript.wood += 1;
                    }
                    else if (hit.collider.name == "stone")
                    {
                        Destroy(hit.transform.gameObject);

                        resourceScript.stone += 1;
                    }
                    else if (hit.collider.name == "scrap")
                    {
                        Destroy(hit.transform.gameObject);

                        resourceScript.scrap += 1;
                    }

                }
                
            }
        }
        
        
    }
}
