using System.Collections.Generic;
using Godot;

public class WorldGenerator : Node2D
{
    Vector2 worldSize = new Vector2(100, 100);
    Vector2 chunkSize = new Vector2(10, 10);
    
    public void GreateChunk(Vector2 position)
    {
  
    }
}


public class WorldChunk
{
    HashSet<Vector2> tiles;
    Vector2 ChunkPos;

    public WorldChunk(Vector2 chunkPos)
    {
        ChunkPos = chunkPos;
        tiles = new HashSet<Vector2>();
    }
    
}





public class WaveFunctionTileGenerator
{
    public static WorldChunk Generate(Vector2 chunkSize, Vector2 position, List<Tile> North, List<Tile> East, List<Tile> South, List<Tile> West, List<Tile> PossibleTiles)
    {
        return new WorldChunk(position);

    }
}



public class Tile
{
    TileType type;
    TileType? RequiredTile;
    TileName name;
    List<TileName> PossibleNeighboursNorth;
    List<TileName> PossibleNeighboursEast;
    List<TileName> PossibleNeighboursSouth;
    List<TileName> PossibleNeighboursWest;

    public Tile(TileType type, TileName name, List<TileName> possibleNeighboursNorth, List<TileName> possibleNeighboursEast, List<TileName> possibleNeighboursSouth, List<TileName> possibleNeighboursWest, TileType? requiredTile = null)
    {
        this.type = type;
        this.name = name;
        this.RequiredTile = requiredTile;
        this.PossibleNeighboursNorth = possibleNeighboursNorth;
        this.PossibleNeighboursEast = possibleNeighboursEast;
        this.PossibleNeighboursSouth = possibleNeighboursSouth;
        this.PossibleNeighboursWest = possibleNeighboursWest;
    }
    public bool IsValidFloor(Tile tile)
    {
        if (RequiredTile == null)
        {
            return true;
        }
        else
        {
            return RequiredTile == tile.type;
        }
    }
    public bool IsValidNeighbourNorth(Tile tile)
    {
        return PossibleNeighboursNorth.Contains(tile.name);
    }

    public bool IsValidNeighbourEast(Tile tile)
    {
        return PossibleNeighboursEast.Contains(tile.name);
    }

    public bool IsValidNeighbourSouth(Tile tile)
    {
        return PossibleNeighboursSouth.Contains(tile.name);
    }

    public bool IsValidNeighbourWest(Tile tile)
    {
        return PossibleNeighboursWest.Contains(tile.name);
    }

    public override string ToString()
    {
        return $"{name}";
    }

}


public enum TileType
{
    Ground_stable,
    Ground_unstable,
    Wall,
    Water,
    Lava,
    Air

}

public enum TileName
{
    tile_large_gray_0,
    tile_large_gray_1,
    tile_large_gray_5,
    tile_large_gray_2,
    tile_gray_small_1,
    tile_gray_small_2,
    tile_gray_small_3,
    tile_gray_med_0,
    tile_gray_med_1,
    tile_gray_med_2,
    tile_gray_med_3,
    tile_gray_broken_0,
    tile_gray_broken_1,
    tile_gray_broken_2,
    tile_gray_broken_3,
    tile_broken_nw_corner,
    tile_broken_n_edge_0,
    tile_broken_n_edge_1,
    tile_broken_ne_corner,
    tile_broken_e_edge_1,
    tile_mud_3,
    tile_mud_2,
    tile_broken_w_edge_0,
    tile_broken_w_edge_1,
    tile_mud_1,
    tile_mud_0,
    tile_broken_e_edge_0,
    tile_broken_se_corner,
    tile_broken_s_edge_1,
    tile_broken_s_edge_0,
    tile_broken_sw_corner,
    tile_large_gray_3,
    tile_large_gray_4,
    tile_gray_small_0,
}




