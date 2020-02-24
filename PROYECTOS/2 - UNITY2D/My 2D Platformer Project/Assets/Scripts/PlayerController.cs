using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyPlatformer
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Horizontal Movement")]
        public float _speed = 10f;
        public Vector2 direction;
        private bool facingRight = true;

        [Header("Vertical Movement")]
        public float _jump = 15f;
        public float _delay = 0.25f;
        public float _timer;

        [Header("Components")]
        public Rigidbody2D _rigidbody2D;
        public Animator animator;
        public LayerMask floorLayer;

        [Header("Physics")]
        public float maxSpeed = 7f;
        public float linearDrag = 4f;
        public float gravity = 1f;
        public float fallMultiplier = 5f;

        [Header("Collision")]
        public bool onGround = false;
        public float groundLength = 0.6f;
        public Vector3 colliderOffset;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            onGround = Physics2D.Raycast(transform.position + colliderOffset, Vector2.down, groundLength, floorLayer) || Physics2D.Raycast(transform.position - colliderOffset, Vector2.down, groundLength, floorLayer); ;

            if (Input.GetButtonDown("Jump"))
            {
                _timer = Time.time + _delay;
            }

            direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

            animator.SetFloat("horizontal", Mathf.Abs(Input.GetAxis("Horizontal")));
            animator.SetFloat("vertical", Input.GetAxis("Vertical"));
        }

        void FixedUpdate()
        {
            moveCharacter(direction.x);

            if (_timer > Time.time && onGround)
            {
                Jump();
            }

            modifyPhysics();
        }

        void moveCharacter(float horizontal)
        {
            _rigidbody2D.AddForce(Vector2.right * horizontal * _speed);

            animator.SetFloat("horizontal", Mathf.Abs(_rigidbody2D.velocity.x));
            animator.SetFloat("vertical", _rigidbody2D.velocity.y);

            if ((horizontal > 0 && !facingRight) || (horizontal < 0 && facingRight))
            {
                Flip();
            }

            if (Mathf.Abs(_rigidbody2D.velocity.x) > maxSpeed)
            {
                _rigidbody2D.velocity = new Vector2(Mathf.Sign(_rigidbody2D.velocity.x) * maxSpeed, _rigidbody2D.velocity.y);
            }
        }

        void Jump()
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, 0);
            _rigidbody2D.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
            _timer = 0;
        }

        void modifyPhysics()
        {
            bool changingDirections = (direction.x > 0 && _rigidbody2D.velocity.x < 0) || (direction.x < 0 && _rigidbody2D.velocity.x > 0);

            if (onGround)
            {
                if (Mathf.Abs(direction.x) < 0.4f || changingDirections)
                {
                    _rigidbody2D.drag = linearDrag;
                }
                else
                {
                    _rigidbody2D.drag = 0f;
                }
                _rigidbody2D.gravityScale = 0;
            }
            else
            {
                _rigidbody2D.gravityScale = gravity;
                _rigidbody2D.drag = linearDrag * 0.15f;
                if (_rigidbody2D.velocity.y < 0)
                {
                    _rigidbody2D.gravityScale = gravity * fallMultiplier;
                }
                else if (_rigidbody2D.velocity.y > 0 && !Input.GetButton("Jump"))
                {
                    _rigidbody2D.gravityScale = gravity * (fallMultiplier / 2);
                }
            }
}

        void Flip()
        {
            facingRight = !facingRight;
            transform.rotation = Quaternion.Euler(0, facingRight ? 0 : 180, 0);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position + colliderOffset, transform.position + colliderOffset + Vector3.down * groundLength);
            Gizmos.DrawLine(transform.position - colliderOffset, transform.position - colliderOffset + Vector3.down * groundLength);
        }
    }
}