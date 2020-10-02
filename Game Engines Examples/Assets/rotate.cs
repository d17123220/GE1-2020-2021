using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float speed = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float dangle = speed * Time.deltaTime;

        //get position and change angle/position based on distance to center
        /*
        Vector3 pos = transform.position;
        
        Vector3 newpos =  new Vector3(pos.x * Mathf.Cos(dangle) + pos.y * Mathf.Sin(dangle),  pos.y * Mathf.Cos(dangle) - pos.x * Mathf.Sin(dangle), 0.0f);
        transform.position = newpos;
        */

        // rotate each prefab around it's Y (vertical) axis

        Vector3 rotate = new Vector3(0,Random.Range(0.0f,1.1f),0);
        transform.RotateAround(transform.position, rotate, dangle);

    }
}
