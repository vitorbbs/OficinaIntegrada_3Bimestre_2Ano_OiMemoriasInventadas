using UnityEngine;
using System.Collections;

public enum ID_Plataforms
{
    Plataform,
    PlataformDestroyer,
    PlataformWalk,
}

public class Atlas_Plataforms : MonoBehaviour
{
    public static Texture2D globalTexture_Plataforms;
    public static Rect[] rects_Plataforms;
    public static Material globalMaterial_Plataforms;

    private Texture2D[] textures_Plataforms;

    void Awake()
    {
        int numImage = 1000;

        textures_Plataforms = new Texture2D[numImage];

        string[] imageNames = new string[]
	    {           
            "Plataform",
            "PlataformDestroyer",
            "PlataformWalk",
        };

        for (int i = 0; i < imageNames.Length; i++)
        {
            textures_Plataforms[i] = (Texture2D)Resources.Load("Textures/Plataforms/" + imageNames[i].ToString());
        }

        globalTexture_Plataforms = AtlasTexture.Create(this.textures_Plataforms, out rects_Plataforms);

        globalMaterial_Plataforms = new Material((Shader)Resources.Load("Shader/Basic2D"));
        globalMaterial_Plataforms.mainTexture = globalTexture_Plataforms;
    }
}
