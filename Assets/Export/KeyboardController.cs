using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class KeyboardController : MonoBehaviour
{

    public Interactable reloadButton;
    public Interactable testButton;
    public Interactable infoButton;
    public Interactable mixedRealityButton;
    public Interactable positionButton;

    public KeyCode setReloadKey = KeyCode.R;
    public KeyCode goToTestkey = KeyCode.H;
    public KeyCode goToInfoKey = KeyCode.J;
    public KeyCode positionKey = KeyCode.K;
    public KeyCode mixedRealityKey = KeyCode.M;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(setReloadKey))
        {
            reloadButton.TriggerOnClick();
        }
        if (Input.GetKeyDown(goToTestkey))
        {
            testButton.TriggerOnClick();
        }
        if (Input.GetKeyDown(goToInfoKey))
        {
            infoButton.TriggerOnClick();
        }
        if (Input.GetKeyDown(mixedRealityKey))
        {
            mixedRealityButton.TriggerOnClick();
        }
        if (Input.GetKeyDown(positionKey))
        {
            positionButton.TriggerOnClick();
        }
    }
}
