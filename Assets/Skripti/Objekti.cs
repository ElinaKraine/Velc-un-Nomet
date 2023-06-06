using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
    public GameObject b2;
    public GameObject cementaMasina;
    public GameObject e46;
    public GameObject e61;
    public GameObject eskavators;
    public GameObject policija;
    public GameObject traktors1;
    public GameObject traktors5;
    public GameObject ugunsdzeseji;

    [HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atraPKoord;
	[HideInInspector]
	public Vector2 bussKoord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 cemMKoord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 e61Koord;
    [HideInInspector]
    public Vector2 eskKoord;
    [HideInInspector]
    public Vector2 polKoord;
    [HideInInspector]
    public Vector2 trak1Koord;
    [HideInInspector]
    public Vector2 trak5Koord;
    [HideInInspector]
    public Vector2 ugunsKoord;

    public Canvas kanva;

    public GameObject poga; //Poga, lai restartētu spēli
    public GameObject kartinka; //izkartne
    public GameObject tekst; //Teksta lodziņš, kurā būs redzams rezultārs
    public int masinasSkaits=0; //Papildu mainigais, lai noteikt, cik daudz mašīnas atrodas to pareizajās vietās
    private float sakumaLaiks; //Mainigais, kas skaita laiku no palaišanas sākuma
    public GameObject z1; //pirma zvaigzne
    public GameObject z2; //otra zvaigzne
    public GameObject z3; //treša zvaigzne

	public AudioSource audioAvots;
	public AudioClip[] skanasKoatskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;

	void Start () {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atraPKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
        b2Koord = b2.GetComponent<RectTransform>().localPosition;
        cemMKoord = cementaMasina.GetComponent<RectTransform>().localPosition;
        e46Koord = e46.GetComponent<RectTransform>().localPosition;
        e61Koord = e61.GetComponent<RectTransform>().localPosition;
        eskKoord = eskavators.GetComponent<RectTransform>().localPosition;
        polKoord = policija.GetComponent<RectTransform>().localPosition;
        trak1Koord = traktors1.GetComponent<RectTransform>().localPosition;
        trak5Koord = traktors5.GetComponent<RectTransform>().localPosition;
        ugunsKoord = ugunsdzeseji.GetComponent<RectTransform>().localPosition;
        sakumaLaiks = Time.time; //laiks ir sācis skaitīties
    }
    //Metode, lai pārbaudītu spēles galarezultātu un rezultāta parādīšana
    public void parbaudisana() {
        if (masinasSkaits >= 12) { //Ja visas mašīnas atrodas pareizajās vietās
            kartinka.SetActive(true); //Parādās izkartne
            poga.SetActive(true); //Parādās poga
            tekst.SetActive(true); //Parādās teksta lodziņš
            float cikLaiks = Time.time - sakumaLaiks; //cikLaiks saturēs laika daudzumu sekundēs no brīža, kad tika izsaukta Start() metode, līdz brīdim, kad visas mašīnas atrodas savas pareizajas vietās
            int stundas = (int) cikLaiks / 3600; //aprēķina stundas
            int minutes = (int) (cikLaiks%3600) / 60; //aprēķina minutes
            int sekundes = (int) (cikLaiks%3600) % 60; //aprēķina sekundes
            string laiks = string.Format("{0:00}:{1:00}:{2:00}", stundas, minutes, sekundes); //Formatējo, lai būtu hh:mm:ss formats
            string str = "Tavs rezultats: \n" + laiks; //teksta saglabāšana
            tekst.GetComponent<Text>().text = str; //teksts saglabā teksta lodziņā
            if (minutes<2) //ja spēle ilga mazāk nekā divas minūtes
            {
                z1.SetActive(true); //visas zvaigznes ir redzamas
                z2.SetActive(true);
                z3.SetActive(true);
            }else if(minutes<3) //ja spēle ilga mazāk nekā trīs minūtes
            {
                z1.SetActive(true); //tikai divas zvaigznes ir redzamas
                z2.SetActive(true);
            }
            else //ja spēle ilga vairāk nekā trīs minūtes
            {
                z1.SetActive(true); //viena zvaigzne ir redzama
            }
        }
    }

}
