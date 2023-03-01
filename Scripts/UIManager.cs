using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject Arrival_Slider_Object;
    public GameObject Arrival_Txt_Object;
    public GameObject PlayerHP_Slider_Object;
    public GameObject PlayerHP_Txt_Object;
    //public GameObject PlayerWea_Txt_Object;
    //public GameObject PlayerBulletCount_Txt_Object; 
    //public GameObject PlayerCurrentBulletCount_Txt_Object; 
    //public GameObject PlayerMissileCount_Txt_Object;

    Slider Arrival_Slider;
    TextMeshProUGUI Arrival_Txt;
    Slider PlayerHP_Slider;
    TextMeshProUGUI PlayerHP_Txt;
    //TextMeshPro PlayerWea_Txt;
    //TextMeshPro PlayerBulletCount_Txt;
    //TextMeshPro PlayerCurrentBulletCount_Txt;
    //TextMeshPro PlayerMissileCount_Txt;

    float ArrivalPersent;
    float PlayerHP;
    //float PlayerCurrentWeapon;
    //float PlayerCurrentBulletCount;
    //float PlayerBulletCount;
    //float PlayerMissileCount;

    void Start()
    {
        //Arrival_Txt_Object = GameObject.Find("Arrival_txt");
        //PlayerHP_Txt_Object = GameObject.Find("PlayerHP_txt");

        Arrival_Slider = Arrival_Slider_Object.GetComponent<Slider>();
        Arrival_Txt = Arrival_Txt_Object.GetComponent<TextMeshProUGUI>();
        PlayerHP_Slider = PlayerHP_Slider_Object.GetComponent<Slider>();
        PlayerHP_Txt = PlayerHP_Txt_Object.GetComponent<TextMeshProUGUI>();
        //PlayerWea_Txt = PlayerWea_Txt_Object.GetComponent<TextMeshPro>();
        //PlayerBulletCount_Txt = PlayerBulletCount_Txt_Object.GetComponent<TextMeshPro>();
        //PlayerCurrentBulletCount_Txt = PlayerCurrentBulletCount_Txt_Object.GetComponent<TextMeshPro>();
        //PlayerMissileCount_Txt = PlayerMissileCount_Txt_Object.GetComponent <TextMeshPro>();

        ArrivalPersent = 0.01f;
        PlayerHP = 1f;
        //PlayerCurrentWeapon = 1; // 1) ±â°üÃÑ (±âº»), 2) ¹Ì»çÀÏ, 3) ¾î·Ú
        //PlayerCurrentBulletCount = 30;
        //PlayerBulletCount = 30;
        //PlayerMissileCount = 5;
        Debug.Log(PlayerHP);
        Debug.Log(PlayerHP_Txt);
        ReloadPlayer();
    }

    void Update()
    {
        ReloadPlayer();
    }

    void FixedUpdate()
    {
        ArrivalPersent += 0.0002f;
        ReloadPlayer();
    }

    void ReloadPlayer()
    {
        Arrival_Slider.value = ArrivalPersent;
        Arrival_Txt.text = (Mathf.Round(ArrivalPersent * 100)).ToString();
        PlayerHP_Slider.value = PlayerHP;
        PlayerHP_Txt.text = (Mathf.Round(PlayerHP * 100)).ToString();
        //PlayerWea_Txt.text = PlayerCurrentWeapon.ToString();
        //PlayerCurrentBulletCount_Txt.text = PlayerCurrentBulletCount.ToString();
        //PlayerBulletCount_Txt.text = PlayerBulletCount.ToString();
        //PlayerMissileCount_Txt.text = PlayerMissileCount.ToString();
    }
    public void Damaged(float damage)
    {
        PlayerHP -= damage;
        PlayerHP_Slider.value = PlayerHP;
        PlayerHP_Txt.text = (Mathf.Round(PlayerHP*100)).ToString();
    }
}
