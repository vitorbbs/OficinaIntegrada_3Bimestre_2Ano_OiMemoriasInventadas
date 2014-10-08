using UnityEngine;
using System.Collections;

public class PlataformWalk : MonoBehaviour
{
    int id = (int)ID_Plataforms.PlataformWalk;
    float aspectRatio = Screen.width / (float)Screen.height;
    float speed ;

    void Awake()
    {
        speed = Random.Range(1, 3);
        if (speed == 2)
            speed = 0.1f;
        else
            speed = -0.1f;
    }

    void Start()
    {
        EditComponets();
    }

    void FixedUpdate()
    {
        DrawMesh();
        PlataformLimit();

        transform.Translate(speed, 0, 0);        
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

    void PlataformLimit()
    {
        if (transform.position.x >= 10f || transform.position.x <= -10f)
            this.speed *= -1;            
    }
} 

