using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + new Vector3(0.0f, 0.0f, -10);
    }
}
