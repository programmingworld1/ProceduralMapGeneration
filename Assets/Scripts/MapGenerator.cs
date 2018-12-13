using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public int mapWidth;
    public int mapHeight;
    public float noiseScale;
    public bool AutoUpdate;
    public void GenerateMap()
    {
        float[,] noiseMap = Noise.Instance().GenerateMapNoise(mapWidth, mapHeight, noiseScale);
        MapRenderer display = FindObjectOfType<MapRenderer>();

        display.DrawNoiseMap(noiseMap);
    }

}
