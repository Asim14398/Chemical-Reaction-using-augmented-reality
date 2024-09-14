using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    public float delay = 0f;
    float countdown;
    public GameObject explosion;
    private void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f)
        {
            explode1();
            delay = 1f;
        }
    }
    void explode1()
    {
        Debug.Log("boom");
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}


