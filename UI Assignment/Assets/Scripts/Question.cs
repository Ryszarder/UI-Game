using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Question
{
	private string m_Question = "";
	private List<string> m_Answers = new List<string>();
	private int m_CorrectIndex = -1;

	public void SetQuestion(string question)
	{
		m_Question = question;
	}

	public void SetAnswer(string answers)
	{
		m_Answers.Add(answers);
	}

	public void SetCorrentIndex(int index)
	{
		m_CorrectIndex = index;
	}

	public string GetQuestion()
	{
		return m_Question;
	}

	public List<string> GetAnswers()
	{
		return m_Answers;
	}

	public int GetCorrentIndex()
	{
		return m_CorrectIndex;
	}
}
