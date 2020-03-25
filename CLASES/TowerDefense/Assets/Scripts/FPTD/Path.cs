﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPTD
{
    public class Path : MonoBehaviour
    {
        static public Path instance;
        static public Node startNode
        {
            get
            {
                return instance.start;
            }
        }

        static public Node finishNode
        {
            get
            {
                return instance.finish;
            }
        }

        static public Vector3 GetPositionAt(Node from, Node to, float t)
        {
            return instance.GetPosition(from, to, t);
        }

        Vector3[] nodesPos = new Vector3[5]{
            new Vector3(-17.3f,0,16.9f),
            new Vector3(15.1f,0,7.3f),
            new Vector3(3.5f,0,-6.3f),
            new Vector3(-15.6f,0,-17.1f),
            new Vector3(17,0,-15.6f)
            };

        int[,] matrix = new int[5, 5] {
            {0,1,0,1,0 },
            {1,0,1,0,1 },
            {0,1,0,1,0 },
            {1,0,1,0,1 },
            {0,1,0,1,0 },
        };

        List<List<int>> list = new List<List<int>>() {
            new List<int>(){1,3},
            new List<int>(){0,2,4},
            new List<int>(){1,3},
            new List<int>(){0,2,4},
            new List<int>(){1,3}
        };

        [System.Serializable]
        public struct exits
        {
            public List<int> nodes;
        }

        [System.Serializable]
        public struct jsonPath
        {
            public Vector3[] nodes;
            public List<exits> exits;
        }

        public List<Node> nodes = new List<Node>();
        
        public Node start 
        {
            get
            {
                return nodes[0];
            }
        }

        public Node finish
        {
            get
            {
                return nodes[nodes.Count - 1];
            }
        }

        public int nodesCount
        {
            get
            {
                return nodes.Count;
            }
        }

        #region Unity Events

        void Awake()
        {
            instance = this;
            foreach (Transform child in transform)
            {
                Node n = new Node(child.position);
                n.name = child.name;
                AddNode(n);
            }

            for (int n = 0; n < list.Count; n++)
            {
                foreach (int m in list[n])
                {
                    nodes[n].AddExit(nodes[m]);
                }
            }
        }

        public TextAsset json;
        public jsonPath myPath;
        public void LoadJson()
        {
            myPath = JsonUtility.FromJson<jsonPath>(json.text);

            for (int i = 0; i < myPath.nodes.Length; i++)
            {
                for (int j = 0; j < myPath.exits[i].nodes.Count; j++)
                {
                    Debug.Log("from: " + transform.GetChild(i).name + " to: " + transform.GetChild(myPath.exits[i].nodes[j]).name);
                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnDrawGizmos()
        {
            if (transform.childCount < 2)
                return;

            for (int i = 0; i < myPath.nodes.Length; i++)
            {
                for (int j = 0; j < myPath.exits[i].nodes.Count; j++)
                {
                    Gizmos.DrawLine(transform.GetChild(i).position, transform.GetChild(myPath.exits[i].nodes[j]).position);
                }
            }
        }
        #endregion

        private void PrintNodes()
        {
            nodes.ForEach((node) =>
            {
                Debug.Log(node.name);
            });
        }

        public void GenerateNodes()
        {
            Debug.Log("GenerateNodes");
            GameObject n = new GameObject("Node " + transform.childCount);

            if (transform.childCount > 1)
                n.transform.position = transform.GetChild(transform.childCount - 1).position;

            n.transform.parent = transform;
        }

        public void DeleteAllNodes()
        {
            int childCount = transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Debug.Log(transform.GetChild(0).name);
                DestroyImmediate(transform.GetChild(0).gameObject);
            }

            nodes.Clear();
        }

        public void GenerateFromMatrix()
        {
            for (int i = 0; i < nodesPos.Length; i++)
            {
                GameObject obj = new GameObject("Node " + i);
                obj.transform.position = nodesPos[i];
                obj.transform.parent = transform;
            }

        }

        public void AddNode (Node node)
        {
            nodes.Add(node);
        }

        public Vector3 GetPosition(Node from, Node to, float t)
        {
            return Vector3.Lerp(
                from.position,
                to.position,
                t);
        }

        public float GetDistance(Node from, Node to)
        {
            return -1f;
        }
    }
}