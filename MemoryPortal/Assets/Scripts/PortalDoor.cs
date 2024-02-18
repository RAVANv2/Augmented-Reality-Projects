using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PortalDoor : MonoBehaviour
{

    public Material[] PGMat;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < PGMat.Length; i++)
        {
            Material mat = PGMat[i];
            mat.SetInt("stest", (int)CompareFunction.Equal);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider collider)
    {

        if (collider.gameObject.CompareTag("MainCamera"))
        {
            if(transform.position.z > collider.transform.position.z)
            {
                foreach(Material mat in PGMat)
                {
                    mat.SetInt("stest", (int)CompareFunction.Equal);
                }
            }
            else
            {
                foreach (Material mat in PGMat)
                {
                    mat.SetInt("stest", (int)CompareFunction.NotEqual);
                }
            }
        }


    }

}
