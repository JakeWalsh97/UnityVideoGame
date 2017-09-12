using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public double score;

	void Update () {
        score = player.position.z + 6250;
        scoreText.text = score.ToString("0");
	}


}
