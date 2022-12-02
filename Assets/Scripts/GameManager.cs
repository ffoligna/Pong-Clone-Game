using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] private TMP_Text paddle01ScoreText;
    [SerializeField] private TMP_Text paddle02ScoreText;

    [SerializeField] private Transform paddle01Transform;
    [SerializeField] private Transform paddle02Transform;
    [SerializeField] private Transform ballTransform;

    private int paddle01Score;
    private int paddle02Score;

    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    public void paddle01Scored()
    {
        paddle01Score++;
        paddle01ScoreText.text = paddle01Score.ToString();
    }

    public void paddle02Scored()
    {
        paddle02Score++;
        paddle02ScoreText.text = paddle02Score.ToString();
    }

    public void Restart()
    {
        paddle01Transform.position = new Vector2(paddle01Transform.position.x, 0);
        paddle02Transform.position = new Vector2(paddle02Transform.position.x, 0);
        ballTransform.position = new Vector2 (0 ,0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
