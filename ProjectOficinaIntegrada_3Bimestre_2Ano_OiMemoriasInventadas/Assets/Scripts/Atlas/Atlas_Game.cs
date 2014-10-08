using UnityEngine;
using System.Collections;

public enum ID_Game
{
    BgGame,
    BgGame2,
    BgGame3,
}

public class Atlas_Game : MonoBehaviour
{
    public static Texture2D globalTexture_Game;
    public static Rect[] rects_Game;
    public static Material globalMaterial_Game;

    private Texture2D[] textures_Game;

    void Awake()
    {
        int numImage = 1000;

        textures_Game = new Texture2D[numImage];

        string[] imageNames = new string[]
	    {
            "BgGame",
            "BgGame2",
            "BgGame3",
        };

        for (int i = 0; i < imageNames.Length; i++)
        {
            textures_Game[i] = (Texture2D)Resources.Load("Textures/Game/" + imageNames[i].ToString());
        }

        globalTexture_Game = AtlasTexture.Create(this.textures_Game, out rects_Game);

        globalMaterial_Game = new Material((Shader)Resources.Load("Shader/Basic2D"));
        globalMaterial_Game.mainTexture = globalTexture_Game;
    }
}
