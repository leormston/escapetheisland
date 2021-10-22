using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionBoard : MonoBehaviour
{
    public Text missionContent; 
        
    // Start is called before the first frame update
    void Start()
    {
        //get resource
        /*GameObject resource = GameObject.Find("player");
        ResourceCounter resourceScript = resource.GetComponent<ResourceCounter>();
        //get mission item list
        GameObject craft = GameObject.Find("GameManager");
        Crafting craftingScript = craft.GetComponent<Crafting>();

        missionContent.text = "Repair " + craftingScript.missionList[craftingScript.current].itemName;

        Debug.Log("the number is " + craftingScript.missionList.Count);*/
    }

    void Update() {
        //get resource
        GameObject resource = GameObject.Find("player");
        ResourceCounter resourceScript = resource.GetComponent<ResourceCounter>();
        //get mission item list
        GameObject craft = GameObject.Find("GameManager");
        Crafting craftingScript = craft.GetComponent<Crafting>();

        missionContent.text = "Repair " + craftingScript.missionList[craftingScript.current].itemName;

    }

    
}
