using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    public float speed = 1.5f;

    public float limitX = 2f;

    public float speedY = 1f;
    public float limitY = 2f;

    public GameObject bullet;
    public float bulletSpeed;
    private bool fired = false;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveY();
        Fire();
    }
    //move player
    public void MoveX()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0f);
        if (transform.position.x > limitX)
        {
            transform.position = new Vector2(limitX, transform.position.y);
        }
        else if (transform.position.x < -limitX)
        {
            transform.position = new Vector2(-limitX, transform.position.y);
        }
    }

    public void MoveY()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, speedY);
        if (transform.position.x > limitX)
        {
            transform.position = new Vector2(limitX, transform.position.y);
        }
        else if (transform.position.x < -limitX)
        {
            transform.position = new Vector2(-limitX, transform.position.y);
        }
    }

    public void Fire()
    {
        if (Input.GetAxis("Fire1") == 1f)
        {
            if (!fired)
            {
                fired = true;
                GameObject bulletInstance = Instantiate(bullet);
                bulletInstance.transform.SetParent(transform.parent);
                bulletInstance.transform.position = transform.position; // new Vector3(transform.position.x,transform.position.y +f,transform.position.z);
                bulletInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bulletSpeed);
                Destroy(bulletInstance, 3f);
            }
            else
            {
                fired = false;
            }
        }
    }

}