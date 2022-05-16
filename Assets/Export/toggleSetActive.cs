using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleSetActive : MonoBehaviour
{
    // Start is called before the first frame update
    public bool activeState = true; 

    public void toggleSet()
    {
        // No need to check for the input again
    activeState = !activeState;
    this.gameObject.SetActive(activeState);
    } 
}
