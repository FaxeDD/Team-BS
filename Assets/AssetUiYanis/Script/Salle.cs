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
    float CheckQuest = 1f;

    private ClickToMove ClickToMove;
    private ShootBullet ShootBullet;

    public TextMeshProUGUI questTxt;

    public GameObject questObject;
    

    // Start is called before the first frame update
    void Start()
    {
        //TextQuest.SetActive(false);
        ClickToMove = GameObject.Find("player").GetComponent<ClickToMove>();
        ShootBullet = GameObject.Find("player").GetComponent<ShootBullet>();
    }

    // Update is called once per frame
    void Update()
    {
        TextSalle.text = "Salle : " + ClickToMove.numberOfRooms;
        if( currentSalle >= SalleMax)
        {
            currentSalle = SalleMax;
        }
        
        questTxt.text = "Number of kills " + ShootBullet.NumberOfKills + "/5"; 

        if ( ShootBullet.NumberOfKills >= 5 )
        {
            //Debug.Log("Quest accomplished");
            CheckImage.fillAmount = Mathf.Lerp(CheckImage.fillAmount, CheckQuest , Time.deltaTime*2);
         if(CheckImage.fillAmount >= 0.9)
          {
                CheckImage.fillAmount = 1;
                StartCoroutine(QuestDissapears());
                
          }
        }
        
       
    }

    IEnumerator QuestDissapears()
    {
        yield return new WaitForSeconds(2);

        

        questObject.SetActive(false);
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
