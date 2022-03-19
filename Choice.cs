using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Choice : MonoBehaviour
{
    [SerializeField] private PlayerStats PS;
    [SerializeField] private GenerateQuestionNumber GQN;

    [SerializeField] private Text C1MoodText, C1MoneyText, C1ProductivityText;
    [SerializeField] private Text C2MoodText, C2MoneyText, C2ProductivityText;
    [SerializeField] private Text C3MoodText, C3MoneyText, C3ProductivityText;
    [SerializeField] private TextMeshProUGUI choice1Text, choice2Text, choice3Text;

    public bool hideButtons, hasChosen;
    public float timerChoice;
    private void Start()
    {
        hideButtons = false;
        hasChosen = false;
        timerChoice = 0;
    }
    void Update()
    {
        Choice1Q();
        Choice2Q();
        Choice3Q();
    }
    void Choice1Q()
    {
        if (GQN.choice1Select == 0)
        {
            //choice1Text.text = "Trocar uma peça antiga do computador por uma mais nova.";
            choice1Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C1O1");
            C1MoodText.color = Color.green;
            C1MoneyText.color = Color.red;
            C1ProductivityText.color = Color.green;
        }
        else if (GQN.choice1Select == 1)
        {
            //choice1Text.text = "Pedir para que a equipe trabalhe até mais tarde.";
            choice1Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C1O2");
            C1MoodText.color = Color.red;
            C1MoneyText.color = Color.grey;
            C1ProductivityText.color = Color.green;
        }
        else if (GQN.choice1Select == 2)
        {
            //choice1Text.text = "Ajudar na implementação de uma nova mecânica.";
            choice1Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C1O3");
            C1MoodText.color = Color.green;
            C1MoneyText.color = Color.grey;
            C1ProductivityText.color = Color.green;
        }
        else if (GQN.choice1Select == 3)
        {
            //choice1Text.text = "Pedir para a equipe desenvolver uma função multiplayer.";
            choice1Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C1O4");
            C1MoodText.color = Color.red;
            C1MoneyText.color = Color.grey;
            C1ProductivityText.color = Color.red;
        }
        else if (GQN.choice1Select == 4)
        {
            //choice1Text.text = "Liberar o horário flexivel para a equipe.";
            choice1Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C1O5");
            C1MoodText.color = Color.green;
            C1MoneyText.color = Color.grey;
            C1ProductivityText.color = Color.grey;
        }
        else if (GQN.choice1Select == 5)
        {
            //choice1Text.text = "Contratar um freelancer para ajudar no projeto.";
            choice1Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C1O6");
            C1MoodText.color = Color.grey;
            C1MoneyText.color = Color.red;
            C1ProductivityText.color = Color.green;
        }
        else if (GQN.choice1Select == 6)
        {
            //choice1Text.text = "Pedir para a equipe procure bugs no jogo.";
            choice1Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C1O7");
            C1MoodText.color = Color.red;
            C1MoneyText.color = Color.grey;
            C1ProductivityText.color = Color.green;
        }
        else if (GQN.choice1Select == 7)
        {
            //choice1Text.text = "Mudar o enredo do jogo.";
            choice1Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C1O8");
            C1MoodText.color = Color.grey;
            C1MoneyText.color = Color.grey;
            C1ProductivityText.color = Color.red;
        }
        else
        {
            //choice1Text.text = "Divulgar o jogo para possíveis investidores.";
            choice1Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C1O9");
            C1MoodText.color = Color.grey;
            C1MoneyText.color = Color.green;
            C1ProductivityText.color = Color.grey;
        }
    }
    void Choice2Q()
    {
        if (GQN.choice2Select == 0)
        {
            choice2Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C2O1");
            C2MoodText.color = Color.red;
            C2MoneyText.color = Color.grey;
            C2ProductivityText.color = Color.red;
        }
        else if (GQN.choice2Select == 1)
        {
            choice2Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C2O2");
            C2MoodText.color = Color.green;
            C2MoneyText.color = Color.green;
            C2ProductivityText.color = Color.red;
        }
        else if (GQN.choice2Select == 2)
        {
            choice2Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C2O3");
            C2MoodText.color = Color.grey;
            C2MoneyText.color = Color.red;
            C2ProductivityText.color = Color.green;
        }
        else if (GQN.choice2Select == 3)
        {
            choice2Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C2O4");
            C2MoodText.color = Color.grey;
            C2MoneyText.color = Color.red;
            C2ProductivityText.color = Color.grey;
        }
        else if (GQN.choice2Select == 4)
        {
            choice2Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C2O5");
            C2MoodText.color = Color.grey;
            C2MoneyText.color = Color.red;
            C2ProductivityText.color = Color.green;
        }
        else if (GQN.choice2Select == 5)
        {
            choice2Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C2O6");
            C2MoodText.color = Color.green;
            C2MoneyText.color = Color.grey;
            C2ProductivityText.color = Color.green;
        }
        else if (GQN.choice2Select == 6)
        {
            choice2Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C2O7");
            C2MoodText.color = Color.grey;
            C2MoneyText.color = Color.green;
            C2ProductivityText.color = Color.grey;
        }
        else if (GQN.choice2Select == 7)
        {
            choice2Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C2O8");
            C2MoodText.color = Color.red;
            C2MoneyText.color = Color.grey;
            C2ProductivityText.color = Color.red;
        }
        else
        {
            choice2Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C2O9");
            C2MoodText.color = Color.red;
            C2MoneyText.color = Color.grey;
            C2ProductivityText.color = Color.red;
        }
    }
    void Choice3Q()
    {
        if (GQN.choice3Select == 0)
        {
            choice3Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C3O1");
            C3MoodText.color = Color.grey;
            C3MoneyText.color = Color.green;
            C3ProductivityText.color = Color.grey;
        }
        else if (GQN.choice3Select == 1)
        {
            choice3Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C3O2");
            C3MoodText.color = Color.red;
            C3MoneyText.color = Color.red;
            C3ProductivityText.color = Color.red;
        }
        else if (GQN.choice3Select == 2)
        {
            choice3Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C3O3");
            C3MoodText.color = Color.red;
            C3MoneyText.color = Color.green;
            C3ProductivityText.color = Color.red;
        }
        else if (GQN.choice3Select == 3)
        {
            choice3Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C3O4");
            C3MoodText.color = Color.green;
            C3MoneyText.color = Color.red;
            C3ProductivityText.color = Color.green;
        }
        else if (GQN.choice3Select == 4)
        {
            choice3Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C3O5");
            C3MoodText.color = Color.red;
            C3MoneyText.color = Color.grey;
            C3ProductivityText.color = Color.green;
        }
        else if (GQN.choice3Select == 5)
        {
            choice3Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C3O6");
            C3MoodText.color = Color.green;
            C3MoneyText.color = Color.grey;
            C3ProductivityText.color = Color.green;
        }
        else if (GQN.choice3Select == 6)
        {
            choice3Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C3O7");
            C3MoodText.color = Color.grey;
            C3MoneyText.color = Color.green;
            C3ProductivityText.color = Color.grey;
        }
        else if (GQN.choice3Select == 7)
        {
            choice3Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C3O8");
            C3MoodText.color = Color.grey;
            C3MoneyText.color = Color.grey;
            C3ProductivityText.color = Color.red;
        }
        else
        {
            choice3Text.text = Lean.Localization.LeanLocalization.GetTranslationText("C3O9");
            C3MoodText.color = Color.green;
            C3MoneyText.color = Color.grey;
            C3ProductivityText.color = Color.green;
        }
    }
    void Choice1S()
    {
        if (GQN.choice1Select == 0)
        {
            PS.money -= Random.Range(20, 300);
            PS.moodValue += Random.Range(1, 10);
            PS.productivityBonus += Random.Range(0.1f, 0.3f);
        }
        else if (GQN.choice1Select == 1)
        {
            PS.moodValue -= Random.Range(5, 15);
            PS.productivityBonus += Random.Range(0.1f, 0.3f);
        }
        else if (GQN.choice1Select == 2)
        {
            PS.moodValue += Random.Range(5, 16);
            PS.productivityBonus += Random.Range(0.1f, 0.3f);
        }
        else if (GQN.choice1Select == 3)
        {
            PS.moodValue -= Random.Range(10, 25);
            PS.productivityBonus -= Random.Range(0.2f, 0.4f);
        }
        else if (GQN.choice1Select == 4)
        {
            PS.moodValue += Random.Range(5, 10);
        }
        else if (GQN.choice1Select == 5)
        {
            PS.money -= Random.Range(150, 400);
            PS.productivityBonus += Random.Range(0.2f, 0.4f);
        }
        else if (GQN.choice1Select == 6)
        {
            PS.moodValue -= Random.Range(1, 5);
            PS.productivityBonus += 0.1f;
        }
        else if (GQN.choice1Select == 7)
        {
            PS.productivityBonus -= Random.Range(0.3f, 0.5f);
        }
        else
        {
            PS.money += Random.Range(300, 550);
        }
    }
    void Choice2S()
    {
        if (GQN.choice2Select == 0)
        {
            PS.moodValue -= Random.Range(5, 20);
            PS.productivityBonus -= Random.Range(0.1f, 0.3f);
        }
        else if (GQN.choice2Select == 1)
        {
            PS.money += Random.Range(100, 200);
            PS.moodValue += Random.Range(5, 17);
            PS.productivityBonus -= 0.2f;
        }
        else if (GQN.choice2Select == 2)
        {
            PS.money -= Random.Range(40, 280);
            PS.productivityBonus += Random.Range(0.1f, 0.3f);
        }
        else if (GQN.choice2Select == 3)
        {
            PS.money -= Random.Range(50, 300);
        }
        else if (GQN.choice2Select == 4)
        {
            PS.money -= Random.Range(20, 150);
            PS.productivityBonus += Random.Range(0.2f, 0.4f);
        }
        else if (GQN.choice2Select == 5)
        {
            PS.moodValue += Random.Range(1, 10);
            PS.productivityBonus += 0.2f;
        }
        else if (GQN.choice2Select == 6)
        {
            PS.money += Random.Range(250, 400);
        }
        else if (GQN.choice2Select == 7)
        {
            PS.moodValue -= Random.Range(10, 20);
            PS.productivityBonus -= Random.Range(0.1f, 0.3f);
        }
        else
        {
            PS.moodValue -= Random.Range(1, 5);
            PS.productivityBonus -= 0.1f;
        }
    }
    void Choice3S()
    {
        if (GQN.choice3Select == 0)
        {
            PS.money += Random.Range(50, 500);
        }
        else if (GQN.choice3Select == 1)
        {
            PS.money -= Random.Range(50, 600);
            PS.moodValue -= Random.Range(15, 30);
            PS.productivityBonus -= 0.4f;
        }
        else if (GQN.choice3Select == 2)
        {
            PS.money += Random.Range(50, 350);
            PS.moodValue -= Random.Range(10, 20);
            PS.productivityBonus -= 0.1f;
        }
        else if (GQN.choice3Select == 3)
        {
            PS.money -= Random.Range(60, 340);
            PS.moodValue += Random.Range(5, 18);
            PS.productivityBonus += 0.1f;
        }
        else if (GQN.choice3Select == 4)
        {
            PS.moodValue -= Random.Range(1, 10);
            PS.productivityBonus += 0.1f;
        }
        else if (GQN.choice3Select == 5)
        {
            PS.moodValue += Random.Range(10, 20);
            PS.productivityBonus += Random.Range(0.1f, 0.4f);
        }
        else if (GQN.choice3Select == 6)
        {
            PS.money += Random.Range(170, 430);
        }
        else if (GQN.choice3Select == 7)
        {
            PS.productivityBonus -= 0.1f;
        }
        else
        {
            PS.moodValue += Random.Range(1, 10);
            PS.productivityBonus += 0.1f;
        }
    }
    public void ChoiceTimeOut()
    {
            PS.money += Random.Range(-300, 300);
            PS.moodValue += Random.Range(-15, 15);
            PS.productivityBonus += Random.Range(-0.3f, 0.3f);
    }
    public void OnClickChoice1()
    {
        Choice1S();
        hideButtons = true;
        hasChosen = true;
    }
    public void OnClickChoice2()
    {
        Choice2S();
        hideButtons = true;
        hasChosen = true;
    }
    public void OnClickChoice3()
    {
        Choice3S();
        hideButtons = true;
        hasChosen = true;
    }
}
