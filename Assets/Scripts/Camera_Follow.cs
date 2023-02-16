using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    [SerializeField] private GameObject _object; //An object camera will follow
   // [SerializeField] private Vector3 zoom; // Camera's distance from the object
    [SerializeField] private Quaternion _quaternionToObject; // Camera's rotation
    [SerializeField] private Vector3 cameraPosition; 
    private Camera _camera;
    private Transform camRig;

    private void Start()
    {
        _camera = Camera.main;
        camRig = transform.parent;

      //  cameraPosition = camRig.position;
       // _quaternionToObject = camRig.rotation;
       // zoom = transform.localPosition;
    }

    private void LateUpdate()
    {
        Vector3 positionToGo = new Vector3 (cameraPosition.x,cameraPosition.y,cameraPosition.z+_object.transform.position.z);
      //  Vector3 smoothPosition = Vector3.Lerp(a: cameraPosition, b: positionToGo, t: 1f);
       // transform.position = smoothPosition;
       //_camera.transform.position = positionToGo;
         transform.SetPositionAndRotation(positionToGo,_quaternionToObject);
        //transform.LookAt(_object.transform.position); 

    }
}
