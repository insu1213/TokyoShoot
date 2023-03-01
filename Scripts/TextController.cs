using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{
    public GameObject MainTxtObject;
    TextMeshProUGUI MainTxt;
    int txtNumber;
    
    void Start()
    {
        txtNumber = 0;
        MainTxt = MainTxtObject.GetComponent<TextMeshProUGUI>();
        MainTxt.text = "2019년 말 부터 시작되어 전세계를 뒤흔든 바이러스";
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            txtNumber++;
            ArrText();
        }
    }

    private void ArrText()
    {
        switch(txtNumber)
        {
            case 0:
                MainTxt.text = "2019년 말 부터 시작되어 전세계를 뒤흔든 바이러스";
                break;
            case 1:
                MainTxt.text = "코로나 바이러스 (COVID-19)";
                break;
            case 2:
                MainTxt.text = "1964년 이후 56년 만에 올림픽을 개최하는 일본";
                break;
            case 3:
                MainTxt.text = "코로나 바이러스로 인해 사실상 연기될 가능성이 높다.";
                break;
            case 4:
                MainTxt.text = "일본 정부는 올림픽 유치에 들어간 비용과 선수들의 노력을 생각해서라도, 연기되는 것만은 피해야 한다.";
                break;
            case 5:
                MainTxt.text = "주변국에 도움을 요청해보지만, 지원이 어렵다고 한다.";
                break;
            case 6:
                MainTxt.text = "그런데 단 한 곳에서 연락이 오는데…";
                break;
            case 7:
                MainTxt.text = "그곳은 바로 대한민국!";
                break;
            case 8:
                MainTxt.text = "한국에서 백신을 조만간 개발하여 일본에 수출한다고 한다.";
                break;
            case 9:
                MainTxt.text = "하지만, 한국에서 만든 백신을 일본까지 이송하려면 오랜 시간이 걸린다.";
                break;
            case 10:
                MainTxt.text = "이 백신은 24시간 이내 이송되어야 하며, 출발지는 부산항, 목적지는 일본 요코하마항이다.";
                break;
            case 11:
                MainTxt.text = "또한, 백신은 직사광선에 노출되면 안되며, 과도한 흔들림에도 취약하다.";
                break;
            case 12:
                MainTxt.text = "요즈음, 한국과 일본 영해 사이 배타적 경제수역에서 백신을 약탈하려는 해적이 있다고 한다.";
                break;
            case 13:
                MainTxt.text = "일본까지 백신을 신속하고 안전하게 이송하는 작전이 시작되었다.";
                break;
            case 14:
                SceneManager.LoadScene("GameScene");
                break;
        }
    }

    
}
