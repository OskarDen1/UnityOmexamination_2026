 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using TMPro;

 public class Dialogue : SceneHandler
 {
     public TextMeshProUGUI textComponent;
     public string[] lines;
     public float textSpeed;
     private int Index;
     void Start()
     {
         textComponent.text = string.Empty;
         StartDialogue();
     }

     void Update()
     {
         if (Input.GetMouseButton(0))
         {
             if (textComponent.text == lines[Index])
             {
                 NextLine();
             }
             else
             {
                 StopAllCoroutines();
                 textComponent.text = lines[Index];
             }
         }
     }

     void StartDialogue()
     {
         Index = 0;
         StartCoroutine(TypeLine());
     }

     IEnumerator TypeLine()
     {
         foreach (char c in lines[Index].ToCharArray())
         {
             textComponent.text += c;
             yield return new WaitForSeconds(textSpeed);
         }
     }

     void NextLine()
     {
         if (Index < lines.Length - 1)
         {
             Index++;
             textComponent.text = string.Empty;
             StartCoroutine(TypeLine());
         }
         else
         {
             gameObject.SetActive(false);
             LoadGameScene();
         }
     }
 }