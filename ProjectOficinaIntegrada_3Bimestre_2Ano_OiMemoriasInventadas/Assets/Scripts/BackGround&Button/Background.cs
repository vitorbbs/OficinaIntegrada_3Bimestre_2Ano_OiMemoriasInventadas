using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour
{
    int id;
    float aspectRatio = Screen.width / (float)Screen.height;



    void Awake()
    {
        switch (this.name)
        {
            case "BgMenu":
                this.id = (int)ID_BackGround.BgMenu;
                break;

            case "BgCreditos":
                this.id = (int)ID_BackGround.BgCreditos;
                break;

            case "Apresentação":
                this.id = (int)ID_BackGround.BgApresentacao;
                break;

            case "Instrucoes":
                this.id = (int)ID_BackGround.BgInstrucoes;
                break;

            case "BgGame":
                this.id = (int)ID_Game.BgGame;
                break;

            case "BgGame2":
                this.id = (int)ID_Game.BgGame2;
                break;

            case "BgGame3":
                this.id = (int)ID_Game.BgGame3;
                break;

            case "BgTransitFase1":
                this.id = (int)ID_BackGround.BgTransitFase1;
                break;

            case "BgTransitFase2":
                this.id = (int)ID_BackGround.BgTransitFase2;
                break;

            case "BgTransitFase3":
                this.id = (int)ID_BackGround.BgTransitFase3;
                break;

            case "BgLogo":
                this.id = (int)ID_BackGround.BgLogo;
                break;

            case "BgVitoria":
                this.id = (int)ID_Vitoria.v1;
                break;

            case "BgDerrota":
                this.id = (int)ID_BackGround.BgDerrota;
                break;
        }
    }

    void Start()
    {
        AddComponents();
        GetComponents();

        if (this.name == "Apresentação")
        {
            StartCoroutine(GoToMenu());
        }
        if (this.name == "BgTransitFase1")
        {
            StartCoroutine(GoToGame());
        }
        if (this.name == "BgTransitFase2")
        {
            StartCoroutine(GoToGame2());
        }
        if (this.name == "BgTransitFase3")
        {
            StartCoroutine(GoToGame3());
        }
        if (this.name == "BgLogo")
        {
            StartCoroutine(GoToApresentacao());
        }
        if (this.name == "BgVitoria")
        {
            StartCoroutine(AnimationVitoria(0.1f));
        }
    }

    void Update()
    {
        DrawMesh();
    }

    void GetComponents()
    {
        if (this.name == "BgGame" || this.name == "BgGame2" || this.name == "BgGame3")
        {
            Mesh mesh = Quad.Create(Camera.main.orthographicSize * aspectRatio, Camera.main.orthographicSize * 10);

            this.gameObject.GetComponent<MeshRenderer>().material = Atlas_Game.globalMaterial_Game;
            this.gameObject.GetComponent<MeshFilter>().mesh = mesh;
        }
        else if (this.name == "BgVitoria")
        {
            Mesh mesh = Quad.Create(Camera.main.orthographicSize * aspectRatio, Camera.main.orthographicSize);

            this.gameObject.GetComponent<MeshRenderer>().material = Atlas_Vitoria.globalMaterial_Vitoria;
            this.gameObject.GetComponent<MeshFilter>().mesh = mesh;
        }

        else
        {
            Mesh mesh = Quad.Create(Camera.main.orthographicSize * aspectRatio, Camera.main.orthographicSize);

            this.gameObject.GetComponent<MeshRenderer>().material = Atlas_BackGrounds.globalMaterial_BackGrounds;
            this.gameObject.GetComponent<MeshFilter>().mesh = mesh;
        }

    }

    void AddComponents()
    {
        this.gameObject.AddComponent<MeshRenderer>();
        this.gameObject.AddComponent<MeshFilter>();
    }

    void DrawMesh()
    {
        if (this.name == "BgGame" || this.name == "BgGame2" || this.name == "BgGame3")
        {
            this.gameObject.GetComponent<MeshFilter>().mesh.uv = new Vector2[]
            {
                new Vector2(Atlas_Game.rects_Game[this.id].xMin, Atlas_Game.rects_Game[this.id].yMax),
                new Vector2(Atlas_Game.rects_Game[this.id].xMax, Atlas_Game.rects_Game[this.id].yMax),
                new Vector2(Atlas_Game.rects_Game[this.id].xMax, Atlas_Game.rects_Game[this.id].yMin),
                new Vector2(Atlas_Game.rects_Game[this.id].xMin, Atlas_Game.rects_Game[this.id].yMin),
            };
        }
        else if (this.name == "BgVitoria")
        {
            this.gameObject.GetComponent<MeshFilter>().mesh.uv = new Vector2[]
            {
                new Vector2(Atlas_Vitoria.rects_Vitoria[this.id].xMin, Atlas_Vitoria.rects_Vitoria[this.id].yMax),
                new Vector2(Atlas_Vitoria.rects_Vitoria[this.id].xMax, Atlas_Vitoria.rects_Vitoria[this.id].yMax),
                new Vector2(Atlas_Vitoria.rects_Vitoria[this.id].xMax, Atlas_Vitoria.rects_Vitoria[this.id].yMin),
                new Vector2(Atlas_Vitoria.rects_Vitoria[this.id].xMin, Atlas_Vitoria.rects_Vitoria[this.id].yMin),
            };
        }
        else
        {
            this.gameObject.GetComponent<MeshFilter>().mesh.uv = new Vector2[]
            {
                new Vector2(Atlas_BackGrounds.rects_BackGrounds[this.id].xMin, Atlas_BackGrounds.rects_BackGrounds[this.id].yMax),
                new Vector2(Atlas_BackGrounds.rects_BackGrounds[this.id].xMax, Atlas_BackGrounds.rects_BackGrounds[this.id].yMax),
                new Vector2(Atlas_BackGrounds.rects_BackGrounds[this.id].xMax, Atlas_BackGrounds.rects_BackGrounds[this.id].yMin),
                new Vector2(Atlas_BackGrounds.rects_BackGrounds[this.id].xMin, Atlas_BackGrounds.rects_BackGrounds[this.id].yMin),
            };
        }
    }

    IEnumerator GoToMenu()
    {
        yield return new WaitForSeconds(3f);
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("Menu");
    }

    IEnumerator GoToGame()
    {
        yield return new WaitForSeconds(3f);
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("Game");
    }

    IEnumerator GoToGame2()
    {
        yield return new WaitForSeconds(3f);
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("Game2");
    }

    IEnumerator GoToGame3()
    {
        yield return new WaitForSeconds(3f);
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("Game3");
    }

    IEnumerator GoToApresentacao()
    {
        yield return new WaitForSeconds(3f);
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("Apresentacao");
    }

    IEnumerator AnimationVitoria(float t)
    {
        #region Cuidado_MuitaGambiarra!
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v3;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v5;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v7;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v9;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v11;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v13;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v15;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v17;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v19;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v21;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v23;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v25;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v27;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v29;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v31;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v33;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v35;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v37;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v39;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v41;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v43;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v45;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v47;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v49;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v51;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v53;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v55;
        yield return new WaitForSeconds(t);
        this.id = (int)ID_Vitoria.v57;
        #endregion
    }
}