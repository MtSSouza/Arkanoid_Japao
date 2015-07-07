using UnityEngine;
using System.Collections;

public class PoU : MonoBehaviour {

    public static bool teste = false;
    public static bool teste2 = false;

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.tag == "player")
        {
            if (BlocosColission.powerup <= 5)
            {
                teste = true;
                Debug.Log("1");
            }

            if (BlocosColission.powerup > 5 && BlocosColission.powerup <= 10)
            {
                teste2 = true;
                Debug.Log("2");
            }
        }
        
    }

   
}
