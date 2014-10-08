using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour
{
    Texture2D texture;
    float constant = 0;
    public static bool endFade;

    void Start()
    {
        constant = 0;
        endFade = false;
    }

    void Update()
    {
        if(endFade)
        constant += 0.01f;
    }

    void OnGUI()
    {
        texture = (Texture2D)Resources.Load("Textures/teste");
        Color tmpColor = GUI.color;
        GUI.color = new Color(1, 1, 1, constant);
        GUI.DrawTexture(new Rect(0, 0, 2048, 1536), texture);
        GUI.color = tmpColor;
    }
}
