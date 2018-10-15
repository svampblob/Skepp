using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour
{
    public float Rotationspeed;
    public Color Rightcolor;
    public Color Leftcolor;
    public SpriteRenderer rend;
    public SpriteRenderer rend2;
    public object Rend2 { get; private set; }
    public float Timer;
    public float Rightwarpzone;
    public float Leftwarpzone;
    public float Y;
    public float x;
    public float z;
    public float speed; 
    // Use this for initialization
    void Start()
    {
       //I den här transform.position koden gör så att spelaren börjar på olika ställen i spelet. 
       // Då man använder Random.Rangeg(bla.bla) för att visa att man ska börja olika ställen inom kameran.
        transform.position = new Vector3(Random.Range (10.6f,-10.5f), Random.Range(7,-7));
        //Den här linjen av kåd gör så att spelaren får en hastighet mellan 1 0ch 100 Steps per sekund. 
        speed = Random.Range(1, 100);
    }

    // Update is called once per frame
    void Update()
    {
        // Kåden "(if (Input.GetKey(KeyCode.A))" och dem andra if med input linje kåderna gör så att när spelaren trycker ner en specifik knapp.
        // Som gör i den här kåden att skäppet ändrar färg och roterar mot höger. 
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
        // Den här "transform.Translate koden gör så att skäppet har en vis hastighet under tiden som man spelar. 
        transform.Translate(speed * Time.deltaTime, 0, 0);
        //S knappen gör så att hastigheten divideras med 2 med hastigheten som skeppet har just i den rundan. 
        if (Input.GetKey(KeyCode.S))
        {
        
            transform.Translate(-speed / 2f * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey(KeyCode.Space))
        {
            rend.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        }
        // Här är timern som går up med en sekund från början av spelet och den funkar genom att variablen "Timer" adderas med time.deltatime som är hur nånga sekunder som det tar för programet att klara en fram.S
        Timer += Time.deltaTime;
        Debug.Log(string.Format("{0}", Timer));
        // if transom.position kåden är här för att göra så att spelaren kommer att  "Warpa" runt i nivån, så att man inte kan åka utanför skärmen.
        // Därför har man transform.position.x/y som seger till hur lång på dem orlika axlarna spelaren får gå till och var spelaren åker till när man hen rör dem punkterna.
        if (transform.position.x > 10.6f)
        {
            transform.position = new Vector3(-10.5f, transform.position.y, 5);
        }

        if (transform.position.x < -10.6f)
        {
            transform.position = new Vector3(10.5f, transform.position.y, 5);
        }

        if (transform.position.y > 7)
        {
            transform.position = new Vector3(transform.position.x, -7, 5);
        }

        if (transform.position.y < -7)
        {
            transform.position = new Vector3(transform.position.x, 7, 5);
        }

    }
}
