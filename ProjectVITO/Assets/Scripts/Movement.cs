using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 15f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveAmountY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float moveAmountX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(moveAmountX, moveAmountY, 0);
    }
}
