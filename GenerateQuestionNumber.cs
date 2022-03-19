using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateQuestionNumber : MonoBehaviour
{
    public int choice1Select;
    public int choice2Select;
    public int choice3Select;

    private float timer;
    bool generateNumber;
    void Start()
    {
        timer = 0;
        generateNumber = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 25)
        {
            timer += Time.deltaTime;
            if (generateNumber == true)
            {
                choice1Select = Random.Range(0, 8);
                choice2Select = Random.Range(0, 8);
                choice3Select = Random.Range(0, 8);
                generateNumber = false;
            }
        }
        if (timer >= 25)
        {
            timer = 0;
            generateNumber = true;
        }
    }
}
