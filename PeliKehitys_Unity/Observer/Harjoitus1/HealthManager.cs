using System;
using TMPro;
using UnityEngine;
/// <summary>
/// Huolehtii pelaajan terveydest‰
/// </summary>
public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance { get; set; }
    [SerializeField] private float hp = 100;
    // Delegate - m‰‰ritys
    public delegate void OnHealthChange();
    // Delegate - muuttujan m‰‰ritys
    //public OnHealthChange onHealthChange;
    // static-m‰‰re mahdollistaa muiden luokkien reagoida tapahtumaan
    public static OnHealthChange onHealthChange;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        // = yhteys vain metodin sis‰iseen kuuntelijaan
        // += sallii yhteyden useampaan kuuntelijaan
        // -= poistaa yhteyden kuuntelijoihin
        // = null eli ei yht‰‰n kuuntelijaa
    }
    private void OnEnable()
    {
        // Luokka kuuntelee OnHealthChange tapahtumaa ja reagoi siihen
        onHealthChange += Death; // Death() -metodi aktivoidaan
    }
    private void OnDisable()
    {
        onHealthChange -= Death; // Death() -metodi deaktivoidaan
    }
    // V‰hent‰‰ pelaajan terveytt‰
    // T‰m‰ metodi k‰ynnist‰‰ metodin, jos ehto t‰yttyy
    public void TakeDamage(float amount)
    {
        hp -= amount;
        if (hp < 0)
        {
            print("Pelaaja kuoli!");
            // Tapahtumat k‰ynnistyv‰t
            onHealthChange?.Invoke(); // Tarkistetaan ettei ole null.
        }
    }
    // Metodi suoritetaan kun tapahtuma k‰ynnistyy.
    private void Death()
    {
        // Tuhoa pelaaja
        Destroy(gameObject);
    }
}