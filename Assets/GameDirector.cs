using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject hpGauge;

    void Start()
    {
        //Find = シーン中の中から該当するオブジェクトを探し、変数に代入する
        this.hpGauge = GameObject.Find("hpGauge");
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image> ().fillAmount -= 0.1f;
    }
}
    