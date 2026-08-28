using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI text;
    private Animator animator;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        animator = GetComponent<Animator>();
    }
    public void Highlight()
    {
        animator.SetTrigger("Highlight");
    }

    public void SetScore(int value)
    {
        text.text = value.ToString();
    }
}