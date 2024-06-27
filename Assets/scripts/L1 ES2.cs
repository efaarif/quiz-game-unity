
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class L1ES2 : MonoBehaviour
{
    public void backL1ES1()
    {
       SceneManager.LoadScene("");
    }

    public void playL1S2()
    {
       SceneManager.LoadScene("L1S2");
    }



    public GameObject te, se, badahe, zaal, re, sheen, zuad, zoe, ghain, qaaf, kaaf, meem, noon, chotihe, hamza;
    private GameObject teduplicate, seduplicate, badaheduplicate, zaalduplicate, reduplicate, sheenduplicate, zuadduplicate, zoeduplicate, ghainduplicate, qaafduplicate, kaafduplicate, meemduplicate, noonduplicate, chotiheduplicate, hamzaduplicate;

    public Vector2 teInitialPos, seInitialPos, badaheInitialPos, zaalInitialPos, reInitialPos, sheenInitialPos, zuadInitialPos, zoeInitialPos, ghainInitialPos, qaafInitialPos, kaafInitialPos, meemInitialPos, noonInitialPos, chotiheInitialPos, hamzaInitialPos;

    private bool isDraggingTe = false;
    private bool isDraggingSe = false;
    private bool isDraggingBadahe = false;
    private bool isDraggingZaal = false;
    private bool isDraggingRe = false;
    private bool isDraggingSheen = false;
    private bool isDraggingZuad = false;
    private bool isDraggingZoe = false;
    private bool isDraggingGhain = false;
    private bool isDraggingQaaf = false;
    private bool isDraggingKaaf = false;
    private bool isDraggingMeem = false;
    private bool isDraggingNoon = false;
    private bool isDraggingChotihe = false;
    private bool isDraggingHamza = false;
    void Start()
    {
      teInitialPos = te.transform.position;
      seInitialPos = se.transform.position;
      badaheInitialPos = badahe.transform.position;
      zaalInitialPos = zaal.transform.position;
      reInitialPos = re.transform.position;
      sheenInitialPos = sheen.transform.position;
      zuadInitialPos = zuad.transform.position;
      zoeInitialPos = zoe.transform.position;
      ghainInitialPos = ghain.transform.position;
      qaafInitialPos = qaaf.transform.position;
      kaafInitialPos = kaaf.transform.position;
      meemInitialPos = meem.transform.position;
      noonInitialPos = noon.transform.position;
      chotiheInitialPos = chotihe.transform.position;
      hamzaInitialPos = hamza.transform.position;

    }

    public bool IsPointerDownGameObject(GameObject obj)
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(mousePos2D, 0.1f);

        foreach (Collider2D hitCollider in hitColliders)
        {
            if (hitCollider.gameObject == obj)
            {
                return true;
            }
        }

        return false;
    }

    public void Update()
    {
        Debug.Log("Update method is running...");
        if (Input.GetMouseButtonDown(0))
        {
            if (IsPointerDownGameObject(te))
            {
                isDraggingTe = true;
            }
            else if (IsPointerDownGameObject(se))
            {
                isDraggingSe = true;
            }
            else if (IsPointerDownGameObject(badahe))
            {
                isDraggingBadahe = true;
            }
            else if (IsPointerDownGameObject(zaal))
            {
                isDraggingZaal = true;
            }
            else if (IsPointerDownGameObject(re))
            {
                isDraggingRe = true;
            }
            else if (IsPointerDownGameObject(sheen))
            {
                isDraggingSheen = true;
            }
            else if (IsPointerDownGameObject(zuad))
            {
                isDraggingZuad = true;
            }
            else if (IsPointerDownGameObject(zoe))
            {
                isDraggingZoe = true;
            }
            else if (IsPointerDownGameObject(ghain))
            {
                isDraggingGhain = true;
            }
            else if (IsPointerDownGameObject(qaaf))
            {
                isDraggingQaaf = true;
            }
            else if (IsPointerDownGameObject(kaaf))
            {
                isDraggingKaaf = true;
            }
            else if (IsPointerDownGameObject(meem))
            {
                isDraggingMeem = true;
            }
            else if (IsPointerDownGameObject(noon))
            {
                isDraggingNoon = true;
            }
            else if (IsPointerDownGameObject(chotihe))
            {
                isDraggingChotihe = true;
            }
            else if (IsPointerDownGameObject(hamza))
            {
                isDraggingHamza = true;
            }
        }
    
      if (Input.GetMouseButtonUp(0))
        {
            isDraggingTe = false;
            isDraggingSe = false;
            isDraggingBadahe = false;
            isDraggingZaal = false;
            isDraggingRe = false;
            isDraggingSheen = false;
            isDraggingZuad = false;
            isDraggingZoe = false;
            isDraggingGhain = false;
            isDraggingQaaf = false;
            isDraggingKaaf = false;
        }

        if (isDraggingTe)
        {
            te.transform.position = Input.mousePosition;
        }

        if (isDraggingSe)
        {
            se.transform.position = Input.mousePosition;
        }

        if (isDraggingBadahe)
        {
            badahe.transform.position = Input.mousePosition;
        }

        if (isDraggingZaal)
        {
            zaal.transform.position = Input.mousePosition;
        }

        if (isDraggingRe)
        {
            re.transform.position = Input.mousePosition;
        }

        if (isDraggingSheen)
        {
            sheen.transform.position = Input.mousePosition;
        }

        if (isDraggingZuad)
        {
            zuad.transform.position = Input.mousePosition;
        }

        if (isDraggingZoe)
        {
            zoe.transform.position = Input.mousePosition;
        }

        if (isDraggingGhain)
        {
            ghain.transform.position = Input.mousePosition;
        }

        if (isDraggingQaaf)
        {
            qaaf.transform.position = Input.mousePosition;
        }

        if (isDraggingKaaf)
        {
            kaaf.transform.position = Input.mousePosition;
        }

        if (isDraggingMeem)
        {
            meem.transform.position = Input.mousePosition;
        }

        if (isDraggingNoon)
        {
            noon.transform.position = Input.mousePosition;
        }

        if (isDraggingChotihe)
        {
            chotihe.transform.position = Input.mousePosition;
        }

        if (isDraggingHamza)
        {
            hamza.transform.position = Input.mousePosition;
        }
    }
    
      

    public void DropTe()
    {
      float Distance = Vector3.Distance(te.transform.position, teduplicate.transform.position);
       if (Distance >= 50)
        {
            te.transform.position = teInitialPos;
        }
        else
        {
            te.transform.position = teduplicate.transform.position;
        }
    }

    public void DropSe()
    {
      float Distance = Vector3.Distance(se.transform.position, seduplicate.transform.position);
       if (Distance >= 50)
        {
          se.transform.position = seInitialPos;
        }
        else
        {
            se.transform.position = seduplicate.transform.position;
        }
    }

    public void DropBadahe()
    {
      float Distance = Vector3.Distance(badahe.transform.position, badaheduplicate.transform.position);
       if (Distance >= 50)
        {
            badahe.transform.position = badaheInitialPos;
        }
        else
        {
            badahe.transform.position = badaheduplicate.transform.position;
        }
    }

    public void DropZaal()
    {
      float Distance = Vector3.Distance(zaal.transform.position, zaalduplicate.transform.position);
       if (Distance >= 50)
        {
            zaal.transform.position = zaalInitialPos;
        }
        else
        {
            zaal.transform.position = zaalduplicate.transform.position;
        }
    }

    public void DropRe()
    {
      float Distance = Vector3.Distance(re.transform.position, reduplicate.transform.position);
       if (Distance >= 50)
        {
            re.transform.position = reInitialPos;
        }
        else
        {
            re.transform.position = reduplicate.transform.position;
        }
    }

    public void DropSheen()
    {
      float Distance = Vector3.Distance(sheen.transform.position, sheenduplicate.transform.position);
       if (Distance >= 50)
        {
            sheen.transform.position = sheenInitialPos;
        }
        else
        {
            sheen.transform.position = sheenduplicate.transform.position;
        }
    }

    public void DropZuad()
    {
      float Distance = Vector3.Distance(zuad.transform.position, zuadduplicate.transform.position);
       if (Distance >= 50)
        {
            zuad.transform.position = zuadInitialPos;
        }
        else
        {
            zuad.transform.position = zuadduplicate.transform.position;
        }
    }

    public void DropZoe()
    {
      float Distance = Vector3.Distance(zoe.transform.position, zoeduplicate.transform.position);
       if (Distance >= 50)
        {
            zoe.transform.position = zoeInitialPos;
        }
        else
        {
            zoe.transform.position = zoeduplicate.transform.position;
        }
    }

    public void DropGhain()
    {
      float Distance = Vector3.Distance(ghain.transform.position, ghainduplicate.transform.position);
       if (Distance >= 50)
        {
            ghain.transform.position = ghainInitialPos;
        }
        else
        {
            ghain.transform.position = ghainduplicate.transform.position;
        }
    }

    public void DropQaaf()
    {
      float Distance = Vector3.Distance(qaaf.transform.position, qaafduplicate.transform.position);
       if (Distance >= 50)
        {
            qaaf.transform.position = qaafInitialPos;
        }
        else
        {
            qaaf.transform.position = qaafduplicate.transform.position;
        }
    }

    public void DropKaaf()
    {
      float Distance = Vector3.Distance(kaaf.transform.position, kaafduplicate.transform.position);
       if (Distance >= 50)
        {
            kaaf.transform.position = kaafInitialPos;
        }
        else
        {
            kaaf.transform.position = kaafduplicate.transform.position;
        }
    }

    public void DropMeem()
    {
      float Distance = Vector3.Distance(meem.transform.position, meemduplicate.transform.position);
       if (Distance >= 50)
        {
            meem.transform.position = meemInitialPos;
        }
        else
        {
            meem.transform.position = meemduplicate.transform.position;
        }
    }

    public void DropNoon()
    {
      float Distance = Vector3.Distance(noon.transform.position, noonduplicate.transform.position);
       if (Distance >= 50)
        {
            noon.transform.position = noonInitialPos;
        }
        else
        {
            noon.transform.position = noonduplicate.transform.position;
        }
    }

    public void DropChotihe()
    {
      float Distance = Vector3.Distance(chotihe.transform.position, chotiheduplicate.transform.position);
       if (Distance >= 50)
        {
            chotihe.transform.position = chotiheInitialPos;
        }
        else
        {
            chotihe.transform.position = chotiheduplicate.transform.position;
        }
    }


    public void DropHamza()
    {
      float Distance = Vector3.Distance(hamza.transform.position, hamzaduplicate.transform.position);
       if (Distance >= 50)
        {
            hamza.transform.position = hamzaInitialPos;
        }
        else
        {
            hamza.transform.position = hamzaduplicate.transform.position;
        }
    }

}

