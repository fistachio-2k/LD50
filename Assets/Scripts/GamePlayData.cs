using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = nameof(GamePlayData), fileName = "Create GamePlay Data")]
public class GamePlayData : ScriptableObject
{
    public GameState State;
    public int LiveHumens;
    public float BlackHoleMass;
    public int PlanetIndex = 0;
    public GameObject BlackHole;
    public GameObject CurrentPlanet;
}
