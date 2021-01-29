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

    private ClickToMove ClickToMove;
    private Shooting shooting;
    

    // Start is called before the first frame update
    void Start()
    {
        TextQuest.SetActive(false);
        ClickToMove = GameObject.Find("player").GetComponent<ClickToMove>();
        shooting = GameObject.Find("player").GetComponent<Shooting>();
    }

    // Update is called once per frame
    void Update()
    {
        TextSalle.text = "Salle : " + ClickToMove.numberOfRooms;
        if( currentSalle >= SalleMax)
        {
            currentSalle = SalleMax;
        }
        
        
       
    }

    public void Quest()
    {
        // a remplacer correspond à un int sur le script du joueur, que le script de la balle fera augmenter dès qu'il touche un enemy
        if ( shooting.numberOfKills >= 10 )
        {
            CheckImage.fillAmount = Mathf.Lerp(CheckImage.fillAmount, CheckQuest, Time.deltaTime*2);
         if(CheckImage.fillAmount >= 0.9)
          {
                CheckImage.fillAmount = 1;
                
          }
        }
    }
    /*public void IncreaseRoom()
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
        
    }*/
}
