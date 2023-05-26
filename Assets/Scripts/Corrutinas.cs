using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas : MonoBehaviour
{
    [SerializeField] private GameObject panelIEnumerator;
    [SerializeField] private GameObject panelInvoke;

    public void ActivateCoroutine()
    {
        StartCoroutine(ActivatePanelCoroutine());
        Invoke(nameof(ActivatePanelInvoke), 1f);

        gameObject.SetActive(false);
    }

    private IEnumerator ActivatePanelCoroutine()
    {
        yield return new WaitForSeconds(1f);
        panelIEnumerator.SetActive(true);
    }

    private void ActivatePanelInvoke()
    {
        panelInvoke.SetActive(true);
    }
}