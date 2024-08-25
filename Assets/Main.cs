using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] private GameObject _question;
    [SerializeField] private GameObject _answer1;
    [SerializeField] private GameObject _answer2;
    [SerializeField] private GameObject _answer3;
    [SerializeField] private GameObject _answer4;
    
    private Quiz _quiz;
    
    private void Start()
    {
        _answer1.GetComponent<Button>().onClick.AddListener(() => SelectAnswer(_answer1));
        _answer2.GetComponent<Button>().onClick.AddListener(() => SelectAnswer(_answer2));
        _answer3.GetComponent<Button>().onClick.AddListener(() => SelectAnswer(_answer3));
        _answer4.GetComponent<Button>().onClick.AddListener(() => SelectAnswer(_answer4));
        
        _quiz = new Quiz
        {
            Question = "Что растёт в огороде? ",
            RightAnswer = "Лук",
            FirstWrongAnswer = "Пулемёт",
            SecondWrongAnswer = "Ракета СС-20",
            ThirdWrongAnswer = "Пистолет"
        };
        
        _question.GetComponentInChildren<TextMeshProUGUI>().text = _quiz.Question;
        _answer1.GetComponentInChildren<TextMeshProUGUI>().text = _quiz.FirstWrongAnswer;
        _answer2.GetComponentInChildren<TextMeshProUGUI>().text = _quiz.SecondWrongAnswer;
        _answer3.GetComponentInChildren<TextMeshProUGUI>().text = _quiz.ThirdWrongAnswer;
        _answer4.GetComponentInChildren<TextMeshProUGUI>().text = _quiz.RightAnswer;
        
    }

    private void SelectAnswer(GameObject answer)
    {
        if (answer.GetComponentInChildren<TextMeshProUGUI>().text == _quiz.RightAnswer)
        {
            SelectRightAnswer(answer);
        }
        else
        {
            SelectWrongAnswer(answer);
        }
    }
    
    private void SelectRightAnswer(GameObject answer)
    {
        Debug.Log("Ура!!! Победа");
        answer.GetComponent<Graphic>().color = Color.green;
    }

    private void SelectWrongAnswer(GameObject answer)
    {
        answer.GetComponent<Graphic>().color = Color.red;
    }
}
