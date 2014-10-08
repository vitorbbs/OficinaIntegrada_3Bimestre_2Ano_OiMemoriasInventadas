using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
    int id;
    bool GiradinhaD = true, GiradinhaE = false, GiradinhaT = false;
    Vector3 mouse;

    float girada = 1.5f;

    

    void Awake()
    {
        switch (this.gameObject.name)
        {
            case "BtJogar":
                this.id = (int)ID_Buttons.BtJogar1;
                this.transform.position = new Vector3(-6.36962f, -1.07593f, -1.2f);
                break;
            
            case "BtCreditos":
                this.id = (int)ID_Buttons.BtCreditos1;
                this.transform.position = new Vector3(-6.286057f, -3.583725f, -1.2f);
                break;

            case "BtVoltar":
                this.id = (int)ID_Buttons.BtVoltar1;
                this.transform.position = new Vector3(8.6f, -6, -1);
                break;

            case "BtVoltarInstrucoes":
                this.id = (int)ID_Buttons.BtVoltar1;
                this.transform.position = new Vector3(6.389559f, -6, -1);
                break;

            case "BtInstruções":
                this.id = (int)ID_Buttons.BtInstrucoes1;
                this.transform.position = new Vector3(-6.003694f, -5.802855f, -1);
                break;

            case "BtTentarNovamente":
                this.id = (int)ID_Buttons.BtInstrucoes1;
                this.transform.position = new Vector3(-6.003694f, -5.802855f, -1);
                break;

            case "BtVoltarCreditos":
                this.id = (int)ID_Buttons.BtCreditos1;
                this.transform.position = new Vector3(-0.8146839f, -7.802574f, -1);
                break;
        }
    }

    void Start()
    {
        AddComponents();
        GetComponents();      
    }

    void Update()
    {
        Giradinha();       
        TrocarID();
    }

    void Giradinha()
    {
        if (GiradinhaT)
        {            
            if (GiradinhaD)
            {
                transform.Rotate(0, 0, girada);
                if (transform.rotation.z >= 0.15f)
                {
                    GiradinhaD = false;
                    GiradinhaE = true;
                }
            }
            if (GiradinhaE)
            {
                transform.Rotate(0, 0, -girada);
                if (transform.rotation.z <= -0.15f)
                {
                    GiradinhaD = true;
                    GiradinhaE = false;
                }
            }
        }
    }

    void OnMouseDown()
    {
        switch (gameObject.name)
        {
            case "BtJogar":
                StartCoroutine(GoToTrasitGame1());
                break;

            case "BtCreditos":
                StartCoroutine(GoToCreditos());
                break;

            case "BtVoltarCreditos":
                StartCoroutine(GoToCreditos());
                break;

            case "BtVoltar":
                StartCoroutine(GoToMenu());
                break;

            case "BtVoltarInstrucoes":
                StartCoroutine(GoToMenu());
                break;

            case "BtInstruções":
                StartCoroutine(GoToIntrucoes());
                break;

            case "BtTentarNovamente":
                StartCoroutine(GoToTrasitGame1());
                break;
        }
    }

    void OnMouseOver()
    {
        switch (this.name)
        {
            case "BtJogar":
                this.id = (int)ID_Buttons.BtJogar2;
                GiradinhaT = true; 
                break;

            case "BtCreditos":
                this.id = (int)ID_Buttons.BtCreditos2;
                GiradinhaT = true; 
                break;

            case "BtVoltarCreditos":
                this.id = (int)ID_Buttons.BtCreditos2;
                break;

            case "BtVoltar":
                this.id = (int)ID_Buttons.BtVoltar2;
                break;

            case "BtVoltarInstrucoes":
                this.id = (int)ID_Buttons.BtVoltar2;
                break;

            case "BtInstruções":
                this.id = (int)ID_Buttons.BtInstrucoes2;
                GiradinhaT = true; 
                break;

            case "BtTentarNovamente":
                this.id = (int)ID_Buttons.BtTentarNovamente;
                GiradinhaT = true;
                break;
        }
    }

    void OnMouseExit()
    {
        switch (this.name)
        {
            case "BtJogar":
                this.id = (int)ID_Buttons.BtJogar1;
                GiradinhaT = false;
                break;

            case "BtCreditos":
                this.id = (int)ID_Buttons.BtCreditos1;
                GiradinhaT = false;
                break;

            case "BtVoltarCreditos":
                this.id = (int)ID_Buttons.BtCreditos1;
                break;

            case "BtVoltar":
                this.id = (int)ID_Buttons.BtVoltar1;
                break;

            case "BtVoltarInstrucoes":
                this.id = (int)ID_Buttons.BtVoltar1;
                break;

            case "BtInstruções":
                this.id = (int)ID_Buttons.BtInstrucoes1;
                GiradinhaT = false;
                break;

            case "BtTentarNovamente":
                this.id = (int)ID_Buttons.BtTentarNovamente;
                GiradinhaT = false;
                break;
        }
    }

    void GetComponents()
    {
        switch (this.gameObject.name)
        {
            case "BtJogar":
                Mesh mesh = Quad.Create(2.6f, 1.3f);

                this.gameObject.GetComponent<MeshRenderer>().material = Atlas_Buttons.globalMaterial_Buttons;
                this.gameObject.GetComponent<MeshFilter>().mesh = mesh;
                this.gameObject.GetComponent<BoxCollider>().size = new Vector3(4.3f, 2.25f, 1);
                break;

            case "BtCreditos":
                Mesh mesh2 = Quad.Create(2.6f, 1.3f);

                this.gameObject.GetComponent<MeshRenderer>().material = Atlas_Buttons.globalMaterial_Buttons;
                this.gameObject.GetComponent<MeshFilter>().mesh = mesh2;
                this.gameObject.GetComponent<BoxCollider>().size = new Vector3(4.3f, 2.25f, 1);
                break;

            case "BtVoltarCreditos":
                Mesh mesh7 = Quad.Create(2.6f, 1.3f);

                this.gameObject.GetComponent<MeshRenderer>().material = Atlas_Buttons.globalMaterial_Buttons;
                this.gameObject.GetComponent<MeshFilter>().mesh = mesh7;
                this.gameObject.GetComponent<BoxCollider>().size = new Vector3(4.3f, 2.25f, 1);
                break;

            case "BtVoltar":
                Mesh mesh3 = Quad.Create(2.6f, 1.3f);

                this.gameObject.GetComponent<MeshRenderer>().material = Atlas_Buttons.globalMaterial_Buttons;
                this.gameObject.GetComponent<MeshFilter>().mesh = mesh3;
                this.gameObject.GetComponent<BoxCollider>().size = new Vector3(4.3f, 2.25f, 1);
                break;

            case "BtVoltarInstrucoes":
                Mesh mesh4 = Quad.Create(2.3f, 1f);

                this.gameObject.GetComponent<MeshRenderer>().material = Atlas_Buttons.globalMaterial_Buttons;
                this.gameObject.GetComponent<MeshFilter>().mesh = mesh4;
                this.gameObject.GetComponent<BoxCollider>().size = new Vector3(4.3f, 2.25f, 1);
                break;

            case "BtInstruções":
                Mesh mesh5 = Quad.Create(2.6f, 1.3f);

                this.gameObject.GetComponent<MeshRenderer>().material = Atlas_Buttons.globalMaterial_Buttons;
                this.gameObject.GetComponent<MeshFilter>().mesh = mesh5;
                this.gameObject.GetComponent<BoxCollider>().size = new Vector3(4.3f, 2.25f, 1);
                break;

            case "BtTentarNovamente":
                Mesh mesh6 = Quad.Create(2.6f, 1.3f);

                this.gameObject.GetComponent<MeshRenderer>().material = Atlas_Buttons.globalMaterial_Buttons;
                this.gameObject.GetComponent<MeshFilter>().mesh = mesh6;
                this.gameObject.GetComponent<BoxCollider>().size = new Vector3(4.3f, 2.25f, 1);
                break;
        }

        
    }

    void AddComponents()
    {
        this.gameObject.AddComponent<MeshRenderer>();
        this.gameObject.AddComponent<MeshFilter>();
        this.gameObject.AddComponent<BoxCollider>();
    }

    void TrocarID()
    {
        this.gameObject.GetComponent<MeshFilter>().mesh.uv = new Vector2[]
        {
            new Vector2(Atlas_Buttons.rects_Buttons[this.id].xMin, Atlas_Buttons.rects_Buttons[this.id].yMax),
            new Vector2(Atlas_Buttons.rects_Buttons[this.id].xMax, Atlas_Buttons.rects_Buttons[this.id].yMax),
            new Vector2(Atlas_Buttons.rects_Buttons[this.id].xMax, Atlas_Buttons.rects_Buttons[this.id].yMin),
            new Vector2(Atlas_Buttons.rects_Buttons[this.id].xMin, Atlas_Buttons.rects_Buttons[this.id].yMin),
        };
    }
       
    IEnumerator GoToCreditos ()
    {
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("Creditos");
    }

    IEnumerator GoToMenu()
    {
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("Menu");
    }

    IEnumerator GoToIntrucoes()
    {
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("Instrucoes");
    }

    IEnumerator GoToTrasitGame1()
    {
        FadeOut.endFade = true;
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("TransitFase1");
    }

    IEnumerator GiradinhaTeste()
    {
        yield return new WaitForSeconds(0);
        GiradinhaT = true;
        GiradinhaT = false;
        StartCoroutine(GiradinhaTeste());
    }
}