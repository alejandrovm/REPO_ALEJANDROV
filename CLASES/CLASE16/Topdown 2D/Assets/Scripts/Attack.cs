using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Topdown {
    public class Attack : MonoBehaviour
    {
        [Serializable]
        public string Attacks
        {
            public ElementType type;
            public Projectile prefab;
        }
        public Attacks[] attacksArray;

        public Dictionary<ElementType, Projectile> attacks;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Shoot(1);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Shoot(2);
            }
        }

        public void Shoot(ElementType type)
        {
            Instantiate(attacks[type], transform.position, Quaternion.identity);

        }
    }
}
