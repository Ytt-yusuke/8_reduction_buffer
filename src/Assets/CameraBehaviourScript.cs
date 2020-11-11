using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float distance = transform.localPosition.z;
        transform.localPosition = new Vector3(0, 0, distance);
        float inv_aspect = (float)Screen.width / (float)Screen.height;
        float s = Mathf.Tan(0.5f * Camera.main.fieldOfView * Mathf.Deg2Rad) * 2.0f * distance;
        transform.localScale = new Vector3(inv_aspect * s, s, 1.0f);

    }

    // Update is called once per frame
    void Update()
    {
        float distance = transform.localPosition.z;
        transform.localPosition = new Vector3(0, 0, distance);
        float inv_aspect = (float)Screen.width / (float)Screen.height;
        float s = Mathf.Tan(0.5f * Camera.main.fieldOfView * Mathf.Deg2Rad) * 2.0f * distance;
        transform.localScale = new Vector3(inv_aspect * s, s, 1.0f);
    }
}
