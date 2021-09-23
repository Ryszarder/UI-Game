using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;

public class QuizButton : MonoBehaviour
{
    private Button m_Button = null;
    private TextMeshProUGUI m_Text = null;

    void Awake()
    {
        m_Button = GetComponent<Button>();
        m_Text = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetText(string text)
	{
        m_Text.text = text;
	}

    public void AddonClicked(UnityAction onClick)
	{
        m_Button.onClick.AddListener(onClick);
	}
}
