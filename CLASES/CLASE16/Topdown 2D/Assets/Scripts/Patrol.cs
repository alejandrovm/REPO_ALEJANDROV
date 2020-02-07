using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Topdown.AI;

namespace Topdown
{
    public class Patrol : MonoBehaviour
{
        int currentIndex;
        float t = 0f;
        Vector3 startPos;
        Vector3 endPos;
<<<<<<< HEAD
        List<Vector3> points;
        
        public float speed = 1f;

        public ActionArea player;
        public Path path;
=======
        Vector3 point;
        Vector3 origin;

        public Vector2[] points;
        public float speed = 1f;
        public ActionArea player;

>>>>>>> abd7d471fcac72014a5e09fc6a54647babffadb7
        // Start is called before the first frame update
        void Start()
    {
            currentIndex = 0;
<<<<<<< HEAD
            points = path.points;
            startPos = points[0];
            endPos = points[1];


        }
=======
            point = points[currentIndex];
            origin = transform.position; 
            startPos = origin;
            endPos = origin + point;
            
    }
>>>>>>> abd7d471fcac72014a5e09fc6a54647babffadb7

    // Update is called once per frame
    void Update()
    {
            transform.position = Vector3.Lerp(startPos, endPos, t);
<<<<<<< HEAD
            t += Time.deltaTime * speed;
=======
            t += Time.deltatime * speed;

            if (Vector3.Distance(transform.position, player.transform.position) <= player.radius)
            {
                speed *= 2f;
            }
            else
            {
                float distance = Vector3.Distance(startPos, endPos);
                speed = 2f / distance;
            }
>>>>>>> abd7d471fcac72014a5e09fc6a54647babffadb7

            
            if (t >= 1f)
            {
                currentIndex++;

                if (currentIndex >= points.Count)
                {
                    OnFinishPath();
                }
<<<<<<< HEAD

                startPos = endPos;
                currentIndex++;
                endPos = points[currentIndex];

                float distance = Vector3.Distance(startPos, endPos);
                speed = 2f / distance;
=======
                else
                {
                    point = points[currentIndex];
                }
               
                endPos = origin + point;
>>>>>>> abd7d471fcac72014a5e09fc6a54647babffadb7

                float distance = Vector3.Distance(startPos, endPos);
                speed = 2f / distance;

                t = 0;
            }
               
    }

<<<<<<< HEAD
        private void OnFinishPath()
        {
            switch (path.type)
            {
                case PathType.loop:
                    currentIndex = 0;
                    if (!path.isClose)
                    {
                        endPos = points[currentIndex];
                        transform.position = endPos;
                    }
                    break;

                case PathType.pingpong:
                    if (!path.isClose)
                    {
                        endPos = points[currentIndex];
                        transform.position = endPos;
                    }
                    else
                    {
                        points.Reverse();
                        currentIndex = 0;
                    }

                    //   speed *= -1; // speed = -speed;

                    break;
            }

            if (path.isClose)
            {
                currentIndex = 0;
            }


=======
    private void OnDrawGizmos()
    {
            if (!Application.isPlaying && origin != transform.position)
                origin = transform.position;

        Vector3 point = points[0];
        Debug.DrawLine(origin, origin + point, Color.cyan);

            for (int i = 1; i < points.Length; i++)
            {
                point = points[i - 1];
                Vector3 start = origin + point;

                point = points[i];
                Vector3 end = origin + point;
                Debug.DrawLine(start, end, Color.cyan);
            }

            point = points[points.Length-1];
            Debug.DrawLine(origin + point, origin, Color.cyan);
>>>>>>> abd7d471fcac72014a5e09fc6a54647babffadb7
        }

}
}