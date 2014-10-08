using UnityEngine;
using System.Collections;

public enum ID_Animation
{
    Tucano1,
    Tucano2,
    Tucano3,
    Tucano4,
    Tucano5,
    Tucano6,
    TucanoNaArvore, 
}

public class Atlas_Animation : MonoBehaviour
{
    public static Texture2D globalTexture_Animation;
    public static Rect[] rects_Animation;
    public static Material globalMaterial_Animation;

    private Texture2D[] textures_Animation;

    void Awake()
    {
        int numImage = 1000;

        textures_Animation = new Texture2D[numImage];

        string[] imageNames = new string[]
	    {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
        };

        for (int i = 0; i < imageNames.Length; i++)
        {
            textures_Animation[i] = (Texture2D)Resources.Load("Textures/Animation/" + imageNames[i].ToString());
        }

        globalTexture_Animation = AtlasTexture.Create(this.textures_Animation, out rects_Animation);

        globalMaterial_Animation = new Material((Shader)Resources.Load("Shader/Basic2D"));
        globalMaterial_Animation.mainTexture = globalTexture_Animation;
    }
}
