using UnityEngine;
public class DisabledLock : MonoBehaviour
{
    public GameObject LightsSEE;
    public Interactable Radius;
    public bool LightsOn;
    
    private void Update()
    {
        Unsseeable();
    }
    public void Unsseeable()
    {
        LightsOn = LightsSEE.activeSelf;
       if(LightsOn==false)
        {
            Radius.interactRadius = 0f;
        }
        else
        {
            Radius.interactRadius = 0.35f;
        }
    }
}
