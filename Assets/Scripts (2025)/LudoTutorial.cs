using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LudoTutorial : MonoBehaviour
{
    public GameObject[] tutorialGO;
    public Animation[] tutorialAnims;
    public ParticleSystem[] tutorialParticles;

    private void Awake()
    {
        TutorialStart();
    }

    public void TutorialStart()
    {
        StartCoroutine(WaitTutorial());
    }

    IEnumerator WaitTutorial()
    {
        yield return new WaitForSeconds(1);
        tutorialGO[0].SetActive(true);
        tutorialAnims[0].Play();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}