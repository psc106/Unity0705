using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Bullet : MonoBehaviour
{
    public float speed = default;

    private Rigidbody bulletRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            Debug.Log("(트리거)플레이어부딪침");
            Player player = other.GetComponent<Player>();

            if(player != null)
            {
                player.Die();
                Destroy(gameObject);
            }
        }
        if (other.tag == ("Wall"))
        {
            Destroy(gameObject);
            Debug.Log("(트리거)벽부딪침");
        }
    }

}
