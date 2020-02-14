using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Topdown
{
    public class AttackModel : MonoBehaviour
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

        void Start()
        {
            attacks = new Dictionary<ElementType, Projectile>();
            foreach (Attacks a in attacksArray)
            {
                attacks.Add(a.type, a.prefab);
            }
        }
    }
}
