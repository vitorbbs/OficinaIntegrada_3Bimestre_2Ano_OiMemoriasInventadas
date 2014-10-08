using UnityEngine;
using System.Collections;

public class PlataformDestroyer : MonoBehaviour
{
    int id = (int)ID_Plataforms.PlataformDestroyer;
    float aspectRatio = Screen.width / (float)Screen.height;

    void Start()
    {
        EditComponets();     
    }

    void Update()
    {
        DrawMesh();
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

    void OnCollisionEnter()
    {
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}