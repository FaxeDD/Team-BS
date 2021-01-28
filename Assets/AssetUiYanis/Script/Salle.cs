using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Salle: MonoBehaviour
{
    
    public TextMeshProUGUI TextSalle;
    int SalleMax = 10;
    int currentSalle = 0;
    public GameObject TextQuest;
    public Image CheckImage;
    float CheckQuest;

    // Start is called before the first frame update
    void Start()
    {
        TextQuest.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TextSalle.text = "Salle : " + currentSalle + " / " + SalleMax;
        if( currentSalle >= SalleMax)
        {
            currentSalle = SalleMax;
        }
        
        CheckImage.fillAmount = Mathf.Lerp(CheckImage.fillAmount, CheckQuest, Time.deltaTime*2);
         if(CheckImage.fillAmount >= 0.9)
          {
                CheckImage.fillAmount = 1;
                
          }
       
    }

    public void IncreaseRoom()
    {
        currentSalle++;
    }

    public void QuestAppear()
    {
        
        TextQuest.SetActive(true);
    }
    public void finishTheQuest()
    {
        QuestFinish(1f);
    }
    public void QuestFinish (float plus)
    {
       
            CheckQuest += plus;
            if (CheckQuest >= 1)
            {
                CheckQuest = 1;
             
            }
        
    }
}
