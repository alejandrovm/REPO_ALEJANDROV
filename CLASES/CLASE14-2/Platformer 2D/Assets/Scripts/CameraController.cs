﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
            target = Player.instance.transform;
    }

    // LateUpdate is called after Update (the player runs in update)
    void LateUpdate()
    {
        Vector3 pos = target.position;
        pos.z = -10;
        transform.position = pos;
    }
}
