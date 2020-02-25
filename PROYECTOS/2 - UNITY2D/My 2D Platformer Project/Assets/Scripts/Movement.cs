using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace My2DPlatformer
{
    public class Movement : MonoBehaviour
    {
        public float speed = 1f;

        public Vector2 startPosition;

        // Start is called before the first frame update
        void Start()
        {
            transform.position = startPosition;
        }

        // Update is called once per frame
        void Update()
        {
            transform.position += new Vector3(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);
            transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
        }

        void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "ToLevel1")
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}