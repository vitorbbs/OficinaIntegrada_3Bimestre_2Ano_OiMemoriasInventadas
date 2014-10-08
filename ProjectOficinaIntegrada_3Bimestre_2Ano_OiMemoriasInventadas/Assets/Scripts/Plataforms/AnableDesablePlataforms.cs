using UnityEngine;
using System.Collections;

public class AnableDesablePlataforms : MonoBehaviour
{
    GameObject player;
    bool test;

	void Start () 
    {
        StartCoroutine(GetPlayer());
	}

    void Update () 
    {
        if (test)
        {
            if (this.transform.position.y < player.transform.position.y - 2)
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = true;
            }
            else if (this.transform.position.y > player.transform.position.y)
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }
	}

    IEnumerator GetPlayer()
    {
        yield return new WaitForSeconds(1);
        player = GameObject.FindGameObjectWithTag("Player");
        test = true;
    }
}
