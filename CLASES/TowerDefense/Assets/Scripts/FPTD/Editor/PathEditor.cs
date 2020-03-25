﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace FPTD
{
    [CustomEditor(typeof(Path))]
    public class PathEditor : Editor
    {
        Path myPath;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            myPath = (Path)target;

            if (GUILayout.Button("Create Node"))
                ((Path)target).GenerateNodes();

            if (GUILayout.Button("Create Nodes"))
            {
                myPath.DeleteAllNodes();
                myPath.GenerateFromMatrix();
            }

            if (GUILayout.Button("Load json"))
                myPath.LoadJson();
        }
    }
}