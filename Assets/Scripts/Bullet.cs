using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public GameObject cubeprefab;
    public GameObject todestroy;
    

    void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
       
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(cubeprefab, transform.position, Quaternion.identity);
            }
            Destroy(todestroy);
        }
    }
}
