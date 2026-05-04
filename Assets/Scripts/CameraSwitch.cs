using UnityEngine;
using Unity.Cinemachine;
public class CameraSwitch : MonoBehaviour
{
    public Transform Player;
    public CinemachineCamera ActiveCam;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ActiveCam.Priority = 1;
        }
    }
        private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ActiveCam.Priority = 0;
        }
    }
}

