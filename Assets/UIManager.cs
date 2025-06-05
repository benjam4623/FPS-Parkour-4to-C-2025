using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney; // variable donde yo voy a tener una referencia a un texto de UI, ese texto en la UI va a tener un valor, el que yo le diga abajo
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateMoneyTxt(string moneyamount)
    {
        txtMoney.text = moneyAmount; // money amoun es un parámetro, estoy generando como un espacio para que me pasen un dato de tipo string. Cuando yo detecte una compra, actualiza el dinero que tengo y poné esta cantidad de plata
    }
}
