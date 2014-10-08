using UnityEngine;
using System.Collections;

public enum ID_Player
{
    Player,
    Player2,
}

public class Atlas_Player : MonoBehaviour
{
    public static Texture2D globalTexture_Player;
    public static Rect[] rects_Player;
    public static Material globalMaterial_Player;

    private Texture2D[] textures_Player;

    void Awake()
    {
        int numImage = 1000;

        textures_Player = new Texture2D[numImage];

        string[] imageNames = new string[]
	    {
            "Player",
            "Player2",
        };

        for (int i = 0; i < imageNames.Length; i++)
        {
            textures_Player[i] = (Texture2D)Resources.Load("Textures/Player/" + imageNames[i].ToString());
        }

        globalTexture_Player = AtlasTexture.Create(this.textures_Player, out rects_Player);

        globalMaterial_Player = new Material((Shader)Resources.Load("Shader/Basic2D"));
        globalMaterial_Player.mainTexture = globalTexture_Player;
    }
}
