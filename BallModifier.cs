using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallModifier : MonoBehaviour
{
    // Variables
    public Vector3 scaleChange;
    public Vector3 positionChange;
    public Vector3 rotationChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Changes the shape's components
        transform.localScale += scaleChange;
        transform.position += positionChange;
        transform.Rotate(rotationChange);
    }
}
