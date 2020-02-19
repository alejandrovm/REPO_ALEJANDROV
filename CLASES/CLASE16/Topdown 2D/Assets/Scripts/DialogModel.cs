using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Topdown.dialog
{
    public class DialogModel : MonoBehaviour
    {
        public List<string> textList = new List<string> ()
        {
            "Help me, Obi-Wan Kenobi. You're my only hope.",
            "You talkin' to me?",
            "You can't handle the truth!",
        };

        public List<Sprite> faceList;

        [System.Serializable]
        public struct Dialog 
        {
            public int text;
            public int face;
            public int next;
        }

        public Dialog[] dialogs;

        public RectTransform dialog;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}