using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceCounter : MonoBehaviour
{
    // Start is called before the first frame update

    public int wood;
    public int stone;
    public int scrap;
    public int stoneAxe;

    public GameObject inventory;

    public Image background;
    public Text woodNumber;
    public Text stoneNumber;
    public Text scrapNumber;
    public Button equipAxe;
    public Text stoneAxeExist;
    public Button close;

    //stoneAxe is 0
    private int[] weaponReference = {0};

    void Start()
    {
        //set inventory page off first
        inventory.SetActive(false);

        close.onClick.AddListener(closeInventory);
    }

    //open the inventory
    public void openInventory() {
        inventory.SetActive(true);
        display();
    }

    //clsoe inventory menu
    public void closeInventory()
    {
        inventory.SetActive(false);
        GameObject PlayerController = GameObject.Find("player");
        playerController playerScript = PlayerController.GetComponent<playerController>();
        playerScript.uiOn = false;
        Debug.Log("close menu");
    }

    private void display()
    {
        //inventory display
        woodNumber.text = "Wood: " + wood;
        stoneNumber.text = "Stone: " + stone;
        scrapNumber.text = "Scrap: " + scrap;
        if (stoneAxe >= 1)
        {
            stoneAxeExist.text = "Stone Axe";
            equipAxe.gameObject.SetActive(true);
        }
        else {
            equipAxe.gameObject.SetActive(false);
            stoneAxeExist.text = " ";
        }
    }

}
