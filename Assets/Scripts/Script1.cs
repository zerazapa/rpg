using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Script1 : MonoBehaviour
{
    public string[] nombres = new string[3];
    int namechosen;
    int hp1, arm1, str1, hp2, arm2, str2, hp3, arm3, str3;
    public GameObject bot1, bot2, bot3, bot4, bot5;
    public TextMeshProUGUI name1, hp1text, str1text, name2, hp2text, str2text, name3, hp3text, str3text;
    public GameObject pt1, pt2;
    public string[] eNombres = new string[2];
    int rndmEnemy;
    string eNameChosen;
    int eHp1, eArm1, eStr1, eHp2, eArm2, eStr2;
    public TextMeshProUGUI eName1, eHp1text, eStr1text, eName2, eHp2text, eStr2text;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void SelectCharacterTichu()
    {
        namechosen = 0;
        SetStats();
        bot1.SetActive(false);
    }
    public void SelectCharacterEmi()
    {
        namechosen = 1;
        SetStats();
        bot2.SetActive(false);
    }
    public void SelectCharacterBoruro()
    {
        namechosen = 2;
        SetStats();
        bot3.SetActive(false);
    }
    public void SelectCharacterAnnKuu()
    {
        namechosen = 3;
        SetStats();
        bot4.SetActive(false);
    }
    public void SelectCharacterVivian()
    {
        namechosen = 4;
        SetStats();
        bot5.SetActive(false);
    }
    void SetStats()
    {        
        if (nombres[0] == "")
        {
            nombres[0] = CharList.charNames[namechosen];
            hp1 = CharList.charHp[namechosen];
            arm1 = hp1;
            str1 = CharList.charStr[namechosen];
            
        }
        else if (nombres[1] == "")
        {
            nombres[1] = CharList.charNames[namechosen];
            hp2 = CharList.charHp[namechosen];
            arm2 = hp2;
            str2 = CharList.charStr[namechosen];
        }
        else if (nombres[2] == "")
        {
            nombres[2] = CharList.charNames[namechosen];
            hp3 = CharList.charHp[namechosen];
            arm3 = hp3;
            str3 = CharList.charStr[namechosen];

            pt1.SetActive(false);

            name1.text = nombres[0];
            hp1text.text = hp1.ToString();
            str1text.text = str1.ToString();
            name2.text = nombres[1];
            hp2text.text = hp2.ToString();
            str2text.text = str2.ToString();
            name3.text = nombres[2];
            hp3text.text = hp3.ToString();
            str3text.text = str3.ToString();
            pt2.SetActive(true);
            RandomEnemy();
        }
    }

    void RandomEnemy()
    {
        rndmEnemy = Random.Range(0, 10);
        eNameChosen = CharList.charNames[rndmEnemy];
        eNombres[0] = eNameChosen;
        eHp1 = CharList.charHp[rndmEnemy];
        eArm1 = eHp1;
        eStr1 = CharList.charStr[rndmEnemy];
        rndmEnemy = Random.Range(0, 10);
        eNameChosen = CharList.charNames[rndmEnemy];
        eNombres[1] = eNameChosen;
        eHp2 = CharList.charHp[rndmEnemy];
        eArm2 = eHp1;
        eStr2 = CharList.charStr[rndmEnemy];

        eName1.text = eNombres[0];
        eHp1text.text = eHp1.ToString();
        eStr1text.text = eStr1.ToString();
        eName2.text = eNombres[1];
        eHp2text.text = eHp2.ToString();
        eStr2text.text = eStr2.ToString();

    }
    
}
