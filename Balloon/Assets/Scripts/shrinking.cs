using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrinking : MonoBehaviour
{

    private float shrinkingSpeed = .7f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * .1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += Vector3.one*shrinkingSpeed*Time.deltaTime;
        if(transform.localScale.x >= 10f)
        {
            Destroy(gameObject);
        }

    }
}
