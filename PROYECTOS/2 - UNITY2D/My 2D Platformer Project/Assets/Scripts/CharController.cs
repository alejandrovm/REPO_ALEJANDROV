using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyPlatformer
{
    public class CharController : MonoBehaviour
    {
        static public CharController _instance;

        [SerializeField]
        private float _speed;
        [SerializeField]
        private float _jump;
        private SpriteRenderer spriteRenderer;
        private Rigidbody2D _rigidbody2D;
        private bool onGround = false;

        public Vector3 startPosition;
        public Animator animator;
        public bool grounded
        {
            get
            {
                return RoundAbsoluteToZero(_rigidbody2D.velocity.y) == 0f || onGround;
            }
        }

        void Awake()
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }

        // Start is called before the first frame update
        void Start()
        {
            transform.position = startPosition;
            spriteRenderer = GetComponent<SpriteRenderer>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(new Vector3(horizontalInput, 0, 0) * _speed * Time.deltaTime);
            animator.SetBool("Speed", (horizontalInput != 0));
            animator.SetBool("IsJumping", !grounded);
            animator.SetFloat("vertical", Mathf.Sign(_rigidbody2D.velocity.y));

            if (horizontalInput != 0)
            {
                spriteRenderer.flipX = (horizontalInput < 0);
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                _speed *= 2;
            }

            if (grounded && Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody2D.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
            }
        }

        void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "DeathZone")
            {
                transform.position = startPosition;
            }

            if (col.gameObject.tag == "Floor")
            {
                onGround = true;
            }
        }

        void OnCollisionExit2D(Collision2D col)
        {
            if (col.gameObject.tag == "Floor")
            {
                onGround = false;
            }
        }

            float RoundAbsoluteToZero(float decimalValue)
        {
            decimalValue = Mathf.Abs(decimalValue);
            if (decimalValue <= 0.01f)
            {
                decimalValue = 0f;
            }
            return decimalValue;
        }
    }
}