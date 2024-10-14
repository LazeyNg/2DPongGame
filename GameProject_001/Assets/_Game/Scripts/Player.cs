using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rgBody;
    public float speed;

    private void Update()
    {
        if (!GameManager.instance.allowControl) return;
        rgBody.velocity = new Vector2(speed * Time.deltaTime * Input.GetAxis("Horizontal"), rgBody.velocity.y);
    }
}
