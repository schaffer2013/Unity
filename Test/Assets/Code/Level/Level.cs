using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {


	public int levelWidth;
	public int levelHeight;

	public Transform grassTile;
	public Transform brickTile;
	public Transform magmaTile;

	public Color grassColor;
	public Color brickColor;
	public Color magmaColor;
	public Color spawnPointColor;

	private Color[] tileColors;

	public Texture2D levelTexture;

	public Entity player;

	// Use this for initialization
	void Start () 
	{
		levelWidth = levelTexture.width;
		levelHeight = levelTexture.height;
		loadLevel ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void loadLevel()
	{
		tileColors = new Color[levelWidth * levelHeight];
		tileColors = levelTexture.GetPixels ();

		for (int y = 0; y < levelHeight; y++) 
		{
			for (int x = 0; x < levelWidth; x++) 
			{
				Color activeColor = tileColors [x + y * levelWidth];
				if (activeColor == brickColor) 
				{
					Instantiate (brickTile, new Vector3 (x, y), Quaternion.identity);
				}
				if (activeColor == magmaColor) 
				{
					Instantiate (magmaTile, new Vector3 (x, y), Quaternion.identity);
				}
				if (activeColor == grassColor) 
				{
					Instantiate (grassTile, new Vector3 (x, y), Quaternion.identity);
				}
				if (activeColor == spawnPointColor) 
				{
					Instantiate (grassTile, new Vector3 (x, y), Quaternion.identity);
					Vector2 pos = new Vector2 (x, y);
					player.transform.position = pos;
				}
			}
		}
	}
}
