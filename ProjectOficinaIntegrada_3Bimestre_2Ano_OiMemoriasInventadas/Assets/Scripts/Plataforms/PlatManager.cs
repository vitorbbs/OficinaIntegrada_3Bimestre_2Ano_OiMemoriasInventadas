using UnityEngine;
using System.Collections;

public class PlatManager : MonoBehaviour 
{
    GameObject PlataformDestroyer, Plataform, PlataformWalk;
	int quantPlataformDestroyer,quantPlataform,quantPlataformWalk;

    void Start()
    {
        switch(this.name)
        {
            case "Game":        
                quantPlataform = 35;
                Plataform = (GameObject)Resources.Load("Prefab/Plataform");

                    for (int i = 0; i < quantPlataform; i++)
                    {
                        Instantiate(Plataform, new Vector3(Random.Range(-10, 10), -89.8f + i * 5, -1), Quaternion.identity);
                    }
                    break;


            case "Game2":
                quantPlataform = 25;
                Plataform = (GameObject)Resources.Load("Prefab/Plataform");

                    for (int i = 0; i < quantPlataform; i++)
                    {
                        Instantiate(Plataform, new Vector3(Random.Range(-10, 10), -89.8f + i * 5, -1), Quaternion.identity);
                    }

                quantPlataformDestroyer = 23;
                PlataformDestroyer = (GameObject)Resources.Load("Prefab/PlataformDestroyer");

                    for (int i = 0; i < quantPlataformDestroyer; i++)
                    {
                        Instantiate(PlataformDestroyer, new Vector3(Random.Range(-10, 10), -32.3f + i * 5, -1), Quaternion.identity);
                    }
                    break;


            case "Game3":
                quantPlataform = 12;
                Plataform = (GameObject)Resources.Load("Prefab/Plataform");

                    for (int i = 0; i < quantPlataform; i++)
                    {
                        Instantiate(Plataform, new Vector3(Random.Range(-10, 10), -89.8f + i * 5, -1), Quaternion.identity);
                    }

                quantPlataformDestroyer = 15;
                PlataformDestroyer = (GameObject)Resources.Load("Prefab/PlataformDestroyer");

                    for (int i = 0; i < quantPlataformDestroyer; i++)
                    {
                        Instantiate(PlataformDestroyer, new Vector3(Random.Range(-10, 10), -62 + i * 5, -1), Quaternion.identity);
                    }

                quantPlataformWalk = 11;
                PlataformWalk = (GameObject)Resources.Load("Prefab/PlataformWalk");

                    for (int i = 0; i < quantPlataformWalk; i++)
                    {
                        Instantiate(PlataformWalk, new Vector3(Random.Range(-10, 10), 0 + i * 5, -1), Quaternion.identity);
                    }                

                    for (int i = 0; i < 1; i++)
                    {
                        Instantiate(PlataformDestroyer, new Vector3(4.235041f, 55, -1), Quaternion.identity);
                        Instantiate(PlataformDestroyer, new Vector3(-4.235041f, 55, -1), Quaternion.identity);
                    }
                
                    for (int i = 0; i < 6; i++)
                    {
                        Instantiate(PlataformWalk, new Vector3(Random.Range(-10, 10), 59.72736f + i * 5, -1), Quaternion.identity);
                    }
                    break;
        }
    }

	void Update () 
    {
		
	}
}
