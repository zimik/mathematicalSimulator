using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskItemController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI questionText;

    [SerializeField]
    private TMP_InputField answerInput;

    public void SetQuestion(string question)
    {
        questionText.text = question;
    }

    public string GetAnswer()
    {
        return answerInput.text;
    }
}
