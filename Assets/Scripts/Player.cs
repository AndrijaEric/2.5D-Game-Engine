using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed;
    public float shootSpeed;

    public Sprite Front;
    public Sprite Right;
    public Sprite Back;
    public Sprite Left;

    public GameObject Orb;

    // Use this for initialization
    void Start () {
        speed = 4.5F;
        shootSpeed = 250F;
    }
	
	// Update is called once per frame
	void Update () {

        //Movement
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.up * speed * Time.deltaTime);
            this.GetComponent<SpriteRenderer>().sprite = Back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);
            this.GetComponent<SpriteRenderer>().sprite = Left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.down * speed * Time.deltaTime);
            this.GetComponent<SpriteRenderer>().sprite = Front;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);
            this.GetComponent<SpriteRenderer>().sprite = Right;
        }

        //Firing
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Orb_Spawn = Instantiate(Orb, this.transform.position, Quaternion.identity) as GameObject;
            Orb_Spawn.GetComponent<Rigidbody2D>().AddForce(Vector2.up * shootSpeed, ForceMode2D.Force);
            Orb_Spawn = null;
        }
    }
}
