using Unity.VisualScripting;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    HpSystem hp= new HpSystem(100);
    public float Health;
    private void Update()
    {
        Health=hp.GetHealth();
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if ((hit.gameObject.tag == "Enemy"))
        {
            hp.damage(10);
        }
        if ((hit.gameObject.tag =="Heal"))
        {
            hp.Heal(10);
        }
    }
  
}
