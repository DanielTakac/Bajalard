using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour{

    [SerializeField] private Text scoreText;

    [SerializeField] private float velocity;

    private LineRenderer line;
    private WhiteBall whiteBall;

    public static int score;

    void Start() {

        line = FindObjectOfType<LineRenderer>();
        whiteBall = FindObjectOfType<WhiteBall>();
    
    }

    private void Update() {

        if (Input.GetKeyDown(Keybinds.keybinds["restart"])) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Input.GetKeyDown(Keybinds.keybinds["menu"])) Application.Quit();

        UpdateText();

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        var direction = Vector3.zero;

        if (Physics.Raycast(ray, out hit)) {

            var ballPosition = new Vector3(whiteBall.transform.position.x, 1f, whiteBall.transform.position.z);
            var mousePosition = new Vector3(hit.point.x, 1f, hit.point.z);
            line.SetPosition(0, mousePosition);
            line.SetPosition(1, ballPosition);
            direction = (mousePosition - ballPosition).normalized;

        }

        if (Input.GetMouseButtonDown(0) && line.gameObject.activeSelf) {

            line.gameObject.SetActive(false);

            whiteBall.GetComponent<Rigidbody>().velocity = direction * velocity;

        }

        if (!line.gameObject.activeSelf && whiteBall.GetComponent<Rigidbody>().velocity.magnitude < 0.3f) {

            line.gameObject.SetActive(true);

        }

    }

    private void UpdateText() {

        scoreText.text = "Score: " + score;

    }

}
