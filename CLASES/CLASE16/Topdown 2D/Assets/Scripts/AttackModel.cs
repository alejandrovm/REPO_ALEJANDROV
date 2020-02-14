using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Topdown
{
    public class AttackModel : MonoBehaviour
    {
        [Serializable]
        public struct Attacks
        {
            public ElementType type;
            public Projectile prefab;
            public Sprite sprite;
        }
        public Attacks[] attacksArray;

        public Dictionary<ElementType, Projectile> attacks;
        public Dictionary<ElementType, Sprite> sprites;


        private int _currentAttack;
        public int currentAttack
        {
            get
            {
                return _currentAttack;
            }
            set { 
                _currentAttack = Mathf.Clamp(value, 0, attacks.Count - 1);
            }
        }

        public Image icon;

    void Start()
        {
            attacks = new Dictionary<ElementType, Projectile>();
            foreach (Attacks a in attacksArray)
            {
                attacks.Add(a.type, a.prefab);
            }

            sprites = new Dictionary<ElementType, Sprite>();
            foreach (Attacks a in attacksArray)
            {
                sprites.Add(a.type, a.sprite);
            }
        }
    }
}
