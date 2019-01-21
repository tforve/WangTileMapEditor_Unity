using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using System;

public class LevelManager : MonoBehaviour
{

	private static LevelManager instance;

	public static LevelManager MyInstance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<LevelManager>();
			}

			return instance;
		}
	}
	
	[SerializeField] private GameObject[] tiles;
	

	[SerializeField] private int GRIDX, GRIDY;

	public float MyCellSize
	{
		get { return tiles[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x; }
	}


	void Start()
	{
		CreateLevel();
	}
	
	
	
	/// <summary>
	/// Instantiate Grid
	/// </summary>
	private void CreateLevel()
	{

		string[] mapData = ReadLevelText();

		//Size of the Strings
		int mapX = mapData[0].ToCharArray().Length;
		//Size of the Array 
		int mapY = mapData.Length;; 
		
		//get Topleft Corner
		Vector3 worldStart = Camera.main.ScreenToWorldPoint((new Vector3(0, Screen.height)));
		
		for (int y = 0; y < mapY; y++)
		{
			//takes string and save it in char Array new Tiles
			char[] newTiles = mapData[y].ToCharArray();
			
			for (int x = 0; x < mapX; x++)
			{
				PlaceTile(newTiles[x].ToString(), x, y, worldStart);
			}
		}
	}

	
	/// <summary>
	/// Placing the Tiles next to each other 
	/// </summary>
	/// <param name="x"></param>
	/// <param name="y"></param>
	/// <param name="worldStart"></param>
	private void PlaceTile(string tileType, int x, int y, Vector3 worldStart)
	{

		int tileIndex = int.Parse(tileType);
		
		GameObject newTile = Instantiate(tiles[tileIndex]);
		newTile.transform.position = new Vector2(worldStart.x + (MyCellSize * x), worldStart.y - (MyCellSize * y));
	}


	private string[] ReadLevelText()
	{
		TextAsset bindData = Resources.Load("Level") as TextAsset;

		string data = bindData.text.Replace(Environment.NewLine, string.Empty);

		return data.Split('-');
	}
}
