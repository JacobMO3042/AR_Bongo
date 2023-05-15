using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
 public Material selectedMaterial; // creates a slot in the editor for the selected material
 private Material originalMaterial; // stores the original material
 public AudioClip audioClip; // creates a slot in the editor for a sound file
 private AudioSource audioSource; // create audio playback functionality
 private Vector3 ScaleChange; // the amount the scale will be changed by
 // Start is called before the first frame update
 void Start()
 {
    ScaleChange = new Vector3(0.01f,0.01f,0.01f);
 // setup audio playback
 audioSource = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;
 audioSource.clip = audioClip;
 // store reference to current material
 originalMaterial = gameObject.GetComponent<MeshRenderer>().material;
 }
 // public methods that will be expose to the Event Trigger system
 public void playAudio(){
 audioSource.Play();
 }
 public void setSelectedMaterial(){
 gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
 }
 public void setOriginalMaterial(){
 gameObject.GetComponent<MeshRenderer>().material = originalMaterial;
 }
    public void Grow(){
    gameObject.transform.localScale += ScaleChange; // increase size
    }
    public void Shrink(){
    gameObject.transform.localScale -= ScaleChange; // decrease size
}
}