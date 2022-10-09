using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public Transform CameraTransform;
    private float horizontal;
    private float vertical;
    // Start is called before the first frame update
    void Start()
    {
    }

    void Update(){
        RotationCam();
        DirectionCam();
    }

    // Update is called once per frame
    private void RotationCam()
    {
        float SourisY = Input.GetAxis("Mouse X")*Time.deltaTime*1000f;
        float SourisX = Input.GetAxis("Mouse Y")*Time.deltaTime*1000f;
        //CameraTransform.RotateAround(CameraTransform.transform.position, Vector3.up, SourisX);
        CameraTransform.eulerAngles +=  new  Vector3(-SourisX,SourisY,0);
    }
    private void DirectionCam(){

        var angle = 2 * Mathf.PI * transform.eulerAngles.y / 360;
        transform.position += new Vector3(
                            Input.GetAxis("Horizontal") * Time.deltaTime * 30f * Mathf.Sin(angle + (Mathf.PI / 2)) + Input.GetAxis("Vertical") * Time.deltaTime * 30f * Mathf.Sin(angle),
                            0f,
                            Input.GetAxis("Horizontal") * Time.deltaTime * 30f * Mathf.Cos(angle + (Mathf.PI / 2)) + Input.GetAxis("Vertical") * Time.deltaTime * 30f * Mathf.Cos(angle));
        
    }
}
