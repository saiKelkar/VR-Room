using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingReticle : MonoBehaviour
{
    [SerializeField] public float rotationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Rotate(0, 0.1f * rotationSpeed * Time.deltaTime, 0);  
    }
}
