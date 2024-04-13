using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public GameObject planetObject;
    public Vector3 rotationDimesion;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        planetObject.transform.Rotate(rotationDimesion * Time.deltaTime);
    }
}
