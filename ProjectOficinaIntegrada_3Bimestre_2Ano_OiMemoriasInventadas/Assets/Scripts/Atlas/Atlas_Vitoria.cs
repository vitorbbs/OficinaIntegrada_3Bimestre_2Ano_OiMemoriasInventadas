using UnityEngine;
using System.Collections;

public enum ID_Vitoria
{
    v1, v3, v5, v7, v9, v11, v13, v15, v17, v19, v21, v23, v25, v27, v29,
    v31, v33, v35, v37, v39, v41, v43, v45, v47, v49, v51, v53, v55, v57, 
}

public class Atlas_Vitoria : MonoBehaviour
{
    public static Texture2D globalTexture_Vitoria;
    public static Rect[] rects_Vitoria;
    public static Material globalMaterial_Vitoria;

    private Texture2D[] textures_Vitoria;

    void Awake()
    {
        int numImage = 1000;

        textures_Vitoria = new Texture2D[numImage];

        string[] imageNames = new string[]
	    {
            "1", "3", "5", "7", "9", "11", "13", "15", "17", "19", "21", "23", "25", "27", "29",
            "31", "33", "35", "37", "39", "41", "43", "45", "47", "49", "51", "53", "55", "57",
        };

        for (int i = 0; i < imageNames.Length; i++)
        {
            textures_Vitoria[i] = (Texture2D)Resources.Load("Textures/Vitoria/" + imageNames[i].ToString());
        }

        globalTexture_Vitoria = AtlasTexture.Create(this.textures_Vitoria, out rects_Vitoria);

        globalMaterial_Vitoria = new Material((Shader)Resources.Load("Shader/Basic2D"));
        globalMaterial_Vitoria.mainTexture = globalTexture_Vitoria;
    }
}
