﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insideContainer : MonoBehaviour
{
    public bool isCollideWithPlayer = false;
    public Transform myFood;
    public GameObject myPlayer;
    public joyButton m_getInfo; // need to check how

    
    public Transform getFoodObject()
    {
        return myFood;
    }


    // Update is called once per frame
    void Update()
    {
        if (isCollideWithPlayer && m_getInfo.ReturnIfPressed()) // if theres a collision and the pickup button is pressed
        {
            //need to add the joystick if condition and see if ok.
            myFood.transform.SetParent(myPlayer.transform);
            Vector3 playerLoc = myPlayer.transform.localPosition;

            myFood.localPosition = new Vector3(playerLoc.x + 10, playerLoc.y + 45, playerLoc.z + 30);
            Debug.Log("in update and parent");

          //  if(myFood.tag == "Food")
          //      Debug.Log("it's food!");
        }
        else
        {
            //maybe need maybe not
            // forDebug = true;
        }
    }

    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isCollideWithPlayer = true;
        }
    }
    void OnCollisionExit(Collision other)
    {
        Debug.Log("on collision exit");
        if (other.gameObject.CompareTag("Player"))
        {
            isCollideWithPlayer = false;
        }
    }


}
