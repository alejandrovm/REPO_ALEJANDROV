using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace My2DPlatformer
{
    public class CameraController : MonoBehaviour
    {
        public GameObject followPlayer;
        public Vector2 followOffset;
        public float camSpeed = 3f;

        private Vector2 threshold;
        private Rigidbody2D _rigidbody2D;

        // Start is called before the first frame update
        void Start()
        {
            threshold = calculateThreshold();
            _rigidbody2D = followPlayer.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            Vector2 follow = followPlayer.transform.position;
            float xDifference = Vector2.Distance(Vector2.right * transform.position.x, Vector2.right * follow.x);
            float yDifference = Vector2.Distance(Vector2.up * transform.position.y, Vector2.up * follow.y);

            Vector3 newPosition = transform.position;

            if (Mathf.Abs(xDifference) >= threshold.x)
            {
                newPosition.x = follow.x;
            }
            if (Mathf.Abs(yDifference) >= threshold.y)
            {
                newPosition.y = follow.y;
            }

            float moveSpeed = _rigidbody2D.velocity.magnitude > camSpeed ? _rigidbody2D.velocity.magnitude : camSpeed;
            transform.position = Vector3.MoveTowards(transform.position, newPosition, moveSpeed * Time.deltaTime);
        }

        private Vector3 calculateThreshold()
        {
            Rect aspect = Camera.main.pixelRect;
            Vector2 t = new Vector2(Camera.main.orthographicSize * aspect.width / aspect.height, Camera.main.orthographicSize);
            t.x -= followOffset.x;
            t.y -= followOffset.y;
            return t;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.blue;
            Vector2 border = calculateThreshold();
            Gizmos.DrawWireCube(transform.position, new Vector3(border.x * 2, border.y * 2, 1));
        }
    }
}