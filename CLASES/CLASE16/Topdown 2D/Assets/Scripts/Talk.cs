using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Topdown.Dialog {
    public class Talk : MonoBehaviour
    {
        private GameObject NPC = null;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (NPC != null)
                DialogController.Show(0);
            }   

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (NPC != null)
                DialogController.Next();
            }  
        }

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "NPC")
            NPC = collision.gameObject;
        }

        void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.tag == "NPC")
            NPC = null;
        }
    }
}