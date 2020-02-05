using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Topdown
{
    public class Patrol : MonoBehaviour
{
        int currentIndex;
        float t = 0f;
        Vector3 startPos;
        Vector3 endPos;
        Vector3 point;
        Vector3 origin;
        public Vector2[] points;

    // Start is called before the first frame update
    void Start()
    {
            currentIndex = 0;
            point = points[currentIndex];
            origin = startPos;
            startPos = transform.position;
            endPos = startpos + point;
            
    }

    // Update is called once per frame
    void Update()
    {
            transform.position = Vector3.Lerp(startPos, endPos, t);
            t += Time.deltatime;

            if (t >= 1f)
            {
                startpos = endPos;
                currentIndex++;

                if (currentIndex >= points.Lenght)
                {
                    currentIndex = -1;
                    point = Vector3.zero;
                }
                else
                {

                }
               
                endPos = origin + point;

                t = 0;
            }
                
    }

    private void OnDrawGizmos()
    {
            if (startpos != transform.position && !Application.IsPlaying)
                startpos = transform.position;

        Vector3 point = points[0];
        Debug.DrawLine(transform.position, transform.position + point, Color.cyan);
        
        for(int i = 1; i < points.Length; i++)
            {
                point = points[i - 1];
                Vector3 start = transform.position + point;

                point = points[i];
                Vector3 end = transform.position + point;
                Debug.DrawLine(start, end, Color.cyan);
            }

            point = points[points.Length-1];
            Debug.DrawLine(transform.position + point, transform.position, Color.cyan);
        }

}
}