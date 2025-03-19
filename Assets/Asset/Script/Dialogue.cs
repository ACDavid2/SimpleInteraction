using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI TextComp;
    public string[] lines;
    public float textspeed;
    private int index;
    void Start()
    {
        TextComp.text = string.Empty;
        startDialogue();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (TextComp.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                TextComp.text = lines[index];
            }
        }
    }

    void startDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())//breaks down into char array
        {
            TextComp.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            TextComp.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
