using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Topdown.Dialog
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

        public string GetTextByDialogId(int id)
        {
            return GetTextByDialog(dialogs[id]);
        }

        public string GetTextByDialog(Dialog d)
        {
            return textList[d.text];
        }

        public Sprite GetFaceByDialogId(int id)
        {
            return GetFaceByDialog(dialogs[id]);
        }

        public Sprite GetFaceByDialog(Dialog d)
        {
            return faceList[d.face];
        }

        public bool IsEndById(int id)
        {
            return IsEndByDialog(dialogs[id]);
        }

        public bool IsEndByDialog(Dialog d)
        {
            return (d.next == -1);
        }

        public int GetNextById(int id)
        {
            return GetNextByDialog(dialogs[id]);
        }
 
        public int GetNextByDialog(Dialog d)
        {
            return d.next;
        }
    }
}