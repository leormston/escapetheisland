using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hungerReduce : MonoBehaviour
{   
    //hunger
    public int hunger = 100;
    public int counter;

    //the hunger text
    public Text hungerText;

    public void hungerIncrease() {
        hunger += 5;
        hungerText.text = "Hunger: " + hunger.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //counter reduce hunger every 3 second
        counter++;
        if (counter == 3000) {
            hunger--;
            hungerText.text = "Hunger: " + hunger.ToString();
            counter = 0;
        }
    }
}
