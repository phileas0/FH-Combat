using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TutorialTrigger : MonoBehaviour
{
    public TMP_Text instructionText; // Referenz zum UI-Text
    public string message;       // Nachricht, die angezeigt wird

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Prüft, ob der Spieler den Trigger erreicht
        {
            instructionText.text = message; // Setzt den Text
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            instructionText.text = ""; // Löscht den Text, wenn der Spieler den Trigger verlässt
        }
    }
}