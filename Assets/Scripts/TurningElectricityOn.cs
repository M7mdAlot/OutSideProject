
using UnityEngine;

public class TurningElectricityOn : MonoBehaviour
{
    public Animator animator;
    public GameObject Lights;

    public void Interacted()
    {
        animator.SetBool("Interacted", true);
        Lights.SetActive(true);
    }

}
