using UnityEngine;
using System.Collections;

public enum ID_BackGround
{
    BgMenu,
    BgCreditos,
    BgApresentacao,
    BgInstrucoes,
    BgTransitFase1,
    BgTransitFase2,
    BgTransitFase3,
    BgLogo,
    BgDerrota,    
}

public class Atlas_BackGrounds : MonoBehaviour 
{
    public static Texture2D globalTexture_BackGrounds;
    public static Rect[] rects_BackGrounds;
    public static Material globalMaterial_BackGrounds;

    private Texture2D[] textures_BackGrounds;

    void Awake () 
    {
        int numImage = 1000;

        textures_BackGrounds = new Texture2D[numImage];

	    string[] imageNames = new string[]
	    {
			"BgMenu",
            "BgCreditos",
            "BgApresentacao",
            "BgInstrucoes",
            "BgTransitFase1",
            "BgTransitFase2",
            "BgTransitFase3",
            "BgLogo",
            "BgDerrota",
        };
		
		for(int i = 0; i < imageNames.Length; i++)
		{
            textures_BackGrounds[i] = (Texture2D)Resources.Load("Textures/BackGrounds/" + imageNames[i].ToString());	
		}

        globalTexture_BackGrounds = AtlasTexture.Create(this.textures_BackGrounds, out rects_BackGrounds);

        globalMaterial_BackGrounds = new Material((Shader)Resources.Load("Shader/Basic2D"));
        globalMaterial_BackGrounds.mainTexture = globalTexture_BackGrounds;
	}
}
