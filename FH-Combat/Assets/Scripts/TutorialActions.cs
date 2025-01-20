using UnityEngine;
using TMPro; // F�r TextMeshPro
using UnityEngine.SceneManagement;

public class TutorialActions : MonoBehaviour
{
    public TMP_Text instructionText; // Referenz zum UI-Text
    private int step = 0; // Aktuelle Tutorial-Phase
    private int punchCounter = 0; // Z�hler f�r Punches (J)
    private int kickCounter = 0; // Z�hler f�r Kicks (K)

    void Update()
    {
        switch (step)
        {
            case 0: // Bewegung lernen
                if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
                {
                    instructionText.text = "Press S to block";
                    step++;
                }
                break;

            case 1: // Blocken lernen
                if (Input.GetKeyDown(KeyCode.S))
                {
                    instructionText.text = "Press J to punch and press J multiple times for a combo";
                    step++;
                }
                break;

            case 2: // Punches lernen (3x J dr�cken)
                if (Input.GetKeyDown(KeyCode.J))
                {
                    punchCounter++; // Erh�he den Punch-Z�hler
                    if (punchCounter >= 3) // Wenn J 3-mal gedr�ckt wurde
                    {
                        instructionText.text = "Press K to kick and press K multiple times for a combo";
                        step++;
                        punchCounter = 0; // Z�hler zur�cksetzen
                    }
                }
                break;

            case 3: // Kicks lernen (3x K dr�cken)
                if (Input.GetKeyDown(KeyCode.K))
                {
                    kickCounter++; // Erh�he den Kick-Z�hler
                    if (kickCounter >= 3) // Wenn K 3-mal gedr�ckt wurde
                    {
                        instructionText.text = "Press SPACE to jump";
                        step++;
                        kickCounter = 0; // Z�hler zur�cksetzen
                    }
                }
                break;

            case 4: // Springen lernen
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    instructionText.text = "While pressing A or D, press Left Shift to sprint";
                    step++;
                }
                break;

            case 5: // Sprinten lernen
                if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.LeftShift) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
                {
                    instructionText.text = "Great job! Tutorial completed. Press ENTER to exit.";
                    step++;
                }
                break;

            case 6: // Wechsel zur n�chsten Szene
                if (Input.GetKeyDown(KeyCode.Return)) // Return = Enter-Taste
                {
                    SceneManager.LoadScene("LevelMap");
                }
                break;
        }
    }
}
