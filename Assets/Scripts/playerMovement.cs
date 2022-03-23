using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    int speedModifier = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalSpeed = Input.GetAxisRaw("Horizontal") * speedModifier * Time.deltaTime;
        transform.Translate(horizontalSpeed, 0, 0);

        float verticalSpeed = Input.GetAxisRaw("Vertical") * speedModifier * Time.deltaTime;
        transform.Translate(0, 0, verticalSpeed);
    }
}
