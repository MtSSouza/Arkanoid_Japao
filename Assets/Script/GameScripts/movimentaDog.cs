using UnityEngine;
using System.Collections;

public class movimentaDog : MonoBehaviour {

    private int velo;
    private float xminimo, xmaximo;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(0, -4.41f, 0);
        velo = 7;

        xminimo = -6.5f;
        xmaximo = 6.5f;

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) 
        {
            transform.position -= new Vector3(velo*Time.deltaTime, 0, 0);        
        }

        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) 
        {
            transform.position += new Vector3(velo*Time.deltaTime, 0, 0);
        }

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, xminimo, xmaximo),
            transform.position.y
            );

	}
}
