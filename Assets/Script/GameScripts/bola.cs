using UnityEngine;
using System.Collections;

public class bola : MonoBehaviour {

    private int changeside;
	public GameObject prefab;
	private GameObject linha;
	private int aumento;
	private int controle;
	private int quant;
	public GameObject[] quantarray;

	void Start () {

        aumento = 0;
        

		for (int linhas = 0; linhas <= aumento; linhas++) {
			linha = (GameObject) Instantiate(prefab, new Vector3(-1.3f, linhas-controle,0), Quaternion.identity);
		}
		//quantarray = GameObject.FindGameObjectsWithTag("Blocos");

		

        changeside = Random.Range(-1, 2);

        if (changeside == 0) {
            changeside = Random.Range(-1, 2);
        }
        
		rigidbody2D.velocity = new Vector2(5 * changeside, 6);
       
	}

    
	
	void Update () {

		quantarray = GameObject.FindGameObjectsWithTag("Blocos");
        quant = quantarray.Length;
        controle = aumento - 1;
		if (quant == 0)
		{
            aumento++;

            for (int linhas = 0; linhas <= aumento; linhas++)
            {
                linha = (GameObject)Instantiate(prefab, new Vector3(-1.3f, linhas - (aumento - 1), 0), Quaternion.identity);
            }
		}
		Debug.Log (quant);

	}
}
