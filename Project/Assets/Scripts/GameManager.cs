using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private Text _scoreUI;
    public static int _score = 0;

    // Use this for initialization
    void Start () {
        _score = 0;
        _scoreUI = GameObject.Find("Text").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        _scoreUI.text = _score.ToString();

        if(_score >= 20 && SceneManager.GetActiveScene().name == "Level_00") {
            SceneManager.LoadScene("Level_01", LoadSceneMode.Single);
        }
    }
}
