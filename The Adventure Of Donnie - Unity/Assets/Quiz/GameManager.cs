using System.Collections; // for IEnumerator
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    // two ways in storing data
    // array - don't need to resize
    // List for resizing

    private Questions[] _questions;
    [SerializeField] private List<Questions> unansweredQuestions;

    private Questions currentQuestion;

    [SerializeField]
    private TMP_Text faceText;
    [SerializeField]
    private TMP_Text aText;
    [SerializeField]
    private TMP_Text bText;
    [SerializeField]
    private TMP_Text cText;
    [SerializeField]
    private TMP_Text dText;

    [SerializeField]
    private float timeBetweenQuestions = 1f;

    /*public MonsterScriptMoving enemy;

    public Monster_Level1 monster;*/
    //public forTheMeantime tut;
    public static bool bawasOras;

    public static bool hitEnemy;

    public quizManager Quiz;

    void Start()
    {

        //Time.timeScale = 0f;
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = _questions.ToList<Questions>();
        }

        SetCurrentQuestions();
        //Debug.Log(currentQuestion.fact + " is " + currentQuestion.isTrue);
    }

    private void Update()
    {
        //pag may error, halion ni
        TransitionToNextQuestion();
    }
    void SetCurrentQuestions()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        faceText.text = currentQuestion.fact;
        aText.text = currentQuestion.a;
        bText.text = currentQuestion.b;
        cText.text = currentQuestion.c;
        dText.text = currentQuestion.d;


        //unansweredQuestions.RemoveAt(randomQuestionIndex);
    }

    IEnumerator TransitionToNextQuestion()
    {
        //unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }



    // can make in single method that has an integer stating what the user has selected 
    /* public void UserSelectTrue()
     {
         if (currentQuestion.isTrue)
         {
             Debug.Log("CORRECT!!");
         }
         else
         {
             Debug.Log("WRONG!!");
         }
     }

     public void UserSelectFalse()
     {
         if (!currentQuestion.isTrue)
         {
             Debug.Log("CORRECT!!");
         }
         else
         {
             Debug.Log("WRONG!!");
         }
     }*/

    void timerBawas()
    {
        bawasOras = true;
    }

    public void _one()
    {
        if (currentQuestion.answer == 1)
        {
            SetCurrentQuestions();
            hitEnemy = true;
            Quiz.anim.SetTrigger("tama");
            Debug.Log("Tama!!");
        }
        else
        {
            SetCurrentQuestions();
            timerBawas();
            Quiz.anim.SetTrigger("sala");
            Debug.Log("sala!!");
        }
        StartCoroutine(TransitionToNextQuestion());
    }
    public void _two()
    {
        if (currentQuestion.answer == 2)
        {
            SetCurrentQuestions();
            Quiz.anim.SetTrigger("tama");
            hitEnemy = true;
            Debug.Log("Tama!!");
        }
        else
        {
            SetCurrentQuestions();
            Quiz.anim.SetTrigger("sala");
            timerBawas();
            Debug.Log("sala!!");
        }
        StartCoroutine(TransitionToNextQuestion());
    }
    public void _three()
    {
        if (currentQuestion.answer == 3)
        {
            SetCurrentQuestions();
            Quiz.anim.SetTrigger("tama");
            hitEnemy = true;
            Debug.Log("Tama!!");
        }
        else
        {
            SetCurrentQuestions();
            Quiz.anim.SetTrigger("sala");
            timerBawas();
            Debug.Log("sala!!");
        }
        StartCoroutine(TransitionToNextQuestion());
    }
    public void _four()
    {

        if (currentQuestion.answer == 4)
        {
            SetCurrentQuestions();
            Quiz.anim.SetTrigger("tama");
            hitEnemy = true;
            Debug.Log("Tama!!");
        }
        else
        {
            SetCurrentQuestions();
            Quiz.anim.SetTrigger("sala");
            timerBawas();
            Debug.Log("sala!!");
        }
        StartCoroutine(TransitionToNextQuestion());
    }

}
