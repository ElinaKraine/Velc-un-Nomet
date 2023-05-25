using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler {
	private float vietasZRot, velkObjRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null) {
            if (eventData.pointerDrag.tag.Equals(tag)) {
                vietasZRot = GetComponent<RectTransform>().transform.eulerAngles.z;
                velkObjRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
                rotacijasStarpiba = Mathf.Abs(velkObjRot - vietasZRot);
                velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
                vietasIzm = GetComponent<RectTransform>().localScale;
                xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
                yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);
                if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba<=360)) && (xIzmeruStarp<=0.1 && yIzmeruStarp <= 0.1)) {
                    objektuSkripts.vaiIstajaVieta = true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;
                    switch(eventData.pointerDrag.tag) {
                        case "atkritumu":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoatskanot[1]);
                            break;
                        case "medicina":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoatskanot[2]);
                            break;
                        case "buss":
                            objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoatskanot[3]);
                            break;
                    }
                }
            } else {
                objektuSkripts.vaiIstajaVieta = false;
                objektuSkripts.audioAvots.PlayOneShot(objektuSkripts.skanasKoatskanot[0]);
                switch (eventData.pointerDrag.tag) {
                    case "atkritumu":
                        objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrMKoord;
                        break;
                    case "medicina":
                        objektuSkripts.atraPalidziba.GetComponent<RectTransform>().localPosition = objektuSkripts.atraPKoord;
                        break;
                    case "buss":
                        objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
                        break;
                }

            }
        }
    }
}
