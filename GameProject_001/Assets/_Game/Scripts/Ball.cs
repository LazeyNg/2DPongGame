using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rdBody;
    public float speed;

    private void Start()
    {
        // Launch();
    }

    public void Launch()
    {
        StartCoroutine(IELaunch());
    }

    IEnumerator IELaunch()
    {
        yield return new WaitForSeconds(1f);

        float x = Random.Range(0, 2) == 0 ? 1 : -1;
        float y = Random.Range(0, 2) == 0 ? 1 : -1;

        rdBody.velocity = new Vector2(x, y) * speed;
    }
}
