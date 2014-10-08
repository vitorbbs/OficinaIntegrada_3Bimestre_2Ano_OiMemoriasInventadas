using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    int id = (int)ID_Player.Player;
    float speed = 0.3f;
    float aspectRatio = Screen.width / (float)Screen.height;
    bool pulei = false;
    int CameraCount = 0;
    

    void Awake()
    {
        this.transform.position = new Vector3(0, -91, -1);
    }

    void Start()
    {
        this.tag = "Player";
        Components();
        EditComponents();
    }

    void Update()
    {        
        Movimentation();
        BlockScreen();
        TrocaID();
    }

    void EditComponents()
    {
        Mesh mesh = Quad.Create(1,1);

        this.gameObject.GetComponent<MeshRenderer>().material = Atlas_Player.globalMaterial_Player;
        this.gameObject.GetComponent<MeshFilter>().mesh = mesh;
        this.gameObject.GetComponent<BoxCollider>().center = new Vector3(0.11f, -0.43f, 1);
        this.gameObject.GetComponent<BoxCollider>().size = new Vector3(1.3f, 0.89f, 1);       
        this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
    }

    void Components()
    {
        this.gameObject.AddComponent<Rigidbody>();
        this.gameObject.AddComponent<MeshRenderer>();
        this.gameObject.AddComponent<MeshFilter>();
        this.gameObject.AddComponent<BoxCollider>();
    }

    void Movimentation()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.id = (int)ID_Player.Player2;
            this.gameObject.GetComponent<BoxCollider>().center = new Vector3(-0.09f, -0.43f, 1);
            transform.Translate(-speed,0,0);            
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.id = (int)ID_Player.Player;
            this.gameObject.GetComponent<BoxCollider>().center = new Vector3(0.11f, -0.43f, 1);
            transform.Translate(speed, 0, 0);
        }
    }

    void BlockScreen()
    {
        if (this.transform.position.x >= Camera.main.orthographicSize * aspectRatio)
        {
            this.transform.position = new Vector3(-Camera.main.orthographicSize * aspectRatio, this.transform.position.y, this.transform.position.z);
        }
        else if (this.transform.position.x <= -Camera.main.orthographicSize * aspectRatio)
        {
            this.transform.position = new Vector3(Camera.main.orthographicSize * aspectRatio, this.transform.position.y, this.transform.position.z);
        }
    }

    void PlayerDying()
    {
        if (this.transform.position.y <= Camera.main.orthographicSize)
        {
            
        }
    }

    void TrocaID()
    {
        this.gameObject.GetComponent<MeshFilter>().mesh.uv = new Vector2[]
        {
            new Vector2(Atlas_Player.rects_Player[this.id].xMin, Atlas_Player.rects_Player[this.id].yMax),
            new Vector2(Atlas_Player.rects_Player[this.id].xMax, Atlas_Player.rects_Player[this.id].yMax),
            new Vector2(Atlas_Player.rects_Player[this.id].xMax, Atlas_Player.rects_Player[this.id].yMin),
            new Vector2(Atlas_Player.rects_Player[this.id].xMin, Atlas_Player.rects_Player[this.id].yMin),
        };
    }

    public Vector3 MyPosition()
    {
        return transform.position;
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "Derrota")
        {
            StartCoroutine(GotoDerrota());
        }

        if (c.gameObject.name == "vitoria1")
        {
            StartCoroutine(GotoVitoria1());
        }

        if (c.gameObject.name == "vitoria2")
        {
            StartCoroutine(GotoVitoria2());
        }

        if (c.gameObject.name == "vitoria3")
        {
            StartCoroutine(GotoGanhou());
        }

        if (c.gameObject.tag == "PlataformWalk")
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * 1150);
        }

        if (c.gameObject.tag == "Plataform")
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * 1150);
        }

        if (c.gameObject.tag == "PlataformDestroyer")
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * 1150);
        }
    }

    IEnumerator GotoVitoria1()
    {
        yield return new WaitForSeconds(1);
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("TransitFase2");
    }

    IEnumerator GotoVitoria2()
    {
        yield return new WaitForSeconds(1);
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("TransitFase3");
    }

    IEnumerator GotoGanhou()
    {
        yield return new WaitForSeconds(1);
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("Vitoria");
    }

    IEnumerator GotoDerrota()
    {
        yield return new WaitForSeconds(1);
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("Derrota");
    }
}