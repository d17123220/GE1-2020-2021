using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int ringnum = 9;
    public int ringbaserad = 1;
    public int elementSize = 1;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        for(int j = 1; j < ringnum + 1; j++)
        {
            int ringrad = ringbaserad * j;

            float elementsInRing = Mathf.Floor(Mathf.PI * 2.0f * (float)ringrad / (float)elementSize); 
            float ugol = Mathf.PI * 2.0f / (float) elementsInRing;
            for (int i = 0; i < elementsInRing; i++)
            {
                GameObject sp = GameObject.Instantiate<GameObject>(prefab);
                Vector3 pos = new Vector3(Mathf.Sin(ugol * i) * ringrad,Mathf.Cos(ugol * i) * ringrad, 0);
                sp.transform.position = transform.TransformPoint(pos);

                sp.GetComponent<Renderer>().material.color = 
                    Color.HSVToRGB(1.0f / elementsInRing * i, 1, 1.0f - 0.5f * j / ringnum);
                    //             color hue divided by whole ring,
                    //                                        saturation = 100%,
                    //                                           Intensity - 1.0f at the center and dimming to 0.5f at the edge
                    
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
