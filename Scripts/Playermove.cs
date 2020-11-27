using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Playermove: MonoBehaviour
{
    Vector3[] maptails = {new Vector3(-1, 0, 1), new Vector3(0, 0, 1), new Vector3(1, 0, 1), 
                          new Vector3(-1, 0, 0), new Vector3(0, 0, 0), new Vector3(1, 0, 0),
                          new Vector3(-1, 0, -1), new Vector3(0, 0, -1),new Vector3(1, 0, -1)};
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int playerpos = Array.IndexOf(maptails, transform.position);

        if (Input.GetKeyDown(KeyCode.W) && playerpos >= 0)
        {
            transform.position = maptails[playerpos - 3];
            playerpos -= 3;
            Debug.Log(playerpos);
        }
        if (Input.GetKeyDown(KeyCode.S) && playerpos < 10)
        {
            transform.position = maptails[playerpos + 3];
            playerpos += 3;
            Debug.Log(playerpos);
        }

        if (Input.GetKeyDown(KeyCode.D) && playerpos + 1 != 3 && Input.GetKeyDown(KeyCode.D) && playerpos + 1 != 6)
        {
            transform.position = maptails[playerpos + 1];
            playerpos += 1;
            Debug.Log(playerpos);
        }
        if (Input.GetKeyDown(KeyCode.A) && playerpos - 1 != 2 && Input.GetKeyDown(KeyCode.A) && playerpos - 1 != 5)
        {
            transform.position = maptails[playerpos - 1];
            playerpos -= 1;
            Debug.Log(playerpos);
        }
    }
}
