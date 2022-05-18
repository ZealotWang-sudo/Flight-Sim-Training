using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
public class EnvironmentPositionManager : MonoBehaviour
{

    public GameObject camera;
    public Vector3 defaultoffset = new Vector3(0, -0.4f, 1.98f);
    public KeyCode setPosition = KeyCode.Space;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(setPosition))
        {
            resetJetLocation();
        }

    }

    public void resetJetLocation()
    {
        transform.position = camera.transform.position + defaultoffset;
    }

    // Update is called once per frame
    public void OnSliderUpdatedX(float eventData)
    {
        //transform.position -= new Vector3(eventData.NewValue, transform.position.y, transform.position.z);
        // defaultoffset = new Vector3(eventData.NewValue, defaultoffset.y, defaultoffset.z);
        /* TargetRenderer = GetComponentInChildren<Renderer>();
         if ((TargetRenderer != null) && (TargetRenderer.material != null))
         {
             TargetRenderer.material.color = new Color(eventData.NewValue, TargetRenderer.sharedMaterial.color.g, TargetRenderer.sharedMaterial.color.b);
         }*/
    }


    public void OnSliderUpdatedY(float eventData)
    {
        transform.position = new Vector3(transform.position.x, eventData + transform.position.y, transform.position.z);
        defaultoffset = new Vector3(defaultoffset.x, eventData + defaultoffset.y, defaultoffset.z);
    }

    public void OnSliderUpdateZ(float eventData)
    {

        transform.position = new Vector3(transform.position.x, transform.position.y, eventData + transform.position.z);
        defaultoffset = new Vector3(defaultoffset.x, defaultoffset.y, eventData + defaultoffset.z);
    }
}
