using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VButton : MonoBehaviour
{
    private VirtualButtonBehaviour[] virtualButtonBehaviours;
    public GameObject bear;

    // Start is called before the first frame update
    void Start()
    {
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
        
        for(int i = 0; i< virtualButtonBehaviours.Length; i++)
        {
            virtualButtonBehaviours[i].RegisterOnButtonPressed(OnButtonPressed);
            virtualButtonBehaviours[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
        bear.GetComponent<Animator>().SetBool("IsDance", true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
        bear.GetComponent<Animator>().SetBool("IsDance", false);
    }
}
