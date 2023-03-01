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
        MainTxt.text = "2019�� �� ���� ���۵Ǿ� �����踦 ����� ���̷���";
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
                MainTxt.text = "2019�� �� ���� ���۵Ǿ� �����踦 ����� ���̷���";
                break;
            case 1:
                MainTxt.text = "�ڷγ� ���̷��� (COVID-19)";
                break;
            case 2:
                MainTxt.text = "1964�� ���� 56�� ���� �ø����� �����ϴ� �Ϻ�";
                break;
            case 3:
                MainTxt.text = "�ڷγ� ���̷����� ���� ��ǻ� ����� ���ɼ��� ����.";
                break;
            case 4:
                MainTxt.text = "�Ϻ� ���δ� �ø��� ��ġ�� �� ���� �������� ����� �����ؼ���, ����Ǵ� �͸��� ���ؾ� �Ѵ�.";
                break;
            case 5:
                MainTxt.text = "�ֺ����� ������ ��û�غ�����, ������ ��ƴٰ� �Ѵ�.";
                break;
            case 6:
                MainTxt.text = "�׷��� �� �� ������ ������ ���µ���";
                break;
            case 7:
                MainTxt.text = "�װ��� �ٷ� ���ѹα�!";
                break;
            case 8:
                MainTxt.text = "�ѱ����� ����� ������ �����Ͽ� �Ϻ��� �����Ѵٰ� �Ѵ�.";
                break;
            case 9:
                MainTxt.text = "������, �ѱ����� ���� ����� �Ϻ����� �̼��Ϸ��� ���� �ð��� �ɸ���.";
                break;
            case 10:
                MainTxt.text = "�� ����� 24�ð� �̳� �̼۵Ǿ�� �ϸ�, ������� �λ���, �������� �Ϻ� �����ϸ����̴�.";
                break;
            case 11:
                MainTxt.text = "����, ����� ���籤���� ����Ǹ� �ȵǸ�, ������ ��鸲���� ����ϴ�.";
                break;
            case 12:
                MainTxt.text = "������, �ѱ��� �Ϻ� ���� ���� ��Ÿ�� ������������ ����� ��Ż�Ϸ��� ������ �ִٰ� �Ѵ�.";
                break;
            case 13:
                MainTxt.text = "�Ϻ����� ����� �ż��ϰ� �����ϰ� �̼��ϴ� ������ ���۵Ǿ���.";
                break;
            case 14:
                SceneManager.LoadScene("GameScene");
                break;
        }
    }

    
}
