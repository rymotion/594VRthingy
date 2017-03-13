using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Done_GameController : MonoBehaviour
{
	public GameObject[] hazards;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
//	public GUIText scoreText;
//	public GUIText restartText;
//	public GUIText gameOverText;
//	
	private bool gameOver;
	private bool restart;
	public float seconds, minutes;


	
	void Start ()
	{
		gameOver = false;
		restart = false;
//		restartText.text = "";
//		gameOverText.text = "";
		StartCoroutine (SpawnWaves ());
	}
	
	void Update ()
	{
		if (!gameOver) {
			minutes = (int)(Time.timeSinceLevelLoad / 60f);
			seconds = (int)(Time.timeSinceLevelLoad % 60f);
//			scoreText.text = minutes.ToString ("0") + ":" + seconds.ToString ("00");
		}

			if (restart)
		{
			if (Input.GetKeyDown (KeyCode.R))
			{

				SceneManager.LoadScene("SW_VR");
			}
			else if (Input.GetKeyDown (KeyCode.Q))
			{
				SceneManager.LoadScene("SW_VR");
			}
		}
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				GameObject hazard = hazards [Random.Range (0, hazards.Length)];
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
			
			if (gameOver)
			{
//				restartText.text = "Press R for Restart or Q for Menu";
				restart = true;
				break;
			}
		}
	}

	
	public void GameOver ()
	{
//		gameOverText.text = "Game Over";
		gameOver = true;
	}
}