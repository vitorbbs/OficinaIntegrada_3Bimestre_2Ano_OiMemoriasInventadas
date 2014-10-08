using UnityEngine;
using System.Collections;

public enum ID_Buttons
{
    BtJogar1,
    BtJogar2,
    BtCreditos1,
    BtCreditos2,
    BtVoltar1,
    BtVoltar2,
    BtInstrucoes1,
    BtInstrucoes2,
    BtTentarNovamente,
}

public class Atlas_Buttons : MonoBehaviour
{
    public static Texture2D globalTexture_Buttons;
    public static Rect[] rects_Buttons;
    public static Material globalMaterial_Buttons;

    private Texture2D[] textures_Buttons;

    void Awake()
    {
        int numImage = 1000;

        textures_Buttons = new Texture2D[numImage];

        string[] imageNames = new string[]
	    {
            "BtJogar1",
            "BtJogar2",
            "BtCreditos1",
            "BtCreditos2",
            "BtVoltar1",
            "BtVoltar2",
            "BtInstrucoes1",
            "BtInstrucoes2",
            "BtTentarNovamente",
        };

        for (int i = 0; i < imageNames.Length; i++)
        {
            textures_Buttons[i] = (Texture2D)Resources.Load("Textures/Buttons/" + imageNames[i].ToString());
        }

        globalTexture_Buttons = AtlasTexture.Create(this.textures_Buttons, out rects_Buttons);

        globalMaterial_Buttons = new Material((Shader)Resources.Load("Shader/Basic2D"));
        globalMaterial_Buttons.mainTexture = globalTexture_Buttons;
    }
}
