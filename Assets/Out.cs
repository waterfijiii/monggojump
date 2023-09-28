using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Out : MonoBehaviour
{
    public Transform target;

    private void LateUpdate()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target.position.y >= transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y-10, transform.position.z);
            transform.position = newPosition;
        }
    }
}
