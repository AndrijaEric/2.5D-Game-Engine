using UnityEngine;
using System;
using System.Collections;

public class Region_Spawner : MonoBehaviour {

    public int regionSize;

    public GameObject Grass_Tile;
    public GameObject Water_Tile;

    public Texture2D startRegion;

    // Use this for initialization
    void Start () {
        Color[] map = startRegion.GetPixels(0);
        regionSize = Convert.ToInt32(Math.Sqrt(map.Length));

        int current = 0;
        int y = -regionSize/2;
        for (int size = regionSize; size > 0; size--)
        {
            for (int x = -regionSize / 2; x < regionSize / 2; x++)
            {
                if (map[current].b > 0.8)
                {
                    GameObject Tile_Spawn = Instantiate(Water_Tile, new Vector2(x, y), Quaternion.identity) as GameObject;
                    Tile_Spawn.transform.parent = this.gameObject.transform;
                    Tile_Spawn = null;
                }else if (map[current].g > 0.8)
                {
                    GameObject Tile_Spawn = Instantiate(Grass_Tile, new Vector2(x, y), Quaternion.identity) as GameObject;
                    Tile_Spawn.transform.parent = this.gameObject.transform;
                    Tile_Spawn = null;
                }
                current++;
            }
            y++;
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
