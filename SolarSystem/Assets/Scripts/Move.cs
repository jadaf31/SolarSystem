using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 v1 = transform.position;
        // transform.position = v1 + new Vector3 (1, 0, 0) * Time.deltaTime;
        transform.Rotate(Vector3.right * 25 * Time.deltaTime);
    }
}
