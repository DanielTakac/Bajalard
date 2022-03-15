using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour{

    [SerializeField] private Text scoreText;

    public static int score;

    private void Update() {

        if (Input.GetKeyDown(Keybinds.keybinds["restart"])) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        UpdateText();

    }

    private void UpdateText() {

        scoreText.text = score.ToString();

    }

}
