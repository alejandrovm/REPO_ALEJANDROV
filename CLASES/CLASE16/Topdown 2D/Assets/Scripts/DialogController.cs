using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Topdown.dialog
{
    public class DialogController : MonoBehaviour
    {
        static private DialogController instance;

        // Start is called before the first frame update
        void Start()
        {
            view.Init(model);
        }
    }
}