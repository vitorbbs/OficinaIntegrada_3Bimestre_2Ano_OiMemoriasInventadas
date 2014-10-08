using UnityEngine;
using System.Collections;

public class TucanoMenu : MonoBehaviour
{
    int id;
    float speed;
    int count = 0;
    bool Voar = true;
    bool Parar;
    bool ee = true;

    void Awake()
    {
        this.id = (int)ID_Animation.Tucano1;
        this.transform.position = new Vector3(16, 1.49f, -2);
    }

    void Start()
    {
        AddComponents();
        GetComponents();
        StartCoroutine(Voando(0.08f));
    }

    void FixedUpdate()
    {
        TrocarID();


        if (Voar && ee) transform.Translate(-0.05f, 0, 0);

        if (Voar)
        {
            transform.Translate(-0.05f, 0, 0);

            if (ee == false)
            {
                transform.Translate(0, 0f, 0);
            }            
        }

        if (this.transform.position.x <= 7.4f && ee) Voar = false;

        if (this.transform.position.x <= -6.883786f && ee == false) Voar = false;
    }

    void GetComponents()
    {
        Mesh mesh2 = Quad.Create(2, 2);

        this.gameObject.GetComponent<MeshRenderer>().material = Atlas_Animation.globalMaterial_Animation;
        this.gameObject.GetComponent<MeshFilter>().mesh = mesh2;
    }

    void AddComponents()
    {
        this.gameObject.AddComponent<MeshRenderer>();
        this.gameObject.AddComponent<MeshFilter>();
    }

    void TrocarID()
    {
        this.gameObject.GetComponent<MeshFilter>().mesh.uv = new Vector2[]
        {
            new Vector2(Atlas_Animation.rects_Animation[this.id].xMin, Atlas_Animation.rects_Animation[this.id].yMax),
            new Vector2(Atlas_Animation.rects_Animation[this.id].xMax, Atlas_Animation.rects_Animation[this.id].yMax),
            new Vector2(Atlas_Animation.rects_Animation[this.id].xMax, Atlas_Animation.rects_Animation[this.id].yMin),
            new Vector2(Atlas_Animation.rects_Animation[this.id].xMin, Atlas_Animation.rects_Animation[this.id].yMin),
        };
    }

    IEnumerator Voando(float vel)
    {
        if (Voar == true)
        {
            this.id = (int)ID_Animation.Tucano1;
            yield return new WaitForSeconds(vel);
            this.id = (int)ID_Animation.Tucano2;
            yield return new WaitForSeconds(vel);
            this.id = (int)ID_Animation.Tucano3;
            yield return new WaitForSeconds(vel);
            this.id = (int)ID_Animation.Tucano4;
            yield return new WaitForSeconds(vel);
            this.id = (int)ID_Animation.Tucano3;
            yield return new WaitForSeconds(vel);
            this.id = (int)ID_Animation.Tucano2;
            yield return new WaitForSeconds(vel);
            StartCoroutine(Voando(vel));
        }
        else
        {
            StartCoroutine(Pousar(vel / 2));
        }
    }

    IEnumerator Pousar(float vel)
    {
        this.id = (int)ID_Animation.Tucano1;
        yield return new WaitForSeconds(vel);
        this.id = (int)ID_Animation.Tucano2;
        yield return new WaitForSeconds(vel);
        this.id = (int)ID_Animation.Tucano3;
        yield return new WaitForSeconds(vel);
        this.id = (int)ID_Animation.Tucano4;
        yield return new WaitForSeconds(vel);
        this.id = (int)ID_Animation.Tucano5;
        yield return new WaitForSeconds(vel);
        this.id = (int)ID_Animation.Tucano6;
        yield return new WaitForSeconds(vel);
        this.id = (int)ID_Animation.TucanoNaArvore;
        yield return new WaitForSeconds(5);
        StartCoroutine(RetomarVoo());
    }

    IEnumerator RetomarVoo()
    {
        yield return new WaitForSeconds(4);
        Voar = true;
        ee = false;
        StartCoroutine(Voando(0.08f));
    }
}