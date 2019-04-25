﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScreenPoint : MonoBehaviour
{
    public Camera mainCam;
    public Camera verticalSpaceCam;
    
    public GameObject[] note;
    public GameObject verticalAxis;
    public GameObject collisionLine;

    public Transform verticalAxisParent;
    public Transform noteParent;

    float[] notePose;

    //void OnDrawGizmosSelected()
    //{
    //    Vector3 p = verticalSpaceCam.ScreenToWorldPoint(new Vector3(0, 0, verticalSpaceCam.nearClipPlane));
    //    Gizmos.color = Color.yellow;
    //    Gizmos.DrawSphere(p, 0.1f);
    //}
    private void OnEnable()
    {
        TF.Scene.Play.Started += StartPlay;
        //TF.Scene.Play.Updated += UpdatePlay;
        //TF.Scene.Play.Ended += EndedPlay;
    }

    private void OnDisable()
    {
        TF.Scene.Play.Started -= StartPlay;
        //TF.Scene.Play.Updated -= UpdatePlay;
        //TF.Scene.Play.Ended -= EndedPlay;
    }

    private void StartPlay()
    {
        mainCam = GetComponent<Camera>();

        Instantiate(collisionLine, new Vector3(0, -1.5f, 10f), Quaternion.identity);

        float noteSpace = verticalSpaceCam.pixelWidth / note.Length;
        float noteHeight = 0-(verticalSpaceCam.pixelHeight/10f);

        float notePosX1 = ((noteSpace * 2) - noteSpace) * 0.5f;
        float notePosX2 = ((noteSpace * 4) - noteSpace) * 0.5f;
        float notePosX3 = ((noteSpace * 6) - noteSpace) * 0.5f;
        float notePosX4 = ((noteSpace * 8) - noteSpace) * 0.5f;
        float notePosX5 = ((noteSpace * 10) - noteSpace) * 0.5f;
        float notePosX6 = ((noteSpace * 12) - noteSpace) * 0.5f;
        float notePosX7 = ((noteSpace * 14) - noteSpace) * 0.5f;
        float notePosX8 = ((noteSpace * 16) - noteSpace) * 0.5f;
        float notePosX9 = ((noteSpace * 18) - noteSpace) * 0.5f;
        float notePosX10 = ((noteSpace * 20) - noteSpace) * 0.5f;
        float notePosX11 = ((noteSpace * 22) - noteSpace) * 0.5f;
        float notePosX12 = ((noteSpace * 24) - noteSpace) * 0.5f;
        float notePosX13 = ((noteSpace * 26) - noteSpace) * 0.5f;
        float notePosX14 = ((noteSpace * 28) - noteSpace) * 0.5f;
        float notePosX15 = ((noteSpace * 30) - noteSpace) * 0.5f;

        Instantiate(verticalAxis, (verticalSpaceCam.ScreenToWorldPoint(new Vector3 (0f, 0f, 10f))), Quaternion.identity, verticalAxisParent);

        for (int i = 0; i < note.Length + 1; i++)
        {
            Instantiate(verticalAxis, (verticalSpaceCam.ScreenToWorldPoint(new Vector3(verticalSpaceCam.pixelWidth / note.Length * i, 0f, 10f))), Quaternion.identity, verticalAxisParent);
        }

        Instantiate(note[0], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX1, noteHeight, 10f))), Quaternion.identity, noteParent);
        Instantiate(note[1], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX2, noteHeight, 10f))), Quaternion.identity, noteParent);
        Instantiate(note[2], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX3, noteHeight, 10f))), Quaternion.identity, noteParent);
        Instantiate(note[3], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX4, noteHeight, 10f))), Quaternion.identity, noteParent);
        Instantiate(note[4], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX5, noteHeight, 10f))), Quaternion.identity, noteParent);
        Instantiate(note[5], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX6, noteHeight, 10f))), Quaternion.identity, noteParent);
        Instantiate(note[6], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX7, noteHeight, 10f))), Quaternion.identity, noteParent);
        Instantiate(note[7], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX8, noteHeight, 10f))), Quaternion.identity, noteParent); 
        Instantiate(note[8], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX9, noteHeight, 10f))), Quaternion.identity, noteParent);
        Instantiate(note[9], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX10, noteHeight, 10f))), Quaternion.identity, noteParent);
        Instantiate(note[10], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX11, noteHeight, 10f))), Quaternion.identity, noteParent);
        Instantiate(note[11], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX12, noteHeight, 10f))), Quaternion.identity, noteParent);
        Instantiate(note[12], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX13, noteHeight, 10f))), Quaternion.identity, noteParent);
        Instantiate(note[13], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX14, noteHeight, 10f))), Quaternion.identity, noteParent); 
        Instantiate(note[14], (verticalSpaceCam.ScreenToWorldPoint(new Vector3(notePosX15, noteHeight, 10f))), Quaternion.identity, noteParent);


    }
}