﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Manager : MonoBehaviour
{
    public Transform startPos;

    // Start is called before the first frame update
    void Start()
    {
        // ver 1 :  Player.instance.transform.position = startPos.Position;
        // ver 2 :  Player.setPosition = startPos.position;
        Player.setPosition2 = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
