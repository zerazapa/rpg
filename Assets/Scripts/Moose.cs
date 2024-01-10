using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Moose : MonoBehaviour
{
	public string[] normales = { "saca castigo", "tematica", "rimas", "apellidos", "historia por palabra", "historia por acciones", "alerta", "saca regla" };
	public string[] castigos = { "lastima", "dar castigo", "bomba"};
	public string[] reglas   = { "una copia", "regla personal", "todes copian", "cambiar regla" };
	public int rndm;
	public TextMeshProUGUI texto, counting;
	bool contando;

	public void Normales()
	{
		rndm = Random.Range(0, normales.Length);
		if (rndm == normales.Length - 1)
        {
			rndm = Random.Range(0, normales.Length);
		}
		StopAllCoroutines();
		StartCoroutine(ContarNormales());
	}

	public void Castigos()
    {
		rndm = Random.Range(0, 3);
		if (rndm != 0)
		{
			rndm = Random.Range(0, 3);
			if (rndm == 2)
			{
				rndm = Random.Range(0, 3);
			}
		}
		StopAllCoroutines();
		StartCoroutine(ContarCastigos());
	}

	public void Reglas()
    {
		rndm = Random.Range(0, 4);
		if (rndm == 2)
        {
			rndm = Random.Range(0, 4);
		}
		StopAllCoroutines();
		StartCoroutine(ContarReglas());
	}

	public void Contador()
	{
		
		StopAllCoroutines();
		if (!contando)
        {
			contando = true;
			StartCoroutine(ContarTiempo());
		}
		else
        {
			StartCoroutine(ContarTiempoDesde10());
        }
    }

	public IEnumerator ContarNormales()
	{
		texto.text = "3";
		yield return new WaitForSeconds(.5f);
		texto.text = "2";
		yield return new WaitForSeconds(.5f);
		texto.text = "1";
		yield return new WaitForSeconds(.5f);
		texto.text = normales[rndm];
	}
	public IEnumerator ContarCastigos()
	{
		texto.text = "3";
		yield return new WaitForSeconds(.5f);
		texto.text = "2";
		yield return new WaitForSeconds(.5f);
		texto.text = "1";
		yield return new WaitForSeconds(.5f);
		texto.text = castigos[rndm];
	}
	public IEnumerator ContarReglas()
	{
		texto.text = "3";
		yield return new WaitForSeconds(.5f);
		texto.text = "2";
		yield return new WaitForSeconds(.5f);
		texto.text = "1";
		yield return new WaitForSeconds(.5f);
		texto.text = reglas[rndm];
	}
	public IEnumerator ContarTiempo()
	{
		counting.text = "3";
		yield return new WaitForSeconds(.5f);
		counting.text = "2";
		yield return new WaitForSeconds(.5f);
		counting.text = "1";
		yield return new WaitForSeconds(.5f);
		counting.text = "YA";
		yield return new WaitForSeconds(.5f);
		counting.text = "10";
		yield return new WaitForSeconds(1);
		counting.text = "9";
		yield return new WaitForSeconds(1);
		counting.text = "8";
		yield return new WaitForSeconds(1);
		counting.text = "7";
		yield return new WaitForSeconds(1);
		counting.text = "6";
		yield return new WaitForSeconds(1);
		counting.text = "5";
		yield return new WaitForSeconds(1);
		counting.text = "4";
		yield return new WaitForSeconds(1);
		counting.text = "3";
		yield return new WaitForSeconds(1);
		counting.text = "2";
		yield return new WaitForSeconds(1);
		counting.text = "1";
		yield return new WaitForSeconds(1);
		counting.text = "TIEMPO";
		contando = false;
	}
	public IEnumerator ContarTiempoDesde10()
	{
		counting.text = "10";
		yield return new WaitForSeconds(1);
		counting.text = "9";
		yield return new WaitForSeconds(1);
		counting.text = "8";
		yield return new WaitForSeconds(1);
		counting.text = "7";
		yield return new WaitForSeconds(1);
		counting.text = "6";
		yield return new WaitForSeconds(1);
		counting.text = "5";
		yield return new WaitForSeconds(1);
		counting.text = "4";
		yield return new WaitForSeconds(1);
		counting.text = "3";
		yield return new WaitForSeconds(1);
		counting.text = "2";
		yield return new WaitForSeconds(1);
		counting.text = "1";
		yield return new WaitForSeconds(1);
		counting.text = "TIEMPO";
		contando = false;
	}
}
