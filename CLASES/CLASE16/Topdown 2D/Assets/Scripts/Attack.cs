using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Topdown {
    public class Attack : MonoBehaviour
    {
        [Serializable]
        public struct Attacks
        {
            public ElementType type;
            public Projectile prefab;
        }
        public Attacks[] attacksArray;

        public Dictionary<ElementType, Projectile> attacks;

        public int currentAttack;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.KeypadMinus))
                currentAttack--;

            if (Input.GetKeyDown(KeyCode.KeypadPlus))
                currentAttack++;

            currentAttack = Mathf.Clamp(currentAttack, 0, attacks.Count - 1);

            if (Input.GetKeyDown(KeyCode.Space))
                Shoot(currentAttack);
        }

        public void Shoot(int type)
        {
            ElementType t = (ElementType)type;
            Shoot(t);
        }

        public void Shoot(ElementType type)
        {
            Instantiate(attacks[type], transform.position, Quaternion.identity);
        }
    }
}
