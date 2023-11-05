using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed;
    public float rotatespeed;
    public string verticalaxis;
    public string horizontalaxis;
    public KeyCode shootkey;
    public GameObject bullet;
    public Transform shootpoint;
    void Update()
    {
        var ver = Input.GetAxis(verticalaxis);
        transform.position += transform.forward * speed * ver *  Time.deltaTime;
        var hor = Input.GetAxis(horizontalaxis);

        transform.Rotate(0, rotatespeed * hor * Time.deltaTime, 0);
        if (Input.GetKeyDown(shootkey))
        {
            Instantiate(bullet, shootpoint.position, transform.rotation);
        }
    }
}
