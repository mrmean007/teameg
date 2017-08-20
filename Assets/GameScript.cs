using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{

    public GameObject[] particleEffects;
    public Canvas canvas;
    public Text scoreText;
    public GameObject gameOverPanel; 
    private AudioSource audioSource;
    private int score;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        score = 0;
    }
    //bool isClicked;
    void Update()
    {
        //RaycastWorldUI();

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("you fired");
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down);
        }

        if (Timer.isGameOver)
        {
            gameOverPanel.active = true;
            Time.timeScale = 0;
        }

    }


    public void ScaleDown(Transform obj)
    {
        score++;
        scoreText.text = score.ToString();
        StartCoroutine(ScaleMe(obj));
    }

    public void ChangeTextColor(Text text)
    {
        text.color = Color.green;
    }

    IEnumerator ScaleMe(Transform obj)
    {
        obj.localScale *= 1.5f;
        yield return new WaitForSeconds(0.5f);
        audioSource.Play();
        showParticle(obj);
        Destroy(obj.gameObject);
        // obj.localScale /= 1.2f;
    }

    private void showParticle(Transform obj)
    {
        int randIndex = Random.Range(0, particleEffects.Length - 1);
        GameObject ps = Instantiate(particleEffects[randIndex]) as GameObject;
        ps.transform.SetParent(canvas.transform);
        ps.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, -1);
    }

   public void Replay ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        Timer.isGameOver = false;
        Timer.TimeLeft = 60f;
    }
}

