using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;



public class DragAndDrop : MonoBehaviour
{
    public GameObject te, se, badahe, zaal, re, sheen, zuad, zoe, ghain, qaaf, kaaf, meem, noon, chotihe, hamza;
    public GameObject teduplicate, seduplicate, badaheduplicate, zaalduplicate, reduplicate, sheenduplicate, zuadduplicate, zoeduplicate, ghainduplicate, qaafduplicate, kaafduplicate, meemduplicate, noonduplicate, chotiheduplicate, hamzaduplicate;

    private Vector2 teInitialPos, seInitialPos, badaheInitialPos, zaalInitialPos, reInitialPos, sheenInitialPos, zuadInitialPos, zoeInitialPos, ghainInitialPos, qaafInitialPos, kaafInitialPos, meemInitialPos, noonInitialPos, chotiheInitialPos, hamzaInitialPos;


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

    public void dragte()
    {
        te.transform.position = Input.mousePosition;
        Console.WriteLine(te.transform.position);
    }

    public void dragse()
    {
        se.transform.position = Input.mousePosition;
        Console.WriteLine(se.transform.position);
    }

    public void dragbadahe()
    {
        badahe.transform.position = Input.mousePosition;
        Console.WriteLine(badahe.transform.position);
    }

    public void dragzaal()
    {
        zaal.transform.position = Input.mousePosition;
    }

    public void dragre()
    {
        re.transform.position = Input.mousePosition;
    }

    public void dragsheen()
    {
        sheen.transform.position = Input.mousePosition;
    }

    public void dragzuad()
    {
        zuad.transform.position = Input.mousePosition;
    }

    public void dragzoe()
    {
        zoe.transform.position = Input.mousePosition;
    }

    public void dragghain()
    {
        ghain.transform.position = Input.mousePosition;
    }

    public void dragqaaf()
    {
        qaaf.transform.position = Input.mousePosition;
    }

    public void dragkaaf()
    {
        kaaf.transform.position = Input.mousePosition;
    }

    public void dragmeem()
    {
        meem.transform.position = Input.mousePosition;
    }

    public void dragnoon()
    {
        noon.transform.position = Input.mousePosition;
    }

    public void dragchotihe()
    {
        chotihe.transform.position = Input.mousePosition;
    }

    public void draghamza()
    {
        hamza.transform.position = Input.mousePosition;
    }


    bool IsPointerDownGameObject(GameObject obj)
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

    public void Dropte()
    {
        float distance = Vector3.Distance(te.transform.position, teduplicate.transform.position);
        if (distance >= 50)
        {
            te.transform.position = teInitialPos;
        }
        else
        {
            te.transform.position = teduplicate.transform.position;
        }

    }

    public void Dropse()
    {
        float distance = Vector3.Distance(se.transform.position, seduplicate.transform.position);
        if (distance >= 50)
        {
            se.transform.position = seInitialPos;
        }
        else
        {
            se.transform.position = seduplicate.transform.position;
        }
    }


    public void Dropbadahe()
    {
        float distance = Vector3.Distance(badahe.transform.position, badaheduplicate.transform.position);
        if (distance >= 50)
        {
            badahe.transform.position = badaheInitialPos;
        }
        else
        {
            badahe.transform.position = badaheduplicate.transform.position;
        }
    }


    public void Dropzaal()
    {
        float distance = Vector3.Distance(zaal.transform.position, zaalduplicate.transform.position);
        if (distance >= 50)
        {
            zaal.transform.position = zaalInitialPos;
        }
        else
        {
            zaal.transform.position = zaalduplicate.transform.position;
        }
    }


    public void Dropre()
    {
        float distance = Vector3.Distance(re.transform.position, reduplicate.transform.position);
        if (distance >= 50)
        {
            re.transform.position = reInitialPos;
        }
        else
        {
            re.transform.position = reduplicate.transform.position;
        }
    }

    public void Dropsheen()
    {
        float distance = Vector3.Distance(sheen.transform.position, sheenduplicate.transform.position);
        if (distance >= 50)
        {
            sheen.transform.position = sheenInitialPos;
        }
        else
        {
            sheen.transform.position = sheenduplicate.transform.position;
        }
    }

    public void Dropzuad()
    {
        float distance = Vector3.Distance(zuad.transform.position, zuadduplicate.transform.position);
        if (distance >= 50)
        {
            zuad.transform.position = zuadInitialPos;
        }
        else
        {
            zuad.transform.position = zuadduplicate.transform.position;
        }
    }

    public void Dropzoe()
    {
        float distance = Vector3.Distance(zoe.transform.position, zoeduplicate.transform.position);
        if (distance >= 50)
        {
            zoe.transform.position = zoeInitialPos;
        }
        else
        {
            zoe.transform.position = zoeduplicate.transform.position;
        }
    }

    public void Dropghain()
    {
        float distance = Vector3.Distance(ghain.transform.position, ghainduplicate.transform.position);
        if (distance >= 50)
        {
            ghain.transform.position = ghainInitialPos;
        }
        else
        {
            ghain.transform.position = ghainduplicate.transform.position;
        }
    }

    public void Dropqaaf()
    {
        float distance = Vector3.Distance(qaaf.transform.position, qaafduplicate.transform.position);
        if (distance >= 50)
        {
            qaaf.transform.position = qaafInitialPos;
        }
        else
        {
            qaaf.transform.position = qaafduplicate.transform.position;
        }
    }

    public void Dropkaaf()
    {
        float distance = Vector3.Distance(kaaf.transform.position, kaafduplicate.transform.position);
        if (distance >= 50)
        {
            kaaf.transform.position = kaafInitialPos;
        }
        else
        {
            kaaf.transform.position = kaafduplicate.transform.position;
        }
    }

    public void Dropmeem()
    {
        float distance = Vector3.Distance(meem.transform.position, meemduplicate.transform.position);
        if (distance >= 50)
        {
            meem.transform.position = meemInitialPos;
        }
        else
        {
            meem.transform.position = meemduplicate.transform.position;
        }
    }

    public void Dropnoon()
    {
        float distance = Vector3.Distance(noon.transform.position, noonduplicate.transform.position);
        if (distance >= 50)
        {
            noon.transform.position = noonInitialPos;
        }
        else
        {
            noon.transform.position = noonduplicate.transform.position;
        }
    }

    public void Dropchotihe()
    {
        float distance = Vector3.Distance(chotihe.transform.position, chotiheduplicate.transform.position);
        if (distance >= 50)
        {
            chotihe.transform.position = chotiheInitialPos;
        }
        else
        {
            chotihe.transform.position = chotiheduplicate.transform.position;
        }
    }

    public void Drophamza()
    {
        float distance = Vector3.Distance(hamza.transform.position, hamzaduplicate.transform.position);
        if (distance >= 50)
        {
            hamza.transform.position = hamzaInitialPos;
        }
        else
        {
            hamza.transform.position = hamzaduplicate.transform.position;
        }
    }


    public void backL1PAGE2()
    {
        SceneManager.LoadScene("L1PAGE2");
    }

    public void playL1PAGE4()
    {
        SceneManager.LoadScene("L1PAGE4");
    }

}