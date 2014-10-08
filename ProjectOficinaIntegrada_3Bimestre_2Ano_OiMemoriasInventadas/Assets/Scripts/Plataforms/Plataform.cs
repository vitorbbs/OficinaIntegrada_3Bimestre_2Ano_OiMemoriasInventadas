using UnityEngine;
using System.Collections;

public class Plataform : MonoBehaviour
{
    int id = (int)ID_Plataforms.Plataform;
    float aspectRatio = Screen.width / (float)Screen.height;
    GameObject can;

    void Start()
    {
        EditComponets();
        can = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        DrawMesh();

        if (this.transform.position.y < can.transform.position.y - 11)
        {
            Destroy(this.gameObject);
        }
    }

    void EditComponets()
    {
        Mesh mesh = Quad.Create(1, 2);

        this.gameObject.GetComponent<MeshRenderer>().material = Atlas_Plataforms.globalMaterial_Plataforms;
        this.gameObject.GetComponent<MeshFilter>().mesh = mesh;
    }

    void DrawMesh()
    {
        this.gameObject.GetComponent<MeshFilter>().mesh.uv = new Vector2[]
        {
            new Vector2(Atlas_Plataforms.rects_Plataforms[this.id].xMin, Atlas_Plataforms.rects_Plataforms[this.id].yMax),
            new Vector2(Atlas_Plataforms.rects_Plataforms[this.id].xMax, Atlas_Plataforms.rects_Plataforms[this.id].yMax),
            new Vector2(Atlas_Plataforms.rects_Plataforms[this.id].xMax, Atlas_Plataforms.rects_Plataforms[this.id].yMin),
            new Vector2(Atlas_Plataforms.rects_Plataforms[this.id].xMin, Atlas_Plataforms.rects_Plataforms[this.id].yMin),
        };
    }
}