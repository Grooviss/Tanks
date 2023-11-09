using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public GameObject particle;
    public int particlecount;
    public AudioSource boom;
    public GameObject explosion;
    
    

    void Start()
    {
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
       
    }
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        if (other.gameObject.tag == "building")
        {
            Destroy(other.gameObject);
            for (int i = 0; i < particlecount; i++)
            {

                var offset = Random.insideUnitSphere * 2;
                Instantiate(particle, transform.position, transform.rotation);
                boom.Play();
                explosion.SetActive(true);
                Instantiate(explosion, transform.position, transform.rotation);

            }
        }
       
    }
}
