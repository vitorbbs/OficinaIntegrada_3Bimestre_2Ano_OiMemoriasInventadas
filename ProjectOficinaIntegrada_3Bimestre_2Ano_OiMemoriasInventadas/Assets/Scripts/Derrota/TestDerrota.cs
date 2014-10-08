using UnityEngine;
using System.Collections;

public class TestDerrota : MonoBehaviour
{
    Player player;
    bool seguir;

    void Start()
    {
        StartCoroutine(SeguirPlayer());
    }

    void Update()
    {
        if (seguir == true)
        {
            var y = player.MyPosition().y;
            if (y > this.transform.position.y + 11 && this.transform.position.y < 83)
            {
                this.transform.position = new Vector3(this.transform.position.x, y - 11, this.transform.position.z);
            }
        }
    }

    IEnumerator SeguirPlayer()
    {
        yield return new WaitForSeconds(1);
        player = GameObject.Find("Player").GetComponent<Player>();
        seguir = true;
    }
}