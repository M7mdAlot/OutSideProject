using Unity.VisualScripting;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
     if(collision.gameObject.CompareTag("Enemy"))
            {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);

    }


    void Update()
    {
        
    }
}
