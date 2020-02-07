using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionArea : MonoBehaviour
{
    public float radius = 1f;
<<<<<<< HEAD
    // Start is called before the first frame update
    void Start()
    {
        
=======

    // Start is called before the first frame update
    void Start()
    {

>>>>>>> abd7d471fcac72014a5e09fc6a54647babffadb7
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
    }
}
=======

    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
>>>>>>> abd7d471fcac72014a5e09fc6a54647babffadb7
