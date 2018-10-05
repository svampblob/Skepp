using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour {
    public float Rotationspeed;
    public Color Rightcolor;
    public Color Leftcolor;
    public SpriteRenderer rend;
    public SpriteRenderer rend2;
    public object Rend2 { get; private set; }
    public float Timer;  

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, -Rotationspeed * Time.deltaTime);
            rend.color = Leftcolor;
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, Rotationspeed * Time.deltaTime);
            rend.color = Rightcolor;
        }

        transform.Translate(10f * Time.deltaTime,0,0);
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-5f * Time.deltaTime,0,0); 

        }

        Timer += Time.deltaTime;
        Debug.Log(string.Format("{0}", Timer));
    }
}
