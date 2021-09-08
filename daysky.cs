using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daysky : MonoBehaviour
{
    [SerializeField]
    private AudioSource pp;
    [SerializeField]
    private AudioSource vv;
    //day
    [SerializeField]
    private GameObject a;
    [SerializeField]
    private GameObject b;
    [SerializeField]
    private GameObject c;
    [SerializeField]
    private GameObject d;
    [SerializeField]
    private GameObject m;
    [SerializeField]
    private GameObject n;

    //night
    [SerializeField]
    private GameObject e;
    [SerializeField]
    private GameObject f;
    [SerializeField]
    private GameObject g;
    [SerializeField]
    private GameObject h;
    // Start is called before the first frame update
    void Start()
    {
        pp.PlayDelayed(95f);
        vv.PlayDelayed(115f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void aa()
    {
        a.gameObject.SetActive(true);
        b.gameObject.SetActive(false);
        c.gameObject.SetActive(false);
        d.gameObject.SetActive(false);
        e.gameObject.SetActive(true);
        f.gameObject.SetActive(false);
        g.gameObject.SetActive(false);
        h.gameObject.SetActive(false);
        m.gameObject.SetActive(false);
        n.gameObject.SetActive(false);
    }
    public void bb()
    {
        a.gameObject.SetActive(false);
        b.gameObject.SetActive(true);
        c.gameObject.SetActive(false);
        d.gameObject.SetActive(false);
        e.gameObject.SetActive(false);
        f.gameObject.SetActive(true);
        g.gameObject.SetActive(false);
        h.gameObject.SetActive(false);
        m.gameObject.SetActive(false);
        n.gameObject.SetActive(false);

    }
    public void cc()
    {
        a.gameObject.SetActive(false);
        b.gameObject.SetActive(false);
        c.gameObject.SetActive(true);
        d.gameObject.SetActive(false);
        e.gameObject.SetActive(false);
        f.gameObject.SetActive(false);
        g.gameObject.SetActive(true);
        h.gameObject.SetActive(false);
        m.gameObject.SetActive(false);
        n.gameObject.SetActive(false);

    }
    public void dd()
    {
        a.gameObject.SetActive(false);
        b.gameObject.SetActive(false);
        c.gameObject.SetActive(false);
        d.gameObject.SetActive(true);
        e.gameObject.SetActive(false);
        f.gameObject.SetActive(false);
        g.gameObject.SetActive(false);
        h.gameObject.SetActive(true);
        m.gameObject.SetActive(false);
        n.gameObject.SetActive(false);
    }
    public void ee()
    {
        a.gameObject.SetActive(false);
        b.gameObject.SetActive(false);
        c.gameObject.SetActive(false);
        d.gameObject.SetActive(false);
        e.gameObject.SetActive(true);
        f.gameObject.SetActive(false);
        g.gameObject.SetActive(false);
        h.gameObject.SetActive(false);
        m.gameObject.SetActive(true);
        n.gameObject.SetActive(false);

    }
    public void ff()
    {
        a.gameObject.SetActive(false);
        b.gameObject.SetActive(false);
        c.gameObject.SetActive(false);
        d.gameObject.SetActive(false);
        e.gameObject.SetActive(true);
        f.gameObject.SetActive(false);
        g.gameObject.SetActive(false);
        h.gameObject.SetActive(false);
        m.gameObject.SetActive(false);
        n.gameObject.SetActive(false);

    }
    public void gg()
    {
        a.gameObject.SetActive(false);
        b.gameObject.SetActive(false);
        c.gameObject.SetActive(false);
        d.gameObject.SetActive(false);
        e.gameObject.SetActive(false);
        f.gameObject.SetActive(true);
        g.gameObject.SetActive(false);
        h.gameObject.SetActive(false);
        m.gameObject.SetActive(false);
        n.gameObject.SetActive(false);

    }
    public void hh()
    {
        a.gameObject.SetActive(false);
        b.gameObject.SetActive(false);
        c.gameObject.SetActive(false);
        d.gameObject.SetActive(false);
        e.gameObject.SetActive(false);
        f.gameObject.SetActive(false);
        g.gameObject.SetActive(true);
        h.gameObject.SetActive(false);
        m.gameObject.SetActive(false);
        n.gameObject.SetActive(false);

    }
    public void ii()
    {
        a.gameObject.SetActive(false);
        b.gameObject.SetActive(false);
        c.gameObject.SetActive(false);
        d.gameObject.SetActive(false);
        e.gameObject.SetActive(false);
        f.gameObject.SetActive(false);
        g.gameObject.SetActive(false);
        h.gameObject.SetActive(true);
        m.gameObject.SetActive(false);
        n.gameObject.SetActive(false);

    }
    public void mm()
    {
        a.gameObject.SetActive(false);
        b.gameObject.SetActive(false);
        c.gameObject.SetActive(false);
        d.gameObject.SetActive(false);
        e.gameObject.SetActive(false);
        f.gameObject.SetActive(true);
        g.gameObject.SetActive(false);
        h.gameObject.SetActive(false);
        m.gameObject.SetActive(false);
        n.gameObject.SetActive(true);

    }

}
