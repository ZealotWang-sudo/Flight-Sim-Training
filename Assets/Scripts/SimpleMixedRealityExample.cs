using UnityEngine;
using Varjo.XR;

public class SimpleMixedRealityExample : MonoBehaviour
{
    public bool mixedReality;
    public KeyCode MixedRealityToggle = KeyCode.Space;
    //meta
    private bool mixedRealityEnabled = false;
    private bool originalOpaqueValue;

    void Start()
    {
        if (mixedReality)
        {
            VarjoMixedReality.StartRender();
            VarjoMixedReality.EnableDepthEstimation();
            mixedRealityEnabled = true;
            originalOpaqueValue = VarjoRendering.GetOpaque();
            VarjoRendering.SetOpaque(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(MixedRealityToggle))
        {
            mixedReality = !mixedReality;
        }

        if (mixedReality != mixedRealityEnabled)
        {
            if (mixedReality)
            {
                VarjoMixedReality.StartRender();
                VarjoMixedReality.EnableDepthEstimation();
                originalOpaqueValue = VarjoRendering.GetOpaque();
                VarjoRendering.SetOpaque(false);
            }
            else
            {
                VarjoMixedReality.DisableDepthEstimation();
                VarjoMixedReality.StopRender();

                VarjoRendering.SetOpaque(originalOpaqueValue);
            }

            mixedRealityEnabled = mixedReality;
        }
    }

    public void mixedRealityToggle()
    {
        mixedReality = !mixedReality;
    }

}
