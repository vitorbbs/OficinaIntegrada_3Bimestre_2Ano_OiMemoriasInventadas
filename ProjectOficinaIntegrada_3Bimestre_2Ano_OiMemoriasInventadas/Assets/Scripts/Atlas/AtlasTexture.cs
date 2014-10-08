using UnityEngine;
using System.Collections;

public class AtlasTexture
{
    public static Texture2D Create(Texture2D[] textures, out Rect[] rects)
    {
        Texture2D texture = new Texture2D(4096, 4096, TextureFormat.RGBA32, true);

        rects = texture.PackTextures(textures, 0, 4096);

        return texture;
    }
}
