using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }
	
}
