using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    public TextMeshProUGUI m_QuestionText = null;

    public QuizButton[] m_Buttons = null;

    private List<Question> m_Question = new List<Question>();
    private Question m_CurrentQuestion = null;

    // Start is called before the first frame update
    void Start()
    { 
        for(int i = 0; i < m_Buttons.Length; ++i)
		{
            int index = i;
            m_Buttons[i].AddonClicked(() => ButtonClicked(index));
		}

        GenerateQuestion();
        ChooseQuestion();
    }

    private void GenerateQuestion()
    {
        Question question = new Question();
        question.SetQuestion("What is the latest RTX?");
        question.SetAnswer("3070");
        question.SetAnswer("3080");
        question.SetAnswer("3090");
        question.SetAnswer("3030");
        question.SetCorrentIndex(1);
        m_Question.Add(question);

        question = new Question();
        question.SetQuestion("What day is the 24/9");
        question.SetAnswer("Monday");
        question.SetAnswer("Tuesday");
        question.SetAnswer("Wednesday");
        question.SetAnswer("Thursday");
        question.SetCorrentIndex(3);
        m_Question.Add(question);

        question = new Question();
        question.SetQuestion("Who was the second Robin for Batman?");
        question.SetAnswer("Tim Drake");
        question.SetAnswer("Dick Grayson");
        question.SetAnswer("Jason Todd");
        question.SetAnswer("Damian Wayne");
        question.SetCorrentIndex(2);
        m_Question.Add(question);

        question = new Question();
        question.SetQuestion("How many dice and what dice do you roll for level 3 fireball");
        question.SetAnswer("8d6");
        question.SetAnswer("6d8");
        question.SetAnswer("4d10");
        question.SetAnswer("15d4");
        question.SetCorrentIndex(0);
        m_Question.Add(question);
    }

    public void ChooseQuestion()
	{
        int nRand = Random.Range(0, m_Question.Count);

        if(m_Question.Count == 0)
		{
            SceneManager.LoadScene("EndScene");
		}
        else
		{
            m_CurrentQuestion = m_Question[nRand];
            m_Question.RemoveAt(nRand);

            m_QuestionText.text = m_CurrentQuestion.GetQuestion();
            for(int i = 0; i < m_Buttons.Length; ++i)
		    {
                m_Buttons[i].SetText(m_CurrentQuestion.GetAnswers()[i]);
		    }
		}
        
	}

    public void ButtonClicked(int nButtonIndex)
	{
        
        if(m_CurrentQuestion != null)
		{
            if (m_CurrentQuestion.GetCorrentIndex() == nButtonIndex)
			{
                Debug.Log("Correct");
            }
			else
			{
                Debug.Log("Wrong");
			}
            ChooseQuestion(); 
            
        }
    }
}
