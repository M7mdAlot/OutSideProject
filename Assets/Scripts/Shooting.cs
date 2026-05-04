using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public Transform spawner;
    public GameObject bullet;
    public float speed = 10f;
    void Update()
    {
    }
    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            GameObject bulletInstance = Instantiate(bullet, spawner.position, bullet.transform.rotation);
            bulletInstance.GetComponent<Rigidbody>().linearVelocity = spawner.forward * speed;
            Destroy(bulletInstance,4f);
        }
    }
}
