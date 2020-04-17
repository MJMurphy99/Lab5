using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMotion : MonoBehaviour
{
    // Start is called before the first frame update

        public float modAmp, modFreq;
        public float xNow;
    Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
        xNow = modAmp * Mathf.Sin(2.0f * Mathf.PI * modFreq * Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        xNow = modAmp * Mathf.Sin(2.0f * Mathf.PI * modFreq * Time.time);
        transform.position = startPos + new Vector3(xNow, 0, 0);

    }
    }
