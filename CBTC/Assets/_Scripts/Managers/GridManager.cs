using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GridManager : MonoBehaviour
{

    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _tilePrefab;
    [SerializeField] private Transform _cam;

    private Dictionary<Vector2, Tile> _tiles;

    GameManager gm;

    void Start() {
        GenerateGrid();
        gm = GameManager.GetInstance();
    }
 
    void GenerateGrid() {
        for (int x = 0; x < _width; x++) {
            for (int y = 0; y < _height; y++) {
                var spawnedTile = Instantiate(_tilePrefab, new Vector3(x,y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedTile.Init(isOffset);
            }
        }

        _cam.transform.position = new Vector3((float)_width / 2 -0.5f + 2.2f, (float)_height / 2 - 0.5f, -10);

        gm.ChangeState(GameManager.GameState.SPAWN);
    }

    public Tile GetHeroSpawnTile()
    {
        return _tiles.Where(async t => t.Key.x < _width / 2 && t.Value.Walkable).OrderBy(t => Random.value).First().Value;
    }
    public Tile GetEnemySpawnTile()
    {
        return _tiles.Where(t => t.Key.x < _width / 2  && t.Value.Walkable).OrderBy(t => Random.value).First().Value;
    }
}
