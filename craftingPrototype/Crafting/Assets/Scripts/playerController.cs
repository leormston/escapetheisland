using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public Vector2 moveValue;
    public float speed;
    //public Rigidbody playerBody;

    //for turning
    public float sensitivity = 30f;

    public Vector2 rotation;

    //ui is on
    public bool uiOn = false;

    void OnMove(InputValue value)
    {
        moveValue = value.Get<Vector2>();

    }

    

    private void FixedUpdate()
    {
        if (uiOn == false)
        {
            Vector3 movement = new Vector3(moveValue.x, 0.0f, moveValue.y);

            movement = transform.TransformDirection(movement);


            GetComponent<Rigidbody>().MovePosition(transform.position + movement * speed * Time.deltaTime);

        }
    }


    private void Update()
    {
        //rotation.y += Mouse.current.delta.y.ReadValue();
        if (uiOn == false) {
            Debug.Log("moving");
            rotation.x += Mouse.current.delta.x.ReadValue();
            transform.rotation = Quaternion.Euler(0, rotation.x, 0);
            GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(0, rotation.x, 0));
        }

        //if i is pressed then open inventory, lock all movement
        if (Keyboard.current.iKey.wasPressedThisFrame)
        {
            Debug.Log(uiOn);
            uiOn = true;
            //reference the inventory ui
            GameObject resource = GameObject.Find("player");
            ResourceCounter resourceScript = resource.GetComponent<ResourceCounter>();

            resourceScript.openInventory();
        }
        else if (Keyboard.current.jKey.wasPressedThisFrame) {
            uiOn = true;
            //reference the crafting menu
            GameObject craft = GameObject.Find("GameManager");
            Crafting craftingScript = craft.GetComponent<Crafting>();

            craftingScript.openCrafting();
        }
        
        
    }

    

}
