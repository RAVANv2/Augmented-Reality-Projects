using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlantsPlacement : MonoBehaviour
{

    public List<GameObject> flowers;
    public ARRaycastManager raycastManager;
    public ARPlaneManager planeManager;

    private List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    private void Start()
    {
        foreach(var flower in flowers)
        {
            flower.transform.localScale = flower.transform.localScale * 0.5f;
        }
    }


    // Update is called once per frame
    void Update()
    {

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            bool collision = raycastManager.Raycast(Input.mousePosition, raycastHits, TrackableType.PlaneWithinPolygon);
            if(collision)
            {
                GameObject flower = Instantiate(flowers[Random.Range(0, flowers.Count - 1)]);
                flower.transform.position = raycastHits[0].pose.position;
            }

            foreach(var plane in planeManager.trackables)
            {
                plane.gameObject.SetActive(false);
            }

            planeManager.enabled = false;
        }
        
    }
}
