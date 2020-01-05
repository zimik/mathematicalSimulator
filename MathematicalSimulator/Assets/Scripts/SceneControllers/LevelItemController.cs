using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelItemController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI levelText;

    public void setLevel(int level)
    {
        levelText.text = level.ToString();
    }
}
