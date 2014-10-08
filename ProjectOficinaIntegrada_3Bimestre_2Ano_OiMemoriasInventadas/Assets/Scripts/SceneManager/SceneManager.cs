using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{
    GameObject[] gameObjects;
    
    float time = 0;

    void Start()
    {
        switch(this.name)
        {
            case "Menu":        
                gameObjects = new GameObject[]
                {
                    new GameObject("BgMenu",typeof(Background)),
                    new GameObject("BtJogar",typeof(Button)),
                    new GameObject("BtCreditos",typeof(Button)),
                    new GameObject("BtInstruções",typeof(Button)),
                    new GameObject("Tucano", typeof(TucanoMenu)),
                };
            break;

            case "Creditos":
            gameObjects = new GameObject[]
                {
                    new GameObject("BgCreditos",typeof(Background)),
                    new GameObject("BtVoltar",typeof(Button)),
                };
            break;

            case "Apresentação":
            gameObjects = new GameObject[]
                {
                    new GameObject("Apresentação",typeof(Background)),
                };
            break;

            case "Instrucoes":
            gameObjects = new GameObject[]
                {
                    new GameObject("BtVoltarInstrucoes",typeof(Button)),
                    new GameObject("Instrucoes",typeof(Background)),
                };
            break;

            case "Game":
            gameObjects = new GameObject[]
                {
                    new GameObject("Player",typeof(Player)),
                    new GameObject("BgGame",typeof(Background)),
                };
            break;

            case "Game2":
            gameObjects = new GameObject[]
                {
                    new GameObject("Player",typeof(Player)),
                    new GameObject("BgGame2",typeof(Background)),
                };
            break;

            case "Game3":
            gameObjects = new GameObject[]
                {
                    new GameObject("Player",typeof(Player)),
                    new GameObject("BgGame3",typeof(Background)),
                };
            break;

            case "TransitFase1":
            gameObjects = new GameObject[]
                {
                    new GameObject("BgTransitFase1",typeof(Background)),
                };
            break;

            case "TransitFase2":
            gameObjects = new GameObject[]
                {
                    new GameObject("BgTransitFase2",typeof(Background)),
                };
            break;

            case "TransitFase3":
            gameObjects = new GameObject[]
                {
                    new GameObject("BgTransitFase3",typeof(Background)),
                };
            break;

            case "Logo":
            gameObjects = new GameObject[]
                {
                    new GameObject("BgLogo",typeof(Background)),
                };
            break;

            case "Vitoria":
            gameObjects = new GameObject[]
                {
                    new GameObject("BgVitoria",typeof(Background)),
                    new GameObject("BtVoltarCreditos",typeof(Button)),
                };
            break;

            case "Derrota":
            gameObjects = new GameObject[]
                {
                    new GameObject("BgDerrota",typeof(Background)),
                    new GameObject("BtVoltar",typeof(Button)),
                };
            break;
        }
    }
}
