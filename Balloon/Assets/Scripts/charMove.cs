using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class charMove : MonoBehaviour
{

    private bool movement = true;
    private float speed = 300f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //movement = Input.GetAxisRaw("Horizontal");
        if (Input.GetMouseButtonDown(0))
        {
            movement = false;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            movement = true;
        }

        if (movement)
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, -speed * Time.fixedDeltaTime);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
