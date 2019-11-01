using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPlant : MonoBehaviour
{
    public GameObject Marichuana;
    public GameObject Amfetamina;
    public GameObject Metamfetamina;
    public GameObject Opium;
    public GameObject Kokaina;
    public void play()// TUTAJ MOZNA ZMIENIC ZEBY BYLO ODPOWIEDNIE DLA INNEJ WYTWORNI
    {
        SceneManager.LoadScene("Gra");
        VariableTag.new_game = true; 
    }
}
