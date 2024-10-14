using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public Transform thisTf;
    public Transform ballTf;
    public Rigidbody2D rgBody;
    public float speed;

    private void Start()
    {
        StartCoroutine(IEChangeSpeed());
    }

    private void Update()
    {
        float direction = ballTf.position.x - thisTf.position.x;

        rgBody.velocity = new Vector2(direction, rgBody.velocity.y) * speed * Time.deltaTime;
    }

    IEnumerator IEChangeSpeed()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            speed = Random.Range(180, 280);
        }
    }
}
