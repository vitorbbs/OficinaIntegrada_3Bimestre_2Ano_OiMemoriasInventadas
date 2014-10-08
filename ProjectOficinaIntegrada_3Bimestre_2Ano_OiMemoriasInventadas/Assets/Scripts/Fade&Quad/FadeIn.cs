using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour
{
    Texture2D texture;
    float constant = 1;
    public static bool startFade = true;

    void Start()
    {
        startFade = true;
    }

    void FixedUpdate()
    {
        if(startFade)
        constant -= 0.01f;

        if (constant < 0)
        {
            startFade = false;
        }
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
