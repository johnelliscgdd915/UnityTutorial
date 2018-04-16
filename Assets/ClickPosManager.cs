using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPosManager : MonoBehaviour {

    public LayerMask clickMask;
    public GameObject followObject;

	// Update is called once per frame
	void Update () {
		//if(Input.GetMouseButtonDown(0))
  //      {
            Vector3 clickPosition = -Vector3.one;

        //METHOD 1: SCREENTOWORLDPOINT
        //clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 5f));

        //METHOD 2: RAYCAST USING COLLIDERS
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f, clickMask))
        {
            clickPosition = hit.point;
        }

        //METHOD 3: RAYCAST USING PLANE
        //Plane plane = new Plane(Vector3.up, 0f);
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //float distanceToPlane;

        //if(plane.Raycast(ray, out distanceToPlane))
        //{
        //    clickPosition = ray.GetPoint(distanceToPlane);
        //}


        //Goal: LOG POSITION IN WORLD SPACE TO THE CONSOLE
        followObject.transform.position = clickPosition + new Vector3(0f, .5f, 0f);
        
	}
}
